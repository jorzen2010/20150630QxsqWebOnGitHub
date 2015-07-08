using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QxsqDTO;
using QxsqBLL;

namespace QxsqWebAdmin.Controllers
{
    public class WebController : Controller
    {
        //
        // GET: /Web/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gonggongweisheng()
        {
            return View();
        }

        public ActionResult Article(int id)
        {
            string table = "QxsqArticle";

            string strwhere = "ArticleId=" + id.ToString();


            ArticleDto articleDto = ArticleBll.GetOneArticleDto(table, strwhere);


            ViewData.Model = articleDto;

            return View();
        }

        public ActionResult MokuaiContent()
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

        [ChildActionOnly]
        public ActionResult MokuaiView()
        {
            return View("MokuaiPartial");
        }
	}
}