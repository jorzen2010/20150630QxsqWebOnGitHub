using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using QxsqBLL;
using QxsqWebAdmin.Models;
using QxsqDTO;

namespace QxsqWebAdmin.Controllers
{
    public class ArticleController : BaseController
    {
      
        #region 文章列表页
       
        public ActionResult ArticleIndex(int? p)
        {


            string strwhere = "ArticleId>0";
            string table = "QxsqArticle";

            Pager pager = new Pager();
            pager.PageSize = 2;
            pager.PageNo = p ?? 1;

            pager = ArticleBll.GetArticlePager(pager, strwhere, table);
            ViewBag.PageNo = p ?? 1;
            ViewBag.PageCount = pager.PageCount;
            ViewBag.RecordCount = pager.Amount;


            return View(pager.Entity);
        }
        #endregion

        #region 文章添加
        public ActionResult ArticleAdd()
        {
            return View();

        }
        #endregion

        #region 文章编辑
        public ActionResult ArticleEdit(int ArticleId)
        {
            string table="QxsqArticle";
            string strwhere="ArticleId="+ArticleId;
            ArticleDto articleDto = ArticleBll.GetOneArticleDto(table, strwhere);

            ArticleEditViewModel model = new ArticleEditViewModel();

            model.ArticleTitle = articleDto.ArticleTitle;
            model.ArticleImg = articleDto.ArticleImg;
            model.ArticleContent = articleDto.ArticleContent;

            model.ArticleClass = articleDto.ArticleClass;
            model.ArticleTop = articleDto.ArticleTop;
            model.ArticleHot = articleDto.ArticleHot;

            model.ArticleImportant = articleDto.ArticleImportant;

            

            return View(model);

        }

        #endregion

        #region 文章新增动作
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ArticleInsert(ArticleAddViewModel model)
        {
            ArticleDto articleDto = new ArticleDto();

            articleDto.ArticleTitle= model.ArticleTitle;
            articleDto.ArticleImg=model.ArticleImg;
            articleDto.ArticleContent=model.ArticleContent;

            articleDto.ArticleClass=model.ArticleClass;
            articleDto.ArticleTop = model.ArticleTop;
            articleDto.ArticleHot = model.ArticleHot;

            articleDto.ArticleImportant = model.ArticleImportant;
            articleDto.ArticleDateTime = System.DateTime.Now;

            ArticleBll.AddArticle(articleDto);

            return RedirectTo("/Article/ArticleIndex", "文章添加成功了");
           // return RedirectToAction("ArticleIndex");


        }
        #endregion

        #region 文章更新动作
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ArticleUpdate(ArticleEditViewModel model)
        {
            string table = "QxsqArticle";
            string strwhere = "ArticleId=" + model.ArticleId;
            ArticleDto articleDto = ArticleBll.GetOneArticleDto(table,strwhere);

            articleDto.ArticleTitle = model.ArticleTitle;
            articleDto.ArticleImg = model.ArticleImg;
            articleDto.ArticleContent = model.ArticleContent;

            articleDto.ArticleClass = model.ArticleClass;
            articleDto.ArticleTop = model.ArticleTop;
            articleDto.ArticleHot = model.ArticleHot;

            articleDto.ArticleImportant = model.ArticleImportant;
            articleDto.ArticleDateTime = System.DateTime.Now;

            ArticleBll.UpdateArticleDto(articleDto);


            return RedirectToAction("ArticleIndex");


        }

        #endregion

        #region 文章删除动作
        public ActionResult ArticleDelete(int ArticleId)
        {
            string table = "QxsqArticle";
            string strwhere = "ArticleId=" + ArticleId;
            ArticleBll.DeleteArticleDto(table, strwhere);

            return RedirectToAction("ArticleIndex");

        }
        #endregion

    }
}