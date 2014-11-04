using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppManageTool.Model;
using System.Data.OleDb;
using System.Data;

namespace AppManageTool.DAL
{
    /// <summary>
    /// 配置信息数据类
    /// </summary>
    public class ConfigDAL
    {
        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(Config model)
        {
            int maxID = DbHelperOleDb.GetMaxID("ID", "Config");

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Config(");
            strSql.Append("ConName,ConValue,ID,ConType)");
            strSql.Append(" values (");
            strSql.Append("@ConName,@ConValue,@ID,@ConType)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ConName", OleDbType.VarChar,255),
					new OleDbParameter("@ConValue", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4),
                    new OleDbParameter("@ConType",OleDbType.VarChar,255)};
            parameters[0].Value = model.ConName;
            parameters[1].Value = model.ConValue;
            parameters[2].Value = maxID;
            parameters[3].Value = model.ConType;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Config set ");
            strSql.Append("ConName=@ConName,");
            strSql.Append("ConValue=@ConValue,");
            strSql.Append("ConType=@ConType");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ConName", OleDbType.VarChar,255),
					new OleDbParameter("@ConValue", OleDbType.VarChar,255),
                    new OleDbParameter("@ConType",OleDbType.VarChar,255),                                          
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.ConName;
            parameters[1].Value = model.ConValue;
            parameters[2].Value = model.ConType;
            parameters[3].Value = model.ID;

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
        /// 批量更新配置数据
        /// </summary>
        /// <returns></returns>
        public void BatchUpdate(List<Config> configList)
        {
            foreach (Config config in configList)
            {
                string selSql = "select * from Config where ID=@ID";
                OleDbParameter parameter = new OleDbParameter("@ID", OleDbType.Integer);
                parameter.Value = config.ID;
                bool isExist = DbHelperOleDb.Exists(selSql, parameter);
                if (isExist)
                {
                    Update(config);
                }
                else
                {
                    Add(config);
                }
            }
        }

        /// <summary>
        /// 获取配置信息列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<Config> GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select 
                            ID,
                            ConName,
                            ConValue,
                            ConType
                            from Config");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DataTable dt = DbHelperOleDb.Query(strSql.ToString()).Tables[0];

            List<Config> list = new List<Config>();
            if (dt.Rows.Count > 0)
            {
                Config model;
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

        private Config DataRowToModel(DataRow row)
        {
            Config model = new Config();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["ConName"] != null)
                {
                    model.ConName = row["ConName"].ToString();
                }
                if (row["ConValue"] != null)
                {
                    model.ConValue = row["ConValue"].ToString();
                }
                if (row["ConType"] != null)
                {
                    model.ConType = row["ConType"].ToString();
                }
            }
            return model;
        }

        public Config GetByConName(string conName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select 
                            ID,
                            ConName,
                            ConValue,
                            ConType
                            from Config");
            OleDbParameter param = null;
            if (conName.Trim() != "")
            {
                strSql.Append(" where ConName=@ConName");
                param = new OleDbParameter("@ConName", OleDbType.VarChar, 255);
                param.Value = conName;
            }
            DataTable dt = DbHelperOleDb.Query(strSql.ToString(), param).Tables[0];

            Config model = null;
            if (dt.Rows.Count > 0)
            {
                model = DataRowToModel(dt.Rows[0]);
            }
            return model;
        }
    }
}
