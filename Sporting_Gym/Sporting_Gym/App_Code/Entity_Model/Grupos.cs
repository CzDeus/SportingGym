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
    
    public partial class Grupos
    {
        public int id_grupo { get; set; }
        public string nombre_grupo { get; set; }
        public Nullable<int> id_cliente_responsable { get; set; }
        public int id_tipo_cliente { get; set; }
    }
}