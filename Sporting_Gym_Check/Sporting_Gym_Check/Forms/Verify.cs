using Sporting_Gym_Check.App_Code.Entity_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporting_Gym_Check.App_Code.Models;

namespace Sporting_Gym_Check.Forms
{
    public partial class Verify : Form, DPFP.Capture.EventHandler
    {
        private static db_Finger_ModelContainer contexto = new db_Finger_ModelContainer();
        private List<csCliente> List_Usuarios = new List<csCliente>();
    
        public Verify()
        {
            InitializeComponent();
        }

        private void Verify_Load(object sender, EventArgs e)
        {
            this.Init();
            this.Start();

            this.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();

            List_Usuarios = (from cliente in contexto.tb_Usuarios select new csCliente() { id_Cliente = cliente.id_usuario, fingerPrint = cliente.dedo }).ToList<csCliente>();
        }

        private void Verify_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Stop();
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();

                if (null != Capturer)
                    Capturer.EventHandler = this;
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            
            if (features != null)
            {
                byte[] bytes = new byte[1632];
                features.Serialize(ref bytes);

                for (int x = 0; x < List_Usuarios.Count; x++)
                {
                    DPFP.Template templeate = new DPFP.Template();
                    templeate.DeSerialize(List_Usuarios[x].fingerPrint);
                    
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    Verificator.Verify(features, templeate, ref result);

                    if (result.Verified)
                    {
                        int id_usuario = List_Usuarios[x].id_Cliente;
                        var usuario = (from cliente in contexto.tb_Usuarios where cliente.id_usuario == id_usuario select cliente).Single();
                        MessageBox.Show("VERIFICADO  " + usuario.nombre_usuario);
                        return;
                    }
                }

                MessageBox.Show("NO ENCONTRADO");
            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                }
                catch
                {
                    MessageBox.Show("No se pudo inicializar la captura");
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
                    MessageBox.Show("Ha finalizado la captura");
                }
            }
        }
        
        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
           
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MessageBox.Show("The quality of the fingerprint sample is good.");
            else
                MessageBox.Show("The quality of the fingerprint sample is poor.");
        }
        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Convertor.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }
        
        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);
            }));
        }

        private DPFP.Capture.Capture Capturer;
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
    }
}
