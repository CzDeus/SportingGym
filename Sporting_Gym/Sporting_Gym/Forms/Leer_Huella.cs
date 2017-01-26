using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporting_Gym.App_Code.Entity_Model;
using System.IO;
using DPFP;
using Sporting_Gym.App_Code.Utility;

namespace Sporting_Gym.Forms
{
    delegate void Function();

    public partial class Leer_Huella : Form, DPFP.Capture.EventHandler
    {
        protected List<Catalogo_Clientes> List_Usuarios = new List<Catalogo_Clientes>();

        private static db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        //public delegate void OnTemplateEventHandler(DPFP.Template template);

        int id_cliente = 0;
        bool persona;

        int intentos = 4;

        delegate void contador();

        private Registro_Cliente huella;

        public Leer_Huella(int id_cliente, bool persona)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            this.persona = persona;
            //MessageBox.Show(id_cliente.ToString());
        }

        private void Leer_Huella_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            List_Usuarios = contexto.Catalogo_Clientes.Select(x => x).ToList();
            Init();
            Start();

            intentos_label.Text = Convert.ToString(intentos);
            
        }

        protected void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                {
                    Capturer.EventHandler = this;                  // Subscribe for capturing events.
                }
                else
                {
                    //SetPrompt("Can't initiate capture operation!");
                }
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Enroller = new DPFP.Processing.Enrollment();            // Create an enrollment.
            UpdateStatus();
        }
       
        protected void Process(DPFP.Sample Sample)
        {
            contador desplegar = new contador(Change_Label);

            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));

            //Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    //MakeReport("The fingerprint feature set was created.");
                    try
                    {
                        Enroller.AddFeatures(features);     // Add feature set to template.
                        //intentos_label.Text = Convert.ToString(intentos - 1);
                        this.Invoke(desplegar);
                    }
                    catch
                    {
                        MessageBox.Show("Error al capturar, vuelva a intentar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        intentos = 4;
                        mensaje_label.Text = Convert.ToString(intentos);
                    }

                }

                finally
                {
                    UpdateStatus();

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
                            OnTemplate(Enroller.Template);
                            //SetPrompt("Click Close, and then click Fingerprint Verification.");
                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            //OnTemplate(null);
                            Start();
                            break;
                    }
                }
        }

        public void Change_Label()
        {
            intentos -= 1;
            intentos_label.Text = Convert.ToString(intentos);

            if(intentos == 0)
            {
                intentos_label.Text = "Listo";
            }
        }
        
        private void UpdateStatus()
        {
            // Show number of samples needed.
            //SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }

        private DPFP.Processing.Enrollment Enroller;

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    //SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    //SetPrompt("Can't initiate capture!");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    //SetPrompt("Can't terminate capture!");
                }
            }
        }

        #region Form Event Handlers:

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            //Init();
            //Start();                                                // Start capture operation.
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
        #endregion

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            //MakeReport("The fingerprint sample was captured.");
            //SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
            {
                //MakeReport("The quality of the fingerprint sample is good.");
            }
            else
            {
                //MakeReport("The quality of the fingerprint sample is poor.");
            }
        }
        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                //StatusLine.Text = status;
            }));
        }

        protected void SetPrompt(string prompt)
        {
            //this.Invoke(new Function(delegate ()
            //{
            //    //Prompt.Text = prompt;
            //}));
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                //StatusText.AppendText(message + "\r\n");
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            //contador desplegar = new contador(Change_Label);

            this.Invoke(new Function(delegate ()
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box
                //this.Invoke(desplegar);
            }));
        }

        private DPFP.Capture.Capture Capturer;
        

        protected void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("Huellas registradas.", "Sporting Gym");

                    byte[] bytes = new byte[1632];
                    Template.Serialize(ref bytes);

                    //int valor = Convert.ToInt32(Clientes_comboBox.SelectedValue);
                    
                    if(persona == true)
                    {
                        var huellas = (from x in contexto.Catalogo_Clientes where x.id_cliente == id_cliente select x).Single();

                            huellas.huella = bytes;
                            contexto.SaveChanges();

                    }else if(persona == false)
                    {
                        var huellas = (from x in contexto.Catalogo_Instructores where x.id_instructor == id_cliente select x).Single();

                            huellas.huella = bytes;
                            contexto.SaveChanges();
                        
                    }

                    contexto.sp_Actualizar_Huella(id_cliente, bytes, persona);

                    this.Close();

                }
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;

        private void Leer_Huella_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        //private void guardar_button_Click(object sender, EventArgs e)
        //{
        //    byte[] bytes = new byte[1632];
        //    Template.Serialize(ref bytes);

        //    //int valor = Convert.ToInt32(Clientes_comboBox.SelectedValue);

        //    contexto.sp_Actualizar_Huella(id_cliente, bytes);
        //}

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
