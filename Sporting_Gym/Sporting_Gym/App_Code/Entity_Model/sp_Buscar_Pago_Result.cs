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
    
    public partial class sp_Buscar_Pago_Result
    {
        public Nullable<int> id_cliente { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Método_de_Pago { get; set; }
        public string Período { get; set; }
        public string Tipo_Cliente { get; set; }
        public Nullable<double> importe_a_pagar { get; set; }
        public Nullable<double> importe_pagado { get; set; }
        public string justificacion { get; set; }
        public string observaciones { get; set; }
    }
}