using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporting_Gym_Check.App_Code.Entity_Model;

namespace Sporting_Gym_Check.Forms
{
    public partial class Validar_Usuario : Usuario
    {
        //private static db_Finger_ModelContainer contexto = new db_Finger_ModelContainer();
        List<tb_Usuarios> List_Usuarios = new List<tb_Usuarios>();

        private void Validar_Usuario_Load(object sender, EventArgs e)
        {
        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
            List_Usuarios = base.List_Usuarios;
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                byte[] bytes = new byte[1632];
                features.Serialize(ref bytes);

                //"0X" + BitConverter.ToString( bytes ).Replace("-","")

                for (int x = 0; x < List_Usuarios.Count; x++)
                {
                    DPFP.Template templeate = new DPFP.Template();
                    templeate.DeSerialize(List_Usuarios[x].dedo);

                    //Compare the feature set with our template
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                    Verificator.Verify(features, templeate, ref result);
                    //UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        MessageBox.Show("VERIFICADO  " + List_Usuarios[x].nombre_usuario);//MakeReport("The fingerprint was VERIFIED.");
                        return;
                    }
                }

                MessageBox.Show("NO ENCONTRADO");

                //if (templeate == null)
                //    return;
            }
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
    }
}
