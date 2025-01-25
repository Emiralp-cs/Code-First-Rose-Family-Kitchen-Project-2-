using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
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
    public class AboutController : Controller
    {


        private void ResimYukleme(About model, About value)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Abouts\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Abouts/" + model.ImageFile.FileName;
                value.ImageUrl = model.ImageUrl;
            }

            if (model.ImageFile2 != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Abouts\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile2.FileName);
                model.ImageFile2.SaveAs(fileName);
                model.ImageUrl2 = "/Pictures/Abouts/" + model.ImageFile2.FileName;
                value.ImageUrl2 = model.ImageUrl2;

            }
        }


        private void ResimYukleme(About model)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Abouts\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Abouts/" + model.ImageFile.FileName;

            }

            if (model.ImageFile2 != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Abouts\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile2.FileName);
                model.ImageFile2.SaveAs(fileName);
                model.ImageUrl2 = "/Pictures/Abouts/" + model.ImageFile2.FileName;


            }
        }

        YummyContext context = new YummyContext();




        public ActionResult Index()
        {
            var value = context.Abouts.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AboutAdd()
        {
            var check_about_count = context.Abouts.Count();
            if (check_about_count == 1)
            {
                TempData["Error"] = "No more than one 'about me' page can be found!";
                return RedirectToAction("Index");
            }


            return View();
        }
        [HttpPost]
        public ActionResult AboutAdd(About add)

        {


            if (!ModelState.IsValid)
            {
                return View(add);
            }

            ResimYukleme(add);
            context.Abouts.Add(add);
            context.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult AboutDelete(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AboutUpdate(int id)
        {

            var value = context.Abouts.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult AboutUpdate(About model)
        {



            var value = context.Abouts.Find(model.AboutId);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ResimYukleme(model, value);
            value.Item1 = model.Item1;
            value.Item2 = model.Item2;
            value.Item3 = model.Item3;
            value.Description = model.Description;
            value.PhoneNumber = model.PhoneNumber;
            value.VideoUrl = model.VideoUrl;
            context.SaveChanges();


            return RedirectToAction("Index");








        }

    }
}