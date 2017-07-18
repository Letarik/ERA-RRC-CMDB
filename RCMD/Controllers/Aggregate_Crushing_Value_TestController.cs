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
    public class Aggregate_Crushing_Value_TestController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Aggregate_Crushing_Value_Test
        public ActionResult Index()
        {
            var aggregate_Crushing_Value_Test = db.Aggregate_Crushing_Value_Test.Include(a => a.Particle_Size_Distribution);
            return View(aggregate_Crushing_Value_Test.ToList());
        }

        // GET: Aggregate_Crushing_Value_Test/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aggregate_Crushing_Value_Test aggregate_Crushing_Value_Test = db.Aggregate_Crushing_Value_Test.Find(id);
            if (aggregate_Crushing_Value_Test == null)
            {
                return HttpNotFound();
            }
            return View(aggregate_Crushing_Value_Test);
        }

        // GET: Aggregate_Crushing_Value_Test/Create
        public ActionResult Create()
        {
            ViewBag.Material_Description_ID = new SelectList(db.Particle_Size_Distribution, "ID", "Sample_Preparation");
            return View();
        }

        // POST: Aggregate_Crushing_Value_Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Material_Description_ID,Sample_No,Size_Of_Aggregate,Maximum_Load_Applied,Duration_Of_Testing,Weight_Of_Sample_Tested,Weight_Of_Sample_Retained,Aggregate_Crushing_Value,Average_Agg_Crushing_Value")] Aggregate_Crushing_Value_Test aggregate_Crushing_Value_Test)
        {
            if (ModelState.IsValid)
            {
                db.Aggregate_Crushing_Value_Test.Add(aggregate_Crushing_Value_Test);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Material_Description_ID = new SelectList(db.Particle_Size_Distribution, "ID", "Sample_Preparation", aggregate_Crushing_Value_Test.Material_Description_ID);
            return View(aggregate_Crushing_Value_Test);
        }

        // GET: Aggregate_Crushing_Value_Test/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aggregate_Crushing_Value_Test aggregate_Crushing_Value_Test = db.Aggregate_Crushing_Value_Test.Find(id);
            if (aggregate_Crushing_Value_Test == null)
            {
                return HttpNotFound();
            }
            ViewBag.Material_Description_ID = new SelectList(db.Particle_Size_Distribution, "ID", "Sample_Preparation", aggregate_Crushing_Value_Test.Material_Description_ID);
            return View(aggregate_Crushing_Value_Test);
        }

        // POST: Aggregate_Crushing_Value_Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Material_Description_ID,Sample_No,Size_Of_Aggregate,Maximum_Load_Applied,Duration_Of_Testing,Weight_Of_Sample_Tested,Weight_Of_Sample_Retained,Aggregate_Crushing_Value,Average_Agg_Crushing_Value")] Aggregate_Crushing_Value_Test aggregate_Crushing_Value_Test)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aggregate_Crushing_Value_Test).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Material_Description_ID = new SelectList(db.Particle_Size_Distribution, "ID", "Sample_Preparation", aggregate_Crushing_Value_Test.Material_Description_ID);
            return View(aggregate_Crushing_Value_Test);
        }

        // GET: Aggregate_Crushing_Value_Test/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aggregate_Crushing_Value_Test aggregate_Crushing_Value_Test = db.Aggregate_Crushing_Value_Test.Find(id);
            if (aggregate_Crushing_Value_Test == null)
            {
                return HttpNotFound();
            }
            return View(aggregate_Crushing_Value_Test);
        }

        // POST: Aggregate_Crushing_Value_Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aggregate_Crushing_Value_Test aggregate_Crushing_Value_Test = db.Aggregate_Crushing_Value_Test.Find(id);
            db.Aggregate_Crushing_Value_Test.Remove(aggregate_Crushing_Value_Test);
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
