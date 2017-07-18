using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RCMD.Models;

namespace RCMD.Controllers
{
    public class Particle_Size_DistributionController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Particle_Size_Distribution
        public ActionResult Index()
        {
            var particle_Size_Distribution = db.Particle_Size_Distribution.Include(p => p.Material_Description).Include(p => p.Material_Description1);
            return View(particle_Size_Distribution.ToList());
        }

        // GET: Particle_Size_Distribution/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particle_Size_Distribution particle_Size_Distribution = db.Particle_Size_Distribution.Find(id);
            if (particle_Size_Distribution == null)
            {
                return HttpNotFound();
            }
            return View(particle_Size_Distribution);
        }

        // GET: Particle_Size_Distribution/Create
        public ActionResult Create()
        {
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name");
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name");
            return View();
        }

        // POST: Particle_Size_Distribution/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Sample_Preparation,Method_Of_Sieving,Sieve_Size,Weight_Retained,Retained_Percent,Passing_Percent,Note,Remark,Material_Description_ID")] Particle_Size_Distribution particle_Size_Distribution)
        {
            if (ModelState.IsValid)
            {
                db.Particle_Size_Distribution.Add(particle_Size_Distribution);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", particle_Size_Distribution.Material_Description_ID);
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", particle_Size_Distribution.Material_Description_ID);
            return View(particle_Size_Distribution);
        }

        // GET: Particle_Size_Distribution/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particle_Size_Distribution particle_Size_Distribution = db.Particle_Size_Distribution.Find(id);
            if (particle_Size_Distribution == null)
            {
                return HttpNotFound();
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", particle_Size_Distribution.Material_Description_ID);
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", particle_Size_Distribution.Material_Description_ID);
            return View(particle_Size_Distribution);
        }

        // POST: Particle_Size_Distribution/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Sample_Preparation,Method_Of_Sieving,Sieve_Size,Weight_Retained,Retained_Percent,Passing_Percent,Note,Remark,Material_Description_ID")] Particle_Size_Distribution particle_Size_Distribution)
        {
            if (ModelState.IsValid)
            {
                db.Entry(particle_Size_Distribution).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", particle_Size_Distribution.Material_Description_ID);
            ViewBag.Material_Description_ID = new SelectList(db.Material_Description, "ID", "Project_Name", particle_Size_Distribution.Material_Description_ID);
            return View(particle_Size_Distribution);
        }

        // GET: Particle_Size_Distribution/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particle_Size_Distribution particle_Size_Distribution = db.Particle_Size_Distribution.Find(id);
            if (particle_Size_Distribution == null)
            {
                return HttpNotFound();
            }
            return View(particle_Size_Distribution);
        }

        // POST: Particle_Size_Distribution/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Particle_Size_Distribution particle_Size_Distribution = db.Particle_Size_Distribution.Find(id);
            db.Particle_Size_Distribution.Remove(particle_Size_Distribution);
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
