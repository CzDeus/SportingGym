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
    public partial class Historial_Pagos : Form
    {
        private static db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        public int id_cliente;
        public int posicion_anterior;
        public bool primera = false;

        public Historial_Pagos()
        {
            InitializeComponent();
        }

        private void cerrar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            if (nombre_textBox.Text != "")
            {
                var clientes = contexto.sp_Buscar_Cliente(nombre_textBox.Text).ToList();
                clientes_dataGridView.DataSource = clientes;

                clientes_dataGridView.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Ingrese nombre del cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clientes_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            id_cliente = Convert.ToInt32(clientes_dataGridView[0, e.RowIndex].Value);

            var historial_cliente = contexto.sp_Buscar_Historial_Pagos(id_cliente).ToList();
            historial_dataGridView.DataSource = historial_cliente;

            if (primera == true)
            {
                clientes_dataGridView.Rows[posicion_anterior].DefaultCellStyle.BackColor = DefaultBackColor;
            }

            clientes_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

            posicion_anterior = e.RowIndex;

            primera = true;
        }

        private void historial_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id_pago = Convert.ToInt32(historial_dataGridView[0, e.RowIndex].Value);

            Ficha_Historial ficha = new Ficha_Historial(id_pago);
            ficha.ShowDialog();
        }

        private void nombre_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var clientes = contexto.sp_Buscar_Cliente(nombre_textBox.Text).ToList();
                clientes_dataGridView.DataSource = clientes;

                clientes_dataGridView.Columns[0].Visible = false;
            }
        }
    }
}
