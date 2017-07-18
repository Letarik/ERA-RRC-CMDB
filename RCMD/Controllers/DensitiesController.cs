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
    public class DensitiesController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Densities
        public ActionResult Index()
        {
            var densities = db.Densities.Include(d => d.Material_Description);
            return View(densities.ToList());
        }

        // GET: Densities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Density density = db.Densities.Find(id);
            if (density == null)
            {
                return HttpNotFound();
            }
            return View(density);
        }

        // GET: Densities/Create
        public ActionResult Create()
        {
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name");
            return View();
        }

        // POST: Densities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Density_Trial_No,Water_Added,Weight_of_Soil_Plus_Mold,Weight_of_Mold,Weight_of_Soil,Volume_of_Mold,Wet_Density_of_Soil,MDD,Remark,Material_Description_ID")] Density density)
        {
            if (ModelState.IsValid)
            {
                db.Densities.Add(density);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", density.Material_Description_ID);
            return View(density);
        }

        // GET: Densities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Density density = db.Densities.Find(id);
            if (density == null)
            {
                return HttpNotFound();
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", density.Material_Description_ID);
            return View(density);
        }

        // POST: Densities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Density_Trial_No,Water_Added,Weight_of_Soil_Plus_Mold,Weight_of_Mold,Weight_of_Soil,Volume_of_Mold,Wet_Density_of_Soil,MDD,Remark,Material_Description_ID")] Density density)
        {
            if (ModelState.IsValid)
            {
                db.Entry(density).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", density.Material_Description_ID);
            return View(density);
        }

        // GET: Densities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Density density = db.Densities.Find(id);
            if (density == null)
            {
                return HttpNotFound();
            }
            return View(density);
        }

        // POST: Densities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Density density = db.Densities.Find(id);
            db.Densities.Remove(density);
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
