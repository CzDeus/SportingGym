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
    
    public partial class sp_Leer_Clientes_Result
    {
        public int id_cliente { get; set; }
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
        public string telefono { get; set; }
        public string celular { get; set; }
        public Nullable<System.DateTime> fecha_ingreso { get; set; }
        public Nullable<bool> estatus { get; set; }
        public Nullable<System.DateTime> ultima_asistencia { get; set; }
        public Nullable<int> id_tipo_cliente { get; set; }
        public byte[] foto { get; set; }
    }
}
