using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DefaultFeature()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultProduct()
        {
            var values = context.Categories.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultChefs()
        {
            var values = context.Chefs.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultEvents()
        {
            var values = context.Events.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultTestimonials()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult DefaultBookings()
        {

            return PartialView();
        }


        [HttpPost]
        public ActionResult DefaultBookings(Booking new_Booking)
        {

            var check = context.Bookings.Where(x => x.BookingDate == new_Booking.BookingDate).Any();

            if (check)
            {
                TempData["Date_Error"] = "Bu Tarih Rezerve Edilmiştir Lütfen Başka Bir Tarih Seçiniz!";
                return RedirectToAction("Index");
            }

            new_Booking.IsApproved = null;
            context.Bookings.Add(new_Booking);
            context.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public PartialViewResult DefaultMessages()
        {
            return PartialView();
        }


        [HttpPost]
        public ActionResult DefaultMessages(Message newMessage)
        {

            newMessage.Isread = false;
            context.Messages.Add(newMessage);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


        public PartialViewResult DefaultPhotoGallery()
        {
            var values = context.PhotoGalleries.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultContactInfo()
        {
            var values = context.ContactInfo.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultServices()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultStats()
        {
            var values = context.Products.OrderBy(x => x.CategoryId).ToList();
            ViewBag.SoupCount = context.Categories.Count();
            ViewBag.MostExpensive = context.Products.OrderByDescending(x => x.Price).Select(x => x.ProductName).FirstOrDefault();
            ViewBag.AvgPrice = context.Products.Average(x => x.Price);
            ViewBag.CheapestPrice = context.Products.OrderBy(x => x.Price).Select(x => x.ProductName).FirstOrDefault();
            return PartialView();
        }


    }
}