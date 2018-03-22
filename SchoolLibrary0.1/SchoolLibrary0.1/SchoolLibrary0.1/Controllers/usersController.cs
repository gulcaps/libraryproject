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
    public class usersController : Controller
    {
        private SchoolLibraryEntities2 db = new SchoolLibraryEntities2();

        // GET: users
        public ActionResult Index()
        {
            var users = db.users.Include(u => u.account).Include(u => u.file).Include(u => u.verification);
            return View(users.ToList());
        }

        // GET: users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: users/Create
        public ActionResult Create()
        {
            ViewBag.account_id = new SelectList(db.accounts, "account_id", "account_id");
            ViewBag.file_id = new SelectList(db.files, "file_id", "file_link");
            ViewBag.verification_id = new SelectList(db.verifications, "verification_id", "verification_code");
            return View();
        }

        // POST: users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "user_id,user_username,user_firstname,user_surname,user_email,file_id,account_id,verification_id")] user user)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.account_id = new SelectList(db.accounts, "account_id", "account_id", user.account_id);
            ViewBag.file_id = new SelectList(db.files, "file_id", "file_link", user.file_id);
            ViewBag.verification_id = new SelectList(db.verifications, "verification_id", "verification_code", user.verification_id);
            return View(user);
        }

        // GET: users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.account_id = new SelectList(db.accounts, "account_id", "account_id", user.account_id);
            ViewBag.file_id = new SelectList(db.files, "file_id", "file_link", user.file_id);
            ViewBag.verification_id = new SelectList(db.verifications, "verification_id", "verification_code", user.verification_id);
            return View(user);
        }

        // POST: users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "user_id,user_username,user_firstname,user_surname,user_email,file_id,account_id,verification_id")] user user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.account_id = new SelectList(db.accounts, "account_id", "account_id", user.account_id);
            ViewBag.file_id = new SelectList(db.files, "file_id", "file_link", user.file_id);
            ViewBag.verification_id = new SelectList(db.verifications, "verification_id", "verification_code", user.verification_id);
            return View(user);
        }

        // GET: users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            user user = db.users.Find(id);
            db.users.Remove(user);
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
