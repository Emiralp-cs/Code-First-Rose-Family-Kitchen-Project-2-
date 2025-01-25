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

    public class FeatureController : Controller
    {

        private void ResimYukleme(Feature model, Feature value)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Feature\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Feature/" + model.ImageFile.FileName;
                value.ImageUrl = model.ImageUrl;
            }


        }


        private void ResimYukleme(Feature model)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Feature\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Feature/" + model.ImageFile.FileName;

            }


        }
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddFeature()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddFeature(Feature feature)
        {

            ResimYukleme(feature);
            context.Features.Add(feature);

            var result = context.SaveChanges();
            if (result == 0)
            {

                ViewBag.error = "Değerler kaydedilirken bir hata ile karşılaşıldı.";
                return View(feature);
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);

        }

        public ActionResult UpdateFeature(Feature model)
        {
            var value = context.Features.Find(model.FeatureId);
            if (!string.IsNullOrEmpty(model.ImageUrl))
            {
                ResimYukleme(value, value);
                value.Title = model.Title;
                value.Description = model.Description;
                value.VideoUrl = model.VideoUrl;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ResimYukleme(model, value);
                value.Title = model.Title;
                value.Description = model.Description;
                value.VideoUrl = model.VideoUrl;
                context.SaveChanges();

                return RedirectToAction("Index");
            }

        }
    }
}