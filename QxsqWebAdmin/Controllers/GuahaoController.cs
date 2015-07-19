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
    public class GuahaoController : BaseController
    {
      

        #region 模块添加
        public ActionResult GuahaoAdd()
        {
            return View();

        }
        #endregion

        #region 模块新增动作
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult GuahaoInsert(GuahaoAddViewModel model)
        {
            GuahaoDto guahaoDto = new GuahaoDto();

            guahaoDto.GuahaoName = model.GuahaoName;
            guahaoDto.GuahaoTel = model.GuahaoTel;
            guahaoDto.GuahaoInfo = model.GuahaoInfo;
            guahaoDto.GuahaoDateTime = System.DateTime.Now;
            guahaoDto.GuahaoTime = model.GuahaoTime;
            guahaoDto.GuahaoStatus = model.GuahaoStatus;
            guahaoDto.GuahaoDoctor = model.GuahaoDoctor;
            guahaoDto.GuahaoGroup = model.GuahaoGroup;


            GuahaoBll.AddGuahao(guahaoDto);


            return RedirectToAction("GuahaoIndex");


        }
        #endregion

        #region 模块列表页

        public ActionResult GuahaoIndex(int? p,int? status)
        {
            int GuahaoStatus = status ?? 0;
            string strwhere = "";

            if (GuahaoStatus == 0)
            {
                strwhere = "GuahaoId>0";
            }
            else
            {
                strwhere = "GuahaoId>0 and GuahaoStatus=" + GuahaoStatus;
            }

           

            string table = "QxsqGuahao";

            Pager pager = new Pager();
            pager.PageSize = 20;
            pager.PageNo = p ?? 1;

            pager = GuahaoBll.GetGuahaoPager(pager, strwhere, table);
            ViewBag.PageNo = p ?? 1;
            ViewBag.PageCount = pager.PageCount;
            ViewBag.RecordCount = pager.Amount;


            return View(pager.Entity);
        }
        #endregion

        #region 模块删除动作
        public ActionResult GuahaoDelete(int GuahaoId)
        {
            string table = "QxsqGuahao";
            string strwhere = "GuahaoId=" + GuahaoId;
            GuahaoBll.DeleteGuahaoDto(table, strwhere);

            return RedirectToAction("GuahaoIndex");

        }
        #endregion

        #region 模块编辑
        public ActionResult GuahaoEdit(int GuahaoId)
        {
            string table = "QxsqGuahao";
            string strwhere = "GuahaoId=" + GuahaoId;
            GuahaoDto guahaoDto = GuahaoBll.GetOneGuahaoDto(table, strwhere);

            GuahaoEditViewModel model = new GuahaoEditViewModel();

            model.GuahaoName = guahaoDto.GuahaoName;
            model.GuahaoTel = guahaoDto.GuahaoTel;
            model.GuahaoInfo = guahaoDto.GuahaoInfo;
            model.GuahaoDateTime = System.DateTime.Now;
            model.GuahaoTime = System.DateTime.Now;
            model.GuahaoStatus = guahaoDto.GuahaoStatus;
            model.GuahaoDoctor = guahaoDto.GuahaoDoctor;
            model.GuahaoGroup = guahaoDto.GuahaoGroup;
            model.GuahaoId = guahaoDto.GuahaoId;



            return View(model);

        }

        #endregion

        #region 模块更新动作
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult GuahaoUpdate(GuahaoEditViewModel model)
        {
            string table = "QxsqGuahao";
            string strwhere = "GuahaoId=" + model.GuahaoId;
            GuahaoDto guahaoDto = GuahaoBll.GetOneGuahaoDto(table, strwhere);

            guahaoDto.GuahaoName = model.GuahaoName;
            guahaoDto.GuahaoTel = model.GuahaoTel;
            guahaoDto.GuahaoInfo = model.GuahaoInfo;
            guahaoDto.GuahaoDateTime = System.DateTime.Now;
            guahaoDto.GuahaoTime = System.DateTime.Now;
            guahaoDto.GuahaoStatus = model.GuahaoStatus;
            guahaoDto.GuahaoDoctor = model.GuahaoDoctor;
            guahaoDto.GuahaoGroup = model.GuahaoGroup;

            GuahaoBll.UpdateGuahaoDto(guahaoDto);


            return RedirectToAction("GuahaoIndex");


        }

        #endregion
    }
}