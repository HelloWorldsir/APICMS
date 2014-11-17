using DBUtility;
using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SQLServerDAL
{
    //Accounts_Log
    public partial class Accounts_Log : IAccounts_Log
    {

        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Accounts_Log");
            strSql.Append(" where ");
            strSql.Append(" ID = @ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Accounts_Log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Accounts_Log(");
            strSql.Append("UserID,OperModuel,ChildModuel,IP,OperResult,OperTime");
            strSql.Append(") values (");
            strSql.Append("@UserID,@OperModuel,@ChildModuel,@IP,@OperResult,@OperTime");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@UserID", SqlDbType.Int,4) ,            
                        new SqlParameter("@OperModuel", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ChildModuel", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@IP", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OperResult", SqlDbType.NVarChar,50),             
                        new SqlParameter("@OperTime",SqlDbType.DateTime)
            };

            parameters[0].Value = model.UserID;
            parameters[1].Value = model.OperModuel;
            parameters[2].Value = model.ChildModuel;
            parameters[3].Value = model.IP;
            parameters[4].Value = model.OperResult;
            parameters[5].Value = model.OperTime;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {

                return Convert.ToInt32(obj);

            }

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Accounts_Log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Accounts_Log set ");

            strSql.Append(" UserID = @UserID , ");
            strSql.Append(" OperModuel = @OperModuel , ");
            strSql.Append(" ChildModuel = @ChildModuel , ");
            strSql.Append(" IP = @IP , ");
            strSql.Append(" OperResult = @OperResult  ");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.Int,4) ,            
                        new SqlParameter("@UserID", SqlDbType.Int,4) ,            
                        new SqlParameter("@OperModuel", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ChildModuel", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@IP", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OperResult", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.OperModuel;
            parameters[3].Value = model.ChildModuel;
            parameters[4].Value = model.IP;
            parameters[5].Value = model.OperResult;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Accounts_Log ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Accounts_Log ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        /// 得到一个对象实体
        /// </summary>
        public Model.Accounts_Log GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, UserID, OperModuel, ChildModuel, IP, OperResult,OperTime  ");
            strSql.Append("  from Accounts_Log ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;


            Model.Accounts_Log model = new Model.Accounts_Log();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                }
                model.OperModuel = ds.Tables[0].Rows[0]["OperModuel"].ToString();
                model.ChildModuel = ds.Tables[0].Rows[0]["ChildModuel"].ToString();
                model.IP = ds.Tables[0].Rows[0]["IP"].ToString();
                model.OperResult = ds.Tables[0].Rows[0]["OperResult"].ToString();
                model.OperTime =DateTime.Parse( ds.Tables[0].Rows[0]["OperTime"].ToString());
                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            //select Accounts_Users.UserName,Accounts_Log.* from Accounts_Users,Accounts_Log where Accounts_Log.UserID=Accounts_Users.UserID
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Accounts_Users.UserName,Accounts_Log.* ");
            strSql.Append(" from Accounts_Users,Accounts_Log ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM Accounts_Log ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

