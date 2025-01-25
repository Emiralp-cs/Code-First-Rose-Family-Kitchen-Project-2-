using Microsoft.Ajax.Utilities;
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

    public class ChefSocialMediasController : Controller
    {
        YummyContext context = new YummyContext();

        public ActionResult Index()
        {
            var value = context.Chefs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddChefSocials(int id)
        {
            List<SelectListItem> şefler = (from i in context.Chefs
                                           select new SelectListItem
                                           {
                                               Text = i.ChefName,
                                               Value = i.ChefId.ToString()
                                           }).ToList();

            ViewBag.şefler = şefler;
            var value = context.ChefSocials.Find(id);

            List<SelectListItem> Logolar = (from i in context.SocialMediasLogo
                                            select new SelectListItem
                                            {
                                                Text = i.SocialMediaLogoName,
                                                Value = i.SocialMediaLogos.ToString()
                                            }).ToList();

            ViewBag.Logolar = Logolar;
            return View(value);





        }




        public ActionResult DeleteChefSocial(int id)
        {
            var value = context.ChefSocials.Find(id);
            context.ChefSocials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateChefSocials(int id)
        {
            List<SelectListItem> şefler = (from i in context.Chefs
                                           select new SelectListItem
                                           {
                                               Text = i.ChefName,
                                               Value = i.ChefId.ToString()
                                           }).ToList();


            ViewBag.şefler = şefler;
            var value = context.ChefSocials.Find(id);


            List<SelectListItem> Logolar = (from i in context.SocialMediasLogo
                                            select new SelectListItem
                                            {
                                                Text = i.SocialMediaLogoName,
                                                Value = i.SocialMediaLogos.ToString()
                                            }).ToList();

            ViewBag.Logolar = Logolar;
            return View(value);


        }
        [HttpPost]
        public ActionResult UpdateChefSocials(ChefSocial social)
        {

            var check = context.ChefSocials.Count(x => x.Icon == social.Icon && x.ChefId == social.ChefId);


            if (check == 1)
            {
                TempData["Error"] = "You can only have one account per social media platform!";
                return RedirectToAction("Index");
            }




            var old = context.ChefSocials.Find(social.ChefSocialId);
            old.Url = social.Url;
            old.Icon = social.Icon;
            context.SaveChanges();
            return RedirectToAction("Index");


        }

        public int chefid;

        [HttpGet]
        public ActionResult Deneme(int id)
        {
            TempData["id"] = id;
            ViewData["id"] = 3;
            chefid = id;
            var value = context.ChefSocials.Where(x => x.ChefId == id && !string.IsNullOrEmpty(x.Icon)).OrderByDescending(x => x.Icon.Substring(5, 6)).ToList();

            return View(value);
        }



        [HttpPost]
        public ActionResult AddChefSocials(ChefSocial newChefSocial)
        {
            newChefSocial.ChefId = (int)TempData["deneme"];
            var check = context.ChefSocials.Where(x => x.Icon == newChefSocial.Icon && x.ChefId == newChefSocial.ChefId).Any();
            if (check == true)
            {
                TempData["Error"] = "You can only have one account per social media platform!";
                return RedirectToAction("Index");
            }
            else
            {
                var value = context.Chefs.Where(x => x.ChefId == newChefSocial.ChefId).FirstOrDefault();
                newChefSocial.ChefId = (int)TempData["deneme"];
                context.ChefSocials.Add(newChefSocial);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


        }
    }
}