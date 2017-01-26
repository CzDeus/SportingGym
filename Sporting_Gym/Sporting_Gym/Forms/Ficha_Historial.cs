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
using Sporting_Gym.DATASET;
using Sporting_Gym.DATASET.Sporting_Gym_DatasetTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Sporting_Gym.Forms
{
    public partial class Ficha_Historial : Form
    {
        int id_pago;
        private static db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        public Ficha_Historial()
        {
            InitializeComponent();
        }

        public Ficha_Historial(int id_pago)
        {
            InitializeComponent();
            this.id_pago = id_pago;
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            var info = contexto.sp_Buscar_Pago(id_pago).ToList();

            int id_cliente = Convert.ToInt32(info[0].id_cliente);

            var nombre_cliente = (from x in contexto.Catalogo_Clientes where x.id_cliente == id_cliente select x).Single();

            nombre_label.Text = nombre_cliente.nombre + " " + nombre_cliente.apellido_paterno + " " + nombre_cliente.apellido_materno;
            fecha_pago_textBox.Text = info[0].Fecha.ToString();
            metodo_pago_textBox.Text = info[0].Método_de_Pago;
            periodo_textBox.Text = info[0].Período;
            tipo_cliente_textBox.Text = info[0].Tipo_Cliente;
            impore_pagar_textBox.Text = info[0].importe_a_pagar.ToString();
            importe_pagado_textBox.Text = info[0].importe_pagado.ToString();
            justificacion_textBox.Text = info[0].justificacion;
            observacion_textBox.Text = info[0].observaciones;

            this.reporte_reportViewer.RefreshReport();
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imprime_recibo_pago(id_pago, importe_pagado_textBox.Text);
        }

        private void imprime_recibo_pago(int id_pago_registrado, string wimp_letra)
        {
            //MANDAR IMPRIMIR 
            sp_Recibo_de_PagoTableAdapter recibo_pago_tableAdapter = new sp_Recibo_de_PagoTableAdapter();
            Sporting_Gym_Dataset.sp_Recibo_de_PagoDataTable recibo_pago_dataTable = new Sporting_Gym_Dataset.sp_Recibo_de_PagoDataTable();

            recibo_pago_tableAdapter.Fill(recibo_pago_dataTable, id_pago_registrado, wimp_letra);

            ReportDataSource recibo_pago_datasource = new ReportDataSource("Recibo_de_Pago_DataSet", (DataTable)recibo_pago_dataTable);
            reporte_reportViewer.LocalReport.DataSources.Clear();

            reporte_reportViewer.LocalReport.DataSources.Add(recibo_pago_datasource);
            reporte_reportViewer.LocalReport.Refresh();
            reporte_reportViewer.RefreshReport();

            ReportPrintDocument print = new ReportPrintDocument(reporte_reportViewer.LocalReport);
            print.Print();

            //FIN IMPRESION DE RECIBO DE PAGO

        }
    }
}
