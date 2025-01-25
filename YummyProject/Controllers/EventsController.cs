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
    

    public class EventsController : Controller



    {

        private void ResimYukleme(Event model, Event value)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Events\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Events/" + model.ImageFile.FileName;
                value.ImageUrl = model.ImageUrl;
            }


        }


        private void ResimYukleme(Event model)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Events\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Events/" + model.ImageFile.FileName;

            }


        }





        YummyContext context = new YummyContext();

        public ActionResult Index()
        {   
            
            var value = context.Events.ToList();
            return View(value);
        }


        public ActionResult DeleteEvent(int id) 
        {
            var value = context.Events.Find(id);
            context.Events.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEvent(Event NewEvent) 
        {
            ResimYukleme(NewEvent);

            context.Events.Add(NewEvent);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateEvent(int id)
        {
            var value = context.Events.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEvent(Event UpdateEvent)
        {
            var value = context.Events.Find(UpdateEvent.EventId);

            value.Description = UpdateEvent.Description;
            value.Title = UpdateEvent.Title;
            value.Price = UpdateEvent.Price;
            ResimYukleme(UpdateEvent, value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}