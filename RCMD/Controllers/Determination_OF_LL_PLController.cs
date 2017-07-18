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
    public class Determination_OF_LL_PLController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Determination_OF_LL_PL
        public ActionResult Index()
        {
            var determination_OF_LL_PL = db.Determination_OF_LL_PL.Include(d => d.Location);
            return View(determination_OF_LL_PL.ToList());
        }

        // GET: Determination_OF_LL_PL/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_OF_LL_PL determination_OF_LL_PL = db.Determination_OF_LL_PL.Find(id);
            if (determination_OF_LL_PL == null)
            {
                return HttpNotFound();
            }
            return View(determination_OF_LL_PL);
        }

        // GET: Determination_OF_LL_PL/Create
        public ActionResult Create()
        {
            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "Road_Section");
            return View();
        }

        // POST: Determination_OF_LL_PL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Location_ID,Test_Number,Container,Determination_Type,Test_Method,Wt_of_Container_Plus_Wet_Soil,Wt_of_Container_Plus_Dry_Soil,Wt_of_Container")] Determination_OF_LL_PL determination_OF_LL_PL)
        {
            if (ModelState.IsValid)
            {
                    
                db.Determination_OF_LL_PL.Add(determination_OF_LL_PL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "Road_Section", determination_OF_LL_PL.Location_ID);
            return View(determination_OF_LL_PL);
        }

        // GET: Determination_OF_LL_PL/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_OF_LL_PL determination_OF_LL_PL = db.Determination_OF_LL_PL.Find(id);
            if (determination_OF_LL_PL == null)
            {
                return HttpNotFound();
            }
            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "Road_Section", determination_OF_LL_PL.Location_ID);
            return View(determination_OF_LL_PL);
        }

        // POST: Determination_OF_LL_PL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Location_ID,Test_Number,Container,Determination_Type,Test_Method,Wt_of_Container_Plus_Wet_Soil,Wt_of_Container_Plus_Dry_Soil,Wt_of_Container")] Determination_OF_LL_PL determination_OF_LL_PL)
        {
            if (ModelState.IsValid)
            {
                
                db.Entry(determination_OF_LL_PL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Location_ID = new SelectList(db.Locations, "ID", "Road_Section", determination_OF_LL_PL.Location_ID);
            return View(determination_OF_LL_PL);
        }

        // GET: Determination_OF_LL_PL/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_OF_LL_PL determination_OF_LL_PL = db.Determination_OF_LL_PL.Find(id);
            if (determination_OF_LL_PL == null)
            {
                return HttpNotFound();
            }
            return View(determination_OF_LL_PL);
        }

        // POST: Determination_OF_LL_PL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Determination_OF_LL_PL determination_OF_LL_PL = db.Determination_OF_LL_PL.Find(id);
            db.Determination_OF_LL_PL.Remove(determination_OF_LL_PL);
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
