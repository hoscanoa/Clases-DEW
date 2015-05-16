using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PREGUNTA2.Models;
using PREGUNTA2.Servicios;
using PREGUNTA2.Controllers;

namespace PREGUNTA2.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        IServicio servicio;

        public ClienteController(IServicio _servicio)
        {
            //servicio = new MiServicioSQL();
            servicio = _servicio;
        }

        public ActionResult Index()
        {
            //Negocios2015Entities db = new Negocios2015Entities();
            //return View(db.clientes);


            //MiServicioSQL servicio = new MiServicioSQL();
            //return View(servicio.ListarTodos());

            return View(servicio.ListarTodos());
        }

    }
}
