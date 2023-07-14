using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Status
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.GestionEntrenamientoEntities context = new DL.GestionEntrenamientoEntities())
                {
                    var query = context.StatusGetAll().ToList();
                    if (query.Count > 0)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Status status = new ML.Status();
                            status.IdStatus = item.IdStatus;
                            status.Nombre = item.Nombre;

                            result.Objects.Add(status);
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
        public static string ObtenerClasePorStatus(int idStatus)
        {
            switch (idStatus)
            {
                case 1:
                    return "dropdown-black entrenamiento-status";
                case 2:
                    return "dropdown-black pre-entrenamiento-status";
                case 3:
                    return "dropdown-black colocacion-status";
                default:
                    return "";
            }
        }
    }
}
