using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporting_Gym_Check.App_Code.Entity_Model;

namespace Sporting_Gym_Check.Forms
{
    delegate void Function();

    public partial class Usuario : Form, DPFP.Capture.EventHandler
    {
        private static db_Finger_ModelContainer contexto = new db_Finger_ModelContainer();
        protected List<tb_Usuarios> List_Usuarios = new List<tb_Usuarios>();

        private static db_sporting_gymEntities contexto2 = new db_sporting_gymEntities();

        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            List_Usuarios = contexto.tb_Usuarios.Select(x => x).ToList();
            Init();
            Start();

            llenar_comboBox();
        }

        private void llenar_comboBox()
        {
            List<Catalogo_Clientes> nombre_clientes = (from Catalogo_Clientes in contexto2.Catalogo_Clientes select Catalogo_Clientes).ToList();
            Clientes_comboBox.ValueMember = "id_cliente";
            Clientes_comboBox.DisplayMember = "nombre";
            Clientes_comboBox.DataSource = nombre_clientes;
        }


        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
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
                    SetPrompt("Can't terminate capture!");
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
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
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
            this.Invoke(new Function(delegate ()
            {
                //Prompt.Text = prompt;
            }));
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
            this.Invoke(new Function(delegate ()
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box
            }));
        }

        private DPFP.Capture.Capture Capturer;

        private void Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1632];
            Template.Serialize(ref bytes);

            //contexto.sp_Guardar_Dedo(bytes);

            /*tb_Usuarios Usuario = new tb_Usuarios();

            //Usuario.nombre_usuario = textBox1.Text;
            Usuario.dedo = bytes;

            contexto.tb_Usuarios.Add(Usuario);

            contexto.SaveChanges();*/

            //Catalogo_Clientes clientes = new Catalogo_Clientes();
            //clientes.huella = bytes;

            //contexto2.Catalogo_Clientes.Add(clientes);
            //contexto2.SaveChanges();

            int valor = Convert.ToInt32(Clientes_comboBox.SelectedValue);

            //contexto2.sp_Actualizar_Huella(valor, bytes);
        }

        protected void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                if (Template != null)
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;
    }
}
