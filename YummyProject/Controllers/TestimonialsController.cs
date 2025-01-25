using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class TestimonialsController : Controller
    {
        YummyContext context = new YummyContext();




        private void ResimYukleme(Testimonial model, Testimonial value)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Testimonials\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Testimonials/" + model.ImageFile.FileName;
                value.ImageUrl = model.ImageUrl;
            }


        }


        private void ResimYukleme(Testimonial model)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Testimonials\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Testimonials/" + model.ImageFile.FileName;

            }


        }
        public ActionResult Index()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTestimonials()
        {
            List<SelectListItem> Comment_Stars = (from i in context.Rating_Stars
                                                  select new SelectListItem
                                                  {
                                                      Text = i.Rating_Stars_Selectable,
                                                      Value = i.Rating_Stars_Counter.ToString()

                                                  }
                                                  ).ToList();
            ViewBag.Comment_Stars = Comment_Stars;
            return View();

        }

        [HttpPost]
        public ActionResult AddTestimonials(Testimonial new_testimonial)
        {
            ResimYukleme(new_testimonial);
            context.Testimonials.Add(new_testimonial);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult DeleteTestimonials(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateTestimonials(int id)
        {
            List<SelectListItem> Comment_Stars = (from i in context.Rating_Stars
                                                  select new SelectListItem
                                                  {
                                                      Text = i.Rating_Stars_Selectable,
                                                      Value = i.Rating_Stars_Counter.ToString()

                                                  }
                                                 ).ToList();
            ViewBag.Comment_Stars = Comment_Stars;


            var value = context.Testimonials.Find(id);
            return View(value);

        }

        [HttpPost]
        public ActionResult UpdateTestimonials(Testimonial update_testimonial)
        {

            var old_testimonial = context.Testimonials.Find(update_testimonial.TestimonialId);

            ResimYukleme(update_testimonial, old_testimonial);
            old_testimonial.Rating = update_testimonial.Rating;
            old_testimonial.Comment = update_testimonial.Comment;
            old_testimonial.Title = update_testimonial.Title;
            old_testimonial.NameSurname = update_testimonial.NameSurname;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}