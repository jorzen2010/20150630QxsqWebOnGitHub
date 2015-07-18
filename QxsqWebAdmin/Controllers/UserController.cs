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
    public class UserController : BaseController
    {
      
        #region 客户列表页
       
        public ActionResult UserIndex(int? p)
        {


            string strwhere = "UserId>0";
            string table = "QxsqUser";

            Pager pager = new Pager();
            pager.PageSize = 2;
            pager.PageNo = p ?? 1;

            pager = UserBll.GetUserPager(pager, strwhere, table);
            ViewBag.PageNo = p ?? 1;
            ViewBag.PageCount = pager.PageCount;
            ViewBag.RecordCount = pager.Amount;


            return View(pager.Entity);
        }
        #endregion

        #region 客户添加
        public ActionResult UserAdd()
        {
            return View();

        }
        #endregion

        #region 客户编辑
        public ActionResult UserEdit(int UserId)
        {
            string table="QxsqUser";
            string strwhere="UserId="+UserId;
            UserDto userDto = UserBll.GetOneUserDto(table, strwhere);

            UserEditViewModel model = new UserEditViewModel();

            model.UserId = userDto.UserId;
            model.UserPassword = userDto.UserPassword;
            model.UserName = userDto.UserName;
            model.UserSex = userDto.UserSex;
            model.UserBirthday = userDto.UserBirthday;
            model.UserNumber = userDto.UserNumber;
            model.UserTel = userDto.UserTel;
            model.UserFirstPerson = userDto.UserFirstPerson;
            model.UserFirstPersonTel = userDto.UserFirstPersonTel;
            model.UserJiedaoName = userDto.UserJiedaoName;
            model.UserJuweihuiName = userDto.UserJuweihuiName;
            model.UserHuji = userDto.UserHuji;
            model.UserMinzu = userDto.UserMinzu;
            model.UserWenhua = userDto.UserWenhua;
            model.UserZhiye = userDto.UserZhiye;
            model.UserHunyin = userDto.UserHunyin;
            model.UserFeiyong = userDto.UserFeiyong;
            model.UserDoctor = userDto.UserDoctor;
            model.UserGroup = userDto.UserGroup;
            model.UserTangniaobing = userDto.UserTangniaobing;
            model.UserGaoxueya = userDto.UserGaoxueya;
            model.UserYunfu = userDto.UserYunfu;
            model.UserErtong = userDto.UserErtong;
            model.UserNowAddress = userDto.UserNowAddress;
            model.UserOldAddress = userDto.UserOldAddress;
            model.UserJobGroup = userDto.UserJobGroup;
            

            return View(model);

        }

        #endregion

        #region 客户新增动作
        [HttpPost]
        public ActionResult UserInsert(UserAddViewModel model)
        {
            UserDto userDto = new UserDto();

            userDto.UserPassword = model.UserPassword;
            userDto.UserName = model.UserName;
            userDto.UserSex = model.UserSex;
            userDto.UserBirthday = model.UserBirthday;
            userDto.UserNumber = model.UserNumber;
            userDto.UserTel = model.UserTel;
            userDto.UserFirstPerson = model.UserFirstPerson;
            userDto.UserFirstPersonTel = model.UserFirstPersonTel;
            userDto.UserJiedaoName = model.UserJiedaoName;
            userDto.UserJuweihuiName = model.UserJuweihuiName;
            userDto.UserHuji = model.UserHuji;
            userDto.UserMinzu = model.UserMinzu;
            userDto.UserWenhua = model.UserWenhua;
            userDto.UserZhiye = model.UserZhiye;
            userDto.UserHunyin = model.UserHunyin;
            userDto.UserFeiyong = model.UserFeiyong;
            userDto.UserDoctor = model.UserDoctor;
            userDto.UserGroup = model.UserGroup;
            userDto.UserTangniaobing = model.UserTangniaobing;
            userDto.UserGaoxueya = model.UserGaoxueya;
            userDto.UserYunfu = model.UserYunfu;
            userDto.UserErtong = model.UserErtong;
            userDto.UserNowAddress = model.UserNowAddress;
            userDto.UserOldAddress = model.UserOldAddress;
            userDto.UserJobGroup = model.UserJobGroup;

            UserBll.AddUser(userDto);

           return RedirectTo("/User/UserIndex", "客户添加成功了");
           //return RedirectToAction("UserIndex");


        }
        #endregion

        #region 客户更新动作
        [HttpPost]
        public ActionResult UserUpdate(UserEditViewModel model)
        {
            string table = "QxsqUser";
            string strwhere = "UserId=" + model.UserId;
            UserDto userDto = UserBll.GetOneUserDto(table,strwhere);
            userDto.UserPassword = model.UserPassword;
            userDto.UserName = model.UserName;
            userDto.UserSex = model.UserSex;
            userDto.UserBirthday = model.UserBirthday;
            userDto.UserNumber = model.UserNumber;
            userDto.UserTel = model.UserTel;
            userDto.UserFirstPerson = model.UserFirstPerson;
            userDto.UserFirstPersonTel = model.UserFirstPersonTel;
            userDto.UserJiedaoName = model.UserJiedaoName;
            userDto.UserJuweihuiName = model.UserJuweihuiName;
            userDto.UserHuji = model.UserHuji;
            userDto.UserMinzu = model.UserMinzu;
            userDto.UserWenhua = model.UserWenhua;
            userDto.UserZhiye = model.UserZhiye;
            userDto.UserHunyin = model.UserHunyin;
            userDto.UserFeiyong = model.UserFeiyong;
            userDto.UserDoctor = model.UserDoctor;
            userDto.UserGroup = model.UserGroup;
            userDto.UserTangniaobing = model.UserTangniaobing;
            userDto.UserGaoxueya = model.UserGaoxueya;
            userDto.UserYunfu = model.UserYunfu;
            userDto.UserErtong = model.UserErtong;
            userDto.UserNowAddress = model.UserNowAddress;
            userDto.UserOldAddress = model.UserOldAddress;
            userDto.UserJobGroup = model.UserJobGroup;



            UserBll.UpdateUserDto(userDto);


            return RedirectToAction("UserIndex");


        }

        #endregion

        #region 客户删除动作
        public ActionResult UserDelete(int UserId)
        {
            string table = "QxsqUser";
            string strwhere = "UserId=" + UserId;
            UserBll.DeleteUserDto(table, strwhere);

            return RedirectToAction("UserIndex");

        }
        #endregion

    }
}