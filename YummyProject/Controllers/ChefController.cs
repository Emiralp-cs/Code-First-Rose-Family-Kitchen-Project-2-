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
    public class ChefController : Controller
    {
        YummyContext context = new YummyContext();


        private void ResimYukleme(Chef model, Chef value)
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


        }


        private void ResimYukleme(Chef model)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Abouts\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Abouts/" + model.ImageFile.FileName;

            }


        }



        public ActionResult Delete(int id)
        {
            var value = context.Chefs.Find(id);
            context.Chefs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            var value = context.Chefs.Find(id);
            return View(value);


        }

        [HttpPost]
        public ActionResult Update(Chef model)
        {
            var value = context.Chefs.Find(model.ChefId);

            ResimYukleme(model, value);
            value.ChefName = model.ChefName;
            value.Description = model.Description;
            value.Title = model.Title;
            context.SaveChanges();
            return RedirectToAction("Index");


        }


        public ActionResult Index()
        {
            var value = context.Chefs.ToList();

            return View(value);
        }

        [HttpGet]
        public ActionResult AddChef()
        {   
            var value = context.Chefs.Count();
            if (value == 3)
            {
                TempData["Error"] = "3 den fazla şef bulunamaz!";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddChef(Chef NewChef)
        {
            var addchefsocial = new ChefSocial();
            var add = NewChef.ChefId;
            addchefsocial.ChefId = NewChef.ChefId;

            ResimYukleme(NewChef);
            context.Chefs.Add(NewChef);
            context.ChefSocials.Add(addchefsocial);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        

        

    }
}