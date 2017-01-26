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
    public partial class Actualizar_Colonias : Form
    {
        bool bandera;
        int id_colonia;

        static db_sporting_gymContainer contexto = new db_sporting_gymContainer();

        public Actualizar_Colonias(int id_colonia, bool bandera)
        {
            InitializeComponent();
            this.bandera = bandera;
            this.id_colonia = id_colonia;

            var nom = (from buscar in contexto.Catalogo_Colonias where buscar.id_colonia == id_colonia select buscar).First();
            nombre_colonia_textBox.Text = nom.nombre_colonia;
        }

        public Actualizar_Colonias(bool bandera)
        {
            InitializeComponent();
            this.bandera = bandera;
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            if (nombre_colonia_textBox.Text != "")
            {
                if (bandera)
                {
                    var actualizar = (from buscar in contexto.Catalogo_Colonias where buscar.id_colonia == id_colonia select buscar).First();
                    actualizar.nombre_colonia = nombre_colonia_textBox.Text;
                    contexto.SaveChanges();

                    this.Close();
                    MessageBox.Show("Datos Actualizados");
                }
                else
                {
                    Catalogo_Colonias colonia = new Catalogo_Colonias();
                    colonia.nombre_colonia = nombre_colonia_textBox.Text;
                    contexto.Catalogo_Colonias.Add(colonia);
                    contexto.SaveChanges();

                    this.Close();
                    MessageBox.Show("Datos Agregados");
                }
            }
            else
            {
                MessageBox.Show("Campo vacio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Actualizar_Colonias_Load(object sender, EventArgs e)
        {
            csResizeForm ResizeForm = new csResizeForm();
            ResizeForm.ResizeForm(this, 800, 600);

            if (bandera == true)
            {
                eliminar_button.Text = "Eliminar";
            }
            else
            {
                eliminar_button.Text = "Limpiar";
            }
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            if(bandera == true)
            {
                if(MessageBox.Show("¿Seguro desea eliminar la colonia?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var eliminar = (from buscar in contexto.Catalogo_Colonias where buscar.id_colonia == id_colonia select buscar).First();
                    contexto.Catalogo_Colonias.Remove(eliminar);
                    contexto.SaveChanges();

                    this.Close();
                    MessageBox.Show("Colonia eliminada");
                }
            }
            else
            {
                nombre_colonia_textBox.Text = "";
            }
        }
    }
}
