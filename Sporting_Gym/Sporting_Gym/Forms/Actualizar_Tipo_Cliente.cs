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
    public partial class Actualizar_Tipo_Cliente : Form
    {
        static db_sporting_gymContainer contexto; 

        private int id_seleccion = 0;
        private bool insertar = false;

        public Actualizar_Tipo_Cliente(int id_seleccion, bool bandera)
        {
            InitializeComponent();
            this.id_seleccion = id_seleccion;
            insertar = bandera;

        }

        public Actualizar_Tipo_Cliente(bool bandera)
        {
            InitializeComponent();
            insertar = bandera;
        }

        private void Actualizar_Tipo_Cliente_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            contexto = new db_sporting_gymContainer();

            if (insertar == true)
            {
                eliminar_button.Text = "Eliminar";
                var nom = (from x in contexto.Catalogo_Tipos_Clientes where x.id_tipo_cliente == id_seleccion select x).ToList();
                nombre_tipo_cliente_textBox.Text = nom[0].nombre_tipo_cliente;
            }
            else
            {
                eliminar_button.Text = "Limpiar";
            }
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (insertar)
            {
                contexto.sp_Actualizar_Tipo_Cliente(id_seleccion, nombre_tipo_cliente_textBox.Text);
                this.Close();
                MessageBox.Show("Datos Actualizados");
            }
            else
            {
                //contexto.sp_Nuevo_Tipo_Cliente(nombre_tipo_cliente_textBox.Text);

                Catalogo_Tipos_Clientes tipos_clientes = new Catalogo_Tipos_Clientes();
                tipos_clientes.nombre_tipo_cliente = nombre_tipo_cliente_textBox.Text;
                contexto.Catalogo_Tipos_Clientes.Add(tipos_clientes);
                contexto.SaveChanges();

                int id_nuevo_tipo = tipos_clientes.id_tipo_cliente;

                this.Close();
                MessageBox.Show("Datos agregados");

                var periodos = (from x in contexto.Catalogo_Periodos select x.id_periodo).ToList();

                for(int x = 0; x < periodos.Count; x++)
                {
                    Costo_Cliente_Periodo costo = new Costo_Cliente_Periodo();

                    costo.id_periodo = Convert.ToInt32(periodos[x]);
                    costo.id_tipo_cliente = id_nuevo_tipo;
                    costo.costo = 0;

                    contexto.Costo_Cliente_Periodo.Add(costo);
                    contexto.SaveChanges();
                }

                var verificar = (from ver in contexto.Catalogo_Periodos select ver).ToList();

                if (verificar.Count != 0)
                {
                    Actualizar_Costos costos = new Actualizar_Costos("Tipos Clientes", id_nuevo_tipo);
                    costos.ShowDialog();
                }
            }
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            if (insertar == true)
            {

                if (MessageBox.Show("¿Seguro desea eliminar el tipo de cliente?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var tabla_tipo_cliente = (from principal in contexto.Catalogo_Tipos_Clientes where principal.id_tipo_cliente == id_seleccion select principal).First();
                    var costos_tipos_cliente = (from costos in contexto.Costo_Cliente_Periodo where costos.id_tipo_cliente == id_seleccion select costos).ToList();

                    contexto.Catalogo_Tipos_Clientes.Remove(tabla_tipo_cliente);

                    for (int x = 0; x < costos_tipos_cliente.Count; x++)
                    {
                        contexto.Costo_Cliente_Periodo.Remove(costos_tipos_cliente[x]);
                        contexto.SaveChanges();
                    }

                    MessageBox.Show("Datos Eliminados", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                nombre_tipo_cliente_textBox.Text = "";
            }
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
