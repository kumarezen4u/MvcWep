using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class ExpController : Controller
    {
        private PracticeEntities db = new PracticeEntities();

        // GET: Exp
        public ActionResult Index()
        {
            return View(db.ExpCategory1.ToList());
        }

        // GET: Exp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpCategory1 expCategory1 = db.ExpCategory1.Find(id);
            if (expCategory1 == null)
            {
                return HttpNotFound();
            }
            return View(expCategory1);
        }

        // GET: Exp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exp/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExpenseCategoryId,CategoryName,Archive")] ExpCategory1 expCategory1)
        {
            if (ModelState.IsValid)
            {
                db.ExpCategory1.Add(expCategory1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expCategory1);
        }

        // GET: Exp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpCategory1 expCategory1 = db.ExpCategory1.Find(id);
            if (expCategory1 == null)
            {
                return HttpNotFound();
            }
            return View(expCategory1);
        }

        // POST: Exp/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExpenseCategoryId,CategoryName,Archive")] ExpCategory1 expCategory1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expCategory1).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expCategory1);
        }

        // GET: Exp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpCategory1 expCategory1 = db.ExpCategory1.Find(id);
            if (expCategory1 == null)
            {
                return HttpNotFound();
            }
            return View(expCategory1);
        }

        // POST: Exp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExpCategory1 expCategory1 = db.ExpCategory1.Find(id);
            db.ExpCategory1.Remove(expCategory1);
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
