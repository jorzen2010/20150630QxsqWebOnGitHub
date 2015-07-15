using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QxsqDTO;
using QxsqBLL;
using Common;
using QxsqWebAdmin.Models;

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

        public ActionResult Yuyueguahao()
        {
            GuahaoAddViewModel model = new GuahaoAddViewModel();
            model.GuahaoDoctor = "全科医生";
            model.GuahaoGroup = "曲线社区医院";
            model.GuahaoStatus = "等待付款";

            return View(model);
        }

        #region 模块新增动作
        [HttpPost]

        public ActionResult GuahaoInsert(GuahaoAddViewModel model)
        {
            GuahaoDto guahaoDto = new GuahaoDto();

            guahaoDto.GuahaoName = model.GuahaoName;
            guahaoDto.GuahaoTel = model.GuahaoTel;
            guahaoDto.GuahaoInfo = model.GuahaoInfo;
            guahaoDto.GuahaoDateTime = System.DateTime.Now;
            guahaoDto.GuahaoTime = System.DateTime.Now;
            guahaoDto.GuahaoStatus = model.GuahaoStatus;
            guahaoDto.GuahaoDoctor = model.GuahaoDoctor;
            guahaoDto.GuahaoGroup = model.GuahaoGroup;


            GuahaoBll.AddGuahao(guahaoDto);


            return  RedirectToAction("Index");


        }
        #endregion
        
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