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
using Sporting_Gym.App_Code.Models;
using Sporting_Gym.App_Code.Handlers;
using Sporting_Gym.App_Code.Utility;

namespace Sporting_Gym
{
    public partial class Login : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        public int idUsuario { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Acceder_button_Click(object sender, EventArgs e)
        {
            var verificar = (from usuarios in contexto.Generales_Usuarios where usuarios.nombre_usuario == usuario_textBox.Text.Trim() && usuarios.password == pasword_textBox.Text.Trim() && usuarios.estatus != 0 select usuarios).ToList();

            if(verificar.Count > 0)
            {
                idUsuario = verificar[0].id_usuario;

                List<csModulo> Modulos = (new csAccesosHandler()).CreateAccesosUsuarios(idUsuario);

                if(Modulos == null)
                {
                    MessageBox.Show("No tiene ningun acceso");
                    return;
                }

                this.Hide();

                usuario_textBox.Text = "";
                pasword_textBox.Text = "";

                Principal frm = new Principal(Modulos, idUsuario);
                frm.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }

            //for(int x = 0; x < verificar.Count; x++)
            //{
            //    if(verificar[x].nombre_usuario == usuario_textBox.Text && verificar[x].password == pasword_textBox.Text)
            //    {

            //    }else
            //    {
            //        MessageBox.Show("")
            //    }
            //}
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
        }   

        private void usuario_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Back)
            {
                cargar_dato();
            }
        }

        private void cargar_dato()
        {
            AutoCompleteStringCollection nombre_usuarios = new AutoCompleteStringCollection();
            string[] nombres = (from leer in contexto.Generales_Usuarios select leer.nombre_usuario).ToArray();

            nombre_usuarios.AddRange(nombres);

            usuario_textBox.AutoCompleteMode = AutoCompleteMode.Append;
            usuario_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            usuario_textBox.AutoCompleteCustomSource = nombre_usuarios;
        }
    }
}
