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

    public class AdminController : Controller
    {
        YummyContext context = new YummyContext();
        private void ResimYukleme(Admin model, Admin value)
        {
            if (model.ImageFile != null)
            {
                var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var saveLocation = currentDirectory + "Pictures\\Admin\\";
                var fileName = Path.Combine(saveLocation + model.ImageFile.FileName);
                model.ImageFile.SaveAs(fileName);
                model.ImageUrl = "/Pictures/Admin/" + model.ImageFile.FileName;
                value.ImageUrl = model.ImageUrl;
            }


        }
        [HttpGet]
        public ActionResult Index()
        {
            var value = context.Admins.FirstOrDefault();

            return View(value);
        }


        [HttpPost]
        public ActionResult Index(Admin UpdateAdmin)
        {
            var value = context.Admins.Find(UpdateAdmin.AdminId);
            if (value.Password != UpdateAdmin.Password)
            {
                ResimYukleme(value, value);
                value.Username = UpdateAdmin.Username;
                value.NameSurname = UpdateAdmin.NameSurname;
                context.SaveChanges();
                TempData["MessageColor"] = "text-danger";
                TempData["ResultMessage"] = "Wrong Password";
                return RedirectToAction("Index");

            }

            else
            {
                if (!string.IsNullOrEmpty(UpdateAdmin.ImageUrl))
                {
                   
                    TempData["MessageColor"] = "text-success";

                    TempData["ResultMessage"] = "Your information has been updated";
                    return RedirectToAction("Index");
                }
                else
                {
                    ResimYukleme(UpdateAdmin, value);
                    value.Username = UpdateAdmin.Username;
                    value.NameSurname = UpdateAdmin.NameSurname;
                    value.Password = UpdateAdmin.Password;
                    context.SaveChanges();
                    TempData["MessageColor"] = "text-success";

                    TempData["ResultMessage"] = "Your information has been updated";
                    return RedirectToAction("Index");
                }
            }





        }
    }
}