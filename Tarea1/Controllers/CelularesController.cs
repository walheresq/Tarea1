using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tarea1.Models;

namespace Tarea1.Controllers
{
    public class CelularesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Celulares
        public async Task<ActionResult> Index()
        {
            return View(await db.Celulares.ToListAsync());
        }

        // GET: Celulares/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celular celular = await db.Celulares.FindAsync(id);
            if (celular == null)
            {
                return HttpNotFound();
            }
            return View(celular);
        }

        // GET: Celulares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Celulares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,IMEI,Marca,Modelo")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                db.Celulares.Add(celular);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(celular);
        }

        // GET: Celulares/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celular celular = await db.Celulares.FindAsync(id);
            if (celular == null)
            {
                return HttpNotFound();
            }
            return View(celular);
        }

        // POST: Celulares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,IMEI,Marca,Modelo")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                db.Entry(celular).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(celular);
        }

        // GET: Celulares/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Celular celular = await db.Celulares.FindAsync(id);
            if (celular == null)
            {
                return HttpNotFound();
            }
            return View(celular);
        }

        // POST: Celulares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Celular celular = await db.Celulares.FindAsync(id);
            db.Celulares.Remove(celular);
            await db.SaveChangesAsync();
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
