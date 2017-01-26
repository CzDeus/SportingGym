using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporting_Gym.App_Code.Utility
{
    class ObjectBase
    {
        public void LogError(string sError)
        {
            System.IO.StreamWriter ArchivoW;
            string strLineaTMP;
            string Minuto;
            //DateTime dt = DateTime.Now;

            Minuto = DateTime.Now.Minute.ToString();
            if (Minuto.Length == 1)
                Minuto = "0" + Minuto;

            strLineaTMP = "\n" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour + ":" + Minuto + ". " + sError + "\n";
            try
            {
                ArchivoW = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Log.txt", true, System.Text.Encoding.UTF8);

                try
                {
                    ArchivoW.Write(strLineaTMP);
                }
                catch (Exception)
                {
                }
                ArchivoW.Close();
            }
            catch (UnauthorizedAccessException)
            {
            }
        }
    }
}
