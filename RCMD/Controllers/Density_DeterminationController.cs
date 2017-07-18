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
    public class Density_DeterminationController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Density_Determination
        public ActionResult Index()
        {
            var density_Determination = db.Density_Determination.Include(d => d.Material_Description).Include(d => d.Moisture);
            return View(density_Determination.ToList());
        }

        // GET: Density_Determination/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Density_Determination density_Determination = db.Density_Determination.Find(id);
            if (density_Determination == null)
            {
                return HttpNotFound();
            }
            return View(density_Determination);
        }

        // GET: Density_Determination/Create
        public ActionResult Create()
        {
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name");
            ViewBag.Moisture_ID = new SelectList(db.Moistures, "ID", "Container_No");
            return View();
        }

        // POST: Density_Determination/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Moisture_ID,Soaking_Condition,Model_Type,Model_No,Weight_Of_Soil_Plus_Mold,Weight_Of_Mold,Weight_Of_Soil,Volume_Of_Mold,Wet_Density_Of_Soil,Dry_Density_Of_Soil,Material_Description_ID")] Density_Determination density_Determination)
        {
            if (ModelState.IsValid)
            {
                db.Density_Determination.Add(density_Determination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", density_Determination.Material_Description_ID);
            ViewBag.Moisture_ID = new SelectList(db.Moistures, "ID", "Container_No", density_Determination.Moisture_ID);
            return View(density_Determination);
        }

        // GET: Density_Determination/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Density_Determination density_Determination = db.Density_Determination.Find(id);
            if (density_Determination == null)
            {
                return HttpNotFound();
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", density_Determination.Material_Description_ID);
            ViewBag.Moisture_ID = new SelectList(db.Moistures, "ID", "Container_No", density_Determination.Moisture_ID);
            return View(density_Determination);
        }

        // POST: Density_Determination/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Moisture_ID,Soaking_Condition,Model_Type,Model_No,Weight_Of_Soil_Plus_Mold,Weight_Of_Mold,Weight_Of_Soil,Volume_Of_Mold,Wet_Density_Of_Soil,Dry_Density_Of_Soil,Material_Description_ID")] Density_Determination density_Determination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(density_Determination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", density_Determination.Material_Description_ID);
            ViewBag.Moisture_ID = new SelectList(db.Moistures, "ID", "Container_No", density_Determination.Moisture_ID);
            return View(density_Determination);
        }

        // GET: Density_Determination/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Density_Determination density_Determination = db.Density_Determination.Find(id);
            if (density_Determination == null)
            {
                return HttpNotFound();
            }
            return View(density_Determination);
        }

        // POST: Density_Determination/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Density_Determination density_Determination = db.Density_Determination.Find(id);
            db.Density_Determination.Remove(density_Determination);
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
