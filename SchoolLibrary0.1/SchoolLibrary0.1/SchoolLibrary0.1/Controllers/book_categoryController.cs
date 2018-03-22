using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolLibrary0._1.Models;

namespace SchoolLibrary0._1.Controllers
{
    public class book_categoryController : Controller
    {
        private SchoolLibraryEntities2 db = new SchoolLibraryEntities2();

        // GET: book_category
        public ActionResult Index()
        {
            var book_category = db.book_category.Include(b => b.book).Include(b => b.category);
            return View(book_category.ToList());
        }

        // GET: book_category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            book_category book_category = db.book_category.Find(id);
            if (book_category == null)
            {
                return HttpNotFound();
            }
            return View(book_category);
        }

        // GET: book_category/Create
        public ActionResult Create()
        {
            ViewBag.book_id = new SelectList(db.books, "book_id", "book_title");
            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name");
            return View();
        }

        // POST: book_category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "book_category_id,book_id,category_id")] book_category book_category)
        {
            if (ModelState.IsValid)
            {
                db.book_category.Add(book_category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.book_id = new SelectList(db.books, "book_id", "book_title", book_category.book_id);
            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name", book_category.category_id);
            return View(book_category);
        }

        // GET: book_category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            book_category book_category = db.book_category.Find(id);
            if (book_category == null)
            {
                return HttpNotFound();
            }
            ViewBag.book_id = new SelectList(db.books, "book_id", "book_title", book_category.book_id);
            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name", book_category.category_id);
            return View(book_category);
        }

        // POST: book_category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "book_category_id,book_id,category_id")] book_category book_category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book_category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.book_id = new SelectList(db.books, "book_id", "book_title", book_category.book_id);
            ViewBag.category_id = new SelectList(db.categories, "category_id", "category_name", book_category.category_id);
            return View(book_category);
        }

        // GET: book_category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            book_category book_category = db.book_category.Find(id);
            if (book_category == null)
            {
                return HttpNotFound();
            }
            return View(book_category);
        }

        // POST: book_category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            book_category book_category = db.book_category.Find(id);
            db.book_category.Remove(book_category);
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
