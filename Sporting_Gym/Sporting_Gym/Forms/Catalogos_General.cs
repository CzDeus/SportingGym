using Sporting_Gym.App_Code.Entity_Model;
using Sporting_Gym.App_Code.Utility;
using Sporting_Gym.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporting_Gym
{
    public partial class Catalogos : Form
    {
        private static db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        private int id_seleccion = 0;

        public Catalogos()
        {
            InitializeComponent();

        }

        private void Catalogos_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            //Catalogos_tabControl.TabPages.Remove(Catalogos_tabControl.TabPages["Instructores_tabPage"]);
            carga_gridview("");
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string nombre_tab = Catalogos_tabControl.TabPages[Catalogos_tabControl.SelectedIndex].Name;

            if (nombre_tab == "Instructores_tabPage")
            {
                if (nombre_instructor_buscar_textBox.Text != "")
                {
                    carga_gridview(nombre_instructor_buscar_textBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Ingrese nombre instructor por favor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (nombre_tab == "Periodos_tabPage")
            {
                if (nombre_periodo_buscar_textBox.Text != "")
                {
                    carga_gridview(nombre_periodo_buscar_textBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Ingrese nombre periodo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (nombre_tab == "Tipos_Clientes_tabPage")
            {
                if (tipo_cliente_buscar_textBox.Text != "")
                {
                    carga_gridview(tipo_cliente_buscar_textBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre de tipo cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (nombre_tab == "Tipos_Egresos_tabPage")
            {
                if (tipo_egreso_buscar_textBox.Text != "")
                {
                    carga_gridview(tipo_egreso_buscar_textBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Ingre el nombre de tipo egreso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (nombre_tab == "Tipos_Pagos_tabPage")
            {
                if (tipo_pago_buscar_textBox.Text != "")
                {
                    carga_gridview(tipo_pago_buscar_textBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre de tipo pago", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }else if (nombre_tab == "Colonia_tabPage")
            {
                if(colonia_buscar_textBox.Text != "")
                {
                    carga_gridview(colonia_buscar_textBox.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre de la colonia", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            carga_gridview("");
        }

        private void nuevo_catalogos(object sender, EventArgs e)
        {
            string nombre_tab = Catalogos_tabControl.TabPages[Catalogos_tabControl.SelectedIndex].Name;

            if (nombre_tab == "Instructores_tabPage")
            {
                Actualizar_Instructor nuevo = new Actualizar_Instructor(false);
                nuevo.ShowDialog();
            }
            else if (nombre_tab == "Periodos_tabPage")
            {
                Actualizar_Periodo nuevo = new Actualizar_Periodo(false);
                nuevo.ShowDialog();
            }
            else if (nombre_tab == "Tipos_Clientes_tabPage")
            {
                Actualizar_Tipo_Cliente nuevo = new Actualizar_Tipo_Cliente(false);
                nuevo.ShowDialog();
            }
            else if (nombre_tab == "Tipos_Egresos_tabPage")
            {
                Actualizar_Tipo_Egreso nuevo = new Actualizar_Tipo_Egreso(false);
                nuevo.ShowDialog();
            }
            else if (nombre_tab == "Tipos_Pagos_tabPage")
            {
                Actualizar_Tipo_Pago nuevo = new Actualizar_Tipo_Pago(false);
                nuevo.ShowDialog();
            }
            else if (nombre_tab == "Grupos_tabPage")
            {
                Sporting_Gym.Forms.Grupos grupo = new Sporting_Gym.Forms.Grupos();
                grupo.ShowDialog();
            }
            else if (nombre_tab == "Colonia_tabPage")
            {
                Actualizar_Colonias nuevo = new Actualizar_Colonias(false);
                nuevo.ShowDialog();
            }

            carga_gridview("");
        }

        private void generales_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridViewGeneral = (DataGridView)sender;

            if (e.RowIndex <= -1)
                return;

            if (gridViewGeneral.Name == "periodos_dataGridView")
            {
                string id_periodo = periodos_dataGridView[0, e.RowIndex].Value.ToString();
                id_seleccion = Convert.ToInt32(id_periodo);
                Actualizar_Periodo actualizar = new Actualizar_Periodo(id_seleccion, true);
                actualizar.ShowDialog();
            }
            else if (gridViewGeneral.Name == "tipo_clientes_dataGridView")
            {
                string id_tipo_cliente = tipo_clientes_dataGridView[0, e.RowIndex].Value.ToString();
                id_seleccion = Convert.ToInt32(id_tipo_cliente);
                Actualizar_Tipo_Cliente actualizar = new Actualizar_Tipo_Cliente(id_seleccion, true);
                actualizar.ShowDialog();
            }
            else if (gridViewGeneral.Name == "tipos_egresos_dataGridView")
            {
                string id_tipo_egreso = tipos_egresos_dataGridView[0, e.RowIndex].Value.ToString();
                id_seleccion = Convert.ToInt32(id_tipo_egreso);
                Actualizar_Tipo_Egreso actualizar = new Actualizar_Tipo_Egreso(id_seleccion, true);
                actualizar.ShowDialog();
            }
            else if (gridViewGeneral.Name == "tipos_pagos_dataGridView")
            {
                string id_tipo_pago = tipos_pagos_dataGridView[0, e.RowIndex].Value.ToString();
                id_seleccion = Convert.ToInt32(id_tipo_pago);
                Actualizar_Tipo_Pago actualizar = new Actualizar_Tipo_Pago(id_seleccion, true);
                actualizar.ShowDialog();
            }
            else if (gridViewGeneral.Name == "Instructores_dataGridView")
            {
                string id_tipo_instructor = Instructores_dataGridView[0, e.RowIndex].Value.ToString();
                id_seleccion = Convert.ToInt32(id_tipo_instructor);
                Actualizar_Instructor actualizar = new Actualizar_Instructor(id_seleccion, true);
                actualizar.ShowDialog();
            }
            else if (gridViewGeneral.Name == "tipos_grupos_dataGridView")
            {
                string id_grupo = tipos_grupos_dataGridView[0, e.RowIndex].Value.ToString();
                id_seleccion = Convert.ToInt32(id_grupo);
                var id_t_cliente = (from leer in contexto.Grupos where leer.id_grupo == id_seleccion select leer).First();
                Nuevo_Grupo actualizar = new Nuevo_Grupo(id_seleccion, true, Convert.ToInt32(id_t_cliente.id_tipo_cliente));
                actualizar.ShowDialog();
            }else if(gridViewGeneral.Name == "colonia_dataGridView")
            {
                string id_colonia = colonia_dataGridView[0, e.RowIndex].Value.ToString();
                id_seleccion = Convert.ToInt32(id_colonia);
                Actualizar_Colonias actualizar = new Actualizar_Colonias(id_seleccion, true);
                actualizar.ShowDialog();
            }

            carga_gridview("");

        }

        //CHECAR    
        public void carga_gridview(string txt_buscar)
        {
            string nombre_tab = Catalogos_tabControl.TabPages[Catalogos_tabControl.SelectedIndex].Name;

            switch (nombre_tab)
            {
                case "Instructores_tabPage":
                    var instructores = contexto.sp_Buscar_Instructor(txt_buscar).ToList();
                    if (instructores.Count != 0 || txt_buscar == "")
                    {
                        Instructores_dataGridView.DataSource = instructores;
                    }
                    else
                    {
                        MessageBox.Show("Instructor no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Periodos_tabPage":
                    var periodos = contexto.sp_Buscar_Periodo(txt_buscar).ToList();
                    if (periodos.Count != 0 || txt_buscar == "")
                    {
                        periodos_dataGridView.DataSource = periodos;
                    }
                    else
                    {
                        MessageBox.Show("Periodo no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Tipos_Clientes_tabPage":
                    var tipos_clientes = contexto.sp_Buscar_Tipo_Clientes(txt_buscar).ToList();
                    if (tipos_clientes.Count != 0 || txt_buscar == "")
                    {
                        tipo_clientes_dataGridView.DataSource = tipos_clientes;
                    }
                    else
                    {
                        MessageBox.Show("Tipo Cliente no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Tipos_Egresos_tabPage":
                    var tipos_egresos = contexto.sp_Buscar_Tipo_Egresos(txt_buscar).ToList();
                    if (tipos_egresos.Count != 0 || txt_buscar == "")
                    {
                        tipos_egresos_dataGridView.DataSource = tipos_egresos;
                    }
                    else
                    {
                        MessageBox.Show("Tipo egreso no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                case "Tipos_Pagos_tabPage":
                    var tipos_pagos = contexto.sp_Buscar_Tipo_Pagos(txt_buscar).ToList();
                    if (tipos_pagos.Count != 0 || txt_buscar == "")
                    {

                        tipos_pagos_dataGridView.DataSource = tipos_pagos;
                    }
                    else
                    {
                        MessageBox.Show("Tipo pago no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "Grupos_tabPage":
                    var tipos_grupos = contexto.sp_Buscar_Grupo(txt_buscar).ToList();
                    if (tipos_grupos.Count != 0 || txt_buscar == "")
                    {
                        tipos_grupos_dataGridView.DataSource = tipos_grupos;
                        tipos_grupos_dataGridView.Columns[0].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Tipo de grupo no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "Colonia_tabPage":
                    var colonias = contexto.sp_Buscar_Colonia(txt_buscar).ToList();
                    if (colonias.Count != 0 || txt_buscar == "")
                    {
                        colonia_dataGridView.DataSource = colonias;
                        colonia_dataGridView.Columns[0].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Colonia no encontrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }

            borrar_campo();
        }

        public void borrar_campo()
        {
            if (Instructores_dataGridView.ColumnCount != 0)
            {
                Instructores_dataGridView.Columns[0].Visible = false;
            }

            if (periodos_dataGridView.ColumnCount != 0)
            {
                periodos_dataGridView.Columns[0].Visible = false;
            }

            if (tipos_egresos_dataGridView.ColumnCount != 0)
            {
                tipos_egresos_dataGridView.Columns[0].Visible = false;
            }

            if (tipo_clientes_dataGridView.ColumnCount != 0)
            {
                tipo_clientes_dataGridView.Columns[0].Visible = false;
            }

            if (tipos_pagos_dataGridView.ColumnCount != 0)
            {
                tipos_pagos_dataGridView.Columns[0].Visible = false;
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costo_button_Click(object sender, EventArgs e)
        {
            Actualizar_Costos costos_periodo = new Actualizar_Costos("Periodo", 1);
            costos_periodo.ShowDialog();
        }

        private void precios_button_Click(object sender, EventArgs e)
        {
            Actualizar_Costos costos_periodo = new Actualizar_Costos("Tipos Clientes", 1);
            costos_periodo.ShowDialog();
        }

    }
}
