using Microsoft.AspNet.Identity;
using NewEventPlanner.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public ActionResult CreateBusiness()
        {
            ViewBag.Id = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult CreateBusiness([Bind(Include = " Id,VenueName,Address,City,State,ZipCode,Phone,Capacity,Price")] Business business)
        {
            if (ModelState.IsValid)
            {

                var userId = User.Identity.GetUserId();
                business.ApplicationUserId = userId;

                db.Business.Add(business);
                db.SaveChanges();
                return RedirectToAction("BusinessDetails", new { id = business.Id });
            }


            return View(business);
        }

        // GET: Main/Edit/5
        public ActionResult EditBusiness(int? Id)
        {

            Business business = db.Business.Find(Id);

            return View(business);
        }
        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult EditBusiness([Bind(Include = " Id,VenueName,Address,City,State,ZipCode,Phone,Capacity,Price")] Business business,int Id)
        {
            if (ModelState.IsValid)
            {

                Business updatedBusiness = db.Business.Find(Id);
                if (updatedBusiness == null)
                {
                    return RedirectToAction("DisplayError", "Business");
                }
                updatedBusiness.VenueName = business.VenueName;
                updatedBusiness.Address = business.Address;
                updatedBusiness.City = business.City;
                updatedBusiness.State = business.State;
                updatedBusiness.ZipCode = business.ZipCode;
                updatedBusiness.Phone = business.Phone;
                updatedBusiness.Capacity = business.Capacity;
                updatedBusiness.Price = business.Price;

                db.Entry(updatedBusiness).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("BusinessDetails");
            }
            return View(business);
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
        public ActionResult SelectBusiness()
        {

            return View();
        }
        public ActionResult CreateCateringBusiness()
        {
            ViewBag.Id = new SelectList(db.User, "Id", "Name");
            return View();
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult CreateCateringBusiness([Bind(Include = " Id,CaterersName,Quantity,Item1,Item2,Item3,Item4,Customize,Price,Discription")] Business business)
        {
            if (ModelState.IsValid)
            {

                var userId = User.Identity.GetUserId();
                business.ApplicationUserId = userId;

                db.Business.Add(business);
                db.SaveChanges();
                return RedirectToAction("CaterersDetails", new { id = business.Id });
            }


            return View(business);
        }
        public ActionResult EditCateringBusiness(int? Id)
        {

            Business business = db.Business.Find(Id);

            return View(business);
        }
        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult EditCateringBusiness([Bind(Include = " Id,CaterersName,Quantity,Item1,Item2,Item3,Item4,Customize,Price,Discription")] Business business, int Id)
        {
            if (ModelState.IsValid)
            {

                Business updatedBusiness = db.Business.Find(Id);
                if (updatedBusiness == null)
                {
                    return RedirectToAction("DisplayError", "Business");
                }
                updatedBusiness.CaterersName = business.CaterersName;
                updatedBusiness.Quantity = business.Quantity;
                updatedBusiness.Item1 = business.Item1;
                updatedBusiness.Item2 = business.Item2;
                updatedBusiness.Item3 = business.Item3;
                updatedBusiness.Item4 = business.Item4;
                updatedBusiness.Customize = business.Customize;
                updatedBusiness.Price = business.Price;

                db.Entry(updatedBusiness).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CaterersDetails");
            }
            return View(business);
        }
        public ActionResult CaterersIndex()
        {

            return View(db.Business.ToList());
        }

        public ActionResult CaterersDetails(int? id)
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

    }
}
