//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sporting_Gym.App_Code.Entity_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Catalogo_Instructores
    {
        public int id_instructor { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public string sexo { get; set; }
        public Nullable<int> edad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string colonia { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public Nullable<System.DateTime> fecha_ingreso { get; set; }
        public Nullable<bool> estatus { get; set; }
        public Nullable<System.DateTime> fecha_egreso { get; set; }
        public byte[] foto { get; set; }
        public byte[] huella { get; set; }
    }
}