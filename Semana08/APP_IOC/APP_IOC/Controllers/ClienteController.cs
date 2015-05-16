using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APP_IOC.Models;
using APP_IOC.Servicios;

namespace APP_IOC.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        IServicio servicio;
        public ClienteController(IServicio _servicio)
        { 
            //servicio= new MiServicioSQL();
            //cambio
            servicio = _servicio;
        }


        public ActionResult Index()
        {
            /*Negocios2015Entities db = new Negocios2015Entities();
            return View(db.clientes);*/

            //MiServicioSQL objServicio = new MiServicioSQL();
            //return View(objServicio.ListarTodos());

            return View(servicio.ListarTodos());
        }

    }
}
