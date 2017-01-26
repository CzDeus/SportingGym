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
    public partial class Cancelar_Pago : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        int id_pago;
        int posicion_anterior;
        public bool primera = false;
        public bool entre = true;

        int periodo;
        int id_cliente;

        public Cancelar_Pago()
        {
            InitializeComponent();
        }

        private void Cancelar_Pago_Load(object sender, EventArgs e)
        {
            if (entre == true)
            {
                csResizeForm ResizeForm = new csResizeForm();
                ResizeForm.ResizeForm(this, 800, 600);
            }
            var pago = contexto.sp_Leer_Fechas_Pagos();
            //var pago = (from x in contexto.Tabla_Pagos
            //            join c in contexto.Catalogo_Clientes on x.id_cliente equals c.id_cliente
            //            where x.cancelado == false
            //            orderby x.fecha_pago descending
            //            select new { Pago = x.id_pago, Nombre_Cliente = c.nombre + "  " + c.apellido_paterno + " " + c.apellido_materno, Fecha_Pago = x.fecha_pago, Importe_Pagado = x.importe_pagado }).ToList();
            pagos_dataGridView.DataSource = pago;
        }

        private void pagos_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pago = Convert.ToInt32(pagos_dataGridView[0, e.RowIndex].Value);

            Ficha_Historial ficha = new Ficha_Historial(id_pago);
            ficha.ShowDialog();
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            if (justificacion_textBox.Text != "")
            {
                var cancelar = (from x in contexto.Tabla_Pagos where x.id_pago == id_pago select x).Single();

                cancelar.cancelado = true;
                cancelar.fecha_cancelacion = DateTime.Now;
                cancelar.justificacion_cancelacion = justificacion_textBox.Text;

                periodo = Convert.ToInt32(cancelar.id_periodo);
                id_cliente = Convert.ToInt32(cancelar.id_cliente);

                contexto.SaveChanges();

                Restar_Dias();

                MessageBox.Show("Pago Cancelado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                entre = false;
                Cancelar_Pago_Load(null, null);
                justificacion_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese una justificacion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Restar_Dias()
        {
            DateTime fecha_corte = new DateTime();

            int id_periodo = Convert.ToInt32(periodo);
            int dias = Convert.ToInt32((from Catalogo_Periodos in contexto.Catalogo_Periodos where Catalogo_Periodos.id_periodo == id_periodo select Catalogo_Periodos.dias).Single());

            var datos_cliente = contexto.sp_Buscar_Clientes_Id(id_cliente).ToList();

            if (datos_cliente[0].fecha_corte != null)
            {

                DateTime fecha_corte_registro = (DateTime)datos_cliente[0].fecha_corte;
                int comparar = DateTime.Compare(fecha_corte_registro, DateTime.Now);

                if (comparar < 0)
                {
                    fecha_corte = DateTime.Now.AddDays(-dias);
                }
                else if (comparar >= 0)
                {
                    fecha_corte = fecha_corte_registro.AddDays(-dias);
                }
            }
            else
            {
                fecha_corte = DateTime.Now.AddDays(-dias);
            }

            var fechas = (from buscar in contexto.Catalogo_Clientes where buscar.id_cliente == id_cliente select buscar).First();
            fechas.fecha_corte = fecha_corte;
            contexto.SaveChanges();

        }

        private void pagos_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }

            if (primera == true)
            {
                pagos_dataGridView.Rows[posicion_anterior].DefaultCellStyle.BackColor = DefaultBackColor;
            }

            pagos_dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            posicion_anterior = e.RowIndex;

            id_pago = Convert.ToInt32(pagos_dataGridView[0, e.RowIndex].Value);

            primera = true;
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
