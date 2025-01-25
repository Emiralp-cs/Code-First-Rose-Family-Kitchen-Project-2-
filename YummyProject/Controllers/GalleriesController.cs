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
    public class GalleriesController : Controller
    {
        private void ResimYukleme(PhotoGallery model, PhotoGallery value)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\PhotoGallery\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/PhotoGallery/" + model.ImageFile.FileName;
                value.ImageUrl = model.ImageUrl;
            }


        }


        private void ResimYukleme(PhotoGallery model)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\PhotoGallery\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/PhotoGallery/" + model.ImageFile.FileName;

            }


        }
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.PhotoGalleries.ToList();
            return View(values);
        }

        public ActionResult DeletePhoto(int id)
        {
            var delete = context.PhotoGalleries.Find(id);
            context.PhotoGalleries.Remove(delete);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddPhoto()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddPhoto(PhotoGallery newPhoto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ResimYukleme(newPhoto);
            context.PhotoGalleries.Add(newPhoto);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}