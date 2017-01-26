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
    public partial class Actualizar_Periodo : Form
    {
        static db_sporting_gymContainer contexto;

        private int id_seleccion = 0;
        private bool insertar = false;

        public Actualizar_Periodo(int id_seleccion, bool bandera)
        {
            InitializeComponent();
            this.id_seleccion = id_seleccion;
            this.insertar = bandera;

        }

        public Actualizar_Periodo(bool bandera)
        {
            InitializeComponent();
            this.insertar = bandera;
        }

        private void Actualizar_Periodo_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            contexto = new db_sporting_gymContainer();

            if (insertar == true)
            {
                Eliminar_button.Text = "Eliminar";
                var nom = (from x in contexto.Catalogo_Periodos where x.id_periodo == id_seleccion select x).ToList();
                nombre_periodo_textBox.Text = nom[0].nombre_periodo;
                dias_periodo_textBox.Text = nom[0].dias.ToString();
            }
            else
            {
                Eliminar_button.Text = "Limpiar";
            }
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (nombre_periodo_textBox.Text != "" && dias_periodo_textBox.Text != "")
            {
                if (insertar)
                {

                    contexto.sp_Actualizar_Periodo(id_seleccion, nombre_periodo_textBox.Text, Convert.ToInt32(dias_periodo_textBox.Text));
                    this.Close();
                    MessageBox.Show("Datos Actualizados");
                }
                else
                {
                    //contexto.sp_Nuevo_Periodo(nombre_periodo_textBox.Text, Convert.ToInt32(dias_periodo_textBox.Text));
                    Catalogo_Periodos periodos = new Catalogo_Periodos();
                    periodos.nombre_periodo = nombre_periodo_textBox.Text;
                    periodos.dias = Convert.ToInt32(dias_periodo_textBox.Text);
                    contexto.Catalogo_Periodos.Add(periodos);
                    contexto.SaveChanges();

                    int id_periodo = periodos.id_periodo;

                    this.Close();
                    MessageBox.Show("Datos agregados");

                    var tipos_clientes = (from x in contexto.Catalogo_Tipos_Clientes select x.id_tipo_cliente).ToList();

                    for (int x = 0; x < tipos_clientes.Count; x++)
                    {
                        Costo_Cliente_Periodo costo = new Costo_Cliente_Periodo();

                        costo.id_tipo_cliente = Convert.ToInt32(tipos_clientes[x]);
                        costo.id_periodo = id_periodo;
                        costo.costo = 0;
                        contexto.Costo_Cliente_Periodo.Add(costo);
                        contexto.SaveChanges();
                    }

                    var verificar = (from ver in contexto.Catalogo_Tipos_Clientes select ver).ToList();

                    if (verificar.Count != 0)
                    {
                        Actualizar_Costos costos = new Actualizar_Costos("Periodo", id_periodo);
                        costos.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Quedan Campos Vacios", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            if (insertar == true)
            {

                if (MessageBox.Show("¿Seguro desea eleiminar el periodo?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var tabla_periodo = (from principal in contexto.Catalogo_Periodos where principal.id_periodo == id_seleccion select principal).First();
                    var costos_periodos = (from costos in contexto.Costo_Cliente_Periodo where costos.id_periodo == id_seleccion select costos).ToList();

                    contexto.Catalogo_Periodos.Remove(tabla_periodo);

                    for (int x = 0; x < costos_periodos.Count; x++)
                    {
                        contexto.Costo_Cliente_Periodo.Remove(costos_periodos[x]);
                        contexto.SaveChanges();
                    }

                    MessageBox.Show("Datos Eliminados", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                nombre_periodo_textBox.Text = "";
                dias_periodo_textBox.Text = "";
            }
        }

        private void dias_periodo_textBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
