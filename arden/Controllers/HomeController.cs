using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arden.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Hizmetlerimiz()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Yonetmelikler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}