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
    public partial class Actualizar_Tipo_Pago : Form
    {
        static db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        private int id_periodo = 0;
        private bool bandera = false;

        public Actualizar_Tipo_Pago(int id_periodo, bool bandera)
        {
            InitializeComponent();
            this.id_periodo = id_periodo;
            this.bandera = bandera;

            var nom = (from x in contexto.Catalogo_Metodos_Pagos where x.id_metodo_pago == id_periodo select x).ToList();
            nombre_tipo_pago_textBox.Text = nom[0].nombre_metodo_pago;
        }

        public Actualizar_Tipo_Pago(bool bandera)
        {
            InitializeComponent();
            this.bandera = bandera;
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (nombre_tipo_pago_textBox.Text != "")
            {
                if (bandera)
                {
                    contexto.sp_Actualizar_Metodos_Pago(id_periodo, nombre_tipo_pago_textBox.Text);
                    this.Close();
                    MessageBox.Show("Datos actualizados");
                }
                else
                {
                    contexto.sp_Nuevo_Metodo_Pago(nombre_tipo_pago_textBox.Text);
                    this.Close();
                    MessageBox.Show("Datos Agregados");
                }
            }else
            {
                MessageBox.Show("Quedan campos vacios", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Actualizar_Tipo_Pago_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            if (bandera== true)
            {
                eliminar_button.Text = "Eliminar";
            }
            else
            {
                eliminar_button.Text = "Limpiar";
            }
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                if (MessageBox.Show("¿Seguro desea eliminar el tipo de pago?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contexto.sp_Eliminar_Tipo_Pagos_Catalogo(id_periodo);
                    this.Close();
                    MessageBox.Show("Datos eliminados", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                nombre_tipo_pago_textBox.Text = "";
            }
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
