using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sporting_Gym.App_Code.Entity_Model;
using Sporting_Gym.App_Code.Models;

namespace Sporting_Gym.App_Code.Handlers
{
    class csSubModuloHandler
    {
        public csSubModulo AddSubModulos(Generales_Accesos GeneralesAccesos)
        {
            csSubModulo SubModulo = new csSubModulo();
            SubModulo.id_General_Acceso = GeneralesAccesos.id_acceso;
            SubModulo.nombre_Acceso = GeneralesAccesos.nombre_acceso.Trim();
            SubModulo.nombre_Form = GeneralesAccesos.nombre_form.Trim();
            SubModulo.titulo_Button = GeneralesAccesos.titulo_boton.Trim();
            SubModulo.form_Button = GeneralesAccesos.form_button.Trim();
            SubModulo.storeProcedure = GeneralesAccesos.store_procedure.Trim();

            return SubModulo;
        }
    }
}
