﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BE;
using BL;

namespace Lawyer.Controllers
{
    public class VerdictsController : Controller
    {
        private IBL bl = new BL.BL();

        // GET: Verdicts
        public ActionResult Index()
        {
            return View(bl.GetVerdicts());
        }

        // GET: Verdicts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verdict verdict = bl.GetVerdictById(id);
            if (verdict == null)
            {
                return HttpNotFound();
            }
            return View(verdict);
        }

        // GET: Verdicts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Verdicts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Data")] Verdict verdict)
        {
            if (ModelState.IsValid)
            {
                bl.AddVerdict(verdict);
                return RedirectToAction("Index");
            }

            return View(verdict);
        }

        // GET: Verdicts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verdict verdict = bl.GetVerdictById(id);
            if (verdict == null)
            {
                return HttpNotFound();
            }
            return View(verdict);
        }

        // POST: Verdicts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Data")] Verdict verdict)
        {
            if (ModelState.IsValid)
            {
                bl.UpdateVerdict(verdict);
                return RedirectToAction("Index");
            }
            return View(verdict);
        }

        // GET: Verdicts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Verdict verdict = bl.GetVerdictById(id);
            if (verdict == null)
            {
                return HttpNotFound();
            }
            return View(verdict);
        }

        // POST: Verdicts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bl.DeleteVerdict(id);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
