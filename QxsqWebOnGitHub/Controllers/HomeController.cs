using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QxsqWebOnGitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gonggongweisheng()
        {
            return View();
        }

        public ActionResult Yiliaofuwu()
        {
            return View();
        }

        public ActionResult Zibizheng()
        {
            return View();
        }

        public ActionResult Lianxiwomen()
        {
            return View();
        }

        public ActionResult Xinwengonggao()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Guanyuwomen()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
    }
}