using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class ContactInfoController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.ContactInfo.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult EditContact(int id)
        {
            var value = context.ContactInfo.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult EditContact(ConInfo EditContact)
        {
            if (!ModelState.IsValid)
            {
                return View(EditContact);

            }

            var oldContact = context.ContactInfo.Find(EditContact.Id);

            oldContact.Address = EditContact.Address;
            oldContact.Email = EditContact.Email;
            oldContact.PhoneNumber = EditContact.PhoneNumber;
            oldContact.OpeningHours = EditContact.OpeningHours;
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}