using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporting_Gym.App_Code.Models
{
    class csModulo
    {
        public int id_General_Acceso { get; set; }
        public string nombre_Acceso { get; set; }
        public string nombre_Form { get; set; }
        public List<csSubModulo> subModulos { get; set; }

        public csModulo()
        {
            id_General_Acceso = 0;
            nombre_Acceso = "";
            nombre_Form = "";
            subModulos = new List<csSubModulo>();
        }
    }
}
