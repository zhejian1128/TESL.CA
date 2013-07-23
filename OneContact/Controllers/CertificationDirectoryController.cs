using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneContact.Models;

namespace OneContact.Controllers
{
    public class CertificationDirectoryController : Controller
    {
        private TESLEntities db = new TESLEntities();

        //
        // GET: /CertificationDirectory/

        public ActionResult Index()
        {
            return View(db.teslGeneralInformationForms.ToList());
        }

        //
        // GET: /CertificationDirectory/Details/5

        public ActionResult Details(int id = 0)
        {
            teslGeneralInformationForm teslgeneralinformationform = db.teslGeneralInformationForms.Find(id);
            if (teslgeneralinformationform == null)
            {
                return HttpNotFound();
            }
            return View(teslgeneralinformationform);
        }

        //
        // GET: /CertificationDirectory/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CertificationDirectory/Create

        [HttpPost]
        public ActionResult Create(teslGeneralInformationForm teslgeneralinformationform)
        {
            if (ModelState.IsValid)
            {
                db.teslGeneralInformationForms.Add(teslgeneralinformationform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teslgeneralinformationform);
        }

        //
        // GET: /CertificationDirectory/Edit/5

        public ActionResult Edit(int id = 0)
        {
            teslGeneralInformationForm teslgeneralinformationform = db.teslGeneralInformationForms.Find(id);
            if (teslgeneralinformationform == null)
            {
                return HttpNotFound();
            }
            return View(teslgeneralinformationform);
        }

        //
        // POST: /CertificationDirectory/Edit/5

        [HttpPost]
        public ActionResult Edit(teslGeneralInformationForm teslgeneralinformationform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teslgeneralinformationform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teslgeneralinformationform);
        }

        //
        // GET: /CertificationDirectory/Delete/5

        public ActionResult Delete(int id = 0)
        {
            teslGeneralInformationForm teslgeneralinformationform = db.teslGeneralInformationForms.Find(id);
            if (teslgeneralinformationform == null)
            {
                return HttpNotFound();
            }
            return View(teslgeneralinformationform);
        }

        //
        // POST: /CertificationDirectory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            teslGeneralInformationForm teslgeneralinformationform = db.teslGeneralInformationForms.Find(id);
            db.teslGeneralInformationForms.Remove(teslgeneralinformationform);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}