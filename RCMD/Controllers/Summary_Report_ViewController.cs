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
    public class Summary_Report_ViewController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Summary_Report_View
        public ActionResult Index()
        {
            return View(db.Summary_Report_View.ToList());
        }

        // GET: Summary_Report_View/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Summary_Report_View summary_Report_View = db.Summary_Report_View.Find(id);
            if (summary_Report_View == null)
            {
                return HttpNotFound();
            }
            return View(summary_Report_View);
        }

        // GET: Summary_Report_View/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Summary_Report_View/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Purpose_of_Material,ID,Location_ID,Road_Sction,Quarry_Area,Chanage,Offset_Distance,Latitude,Longtiude,Eatimated_Quantiy,LL,PI,SC,PP,GM,PM,OMC,MDD,CBR,SWELL,TFV,ACV,LAA,FI,SGR,WAT,ST,SEVT")] Summary_Report_View summary_Report_View)
        {
            if (ModelState.IsValid)
            {
                db.Summary_Report_View.Add(summary_Report_View);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(summary_Report_View);
        }

        // GET: Summary_Report_View/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Summary_Report_View summary_Report_View = db.Summary_Report_View.Find(id);
            if (summary_Report_View == null)
            {
                return HttpNotFound();
            }
            return View(summary_Report_View);
        }

        // POST: Summary_Report_View/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Road_Sction,Quarry_Area,Chanage,Offset_Distance,Latitude,Longtiude,Eatimated_Quantiy,LL,PI,SC,PP,GM,PM,OMC,MDD,CBR,SWELL,TFV,ACV,LAA,FI,SGR,WAT,ST,SEVT,Purpose_of_Material,Road_Section")] Summary_Report_View summary_Report_View)
        {
            if (ModelState.IsValid)
            {
                db.Entry(summary_Report_View).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(summary_Report_View);
        }

        // GET: Summary_Report_View/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Summary_Report_View summary_Report_View = db.Summary_Report_View.Find(id);
            if (summary_Report_View == null)
            {
                return HttpNotFound();
            }
            return View(summary_Report_View);
        }

        // POST: Summary_Report_View/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Summary_Report_View summary_Report_View = db.Summary_Report_View.Find(id);
            db.Summary_Report_View.Remove(summary_Report_View);
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
