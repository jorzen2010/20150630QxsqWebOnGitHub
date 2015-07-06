using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QxsqWebAdmin.Models
{
    #region 文章类别添加模型
    public class ArticleClassAddViewModel
    {
        [Required]
        [Display(Name = "文章类别名称")]
        public string ArticleClassName { get; set; }

        

    }
    #endregion

    #region 文章类别更新模型
    public class ArticleClassEditViewModel
    {
        [Required]
        [Display(Name = "文章类别名称")]
        public string ArticleClassName { get; set; }

        public int ArticleClassId { get; set; }



    }
    #endregion
}