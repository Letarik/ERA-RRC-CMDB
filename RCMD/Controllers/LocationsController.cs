using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RCMD.Models;
using System.IO;



namespace RCMD.Views
{
    public class LocationsController : Controller
    {
        private NRCMDBEntities db = new NRCMDBEntities();
        private int location_id; 
        // GET: Locations
        public ActionResult Index()
        {
            return View(db.Locations.ToList());
        }

        // GET: Locations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // GET: Locations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        // To protect from over-posting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Location location, HttpPostedFileBase postedFile)
        {
            if (postedFile != null)
            {
                string FileName = postedFile.FileName,FilePath;
                //To create a new folder by the file name
                FileName = FileName.Remove(FileName.Length - 4);
                //Main file upload path
                FilePath = "~/Uploads/";
                string SavingDirectroy = string.Concat(FilePath, FileName); 
                //File saving directory full path to save captured image/photo in the directory                            
                string path = Server.MapPath(SavingDirectroy);
                //To save the file full path at location table in the database
                string FileFullPath = Path.Combine(FileName, Path.GetFileName(postedFile.FileName));
                location.Photo = FileFullPath;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);                 
                }
                postedFile.SaveAs(Path.Combine(path, Path.GetFileName(postedFile.FileName)));
                ViewBag.Message = "File uploaded successfully.";
            }

            if (ModelState.IsValid)
                        {                                                     
                            db.Locations.Add(new Location
                            {
                                ID = location.ID,
                                Material_Description = location.Material_Description,
                                District = location.District,
                                Road_Section=location.Road_Section,
                                Quarry_Area=location.Quarry_Area,
                                Change=location.Change,
                                Offset_Distance=location.Offset_Distance,
                                Latitude=location.Latitude,
                                Longitude=location.Longitude,
                                Elevation=location.Elevation,
                                Estimated_Quantity=location.Estimated_Quantity,
                                Purpose=location.Purpose,
                                Test_Result=location.Test_Result,
                                Date_Sampled= DateTime.Now,
                                Date_Tested= DateTime.Now,
                                Photo =location.Photo                                                               
                            });
                       }                                                                       
                     //db.Locations.Add(location);
                     db.SaveChanges();
            //  return RedirectToAction("Index");
            return RedirectToAction("Create", "Summary_Report");
            //return View(location);
        }

        // GET: Locations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
          
            location_id = (int)location.ID;
            ViewBag.Photo = new SelectList(db.Locations.Where(g => g.ID == location_id).ToList(), "ID", "Photo");
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,District,Road_Section,Quarry_Area,Change,Offset_Distance,Latitude,Longitude,Elevation,Material_Description,Photo")] Location location, HttpPostedFileBase postedFile)
        {
            if (postedFile != null)
            {
                string FileName = postedFile.FileName, FilePath;
                //To create a new folder by the file name
                FileName = FileName.Remove(FileName.Length - 4);
                //Main file upload path
                FilePath = "~/Uploads/";
                string SavingDirectroy = string.Concat(FilePath, FileName);
                //File saving directory full path to save captured image/photo in the directory                            
                string path = Server.MapPath(SavingDirectroy);
                //To save the file full path at location table in the database
                string FileFullPath = Path.Combine(FileName, Path.GetFileName(postedFile.FileName));
                location.Photo = FileFullPath;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                postedFile.SaveAs(Path.Combine(path, Path.GetFileName(postedFile.FileName)));
                ViewBag.Message = "File uploaded successfully.";
            }
            
            if (ModelState.IsValid)
            {
                location.Date_Sampled = DateTime.Now;
                location.Date_Tested = DateTime.Now;
                db.Entry(location).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(location);
        }

        // GET: Locations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Location location = db.Locations.Find(id);
            db.Locations.Remove(location);
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
