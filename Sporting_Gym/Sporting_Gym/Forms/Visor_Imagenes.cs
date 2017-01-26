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
using System.IO;
using System.Drawing.Imaging;

namespace Sporting_Gym.Forms
{
    public partial class Visor_Imagenes : Form
    {
        db_sporting_gymContainer contexto = new db_sporting_gymContainer();
        private int id_imagen;
        private Image myimage;

        public Visor_Imagenes()
        {
            InitializeComponent();
        }

        public Visor_Imagenes(int id_imagen)
        {
            InitializeComponent();
            this.id_imagen = id_imagen;
            ver_foto();
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminar_button_Click(object sender, EventArgs e)
        {
            var eliminar = (from buscar in contexto.Archivos_Clientes where buscar.id_archivo == id_imagen select buscar).First();
            contexto.Archivos_Clientes.Remove(eliminar);
            contexto.SaveChanges();

            this.Close();
        }
        
        private void ver_foto()
        {
            var foto = (from ver in contexto.Archivos_Clientes where ver.id_archivo == id_imagen select ver.archivo).First();
            var data = (Byte[])foto;
            var stream = new MemoryStream(data);
            videoSourcePlayer1.BackgroundImage = Image.FromStream(stream);

            myimage = Image.FromStream(stream);
        } 
    }
}
