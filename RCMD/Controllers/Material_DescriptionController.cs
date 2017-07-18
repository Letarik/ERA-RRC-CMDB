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
    public class Material_DescriptionController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Material_Description
        public ActionResult Index()
        {
            return View(db.Material_Description.ToList());
        }

        // GET: Material_Description/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Material_Description material_Description = db.Material_Description.Find(id);
            if (material_Description == null)
            {
                return HttpNotFound();
            }
            return View(material_Description);
        }

        // GET: Material_Description/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Material_Description/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Tester_ID,Project_Name,Material_Description1,Purpose,Chainage,Tested_At,Sample_Taken_From,Date_Sampled,Date_Tested,Sample_No,Determination,Number_of_Blows,Determination_No,Container,Wt_Of_Container_Plus_Wet_Soil,Wt_Of_Container_Plus_Dry_Soil,Wt_Of_Container,Wt_Of_Water,Wt_Of_Dry_Soil,Moisture_Container,Average,Soil_Classification,Liquid_Limit_Average,Plastic_Limit_Average,Remark")] Material_Description material_Description)
        {
            if (ModelState.IsValid)
            {
                db.Material_Description.Add(material_Description);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(material_Description);
        }

        // GET: Material_Description/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Material_Description material_Description = db.Material_Description.Find(id);
            if (material_Description == null)
            {
                return HttpNotFound();
            }
            return View(material_Description);
        }

        // POST: Material_Description/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Tester_ID,Project_Name,Material_Description1,Purpose,Chainage,Tested_At,Sample_Taken_From,Date_Sampled,Date_Tested,Sample_No,Determination,Number_of_Blows,Determination_No,Container,Wt_Of_Container_Plus_Wet_Soil,Wt_Of_Container_Plus_Dry_Soil,Wt_Of_Container,Wt_Of_Water,Wt_Of_Dry_Soil,Moisture_Container,Average,Soil_Classification,Liquid_Limit_Average,Plastic_Limit_Average,Remark")] Material_Description material_Description)
        {
            if (ModelState.IsValid)
            {
                db.Entry(material_Description).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(material_Description);
        }

        // GET: Material_Description/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Material_Description material_Description = db.Material_Description.Find(id);
            if (material_Description == null)
            {
                return HttpNotFound();
            }
            return View(material_Description);
        }

        // POST: Material_Description/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Material_Description material_Description = db.Material_Description.Find(id);
            db.Material_Description.Remove(material_Description);
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
