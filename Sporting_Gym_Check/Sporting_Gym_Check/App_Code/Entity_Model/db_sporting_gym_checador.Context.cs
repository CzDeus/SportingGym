﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sporting_Gym_Check.App_Code.Entity_Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db_sporting_gymEntities : DbContext
    {
        public db_sporting_gymEntities()
            : base("name=db_sporting_gymEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Generales_Usuarios> Generales_Usuarios { get; set; }
        public virtual DbSet<Bitacora_Asistencias> Bitacora_Asistencias { get; set; }
        public virtual DbSet<Catalogo_Clientes> Catalogo_Clientes { get; set; }
        public virtual DbSet<Catalogo_Instructores> Catalogo_Instructores { get; set; }
    
        public virtual int sp_Actualizar_Huella(Nullable<int> id_cliente, byte[] huella, Nullable<bool> persona)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            var huellaParameter = huella != null ?
                new ObjectParameter("huella", huella) :
                new ObjectParameter("huella", typeof(byte[]));
    
            var personaParameter = persona.HasValue ?
                new ObjectParameter("persona", persona) :
                new ObjectParameter("persona", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Actualizar_Huella", id_clienteParameter, huellaParameter, personaParameter);
        }
    
        public virtual ObjectResult<sp_Buscar_Cliente_Result> sp_Buscar_Cliente(string nombre_buscar, string ape_paterno)
        {
            var nombre_buscarParameter = nombre_buscar != null ?
                new ObjectParameter("nombre_buscar", nombre_buscar) :
                new ObjectParameter("nombre_buscar", typeof(string));
    
            var ape_paternoParameter = ape_paterno != null ?
                new ObjectParameter("ape_paterno", ape_paterno) :
                new ObjectParameter("ape_paterno", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Buscar_Cliente_Result>("sp_Buscar_Cliente", nombre_buscarParameter, ape_paternoParameter);
        }
    
        public virtual ObjectResult<sp_Cargar_Usuarios_Checador_Result> sp_Cargar_Usuarios_Checador()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Cargar_Usuarios_Checador_Result>("sp_Cargar_Usuarios_Checador");
        }
    
        public virtual ObjectResult<sp_Lista_Checador_Result> sp_Lista_Checador()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Lista_Checador_Result>("sp_Lista_Checador");
        }
    
        public virtual ObjectResult<sp_Buscar_Instructor_Id_Result> sp_Buscar_Instructor_Id(Nullable<int> id_instructor)
        {
            var id_instructorParameter = id_instructor.HasValue ?
                new ObjectParameter("id_instructor", id_instructor) :
                new ObjectParameter("id_instructor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Buscar_Instructor_Id_Result>("sp_Buscar_Instructor_Id", id_instructorParameter);
        }
    
        public virtual int sp_Registro_Ingreso(Nullable<int> id_cliente, Nullable<bool> instructor, Nullable<bool> estatus, Nullable<int> id_responsable)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            var instructorParameter = instructor.HasValue ?
                new ObjectParameter("instructor", instructor) :
                new ObjectParameter("instructor", typeof(bool));
    
            var estatusParameter = estatus.HasValue ?
                new ObjectParameter("estatus", estatus) :
                new ObjectParameter("estatus", typeof(bool));
    
            var id_responsableParameter = id_responsable.HasValue ?
                new ObjectParameter("id_responsable", id_responsable) :
                new ObjectParameter("id_responsable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Registro_Ingreso", id_clienteParameter, instructorParameter, estatusParameter, id_responsableParameter);
        }
    
        public virtual ObjectResult<sp_Buscar_Clientes_Id_Result> sp_Buscar_Clientes_Id(Nullable<int> id_cliente)
        {
            var id_clienteParameter = id_cliente.HasValue ?
                new ObjectParameter("id_cliente", id_cliente) :
                new ObjectParameter("id_cliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Buscar_Clientes_Id_Result>("sp_Buscar_Clientes_Id", id_clienteParameter);
        }
    }
}
