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
    public class EditorController : Controller
    {
      
      #region 网站管理员列表页
       
        public ActionResult EditorIndex(int? p)
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
        #endregion

        #region 网站管理员添加
        public ActionResult EditorAdd()
        {
            return View();

        }
        #endregion
        #region 网站管理员编辑
        public ActionResult EditorEdit(int EditorId)
        {
            string table="QxsqEditor";
            string strwhere="EditorId="+EditorId;
            EditorDto editorDto = EditorBll.GetOneEditorDto(table, strwhere);

            EditorEditViewModel model = new EditorEditViewModel();

            model.EditorUserName = editorDto.EditorUserName;
            model.EditorRealName = editorDto.EditorRealName;
            model.EditorId = editorDto.EditorId;
            

            return View(model);

        }

        #endregion
        #region 网站管理员新增动作
        [HttpPost]
        public ActionResult EditorInsert(EditorAddViewModel model)
        {
            EditorDto editorDto = new EditorDto();

            editorDto.EditorUserName = model.EditorUserName;
            editorDto.EditorRealName = model.EditorRealName;
            editorDto.EditorPassword = CommonTools.ToMd5(model.EditorPassword);
            editorDto.EditorRegTime = System.DateTime.Now;

            EditorBll.AddEditor(editorDto);


            return RedirectToAction("EditorIndex");


        }
        #endregion
        #region 网站管理员更新动作
        [HttpPost]
        public ActionResult EditorUpdate(EditorEditViewModel model)
        {
            string table = "QxsqEditor";
            string strwhere = "EditorId=" + model.EditorId;
            EditorDto editorDto = EditorBll.GetOneEditorDto(table,strwhere);

            editorDto.EditorUserName = model.EditorUserName;
            editorDto.EditorRealName = model.EditorRealName;
            editorDto.EditorRegTime = System.DateTime.Now;

            EditorBll.UpdateEditorDto(editorDto);


            return RedirectToAction("EditorIndex");


        }

        #endregion
        #region 网站管理员删除动作
        public ActionResult EditorDelete(int EditorId)
        {
            string table = "QxsqEditor";
            string strwhere = "EditorId=" + EditorId;
            EditorBll.DeleteEditorDto(table, strwhere);

            return RedirectToAction("EditorIndex");

        }
        #endregion

    }
}