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
    public class legislationsController : Controller
    {
        private IBL bl = new BL.BL();

        // GET: legislations
        public ActionResult Index()
        {
            return View(bl.GetLegislations());
        }

        // GET: legislations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            legislation legislation = bl.GetLegislationById(id);
            if (legislation == null)
            {
                return HttpNotFound();
            }
            return View(legislation);
        }

        // GET: legislations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: legislations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Data")] legislation legislation)
        {
            if (ModelState.IsValid)
            {
                bl.AddLegislation(legislation);
                return RedirectToAction("Index");
            }

            return View(legislation);
        }

        // GET: legislations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            legislation legislation = bl.GetLegislationById(id);
            if (legislation == null)
            {
                return HttpNotFound();
            }
            return View(legislation);
        }

        // POST: legislations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Data")] legislation legislation)
        {
            if (ModelState.IsValid)
            {
                bl.UpdateLegislation(legislation);
                return RedirectToAction("Index");
            }
            return View(legislation);
        }

        // GET: legislations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            legislation legislation = bl.GetLegislationById(id);
            if (legislation == null)
            {
                return HttpNotFound();
            }
            return View(legislation);
        }

        // POST: legislations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bl.DeleteLegislation(id);
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
