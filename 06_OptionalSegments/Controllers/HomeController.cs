using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_OptionalSegments.Controllers {
    public class HomeController : Controller {
        public ActionResult Index(int ?id) {
            ViewBag.Variable = id;
            return View();
        }
    }
}