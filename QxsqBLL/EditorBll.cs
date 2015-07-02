using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using QxsqDTO;
using QxsqDAL;
using Common;

namespace QxsqBLL
{
    public class EditorBll
    {
         #region 得到一个Editorlist 并显示成下拉列表形式


        public static List<SelectListItem> GetEditorListForSelectListItems(string strwhere)
        {


            List<EditorDto> EditorDtoList = EditorDal.GetEditorList(strwhere);

            List<SelectListItem> Editorlist = new List<SelectListItem>();

            Editorlist.Add(new SelectListItem { Text = "请选择游戏",Value = "0"});

            foreach (EditorDto dto in EditorDtoList)
            {
                Editorlist.Add(new SelectListItem { Text = dto.EditorUserName, Value = dto.EditorId.ToString() });

            }

            return Editorlist;
        }


        #endregion


        public static List<EditorDto> GetEditorDtoList(string strwhere)
        {
            return EditorDal.GetEditorList(strwhere);
        }



        #region 得到一个EditorPager 
        public static Pager GetEditorPager(Pager pager,string strwhere,string table)
        {


            //return EditorDal.GetEditorPage(pager, strwhere,table);
            return EditorDal.GetEditorPage(pager, strwhere, table);
        }


        #endregion

        #region 新增一个游戏
        public static void AddEditor(EditorDto gameDto)
        {
            EditorDal.AddEditor(gameDto);
     
        }


        #endregion

        #region 获取一个Editor
        public static EditorDto GetOneEditorDto(string strwhere)
        {
            EditorDto gameDto=new EditorDto();

            gameDto = EditorDal.GetOneEditor(strwhere);

            return gameDto;
        }


        #endregion

        #region 更新Editor

        public static void UpdateEditorDt0(EditorDto gameDto)
        {
            EditorDal.UpdateEditor(gameDto);
        }

        #endregion
    }
}
