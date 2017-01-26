using Sporting_Gym_Check.App_Code.Utility;
using Sporting_Gym_Check.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporting_Gym_Check
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += ExceptionTrigger;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cambio_Usuario());
        }

        static void ExceptionTrigger(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("ERROR !!!!!!!!");
            (new ObjectoBase()).LogError(e.ExceptionObject.ToString());
            Environment.Exit(1);
        }
    }
}
