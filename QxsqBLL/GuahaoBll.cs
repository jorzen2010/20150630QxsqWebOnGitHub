using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QxsqDTO;
using QxsqDAL;
using Common;

namespace QxsqBLL
{
    public class GuahaoBll
    {
         


        public static List<GuahaoDto> GetGuahaoDtoList(string strwhere)
        {
            return GuahaoDal.GetGuahaoList(strwhere);
        }



        #region 得到一个GuahaoPager 
        public static Pager GetGuahaoPager(Pager pager,string strwhere,string table)
        {


            //return GuahaoDal.GetGuahaoPage(pager, strwhere,table);
            return GuahaoDal.GetGuahaoPage(pager, strwhere, table);
        }


        #endregion

        #region 新增一个
        public static void AddGuahao(GuahaoDto mguahaoDto)
        {
            GuahaoDal.AddGuahao(mguahaoDto);
     
        }


        #endregion

        #region 获取一个Guahao
        public static GuahaoDto GetOneGuahaoDto(string table,string strwhere)
        {
            GuahaoDto mguahaoDto=new GuahaoDto();

            mguahaoDto = GuahaoDal.GetOneGuahao(table, strwhere);

            return mguahaoDto;
        }


        #endregion

        #region 更新Guahao

        public static void UpdateGuahaoDto(GuahaoDto mguahaoDto)
        {
            GuahaoDal.UpdateGuahao(mguahaoDto);
        }

        #endregion

        #region 删除Guahao
        public static void DeleteGuahaoDto(string table,string strwhere)
        {
            CommonDal.DeleteOneDto(table,strwhere);
        }
        #endregion
    }
}
