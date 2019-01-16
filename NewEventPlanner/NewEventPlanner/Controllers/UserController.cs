﻿using Microsoft.AspNet.Identity;
using NewEventPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewEventPlanner.Controllers
{
    public class UserController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        // GET: User
        public ActionResult VenueIndex()
        {
            return View(db.Business.ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult CreateUser()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = " Id,FirstName,LastName,Email,Address,City,State,ZipCode")] User user)
        {
            if (ModelState.IsValid)
            {

                var userId = User.Identity.GetUserId();
                user.ApplicationUserId = userId;

                db.User.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index","Home", new { id = user.Id });
            }


            return View(user);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
            public ActionResult SearchZipcode()
            {
                return View(db.Business.ToList());
            }

        [HttpPost]
        public ActionResult SearchZipcode(string SearchResult)

        {
            var ZipCodeSearch = from m in db.Business
                                select m;
            if (!string.IsNullOrEmpty(SearchResult))
            {
                ZipCodeSearch = ZipCodeSearch.Where(s => s.ZipCode.ToString().Contains(SearchResult));
            }

            return View(ZipCodeSearch);
        }
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
        public ActionResult Stripe ( )
        {
            return View();
        }

















    }

}