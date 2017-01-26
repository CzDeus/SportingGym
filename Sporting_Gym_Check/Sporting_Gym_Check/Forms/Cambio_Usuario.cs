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

namespace Sporting_Gym_Check.Forms
{
    public partial class Cambio_Usuario : Form
    {
        db_sporting_gymEntities contexto = new db_sporting_gymEntities();
        int idUsuario;

        public Cambio_Usuario()
        {
            InitializeComponent();
        }

        private void Acceder_button_Click(object sender, EventArgs e)
        {
            var verificar = (from usuarios in contexto.Generales_Usuarios where usuarios.nombre_usuario == usuario_textBox.Text.Trim() && usuarios.password == pasword_textBox.Text.Trim() select usuarios).ToList();

            if (verificar.Count > 0)
            {
                idUsuario = verificar[0].id_usuario;

                this.Hide();

                usuario_textBox.Text = "";
                pasword_textBox.Text = "";

                Checador check = new Checador(idUsuario);
                check.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cambio_Usuario_Load(object sender, EventArgs e)
        {     
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
        }

        private void usuario_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Acceder_button_Click(null, null);
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

        private void usuario_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
            {
                cargar_dato();
            }
        }
    }
}
