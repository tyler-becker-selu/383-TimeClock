using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Clock.Models;
using Clock.DAL;

namespace Clock.Controllers
{
    public class TimeEntryController : Controller
    {
        private ClockContext db = new ClockContext();

        // GET: /TimeEntry/
        public ActionResult Index()
        {
            var timeentries = db.TimeEntries.Include(t => t.User);
            return View(timeentries.ToList());
        }

        // GET: /TimeEntry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeEntry timeentry = db.TimeEntries.Find(id);
            if (timeentry == null)
            {
                return HttpNotFound();
            }
            return View(timeentry);
        }

        // GET: /TimeEntry/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "Username");
            return View();
        }

        // POST: /TimeEntry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,TimeIn,TimeOut,UserId")] TimeEntry timeentry)
        {
            if (ModelState.IsValid)
            {
                db.TimeEntries.Add(timeentry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "Username", timeentry.UserId);
            return View(timeentry);
        }

        // GET: /TimeEntry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeEntry timeentry = db.TimeEntries.Find(id);
            if (timeentry == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Username", timeentry.UserId);
            return View(timeentry);
        }

        // POST: /TimeEntry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,TimeIn,TimeOut,UserId")] TimeEntry timeentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Username", timeentry.UserId);
            return View(timeentry);
        }

        // GET: /TimeEntry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeEntry timeentry = db.TimeEntries.Find(id);
            if (timeentry == null)
            {
                return HttpNotFound();
            }
            return View(timeentry);
        }

        // POST: /TimeEntry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeEntry timeentry = db.TimeEntries.Find(id);
            db.TimeEntries.Remove(timeentry);
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
