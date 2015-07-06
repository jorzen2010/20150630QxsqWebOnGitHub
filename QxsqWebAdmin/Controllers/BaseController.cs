using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using QxsqBLL;

namespace QxsqWebAdmin.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/
        public ActionResult RedirectTo(string action = "Index", string controller = "Home", string message = "")
        {
            ViewBag.Message = message;
            ViewBag.Url = Url.Action(action, controller);
            return View("Redirect");
        }

        public ActionResult RedirectTo(string url, string message = "")
        {
            if (string.IsNullOrEmpty(url))
            {
                url = Url.Action("Index", "Home");
            }
            ViewBag.Message = message;
            ViewBag.Url = url;
            return View("Redirect");
        }
        public JsonResult SetModelByAjax(string table, string strwhere, string columnname, string columnvalue)
        {
            CommonBll.SetModelBitByAjax(table, strwhere, columnname, columnvalue);
            var message = new Message();
            var json = new
            {
                message.MessageInfo,
                message.MessageStatus,
                message.MessageUrl
            };
            return Json(json, JsonRequestBehavior.AllowGet);
        }
	}
}