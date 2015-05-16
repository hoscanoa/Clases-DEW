using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PREGUNTA1.Models;

namespace PREGUNTA1.Controllers
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/

        public ActionResult Index()
        {
            Negocios2015Entities db = new Negocios2015Entities();
            return View(db.productos.ToList());
        }

        public ActionResult BuscarIndex(string producto=null)
        {
            Negocios2015Entities db = new Negocios2015Entities();
            IQueryable<productos> resultado = db.productos;

            if (!string.IsNullOrEmpty(producto))
            {
                resultado = resultado.Where(p => p.NomProducto.Contains(producto));
            }

            return View(resultado.ToList());
        }
    }
}
