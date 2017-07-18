using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RCMD.Models;

namespace RCMD.Views
{
    public class Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_FineController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine
        public ActionResult Index()
        {
            var determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine = db.Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Include(d => d.Location);
            return View(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.ToList());
        }

        // GET: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine = db.Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Find(id);
            if (determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine == null)
            {
                return HttpNotFound();
            }
            return View(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine);
        }

        // GET: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine/Create
        public ActionResult Create()
        {
            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "District");
            return View();
        }

        // POST: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Location_ID,WSASDT,WSSDAIA,MoAIW,Specific_Gravity,Apparent_Specific_Gravity,Water_Absorption_of_Aggregate")] Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine)
        {
            if (ModelState.IsValid)
            {
                db.Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Add(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "District", determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Location_ID);
            return View(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine);
        }

        // GET: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine = db.Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Find(id);
            if (determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine == null)
            {
                return HttpNotFound();
            }
            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "District", determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Location_ID);
            return View(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine);
        }

        // POST: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Location_ID,WSASDT,WSSDAIA,MoAIW,Specific_Gravity,Apparent_Specific_Gravity,Water_Absorption_of_Aggregate")] Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "District", determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Location_ID);
            return View(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine);
        }

        // GET: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine = db.Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Find(id);
            if (determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine == null)
            {
                return HttpNotFound();
            }
            return View(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine);
        }

        // POST: Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine = db.Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Find(id);
            db.Determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine.Remove(determnation_Of_Specific_Gravity_And_Water_Absorption_Of_Fine);
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
