﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YummyProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult SideBar()
        {
            return PartialView();
        }
    }
}