using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoEmail;

using System.Net.Mail;
using System.Net;

using Sporting_Gym.App_Code.Entity_Model;
using Sporting_Gym.App_Code.Utility;

namespace Sporting_Gym.Forms
{
    public partial class Correo : Form
    {
        String[] filePath = null;
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        public Correo()
        {
            InitializeComponent();
        }

        private void enviar_correo_button_Click(object sender, EventArgs e)
        {
            List<string> list_Correos = new List<string>();

            if (vigentes_radioButton.Checked)
            {
                list_Correos = (from usuarios in contexto.Catalogo_Clientes where usuarios.fecha_corte > DateTime.Today select usuarios.correo).ToList();

            }
            else if (vencidos_radioButton.Checked)
            {
                list_Correos = (from usuarios in contexto.Catalogo_Clientes where usuarios.fecha_corte < DateTime.Today select usuarios.correo).ToList();
            }
            else if (todos_radioButton.Checked)
            {
                list_Correos = (from usuarios in contexto.Catalogo_Clientes select usuarios.correo).ToList();
            }

            if (asunto_textBox.Text != "" || correo_emisor_textBox.Text != "" || mensaje_textBox.Text != "")
            {
                bool email = SendMail(correo_emisor_textBox.Text, asunto_textBox.Text, mensaje_textBox.Text, filePath, list_Correos, contraseña_textBox.Text);

                if (email == true)
                {
                    MessageBox.Show("Correo Enviado");
                }
                else
                {
                    MessageBox.Show("Error al enviar");
                }
            }
            else
            {
                MessageBox.Show("Falta Informacion");
            }
        }

        public static Boolean SendMail(string emisor, string asunto, string mensaje, string[] file, List<string> list_Correos, string contra)
        {
            try
            {
                //Configuración del Mensaje
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                mail.From = new MailAddress(emisor, "Sporting GYM", Encoding.UTF8);
                //Aquí ponemos el asunto del correo
                mail.Subject = asunto;
                //Aquí ponemos el mensaje que incluirá el correo
                mail.Body = mensaje;
                //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
                //mail.To.Add("cz_z15@hotmail.com");
                //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
                if (file != null)
                {
                    for(int x = 0; x < file.Length; x++)
                        mail.Attachments.Add(new Attachment(file[x]));
                }
                for (int x = 0; x < list_Correos.Count; x++)
                    mail.CC.Add(list_Correos[x]);

                //mail.CC.Add("czz1305@gmail.com");
                //Configuracion del SMTP
                SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
                //Especificamos las credenciales con las que enviaremos el mail
                SmtpServer.Credentials = new System.Net.NetworkCredential(emisor, contra);
                SmtpServer.EnableSsl = true;
                SmtpServer.SendAsync(mail, "Message 1");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void adjuntar_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "All Files|*.*";
            file.FilterIndex = 1;

            file.Multiselect = true; //para seleccionar varios archivos a la vez
            String[] nombresArchivos = null;

            if (file.ShowDialog() == DialogResult.OK)
            {
                nombresArchivos = file.SafeFileNames;
                filePath = file.FileNames; //guardo archivos en arreglo
            }

            if (nombresArchivos != null)
            {
                foreach (string adjunto in nombresArchivos)
                {
                    direccion_archivo_textBox.Text += adjunto + ", ";
                }
            }
        }

        private void Correo_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
