using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APP_MANTENIMIENTO.Models;

namespace APP_MANTENIMIENTO.Controllers
{
    public class EmpleadoController : Controller
    {
        private MyDataContext db = new MyDataContext();

        //
        // GET: /Empleado/

        public ActionResult Index()
        {
            return View(db.listEmpleados.ToList());
        }

        //
        // GET: /Empleado/Details/5

        public ActionResult Details(int id = 0)
        {
            Empleado empleado = db.listEmpleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        //
        // GET: /Empleado/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Empleado/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.listEmpleados.Add(empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleado);
        }

        //
        // GET: /Empleado/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Empleado empleado = db.listEmpleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        //
        // POST: /Empleado/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        //
        // GET: /Empleado/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Empleado empleado = db.listEmpleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        //
        // POST: /Empleado/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = db.listEmpleados.Find(id);
            db.listEmpleados.Remove(empleado);
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