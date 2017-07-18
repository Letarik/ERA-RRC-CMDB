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
    public class Determination_Of_Flakiness_IndexController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Determination_Of_Flakiness_Index
        public ActionResult Index()
        {
            var determination_Of_Flakiness_Index = db.Determination_Of_Flakiness_Index.Include(d => d.Material_Description);
            return View(determination_Of_Flakiness_Index.ToList());
        }

        // GET: Determination_Of_Flakiness_Index/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_Of_Flakiness_Index determination_Of_Flakiness_Index = db.Determination_Of_Flakiness_Index.Find(id);
            if (determination_Of_Flakiness_Index == null)
            {
                return HttpNotFound();
            }
            return View(determination_Of_Flakiness_Index);
        }

        // GET: Determination_Of_Flakiness_Index/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Material_Description, "ID", "Project_Name");
            return View();
        }

        // POST: Determination_Of_Flakiness_Index/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Material_Description_ID,Sieves_Nominal_Apperture_Size,Mass_Of_Test_Portion,Flakiness_Index,Aggregate,Flakiness_Index_Weighted_Average,Total_Weight")] Determination_Of_Flakiness_Index determination_Of_Flakiness_Index)
        {
            if (ModelState.IsValid)
            {
                db.Determination_Of_Flakiness_Index.Add(determination_Of_Flakiness_Index);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.Material_Description, "ID", "Project_Name", determination_Of_Flakiness_Index.ID);
            return View(determination_Of_Flakiness_Index);
        }

        // GET: Determination_Of_Flakiness_Index/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_Of_Flakiness_Index determination_Of_Flakiness_Index = db.Determination_Of_Flakiness_Index.Find(id);
            if (determination_Of_Flakiness_Index == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.Material_Description, "ID", "Project_Name", determination_Of_Flakiness_Index.ID);
            return View(determination_Of_Flakiness_Index);
        }

        // POST: Determination_Of_Flakiness_Index/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Material_Description_ID,Sieves_Nominal_Apperture_Size,Mass_Of_Test_Portion,Flakiness_Index,Aggregate,Flakiness_Index_Weighted_Average,Total_Weight")] Determination_Of_Flakiness_Index determination_Of_Flakiness_Index)
        {
            if (ModelState.IsValid)
            {
                db.Entry(determination_Of_Flakiness_Index).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Material_Description, "ID", "Project_Name", determination_Of_Flakiness_Index.ID);
            return View(determination_Of_Flakiness_Index);
        }

        // GET: Determination_Of_Flakiness_Index/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_Of_Flakiness_Index determination_Of_Flakiness_Index = db.Determination_Of_Flakiness_Index.Find(id);
            if (determination_Of_Flakiness_Index == null)
            {
                return HttpNotFound();
            }
            return View(determination_Of_Flakiness_Index);
        }

        // POST: Determination_Of_Flakiness_Index/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Determination_Of_Flakiness_Index determination_Of_Flakiness_Index = db.Determination_Of_Flakiness_Index.Find(id);
            db.Determination_Of_Flakiness_Index.Remove(determination_Of_Flakiness_Index);
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
