using Microsoft.AspNet.Identity;
using NewEventPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewEventPlanner.Controllers
{
    public class BusinessController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        // GET: Main
        public ActionResult VenueIndex()
        {

            return View(db.Business.ToList());
        }
        // GET: Main/Details/5
        public ActionResult BusinessDetails(int? id)
        {
            Business business = null;
            if (id == null)
            {
                // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                var FoundUserId = User.Identity.GetUserId();

                business = db.Business.Where(c => c.ApplicationUserId == FoundUserId).FirstOrDefault();
                return View(business);

            }

            else
            {
                business = db.Business.Find(id);
            }

            if (business == null)
            {
                return HttpNotFound();
            }
            return View(business);
        }

        // GET: Main/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Main/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Main/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Main/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



    }
}
