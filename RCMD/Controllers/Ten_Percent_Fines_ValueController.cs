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
    public class Ten_Percent_Fines_ValueController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Ten_Percent_Fines_Value
        public ActionResult Index()
        {
            return View(db.Ten_Percent_Fines_Value.ToList());
        }

        // GET: Ten_Percent_Fines_Value/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ten_Percent_Fines_Value ten_Percent_Fines_Value = db.Ten_Percent_Fines_Value.Find(id);
            if (ten_Percent_Fines_Value == null)
            {
                return HttpNotFound();
            }
            return View(ten_Percent_Fines_Value);
        }

        // GET: Ten_Percent_Fines_Value/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ten_Percent_Fines_Value/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Sample_No,Size_OF_Aggregate,Load_Achived,Duration_Of_Testing,Penetration_Of_Plunger,Weight_Of_Sample_Tested,Weight_Of_Sample_Retained,Material_Passing,Force_Required_To_Produce,Average_Force,Wet,Remark")] Ten_Percent_Fines_Value ten_Percent_Fines_Value)
        {
            if (ModelState.IsValid)
            {
                db.Ten_Percent_Fines_Value.Add(ten_Percent_Fines_Value);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ten_Percent_Fines_Value);
        }

        // GET: Ten_Percent_Fines_Value/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ten_Percent_Fines_Value ten_Percent_Fines_Value = db.Ten_Percent_Fines_Value.Find(id);
            if (ten_Percent_Fines_Value == null)
            {
                return HttpNotFound();
            }
            return View(ten_Percent_Fines_Value);
        }

        // POST: Ten_Percent_Fines_Value/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Sample_No,Size_OF_Aggregate,Load_Achived,Duration_Of_Testing,Penetration_Of_Plunger,Weight_Of_Sample_Tested,Weight_Of_Sample_Retained,Material_Passing,Force_Required_To_Produce,Average_Force,Wet,Remark")] Ten_Percent_Fines_Value ten_Percent_Fines_Value)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ten_Percent_Fines_Value).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ten_Percent_Fines_Value);
        }

        // GET: Ten_Percent_Fines_Value/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ten_Percent_Fines_Value ten_Percent_Fines_Value = db.Ten_Percent_Fines_Value.Find(id);
            if (ten_Percent_Fines_Value == null)
            {
                return HttpNotFound();
            }
            return View(ten_Percent_Fines_Value);
        }

        // POST: Ten_Percent_Fines_Value/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ten_Percent_Fines_Value ten_Percent_Fines_Value = db.Ten_Percent_Fines_Value.Find(id);
            db.Ten_Percent_Fines_Value.Remove(ten_Percent_Fines_Value);
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
