using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_CatchAllSegments.Controllers {
    public class HomeController : Controller {
        public ActionResult Index(string id, string catchall) {
            ViewBag.Id = id;
            ViewBag.CatchAll = catchall;
            return View();
        }
    }
}