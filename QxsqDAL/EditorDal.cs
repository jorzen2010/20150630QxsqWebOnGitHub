using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QxsqDTO;
using Common;

namespace QxsqDAL
{
    public class EditorDal
    {
        #region 添加一个游戏

        public static void AddEditor(EditorDto editorDto)
        {

            SqlParameter[] arParames = EditorDal.getParameters(editorDto);

            SqlHelper.ExecuteNonQuery(DataConn.ConnectionString, CommandType.StoredProcedure, "CreateEditor", arParames);

        }
        #endregion

        #region 获取一个游戏

        public static EditorDto GetOneEditor(string strwhere)
        {
            EditorDto editorDto = new EditorDto();

            SqlParameter[] arParames = new SqlParameter[2];
            arParames[0] = new SqlParameter("@table ", SqlDbType.VarChar, 200);
            arParames[0].Value = "Pk66_Editor";

            arParames[1] = new SqlParameter("@Where ", SqlDbType.VarChar, 8000);
            arParames[1].Value = strwhere;

            DataTable dt = null;

            DataSet ds = SqlHelper.ExecuteDataset(DataConn.ConnectionString, CommandType.StoredProcedure, "getModelByWhere", arParames);
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {

                editorDto = EditorDal.getDataRowToEditorDto(dr);

            }


            return editorDto;



        }
        #endregion

        #region 取得游戏类型List
        public static List<EditorDto> GetEditorList(string strwhere)
        {
            List<EditorDto> gamelist = new List<EditorDto>();



            SqlParameter[] arParames = new SqlParameter[2];
            arParames[0] = new SqlParameter("@table ", SqlDbType.VarChar, 200);
            arParames[0].Value = "Pk66_Editor";

            arParames[1] = new SqlParameter("@Where ", SqlDbType.VarChar, 8000);
            arParames[1].Value = strwhere;

            DataTable dt = null;
            DataSet ds = SqlHelper.ExecuteDataset(DataConn.ConnectionString, CommandType.StoredProcedure, "getModelByWhere", arParames);
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                EditorDto editorDto = new EditorDto();

                editorDto = EditorDal.getDataRowToEditorDto(dr);


                gamelist.Add(editorDto);

            }

            return gamelist;

        }
        #endregion

        #region 将DTO映射成数据库参数
        private static SqlParameter[] getParameters(EditorDto editorDto)
        {
            SqlParameter[] arParames = new SqlParameter[5];


            arParames[0] = new SqlParameter("@Editor_Id", SqlDbType.Int);
            arParames[0].Value = editorDto.EditorId;

            arParames[1] = new SqlParameter("@Editor_Title", SqlDbType.VarChar, 500);
            arParames[1].Value = editorDto.EditorTitle;

            arParames[2] = new SqlParameter("@Editor_Img", SqlDbType.VarChar, 500);
            arParames[2].Value = editorDto.EditorImg;

            arParames[3] = new SqlParameter("@Editor_Href", SqlDbType.VarChar, 500);
            arParames[3].Value = editorDto.EditorHref;

            arParames[4] = new SqlParameter("@Editor_Enable", SqlDbType.Bit);
            arParames[4].Value = editorDto.EditorEnable;


            return arParames;
        }

        #endregion

        #region 将数据集映射成DTO
        private static EditorDto getDataRowToEditorDto(DataRow dr)
        {
            EditorDto editorDto = new EditorDto();

            editorDto.EditorId = int.Parse(dr["Editor_Id"].ToString());
            editorDto.EditorTitle = dr["Editor_Title"].ToString();
            editorDto.EditorImg = dr["Editor_Img"].ToString();

            editorDto.EditorHref = dr["Editor_Href"].ToString();

            editorDto.EditorEnable = bool.Parse(dr["Editor_Enable"].ToString());

            return editorDto;
        }

        #endregion

        #region 将数据集映射成DTO
        private static EditorDto getDataReaderToEditorDto(SqlDataReader dr)
        {
            EditorDto editorDto = new EditorDto();


            editorDto.EditorId = int.Parse(dr["Editor_Id"].ToString());
            editorDto.EditorTitle = dr["Editor_Title"].ToString();
            editorDto.EditorImg = dr["Editor_Img"].ToString();

            editorDto.EditorHref = dr["Editor_Href"].ToString();

            editorDto.EditorEnable = bool.Parse(dr["Editor_Enable"].ToString());
            return editorDto;
        }

        #endregion

        #region 删除一个Editor对象DTO
        public static void DeleteEditorDto(string table, string strwhere)
        {


            SqlParameter[] arParames = new SqlParameter[2];
            arParames[0] = new SqlParameter("@table ", SqlDbType.VarChar, 200);
            arParames[0].Value = table;

            arParames[1] = new SqlParameter("@Where ", SqlDbType.VarChar, 8000);
            arParames[1].Value = strwhere;

            SqlHelper.ExecuteNonQuery(DataConn.ConnectionString, CommandType.StoredProcedure, "deleteModelByWhere", arParames);



        }
        #endregion


        #region 更新一个Editor课程
        public static void UpdateEditor(EditorDto editorDto)
        {

            SqlParameter[] arParames = EditorDal.getParameters(editorDto);

            SqlHelper.ExecuteNonQuery(DataConn.ConnectionString, CommandType.StoredProcedure, "UpdateEditor", arParames);


        }

        #endregion


        #region 取得联合查询的数据库游戏内容并进行分页
        public static Pager GetEditorPage(Pager pager, string strwhere, string table)
        {
            SqlParameter[] arParms = new SqlParameter[10];

            //@tblName   --要分页显示的表名（支持多个表）
            arParms[0] = new SqlParameter("@strTbName", SqlDbType.NVarChar, 200);
            arParms[0].Value = table;

            // @fldName --需要显示的字段
            arParms[1] = new SqlParameter("@strFeilds", SqlDbType.NVarChar, 500);
            arParms[1].Value = "*";

            // @PageSize --每页的大小(记录数)
            arParms[2] = new SqlParameter("@PageSize", SqlDbType.Int);
            arParms[2].Value = pager.PageSize;

            //@PageCurrent --要显示的页码
            arParms[3] = new SqlParameter("@PageIndex", SqlDbType.Int);
            arParms[3].Value = pager.PageNo + 1;


            //@FieldShow  --排序字段或条件
            arParms[4] = new SqlParameter("@strOrder", SqlDbType.NVarChar, 200);
            arParms[4].Value = "";

            //@Sort --1为升序，0为降序

            arParms[5] = new SqlParameter("@OrderType", SqlDbType.Int);
            arParms[5].Value = 1;

            //@strCondition --查询条件，不含where

            arParms[6] = new SqlParameter("@strWhere", SqlDbType.NVarChar, 1000);
            arParms[6].Value = strwhere;



            //@ID   --主表的主键
            arParms[7] = new SqlParameter("@masterFeilds", SqlDbType.NVarChar, 150);
            arParms[7].Value = "Editor_ID";



            //@PageCount --总页数
            arParms[8] = new SqlParameter("@totalPage", SqlDbType.Int);
            arParms[8].Direction = ParameterDirection.Output;

            //@RecordCount --总记录数
            arParms[9] = new SqlParameter("@RecordCount", SqlDbType.Int);
            arParms[9].Direction = ParameterDirection.Output;


            List<EditorDto> list = new List<EditorDto>();
            DataTable dt = null;
            DataSet ds = SqlHelper.ExecuteDataset(DataConn.ConnectionString, CommandType.StoredProcedure, "p_generalTablePage", arParms);
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {



                EditorDto editorDto = EditorDal.getDataRowToEditorDto(dr);


                list.Add(editorDto);
            }

            var totalItems = (int)arParms[9].Value;

            pager.Amount = totalItems;
            pager.Entity = list.AsQueryable();

            return pager;
        }
        #endregion
    }
}
