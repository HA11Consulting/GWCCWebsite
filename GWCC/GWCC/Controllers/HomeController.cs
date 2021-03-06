﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GWCC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About US";

            return View();
        }

        public ActionResult History()
        {
            ViewBag.Message = "History";

            return View();
        }

        public ActionResult Governance()
        {
            ViewBag.Message = "Governance";

            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Our Team";

            return View();
        }

    }
}