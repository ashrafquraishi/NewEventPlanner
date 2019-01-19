using NewEventPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace NewEventPlanner.Controllers
{

    public class SecurityAgencyController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult SecurityAgencyIndex()
        {

            return View(db.SecurityAgency.ToList());
        }
        // GET: SecurityAgency
        public ActionResult CreateSecurityAgency()
        {
            ViewBag.Id = new SelectList(db.User, "Id", "Name");
            return View();
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult CreateSecurityAgency([Bind(Include = " Id,SecurityAgencyName,NumberOfPeople,Charge")] SecurityAgency securityAgency)
        {
            if (ModelState.IsValid)
            {

                var userId = User.Identity.GetUserId();
                securityAgency.ApplicationUserId = userId;

                db.SecurityAgency.Add(securityAgency);
                db.SaveChanges();
                return RedirectToAction("DetailsOfSecurityAgency", new { id = securityAgency.Id });
            }


            return View(securityAgency);
        }
        public ActionResult EditBusiness(int? Id)
        {

            Business business = db.Business.Find(Id);

            return View(business);
        }
        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult EditBusiness([Bind(Include = " Id,SecurityAgencyName,NumberOfPeople,Charge")] SecurityAgency securityAgency, int Id)
        {
            if (ModelState.IsValid)
            {

                SecurityAgency updatedSecurity = db.SecurityAgency.Find(Id);
                if (updatedSecurity == null)
                {
                    return RedirectToAction("DisplayError", "SecurityAgency");
                }
                updatedSecurity.SecurityAgencyName = securityAgency.SecurityAgencyName;
                updatedSecurity.NumberOfPeople = securityAgency.NumberOfPeople;
                updatedSecurity.Charge = securityAgency.Charge;


                db.Entry(updatedSecurity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("SecurityAgencyDetails");
            }
            return View(securityAgency);
}

        public ActionResult SecurityAgencyDetails(int? id)
        {
            SecurityAgency securityAgency = null;
            if (id == null)
            {
                // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                var FoundUserId = User.Identity.GetUserId();

                securityAgency = db.SecurityAgency.Where(c => c.ApplicationUserId == FoundUserId).FirstOrDefault();
                return View(securityAgency);

            }

            else
            {
                securityAgency = db.SecurityAgency.Find(id);
            }

            if (securityAgency == null)
            {
                return HttpNotFound();
            }
            return View(securityAgency);
        }


        public ActionResult Test()
        {

            return View(db.SecurityAgency.ToList());
        }

        public ActionResult SecurityAgency()
        {

            return View(db.SecurityAgency.ToList());
        }


    }
}