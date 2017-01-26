using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporting_Gym.App_Code.Models
{
    class csCliente
    {
        public int id_Cliente { get; set; }
        public byte[] fingerPrint { get; set; }

        public csCliente()
        {
            id_Cliente = 0;
            fingerPrint = new byte[1632];
        }
    }
}
