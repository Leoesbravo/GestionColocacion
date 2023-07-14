using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class GrupoController : Controller
    {
        // GET: Grupo
        public ActionResult GetAll()
        {
            ML.Result result = BL.Grupo.GetAll();
            ML.Grupo grupo = new ML.Grupo();
            grupo.Grupos = result.Objects;  

            ML.Result resultStatus = BL.Status.GetAll();
            grupo.Status = new ML.Status();
            grupo.Status.Statuss = resultStatus.Objects;

            return View(grupo);
        }
        [HttpPost]
        public JsonResult CambiarStatus(int idStatus, int idGrupo)
        {
            ML.Result resultado = BL.Grupo.CambiarStatus(idGrupo, idStatus);
            string statusClass = BL.Status.ObtenerClasePorStatus(idStatus);
            var result = new { statusClass = statusClass };
            return Json(result);
        }
        public ActionResult GetAlumnosByGrupo(int IdGrupo)
        {
            ML.Grupo grupo = new ML.Grupo();
            ML.Result result = BL.Grupo.GetById(IdGrupo);
            grupo = (ML.Grupo)result.Object;
            result = BL.Usuario.GetByIdGrupo(IdGrupo);
            grupo.Usuario = new ML.Usuario();
            grupo.Usuario.Usuarios = result.Objects;
            result = BL.Usuario.GetCoachesByGrupo(IdGrupo);
            grupo.Coaches = result.Objects;
            
            return View(grupo);
        }
    }
}