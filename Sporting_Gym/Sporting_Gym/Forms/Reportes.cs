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
using System.IO;

namespace Sporting_Gym.Forms
{
    public partial class Reportes : Form
    {
        List<Catalogo_Clientes> lista_clientes_vencidos = new List<Catalogo_Clientes>();
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        int v_id_cliente = 0;
        int numero_reporte = 0;

        DateTime f1, f2;
        double valor_fecha;

        int id_usuario;

        public Reportes()
        {
            InitializeComponent();
        }

        public Reportes(int numero_reporte, int id_usuario)
        {
            InitializeComponent();

            this.numero_reporte = numero_reporte;
            this.id_usuario = id_usuario;

            if(numero_reporte == 1)
            {
                Fecha_Inicial_label.Text = "Fecha Corte";
                Fecha_Final_label.Visible = false;
               Final_dateTimePicker.Visible = false;
            }

            if (numero_reporte == 3)
            {
                Inicial_dateTimePicker.Visible = false;
                Final_dateTimePicker.Visible = false;
                Fecha_Final_label.Visible = false;
                Fecha_Inicial_label.Visible = false;
            }

            visualizar_report();
        }

        private void Imprimir_button_Click(object sender, EventArgs e)
        {
            if (numero_reporte == 1)
            {
                Corte_Caja();
            }
            else if (numero_reporte == 2)
            {
                Acceso_Sin_Pagar();
            }
            else if (numero_reporte == 3)
            {
                Proyeccion_Ingresos();
            }
            else if (numero_reporte == 4)
            {
                Clientes_Sin_Renovar();
            }
            else if (numero_reporte == 5)
            {
                reporte_clientes_generales();
            }
            else if (numero_reporte == 6)
            {
                reporte_egresos();
            }
            else if (numero_reporte == 7)
            {
                reporte_balance();
            }

        }

        private void reporte_balance()
        {
            valor_fecha = Validar_Fechas();

            if (valor_fecha <= 0)
            {
                sp_Rpt_Folios_EgresosTableAdapter corte = new sp_Rpt_Folios_EgresosTableAdapter();
                Sporting_Gym_Dataset.sp_Rpt_Folios_EgresosDataTable tabla_acceso = new Sporting_Gym_Dataset.sp_Rpt_Folios_EgresosDataTable();
                corte.Fill(tabla_acceso, f1, f2);

                sp_Rpt_EgresosTableAdapter egresos = new sp_Rpt_EgresosTableAdapter();
                Sporting_Gym_Dataset.sp_Rpt_EgresosDataTable tabla_acceso2 = new Sporting_Gym_Dataset.sp_Rpt_EgresosDataTable();
                egresos.Fill(tabla_acceso2, f1, f2);

                sp_Rpt_Corte_Caja_total_tipo_cliente_2TableAdapter total = new sp_Rpt_Corte_Caja_total_tipo_cliente_2TableAdapter();
                Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_tipo_cliente_2DataTable tabla_acceso3 = new Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_tipo_cliente_2DataTable();
                total.Fill(tabla_acceso3, f1, f2);

                ReportDataSource total_clientes = new ReportDataSource("Totales_Tipo_Cliente", (DataTable)tabla_acceso3);
                ReportDataSource corte_datasource = new ReportDataSource("Folios_DataSet", (DataTable)tabla_acceso);
                ReportDataSource egresos_datasource = new ReportDataSource("Egresos_DataSet", (DataTable)tabla_acceso2);

                Balance_reportViewer.LocalReport.DataSources.Clear();

                Balance_reportViewer.LocalReport.DataSources.Add(corte_datasource);
                Balance_reportViewer.LocalReport.DataSources.Add(egresos_datasource);
                Balance_reportViewer.LocalReport.DataSources.Add(total_clientes);

                Balance_reportViewer.LocalReport.Refresh();
                Balance_reportViewer.RefreshReport();
            }
            else
            {
                MessageBox.Show("Verifique las fechas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reporte_egresos()
        {
            sp_Rpt_EgresosTableAdapter egresos = new sp_Rpt_EgresosTableAdapter();
            Sporting_Gym_Dataset.sp_Rpt_EgresosDataTable tabla_accesos = new Sporting_Gym_Dataset.sp_Rpt_EgresosDataTable();

            valor_fecha = Validar_Fechas();

            if (valor_fecha <= 0)
            {
                egresos.Fill(tabla_accesos, f1, f2);

                ReportDataSource detalle_datasource = new ReportDataSource("Egresos_DataSet", (DataTable)tabla_accesos);

                Egresos_reportViewer.LocalReport.DataSources.Clear();

                Egresos_reportViewer.LocalReport.DataSources.Add(detalle_datasource);

                Egresos_reportViewer.LocalReport.Refresh();
                Egresos_reportViewer.RefreshReport();
            }
            else
            {
                MessageBox.Show("Verifique las fechas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reporte_clientes_generales()
        {
            valor_fecha = Validar_Fechas();

            if (valor_fecha <= 0)
            {
                sp_Clientes_VigentesTableAdapter vigentes = new sp_Clientes_VigentesTableAdapter();
                Sporting_Gym_Dataset.sp_Clientes_VigentesDataTable tabla_vigentes = new Sporting_Gym_Dataset.sp_Clientes_VigentesDataTable();
                vigentes.Fill(tabla_vigentes);

                sp_Clientes_VencidosTableAdapter vencidos = new sp_Clientes_VencidosTableAdapter();
                Sporting_Gym_Dataset.sp_Clientes_VencidosDataTable tabla_vencidos = new Sporting_Gym_Dataset.sp_Clientes_VencidosDataTable();
                vencidos.Fill(tabla_vencidos);

                sp_Clientes_ReinscritosTableAdapter reinscritos = new sp_Clientes_ReinscritosTableAdapter();
                Sporting_Gym_Dataset.sp_Clientes_ReinscritosDataTable tabla_reinscritos = new Sporting_Gym_Dataset.sp_Clientes_ReinscritosDataTable();
                reinscritos.Fill(tabla_reinscritos, f1, f2);

                sp_Clientes_NuevosTableAdapter nuevos = new sp_Clientes_NuevosTableAdapter();
                Sporting_Gym_Dataset.sp_Clientes_NuevosDataTable tabla_nuevos = new Sporting_Gym_Dataset.sp_Clientes_NuevosDataTable();
                nuevos.Fill(tabla_nuevos, f1, f2);

                sp_Rpt_totales_clientesTableAdapter totales = new sp_Rpt_totales_clientesTableAdapter();
                Sporting_Gym_Dataset.sp_Rpt_totales_clientesDataTable tabla_totales = new Sporting_Gym_Dataset.sp_Rpt_totales_clientesDataTable();
                totales.Fill(tabla_totales, f1, f2);

                ReportDataSource clientes_vigentes = new ReportDataSource("Clientes_Vigentes_DataSet", (DataTable)tabla_vigentes);
                ReportDataSource clientes_vencidos = new ReportDataSource("Clientes_Vencidos_DataSet", (DataTable)tabla_vencidos);
                ReportDataSource clientes_reinscritos = new ReportDataSource("Clientes_Reinscritos_DataSet", (DataTable)tabla_reinscritos);
                ReportDataSource clientes_nuevos = new ReportDataSource("Clientes_Nuevos_DataSet", (DataTable)tabla_nuevos);
                ReportDataSource clientes_totales = new ReportDataSource("Totales_Clientes_DataSet", (DataTable)tabla_totales);

                reporte_Generales_reportViewer.LocalReport.DataSources.Clear();

                reporte_Generales_reportViewer.LocalReport.DataSources.Add(clientes_vencidos);
                reporte_Generales_reportViewer.LocalReport.DataSources.Add(clientes_vigentes);
                reporte_Generales_reportViewer.LocalReport.DataSources.Add(clientes_reinscritos);
                reporte_Generales_reportViewer.LocalReport.DataSources.Add(clientes_nuevos);
                reporte_Generales_reportViewer.LocalReport.DataSources.Add(clientes_totales);
                reporte_Generales_reportViewer.LocalReport.Refresh();
                reporte_Generales_reportViewer.RefreshReport();
            }
            else
            {
                MessageBox.Show("Verifique las fechas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Corte_Caja()
        {

            sp_Rpt_Corte_CajaTableAdapter corte_caja = new sp_Rpt_Corte_CajaTableAdapter();
            Sporting_Gym_Dataset.sp_Rpt_Corte_CajaDataTable tabla_accesos = new Sporting_Gym_Dataset.sp_Rpt_Corte_CajaDataTable();

            sp_Rpt_Corte_Caja_total_tipo_clienteTableAdapter total_tipo_cliente_tableAdapter = new sp_Rpt_Corte_Caja_total_tipo_clienteTableAdapter();
            Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_tipo_clienteDataTable total_tipo_cliente_dataTable = new Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_tipo_clienteDataTable();

            sp_Rpt_Corte_Caja_total_periodoTableAdapter total_periodos_tableAdapter = new sp_Rpt_Corte_Caja_total_periodoTableAdapter();
            Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_periodoDataTable total_periodos_dataTable = new Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_periodoDataTable();

            sp_Rpt_Corte_Caja_total_metodo_pagoTableAdapter metodo_pago_tableAdapter = new sp_Rpt_Corte_Caja_total_metodo_pagoTableAdapter();
            Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_metodo_pagoDataTable metodo_pago_dataTable = new Sporting_Gym_Dataset.sp_Rpt_Corte_Caja_total_metodo_pagoDataTable();

            valor_fecha = Validar_Fechas();

            if (valor_fecha <= 0)
            {
                corte_caja.Fill(tabla_accesos, f1, id_usuario);
                total_tipo_cliente_tableAdapter.Fill(total_tipo_cliente_dataTable, f1);
                total_periodos_tableAdapter.Fill(total_periodos_dataTable, f1);
                metodo_pago_tableAdapter.Fill(metodo_pago_dataTable, f1, f2);

                ReportDataSource detalle_datasource = new ReportDataSource("Corte_De_Caja_Dataset", (DataTable)tabla_accesos);
                ReportDataSource total_tipo_cliente_datasource = new ReportDataSource("Totalizado_Tipo_Cliente_DataSet", (DataTable)total_tipo_cliente_dataTable);
                ReportDataSource total_periodos_datasource = new ReportDataSource("Periodo_DataSet", (DataTable)total_periodos_dataTable);
                ReportDataSource metodo_pago_datasource = new ReportDataSource("Metodo_Pago_DataSet", (DataTable)metodo_pago_dataTable);

                corte_caja_reportViewer.LocalReport.DataSources.Clear();

                //IMPRIME CORTE DE CAJA
                corte_caja_reportViewer.LocalReport.DataSources.Add(total_tipo_cliente_datasource);
                corte_caja_reportViewer.LocalReport.DataSources.Add(detalle_datasource);
                corte_caja_reportViewer.LocalReport.DataSources.Add(total_periodos_datasource);
                corte_caja_reportViewer.LocalReport.DataSources.Add(metodo_pago_datasource);

                corte_caja_reportViewer.LocalReport.Refresh();
                corte_caja_reportViewer.RefreshReport();
            }
            else
            {
                MessageBox.Show("Verifique las fechas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Acceso_Sin_Pagar()
        {
            var vencidos = (from x in contexto.Bitacora_Asistencias where x.estatus == false select x).ToList();

            if (vencidos.Count > 0)
            {
                sp_Rpt_Acesso_Sin_Pago_DetalleTableAdapter reporte_acessos_sin_pago = new sp_Rpt_Acesso_Sin_Pago_DetalleTableAdapter();
                Sporting_Gym_Dataset.sp_Rpt_Acesso_Sin_Pago_DetalleDataTable tabla_accesos = new Sporting_Gym_Dataset.sp_Rpt_Acesso_Sin_Pago_DetalleDataTable();

                valor_fecha = Validar_Fechas();

                if (valor_fecha <= 0)
                {
                    for (int x = 0; x < vencidos.Count; x++)
                    {
                        v_id_cliente = Convert.ToInt32(vencidos[x].id_cliente);

                        //DateTime fecha_ingreso = Convert.ToDateTime(vencidos[x].fecha_ingreso);


                        //double a = fecha_ingreso.Subtract(f1).TotalDays;
                        //double b = fecha_ingreso.Subtract(f2).TotalDays;

                        //if(a > 0 && b < 1)
                        //{
                        DateTime fecha2 = f2.AddDays(1);
                        reporte_acessos_sin_pago.Fill(tabla_accesos, v_id_cliente, f1, fecha2);
                        //}
                    }

                    // AGREGA DATASETS
                    ReportDataSource detalle_datasource = new ReportDataSource("Acesso_Sin_Pago_Detalle_DataSet", (DataTable)tabla_accesos);
                    accesos_no_vigentes_reportViewer.LocalReport.DataSources.Clear();

                    //IMPRIME NOTA DE VENTA
                    //Reporte_reportViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reporte\AccesoSinPago.rdlc";
                    accesos_no_vigentes_reportViewer.LocalReport.DataSources.Add(detalle_datasource);
                    accesos_no_vigentes_reportViewer.LocalReport.Refresh();
                    accesos_no_vigentes_reportViewer.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Verifique las fechas", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Lista sin elementos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Proyeccion_Ingresos()
        {

            string path = Directory.GetCurrentDirectory();

            string uri = @"C:\Temp\ReportesSportingGym\Proyeccion_Ingresos.rdlc";
            string uri_1 = @"C:\Temp\ReportesSportingGym\Proyeccion_Ingresos_1.rdlc";

            csDynamicColumns cs = new csDynamicColumns();
            DataTable dt = cs.Genera_RDLC(ref uri_1, uri);

            ReportDataSource dataSource = new ReportDataSource("Proyeccion_ingresos_DataSet", dt);
            proyeccion_ingresos_reportViewer.LocalReport.DataSources.Clear();

            proyeccion_ingresos_reportViewer.LocalReport.ReportEmbeddedResource = "Sporting_Gym.Reportes.Proyeccion_Ingresos_1.rdlc";
            proyeccion_ingresos_reportViewer.LocalReport.DataSources.Add(dataSource);
            proyeccion_ingresos_reportViewer.LocalReport.Refresh();
            proyeccion_ingresos_reportViewer.RefreshReport();
            //this.proyeccion_ingresos_reportViewer.RefreshReport();
        }

        private void Clientes_Sin_Renovar()
        {
            Actualizar_Fecha_Vencimiento();

            var sin_renovar = (from x in contexto.Catalogo_Clientes where x.estatus == false select x).ToList();

            sp_Rpt_Clientes_No_RenovaronTableAdapter no_renovaron = new sp_Rpt_Clientes_No_RenovaronTableAdapter();
            Sporting_Gym_Dataset.sp_Rpt_Clientes_No_RenovaronDataTable tabla_Accesos = new Sporting_Gym_Dataset.sp_Rpt_Clientes_No_RenovaronDataTable();

            valor_fecha = Validar_Fechas();

            if (valor_fecha <= 0)
            {

                for (int x = 0; x < sin_renovar.Count; x++)
                {
                    v_id_cliente = Convert.ToInt32(sin_renovar[0].id_cliente);
                    no_renovaron.Fill(tabla_Accesos, v_id_cliente, f1, f2);
                }

                // AGREGA DATASETS
                ReportDataSource detalle_datasource = new ReportDataSource("Clientes_No_Renovaron_Dataset", (DataTable)tabla_Accesos);
                clientes_sin_renovar_reportViewer.LocalReport.DataSources.Clear();

                //IMPRIME NOTA DE VENTA
                //Reporte_reportViewer.LocalReport.ReportPath = Application.StartupPath + @"\Reporte\Clientes_Sin_Renovar.rdlc";
                clientes_sin_renovar_reportViewer.LocalReport.DataSources.Add(detalle_datasource);
                clientes_sin_renovar_reportViewer.LocalReport.Refresh();
                clientes_sin_renovar_reportViewer.RefreshReport();
            }
            else
            {
                MessageBox.Show("Verifique las fechas", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Actualizar_Fecha_Vencimiento()
        {
            int comparar = 0;

            var clientes = (from verificar in contexto.Catalogo_Clientes where verificar.estatus == true select verificar).ToList();

            for (int x = 0; x < clientes.Count; x++)
            {
                comparar = DateTime.Compare(Convert.ToDateTime(clientes[x].fecha_corte), DateTime.Now);

                if (comparar < 0)
                {
                    clientes[x].estatus = false;
                    contexto.SaveChanges();
                }
            }
        }

        private double Validar_Fechas()
        {
            f1 = Convert.ToDateTime(Inicial_dateTimePicker.Text);

            if (numero_reporte != 1)
            {
                f2 = Convert.ToDateTime(Final_dateTimePicker.Text);
            }
            else
            {
                f2 = f1;
            }

            double a = f1.Subtract(f2).TotalDays;

            return a;
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
            this.corte_caja_reportViewer.RefreshReport();
            this.Balance_reportViewer.RefreshReport();
        }

        private void visualizar_report()
        {
            if (numero_reporte == 1)
            {
                corte_caja_reportViewer.Visible = true;
            }
            else if (numero_reporte == 2)
            {
                accesos_no_vigentes_reportViewer.Visible = true;
            }
            else if (numero_reporte == 3)
            {
                proyeccion_ingresos_reportViewer.Visible = true;
            }
            else if (numero_reporte == 4)
            {
                clientes_sin_renovar_reportViewer.Visible = true;
            }
            else if (numero_reporte == 5)
            {
                reporte_Generales_reportViewer.Visible = true;
            }
            else if (numero_reporte == 6)
            {
                Egresos_reportViewer.Visible = true;
            }
            else if (numero_reporte == 7)
            {
                Balance_reportViewer.Visible = true;
            }
        }
    }
}
