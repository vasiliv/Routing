using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_SegmentVariables.Controllers {
    public class HomeController : Controller {
        public ActionResult Index(int ?x, int ?y) {
            if (x!=null && y != null) {
                ViewBag.Variable = x + y;
            }
            return View();
        }
    }
}