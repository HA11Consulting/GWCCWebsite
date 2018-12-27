using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GWCC.Controllers
{
    public class ParentsController : Controller
    {
        // GET: Parents
        public ActionResult ParentsInfo()
        {
            return View();
        }

        public ActionResult UsefulLinks()
        {
            ViewBag.Message = "UsefulLinks";

            return View();
        }
        public ActionResult FAQ()
        {
            ViewBag.Message = "FAQ";

            return View();
        }
        public ActionResult Testimonials()
        {
            ViewBag.Message = "Testimonials";

            return View();
        }       
    }
}