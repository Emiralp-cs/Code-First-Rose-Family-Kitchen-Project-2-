using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YummyProject.Context;

namespace YummyProject.Controllers
{

    public class DashboardController : Controller
    {

        YummyContext context = new YummyContext();
        public ActionResult Index()
        {   

            var values = context.Products.OrderBy(x => x.CategoryId).ToList();
            ViewBag.SoupCount = context.Categories.Count();
            ViewBag.MostExpensive = context.Products.OrderByDescending(x => x.Price).Select(x => x.ProductName).FirstOrDefault();
            ViewBag.AvgPrice = context.Products.Average(x => x.Price);
            ViewBag.CheapestPrice = context.Products.OrderBy(x => x.Price).Select(x => x.ProductName).FirstOrDefault();



            return View(values);
        }
    }
}