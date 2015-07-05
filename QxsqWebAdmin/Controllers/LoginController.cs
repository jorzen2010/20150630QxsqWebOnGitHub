using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QxsqDTO;
using QxsqDAL;
using QxsqBLL;
using Common;

namespace QxsqWebAdmin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logon(string username ,string password)
        {
            string table = "QxsqEditor";
            string strwhere = "EditorUsername='" + username + "' and EditorPassword='" + CommonTools.ToMd5(password) + "'";
            EditorDto editorDto = EditorBll.GetOneEditorDto(table,strwhere);

            if (String.IsNullOrEmpty(editorDto.EditorUserName))
            {
                var message = new Message();
                message.MessageInfo = "用户名或密码错误";
                message.MessageStatus = "0";
                message.MessageUrl = "";
                var json = new { message.MessageInfo, message.MessageStatus, message.MessageUrl };
                return Json(json, JsonRequestBehavior.AllowGet);


            }
            else
            {
                var message = new Message();
                message.MessageInfo = "登录成功";
                message.MessageStatus = "1";
                message.MessageUrl = "";

                var json = new { message.MessageInfo, message.MessageStatus, message.MessageUrl };
                CommonBll.SetSessions(editorDto);
                var cookie = new HttpCookie("Editor", "Success");
                var cookieId = new HttpCookie("EditorId", editorDto.EditorId.ToString());
                System.Web.HttpContext.Current.Response.SetCookie(cookie);
                System.Web.HttpContext.Current.Response.SetCookie(cookieId);

                return Json(json, JsonRequestBehavior.AllowGet);
            }
            
            
        }
	}
}