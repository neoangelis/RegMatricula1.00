using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProyecto.Controllers
{
    public class AdministradorController : Controller
    {
        //
        // GET: /Administrador/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Administrador/AdminCtaUsuario

        public ActionResult AdminCtaUsuario()
        {
            return View();
        }

        //
        // GET: /Administrador/RegisNotCurso

        public ActionResult RegisNotCurso()
        {
            return View();
        }

        //
        // GET: /Administrador/RegisMatricula

        public ActionResult RegisMatricula()
        {
            return View();
        }
    }
}
