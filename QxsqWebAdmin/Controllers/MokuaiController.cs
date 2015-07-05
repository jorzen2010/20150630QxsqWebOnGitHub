﻿using System;
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
    public class MokuaiController : Controller
    {
      

        #region 网站管理员添加
        public ActionResult MokuaiAdd()
        {
            return View();

        }
        #endregion

        #region 网站管理员新增动作
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult MokuaiInsert(MokuaiAddViewModel model)
        {
            MokuaiDto mokuaiDto = new MokuaiDto();

            mokuaiDto.MokuaiTitle = model.MokuaiTitle;
            mokuaiDto.MokuaiImg = model.MokuaiImg;
            mokuaiDto.MokuaiContent = model.MokuaiContent;
            mokuaiDto.MokuaiDateTime = System.DateTime.Now;

            MokuaiBll.AddMokuai(mokuaiDto);


            return RedirectToAction("MokuaiIndex");


        }
        #endregion


        #region 模块列表页

        public ActionResult MokuaiIndex(int? p)
        {


            string strwhere = "MokuaiId>0";
            string table = "QxsqMokuai";

            Pager pager = new Pager();
            pager.PageSize = 2;
            pager.PageNo = p ?? 1;

            pager = MokuaiBll.GetMokuaiPager(pager, strwhere, table);
            ViewBag.PageNo = p ?? 1;
            ViewBag.PageCount = pager.PageCount;
            ViewBag.RecordCount = pager.Amount;


            return View(pager.Entity);
        }
        #endregion

        #region 模块删除动作
        public ActionResult MokuaiDelete(int MokuaiId)
        {
            string table = "QxsqMokuai";
            string strwhere = "MokuaiId=" + MokuaiId;
            MokuaiBll.DeleteMokuaiDto(table, strwhere);

            return RedirectToAction("MokuaiIndex");

        }
        #endregion

        #region 模块编辑
        public ActionResult MokuaiEdit(int MokuaiId)
        {
            string table = "QxsqMokuai";
            string strwhere = "MokuaiId=" + MokuaiId;
            MokuaiDto MokuaiDto = MokuaiBll.GetOneMokuaiDto(table, strwhere);

            MokuaiEditViewModel model = new MokuaiEditViewModel();

            model.MokuaiTitle = MokuaiDto.MokuaiTitle;
            model.MokuaiImg = MokuaiDto.MokuaiImg;
            model.MokuaiContent = MokuaiDto.MokuaiContent;

            ViewBag.MokuaiContent = model.MokuaiContent;


            return View(model);

        }

        #endregion

        #region 网站管理员更新动作
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult MokuaiUpdate(MokuaiEditViewModel model)
        {
            string table = "QxsqMokuai";
            string strwhere = "MokuaiId=" + model.MokuaiId;
            MokuaiDto mokuaiDto = MokuaiBll.GetOneMokuaiDto(table, strwhere);

            mokuaiDto.MokuaiTitle = model.MokuaiTitle;
            mokuaiDto.MokuaiImg = model.MokuaiImg;
            mokuaiDto.MokuaiContent = model.MokuaiContent;
            mokuaiDto.MokuaiDateTime = System.DateTime.Now;

            MokuaiBll.UpdateMokuaiDto(mokuaiDto);


            return RedirectToAction("MokuaiIndex");


        }

        #endregion
    }
}