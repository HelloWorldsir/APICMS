using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CommonCustom;
using DBUtility;

namespace SQLServerDAL
{
    public class Accounts_Users:IDAL.IAccounts_Users
    {

        public bool Exists(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Accounts_Users");
            strSql.Append(" where ");
            strSql.Append(" UserID = @UserID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Accounts_Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Accounts_Users(");
            strSql.Append("DepartmentID,Activity,UserType,Style,User_iCreator,User_dateCreate,User_dateValid,User_dateExpire,User_iApprover,User_dateApprove,UserName,User_iApproveState,User_cLang,Password,NickName,TrueName,Sex,Phone,Email,EmployeeID");
            strSql.Append(") values (");
            strSql.Append("@DepartmentID,@Activity,@UserType,@Style,@User_iCreator,@User_dateCreate,@User_dateValid,@User_dateExpire,@User_iApprover,@User_dateApprove,@UserName,@User_iApproveState,@User_cLang,@Password,@NickName,@TrueName,@Sex,@Phone,@Email,@EmployeeID");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@DepartmentID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Activity", SqlDbType.Bit,1) ,            
                        new SqlParameter("@UserType", SqlDbType.Char,2) ,            
                        new SqlParameter("@Style", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_iCreator", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_dateCreate", SqlDbType.DateTime) ,            
                        new SqlParameter("@User_dateValid", SqlDbType.DateTime) ,            
                        new SqlParameter("@User_dateExpire", SqlDbType.DateTime) ,            
                        new SqlParameter("@User_iApprover", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_dateApprove", SqlDbType.DateTime) ,            
                        new SqlParameter("@UserName", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@User_iApproveState", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_cLang", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Password", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@NickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TrueName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Sex", SqlDbType.Char,10) ,            
                        new SqlParameter("@Phone", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Email", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@EmployeeID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.DepartmentID;
            parameters[1].Value = model.Activity;
            parameters[2].Value = model.UserType;
            parameters[3].Value = model.Style;
            parameters[4].Value = model.User_iCreator;
            parameters[5].Value = model.User_dateCreate;
            parameters[6].Value = model.User_dateValid;
            parameters[7].Value = model.User_dateExpire;
            parameters[8].Value = model.User_iApprover;
            parameters[9].Value = model.User_dateApprove;
            parameters[10].Value = model.UserName;
            parameters[11].Value = model.User_iApproveState;
            parameters[12].Value = model.User_cLang;
            parameters[13].Value = model.Password;
            parameters[14].Value = model.NickName;
            parameters[15].Value = model.TrueName;
            parameters[16].Value = model.Sex;
            parameters[17].Value = model.Phone;
            parameters[18].Value = model.Email;
            parameters[19].Value = model.EmployeeID;

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
        public bool Update(Model.Accounts_Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Accounts_Users set ");

            strSql.Append(" DepartmentID = @DepartmentID , ");
            strSql.Append(" Activity = @Activity , ");
            strSql.Append(" UserType = @UserType , ");
            strSql.Append(" Style = @Style , ");
            strSql.Append(" User_iCreator = @User_iCreator , ");
            strSql.Append(" User_dateCreate = @User_dateCreate , ");
            strSql.Append(" User_dateValid = @User_dateValid , ");
            strSql.Append(" User_dateExpire = @User_dateExpire , ");
            strSql.Append(" User_iApprover = @User_iApprover , ");
            strSql.Append(" User_dateApprove = @User_dateApprove , ");
            strSql.Append(" UserName = @UserName , ");
            strSql.Append(" User_iApproveState = @User_iApproveState , ");
            strSql.Append(" User_cLang = @User_cLang , ");
            strSql.Append(" Password = @Password , ");
            strSql.Append(" NickName = @NickName , ");
            strSql.Append(" TrueName = @TrueName , ");
            strSql.Append(" Sex = @Sex , ");
            strSql.Append(" Phone = @Phone , ");
            strSql.Append(" Email = @Email , ");
            strSql.Append(" EmployeeID = @EmployeeID  ");
            strSql.Append(" where UserID=@UserID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@UserID", SqlDbType.Int,4) ,            
                        new SqlParameter("@DepartmentID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Activity", SqlDbType.Bit,1) ,            
                        new SqlParameter("@UserType", SqlDbType.Char,2) ,            
                        new SqlParameter("@Style", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_iCreator", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_dateCreate", SqlDbType.DateTime) ,            
                        new SqlParameter("@User_dateValid", SqlDbType.DateTime) ,            
                        new SqlParameter("@User_dateExpire", SqlDbType.DateTime) ,            
                        new SqlParameter("@User_iApprover", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_dateApprove", SqlDbType.DateTime) ,            
                        new SqlParameter("@UserName", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@User_iApproveState", SqlDbType.Int,4) ,            
                        new SqlParameter("@User_cLang", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Password", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@NickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@TrueName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Sex", SqlDbType.Char,10) ,            
                        new SqlParameter("@Phone", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Email", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@EmployeeID", SqlDbType.Int,4)             
              
            };

            parameters[0].Value = model.UserID;
            parameters[1].Value = model.DepartmentID;
            parameters[2].Value = model.Activity;
            parameters[3].Value = model.UserType;
            parameters[4].Value = model.Style;
            parameters[5].Value = model.User_iCreator;
            parameters[6].Value = model.User_dateCreate;
            parameters[7].Value = model.User_dateValid;
            parameters[8].Value = model.User_dateExpire;
            parameters[9].Value = model.User_iApprover;
            parameters[10].Value = model.User_dateApprove;
            parameters[11].Value = model.UserName;
            parameters[12].Value = model.User_iApproveState;
            parameters[13].Value = model.User_cLang;
            parameters[14].Value = model.Password;
            parameters[15].Value = model.NickName;
            parameters[16].Value = model.TrueName;
            parameters[17].Value = model.Sex;
            parameters[18].Value = model.Phone;
            parameters[19].Value = model.Email;
            parameters[20].Value = model.EmployeeID;
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
        public bool Delete(int UserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Accounts_Users ");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;


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
        public bool DeleteList(string UserIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Accounts_Users ");
            strSql.Append(" where ID in (" + UserIDlist + ")  ");
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
        public Model.Accounts_Users GetModel(int UserID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserID, DepartmentID, Activity, UserType, Style, User_iCreator, User_dateCreate, User_dateValid, User_dateExpire, User_iApprover, User_dateApprove, UserName, User_iApproveState, User_cLang, Password, NickName, TrueName, Sex, Phone, Email, EmployeeID  ");
            strSql.Append("  from Accounts_Users ");
            strSql.Append(" where UserID=@UserID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
            parameters[0].Value = UserID;


            Model.Accounts_Users model = new Model.Accounts_Users();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                }
                model.DepartmentID = ds.Tables[0].Rows[0]["DepartmentID"].ToString();
                if (ds.Tables[0].Rows[0]["Activity"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Activity"].ToString() == "1") || (ds.Tables[0].Rows[0]["Activity"].ToString().ToLower() == "true"))
                    {
                        model.Activity = true;
                    }
                    else
                    {
                        model.Activity = false;
                    }
                }
                model.UserType = ds.Tables[0].Rows[0]["UserType"].ToString();
                if (ds.Tables[0].Rows[0]["Style"].ToString() != "")
                {
                    model.Style = int.Parse(ds.Tables[0].Rows[0]["Style"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_iCreator"].ToString() != "")
                {
                    model.User_iCreator = int.Parse(ds.Tables[0].Rows[0]["User_iCreator"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_dateCreate"].ToString() != "")
                {
                    model.User_dateCreate = DateTime.Parse(ds.Tables[0].Rows[0]["User_dateCreate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_dateValid"].ToString() != "")
                {
                    model.User_dateValid = DateTime.Parse(ds.Tables[0].Rows[0]["User_dateValid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_dateExpire"].ToString() != "")
                {
                    model.User_dateExpire = DateTime.Parse(ds.Tables[0].Rows[0]["User_dateExpire"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_iApprover"].ToString() != "")
                {
                    model.User_iApprover = int.Parse(ds.Tables[0].Rows[0]["User_iApprover"].ToString());
                }
                if (ds.Tables[0].Rows[0]["User_dateApprove"].ToString() != "")
                {
                    model.User_dateApprove = DateTime.Parse(ds.Tables[0].Rows[0]["User_dateApprove"].ToString());
                }
                model.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["User_iApproveState"].ToString() != "")
                {
                    model.User_iApproveState = int.Parse(ds.Tables[0].Rows[0]["User_iApproveState"].ToString());
                }
                model.User_cLang = ds.Tables[0].Rows[0]["User_cLang"].ToString();
                model.Password = ds.Tables[0].Rows[0]["Password"].ToString();
                model.NickName = ds.Tables[0].Rows[0]["NickName"].ToString();
                model.TrueName = ds.Tables[0].Rows[0]["TrueName"].ToString();
                model.Sex = ds.Tables[0].Rows[0]["Sex"].ToString();
                model.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }

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
            strSql.Append(" FROM Accounts_Users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取用户数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetUserList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Accounts_Users,Employee ");
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
            strSql.Append(" FROM Accounts_Users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Login(Model.Accounts_Users model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select count(*) ");
            sb.Append(" from Accounts_Users ");
            sb.Append(" where ");
            sb.Append(" UserName=@username and");
            sb.Append(" Password=@password");
            SqlParameter[] para = {
                                      new SqlParameter("@username",SqlDbType.NVarChar,50),
                                      new SqlParameter("@password",SqlDbType.NVarChar,50)
                                  };
            para[0].Value = model.UserName;
            para[1].Value = model.Password;
            DataSet ds= DBUtility.DbHelperSQL.Query(sb.ToString(),para);
            if (ds.Tables[0].Rows.Count > 0&&Convert.ToInt32( ds.Tables[0].Rows[0][0])>0)
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
