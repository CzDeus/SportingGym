using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporting_Gym_Check.App_Code.Entity_Model;
using System.IO;
using System.Drawing.Imaging;
using Sporting_Gym_Check.App_Code.Models;
using Sporting_Gym_Check.App_Code.Utility;
using DPFP.Capture;

namespace Sporting_Gym_Check
{
    public partial class Checador : Form, DPFP.Capture.EventHandler
    {
        public Capture capture { get; set; } = new Capture();

        private static db_sporting_gymEntities contexto = new db_sporting_gymEntities();
        //private List<csCliente> List_Usuarios = new List<csCliente>();

        int id_usuario_anterior = 0;
        int id_usuario = 0;

        int id_responsable = 0;

        string tipo_persona = "";
        string tipo_persona_anterior = "";

        bool casi = false;

        Double total = 0;

        int valor = 0;

        List<sp_Lista_Checador_Result> lista = new List<sp_Lista_Checador_Result>();

        //List<Object_Checado> listObject = new List<Object_Checado>();

        delegate void imprimir(Object_Checado listObject);

        public Checador()
        {
            InitializeComponent();
        }

        public Checador(int id_responsable)
        {
            InitializeComponent();

            this.id_responsable = id_responsable;
        }

        #region Form Event Handlers:
        private void Checador_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            this.Init();
            this.Start();

            Verificator = new DPFP.Verification.Verification();

            var today = DateTime.Today;

            //List_Usuarios = (from cliente in contexto.Lista_Checador select new csCliente() {id_Cliente = cliente.id_usuario.Value, fingerPrint = cliente.huella}).ToList<csCliente>();

            //for(int x = 0; x < lista)

            lista = contexto.sp_Lista_Checador().ToList();

            int a = lista.Count;
        }

        private void Checador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Stop();
        }
        #endregion

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

                imprimir imprimir = new imprimir(mostrar_info);

                for (int x = 0; x < lista.Count; x++)
                {
                    DPFP.Template templeate = new DPFP.Template();

                    //if (lista[x].huella == null)
                    //{
                    //    return;
                    //}

                    templeate.DeSerialize(lista[x].huella);

                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                    Verificator.Verify(features, templeate, ref result);

                    if (result.Verified)
                    {
                        id_usuario = lista[x].id_cliente;
                        tipo_persona = lista[x].tipo;

                        if (tipo_persona == "Cliente")
                        {
                            if (id_usuario == id_usuario_anterior && tipo_persona == tipo_persona_anterior)
                            {

                            }
                            else
                            {
                                var fecha = contexto.sp_Buscar_Clientes_Id(id_usuario).ToList();

                                //if()
                                valor = verificar_vencimiento(Convert.ToDateTime(fecha[0].fecha_corte));
                                //var usuario = (from cliente in contexto.Catalogo_Clientes where cliente.id_cliente == id_usuario select cliente).Single();

                                var data = (Byte[])fecha[0].foto;
                                var stream = new MemoryStream(data);
                                Foto_videoSourcePlayer.BackgroundImage = Image.FromStream(stream);

                                this.Invoke(imprimir, new Object_Checado() { nombre = fecha[0].nombre, valor = valor, fecha = Convert.ToDateTime(fecha[0].fecha_corte) });

                                id_usuario_anterior = id_usuario;
                                tipo_persona_anterior = tipo_persona;

                                timer1.Start();
                            }
                        }
                        else if (tipo_persona == "Instructor")
                        {
                            if (id_usuario == id_usuario_anterior && tipo_persona == tipo_persona_anterior)
                            {

                            }
                            else
                            {
                                var estatus = contexto.sp_Buscar_Instructor_Id(id_usuario).First();

                                if (estatus.estatus == true)
                                {
                                    contexto.sp_Registro_Ingreso(id_usuario, true, true, id_responsable);
                                }
                                else if (estatus.estatus == false)
                                {
                                    contexto.sp_Registro_Ingreso(id_usuario, true, false, id_responsable);
                                }

                                var usuario = (from cliente in contexto.Catalogo_Instructores where cliente.id_instructor == id_usuario select cliente).First();

                                var data = (Byte[])usuario.foto;
                                var stream = new MemoryStream(data);
                                Foto_videoSourcePlayer.BackgroundImage = Image.FromStream(stream);

                                valor = 2;

                                this.Invoke(imprimir, new Object_Checado() { nombre = usuario.nombre, valor = valor });

                                id_usuario_anterior = id_usuario;
                                tipo_persona_anterior = tipo_persona;

                                timer1.Start();
                            }
                        }
                        return;
                    }
                }

                this.Invoke(imprimir, new Object_Checado() { nombre = "Desconocido", valor = 0 });
                color_pictureBox.BackColor = Color.White;
                Foto_videoSourcePlayer.BackgroundImage = Properties.Resources.Desconocido;
            }
        }

        private int verificar_vencimiento(DateTime fecha)
        {
            int comparar = DateTime.Compare(Convert.ToDateTime(fecha), DateTime.Now);

            DateTime a = Convert.ToDateTime(fecha);
            DateTime b = DateTime.Now;

            TimeSpan diferencia = a - b;
            double days = (int)diferencia.TotalDays;
            

            double d = a.Subtract(b).TotalDays;

            if (days < 0)
            {
                comparar = -1;
                color_pictureBox.BackColor = Color.Red;

                var estatus = (from x in contexto.Catalogo_Clientes where x.id_cliente == id_usuario select x).Single();

                estatus.estatus = false;

                contexto.SaveChanges();

                contexto.sp_Registro_Ingreso(id_usuario, false, false, id_responsable);

                valor = 1;
            }
            else if (days >= 0)
            {
                contexto.sp_Registro_Ingreso(id_usuario, false, true, id_responsable);
                comparar = 1;

                if (d < 5)
                {
                    color_pictureBox.BackColor = Color.Orange;
                    casi = true;
                }
                else
                {
                    color_pictureBox.BackColor = Color.Green;
                    casi = false;
                }

                valor = 2;
            }

            return valor;
        }

        public void mostrar_info(Object_Checado listObject)
        {
            if(listObject.fecha.ToShortDateString() == "01/01/0001")
            {
                Fecha_Vencimiento_label.Visible = false;
                label4.Visible = false;
            }else
            {
                Fecha_Vencimiento_label.Visible = true;
                label4.Visible = true;
            }

            nombre_label.Text = listObject.nombre;

            Fecha_Vencimiento_label.Text = listObject.fecha.ToShortDateString();

            if (valor == 1)
            {
                mensaje_label.Text = "Pasar a renovar suscripción";
                Fecha_Vencimiento_label.BackColor = Color.Red;
            }
            else if (valor == 2)
            {
                mensaje_label.Text = "Bienvenido";
                if (casi == false)
                {
                    Fecha_Vencimiento_label.BackColor = Color.Green;
                }
                else if (casi == true)
                {
                    Fecha_Vencimiento_label.BackColor = Color.Orange;
                }
            }
            else if (valor == 0)
            {
                mensaje_label.Text = "Cliente no registrado";
                Fecha_Vencimiento_label.BackColor = Color.White;
            }

            fecha_checar_label.Text = DateTime.Now.ToString("dd-MM-yyyy");
            hora_checar_label.Text = DateTime.Now.ToLongTimeString();
            //Checador_Paint(null, null);
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

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imprimir imprimir = new imprimir(mostrar_info);

            total += 1;
            if (total == 50)
            {
                valor = 2;
                timer1.Stop();
                total = 0;
                Foto_videoSourcePlayer.BackgroundImage = Properties.Resources.Desconocido;
                this.Invoke(imprimir, new Object_Checado() { nombre = "", valor = valor });
                color_pictureBox.BackColor = Color.White;
                Fecha_Vencimiento_label.BackColor =  Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Recargar_button_Click(object sender, EventArgs e)
        {
            lista = contexto.sp_Lista_Checador().ToList();
        }
    }

    public class Object_Checado
    {
        public string nombre { get; set; }
        public int valor { get; set; }
        public DateTime fecha { get; set; }
    }
}
