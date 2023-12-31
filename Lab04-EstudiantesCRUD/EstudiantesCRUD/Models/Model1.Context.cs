﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstudiantesCRUD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PrograVIEntities : DbContext
    {
        public PrograVIEntities()
            : base("name=PrograVIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<estudiante> estudiantes { get; set; }
    
        public virtual int sp_DeleteEstudiante(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteEstudiante", idParameter);
        }
    
        public virtual int sp_InsertaEstudiante(string id, string nombre, string genero, string direccion, Nullable<System.DateTime> fechaNacimiento, string celula, string correo, string nacionalidad)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            var celulaParameter = celula != null ?
                new ObjectParameter("celula", celula) :
                new ObjectParameter("celula", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var nacionalidadParameter = nacionalidad != null ?
                new ObjectParameter("nacionalidad", nacionalidad) :
                new ObjectParameter("nacionalidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaEstudiante", idParameter, nombreParameter, generoParameter, direccionParameter, fechaNacimientoParameter, celulaParameter, correoParameter, nacionalidadParameter);
        }
    
        public virtual ObjectResult<sp_SelectEstudiante_Result> sp_SelectEstudiante()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SelectEstudiante_Result>("sp_SelectEstudiante");
        }
    
        public virtual ObjectResult<sp_SelectEstudiantePorID_Result> sp_SelectEstudiantePorID(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SelectEstudiantePorID_Result>("sp_SelectEstudiantePorID", idParameter);
        }
    
        public virtual int sp_UpdateEstudiante(Nullable<int> idEstudiante, string id, string nombre, string genero, string direccion, Nullable<System.DateTime> fechaNacimiento, string celular, string correo, string nacionalidad)
        {
            var idEstudianteParameter = idEstudiante.HasValue ?
                new ObjectParameter("idEstudiante", idEstudiante) :
                new ObjectParameter("idEstudiante", typeof(int));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            var celularParameter = celular != null ?
                new ObjectParameter("celular", celular) :
                new ObjectParameter("celular", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var nacionalidadParameter = nacionalidad != null ?
                new ObjectParameter("nacionalidad", nacionalidad) :
                new ObjectParameter("nacionalidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateEstudiante", idEstudianteParameter, idParameter, nombreParameter, generoParameter, direccionParameter, fechaNacimientoParameter, celularParameter, correoParameter, nacionalidadParameter);
        }
    }
}
