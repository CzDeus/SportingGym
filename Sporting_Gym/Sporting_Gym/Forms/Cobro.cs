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
    public partial class Cobro : Form
    {

        db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        int id_cliente = 0;
        bool primeravez = true;

        int id_grupo = 0;
        Convierte_Numero_a_Letra_Class vconvertidor = new Convierte_Numero_a_Letra_Class();

        bool listo = false;

        public Cobro()
        {
            InitializeComponent();
        }

        public Cobro(int id_cliente)
        {
            InitializeComponent();

            this.id_cliente = id_cliente;

            var nombre = contexto.sp_Buscar_Clientes_Id(id_cliente).ToList();

            nombre_textBox.Text = nombre[0].nombre + " " + nombre[0].apellido_paterno + " " + nombre[0].apellido_materno;

            buscar_button.Visible = false;

        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            llenar_comoboBox();

            int id_cliente = Convert.ToInt32(tipo_cliente_comboBox.SelectedValue);
            int id_periodo = Convert.ToInt32(periodo_comboBox.SelectedValue);

            //var importepagar = contexto.sp_Importe_Pagar(a, b).ToString();
            var importePagar = (from x in contexto.Costo_Cliente_Periodo where x.id_periodo == id_periodo && x.id_tipo_cliente == id_cliente select x).ToList();
            //"Tipo cliente: " + tipo_cliente_comboBox.SelectedValue + ", Periodo: " + periodo_comboBox.SelectedValue
            //MessageBox.Show(Convert.ToString( importePagar[0].costo));
            if (importePagar.Count != 0)
            {
                importe_pagar_textBox.Text = Convert.ToString(importePagar[0].costo);
                total_textBox.Text = importe_pagar_textBox.Text;
            }
            else
            {
                this.Close();
                MessageBox.Show("Verifique catalogo de periodos y/o tipo cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            primeravez = false;
            this.reporte_reportViewer.RefreshReport();
        }

        private void si_descuento_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            cantidad_descuento_textBox.Enabled = true;
            justificacion_textBox.ReadOnly = false;
        }

        private void no_descuento_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            cantidad_descuento_textBox.Enabled = false;
            justificacion_textBox.ReadOnly = true;
            cantidad_descuento_textBox.Text = "";
            justificacion_textBox.Text = "";
        }

        private void cantidad_descuento_textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void llenar_comoboBox()
        {
            List<Catalogo_Metodos_Pagos> forma_pago = (from Catalogo_Metodos_Pagos in contexto.Catalogo_Metodos_Pagos select Catalogo_Metodos_Pagos).ToList();
            tipo_pago_comboBox.ValueMember = "id_metodo_pago";
            tipo_pago_comboBox.DisplayMember = "nombre_metodo_pago";
            tipo_pago_comboBox.DataSource = forma_pago;

            List<Catalogo_Tipos_Clientes> tipo_cliente = (from Catalogo_Tipos_Clientes in contexto.Catalogo_Tipos_Clientes select Catalogo_Tipos_Clientes).ToList();
            tipo_cliente_comboBox.ValueMember = "id_tipo_cliente";
            tipo_cliente_comboBox.DisplayMember = "nombre_tipo_cliente";
            tipo_cliente_comboBox.DataSource = tipo_cliente;

            List<Catalogo_Periodos> periodo = (from Catalogo_Periodos in contexto.Catalogo_Periodos select Catalogo_Periodos).ToList();
            periodo_comboBox.ValueMember = "id_periodo";
            periodo_comboBox.DisplayMember = "nombre_periodo";
            periodo_comboBox.DataSource = periodo;

            //fecha_textBox.Text = DateTime.Now.ToShortDateString();
        }

        private void cobrar_button_Click(object sender, EventArgs e)
        {


            int id_usuario_capturo = ((Login)Application.OpenForms["Login"]).idUsuario;
            double total_pago = Convert.ToDouble(total_textBox.Text);
            string wimp_letra = vconvertidor.convierte(Convert.ToString(total_pago));
            int id_pago_registrado = 0;

            if (id_cliente != 0)
            {

                if (si_descuento_radioButton.Checked == true && justificacion_textBox.Text == "")
                {
                    MessageBox.Show("Ingrese justificacion para el descuento", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Recibido_textBox.Text != "")
                {
                    if (MessageBox.Show("El cobro se realizar ¿Continuar?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        double recibido = Convert.ToDouble(Recibido_textBox.Text);
                        double cambio = Convert.ToDouble(Cambio_textBox.Text);
                        if (id_grupo == 0)
                        {
                            verificar_tipo_cliente();

                            DateTime fecha_corte = calcular_fecha_corte();
                            id_pago_registrado = Convert.ToInt32(contexto.sp_Actualizar_Cliente_Pago(id_cliente, Convert.ToInt32(tipo_cliente_comboBox.SelectedValue), Convert.ToInt32(periodo_comboBox.SelectedValue),
                                Convert.ToInt32(tipo_pago_comboBox.SelectedValue), 0, Convert.ToDouble(importe_pagar_textBox.Text), recibido, cambio, total_pago,
                                justificacion_textBox.Text, observaciones_textBox.Text, fecha_corte, id_usuario_capturo).First());

                            var borrar_registro_hoy = (from buscar in contexto.Bitacora_Asistencias where buscar.id_cliente == id_cliente && buscar.estatus == false select buscar).ToList();

                            if (borrar_registro_hoy.Count > 0)
                            {
                                foreach (var borrar in borrar_registro_hoy)
                                {
                                    contexto.Bitacora_Asistencias.Remove(borrar);
                                    contexto.SaveChanges();
                                }
                            }

                            if (Convert.ToDouble(importe_pagar_textBox.Text) != 0) {
                                imprime_recibo_pago(id_pago_registrado, wimp_letra);
                            }
                        }
                        else
                        {
                            var integrantes = (from totales in contexto.Catalogo_Clientes where totales.id_grupo == id_grupo select totales).ToList();

                            double precioXcliente = Convert.ToInt32(total_textBox.Text) / integrantes.Count;

                            for (int x = 0; x < integrantes.Count; x++)
                            {
                                verificar_tipo_cliente();
                                DateTime fecha_corte = calcular_fecha_corte();
                                id_pago_registrado = Convert.ToInt32(contexto.sp_Actualizar_Cliente_Pago(integrantes[x].id_cliente, Convert.ToInt32(tipo_cliente_comboBox.SelectedValue), Convert.ToInt32(periodo_comboBox.SelectedValue),
                                    Convert.ToInt32(tipo_pago_comboBox.SelectedValue), 0, Convert.ToDouble(importe_pagar_textBox.Text), recibido, cambio, precioXcliente,
                                    justificacion_textBox.Text, observaciones_textBox.Text, fecha_corte, id_usuario_capturo).First());

                                var borrar_registro_hoy = (contexto.sp_Leer_Asistencias(id_cliente));

                                if (Convert.ToDouble(importe_pagar_textBox.Text) != 0)
                                {
                                    imprime_recibo_pago(id_pago_registrado, wimp_letra);
                                }
                            }
                        }


                        MessageBox.Show("Pago registrado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el total recibido", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente por favor", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

            reporte_gym_reportViewer.LocalReport.DataSources.Clear();

            reporte_gym_reportViewer.LocalReport.DataSources.Add(recibo_pago_datasource);
            reporte_gym_reportViewer.LocalReport.Refresh();
            reporte_gym_reportViewer.RefreshReport();

            ReportPrintDocument print2 = new ReportPrintDocument(reporte_gym_reportViewer.LocalReport);
            print2.Print();

            //FIN IMPRESION DE RECIBO DE PAGO

        }

        private void verificar_tipo_cliente()
        {
            var nuevo = (from verificar in contexto.Tabla_Pagos where verificar.id_cliente == id_cliente select verificar).ToList();

            if (nuevo.Count > 0)
            {
                var actualizar = (from buscar in contexto.Catalogo_Clientes where buscar.id_cliente == id_cliente select buscar).First();
                actualizar.nuevo_ingreso = false;
                contexto.SaveChanges();

            }
            else if (nuevo.Count == 0)
            {
                var actualizar = (from buscar in contexto.Catalogo_Clientes where buscar.id_cliente == id_cliente select buscar).First();
                actualizar.nuevo_ingreso = true;
                contexto.SaveChanges();
            }
        }

        private void calcularImportePagar(object sender, EventArgs e)
        {
            if (id_grupo == 0 && tipo_cliente_comboBox.Text == "Grupo")
            {
                MessageBox.Show("No pertecenes a un grupo, seleccione algun otro tipo de cliente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tipo_cliente_comboBox.DroppedDown = true;
                return;
            }

            if (primeravez == false)
            {
                //if (id_grupo == 0 && tipo_cliente_comboBox.Text == "Grupos" || tipo_cliente_comboBox.Text == "Grupo")
                //{
                //    MessageBox.Show("El cliente no forma para de un grupo");
                //    tipo_cliente_comboBox.SelectedValue = 1;
                //    return;
                //}

                int id_tipo_cliente = Convert.ToInt32(tipo_cliente_comboBox.SelectedValue);
                int id_periodo = Convert.ToInt32(periodo_comboBox.SelectedValue);

                var importePagar = (from x in contexto.Costo_Cliente_Periodo where x.id_periodo == id_periodo && x.id_tipo_cliente == id_tipo_cliente select x).ToList();
                importe_pagar_textBox.Text = Convert.ToString(importePagar[0].costo);

                total_textBox.Text = importe_pagar_textBox.Text;

                if (id_grupo != 0)
                {
                    var miembros_grupo = (from miembros in contexto.Catalogo_Clientes where miembros.id_grupo == id_grupo select miembros).ToList();

                    double total = (Convert.ToDouble(miembros_grupo.Count)) * (Convert.ToDouble(total_textBox.Text));
                    importe_pagar_textBox.Text = total.ToString();
                    total_textBox.Text = total.ToString();
                }

                if (si_descuento_radioButton.Checked)
                {
                    int descuento = 0;

                    double subtotal = Convert.ToDouble(importe_pagar_textBox.Text);

                    if (cantidad_descuento_textBox.Text == "")
                    {
                        descuento = 0;
                    }
                    else
                    {
                        descuento = Convert.ToInt32(cantidad_descuento_textBox.Text);
                    }

                    double total = subtotal - descuento;

                    if (total < 0)
                    {
                        MessageBox.Show("Ingrese un descuento valido", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cantidad_descuento_textBox.Text = "";
                    }
                    else
                    {
                        total_textBox.Text = (subtotal - descuento).ToString();
                    }
                }
                else
                {

                }
            }
        }

        private void buscar_button_Click(object sender, EventArgs e)
        {
            Buscar_Cliente clientes = new Buscar_Cliente(true, true);
            clientes.ShowDialog();

            if (clientes._idCliente != 0)
            {
                var catalogo_cliente = contexto.Catalogo_Clientes.Where(x => x.id_cliente == clientes._idCliente).First();

                id_cliente = clientes._idCliente;

                id_grupo = Convert.ToInt32(catalogo_cliente.id_grupo);

                if (id_grupo != 0)
                {
                    var responsable = (from id_responsable in contexto.Grupos where id_responsable.id_grupo == id_grupo select id_responsable).First();

                    if (responsable.id_cliente_responsable != id_cliente)
                    {
                        MessageBox.Show("El cliente pertenece a un grupo, no tiene permiso para realizar pago", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        id_cliente = 0;
                        return;
                    }

                    if (id_grupo > 0)
                    {
                        for (int x = 0; x < tipo_cliente_comboBox.Items.Count; x++)
                        {
                            tipo_cliente_comboBox.SelectedIndex = x;
                            if (catalogo_cliente.id_tipo_cliente == (int)tipo_cliente_comboBox.SelectedValue)
                                break;
                        }
                    }

                    //tipo_cliente_comboBox.Text = "Grupo";
                    info_grupo_button.Visible = true;
                    tipo_cliente_comboBox.Enabled = false;

                    //int index = tipo_cliente_comboBox.FindString("Grupo");
                    //tipo_cliente_comboBox.SelectedIndex = index;

                    int periodo = Convert.ToInt32(catalogo_cliente.id_periodo);

                    calcularImportePagar(null, null);

                    if (periodo != 0)
                    {
                        periodo_comboBox.SelectedValue = periodo;
                    }
                    else
                    {
                        periodo_comboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    info_grupo_button.Visible = false;
                    tipo_cliente_comboBox.Enabled = true;
                }

                nombre_textBox.Text = catalogo_cliente.nombre + " " + catalogo_cliente.apellido_paterno + " " + catalogo_cliente.apellido_materno;
                tipo_cliente_comboBox.SelectedValue = catalogo_cliente.id_tipo_cliente;
                periodo_comboBox.SelectedValue = catalogo_cliente.id_periodo;
            }
        }

        private DateTime calcular_fecha_corte()
        {
            DateTime fecha_corte = new DateTime();

            int id_periodo = Convert.ToInt32(periodo_comboBox.SelectedValue);
            int dias = Convert.ToInt32((from Catalogo_Periodos in contexto.Catalogo_Periodos where Catalogo_Periodos.id_periodo == id_periodo select Catalogo_Periodos.dias).Single());

            var datos_cliente = contexto.sp_Buscar_Clientes_Id(id_cliente).ToList();

            if (datos_cliente[0].fecha_corte != null)
            {

                DateTime fecha_corte_registro = (DateTime)datos_cliente[0].fecha_corte;
                int comparar = DateTime.Compare(fecha_corte_registro, DateTime.Now);

                if (comparar < 0)
                {
                    fecha_corte = DateTime.Now.AddDays(dias);
                }
                else if (comparar >= 0)
                {
                    fecha_corte = fecha_corte_registro.AddDays(dias);
                }
            }
            else
            {
                fecha_corte = DateTime.Now.AddDays(dias);
            }

            return fecha_corte;
        }

        private void regresar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipo_cliente_comboBox_Click(object sender, EventArgs e)
        {
            if (id_grupo != 0)
            {
                MessageBox.Show("El cliente pertenece a un grupo", "information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void info_grupo_button_Click(object sender, EventArgs e)
        {
            Info_Grupos info = new Info_Grupos(id_grupo);
            info.Show();
        }

        private void Recibido_textBox_Leave(object sender, EventArgs e)
        {
            Verificar_Costo();
        }

        private void Cobro_Enter(object sender, EventArgs e)
        {
        }

        private void Recibido_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && listo == false)
            {
                bool valor = Verificar_Costo();
                listo = true;

                if (valor == true)
                {
                    //if (MessageBox.Show("El cobro se realizar ¿Continuar?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    cobrar_button_Click(null, null);
                    //}
                }
            }
        }

        private bool Verificar_Costo()
        {
            if (Recibido_textBox.Text == "")
            {
                Recibido_textBox.Text = "0";
            }

            double recibido = Convert.ToDouble(Recibido_textBox.Text);
            double total = Convert.ToDouble(total_textBox.Text);

            if (recibido >= total)
            {
                Cambio_textBox.Text = Convert.ToDouble(recibido - total).ToString();
                return true;
            }
            else
            {
                Recibido_textBox.Text = "";
                MessageBox.Show("Las cantidad recibidad es menor al total a pagar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}