using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PREGUNTA1.Models;

namespace PREGUNTA1.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/


        public ActionResult Index()
        {
            Negocios2015Entities db = new Negocios2015Entities();
            return View(db.clientes.ToList());
        }

        public ActionResult IndexBuscar(String cliente=null, String pais=null)
        {
            Negocios2015Entities db = new Negocios2015Entities();
            IQueryable<clientes> resultado = db.clientes;
            if (!string.IsNullOrEmpty(cliente) && string.IsNullOrEmpty(pais))
                resultado = resultado.Where(p => p.NomCliente.Contains(cliente));
            else if (string.IsNullOrEmpty(cliente) && !string.IsNullOrEmpty(pais))
                resultado = resultado.Where(p => p.paises.NombrePais.Contains(pais));
            else if (!string.IsNullOrEmpty(cliente) && !string.IsNullOrEmpty(pais))
            {
                resultado = resultado.Where(p => p.NomCliente.Contains(cliente));
                resultado = resultado.Where(p => p.paises.NombrePais.Contains(pais));
            }
            return View(resultado.ToList());
        }

    }
}
