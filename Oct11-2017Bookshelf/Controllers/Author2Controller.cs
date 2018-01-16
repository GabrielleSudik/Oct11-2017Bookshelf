using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Oct11_2017Bookshelf.Models;

namespace Oct11_2017Bookshelf.Controllers
{
    public class Author2Controller : Controller
    {
        private Oct11_2017BookshelfContext db = new Oct11_2017BookshelfContext();

        // GET: Author2
        public ActionResult Index()
        {
            return View(db.Author2.ToList());
        }

        // GET: Author2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Author2 author2 = db.Author2.Find(id);
            if (author2 == null)
            {
                return HttpNotFound();
            }
            return View(author2);
        }

        // GET: Author2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Language")] Author2 author2)
        {
            if (ModelState.IsValid)
            {
                db.Author2.Add(author2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(author2);
        }

        // GET: Author2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Author2 author2 = db.Author2.Find(id);
            if (author2 == null)
            {
                return HttpNotFound();
            }
            return View(author2);
        }

        // POST: Author2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Language")] Author2 author2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(author2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(author2);
        }

        // GET: Author2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Author2 author2 = db.Author2.Find(id);
            if (author2 == null)
            {
                return HttpNotFound();
            }
            return View(author2);
        }

        // POST: Author2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Author2 author2 = db.Author2.Find(id);
            db.Author2.Remove(author2);
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
