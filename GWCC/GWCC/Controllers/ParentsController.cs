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
        public ActionResult NeedToKnow()
        {
            return View();
        }
    }
}