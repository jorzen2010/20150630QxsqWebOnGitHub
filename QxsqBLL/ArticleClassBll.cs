﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QxsqDTO;
using QxsqDAL;
using Common;

namespace QxsqBLL
{
    public class ArticleClassBll
    {
         


        public static List<ArticleClassDto> GetArticleClassDtoList(string strwhere)
        {
            return ArticleClassDal.GetArticleClassList(strwhere);
        }



        #region 得到一个ArticleClassPager 
        public static Pager GetArticleClassPager(Pager pager,string strwhere,string table)
        {


            //return ArticleClassDal.GetArticleClassPage(pager, strwhere,table);
            return ArticleClassDal.GetArticleClassPage(pager, strwhere, table);
        }


        #endregion

        #region 新增一个
        public static void AddArticleClass(ArticleClassDto articleClassDto)
        {
            ArticleClassDal.AddArticleClass(articleClassDto);
     
        }


        #endregion

        #region 获取一个ArticleClass
        public static ArticleClassDto GetOneArticleClassDto(string table,string strwhere)
        {
            ArticleClassDto articleClassDto = new ArticleClassDto();

            articleClassDto = ArticleClassDal.GetOneArticleClass(table, strwhere);

            return articleClassDto;
        }


        #endregion

        #region 更新ArticleClass

        public static void UpdateArticleClassDto(ArticleClassDto articleClassDto)
        {
            ArticleClassDal.UpdateArticleClass(articleClassDto);
        }

        #endregion

        #region 删除ArticleClass
        public static void DeleteArticleClassDto(string table, string strwhere)
        {
            CommonDal.DeleteOneDto(table,strwhere);
        }
        #endregion
    }
}
