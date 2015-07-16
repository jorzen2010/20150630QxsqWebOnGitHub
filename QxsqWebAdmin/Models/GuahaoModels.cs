using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using QxsqWebAdmin.Attributes;

namespace QxsqWebAdmin.Models
{
    
    #region 模块添加模型
    public class GuahaoAddViewModel
    {
        [RegularExpression("^[\u4E00-\u9FA5]{2,4}$", ErrorMessage = "姓名必须是2-4个汉字")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "姓名必须是2-4个汉字")]
        [Required]
        [Display(Name = "姓名")]
        public string GuahaoName { get; set; }

        [Required]
        [Display(Name = "手机")]
        public string GuahaoTel { get; set; }

        [Required]
        [Display(Name = "挂号时间")]
        public DateTime GuahaoTime { get; set; }
        [Required]
        [Display(Name = "病情描述")]
        public string GuahaoInfo { get; set; }

        [Required]
        [Display(Name = "预约时间")]
        public DateTime GuahaoDateTime { get; set; }

        [Required]
        [Display(Name = "预约状态")]
        public int GuahaoStatus { get; set; }

        [Required]
        [Display(Name = "预约医生")]
        public string GuahaoDoctor { get; set; }

        [Required]
        [Display(Name = "预约科室")]
        public string GuahaoGroup { get; set; }
    
    }
    #endregion

    #region 模块添加模型
    public class GuahaoEditViewModel
    {
        [Required]
        [Display(Name = "姓名")]
        public int GuahaoId { get; set; }

        [Required]
        [Display(Name = "姓名")]
        public string GuahaoName { get; set; }

        [Required]
        [Display(Name = "手机")]
        public string GuahaoTel { get; set; }

        [Required]
        [Display(Name = "挂号时间")]
        public DateTime GuahaoTime { get; set; }
        [Required]
        [Display(Name = "病情描述")]
        public string GuahaoInfo { get; set; }

        [Required]
        [Display(Name = "预约时间")]
        public DateTime GuahaoDateTime { get; set; }

        [Required]
        [Display(Name = "预约状态")]
        public int GuahaoStatus { get; set; }

        [Required]
        [Display(Name = "预约医生")]
        public string GuahaoDoctor { get; set; }

        [Required]
        [Display(Name = "预约科室")]
        public string GuahaoGroup { get; set; }
    

    }
    #endregion
   

}