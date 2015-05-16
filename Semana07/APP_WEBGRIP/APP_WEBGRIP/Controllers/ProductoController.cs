using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APP_WEBGRIP.Models;

namespace APP_WEBGRIP.Controllers
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/
        Negocios2015Entities1 db = new Negocios2015Entities1();


        public ActionResult Index()
        {
            return View(db.productos.ToList());
        }

    }
}
