using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporting_Gym_Check
{
    delegate void Function();

    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Usuario_1 frm = new Forms.Usuario_1();
            frm.OnTemplate += this.OnTemplate;
            frm.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                if (Template != null)
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;

        private void button2_Click(object sender, EventArgs e)
        {
            //Forms.Validar_Usuario frm = new Forms.Validar_Usuario();
            //frm.ShowDialog();

            //Forms.Verify frm = new Forms.Verify();
            //frm.ShowDialog();

            Checador frm = new Checador();
            frm.ShowDialog(); 
        }
    }
}
