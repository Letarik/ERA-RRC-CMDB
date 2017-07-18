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
    public class Determination_0f_LL_PL_End_Resutl_ViewController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();

        // GET: Determination_0f_LL_PL_End_Resutl_View
        public ActionResult Index()
        {
            return View(db.Determination_0f_LL_PL_End_Resutl_View.ToList());
        }

        // GET: Determination_0f_LL_PL_End_Resutl_View/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_0f_LL_PL_End_Resutl_View determination_0f_LL_PL_End_Resutl_View = db.Determination_0f_LL_PL_End_Resutl_View.Find(id);
            if (determination_0f_LL_PL_End_Resutl_View == null)
            {
                return HttpNotFound();
            }
            return View(determination_0f_LL_PL_End_Resutl_View);
        }

        // GET: Determination_0f_LL_PL_End_Resutl_View/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Determination_0f_LL_PL_End_Resutl_View/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Test_Number,Container,Determination_Type,Test_Method,Wt_of_Container_Plus_Wet_Soil,Wt_of_Container_Plus_Dry_Soil,Wt_of_Container,Wt_of_Water,Wt_of_Dry_Soil,Moisture_Container")] Determination_0f_LL_PL_End_Resutl_View determination_0f_LL_PL_End_Resutl_View)
        {
            if (ModelState.IsValid)
            {
                db.Determination_0f_LL_PL_End_Resutl_View.Add(determination_0f_LL_PL_End_Resutl_View);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(determination_0f_LL_PL_End_Resutl_View);
        }

        // GET: Determination_0f_LL_PL_End_Resutl_View/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_0f_LL_PL_End_Resutl_View determination_0f_LL_PL_End_Resutl_View = db.Determination_0f_LL_PL_End_Resutl_View.Find(id);
            if (determination_0f_LL_PL_End_Resutl_View == null)
            {
                return HttpNotFound();
            }
            return View(determination_0f_LL_PL_End_Resutl_View);
        }

        // POST: Determination_0f_LL_PL_End_Resutl_View/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Test_Number,Container,Determination_Type,Test_Method,Wt_of_Container_Plus_Wet_Soil,Wt_of_Container_Plus_Dry_Soil,Wt_of_Container,Wt_of_Water,Wt_of_Dry_Soil,Moisture_Container")] Determination_0f_LL_PL_End_Resutl_View determination_0f_LL_PL_End_Resutl_View)
        {
            if (ModelState.IsValid)
            {
                db.Entry(determination_0f_LL_PL_End_Resutl_View).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(determination_0f_LL_PL_End_Resutl_View);
        }

        // GET: Determination_0f_LL_PL_End_Resutl_View/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Determination_0f_LL_PL_End_Resutl_View determination_0f_LL_PL_End_Resutl_View = db.Determination_0f_LL_PL_End_Resutl_View.Find(id);
            if (determination_0f_LL_PL_End_Resutl_View == null)
            {
                return HttpNotFound();
            }
            return View(determination_0f_LL_PL_End_Resutl_View);
        }

        // POST: Determination_0f_LL_PL_End_Resutl_View/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Determination_0f_LL_PL_End_Resutl_View determination_0f_LL_PL_End_Resutl_View = db.Determination_0f_LL_PL_End_Resutl_View.Find(id);
            db.Determination_0f_LL_PL_End_Resutl_View.Remove(determination_0f_LL_PL_End_Resutl_View);
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
