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
    public partial class Actualizar_Tipo_Egreso : Form
    {

        static db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        int id_periodo = 0;
        bool bandera = false;

        public Actualizar_Tipo_Egreso(int id_periodo, bool bandera)
        {
            InitializeComponent();
            this.id_periodo = id_periodo;
            this.bandera = bandera;

            var nom = (from x in contexto.Catalogo_Tipos_Egresos where x.id_tipo_egreso == id_periodo select x).ToList();
            nombre_tipo_egreso_textBox.Text = nom[0].nombre_tipo_egreso;
        }

        public Actualizar_Tipo_Egreso(bool bandera)
        {
            InitializeComponent();
            this.bandera = bandera;
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (nombre_tipo_egreso_textBox.Text != "")
            {
                if (bandera)
                {
                    contexto.sp_Actualizar_Tipo_Egreso(id_periodo, nombre_tipo_egreso_textBox.Text);
                    this.Close();
                    MessageBox.Show("Datos Actualizados");
                }
                else
                {
                    contexto.sp_Nuevo_Tipo_Egreso(nombre_tipo_egreso_textBox.Text);
                    this.Close();
                    MessageBox.Show("Datos Agregados");
                }
            }else
            {
                MessageBox.Show("Campo vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                if (MessageBox.Show("¿Seguro desea eliminar el tipo de egreso?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contexto.sp_Eliminar_Tipo_Egresos_Catalogo(id_periodo);
                    this.Close();
                    MessageBox.Show("Tipo egreso eliminado");
                }
            }
            else
            {
                nombre_tipo_egreso_textBox.Text = "";
            }
        }

        private void Actualizar_Tipo_Egreso_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            if (bandera == true)
            {
                eliminar_button.Text = "Eliminar";
            }
            else
            {
                eliminar_button.Text = "Limpiar";
            }
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
