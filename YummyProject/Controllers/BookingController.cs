using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;
namespace YummyProject.Controllers
{
    public class BookingController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {

            var value = context.Bookings.ToList();


            return View(value);
        }

        public ActionResult DeleteBookings(int id)
        {
            var value = context.Bookings.Find(id);
            context.Bookings.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Confirm(int id)
        {
            var value = context.Bookings.Find(id);
            value.IsApproved = true;
            context.SaveChanges();
            return RedirectToAction("Index");


        }


        public ActionResult Decline(int id)
        {
            var value = context.Bookings.Find(id);
            value.IsApproved = false;
            context.SaveChanges();
            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult UpdateBookings(int id)
        {
            var value = context.Bookings.Find(id);

            TempData["Id"] = id;


            TempData["Date"] = value.BookingDate.ToString("yyyy-MM-dd");
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateBookings(Booking updateBooking)
        {

            var value = context.Bookings.Find(updateBooking.BookingId);
            TempData["Date"] = value.BookingDate.ToString("yyyy-MM-dd");


            if (!ModelState.IsValid)
            {
                return View(updateBooking);
            }


            value.Name = updateBooking.Name;
            value.Email = updateBooking.Email;
            value.PhoneNumber = updateBooking.PhoneNumber;
            value.BookingDate = updateBooking.BookingDate;
            value.PersonCount = updateBooking.PersonCount;
            value.MessageContent = updateBooking.MessageContent;
            context.SaveChanges();


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddBooking()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddBooking(Booking booking)
        {
            if (!ModelState.IsValid)
            {

                return View(booking);
            }
            context.Bookings.Add(booking);
            context.SaveChanges();

            return RedirectToAction("Index");
        }















    }
}