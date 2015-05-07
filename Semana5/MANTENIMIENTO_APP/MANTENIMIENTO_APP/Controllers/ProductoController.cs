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
    [Authorize]
    public class ProductoController : Controller
    {
        private MyDataContext db = new MyDataContext();

        //
        // GET: /Producto/

        public ActionResult Index()
        {
            var listaproducto = db.listaProducto.Include(p => p.categoria).Include(p => p.proveedor);
            return View(listaproducto.ToList());
        }

        //
        // GET: /Producto/Details/5

        public ActionResult Details(int id = 0)
        {
            Producto producto = db.listaProducto.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        //
        // GET: /Producto/Create

        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(db.listaCategoria, "CategoriaId", "Descripcion");
            ViewBag.ProveedorId = new SelectList(db.listaProveedor, "ProveedorId", "Nombre");
            return View();
        }

        //
        // POST: /Producto/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.listaProducto.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(db.listaCategoria, "CategoriaId", "Descripcion", producto.CategoriaId);
            ViewBag.ProveedorId = new SelectList(db.listaProveedor, "ProveedorId", "Nombre", producto.ProveedorId);
            return View(producto);
        }

        //
        // GET: /Producto/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Producto producto = db.listaProducto.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoriaId = new SelectList(db.listaCategoria, "CategoriaId", "Descripcion", producto.CategoriaId);
            ViewBag.ProveedorId = new SelectList(db.listaProveedor, "ProveedorId", "Nombre", producto.ProveedorId);
            return View(producto);
        }

        //
        // POST: /Producto/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaId = new SelectList(db.listaCategoria, "CategoriaId", "Descripcion", producto.CategoriaId);
            ViewBag.ProveedorId = new SelectList(db.listaProveedor, "ProveedorId", "Nombre", producto.ProveedorId);
            return View(producto);
        }

        //
        // GET: /Producto/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Producto producto = db.listaProducto.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        //
        // POST: /Producto/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = db.listaProducto.Find(id);
            db.listaProducto.Remove(producto);
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