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
    public class Moisture_DeterminationController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Moisture_Determination
        public ActionResult Index()
        {
            var moisture_Determination = db.Moisture_Determination.Include(m => m.Material_Description);
            return View(moisture_Determination.ToList());
        }

        // GET: Moisture_Determination/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moisture_Determination moisture_Determination = db.Moisture_Determination.Find(id);
            if (moisture_Determination == null)
            {
                return HttpNotFound();
            }
            return View(moisture_Determination);
        }

        // GET: Moisture_Determination/Create
        public ActionResult Create()
        {
            ViewBag.Material_Determination_No = new SelectList(db.Material_Description, "ID", "Project_Name");
            return View();
        }

        // POST: Moisture_Determination/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Material_Determination_No,Soaking_Condition,Container_Type,Container_No,Wet_Soil_Plus_Container,Dry_Soil_Plus_Container,Weight_Of_Water,Weight_Of_Container,Weight_of_Dry_Soil,Moisture_Content,AVG_Moisture_Content")] Moisture_Determination moisture_Determination)
        {
            if (ModelState.IsValid)
            {
                db.Moisture_Determination.Add(moisture_Determination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Material_Determination_No = new SelectList(db.Material_Description, "ID", "Project_Name", moisture_Determination.Material_Determination_No);
            return View(moisture_Determination);
        }

        // GET: Moisture_Determination/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moisture_Determination moisture_Determination = db.Moisture_Determination.Find(id);
            if (moisture_Determination == null)
            {
                return HttpNotFound();
            }
            ViewBag.Material_Determination_No = new SelectList(db.Material_Description, "ID", "Project_Name", moisture_Determination.Material_Determination_No);
            return View(moisture_Determination);
        }

        // POST: Moisture_Determination/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Material_Determination_No,Soaking_Condition,Container_Type,Container_No,Wet_Soil_Plus_Container,Dry_Soil_Plus_Container,Weight_Of_Water,Weight_Of_Container,Weight_of_Dry_Soil,Moisture_Content,AVG_Moisture_Content")] Moisture_Determination moisture_Determination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moisture_Determination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Material_Determination_No = new SelectList(db.Material_Description, "ID", "Project_Name", moisture_Determination.Material_Determination_No);
            return View(moisture_Determination);
        }

        // GET: Moisture_Determination/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moisture_Determination moisture_Determination = db.Moisture_Determination.Find(id);
            if (moisture_Determination == null)
            {
                return HttpNotFound();
            }
            return View(moisture_Determination);
        }

        // POST: Moisture_Determination/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Moisture_Determination moisture_Determination = db.Moisture_Determination.Find(id);
            db.Moisture_Determination.Remove(moisture_Determination);
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
