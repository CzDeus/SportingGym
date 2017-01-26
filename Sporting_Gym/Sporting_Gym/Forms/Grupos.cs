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
    public partial class Grupos : Form
    {

        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        public Grupos()
        {
            InitializeComponent();
        }

        public Grupos(int id_grupo)
        {
            InitializeComponent();
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            int id_tipo_cliente = Convert.ToInt32(tipo_cliente_comboBox.SelectedValue);

            if (nombre_grupo_textBox.Text != "")
            {
                int id = Convert.ToInt32(contexto.sp_Nuevo_Grupo(nombre_grupo_textBox.Text).First());

                MessageBox.Show("Nuevo grupo agregado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                Nuevo_Grupo grupo = new Nuevo_Grupo(id, true, id_tipo_cliente);
                grupo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Quedan campos vacios", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            List<Catalogo_Tipos_Clientes> tipos_clientes = (from leer in contexto.Catalogo_Tipos_Clientes select leer).ToList();
            tipo_cliente_comboBox.ValueMember = "id_tipo_cliente";
            tipo_cliente_comboBox.DisplayMember = "nombre_tipo_cliente";
            tipo_cliente_comboBox.DataSource = tipos_clientes;
        }
    }
}
