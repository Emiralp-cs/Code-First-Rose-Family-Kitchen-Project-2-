using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using YummyProject.Context;
using YummyProject.Models;

namespace YummyProject.Controllers
{
    public class MessagesController : Controller
    {
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddMessage()
        {

            return View();

        }

        [HttpPost]
        public ActionResult AddMessage(Models.Message newMessage)
        {

            if (!ModelState.IsValid)
            {
                return View(newMessage);
            }

            newMessage.Isread = false;
            context.Messages.Add(newMessage);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Isread(int id)
        {
            var value = context.Messages.Find(id);


            if (value.Isread == false)
            {
                value.Isread = true;
                context.SaveChanges();
            }

            else
            {
                value.Isread = false;
                context.SaveChanges();
            }


            return RedirectToAction("Index");


        }

        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var value = context.Messages.Find(id);

            return View(value);

        }


        [HttpPost]
        public ActionResult UpdateMessage(Models.Message updateMessage)
        {   
            if(!ModelState.IsValid)
            {
                return View(updateMessage);
            }


            var oldMessage = context.Messages.Find(updateMessage.MessageId);

            oldMessage.Name = updateMessage.Name;
            oldMessage.Email = updateMessage.Email;
            oldMessage.Subject = updateMessage.Subject;
            oldMessage.MessageContent = updateMessage.MessageContent;
            context.SaveChanges();


            return RedirectToAction("Index");
        }










    }
}