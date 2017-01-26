using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;
using Sporting_Gym.App_Code.Entity_Model;

namespace Sporting_Gym.Forms
{
    public partial class Captura_Archivo : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        private VideoCaptureDevice FuenteDeVideo;
        private Image myimage;
        private bool encendido = false;
        private FilterInfoCollection dispositivos;
        private int id_cliente;
        private int tipo_persona;

        public Captura_Archivo()
        {
            InitializeComponent();
        }

        public Captura_Archivo(int id_cliente, int tipo_persona)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            this.tipo_persona = tipo_persona;
        }

        private void tomar_foto_button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            try
            {
                SaveFileDialog sf = new SaveFileDialog();

                sf.Filter = "Imagenes JPG | *.jpg";

                //sf.FileName = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Sporting_Gym\Sporting_Gym\Img\Clientes\" +
                //    apellido_paterno_textBox.Text + nombre_textBox.Text + DateTime.Now.ToString("dd-mm-yyyy") + ".jpg";

                Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();


                //img.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                //img.Dispose();

                FuenteDeVideo.SignalToStop();
                FuenteDeVideo = null;

                //Image myimage = new Bitmap(sf.FileName);
                myimage = img;
                videoSourcePlayer1.BackgroundImage = myimage;

                encendido = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en tomar foto");
            }
        }

        private void encender_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (encendido == false)
                {
                    FuenteDeVideo = new VideoCaptureDevice(dispositivos[dispositivos_comboBox.SelectedIndex].MonikerString);

                    videoSourcePlayer1.VideoSource = FuenteDeVideo;

                    videoSourcePlayer1.Start();

                    encendido = true;
                }
                else
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                    encendido = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la camara");

                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1 = null;

                FuenteDeVideo = null;
            }
        }

        private void Captura_Archivo_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo x in dispositivos)
            {
                dispositivos_comboBox.Items.Add(x.Name);
            }

            try
            {
                dispositivos_comboBox.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Instale un dispositivo de video", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (myimage != null && nombre_archivo_textBox.Text != "") {
                MemoryStream IO = new MemoryStream();
                myimage.Save(IO, ImageFormat.Jpeg);

                Archivos_Clientes archivos = new Archivos_Clientes();

                archivos.archivo = IO.ToArray();
                archivos.id_cliente = id_cliente;
                archivos.nombre_imagen = nombre_archivo_textBox.Text;
                archivos.fecha = DateTime.Now;
                archivos.tipo_cliente = tipo_persona;

                contexto.Archivos_Clientes.Add(archivos);

                contexto.SaveChanges();

                this.Close();
            }else
            {
                MessageBox.Show("Verifique camara o falta informacion");
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
