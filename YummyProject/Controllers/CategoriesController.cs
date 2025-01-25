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
    public class CategoriesController : Controller
    {
        YummyContext context = new YummyContext();


        [HttpGet]
        public ActionResult Update(int id)
        {
            var value = context.Categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult Update(Category UpdateCategory)
        {
            if (!ModelState.IsValid)
            {
                return View(UpdateCategory);
            }
            var value = context.Categories.Find(UpdateCategory.CategoryId);

            value.CategoryName = UpdateCategory.CategoryName;

            context.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Index()
        {
            var value = context.Categories.ToList();
            return View(value);
        }


        [HttpGet]
        public ActionResult CategoriesAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CategoriesAdd(Category add)

        {


            if (!ModelState.IsValid)
            {
                return View(add);
            }

            context.Categories.Add(add);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var value = context.Categories.Find(id);

            var check = context.Products.Where(x => x.CategoryId == value.CategoryId).Any();

            if (check)
            {
                TempData["categoryDeleteError"] = "A project exists within this category. You cannot delete this category.";
                return RedirectToAction("Index");
            }

            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}