using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkAdditional.Controllers
{
    public class CalcController : Controller
    {
        //Создайте приложение, которое будет обслуживать следующие запросы выполняя арифметические операции –  
        //Calc/Add/10/20 в ответ возвращается страница с текстом 30 
        //Calc/Mul/5/5 в ответ возвращается страница с текстом 25 
        //Calc/Sub/10/3 в ответ возвращается страница с текстом 7 
        //Calc/Div/10/2 в ответ возвращается страница с текстом 5 
        public ActionResult Index() {            
            return View();
        }
        public ActionResult Add(int ?x, int ?y)
        {
            ViewBag.Result = x + y;
            return View();
        }
        public ActionResult Mul(int? x, int? y) {
            ViewBag.Result = x * y;
            return View();
        }
        public ActionResult Sub(int? x, int? y) {
            ViewBag.Result = x - y;
            return View();
        }
        public ActionResult Div(int? x, int? y) {
            ViewBag.Result = x / y;
            return View();
        }
    }
}