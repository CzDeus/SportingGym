using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Sporting_Gym.App_Code.Entity_Model;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Sporting_Gym.App_Code.Utility
{
    class csDynamicColumns
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="archivo_guardar"></param>
        /// <param name="ruta_archivo"></param>
        public DataTable Genera_RDLC(ref string archivo_guardar, string ruta_archivo)
        {
            XDocument xml_reporte = XDocument.Load(ruta_archivo);

            //NOMBRES DE ESPACIO PARA EL XDOCUMENT
            XNamespace namspac_def = "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition";
            XNamespace namspac_rd = "http://schemas.microsoft.com/SQLServer/reporting/reportdesigner";

            //TOMAMOS EL NOM BRE DE LAS SEMANAS QUE VAN REPOTEARSE
            string nombre_semana = "";

            SqlConnection connection = new SqlConnection( ConfigurationManager.ConnectionStrings["Sporting_Gym.Properties.Settings.Sporting_Gym_ConnectionString"].ConnectionString );
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_Rpt_Proyeccion_ingresos", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
                connection = null;
            }

            for (int x = 0; x < dt.Columns.Count; x++)
            {
                nombre_semana = dt.Columns[x].ColumnName.Trim().Replace(' ', '_');
                string nombre_semana_replace = nombre_semana.Replace('c', ' ').Replace('_', ' ');

                //
                // DATASET
                //
                XElement xDataSets = xml_reporte.Elements(namspac_def + "Report").Elements(namspac_def + "DataSets").Elements().ElementAt(0);
                if (x > 1)
                {
                    XElement xdata_original = new XElement(xDataSets.Elements(namspac_def + "Fields").Elements().ElementAt(1));
                    XElement xDataSets_agregar = xDataSets.Elements(namspac_def + "Fields").ElementAt(0);
                    xDataSets_agregar.Add(new XElement(xdata_original));
                }
                xDataSets.Elements(namspac_def + "Fields").Elements(namspac_def + "Field").ElementAt(x).Attribute("Name").Value = nombre_semana;
                xDataSets.Elements(namspac_def + "Fields").Elements(namspac_def + "Field").ElementAt(x).Elements(namspac_def + "DataField").First().Value = nombre_semana;

                //
                // COLUMNAS
                //
                XElement xTablix_Columns = xml_reporte.Elements(namspac_def + "Report").Elements(namspac_def + "Body").Elements(namspac_def + "ReportItems").Elements(namspac_def + "Tablix").Elements(namspac_def + "TablixBody").Elements().ElementAt(0);
                if (x > 1)
                {
                    XElement xdata_original = new XElement(xTablix_Columns.Elements().ElementAt(1));
                    xTablix_Columns.Add(new XElement(xdata_original));
                }
                xTablix_Columns.Elements(namspac_def + "TablixColumn").ElementAt(0).Elements(namspac_def + "Width").First().Value = "2cm";

                //
                // RENGLONES (TablixRows)
                //
                // (1) RENGLON DE ENCABEZADO
                XElement xTablixRow_encabezado = xml_reporte.Elements(namspac_def + "Report").Elements(namspac_def + "Body").Elements(namspac_def + "ReportItems").Elements(namspac_def + "Tablix").Elements(namspac_def + "TablixBody").Elements(namspac_def + "TablixRows").Elements().ElementAt(0);
                // COLUMNAS DE ENCABEZADO
                IEnumerable<XElement> xencabezados = xTablixRow_encabezado.Elements(namspac_def + "TablixCells").Elements();
                // NOMBRE TEXTBOX
                if (x > 1)
                {
                    XElement xdata_original = new XElement(xTablixRow_encabezado.Elements(namspac_def + "TablixCells").Elements().ElementAt(1));//new XElement(xencabezados.ElementAt(1));
                    XElement xtablix_agregar = xTablixRow_encabezado.Elements().ElementAt(1);
                    xtablix_agregar.Add(new XElement(xdata_original));
                }
                if (x > 0)
                {
                    XElement textBox_encabezado = xencabezados.ElementAt(x).Elements(namspac_def + "CellContents").Elements(namspac_def + "Textbox").ElementAt(0);
                    textBox_encabezado.Attribute("Name").Value = nombre_semana.Replace(' ', '_') + "_encab_" + x.ToString();
                    //ENCABEZADO DE LA COLUMNA (NOMBRE DE LA SEMANA)
                    xencabezados.ElementAt(x).Elements(namspac_def + "CellContents").Elements(namspac_def + "Textbox").Elements(namspac_def + "Paragraphs").Elements(namspac_def + "Paragraph").Elements(namspac_def + "TextRuns").Elements(namspac_def + "TextRun").Elements(namspac_def + "Value").First().Value = nombre_semana_replace;

                }

                //(2) RENGLON DE CAMPOS
                XElement xTablixRow_campos = xml_reporte.Elements(namspac_def + "Report").Elements(namspac_def + "Body").Elements(namspac_def + "ReportItems").Elements(namspac_def + "Tablix").Elements(namspac_def + "TablixBody").Elements(namspac_def + "TablixRows").Elements().ElementAt(1);
                //COLUMNA DE CAMPOS
                IEnumerable<XElement> xcampos = xTablixRow_campos.Elements(namspac_def + "TablixCells").Elements();
                //NOMBRE DEL TEXTBOX
                if (x > 1)
                {
                    XElement xdata_original = new XElement(xTablixRow_campos.Elements(namspac_def + "TablixCells").Elements().ElementAt(1));//new XElement(xcampos.ElementAt(0));
                    XElement xtablix_agregar = xTablixRow_campos.Elements().ElementAt(1);
                    xtablix_agregar.Add(new XElement(xdata_original));
                }
                if (x > 0)
                {
                    XElement textBox_campos = xcampos.ElementAt(x).Elements(namspac_def + "CellContents").Elements(namspac_def + "Textbox").ElementAt(0);
                    textBox_campos.Attribute("Name").Value = nombre_semana.Replace(' ', '_') + "_Textbox_" + x.ToString();
                    //NOMBRE DEL TEXTBOX (NOMBRE DE LA SEMANA)
                    xcampos.ElementAt(x).Elements(namspac_def + "CellContents").Elements(namspac_def + "Textbox").Elements(namspac_def + "Paragraphs").Elements(namspac_def + "Paragraph").Elements(namspac_def + "TextRuns").Elements(namspac_def + "TextRun").Elements(namspac_def + "Value").First().Value = "=Fields!" + nombre_semana + ".Value";

                }

                //(3) RENGLON
                XElement xTablixRow_espacio = xml_reporte.Elements(namspac_def + "Report").Elements(namspac_def + "Body").Elements(namspac_def + "ReportItems").Elements(namspac_def + "Tablix").Elements(namspac_def + "TablixBody").Elements(namspac_def + "TablixRows").Elements().ElementAt(2);
                // COLUMNAS DE ENCABEZADO
                IEnumerable<XElement> xespacios = xTablixRow_espacio.Elements(namspac_def + "TablixCells").Elements();
                // NOMBRE DEL TEXTBOX
                if (x > 1)
                {
                    XElement xdata_original = new XElement(xTablixRow_espacio.Elements(namspac_def + "TablixCells").Elements().ElementAt(1));//new XElement(xespacios.ElementAt(0));
                    XElement xtablix_agregar = xTablixRow_espacio.Elements().ElementAt(1);
                    xtablix_agregar.Add(new XElement(xdata_original));
                }
                if (x > 0)
                {
                    XElement textBox_espacio = xespacios.ElementAt(x).Elements(namspac_def + "CellContents").Elements(namspac_def + "Textbox").ElementAt(0);
                    textBox_espacio.Attribute("Name").Value = nombre_semana.Replace(' ', '_') + "_espacio_" + x.ToString();

                }

                //(4) RENGLON TOTALES
                XElement xTablixRow_totales = xml_reporte.Elements(namspac_def + "Report").Elements(namspac_def + "Body").Elements(namspac_def + "ReportItems").Elements(namspac_def + "Tablix").Elements(namspac_def + "TablixBody").Elements(namspac_def + "TablixRows").Elements().ElementAt(3);
                //COLUMNAS DE ENCABEZADO
                IEnumerable<XElement> xtotales = xTablixRow_totales.Elements(namspac_def + "TablixCells").Elements();
                // NOMBRE DEL TEXTBOX
                if (x > 1)
                {
                    XElement xdata_original = new XElement(xTablixRow_totales.Elements(namspac_def + "TablixCells").Elements().ElementAt(1));//new XElement(xtotales.ElementAt(0));
                    XElement xtablix_agregar = xTablixRow_totales.Elements().ElementAt(1);
                    xtablix_agregar.Add(new XElement(xdata_original));
                }
                if (x > 0)
                {
                    XElement textBox_totales = xtotales.ElementAt(x).Elements(namspac_def + "CellContents").Elements(namspac_def + "Textbox").ElementAt(0);
                    textBox_totales.Attribute("Name").Value = nombre_semana.Replace(' ', '_') + "_total_" + x.ToString();
                    xtotales.ElementAt(x).Elements(namspac_def + "CellContents").Elements(namspac_def + "Textbox").Elements(namspac_def + "Paragraphs").Elements(namspac_def + "Paragraph").Elements(namspac_def + "TextRuns").Elements(namspac_def + "TextRun").Elements(namspac_def + "Value").First().Value = "=sum(Fields!" + nombre_semana + ".Value)";
                }

                //
                // <TablixColumnHierarchy>
                //
                XElement xColumnHierarchy = xml_reporte.Elements(namspac_def + "Report").Elements(namspac_def + "Body").Elements(namspac_def + "ReportItems").Elements(namspac_def + "Tablix").Elements(namspac_def + "TablixColumnHierarchy").Elements().ElementAt(0);
                if (x > 1)
                {
                    XElement xdata_original = new XElement(xColumnHierarchy.Elements().ElementAt(0));
                    XElement xColumn_agregar = xColumnHierarchy;
                    xColumn_agregar.Add(new XElement(xdata_original));
                }
            }

            xml_reporte.Save(archivo_guardar);

            return dt;
        }
    }
}