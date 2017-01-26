using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporting_Gym_Check.App_Code.Models
{
    public class csCliente
    {
        public string tipo { get; set; }

        public int id_Cliente { get; set; }

        public byte[] fingerPrint { get; set; }

        public string nombre { get; set; }

        public DateTime fecha_corte { get; set; }

        public csCliente()
        {
            tipo = " ";
            id_Cliente = 0;
            fingerPrint = new byte[1632];
            nombre = " ";
            fecha_corte = DateTime.Now;
        }
    }
}
