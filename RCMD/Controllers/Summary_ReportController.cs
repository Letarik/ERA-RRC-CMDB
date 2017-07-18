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
    public class Summary_ReportController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Summary_Report
        public ActionResult Index()
        {
            return View(db.Summary_Report.ToList());
        }

        // GET: Summary_Report/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Summary_Report summary_Report = db.Summary_Report.Find(id);
            if (summary_Report == null)
            {
                return HttpNotFound();
            }
            return View(summary_Report);
        }

        // GET: Summary_Report/Create
        public ActionResult Create()
        {
            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "Road_Section");
            return View();
        }

        // POST: Summary_Report/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Location_ID,Quarry_Area,Chanage,Offset_Distance,Latitude,Longtiude,Eatimated_Quantiy,LL,PI,SC,PP,GM,PM,OMC,MDD,CBR,SWELL,ACV,TFV,LAA,FI,SGR,WAT,ST,SEVT,Purpose_of_Material")] Summary_Report summary_Report)
        {
            if (ModelState.IsValid)
            {
                db.Summary_Report.Add(summary_Report);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(summary_Report);
        }

        // GET: Summary_Report/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Summary_Report summary_Report = db.Summary_Report.Find(id);
            if (summary_Report == null)
            {
                return HttpNotFound();
            }
            return View(summary_Report);
        }

        // POST: Summary_Report/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Road_Sction,Quarry_Area,Chanage,Offset_Distance,Latitude,Longtiude,Eatimated_Quantiy,LL,PI,SC,PP,GM,PM,OMC,MDD,CBR,SWELL,ACV,TFV,LAA,FI,SGR,WAT,ST,SEVT,Purpose_of_Material")] Summary_Report summary_Report)
        {
            if (ModelState.IsValid)
            {
                db.Entry(summary_Report).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(summary_Report);
        }

        // GET: Summary_Report/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Summary_Report summary_Report = db.Summary_Report.Find(id);
            if (summary_Report == null)
            {
                return HttpNotFound();
            }
            return View(summary_Report);
        }

        // POST: Summary_Report/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Summary_Report summary_Report = db.Summary_Report.Find(id);
            db.Summary_Report.Remove(summary_Report);
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
