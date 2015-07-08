using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using QxsqWebAdmin.Attributes;

namespace QxsqWebAdmin.Models
{
    
    #region 文章添加模型
    public class ArticleAddViewModel
    {
        [Required]
        [Display(Name = "文章标题")]
        public string ArticleTitle { get; set; }

        [Required]
        [Display(Name = "文章类别")]
        public string ArticleClass { get; set; }

        [Required]
        [Display(Name = "文章图片")]
        [FileUpload("Course")]
        public string ArticleImg { get; set; }

        [Required]
        [Display(Name = "文章简介")]
        public string ArticleInfo { get; set; }

        [Required]
        [Display(Name = "文章内容")]
        public string ArticleContent { get; set; }

        [Required]
        [Display(Name = "文章更新日期")]
        public string ArticleDateTime { get; set; }
        [Required]
        [Display(Name = "置顶")]
        public bool ArticleTop { get; set; }
        [Required]
        [Display(Name = "热门")]
        public bool ArticleHot { get; set; }
        [Required]
        [Display(Name = "加精")]
        public bool ArticleImportant { get; set; }


    
    }
    #endregion

    #region 模块添加模型
    public class ArticleEditViewModel
    {
        [Required]
        [Display(Name = "文章标题")]
        public string ArticleTitle { get; set; }

        [Required]
        [Display(Name = "文章类别")]
        public string ArticleClass { get; set; }

        [Required]
        [Display(Name = "文章图片")]
        [FileUpload("Course")]
        public string ArticleImg { get; set; }

        [Required]
        [Display(Name = "文章简介")]
        public string ArticleInfo { get; set; }

        [Required]
        [Display(Name = "文章内容")]
        public string ArticleContent { get; set; }

        [Required]
        [Display(Name = "文章置顶")]
        public bool ArticleTop { get; set; }
        [Required]
        [Display(Name = "文章热门")]
        public bool ArticleHot { get; set; }
        [Required]
        [Display(Name = "文章加精")]
        public bool ArticleImportant { get; set; }

        public int ArticleId { get; set; }

    }
    #endregion
   

}