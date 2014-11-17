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
    public partial class Employee : IEmployee
    {

        public bool Exists(int EmployeeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Employee");
            strSql.Append(" where ");
            strSql.Append(" EmployeeID = @EmployeeID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)
			};
            parameters[0].Value = EmployeeID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Employee(");
            strSql.Append("EmployeeName,EmployeeMark");
            strSql.Append(") values (");
            strSql.Append("@EmployeeName,@EmployeeMark");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@EmployeeMark", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.EmployeeName;
            parameters[1].Value = model.EmployeeMark;

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
        public bool Update(Model.Employee model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Employee set ");

            strSql.Append(" EmployeeName = @EmployeeName , ");
            strSql.Append(" EmployeeMark = @EmployeeMark  ");
            strSql.Append(" where EmployeeID=@EmployeeID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@EmployeeID", SqlDbType.Int,4) ,            
                        new SqlParameter("@EmployeeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@EmployeeMark", SqlDbType.NVarChar,50)             
              
            };

            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.EmployeeName;
            parameters[2].Value = model.EmployeeMark;
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
        public bool Delete(int EmployeeID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Employee ");
            strSql.Append(" where EmployeeID=@EmployeeID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)
			};
            parameters[0].Value = EmployeeID;


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
        public bool DeleteList(string EmployeeIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Employee ");
            strSql.Append(" where ID in (" + EmployeeIDlist + ")  ");
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
        public Model.Employee GetModel(int EmployeeID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select EmployeeID, EmployeeName, EmployeeMark  ");
            strSql.Append("  from Employee ");
            strSql.Append(" where EmployeeID=@EmployeeID");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)
			};
            parameters[0].Value = EmployeeID;


            Model.Employee model = new Model.Employee();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                model.EmployeeName = ds.Tables[0].Rows[0]["EmployeeName"].ToString();
                model.EmployeeMark = ds.Tables[0].Rows[0]["EmployeeMark"].ToString();

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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Employee ");
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
            strSql.Append(" FROM Employee ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}
