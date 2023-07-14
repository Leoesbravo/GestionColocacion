using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Login()
        {


            return View();
        }
        public ActionResult AlumnoGetById(int idUsuario)
        {
            ML.Result result = BL.Usuario.AlumnoGetById(idUsuario);
            ML.Usuario usuario = (ML.Usuario)result.Object;
            return View(usuario);
        }
    }
}