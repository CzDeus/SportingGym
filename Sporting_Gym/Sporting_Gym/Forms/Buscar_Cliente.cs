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
    public partial class Buscar_Cliente : Form
    {
        public int _idCliente { get; set; }

        public string nombre;
        public string apellido_paterno;

        public int id_cliente = 0;
        public int id_instructor = 0;

        public bool tipo;
        bool esPago;

        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        public Buscar_Cliente(bool tipo, bool esPago)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.esPago = esPago;

        }

        public Buscar_Cliente(string nombre, string apellido_paterno, bool tipo)
        {
            InitializeComponent();

            if (tipo == false)
            {
                titulo_label.Text = "Buscar Instructor";
            }

            this.apellido_paterno = apellido_paterno;
            this.nombre = nombre;
            this.tipo = tipo;
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            if (tipo == true)
            {
                var cliente = contexto.sp_Buscar_Cliente(apellido_paterno).ToList();
                Clientes_dataGridView.DataSource = cliente;
            }
            else if (tipo == false)
            {
                var cliente = contexto.sp_Buscar_Instructor(nombre).ToList();
                Clientes_dataGridView.DataSource = cliente;
            }

            Clientes_dataGridView.Columns[0].Visible = false;
        }

        private void buscar_cliente_button_Click(object sender, EventArgs e)
        {
            if (nombre_cliente_buscar_textBox.Text != "")
            {
                var cliente = contexto.sp_Buscar_Cliente(nombre_cliente_buscar_textBox.Text).ToList();

                Clientes_dataGridView.DataSource = cliente;
            }else
            {
                MessageBox.Show("Por favor ingrese nombre del cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Clientes_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (tipo == true && esPago == false)
            {
                id_cliente = Convert.ToInt32(Clientes_dataGridView[0, e.RowIndex].Value);
                Registro_Cliente cliente = new Registro_Cliente(id_cliente);
                cliente.ShowDialog();
            }
            else if (tipo == false)
            {
                id_instructor = Convert.ToInt32(Clientes_dataGridView[0, e.RowIndex].Value);
                Actualizar_Instructor instructor = new Actualizar_Instructor(id_instructor, true);
                instructor.ShowDialog();
            }
            else if (tipo == true && esPago == true)
            {
                //DEVOLVER NOMBRE A LA FORMA DE PAGO
                _idCliente = Convert.ToInt32(Clientes_dataGridView[0, e.RowIndex].Value);

            }

            this.Close();
        }

        private void cargar_clientes_button_Click(object sender, EventArgs e)
        {
            var cliente = contexto.sp_Buscar_Cliente("");

            Clientes_dataGridView.DataSource = cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombre_cliente_buscar_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var cliente = contexto.sp_Buscar_Cliente(nombre_cliente_buscar_textBox.Text).ToList();
                Clientes_dataGridView.DataSource = cliente;
            }
        }
    }
}