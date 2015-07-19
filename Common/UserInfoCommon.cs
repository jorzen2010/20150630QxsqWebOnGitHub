using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class UserInfoCommon
    {
        public static List<string> UserInfoList(string userInfo)
        {
            List<string> userInfoList = new List<string>();
            if (userInfo == "UserSex")
            {
                userInfoList.Add("0 未知的性别");
                userInfoList.Add("1 男");
                userInfoList.Add("2 女");
                userInfoList.Add("9 未说明的性别");
            
            }
            if (userInfo == "UserHuji")
            {
                userInfoList.Add("1 户籍");
                userInfoList.Add("2 非户籍");
            }
            if (userInfo == "UserMinzu")
            {
                userInfoList.Add("1 汉族");
                userInfoList.Add("2 满族");
            }

            if (userInfo == "UserWenhua")
            {
                userInfoList.Add("1 文盲及半文盲");
                userInfoList.Add("2 小学");
                userInfoList.Add("3 初中");
                userInfoList.Add("4 高中/技校/中专");
                userInfoList.Add("5 大学专科及以上");
                userInfoList.Add("6 不详");
            }
            if (userInfo == "UserHunyin")
            {
                userInfoList.Add("1 未婚");
                userInfoList.Add("2 已婚");
                userInfoList.Add("3 丧偶");
                userInfoList.Add("4 离婚");
                userInfoList.Add("5 未说明的婚姻状况");
            }
            if (userInfo == "UserZhiye")
            {
                userInfoList.Add("1 国家机关、党群组织、企业、事业单位负责人");
                userInfoList.Add("2 专业技术人员");
                userInfoList.Add("3 办事人员和有关人员");
                userInfoList.Add("4 商业、服务人员");
                userInfoList.Add("5 农、林、牧、渔、水利业生产人员");
                userInfoList.Add("6 生产、运输设备操作人员及有关人员");
                userInfoList.Add("7 军人");
                userInfoList.Add("8 不便分类的其他从业人员");
            }
            return userInfoList;
        }



        
    }
}
