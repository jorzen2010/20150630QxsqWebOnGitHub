using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using QxsqWebAdmin.Attributes;

namespace QxsqWebAdmin.Models
{
    
    #region 模块添加模型
    public class UserAddViewModel
    {
        [Required]
        [Display(Name = "用户密码")]
        public string UserPassword { get; set; }
        [Required]
        [Display(Name = "姓名")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "性别")]
        public string UserSex { get; set; }
        [Required]
        [Display(Name = "出生日期")]
        public string UserBirthday { get; set; }
        [Required]
        [Display(Name = "身份证号码")]
        public string UserNumber { get; set; }
        [Required]
        [Display(Name = "本人电话")]
        public string UserTel { get; set; }
        [Required]
        [Display(Name = "联系人姓名")]
        public string UserFirstPerson { get; set; }
        [Required]
        [Display(Name = "联系人电话")]
        public string UserFirstPersonTel { get; set; }
        [Required]
        [Display(Name = "乡镇（街道）名称")]
        public string UserJiedaoName { get; set; }
        [Required]
        [Display(Name = "村（居）委会名称")]
        public string UserJuweihuiName { get; set; }
        [Required]
        [Display(Name = "常住类型")]
        public string UserHuji { get; set; }
        [Required]
        [Display(Name = "民族")]
        public string UserMinzu { get; set; }
        [Required]
        [Display(Name = "文化程度")]
        public string UserWenhua { get; set; }
        [Required]
        [Display(Name = "职业")]
        public string UserZhiye { get; set; }
        [Required]
        [Display(Name = "婚姻状况")]
        public string UserHunyin { get; set; }
        [Required]
        [Display(Name = "医疗费用支付方式")]
        public string UserFeiyong { get; set; }
        [Required]
        [Display(Name = "责任医生")]
        public int UserDoctor { get; set; }
        [Required]
        [Display(Name = "所属组织")]
        public int UserGroup { get; set; }
        [Required]
        [Display(Name = "糖尿病患者")]
        public bool UserTangniaobing { get; set; }
        [Required]
        [Display(Name = "高血压患者")]
        public bool UserGaoxueya { get; set; }
        [Required]
        [Display(Name = "孕妇保健")]
        public bool UserYunfu { get; set; }
        [Required]
        [Display(Name = "儿童保健")]
        public bool UserErtong { get; set; }
        [Required]
        [Display(Name = "现住址")]
        public string UserNowAddress { get; set; }
        [Required]
        [Display(Name = "户籍地址")]
        public string UserOldAddress { get; set; }
        [Required]
        [Display(Name = "工作单位")]
        public string UserJobGroup { get; set; }
    
    }
    #endregion

    #region 模块添加模型
    public class UserEditViewModel
    {
        [Required]
        [Display(Name = "用户Id")]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "用户密码")]
        public string UserPassword { get; set; }
        [Required]
        [Display(Name = "姓名")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "性别")]
        public string UserSex { get; set; }
        [Required]
        [Display(Name = "出生日期")]
        public string UserBirthday { get; set; }
        [Required]
        [Display(Name = "身份证号码")]
        public string UserNumber { get; set; }
        [Required]
        [Display(Name = "本人电话")]
        public string UserTel { get; set; }
        [Required]
        [Display(Name = "联系人姓名")]
        public string UserFirstPerson { get; set; }
        [Required]
        [Display(Name = "联系人电话")]
        public string UserFirstPersonTel { get; set; }
        [Required]
        [Display(Name = "乡镇（街道）名称")]
        public string UserJiedaoName { get; set; }
        [Required]
        [Display(Name = "村（居）委会名称")]
        public string UserJuweihuiName { get; set; }
        [Required]
        [Display(Name = "常住类型")]
        public string UserHuji { get; set; }
        [Required]
        [Display(Name = "民族")]
        public string UserMinzu { get; set; }
        [Required]
        [Display(Name = "文化程度")]
        public string UserWenhua { get; set; }
        [Required]
        [Display(Name = "职业")]
        public string UserZhiye { get; set; }
        [Required]
        [Display(Name = "婚姻状况")]
        public string UserHunyin { get; set; }
        [Required]
        [Display(Name = "医疗费用支付方式")]
        public string UserFeiyong { get; set; }
        [Required]
        [Display(Name = "责任医生")]
        public int UserDoctor { get; set; }
        [Required]
        [Display(Name = "所属组织")]
        public int UserGroup { get; set; }
        [Required]
        [Display(Name = "糖尿病患者")]
        public bool UserTangniaobing { get; set; }
        [Required]
        [Display(Name = "高血压患者")]
        public bool UserGaoxueya { get; set; }
        [Required]
        [Display(Name = "孕妇保健")]
        public bool UserYunfu { get; set; }
        [Required]
        [Display(Name = "儿童保健")]
        public bool UserErtong { get; set; }
        [Required]
        [Display(Name = "现住址")]
        public string UserNowAddress { get; set; }
        [Required]
        [Display(Name = "户籍地址")]
        public string UserOldAddress { get; set; }
        [Required]
        [Display(Name = "工作单位")]
        public string UserJobGroup { get; set; }

    }
    #endregion
   

}