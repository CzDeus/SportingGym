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
    public partial class Historial_Asistencias : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        int id_cliente;
        bool instructor;

        public Historial_Asistencias()
        {
            InitializeComponent();
        }

        public Historial_Asistencias(int id_cliente, bool instructor)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
            this.instructor = instructor;
        }

        private void Historial_Asistencias_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            if (instructor == false)
            {
                var historial = (from x in contexto.Bitacora_Asistencias where x.id_cliente == id_cliente && x.estatus == true orderby x.fecha_ingreso descending select new { fecha_ingreso = x.fecha_ingreso }).ToList();
                historial_asistencias_dataGridView.DataSource = historial;
            }else
            {
                var historial = (from x in contexto.Bitacora_Asistencias where x.id_cliente == id_cliente  && x.estatus == false select new { fecha_ingreso = x.fecha_ingreso }).ToList();
                historial_asistencias_dataGridView.DataSource = historial;
            }
            
        }

        private void Salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salir_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
