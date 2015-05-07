using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MANTENIMIENTO_APP.Models;

namespace MANTENIMIENTO_APP.Controllers
{
    public class ProveedorController : Controller
    {
        private MyDataContext db = new MyDataContext();

        //
        // GET: /Proveedor/

        public ActionResult Index()
        {
            return View(db.listaProveedor.ToList());
        }

        //
        // GET: /Proveedor/Details/5

        public ActionResult Details(int id = 0)
        {
            Proveedor proveedor = db.listaProveedor.Find(id);
            if (proveedor == null)
            {
                return HttpNotFound();
            }
            return View(proveedor);
        }

        //
        // GET: /Proveedor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Proveedor/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                db.listaProveedor.Add(proveedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proveedor);
        }

        //
        // GET: /Proveedor/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Proveedor proveedor = db.listaProveedor.Find(id);
            if (proveedor == null)
            {
                return HttpNotFound();
            }
            return View(proveedor);
        }

        //
        // POST: /Proveedor/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proveedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proveedor);
        }

        //
        // GET: /Proveedor/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Proveedor proveedor = db.listaProveedor.Find(id);
            if (proveedor == null)
            {
                return HttpNotFound();
            }
            return View(proveedor);
        }

        //
        // POST: /Proveedor/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proveedor proveedor = db.listaProveedor.Find(id);
            db.listaProveedor.Remove(proveedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}