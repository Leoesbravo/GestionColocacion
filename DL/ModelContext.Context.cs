﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GestionEntrenamientoEntities : DbContext
    {
        public GestionEntrenamientoEntities()
            : base("name=GestionEntrenamientoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Grupo> Grupoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TipoGrupo> TipoGrupoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<GrupoCoach> GrupoCoaches { get; set; }
        public virtual DbSet<UsuarioGrupo> UsuarioGrupoes { get; set; }
    
        public virtual int GrupoAdd(Nullable<System.DateTime> fechaIngreso, Nullable<int> idTipoGrupo)
        {
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var idTipoGrupoParameter = idTipoGrupo.HasValue ?
                new ObjectParameter("IdTipoGrupo", idTipoGrupo) :
                new ObjectParameter("IdTipoGrupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GrupoAdd", fechaIngresoParameter, idTipoGrupoParameter);
        }
    
        public virtual ObjectResult<GrupoGetAll_Result> GrupoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GrupoGetAll_Result>("GrupoGetAll");
        }
    
        public virtual int UsuarioAdd(string nombre, string apellidoPaterno, string apellidoMaterno, Nullable<int> idRol)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioAdd", nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, idRolParameter);
        }
    
        public virtual ObjectResult<StatusGetAll_Result> StatusGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StatusGetAll_Result>("StatusGetAll");
        }
    
        public virtual int GrupoCambiarStatus(Nullable<int> idgrupo, Nullable<int> idStatus)
        {
            var idgrupoParameter = idgrupo.HasValue ?
                new ObjectParameter("Idgrupo", idgrupo) :
                new ObjectParameter("Idgrupo", typeof(int));
    
            var idStatusParameter = idStatus.HasValue ?
                new ObjectParameter("IdStatus", idStatus) :
                new ObjectParameter("IdStatus", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GrupoCambiarStatus", idgrupoParameter, idStatusParameter);
        }
    
        public virtual ObjectResult<GrupoGetAlumnosById_Result> GrupoGetAlumnosById(Nullable<int> idGrupo)
        {
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GrupoGetAlumnosById_Result>("GrupoGetAlumnosById", idGrupoParameter);
        }
    
        public virtual ObjectResult<GrupoGetCoachById_Result> GrupoGetCoachById(Nullable<int> idGrupo)
        {
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GrupoGetCoachById_Result>("GrupoGetCoachById", idGrupoParameter);
        }
    
        public virtual ObjectResult<GrupoGetById_Result> GrupoGetById(Nullable<int> idGrupo)
        {
            var idGrupoParameter = idGrupo.HasValue ?
                new ObjectParameter("IdGrupo", idGrupo) :
                new ObjectParameter("IdGrupo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GrupoGetById_Result>("GrupoGetById", idGrupoParameter);
        }
    
        public virtual ObjectResult<AlumnoGetById_Result> AlumnoGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AlumnoGetById_Result>("AlumnoGetById", idUsuarioParameter);
        }
    }
}
