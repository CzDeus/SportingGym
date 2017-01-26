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
    public partial class Egresos_Principal : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        int id_egreso, posicion_anterior;
        bool primera;
        int id_usuario;

        public Egresos_Principal()
        {
            InitializeComponent();
            Llenar_Egresos();
        }


        public void Llenar_Egresos()
        {
            var egresos = contexto.sp_Leer_Egresos();

            Egresos_dataGridView.DataSource = egresos;
            Egresos_dataGridView.Columns[0].Visible = false;
        }

        public Egresos_Principal(int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            Llenar_Egresos();
        }

        private void Egresos_Principal_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
        }

        private void Salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nuevo_Egreso_button_Click(object sender, EventArgs e)
        {
            Egresos nuevo_Egreso = new Egresos(id_usuario);
            nuevo_Egreso.ShowDialog();
            Llenar_Egresos();
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            var eliminar = (from buscar in contexto.Tabla_Egresos where buscar.id_egreso == id_egreso select buscar).First();

            contexto.Tabla_Egresos.Remove(eliminar);
            contexto.SaveChanges();
            Llenar_Egresos();
        }

        private void Egresos_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            id_egreso = Convert.ToInt32(Egresos_dataGridView[0, e.RowIndex].Value);

            int valor = Egresos_dataGridView.RowCount;

            if (primera == true && posicion_anterior < valor)
            {
                Egresos_dataGridView.Rows[posicion_anterior].DefaultCellStyle.BackColor = DefaultBackColor;
            }
            else if (posicion_anterior > valor)
            {
                Egresos_dataGridView.Rows[valor - 1].DefaultCellStyle.BackColor = DefaultBackColor;
            }

            Egresos_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            posicion_anterior = e.RowIndex;

            primera = true;
        }
    }
}
