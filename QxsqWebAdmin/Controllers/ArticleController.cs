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
    public class ArticleController : Controller
    {
      
       
        #region 文章添加
        public ActionResult ArticleAdd()
        {
            return View();

        }
        #endregion
       

    }
}