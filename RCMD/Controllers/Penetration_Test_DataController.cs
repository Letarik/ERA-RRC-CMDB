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
    public class Penetration_Test_DataController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Penetration_Test_Data
        public ActionResult Index()
        {
            var penetration_Test_Data = db.Penetration_Test_Data.Include(p => p.Material_Description);
            return View(penetration_Test_Data.ToList());
        }

        // GET: Penetration_Test_Data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Penetration_Test_Data penetration_Test_Data = db.Penetration_Test_Data.Find(id);
            if (penetration_Test_Data == null)
            {
                return HttpNotFound();
            }
            return View(penetration_Test_Data);
        }

        // GET: Penetration_Test_Data/Create
        public ActionResult Create()
        {
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name");
            return View();
        }

        // POST: Penetration_Test_Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Ring_Factor,Penetration,No_Of_Blows,Dialrdg,Penetration_Load,Cor_Load,CBR,RDG_Before_Soaking,RDG_After_Soaking,Percent_Swell,Average_Percent_Swell,Unit,Blow_No,Material_Description_ID")] Penetration_Test_Data penetration_Test_Data)
        {
            if (ModelState.IsValid)
            {
                db.Penetration_Test_Data.Add(penetration_Test_Data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", penetration_Test_Data.Material_Description_ID);
            return View(penetration_Test_Data);
        }

        // GET: Penetration_Test_Data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Penetration_Test_Data penetration_Test_Data = db.Penetration_Test_Data.Find(id);
            if (penetration_Test_Data == null)
            {
                return HttpNotFound();
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", penetration_Test_Data.Material_Description_ID);
            return View(penetration_Test_Data);
        }

        // POST: Penetration_Test_Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Ring_Factor,Penetration,No_Of_Blows,Dialrdg,Penetration_Load,Cor_Load,CBR,RDG_Before_Soaking,RDG_After_Soaking,Percent_Swell,Average_Percent_Swell,Unit,Blow_No,Material_Description_ID")] Penetration_Test_Data penetration_Test_Data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(penetration_Test_Data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", penetration_Test_Data.Material_Description_ID);
            return View(penetration_Test_Data);
        }

        // GET: Penetration_Test_Data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Penetration_Test_Data penetration_Test_Data = db.Penetration_Test_Data.Find(id);
            if (penetration_Test_Data == null)
            {
                return HttpNotFound();
            }
            return View(penetration_Test_Data);
        }

        // POST: Penetration_Test_Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Penetration_Test_Data penetration_Test_Data = db.Penetration_Test_Data.Find(id);
            db.Penetration_Test_Data.Remove(penetration_Test_Data);
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
