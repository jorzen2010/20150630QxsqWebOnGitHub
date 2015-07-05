using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using QxsqBLL;

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
        public ActionResult Setting(int? p)
        {
            string strwhere = "EditorId>0";
            string table = "QxsqEditor";

            Pager pager = new Pager();
            pager.PageSize = 2;
            pager.PageNo = p ?? 1;

            pager = EditorBll.GetEditorPager(pager, strwhere, table);
            ViewBag.PageNo = p ?? 1;
            ViewBag.PageCount = pager.PageCount;
            ViewBag.RecordCount = pager.Amount;


            return View(pager.Entity);
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}