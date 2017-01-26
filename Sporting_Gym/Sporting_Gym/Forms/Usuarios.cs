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
using Sporting_Gym.App_Code.Handlers;
using Sporting_Gym.App_Code.Utility;

namespace Sporting_Gym.Forms
{
    public partial class Usuarios : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        bool actualizar = false;
        bool editables = false;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            LlenarComboBoxUsuarios();
            LlenarTreeView();
        }

        private void LlenarTreeView()
        {
            treeView.Nodes.Clear();

            csAccesosHandler AccesoHanlder = new csAccesosHandler();

            AccesoHanlder.LlenarTreeView(treeView);

            AccesoHanlder.LlenarTreeViewUsuarios(treeView, (int)usuarios_comboBox.SelectedValue);

            treeView.ExpandAll();
        }

        private void LlenarComboBoxUsuarios()
        {
            var usuarios = (from x in contexto.Generales_Usuarios select x).ToList();

            usuarios_comboBox.DisplayMember = "nombre";
            usuarios_comboBox.ValueMember = "id_usuario";
            usuarios_comboBox.DataSource = usuarios;

            usuarios_comboBox.SelectedIndex = 0;
        }

        //BOTONES
        private void editar_button_Click(object sender, EventArgs e)
        {
            Llenar_campos();

            actualizar = true;

            guardar_button.Visible = true;
            cancelar_button.Visible = true;

            if (editables == false)
            {
                Solo_Lectura();
                editables = true;
            }
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            actualizar = false;

            if (editables == false)
            {
                Solo_Lectura();
                editables = true;
            }

            guardar_button.Visible = true;
            cancelar_button.Visible = true;
            Limpiar_TextBox();
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            int id_usuario = Convert.ToInt32(usuarios_comboBox.SelectedValue.ToString());
            (new csAccesosHandler()).BorrarAccesosUsuarios(id_usuario, true);
            LlenarComboBoxUsuarios();
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (actualizar == true)
            {
                if (nombre_textBox.Text == "" || correo_textBox.Text == "" || nom_usuario_textBox.Text == "" || password_textBox.Text == "")
                {
                    MessageBox.Show("Quedan campos vacios", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int id_usuario = Convert.ToInt32(usuarios_comboBox.SelectedValue.ToString());

                    var info_user = (from buscar in contexto.Generales_Usuarios where buscar.id_usuario == id_usuario select buscar).First();

                    info_user.nombre = nombre_textBox.Text;
                    info_user.correo = correo_textBox.Text;
                    info_user.nombre_usuario = nom_usuario_textBox.Text;
                    info_user.password = password_textBox.Text;

                    if (Activo_radioButton.Checked)
                    {
                        info_user.estatus = 1;
                    }else
                    {
                        info_user.estatus = 0;
                    }

                    contexto.SaveChanges();

                    csAccesosHandler AccesoHanlder = new csAccesosHandler();

                    AccesoHanlder.AgregaAccesosUsuarios(treeView, (int)usuarios_comboBox.SelectedValue);

                    MessageBox.Show("Usuario Actualizado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    guardar_button.Visible = false;
                    cancelar_button.Visible = false;
                }
            }
            else if (actualizar == false)
            {
                if (nombre_textBox.Text != "" && correo_textBox.Text != "" && nom_usuario_textBox.Text != "" && password_textBox.Text != "")
                {
                    Generales_Usuarios accesos = new Generales_Usuarios();

                    accesos.nombre = nombre_textBox.Text;
                    accesos.correo = correo_textBox.Text;
                    accesos.nombre_usuario = nom_usuario_textBox.Text;
                    accesos.password = password_textBox.Text;

                    if (Activo_radioButton.Checked)
                    {
                        accesos.estatus = 1;
                    }
                    else
                    {
                        accesos.estatus = 0;
                    }

                    contexto.Generales_Usuarios.Add(accesos);

                    contexto.SaveChanges();

                    (new csAccesosHandler()).AgregaAccesosUsuarios(treeView, accesos.id_usuario);
                    LlenarComboBoxUsuarios();
                    MessageBox.Show("Usuario creado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    guardar_button.Visible = false;
                    cancelar_button.Visible = false;
                }
                else
                {
                    MessageBox.Show("Quedan campos vacios", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            if (editables == true)
            {
                Solo_Lectura();
                editables = false;
            }
            
            Llenar_campos();

            guardar_button.Visible = false;
            cancelar_button.Visible = false;
        }

        private void Ver_checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if(Ver_checkBox.Checked == true)
            {
                password_textBox.PasswordChar = '\0';
            }
            else 
            if(Ver_checkBox.Checked == false) 
            {
                password_textBox.PasswordChar = '*';
            }
        }

        private void usuarios_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Llenar_campos();
            LlenarTreeView();

            if(editables == true)
            {
                Solo_Lectura();
                editables = false;
            }
        }

        private void Solo_Lectura()
        {
            nombre_textBox.ReadOnly = !nombre_textBox.ReadOnly;
            correo_textBox.ReadOnly = !correo_textBox.ReadOnly;
            nom_usuario_textBox.ReadOnly = !nom_usuario_textBox.ReadOnly;
            password_textBox.ReadOnly = !password_textBox.ReadOnly;
            Ver_checkBox.Enabled = !Ver_checkBox.Enabled;

            treeView.Enabled = !treeView.Enabled;
        }

        private void Limpiar_TextBox()
        {
            nombre_textBox.Text = "";
            correo_textBox.Text = "";
            nom_usuario_textBox.Text = "";
            password_textBox.Text = "";
        }

        private void Llenar_campos()
        {
            int id_usuario = Convert.ToInt32(usuarios_comboBox.SelectedValue);
            var info_usuario = (from usuarios in contexto.Generales_Usuarios where usuarios.id_usuario == id_usuario select usuarios).Single();

            nombre_textBox.Text = info_usuario.nombre;
            correo_textBox.Text = info_usuario.correo;
            nom_usuario_textBox.Text = info_usuario.nombre_usuario;
            password_textBox.Text = info_usuario.password;

            if (info_usuario.estatus == 0)
            {
                Inactivo_radioButton.Checked = true;
            }
            else{
                Activo_radioButton.Checked = true;
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
