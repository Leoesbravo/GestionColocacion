using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Grupo
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.GestionEntrenamientoEntities context = new DL.GestionEntrenamientoEntities())
                {
                    var query = context.GrupoGetAll().ToList();
                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Grupo grupo = new ML.Grupo();
                            grupo.IdGrupo = item.IdGrupo;
                            grupo.FechaIngreso = item.FechaIngreso.Value.ToString("dd/MMMM/yyyy", new CultureInfo("es-ES"));
                            grupo.FechaEgreso = item.FechaEgreso.Value.ToString("dd/MMMM/yyyy", new CultureInfo("es-ES"));
                            grupo.TipoGrupo = new ML.TipoGrupo();
                            grupo.TipoGrupo.IdTipoGrupo = item.IdGrupo;
                            grupo.TipoGrupo.Nombre = item.Tipo;
                            grupo.Status = new ML.Status();
                            grupo.Status.IdStatus = item.IdStatus.Value;
                            grupo.Status.Nombre = item.Status;
                            grupo.Nombre = item.FechaIngreso.Value.ToString("MMMM", new CultureInfo("es-ES"));

                            result.Objects.Add(grupo);
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
        public static ML.Result CambiarStatus(int idGrupo, int idStatus)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.GestionEntrenamientoEntities context = new DL.GestionEntrenamientoEntities())
                {
                    int query = context.GrupoCambiarStatus(idGrupo, idStatus);
                    if (query > 0)
                    {
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
        public static ML.Result GetById(int idGrupo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.GestionEntrenamientoEntities context = new DL.GestionEntrenamientoEntities())
                {
                    var query = context.GrupoGetById(idGrupo).FirstOrDefault();
                    if (query != null)
                    {
                        ML.Grupo grupo = new ML.Grupo();
                        grupo.IdGrupo = query.IdGrupo;
                        grupo.FechaIngreso = query.FechaIngreso.Value.ToString("dd/MMMM/yyyy", new CultureInfo("es-ES"));
                        grupo.FechaEgreso = query.FechaEgreso.Value.ToString("dd/MMMM/yyyy", new CultureInfo("es-ES"));
                        grupo.TipoGrupo = new ML.TipoGrupo();
                        grupo.TipoGrupo.IdTipoGrupo = query.IdTipoGrupo.Value;
                        grupo.TipoGrupo.Nombre = query.Tipo;
                        grupo.Status = new ML.Status();
                        grupo.Status.IdStatus = query.IdStatus.Value;
                        grupo.Status.Nombre = query.Status;
                        grupo.Nombre = query.FechaIngreso.Value.ToString("MMMM", new CultureInfo("es-ES"));

                        result.Object = grupo;
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
