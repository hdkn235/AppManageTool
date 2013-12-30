using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace AppManageTool
{
    public class AppInfoService
    {
        public List<AppInfo> GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from AppInfo");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by AppOrder");
            DataTable dt = AccessHelper.GetDataSet(strSql.ToString()).Tables[0];

            List<AppInfo> list = new List<AppInfo>();
            if (dt.Rows.Count >0 )
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
                if (row["AppType"] != null && row["AppType"].ToString() != "")
                {
                    model.AppType = int.Parse(row["AppType"].ToString());
                }
            }
            return model;
        }

        public bool Add(AppInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AppInfo(");
            strSql.Append("AppName,AppPath,AppParam,AppOrder,AppType)");
            strSql.Append(" values (");
            strSql.Append("@AppName,@AppPath,@AppParam,@AppOrder,@AppType)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@AppName", OleDbType.VarChar,255),
					new OleDbParameter("@AppPath", OleDbType.VarChar,255),
					new OleDbParameter("@AppParam", OleDbType.VarChar,255),
					new OleDbParameter("@AppOrder", OleDbType.Integer,4),
                    new OleDbParameter("@AppType", OleDbType.Integer,4)};
            parameters[0].Value = model.AppName;
            parameters[1].Value = model.AppPath;
            parameters[2].Value = model.AppParam;
            parameters[3].Value = model.AppOrder;
            parameters[4].Value = model.AppType;

            int rows = AccessHelper.ExecuteNonQuery(strSql.ToString(), parameters);
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
