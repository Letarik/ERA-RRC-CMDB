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
    public class MoisturesController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Moistures
        public ActionResult Index()
        {
            var moistures = db.Moistures.Include(m => m.Density).Include(m => m.Material_Description);
            return View(moistures.ToList());
        }

        // GET: Moistures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moisture moisture = db.Moistures.Find(id);
            if (moisture == null)
            {
                return HttpNotFound();
            }
            return View(moisture);
        }

        // GET: Moistures/Create
        public ActionResult Create()
        {
            ViewBag.Density_ID = new SelectList(db.Densities, "ID", "Remark");
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name");
            return View();
        }

        // POST: Moistures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Density_ID,Container_No,Wet_Soil_Container,Dry_Soil_Container,Weight_of_Water,Weight_of_Container,Weight_of_Dry_Soil,Moisture_Content,OMC,Remark,Material_Description_ID")] Moisture moisture)
        {
            if (ModelState.IsValid)
            {
                db.Moistures.Add(moisture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Density_ID = new SelectList(db.Densities, "ID", "Remark", moisture.Density_ID);
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", moisture.Material_Description_ID);
            return View(moisture);
        }

        // GET: Moistures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moisture moisture = db.Moistures.Find(id);
            if (moisture == null)
            {
                return HttpNotFound();
            }
            ViewBag.Density_ID = new SelectList(db.Densities, "ID", "Remark", moisture.Density_ID);
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", moisture.Material_Description_ID);
            return View(moisture);
        }

        // POST: Moistures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Density_ID,Container_No,Wet_Soil_Container,Dry_Soil_Container,Weight_of_Water,Weight_of_Container,Weight_of_Dry_Soil,Moisture_Content,OMC,Remark,Material_Description_ID")] Moisture moisture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moisture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Density_ID = new SelectList(db.Densities, "ID", "Remark", moisture.Density_ID);
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", moisture.Material_Description_ID);
            return View(moisture);
        }

        // GET: Moistures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moisture moisture = db.Moistures.Find(id);
            if (moisture == null)
            {
                return HttpNotFound();
            }
            return View(moisture);
        }

        // POST: Moistures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Moisture moisture = db.Moistures.Find(id);
            db.Moistures.Remove(moisture);
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
