using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using AppManageTool.DAL;

namespace AppManageTool.DAL
{
    public class AppInfoDAL
    {
        public List<AppInfo> GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select 
                            (1+(select count(*) from AppInfo where a.AppOrder>AppOrder)) AS AppNum,
                            ID,
                            AppName,
                            AppPath,
                            AppParam,
                            AppOrder,
                            switch(AppType=1,'执行脚本',AppType=2,'执行文件') as Type,
                            AppType,
                            IsChecked
                            from AppInfo a");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by AppOrder");
            DataTable dt = DbHelperOleDb.Query(strSql.ToString()).Tables[0];

            List<AppInfo> list = new List<AppInfo>();
            if (dt.Rows.Count > 0)
            {
                AppInfo model;
                foreach (DataRow dr in dt.Rows)
                {
                    model = DataRowToModel(dr);
                    if (model != null)
                    {
                        list.Add(model);
                    }
                }
            }
            return list;
        }

        private AppInfo DataRowToModel(DataRow row)
        {
            AppInfo model = new AppInfo();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["AppName"] != null)
                {
                    model.AppName = row["AppName"].ToString();
                }
                if (row["AppPath"] != null)
                {
                    model.AppPath = row["AppPath"].ToString();
                }
                if (row["AppParam"] != null)
                {
                    model.AppParam = row["AppParam"].ToString();
                }
                if (row["AppOrder"] != null && row["AppOrder"].ToString() != "")
                {
                    model.AppOrder = int.Parse(row["AppOrder"].ToString());
                }
                if (row["AppNum"] != null && row["AppNum"].ToString() != "")
                {
                    model.AppNum = int.Parse(row["AppNum"].ToString());
                }
                if (row["AppType"] != null && row["AppType"].ToString() != "")
                {
                    model.AppType = int.Parse(row["AppType"].ToString());
                }
                if (row["Type"] != null && row["Type"].ToString() != "")
                {
                    model.Type = row["Type"].ToString();
                }
                if (row["IsChecked"] != null && row["IsChecked"].ToString() != "")
                {
                    model.IsChecked = int.Parse(row["IsChecked"].ToString());
                }
            }
            return model;
        }

        public bool Add(AppInfo model)
        {
            int maxID = DbHelperOleDb.GetMaxID("ID", "AppInfo");

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AppInfo(");
            strSql.Append("AppName,AppPath,AppParam,AppOrder,AppType,ID)");
            strSql.Append(" values (");
            strSql.Append("@AppName,@AppPath,@AppParam,@AppOrder,@AppType,@ID)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@AppName", OleDbType.VarChar,255),
					new OleDbParameter("@AppPath", OleDbType.VarChar,255),
					new OleDbParameter("@AppParam", OleDbType.VarChar,255),
					new OleDbParameter("@AppOrder", OleDbType.Integer,4),
                    new OleDbParameter("@AppType", OleDbType.Integer,4),
                    new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.AppName;
            parameters[1].Value = model.AppPath;
            parameters[2].Value = model.AppParam;
            parameters[3].Value = maxID;
            parameters[4].Value = model.AppType;
            parameters[5].Value = maxID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteList(string idList)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AppInfo");
            strSql.Append(" where ID in (" + idList + ")");
            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(AppInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AppInfo");
            strSql.Append(" where ID =" + model.ID);
            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(AppInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AppInfo set ");
            strSql.Append("AppName=@AppName,");
            strSql.Append("AppPath=@AppPath,");
            strSql.Append("AppParam=@AppParam,");
            strSql.Append("AppType=@AppType");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@AppName", OleDbType.VarChar,255),
					new OleDbParameter("@AppPath", OleDbType.VarChar,255),
					new OleDbParameter("@AppParam", OleDbType.VarChar,255),
					new OleDbParameter("@AppType", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.AppName;
            parameters[1].Value = model.AppPath;
            parameters[2].Value = model.AppParam;
            parameters[3].Value = model.AppType;
            parameters[4].Value = model.ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改选中状态
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateChecked(AppInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AppInfo set ");
            strSql.Append("IsChecked=@IsChecked");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@IsChecked", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.IsChecked;
            parameters[1].Value = model.ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新排序
        /// </summary>
        public bool UpdateOrder(AppInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AppInfo set ");
            strSql.Append("AppOrder=@AppOrder");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@AppOrder", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.AppOrder;
            parameters[1].Value = model.ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
