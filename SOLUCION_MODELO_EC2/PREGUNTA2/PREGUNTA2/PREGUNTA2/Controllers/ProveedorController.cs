using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PREGUNTA2.Controllers
{
    public class ProveedorController : Controller
    {
        //
        // GET: /Proveedor/

        IServicio servicio;

        public ProveedorController(IServicio _servicio)
        {
            servicio = _servicio;
        }

        public ActionResult Index()
        {
            return View(servicio.ListarTodo());
        }

    }
}
