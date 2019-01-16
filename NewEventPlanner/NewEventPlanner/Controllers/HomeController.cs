using NewEventPlanner.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NewEventPlanner.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Stripe()
        {
            var stripePublishKey = ConfigurationManager.AppSettings["stripePublishableKey"];
            ViewBag.StripePublishKey = stripePublishKey;
            return View();
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "";
                body += "<p>From: {0} ({1})</p>";
                body += "<p>Message:</p>";
                body += "<hr>";
                body += "<p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("isetrade@gmail.com")); //destination e-mail address
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    try
                    {
                        await smtp.SendMailAsync(message);
                    }
                    catch (Exception e)
                    {
                        Response.Write("<p>" + e.Message + "</p>");
                    }
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult Sent()
        {
            return View();
        }

        public class EmailFormModel
        {
            public object FromName { get; internal set; }
            public object FromEmail { get; internal set; }
            public object Message { get; internal set; }
        }
    }

  
}