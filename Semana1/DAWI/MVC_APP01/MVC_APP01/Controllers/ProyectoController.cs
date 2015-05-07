using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_APP01.Models;

namespace MVC_APP01.Controllers
{
    public class ProyectoController : Controller
    {
        //
        // GET: /Proyecto/

        public ActionResult Index()
        {
            ViewBag.titulo = "Bienvenido";
            ViewBag.detalle = "Desarrollo para Entorno Web";

            return View();
        }
        public ActionResult Consulta()
        {
            Cliente cli = new Cliente();
            cli.codigo = "CL001254";
            cli.nombre = "Importaciones ECOVESA S.A.C";
            cli.direccion = "AV. MEXICO 1212";
            cli.email = "ECOVESA@GMAIL.COM";
            return View(cli);
        }

    }
}
