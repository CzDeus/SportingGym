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
    
    public partial class Archivos_Clientes
    {
        public int id_archivo { get; set; }
        public byte[] archivo { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string nombre_imagen { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int tipo_cliente { get; set; }
    }
}