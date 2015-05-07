using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using APP_WEBGRID_1.Models;

namespace APP_WEBGRID_1.Controllers
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/

        Negocios2015Entities db = new Negocios2015Entities();

        public ActionResult Index()
        {
            return View(db.productos.ToList());
        }

        public ActionResult IndexBuscar(string producto = null)
        {
            IQueryable<productos> resultado = db.productos;
            if (!string.IsNullOrEmpty(producto))
            {
                resultado = resultado.Where(p => p.NomProducto.Contains(producto));
            }
            return View(resultado.ToList());
        }

    }
}
