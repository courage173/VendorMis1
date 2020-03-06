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
    public class CriticalDocumentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CriticalDocuments
        public ActionResult Index()
        {
            var criticalDocuments = db.CriticalDocuments.Include(c => c.Vendors);
            return View(criticalDocuments.ToList());
        }

        // GET: CriticalDocuments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticalDocument criticalDocument = db.CriticalDocuments.Find(id);
            if (criticalDocument == null)
            {
                return HttpNotFound();
            }
            return View(criticalDocument);
        }

        // GET: CriticalDocuments/Create
        public ActionResult Create()
        {
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName");
            return View();
        }

        // POST: CriticalDocuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CriticalDocumentId,VendorId,Document,Score")] CriticalDocument criticalDocument)
        {
            if (ModelState.IsValid)
            {
                db.CriticalDocuments.Add(criticalDocument);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName", criticalDocument.VendorId);
            return View(criticalDocument);
        }

        // GET: CriticalDocuments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticalDocument criticalDocument = db.CriticalDocuments.Find(id);
            if (criticalDocument == null)
            {
                return HttpNotFound();
            }
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName", criticalDocument.VendorId);
            return View(criticalDocument);
        }

        // POST: CriticalDocuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CriticalDocumentId,VendorId,Document,Score")] CriticalDocument criticalDocument)
        {
            if (ModelState.IsValid)
            {
                db.Entry(criticalDocument).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VendorId = new SelectList(db.Vendors, "VendorId", "VendorName", criticalDocument.VendorId);
            return View(criticalDocument);
        }

        // GET: CriticalDocuments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticalDocument criticalDocument = db.CriticalDocuments.Find(id);
            if (criticalDocument == null)
            {
                return HttpNotFound();
            }
            return View(criticalDocument);
        }

        // POST: CriticalDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CriticalDocument criticalDocument = db.CriticalDocuments.Find(id);
            db.CriticalDocuments.Remove(criticalDocument);
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
