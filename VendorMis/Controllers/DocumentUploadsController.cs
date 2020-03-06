using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VendorMis.Models;

namespace VendorMis.Controllers
{
    public class DocumentUploadsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DocumentUploads
        public ActionResult Index()
        {
            var documentUploads = db.DocumentUploads.Include(d => d.Vendors);
            return View(documentUploads.ToList());
        }

        // GET: DocumentUploads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentUpload documentUpload = db.DocumentUploads.Find(id);
            if (documentUpload == null)
            {
                return HttpNotFound();
            }
            return View(documentUpload);
        }

        // GET: DocumentUploads/Create
        public ActionResult Create()
        {
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName");
            return View();
        }

        // POST: DocumentUploads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocumentUploadId,VendorId,Document,Creator,CreatedDate")] DocumentUpload documentUpload)
        {
            if (ModelState.IsValid)
            {
                db.DocumentUploads.Add(documentUpload);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName", documentUpload.VendorId);
            return View(documentUpload);
        }

        // GET: DocumentUploads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentUpload documentUpload = db.DocumentUploads.Find(id);
            if (documentUpload == null)
            {
                return HttpNotFound();
            }
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName", documentUpload.VendorId);
            return View(documentUpload);
        }

        // POST: DocumentUploads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DocumentUploadId,VendorId,Document,Creator,CreatedDate")] DocumentUpload documentUpload)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documentUpload).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName", documentUpload.VendorId);
            return View(documentUpload);
        }

        // GET: DocumentUploads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentUpload documentUpload = db.DocumentUploads.Find(id);
            if (documentUpload == null)
            {
                return HttpNotFound();
            }
            return View(documentUpload);
        }

        // POST: DocumentUploads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DocumentUpload documentUpload = db.DocumentUploads.Find(id);
            db.DocumentUploads.Remove(documentUpload);
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
