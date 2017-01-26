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
    public partial class Actualizar_Costos : Form
    {

        db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        string tipo = "";
        int id_pago;

        int posicion_anterior;
        public bool primera = false;

        int id;

        public Actualizar_Costos(string tipo, int id)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.id = id;
        }

        private void Actualizar_Costos_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            Cargar_Datos();
            Cambiar_Valores_Gridview(null, null);
        }

        public void Cargar_Datos()
        {
            if (tipo == "Tipos Clientes")
            {
                nombre_label.Text = "Tipo Cliente";
                List<Catalogo_Tipos_Clientes> tipo_clientes = (from x in contexto.Catalogo_Tipos_Clientes select x).ToList();
                tipo_cliente_comboBox.ValueMember = "id_tipo_cliente";
                tipo_cliente_comboBox.DisplayMember = "nombre_tipo_cliente";
                tipo_cliente_comboBox.DataSource = tipo_clientes;
            }
            else if (tipo == "Periodo")
            {
                nombre_label.Text = "Periodo:";
                List<Catalogo_Periodos> periodos = (from y in contexto.Catalogo_Periodos select y).ToList();
                tipo_cliente_comboBox.ValueMember = "id_periodo";
                tipo_cliente_comboBox.DisplayMember = "nombre_periodo";
                tipo_cliente_comboBox.DataSource = periodos;
            }

            tipo_cliente_comboBox.SelectedValue = id;
        }

        public void Cambiar_Valores_Gridview(object sender, EventArgs e)
        {
            if (tipo == "Tipos Clientes")
            {
                int cliente = Convert.ToInt32(tipo_cliente_comboBox.SelectedValue);

                //int periodo = Convert.ToInt32(periodo_comboBox.SelectedValue);

                //var mostrar_costos = (from costos in contexto.Costo_Cliente_Periodo where costos.id_tipo_cliente == cliente select costos).ToList();

                var mostrar_costos = (from costos in contexto.Costo_Cliente_Periodo
                                      join c in contexto.Catalogo_Periodos on costos.id_periodo equals c.id_periodo
                                      where costos.id_tipo_cliente == cliente
                                      select new
                                      {
                                          id_Costo_Tipo_Cliente = costos.id_costo_cliente_periodo,
                                          id_periodo = costos.id_periodo,
                                          Periodo = c.nombre_periodo,
                                          Tipo_Cliene = costos.id_tipo_cliente,
                                          Costo = costos.costo
                                      }).ToList();

                costos_tipos_periodos_dataGridView.DataSource = mostrar_costos;

                //costos_tipos_periodos_dataGridView.Columns[0].Visible = false;
                //costos_tipos_periodos_dataGridView.Columns[2].Visible = false;

                costos_tipos_periodos_dataGridView.Columns[0].Visible = false;
                costos_tipos_periodos_dataGridView.Columns[1].Visible = false;
                costos_tipos_periodos_dataGridView.Columns[3].Visible = false;
            }
            else if (tipo == "Periodo")
            {
                int periodo = Convert.ToInt32(tipo_cliente_comboBox.SelectedValue);
                //int periodo = Convert.ToInt32(periodo_comboBox.SelectedValue);

                //var mostrar_costos = (from costos in contexto.Costo_Cliente_Periodo where costos.id_periodo == periodo select costos).ToList();

                var mostrar_costos = (from costos in contexto.Costo_Cliente_Periodo
                                      join c in contexto.Catalogo_Tipos_Clientes on costos.id_tipo_cliente equals c.id_tipo_cliente
                                      where costos.id_periodo == periodo
                                      select new
                                      {
                                          id_Costo_Tipo_Cliente = costos.id_costo_cliente_periodo,
                                          id_periodo = costos.id_periodo,
                                          id_tipo_cliente = costos.id_tipo_cliente,
                                          tipo_cliente = c.nombre_tipo_cliente,
                                          Costo = costos.costo
                                      }).ToList();

                costos_tipos_periodos_dataGridView.DataSource = mostrar_costos;

                //costos_tipos_periodos_dataGridView.Columns[0].Visible = false;
                //costos_tipos_periodos_dataGridView.Columns[1].Visible = false;

                costos_tipos_periodos_dataGridView.Columns[0].Visible = false;
                costos_tipos_periodos_dataGridView.Columns[1].Visible = false;
                costos_tipos_periodos_dataGridView.Columns[2].Visible = false;
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costos_tipos_periodos_dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //MessageBox.Show(costos_tipos_periodos_dataGridView.CurrentCell.ColumnIndex.ToString());

            if (costos_tipos_periodos_dataGridView.CurrentRow.Index >= 0 && costos_tipos_periodos_dataGridView.CurrentCell.ColumnIndex == 4)
            {
                decimal costo = 0;
                costos_tipos_periodos_dataGridView.CurrentCell.ReadOnly = false;
                if (!decimal.TryParse(Convert.ToString(e.FormattedValue), out costo))
                {
                    e.Cancel = true;
                    MessageBox.Show("Importe no valido", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    for (int x = 0; x < costos_tipos_periodos_dataGridView.Rows.Count; x++)
                    {
                        costo = Convert.ToDecimal(costos_tipos_periodos_dataGridView.Rows[x].Cells[4].Value.ToString());
                        int id_costo = Convert.ToInt32(costos_tipos_periodos_dataGridView.Rows[x].Cells[0].Value);

                        var nuevo_costo = (from a in contexto.Costo_Cliente_Periodo where a.id_costo_cliente_periodo == id_costo select a).Single();
                        nuevo_costo.costo = costo;
                    }
                    contexto.SaveChanges();
                }

            }
        }

        private void costos_tipos_periodos_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (costos_tipos_periodos_dataGridView.CurrentRow.Index >= 0 && costos_tipos_periodos_dataGridView.CurrentCell.ColumnIndex != 4)
            //{

            //    MessageBox.Show("Capturar solo en campos de importe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //MessageBox.Show("Un Click");

            if (e.RowIndex <= -1)
            {
                return;
            }

            id_pago = Convert.ToInt32(costos_tipos_periodos_dataGridView[0, e.RowIndex].Value);

            if (primera == true)
            {
                costos_tipos_periodos_dataGridView.Rows[posicion_anterior].DefaultCellStyle.BackColor = DefaultBackColor;
            }

            costos_tipos_periodos_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            posicion_anterior = e.RowIndex;

            id_pago = Convert.ToInt32(costos_tipos_periodos_dataGridView[0, e.RowIndex].Value);
            costo_textBox.Text = costos_tipos_periodos_dataGridView.Rows[costos_tipos_periodos_dataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString();

            primera = true;
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            //for (int x = 0; x < costos_tipos_periodos_dataGridView.Rows.Count; x++)
            //{
            //    decimal costo = Convert.ToDecimal(costos_tipos_periodos_dataGridView.Rows[x].Cells[4].Value.ToString());
            //    int id_costo = Convert.ToInt32(costos_tipos_periodos_dataGridView.Rows[x].Cells[0].Value);

            //    var nuevo_costo = (from a in contexto.Costo_Cliente_Periodo where a.id_costo_cliente_periodo == id_costo select a).Single();
            //    nuevo_costo.costo = costo;
            //}

            //contexto.SaveChanges();

            //MessageBox.Show("Datos actualizados", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costos_tipos_periodos_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            costos_tipos_periodos_dataGridView.CurrentCell.ReadOnly = false;
        }

        private void costo_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void costo_textBox_Leave(object sender, EventArgs e)
        {
            if (id_pago != 0)
            {
                if (costo_textBox.Text != "")
                {
                    decimal costo = 0;
                    costo = Convert.ToDecimal(costo_textBox.Text);

                    var nuevo_costo = (from a in contexto.Costo_Cliente_Periodo where a.id_costo_cliente_periodo == id_pago select a).Single();
                    nuevo_costo.costo = costo;

                    contexto.SaveChanges();

                    Cambiar_Valores_Gridview(null, null);

                    id_pago = 0;
                    costo_textBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Seleccione Costo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
