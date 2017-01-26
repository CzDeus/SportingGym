using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporting_Gym.Forms;
using Sporting_Gym.App_Code.Models;
using System.IO;
using System.Net.Mail;
using System.Net;
using Sporting_Gym.App_Code.Utility;
using Sporting_Gym.App_Code.Entity_Model;

namespace Sporting_Gym
{
    public partial class Principal : Form
    {
        private List<csModulo> Modulos;
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        String[] filePath = null;
        int id_usuario;

        public Principal(object Modulos, int id_usuario)
        {
            InitializeComponent();
            mostrar_submenu("ocultar");

            this.id_usuario = id_usuario;
            this.Modulos = (List<csModulo>)Modulos;
        }

        public Principal()
        {
            InitializeComponent();
            mostrar_submenu("ocultar");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);
            //Sporting_Gym.App_Code.Utility.csDynamicColumns g = new App_Code.Utility.csDynamicColumns();
            //string uri = @"C:\Users\User\Documents\Visual Studio 2015\Projects\Sporting_Gym\Sporting_Gym\Reportes\Proyeccion_Ingrensos.rdlc";
            //g.Genera_RDLC(, uri);

            for (int x = 0; x < Modulos.Count; x++)
            {
                foreach (Control c in this.Controls)
                {
                    if (!(c.Name == "Salir_Button"))
                    {
                        if (c.GetType().Name == "Button")
                        {
                            var v = Modulos.Where(s => s.nombre_Form == c.Name).ToList();

                            if (!(v.Count > 0))
                            {
                                c.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void Catalogo_Button_Click(object sender, EventArgs e)
        {
            Catalogos catalogos = new Catalogos();
            catalogos.ShowDialog();
        }

        private void registro_button_Click(object sender, EventArgs e)
        {
            csModulo Modulo = Modulos.Where(x => x.nombre_Form == "registro_button").Single();

            for (int x = 0; x < Modulo.subModulos.Count; x++)
            {
                foreach (Control c in this.Controls)
                {
                    foreach (Control _c in c.Controls)
                    {
                        if (_c.GetType().Name == "Label")
                        {
                            var v = Modulo.subModulos.Where(s => s.titulo_Button == _c.Name).ToList();

                            if (!(v.Count > 0))
                            {
                                _c.Visible = false;
                            }
                            else
                            {
                                _c.Visible = true;
                            }
                        }
                    }
                }
            }

            submenu_clientes_panel.Visible = true;
            submenu_clientes_panel.Location = new Point(fondo_submenu_panel.Location.X, fondo_submenu_panel.Location.Y);
            submenu_pagos_panel.Visible = false;
            submenu_reportes_panel.Visible = false;
            mostrar_submenu("mostrar");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Double total = Convert.ToDouble(prueba_label.Text);
            total += 1;
            if (total == 4)
            {
                mostrar_submenu("ocultar");

                timer1.Stop();
                total = 0;
            }
            prueba_label.Text = total.ToString();
        }

        private void Pagos_Button_Click(object sender, EventArgs e)
        {
            csModulo Modulo = Modulos.Where(x => x.nombre_Form == "Pagos_Button").Single();

            for (int x = 0; x < Modulo.subModulos.Count; x++)
            {
                foreach (Control c in this.Controls)
                {
                    foreach (Control _c in c.Controls)
                    {
                        if (_c.GetType().Name == "Label")
                        {
                            var v = Modulo.subModulos.Where(s => s.titulo_Button == _c.Name).ToList();

                            if (!(v.Count > 0))
                            {
                                _c.Visible = false;
                            }
                            else
                            {
                                _c.Visible = true;
                            }
                        }
                    }
                }
            }
            submenu_pagos_panel.Visible = true;
            submenu_pagos_panel.Location = new Point(fondo_submenu_panel.Location.X, fondo_submenu_panel.Location.Y);
            submenu_clientes_panel.Visible = false;
            submenu_reportes_panel.Visible = false;
            mostrar_submenu("mostrar");
        }

        private void Salir_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportes_Button_Click(object sender, EventArgs e)
        {
            csModulo Modulo = Modulos.Where(x => x.nombre_Form == "Reportes_Button").Single();

            for (int x = 0; x < Modulo.subModulos.Count; x++)
            {
                foreach (Control c in this.Controls)
                {
                    foreach (Control _c in c.Controls)
                    {
                        if (_c.GetType().Name == "Label")
                        {
                            var v = Modulo.subModulos.Where(s => s.titulo_Button == _c.Name).ToList();

                            if (!(v.Count > 0))
                            {
                                _c.Visible = false;
                            }
                            else
                            {
                                _c.Visible = true;
                            }
                        }
                    }
                }
            }

            submenu_reportes_panel.Visible = true;
            submenu_reportes_panel.Location = new Point(fondo_submenu_panel.Location.X, fondo_submenu_panel.Location.Y);
            submenu_clientes_panel.Visible = false;
            submenu_pagos_panel.Visible = false;

            mostrar_submenu("mostrar");
        }

        private void Submenus(object sender, EventArgs e)
        {
            Label label = sender as Label;

            string nombre_Label = label.Name;

            switch (nombre_Label)
            {
                //SUBMENU CLIENTES
                case "nuevo_cliente_label":
                    Registro_Cliente registro = new Registro_Cliente();
                    registro.ShowDialog();
                    break;
                case "buscar_cliente_label":
                    Buscar_Cliente buscar = new Buscar_Cliente(true, false);
                    buscar.ShowDialog();
                    break;
                case "grupo_clientes_label":
                    Sporting_Gym.Forms.Grupos grupos = new Sporting_Gym.Forms.Grupos();
                    grupos.ShowDialog();
                    break;
                case "correos_label":
                    Correo correo = new Correo();
                    correo.ShowDialog();
                    break;

                //SUBMENU PAGOS
                case "cobrar_label":
                    var periodos = (from leer_periodos in contexto.Catalogo_Periodos select leer_periodos).ToList();
                    var tipos_cliente = (from leer_tipo_cliente in contexto.Catalogo_Tipos_Clientes select leer_tipo_cliente).ToList();
                    var metodos = (from leer_metodos in contexto.Catalogo_Metodos_Pagos select leer_metodos).ToList();
                    if (periodos.Count != 0 && tipos_cliente.Count != 0 && metodos.Count != 0)
                    {
                        Cobro cobro = new Cobro();
                        cobro.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Verifique sus catalogos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "historial_pagos_label":
                    Historial_Pagos historial = new Historial_Pagos();
                    historial.ShowDialog();
                    break;
                case "cancelar_pago_label":
                    Cancelar_Pago cancelar = new Cancelar_Pago();
                    cancelar.ShowDialog();
                    break;
                case "egresos_label":
                    var egresos = (from verificar in contexto.Catalogo_Tipos_Egresos select verificar).ToList();
                    if (egresos.Count != 0)
                    {
                        //Egresos egreso = new Egresos(id_usuario);
                        //egreso.ShowDialog();
                        Egresos_Principal egresos_mensuales = new Egresos_Principal(id_usuario);
                        egresos_mensuales.Show();
                    }
                    else
                    {
                        MessageBox.Show("Verifique sus catalogos", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                //SUBMENU REPORTES

                case "corte_caja_label":
                    Reportes reporte_corte = new Reportes(1, id_usuario);
                    reporte_corte.ShowDialog();
                    break;
                case "acceso_no_vigentes_label":
                    Reportes reporte_accesos = new Reportes(2, id_usuario);
                    reporte_accesos.ShowDialog();
                    break;
                case "proyeccion_ingresos_label":
                    Reportes reporte_proyeccion = new Reportes(3, id_usuario);
                    reporte_proyeccion.ShowDialog();
                    break;
                case "clientes_sin_renovar":
                    Reportes reporte_no_renovacion = new Reportes(4, id_usuario);
                    reporte_no_renovacion.ShowDialog();
                    break;
                case "Clientes_Generales_label":
                    Reportes reporte_clientes_generales = new Reportes(5, id_usuario);
                    reporte_clientes_generales.Show();
                    break;
                case "Reporte_Egresos_label":
                    Reportes reporte_egresos = new Reportes(6, id_usuario);
                    reporte_egresos.Show();
                    break;
                case "Reporte_Balance_label":
                    Reportes reporte_balance = new Reportes(7, id_usuario);
                    reporte_balance.Show();
                    break;
            }
        }

        private void mostrar_submenu(string nombre_submenu)
        {
            if (nombre_submenu == "mostrar")
            {
                fondo_submenu_panel.Visible = false;
                timer1.Start();
            }
            else if (nombre_submenu == "ocultar")
            {
                fondo_submenu_panel.Visible = false;
                submenu_clientes_panel.Visible = false;
                submenu_pagos_panel.Visible = false;
                submenu_reportes_panel.Visible = false;
            }
        }

        private void usuarios_button_Click(object sender, EventArgs e)
        {
            Usuarios users = new Usuarios();
            users.Show();
        }
    }
}
