using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APP_DBCONTEXT002.Models;


namespace APP_DBCONTEXT002.Controllers
{
    public class MantenimientoController : Controller
    {
        //
        // GET: /Mantenimiento/

        DataBase1DB db = new DataBase1DB();

        public ActionResult Index()
        {
            var lista = db.tb_materiales;
            return View(lista.ToList());
        }

        public ActionResult Nuevo() {
            Tb_Material reg = new Tb_Material();
            return View(reg);
        }

        [HttpPost]
        public ActionResult Nuevo(Tb_Material reg) {
            if (!ModelState.IsValid)
                return View(reg);
            try{
                db.tb_materiales.Add(reg);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            catch(Exception ex){
                ValidateModel(ex.Message);
                return View(reg);
            }
        }

    }
}
