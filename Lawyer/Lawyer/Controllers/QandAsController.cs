using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BE;
using Lawyer.Data;

namespace Lawyer.Controllers
{
    public class QandAsController : Controller
    {
        private QandAContext db = new QandAContext();

        // GET: QandAs
        public ActionResult Index()
        {
            return View(db.QandAs.ToList());
        }

        // GET: QandAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QandA qandA = db.QandAs.Find(id);
            if (qandA == null)
            {
                return HttpNotFound();
            }
            return View(qandA);
        }

        // GET: QandAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QandAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Data")] QandA qandA)
        {
            if (ModelState.IsValid)
            {
                db.QandAs.Add(qandA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qandA);
        }

        // GET: QandAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QandA qandA = db.QandAs.Find(id);
            if (qandA == null)
            {
                return HttpNotFound();
            }
            return View(qandA);
        }

        // POST: QandAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Data")] QandA qandA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qandA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qandA);
        }

        // GET: QandAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QandA qandA = db.QandAs.Find(id);
            if (qandA == null)
            {
                return HttpNotFound();
            }
            return View(qandA);
        }

        // POST: QandAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QandA qandA = db.QandAs.Find(id);
            db.QandAs.Remove(qandA);
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
