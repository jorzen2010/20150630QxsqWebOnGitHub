using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QxsqWebAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNews()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NewsList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Mokuai()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Setting()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}