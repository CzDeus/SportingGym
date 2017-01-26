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
    public partial class Egresos : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        int id_usuario;

        public Egresos()
        {
            InitializeComponent();
        }

        public Egresos(int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
        }

        private void Egresos_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            var egresos = (from x in contexto.Catalogo_Tipos_Egresos select x).ToList();
            tipo_egreso_comboBox.ValueMember = "id_tipo_egreso";
            tipo_egreso_comboBox.DisplayMember = "nombre_tipo_egreso";
            tipo_egreso_comboBox.DataSource = egresos;

            fecha_dateTimePicker.Text = DateTime.Now.ToString("dd-MM-yyyy");
            
        }

        private void cantidad_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {

            if (cantidad_textBox.Text != "")
            {
                Tabla_Egresos egresos = new Tabla_Egresos();

                egresos.id_tipo_egreso = Convert.ToInt32(tipo_egreso_comboBox.SelectedValue);
                egresos.cantidad = Convert.ToInt32(cantidad_textBox.Text);
                egresos.justificacion = justificacion_textBox.Text;
                egresos.fecha = DateTime.Now;
                egresos.id_usuario = id_usuario;

                contexto.Tabla_Egresos.Add(egresos);
                contexto.SaveChanges();

                MessageBox.Show("Se registro el egreso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cantidad_textBox.Text = "";
                justificacion_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese cantidad por favor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}