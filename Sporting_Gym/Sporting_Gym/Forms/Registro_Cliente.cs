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
using Sporting_Gym.App_Code.Models;
using Sporting_Gym.App_Code.Utility;
using Sporting_Gym.App_Code.Entity_Model;


namespace Sporting_Gym.Forms
{
    public partial class Registro_Cliente : Form/*, DPFP.Capture.EventHandler*/
    {
        private static db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        private List<object> listCampos = null;

        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice FuenteDeVideo;
        private bool encendido = false;
        private Image myimage = null;
        private Image archivo = null;

        public int id_cliente = 0;

        private List<csCliente> List_Usuarios = new List<csCliente>();

        delegate void imprimir(int id);

        public bool huella = false;

        public Registro_Cliente()
        {
            InitializeComponent();
            lista_textbox();

            fondo_fecha_label.Visible = false;
            fecha_limite_label.Visible = false;
            fecha_label.Visible = false;

            eliminar_cliente_button.Visible = false;
            capturar_huella_button.Visible = false;

            //historial_button.Visible = false;
        }

        public Registro_Cliente(int id_cliente)
        {
            InitializeComponent();
            lista_textbox();

            capturar_huella_button.Visible = true;

            fondo_fecha_label.Visible = true;
            fecha_limite_label.Visible = true;
            fecha_label.Visible = true;

            eliminar_cliente_button.Visible = true;
            //historial_button.Visible = true;

            this.id_cliente = id_cliente;

            encabezado_label.Text = "EDITAR INFORMACION CLIENTE";
            registrar_button.Text = "Actualizar";

            var llenar = contexto.sp_Buscar_Clientes_Id(id_cliente).ToList();

            apellido_paterno_textBox.Text = llenar[0].apellido_paterno;
            apellido_materno_textBox.Text = llenar[0].apellido_materno;
            nombre_textBox.Text = llenar[0].nombre;
            fecha_nacimiento_dateTimePicker.Text = llenar[0].fecha_nacimiento.ToString();
            sexo_comboBox.Text = llenar[0].sexo;

            correo_textBox.Text = llenar[0].correo;
            //telefono_fijo_textBox.Text = llenar[0].telefono;
            telefono_celular_textBox.Text = llenar[0].celular;

            calle_textBox.Text = llenar[0].calle;
            numero_textBox.Text = llenar[0].numero;
            colonia_textBox.Text = llenar[0].colonia;

            tipo_sangre_textBox.Text = llenar[0].tipo_sangre;

            alergias_comboBox.Text = llenar[0].alergias;

            if (llenar[0].fecha_corte > DateTime.Today)
            {
                fecha_label.Text = Convert.ToDateTime(llenar[0].fecha_corte).ToString("dd/MM/yyyy");
            }
            else
            {
                fecha_label.Text = "Sin Accesso";
            }

            var data = (Byte[])llenar[0].foto;
            var stream = new MemoryStream(data);
            videoSourcePlayer1.BackgroundImage = Image.FromStream(stream);

            myimage = Image.FromStream(stream);

            Llenar_Historial_Archivos();
        }

        private void Llenar_Historial_Archivos()
        {
            //var historial2 = contexto.sp_Buscar_Historial_Pagos(id_cliente).ToList();

            var historial = (from buscar in contexto.Tabla_Pagos where buscar.id_cliente == id_cliente && buscar.fecha_cancelacion == null orderby buscar.fecha_corte descending select new { buscar.id_pago, buscar.fecha_pago, buscar.importe_pagado, buscar.fecha_corte }).ToList();

            historial_pagos_dataGridView.DataSource = historial;
            historial_pagos_dataGridView.Columns[0].Visible = false;

            var archivos = (from buscar in contexto.Archivos_Clientes where buscar.id_cliente == id_cliente && buscar.tipo_cliente == 1 select buscar).ToList();
            archivos_dataGridView.DataSource = archivos;
            archivos_dataGridView.Columns[0].Visible = false;
            archivos_dataGridView.Columns[1].Visible = false;
            archivos_dataGridView.Columns[2].Visible = false;
        }

        private void Registro_Cliente_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);


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

            if (id_cliente == 0)
            {
                sexo_comboBox.SelectedIndex = 0;
                alergias_comboBox.SelectedIndex = 0;
            }
        }

        private void Registro_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Stop();
        }

        private void registrar_button_Click(object sender, EventArgs e)
        {

            if (VerificarCamposVacios(listCampos) || sexo_comboBox.Text == "Seleccione el sexo" || myimage == null || telefono_celular_textBox.MaskFull == false)
                MessageBox.Show("Quedan campos vacios", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MemoryStream IO = new MemoryStream();
                myimage.Save(IO, ImageFormat.Jpeg);

                if (id_cliente == 0)
                {
                    Catalogo_Clientes cataClie = new Catalogo_Clientes();

                    cataClie.apellido_paterno = apellido_paterno_textBox.Text;
                    cataClie.apellido_materno = apellido_materno_textBox.Text;
                    cataClie.nombre = nombre_textBox.Text;
                    cataClie.fecha_nacimiento = Convert.ToDateTime(fecha_nacimiento_dateTimePicker.Text);
                    cataClie.sexo = sexo_comboBox.Text;
                    cataClie.edad = calcular_edad();
                    cataClie.calle = calle_textBox.Text;
                    cataClie.numero = numero_textBox.Text;
                    cataClie.colonia = colonia_textBox.Text;
                    cataClie.correo = correo_textBox.Text;
                    //cataClie.telefono = telefono_fijo_textBox.Text;
                    cataClie.celular = telefono_celular_textBox.Text;
                    cataClie.fecha_ingreso = DateTime.Now;
                    cataClie.estatus = false;
                    cataClie.foto = IO.ToArray();
                    cataClie.tipo_sangre = tipo_sangre_textBox.Text;
                    cataClie.id_grupo = 0;

                    cataClie.alergias = alergias_comboBox.Text;

                    contexto.Catalogo_Clientes.Add(cataClie);

                    contexto.SaveChanges();

                    id_cliente = cataClie.id_cliente;

                    encabezado_label.Text = "EDITAR INFORMACION CLIENTE";
                    registrar_button.Text = "Actualizar";

                    MessageBox.Show("Cliente registrado ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Leer_Huella frm = new Leer_Huella(id_cliente, true);
                    //Stop();
                    frm.ShowDialog();



                }
                else if (id_cliente != 0)
                {
                    var estatus = contexto.sp_Buscar_Clientes_Id(id_cliente).ToList();

                    contexto.sp_Actualizar_Cliente(id_cliente, nombre_textBox.Text, apellido_paterno_textBox.Text, apellido_materno_textBox.Text, Convert.ToDateTime(fecha_nacimiento_dateTimePicker.Text), sexo_comboBox.Text,
                        calcular_edad(), calle_textBox.Text, numero_textBox.Text, colonia_textBox.Text, correo_textBox.Text, telefono_celular_textBox.Text, IO.ToArray(), estatus[0].estatus);

                    MessageBox.Show("Informacion Actualizada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        private void Registro_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FuenteDeVideo != null)
            {
                FuenteDeVideo.SignalToStop();
                FuenteDeVideo = null;
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

        private void buscar_cliente_button_Click(object sender, EventArgs e)
        {
            if (apellido_paterno_textBox.Text == "")
            {
                MessageBox.Show("Ingrese apellidos paterno", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var verificar = contexto.sp_Buscar_Cliente(nombre_textBox.Text).ToList();

                if (verificar.Count != 0)
                {
                    Buscar_Cliente buscar_cliente = new Buscar_Cliente(nombre_textBox.Text, apellido_paterno_textBox.Text, true);
                    buscar_cliente.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encontro el cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cobrar_button_Click(object sender, EventArgs e)
        {
            var periodos = (from leer_periodos in contexto.Catalogo_Periodos select leer_periodos).ToList();
            var tipos_cliente = (from leer_tipo_cliente in contexto.Catalogo_Tipos_Clientes select leer_tipo_cliente).ToList();
            var metodos = (from leer_metodos in contexto.Catalogo_Metodos_Pagos select leer_metodos).ToList();

            if (periodos.Count != 0 && tipos_cliente.Count != 0 && metodos.Count != 0)
            {
                if (id_cliente != 0)
                {
                    var id_grupo_cliente = (from id in contexto.Catalogo_Clientes where id.id_cliente == id_cliente select id.id_grupo).First();

                    if (id_grupo_cliente == 0)
                    {
                        Cobro cobrar = new Cobro(id_cliente);
                        cobrar.ShowDialog();
                    }
                    else
                    {
                        var responsable = (from res in contexto.Grupos where res.id_cliente_responsable == id_cliente select res).ToList();
                        if (responsable.Count != 0)
                        {
                            Cobro cobrar = new Cobro(id_cliente);
                            cobrar.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("El cliente pertenece a un grupo, no tiene permiso para realizar pago", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se tiene cliente seleccionado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Verifique sus catalogos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lista_textbox()
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
                telefono_celular_textBox
            };
        }

        //CAMARA
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

        private void adjuntar_button_Click(object sender, EventArgs e)
        {
            if (id_cliente != 0)
            {
                Captura_Archivo archivo = new Captura_Archivo(id_cliente, 1);
                archivo.ShowDialog();
                Llenar_Historial_Archivos();
            }
            else
            {
                MessageBox.Show("No se tiene cliente seleccionado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //try
            //{
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error en el archivo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void historial_pagos_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            int id_pago = Convert.ToInt32(historial_pagos_dataGridView[0, e.RowIndex].Value);

            Ficha_Historial ver_datos = new Ficha_Historial(id_pago);
            ver_datos.ShowDialog();
        }

        private void capturar_huella_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_cliente != 0)
                {
                    Leer_Huella frm = new Leer_Huella(id_cliente, true);
                    //Stop();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Registre o busque cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                (new ObjectBase()).LogError(ex.Message + ex.StackTrace);
            }

        }

        public void Registro_Cliente2(int id_cliente)
        {
            lista_textbox();

            this.id_cliente = id_cliente;

            eliminar_cliente_button.Visible = true;

            encabezado_label.Text = "EDITAR INFORMACION CLIENTE";
            registrar_button.Text = "Actualizar";

            var llenar = contexto.sp_Buscar_Clientes_Id(id_cliente).ToList();

            apellido_paterno_textBox.Text = llenar[0].apellido_paterno;
            apellido_materno_textBox.Text = llenar[0].apellido_materno;
            nombre_textBox.Text = llenar[0].nombre;
            fecha_nacimiento_dateTimePicker.Text = llenar[0].fecha_nacimiento.ToString();
            sexo_comboBox.Text = llenar[0].sexo;

            correo_textBox.Text = llenar[0].correo;
            telefono_celular_textBox.Text = llenar[0].celular;

            calle_textBox.Text = llenar[0].calle;
            numero_textBox.Text = llenar[0].numero;
            colonia_textBox.Text = llenar[0].colonia;

            tipo_sangre_textBox.Text = llenar[0].tipo_sangre;

            alergias_comboBox.Text = llenar[0].alergias;

            var data = (Byte[])llenar[0].foto;
            var stream = new MemoryStream(data);
            videoSourcePlayer1.BackgroundImage = Image.FromStream(stream);

            myimage = Image.FromStream(stream);

            Llenar_Historial_Archivos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prueba_Huella prueba = new Prueba_Huella();
            prueba.ShowDialog();

            Registro_Cliente2(prueba._idCliente);
        }

        private void eliminar_cliente_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea eliminar usuario?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                contexto.sp_Eliminar_Cliente_Catalogo(id_cliente);
                MessageBox.Show("Cliente Eliminado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Registro_Cliente nuevo = new Registro_Cliente();
                nuevo.Show();
                this.Close();
            }
        }

        private void historial_button_Click(object sender, EventArgs e)
        {
            Historial_Asistencias historial = new Historial_Asistencias(id_cliente, false);
            historial.ShowDialog();
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

        private void loadData()
        {
            AutoCompleteStringCollection nombres_colonias = new AutoCompleteStringCollection();

            string[] colonias = (from leer in contexto.Catalogo_Colonias select leer.nombre_colonia).ToArray();
            
            nombres_colonias.AddRange(colonias);

            colonia_textBox.AutoCompleteMode = AutoCompleteMode.Append;
            colonia_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            colonia_textBox.AutoCompleteCustomSource = nombres_colonias;
        }

        private void colonia_textBox_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyCode != Keys.Back)
            {
                loadData();
            }
        }
    }
}
