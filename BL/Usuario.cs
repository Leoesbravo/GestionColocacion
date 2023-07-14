using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result GetByIdGrupo(int idGrupo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.GestionEntrenamientoEntities context = new DL.GestionEntrenamientoEntities())
                {
                    var query = context.GrupoGetAlumnosById(idGrupo).ToList();
                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = item.IdUsuario;
                            usuario.Nombre = item.Nombre;
                            usuario.ApellidoMaterno = item.ApellidoMaterno;
                            usuario.ApellidoPaterno = item.ApellidoPaterno;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = item.IdRol.Value;
                            usuario.Grupo = new ML.Grupo();
                            usuario.Grupo.IdGrupo = item.IdGrupo;
                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetCoachesByGrupo(int idGrupo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.GestionEntrenamientoEntities context = new DL.GestionEntrenamientoEntities())
                {
                    var query = context.GrupoGetCoachById(idGrupo).ToList();
                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = item.IdUsuario;
                            usuario.Nombre = item.Nombre;
                            usuario.ApellidoMaterno = item.ApellidoMaterno;
                            usuario.ApellidoPaterno = item.ApellidoPaterno;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = item.IdRol.Value;
                            usuario.Grupo = new ML.Grupo();
                            usuario.Grupo.IdGrupo = item.IdGrupo;
                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result AlumnoGetById(int idUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.GestionEntrenamientoEntities context = new DL.GestionEntrenamientoEntities())
                {
                    var query = context.AlumnoGetById(idUsuario).FirstOrDefault();
                    if (query != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = query.IdUsuario;
                        usuario.Nombre = query.Nombre;
                        usuario.ApellidoMaterno = query.ApellidoMaterno;
                        usuario.ApellidoPaterno = query.ApellidoPaterno;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.IdRol = query.IdRol.Value;
                        usuario.Rol.Nombre = query.Rol;
                        usuario.Grupo = new ML.Grupo();
                        usuario.Grupo.FechaIngreso = query.FechaIngreso.Value.ToString("dd/MMMM/yyyy", new CultureInfo("es-ES"));
                        usuario.Grupo.FechaEgreso = query.FechaEgreso.Value.ToString("dd/MMMM/yyyy", new CultureInfo("es-ES"));
                        usuario.Grupo.Nombre = query.FechaIngreso.Value.ToString("MMMM", new CultureInfo("es-ES"));
                        usuario.Grupo.TipoGrupo = new ML.TipoGrupo();
                        usuario.Grupo.TipoGrupo.IdTipoGrupo = query.IdTipoGrupo;
                        usuario.Grupo.TipoGrupo.Nombre = query.Grupo;
                        usuario.Grupo.IdGrupo = query.IdGrupo; 

                        result.Object = usuario;
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Message = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
