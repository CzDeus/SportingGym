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
    public partial class Nuevo_Grupo : Form
    {
        static db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        bool bandera;

        int id_grupo;
        int id_usuario;

        int id_responsable;
        int id_tipo_cliente;

        bool primera = false;
        bool entrada = true;

        int posicion_anterior;

        public Nuevo_Grupo(bool bandera)
        {
            InitializeComponent();
            this.bandera = bandera;
        }

        public Nuevo_Grupo(int id_grupo, bool bandera, int id_tipo_cliente)
        {
            InitializeComponent();
            this.bandera = bandera;
            this.id_grupo = id_grupo;
            this.id_tipo_cliente = id_tipo_cliente;

            nombre_grupo_textBox.ReadOnly = true;
        }

        private void Nuevo_Grupo_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            if (bandera == true)
            {
                eliminar_button.Text = "Eliminar";
                var nombre_grupo = (from nombre in contexto.Grupos where nombre.id_grupo == id_grupo select nombre).First();
                nombre_grupo_textBox.Text = nombre_grupo.nombre_grupo;

                id_responsable = Convert.ToInt32(nombre_grupo.id_cliente_responsable);

                if (id_responsable != 0)
                {
                    var id_responsable = (from responsable in contexto.Grupos where responsable.id_grupo == id_grupo select responsable).First();
                    var nombre_responsable = (from responsable in contexto.Catalogo_Clientes where responsable.id_cliente == id_responsable.id_cliente_responsable select responsable).First();
                    responsable_textBox.Text = nombre_responsable.nombre + " " + nombre_responsable.apellido_paterno + " " + nombre_responsable.apellido_materno;
                    entrada = false;
                }
            }
            else
            {
                eliminar_button.Text = "Limpiar";
            }

            Cargar_Gridviews();
        }

        private void crear_grupo_button_Click(object sender, EventArgs e)
        {
            var responsable = (from persona in contexto.Grupos where persona.id_grupo == id_grupo select persona.id_cliente_responsable).First();

            if(Convert.ToInt32(responsable.ToString()) != 0)
            {
                MessageBox.Show("Datos Actualizados");
                entrada = false;
            }
            else
            {
                MessageBox.Show("Seleccione un responsable");
            }
        }

        private void numero_personas_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cancelar_button_Click(object sender, EventArgs e)
        {

            if(id_responsable == 0 && Clientes_Grupos_dataGridView.RowCount <= 0)
            {
                if(MessageBox.Show("¿Cancelar/Eliminar grupo?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var eliminar = (from grupos in contexto.Grupos where grupos.id_grupo == id_grupo select grupos).First();
                    contexto.Grupos.Remove(eliminar);
                    contexto.SaveChanges();

                    this.Close();
                }
            }else if (id_responsable == 0 && Clientes_Grupos_dataGridView.RowCount > 0)
            {
                MessageBox.Show("Seleccione un responsable");
            }
            else
            {
                this.Close();
            }
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            if(bandera == true)
            {
                if (Clientes_Grupos_dataGridView.RowCount <= 0)
                {
                    if (MessageBox.Show("¿Seguro desea eliminar?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var eliminar = (from grupo in contexto.Grupos where grupo.id_grupo == id_grupo select grupo).First();

                        contexto.Grupos.Remove(eliminar);

                        contexto.SaveChanges();
                        this.Close();
                    }
                }else
                {
                    MessageBox.Show("El grupo no debe de contener miembros", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                nombre_grupo_textBox.Text = "";
            }
        }

        private void clientes_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_cliente = clientes_dataGridView[0, e.RowIndex].Value.ToString();
            int id_seleccion = Convert.ToInt32(id_cliente);

            var c = (from x in contexto.Catalogo_Clientes where x.id_cliente == id_seleccion select x).First();
            c.id_grupo = id_grupo;
            c.id_tipo_cliente = id_tipo_cliente;
            contexto.SaveChanges();

            Cargar_Gridviews();
            clientes_sin_grupo();
        }

        private void Cargar_Gridviews()
        {
            var clientes_grupo = (from usuarios in contexto.Catalogo_Clientes where usuarios.id_grupo == id_grupo select new { id_usuario = usuarios.id_cliente, Integrantes = usuarios.nombre + " " + usuarios.apellido_paterno + " " + usuarios.apellido_materno }).ToList();
            Clientes_Grupos_dataGridView.DataSource = clientes_grupo;
            Clientes_Grupos_dataGridView.Columns[0].Visible = false;
        }

        private void Clientes_Grupos_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_usuario_cambiar = Convert.ToInt32(Clientes_Grupos_dataGridView.CurrentRow.Cells[0].Value);

            var quitar_grupo = (from usuario in contexto.Catalogo_Clientes where usuario.id_cliente == id_usuario_cambiar select usuario).First();
            quitar_grupo.id_grupo = 0;

            var quitar_responsable = (from responsable in contexto.Grupos where responsable.id_grupo == id_grupo select responsable).First();

            if(quitar_grupo.id_cliente == quitar_responsable.id_cliente_responsable)
            {
                quitar_responsable.id_cliente_responsable = 0;
                responsable_textBox.Text = "";
                id_responsable = 0;
            }

            contexto.SaveChanges();
            id_usuario = 0;

            Cargar_Gridviews();
            clientes_sin_grupo();
        }

        private void Clientes_Grupos_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_usuario = Convert.ToInt32(Clientes_Grupos_dataGridView.CurrentRow.Cells[0].Value);

            int valor = Clientes_Grupos_dataGridView.RowCount;

            if (primera == true && posicion_anterior < valor)
            {
                Clientes_Grupos_dataGridView.Rows[posicion_anterior].DefaultCellStyle.BackColor = DefaultBackColor;
            }
            else if (posicion_anterior > valor)
            {
                Clientes_Grupos_dataGridView.Rows[valor - 1].DefaultCellStyle.BackColor = DefaultBackColor;
            }

            Clientes_Grupos_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            posicion_anterior = e.RowIndex;

            primera = true;
        }

        private void responsable_button_Click(object sender, EventArgs e)
        {
            try
            {
                var asignar = (from grupo in contexto.Grupos where grupo.id_grupo == id_grupo select grupo).First();
                asignar.id_cliente_responsable = id_usuario;
                id_responsable = Convert.ToInt32(asignar.id_cliente_responsable);
                contexto.SaveChanges();

                var nombre = (from clientes in contexto.Catalogo_Clientes where clientes.id_cliente == id_usuario select new { nombre = clientes.nombre, ape_pa = clientes.apellido_paterno, ape_ma = clientes.apellido_materno }).Single();
                responsable_textBox.Text = nombre.nombre.ToString() + " " + nombre.ape_pa + " " + nombre.ape_ma;

                entrada = false;
            }
            catch
            {
                MessageBox.Show("Seleccione un responsable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void nombre_textBox_TextChanged(object sender, EventArgs e)
        {

            var cliente = (from buscar_clientes in contexto.Catalogo_Clientes where buscar_clientes.id_grupo == 0 select new { id_usuario = buscar_clientes.id_cliente, Clientes = buscar_clientes.nombre + " " + buscar_clientes.apellido_paterno + " " + buscar_clientes.apellido_materno }).ToList();

            if (cliente.Count != 0 || nombre_textBox.Text == "")
            {
                var buscar = contexto.sp_Buscar_Cliente(nombre_textBox.Text).ToList();

                clientes_dataGridView.DataSource = buscar;
                clientes_dataGridView.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargar_clientes_button_Click(object sender, EventArgs e)
        {
            clientes_sin_grupo();
        }

        private void clientes_sin_grupo()
        {
            var sin_grupo = (from usuarios in contexto.Catalogo_Clientes where usuarios.id_grupo == 0 select new { id_usuario = usuarios.id_cliente, Clientes = usuarios.nombre + " " + usuarios.apellido_paterno + " " + usuarios.apellido_materno }).ToList();
            clientes_dataGridView.DataSource = sin_grupo;
            clientes_dataGridView.Columns[0].Visible = false;
        }
    }
}
