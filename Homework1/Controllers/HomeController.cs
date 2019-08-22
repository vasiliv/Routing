using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers {
    public class HomeController : Controller {
        //Создайте веб приложение содержащее область для администратора с именем Admin.
        //Создайте несколько представлений и контроллеров. Для основной части приложения создайте
        //контроллер Home с методами действия Index, About, Contacts сделайте так, чтобы все 
        //представления, возвращаемые данными методами содержали ссылки на другие методы действий
        //контроллера Home.В области Admin создайте контроллер Home с методом Index и контроллер
        //Products с методами Index, Create, Delete.Организуйте доступ ко всем методам из 
        //пользовательского интерфейса. 
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}