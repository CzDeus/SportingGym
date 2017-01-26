using Sporting_Gym.App_Code.Entity_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporting_Gym.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;
using Sporting_Gym.App_Code.Utility;

namespace Sporting_Gym.Forms
{
    public partial class Actualizar_Instructor : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        private List<object> listCampos = null;

        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice FuenteDeVideo;
        private bool encendido = false;
        private Image myimage = null;

        public int id_instructor = 0;
        private bool estatus = false;

        bool bandera = false;
        public Actualizar_Instructor(bool bandera)
        {
            InitializeComponent();

            lista_campos();
        }

        //LLENA CAMPOS CON LOS DATOS GUARDADOS
        public Actualizar_Instructor(int id_instructor, bool bandera)
        {
            InitializeComponent();

            lista_campos();

            this.bandera = bandera;
            this.id_instructor = id_instructor;

            if (bandera == true)
            {
                encabezado_label.Text = "Edicion Instructor";

                var contexto = new db_sporting_gymContainer();

                var datos_instructor = (from x in contexto.Catalogo_Instructores where x.id_instructor == id_instructor select x).ToList();

                apellido_paterno_textBox.Text = datos_instructor[0].apellido_paterno;
                apellido_materno_textBox.Text = datos_instructor[0].apellido_materno;
                nombre_textBox.Text = datos_instructor[0].nombre;
                fecha_nacimiento_dateTimePicker.Text = datos_instructor[0].fecha_nacimiento.ToString();
                sexo_comboBox.Text = datos_instructor[0].sexo;

                correo_textBox.Text = datos_instructor[0].correo;
                //telefono_fijo_textBox.Text = Convert.ToString(datos_instructor[0].telefono);
                telefono_celular_textBox.Text = Convert.ToString(datos_instructor[0].celular);

                calle_textBox.Text = datos_instructor[0].calle;
                numero_textBox.Text = Convert.ToString(datos_instructor[0].numero);
                colonia_textBox.Text = datos_instructor[0].colonia;

                if (datos_instructor[0].estatus == false)
                {
                    inactivo_radioButton.Checked = true;
                }
                else
                {
                    activo_radioButton.Checked = true;
                }

                var data = (Byte[])datos_instructor[0].foto;
                var stream = new MemoryStream(data);
                videoSourcePlayer1.BackgroundImage = Image.FromStream(stream);

                myimage = Image.FromStream(stream);

                if (datos_instructor[0].estatus == true)
                {
                    activo_radioButton.Checked = true;
                }

                Llenar_Historial_Archivos();
            }
        }

        private void Actualizar_Instructor_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo x in dispositivos)
            {
                dispositivos_comboBox.Items.Add(x.Name);
            }

            dispositivos_comboBox.SelectedIndex = 0;

            var contexto = new db_sporting_gymContainer();

            if (id_instructor == 0)
            {
                sexo_comboBox.SelectedIndex = 0;
            }
        }

        private int calcular_edad()
        {
            int edad = DateTime.Now.Year - fecha_nacimiento_dateTimePicker.Value.Year;

            if (DateTime.Now.Month < fecha_nacimiento_dateTimePicker.Value.Month)
            {
                edad--;
            }

            return edad;
        }

        private void buscar_instructor_button_Click(object sender, EventArgs e)
        {
            var contexto = new db_sporting_gymContainer();

            if (apellido_paterno_textBox.Text == "")
            {
                MessageBox.Show("Ingrese apellidos paterno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var verificar = contexto.sp_Buscar_Instructor(nombre_textBox.Text).ToList();

                if (verificar.Count != 0)
                {
                    Buscar_Cliente buscar_cliente = new Buscar_Cliente(nombre_textBox.Text, apellido_paterno_textBox.Text, false);
                    buscar_cliente.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro el instructor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar_button_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < listCampos.Count; x++)
            {
                if (listCampos[x].GetType().Name == "TextBox")
                {
                    TextBox txt = (TextBox)listCampos[x];
                    txt.Text = "";

                }
                else
                    if (listCampos[x].GetType().Name == "MaskedTextBox")
                {
                    MaskedTextBox txt = (MaskedTextBox)listCampos[x];
                    txt.Text = "";
                }

                videoSourcePlayer1.BackgroundImage = null;
            }
        }

        public void recibe_datos(string ape_paterno, string ape_materno, string nombre, DateTime fecha_nac, string sexo, string calle, string numero, string colonia, string correo, string celular, DateTime fecha_ingreso, bool estatus, DateTime ultima_asistencia, int id_tipo_cliente, Image foto)
        {
            apellido_paterno_textBox.Text = ape_paterno;
            apellido_materno_textBox.Text = ape_materno;
            nombre_textBox.Text = nombre;
            sexo_comboBox.Text = sexo;
            calle_textBox.Text = calle;
            numero_textBox.Text = numero;
            colonia_textBox.Text = colonia;
            correo_textBox.Text = correo;
            //telefono_fijo_textBox.Text = telefono;
            telefono_celular_textBox.Text = celular;
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            var contexto = new db_sporting_gymContainer();

            if (activo_radioButton.Checked == true)
            {
                estatus = true;
            }
            else
            {
                estatus = false;
            }

            if (VerificarCamposVacios(listCampos) || sexo_comboBox.Text == "Seleccione el sexo" || myimage == null || telefono_celular_textBox.MaskFull == false)
            {
                MessageBox.Show("Queda campos vacios", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MemoryStream IO = new MemoryStream();
                myimage.Save(IO, ImageFormat.Jpeg);
                if (bandera == false)
                {
                    Catalogo_Instructores cataIntruc = new Catalogo_Instructores();

                    cataIntruc.apellido_paterno = apellido_paterno_textBox.Text;
                    cataIntruc.apellido_materno = apellido_materno_textBox.Text;
                    cataIntruc.nombre = nombre_textBox.Text;
                    cataIntruc.fecha_nacimiento = Convert.ToDateTime(fecha_nacimiento_dateTimePicker.Text);
                    cataIntruc.sexo = sexo_comboBox.Text;
                    cataIntruc.edad = calcular_edad();
                    cataIntruc.calle = calle_textBox.Text;
                    cataIntruc.numero = numero_textBox.Text;
                    cataIntruc.colonia = colonia_textBox.Text;
                    cataIntruc.correo = correo_textBox.Text;
                    //cataIntruc.telefono = telefono_fijo_textBox.Text;
                    cataIntruc.celular = telefono_celular_textBox.Text;
                    cataIntruc.fecha_ingreso = DateTime.Now;

                    if (activo_radioButton.Checked)
                    {
                        cataIntruc.estatus = true;
                    }
                    else
                    {
                        cataIntruc.estatus = false;
                    }
                    cataIntruc.foto = IO.ToArray();

                    contexto.Catalogo_Instructores.Add(cataIntruc);
                    contexto.SaveChanges();

                    MessageBox.Show("Instructor Registrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (bandera == true)
                {
                    contexto.sp_Actualizar_Instructor(id_instructor, apellido_paterno_textBox.Text, apellido_materno_textBox.Text,
                        nombre_textBox.Text, Convert.ToDateTime(fecha_nacimiento_dateTimePicker.Text),
                        sexo_comboBox.Text, calcular_edad(), calle_textBox.Text,
                        numero_textBox.Text, colonia_textBox.Text, correo_textBox.Text,
                     telefono_celular_textBox.Text, IO.ToArray(), estatus);

                    MessageBox.Show("Instructor actualizado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void cambiar_estatus(object sender, EventArgs e)
        {
            if (activo_radioButton.Checked)
            {
                estatus = true;
            }
            else if (inactivo_radioButton.Checked)
            {
                estatus = false;
            }
        }

        //FOTOS
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

        private void tomar_foto_button_Click(object sender, EventArgs e)
        {
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

        private void Registro_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Catalogos cargar = new Catalogos();

            cargar.carga_gridview("");

            if (FuenteDeVideo != null)
            {
                FuenteDeVideo.SignalToStop();
                FuenteDeVideo = null;
            }
        }

        //CAMPOS
        private void lista_campos()
        {
            listCampos = new List<object>()
            {
                apellido_paterno_textBox,
                apellido_materno_textBox,
                nombre_textBox,
                calle_textBox,
                numero_textBox,
                colonia_textBox,
                correo_textBox,
                telefono_celular_textBox,
                //telefono_fijo_textBox
            };
        }

        private bool VerificarCamposVacios(List<object> listCampos)
        {
            bool vacio = false;

            for (int x = 0; x < listCampos.Count; x++)
            {
                if (listCampos[x].GetType().Name == "TextBox")
                {
                    TextBox txt = (TextBox)listCampos[x];
                    if (txt.Text == "")
                    {
                        vacio = true;
                        break;
                    }
                }
                else if (listCampos[x].GetType().Name == "MaskedTextBox")
                {
                    MaskedTextBox txt = (MaskedTextBox)listCampos[x];
                    if (txt.Text == "")
                    {
                        vacio = true;
                        break;
                    }
                }
            }

            return vacio;
        }

        private void elimnar_button_Click(object sender, EventArgs e)
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();

            if (bandera == true)
            {
                contexto.sp_Eliminar_Instructor_Catalogo(id_instructor);
                MessageBox.Show("Se elimino el instructor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void capturar_huella_button_Click(object sender, EventArgs e)
        {
            if (id_instructor != 0)
            {
                Leer_Huella frm = new Leer_Huella(id_instructor, false);
                //Stop();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Registre o busque cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void historial_button_Click(object sender, EventArgs e)
        {
            Historial_Asistencias historial = new Historial_Asistencias(id_instructor, true);
            historial.Show();
        }

        private void Adjuntar_button_Click(object sender, EventArgs e)
        {
            Captura_Archivo archivos = new Captura_Archivo(id_instructor, 2);
            archivos.ShowDialog();
            Llenar_Historial_Archivos();
        }

        private void Llenar_Historial_Archivos()
        {
            var archivos = (from buscar in contexto.Archivos_Clientes where buscar.id_cliente == id_instructor && buscar.tipo_cliente == 2 select buscar).ToList();
            archivos_dataGridView.DataSource = archivos;
            archivos_dataGridView.Columns[0].Visible = false;
            archivos_dataGridView.Columns[1].Visible = false;
            archivos_dataGridView.Columns[2].Visible = false;
        }

        private void archivos_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex <= -1)
                return;

            int id_imagen = Convert.ToInt32(archivos_dataGridView[0, e.RowIndex].Value);

            Visor_Imagenes ver = new Visor_Imagenes(id_imagen);
            ver.ShowDialog();

            Llenar_Historial_Archivos();
        }
    }
}
