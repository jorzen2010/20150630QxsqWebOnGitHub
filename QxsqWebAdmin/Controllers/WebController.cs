using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QxsqDTO;
using QxsqBLL;
using Common;

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

        public ActionResult Mokuai(int id)
        {
            string table = "QxsqMokuai";

            string strwhere = "MokuaiId=" + id.ToString();


            MokuaiDto articleDto = MokuaiBll.GetOneMokuaiDto(table, strwhere);


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

        
        #region 新闻公告页

        public ActionResult Xinwengonggao(int? p)
        {


            string strwhere = "ArticleId>0";
            string table = "QxsqArticle";

            Pager pager = new Pager();
            pager.PageSize = 9;
            pager.PageNo = p ?? 1;

            pager = ArticleBll.GetArticlePager(pager, strwhere, table);
            ViewBag.PageNo = p ?? 1;
            ViewBag.PageCount = pager.PageCount;
            ViewBag.RecordCount = pager.Amount;


            return View(pager.Entity);
        }
        #endregion
        public ActionResult Guanyuwomen()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult MokuaiView(int id)
        {
            string table = "QxsqMokuai";

            string strwhere = "MokuaiId=" + id.ToString();


            MokuaiDto mokuaiDto = MokuaiBll.GetOneMokuaiDto(table, strwhere);


            ViewData.Model = mokuaiDto;

            return View("MokuaiPartial");
        }
        [ChildActionOnly]
        public ActionResult LeftMenuView(string urlTitle)
        {


            return View("LeftMenuPartial");
        }
	}
}