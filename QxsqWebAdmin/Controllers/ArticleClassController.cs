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
    public class ArticleClassController : BaseController
    {
      
        #region 文章类别列表页
       
        public ActionResult ArticleClassIndex(int? p)
        {


            string strwhere = "ArticleClassId>0";
            string table = "QxsqArticleClass";

            Pager pager = new Pager();
            pager.PageSize = 2;
            pager.PageNo = p ?? 1;

            pager = ArticleClassBll.GetArticleClassPager(pager, strwhere, table);
            ViewBag.PageNo = p ?? 1;
            ViewBag.PageCount = pager.PageCount;
            ViewBag.RecordCount = pager.Amount;


            return View(pager.Entity);
        }
        #endregion

        #region 文章类别添加
        public ActionResult ArticleClassAdd()
        {
            return View();

        }
        #endregion

        #region 文章类别编辑
        public ActionResult ArticleClassEdit(int ArticleClassId)
        {
            string table="QxsqArticleClass";
            string strwhere="ArticleClassId="+ArticleClassId;
            ArticleClassDto editorDto = ArticleClassBll.GetOneArticleClassDto(table, strwhere);

            ArticleClassEditViewModel model = new ArticleClassEditViewModel();

            model.ArticleClassName = editorDto.ArticleClassName;
            model.ArticleClassId = editorDto.ArticleClassId;
            

            return View(model);

        }

        #endregion

        #region 文章类别新增动作
        [HttpPost]
        public ActionResult ArticleClassInsert(ArticleClassAddViewModel model)
        {
            ArticleClassDto editorDto = new ArticleClassDto();

            editorDto.ArticleClassName = model.ArticleClassName;
           

            ArticleClassBll.AddArticleClass(editorDto);

            return RedirectTo("/ArticleClass/ArticleClassIndex", "文章类别添加成功了");
           // return RedirectToAction("ArticleClassIndex");


        }
        #endregion

        #region 文章类别更新动作
        [HttpPost]
        public ActionResult ArticleClassUpdate(ArticleClassEditViewModel model)
        {
            string table = "QxsqArticleClass";
            string strwhere = "ArticleClassId=" + model.ArticleClassId;
            ArticleClassDto editorDto = ArticleClassBll.GetOneArticleClassDto(table,strwhere);

            editorDto.ArticleClassName = model.ArticleClassName;


            ArticleClassBll.UpdateArticleClassDto(editorDto);


            return RedirectToAction("ArticleClassIndex");


        }

        #endregion

        #region 文章类别删除动作
        public ActionResult ArticleClassDelete(int ArticleClassId)
        {
            string table = "QxsqArticleClass";
            string strwhere = "ArticleClassId=" + ArticleClassId;
            ArticleClassBll.DeleteArticleClassDto(table, strwhere);

            return RedirectToAction("ArticleClassIndex");

        }
        #endregion

    }
}