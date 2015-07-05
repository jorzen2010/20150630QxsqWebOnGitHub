using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using QxsqWebAdmin.Attributes;

namespace QxsqWebAdmin.Models
{
    
    #region 模块添加模型
    public class MokuaiAddViewModel
    {
        [Required]
        [Display(Name = "模块标题")]
        public string MokuaiTitle { get; set; }

        [Required]
        [Display(Name = "模块图片")]
        [FileUpload("Course")]
        public string MokuaiImg { get; set; }

        [Required]
        [Display(Name = "模块内容")]
        public string MokuaiContent { get; set; }

        [Required]
        [Display(Name = "模块更新日期")]
        public string MokuaiDateTime { get; set; }
    
    }
    #endregion

    #region 模块添加模型
    public class MokuaiEditViewModel
    {
        [Required]
        [Display(Name = "模块标题")]
        public int MokuaiId { get; set; }

        [Required]
        [Display(Name = "模块标题")]
        public string MokuaiTitle { get; set; }

        [Required]
        [Display(Name = "模块图片")]
        [FileUpload("Course")]
        public string MokuaiImg { get; set; }

        [Required]
        [Display(Name = "模块内容")]
        public string MokuaiContent { get; set; }

        [Required]
        [Display(Name = "模块更新日期")]
        public string MokuaiDateTime { get; set; }

    }
    #endregion
   

}