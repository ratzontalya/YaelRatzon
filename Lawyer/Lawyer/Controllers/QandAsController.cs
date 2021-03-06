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
    public class QandAsController : Controller
    {

        // GET: QandAs
        public ActionResult Index()
        {
            IBL bl = new BL.BL();
            return View(bl.GetQandAs());
        }

        // GET: QandAs/Details/5
        public ActionResult Details(int? id)
        {
            IBL bl = new BL.BL();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QandA qandA = bl.GetQandAById(id);
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
                IBL bl = new BL.BL();
                bl.AddQandA(qandA);
                return RedirectToAction("Index");
            }

            return View(qandA);
        }

        // GET: QandAs/Edit/5
        public ActionResult Edit(int? id)
        {
            IBL bl = new BL.BL();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QandA qandA = bl.GetQandAById(id);
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
            IBL bl = new BL.BL();
            if (ModelState.IsValid)
            {
                bl.UpdateQandA(qandA);
                return RedirectToAction("Index");
            }
            return View(qandA);
        }

        // GET: QandAs/Delete/5
        public ActionResult Delete(int? id)
        {
            IBL bl = new BL.BL();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QandA qandA = bl.GetQandAById(id);
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
            IBL bl = new BL.BL();
            bl.DeleteQandA(id);
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
