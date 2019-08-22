using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_CustomVariables.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Variable = RouteData.Values["id"];
            return View();
        }
        public ActionResult CustomVariable(int ?id) {
            ViewBag.Variable = id;
            return View("Index");
        }
    }
}