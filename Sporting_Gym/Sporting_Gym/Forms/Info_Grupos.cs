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
using Sporting_Gym.App_Code.Utility;

namespace Sporting_Gym.Forms
{
    public partial class Info_Grupos : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        int id_grupo; 

        public Info_Grupos()
        {
            InitializeComponent();
        }

        public Info_Grupos(int id_grupo)
        {
            InitializeComponent();
            this.id_grupo = id_grupo;
            Cargar_Gridview();
        }
        
        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cargar_Gridview()
        {
            var datos_grupo = (from info in contexto.Grupos where info.id_grupo == id_grupo select info).First();
            nombre_grupo_textBox.Text = datos_grupo.nombre_grupo;

            var nombre_responsable = (from responsable in contexto.Catalogo_Clientes where responsable.id_cliente == datos_grupo.id_cliente_responsable select responsable).First();
            responsable_textBox.Text = nombre_responsable.nombre + " " + nombre_responsable.apellido_paterno + " " + nombre_responsable.apellido_materno;

            var clientes_grupo = (from usuarios in contexto.Catalogo_Clientes where usuarios.id_grupo == id_grupo select new { id_usuario = usuarios.id_cliente, Nombre_Clientes = usuarios.nombre + " " + usuarios.apellido_paterno + " " + usuarios.apellido_materno }).ToList();
            Clientes_Grupos_dataGridView.DataSource = clientes_grupo;
            Clientes_Grupos_dataGridView.Columns[0].Visible = false;
        }

        private void Info_Grupos_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
        }
    }
}
