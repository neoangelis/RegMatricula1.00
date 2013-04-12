using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProyecto.Controllers
{
    public class ProyectoController : Controller
    {
        //
        // GET: /Proyecto/

        public ActionResult Index()
        //public string Index()
        {
            return View();
            //return "Este Es  mi <b>Default</b> Action ...";
        }

        //
        // GET: /Proyecto/Reserva
        //Reservar Matricula

        public ActionResult Reserva()
        {
            return View();
            //return RedirectToAction("Index", "Proyecto");
        }
        
        //
        // GET: /Proyecto/VerReportes
        // Ver Reportes
        public ActionResult VerReportes() 
        {
            return View();
        }
    }
}