using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class ServicesController : Controller
    {
        private void ResimYukleme(Service model, Service value)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Services\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.Icon = "/Pictures/Services/" + model.ImageFile.FileName;
                value.Icon = model.Icon;
            }


        }


        private void ResimYukleme(Service model)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Services\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.Icon = "/Pictures/Services/" + model.ImageFile.FileName;

            }


        }


        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.Services.ToList();
            return View(values);
        }


        public ActionResult DeleteServices(int id)
        {
            var values = context.Services.Find(id);
            context.Services.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult AddServices()
        {
            var check = context.Services.Count();

            if (check == 3)
            {
                TempData["CountError"] = "Up to 3 services can be found!";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddServices(Service Newservice)
        {   

            if(!ModelState.IsValid)
            {
                return View(Newservice);
            }
            ResimYukleme(Newservice);

            context.Services.Add(Newservice);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = context.Services.Find(id);

            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateServices(Service NewService)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            var OldService = context.Services.Find(NewService.ServiceId);
            ResimYukleme(NewService, OldService);
            OldService.Title = NewService.Title;
            OldService.Description = NewService.Description;
            context.SaveChanges();


            return RedirectToAction("Index");
        }

    }
}