﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webMitienda.contexto;

namespace webMitienda.Controllers
{
    public class proveedoresController : Controller
    {
        private MitiendaEntities db = new MitiendaEntities();

        // GET: proveedores
        public ActionResult Index()
        {
            return View(db.tb_proveedores.ToList());
        }

        // GET: proveedores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_proveedores tb_proveedores = db.tb_proveedores.Find(id);
            if (tb_proveedores == null)
            {
                return HttpNotFound();
            }
            return View(tb_proveedores);
        }

        // GET: proveedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: proveedores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_proveedor,nombre_proveedor")] tb_proveedores tb_proveedores)
        {
            if (ModelState.IsValid)
            {
                db.tb_proveedores.Add(tb_proveedores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_proveedores);
        }

        // GET: proveedores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_proveedores tb_proveedores = db.tb_proveedores.Find(id);
            if (tb_proveedores == null)
            {
                return HttpNotFound();
            }
            return View(tb_proveedores);
        }

        // POST: proveedores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_proveedor,nombre_proveedor")] tb_proveedores tb_proveedores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_proveedores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_proveedores);
        }

        // GET: proveedores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_proveedores tb_proveedores = db.tb_proveedores.Find(id);
            if (tb_proveedores == null)
            {
                return HttpNotFound();
            }
            return View(tb_proveedores);
        }

        // POST: proveedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_proveedores tb_proveedores = db.tb_proveedores.Find(id);
            db.tb_proveedores.Remove(tb_proveedores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
