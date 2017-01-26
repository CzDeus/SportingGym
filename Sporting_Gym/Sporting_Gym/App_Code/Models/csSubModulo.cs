using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporting_Gym.App_Code.Models
{
    class csSubModulo
    {
        public int id_General_Acceso { get; set; }
        public string nombre_Acceso { get; set; }
        public string nombre_Form { get; set; }
        public string titulo_Button { get; set; }
        public string form_Button { get; set; }
        public string storeProcedure { get; set; }
        public List<csSubModulo> SubModulos { get; set; }

        public csSubModulo()
        {
            id_General_Acceso = 0;
            nombre_Acceso = "";
            nombre_Form = "";
            titulo_Button = "";
            form_Button = "";
            SubModulos = new List<csSubModulo>();
        }
    }
}
