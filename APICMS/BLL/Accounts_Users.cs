using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using CommonCustom;

namespace BLL
{
    public partial class Accounts_Users
    {
        private readonly IDAL.IAccounts_Users dal = DALFactory.Users.CreateIUser();
        public Accounts_Users() { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int UserID)
        {
            
            return dal.Exists(UserID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Accounts_Users model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Accounts_Users model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int UserID)
        {

            return dal.Delete(UserID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string UserIDlist)
        {
            return dal.DeleteList(UserIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Accounts_Users GetModel(int UserID)
        {

            return dal.GetModel(UserID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.Accounts_Users GetModelByCache(int UserID)
        {

            string CacheKey = "Accounts_UsersModel-" + UserID;
            object objModel = DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(UserID);
                    if (objModel != null)
                    {
                        int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
                        
                        DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.Accounts_Users)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Accounts_Users> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<Model.Accounts_Users> GetUserModelList(string strWhere)
        {
            DataSet ds = dal.GetUserList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Accounts_Users> DataTableToList(DataTable dt)
        {
            List<Model.Accounts_Users> modelList = new List<Model.Accounts_Users>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.Accounts_Users model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.Accounts_Users();
                    if (dt.Rows[n]["UserID"].ToString() != "")
                    {
                        model.UserID = int.Parse(dt.Rows[n]["UserID"].ToString());
                    }
                    if (dt.Rows[n]["DepartmentID"] != null && dt.Rows[n]["DepartmentID"].ToString() != "")
                    {
                        model.DepartmentID = dt.Rows[n]["DepartmentID"].ToString();
                    }
                    if (dt.Rows[n]["Activity"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Activity"].ToString() == "1") || (dt.Rows[n]["Activity"].ToString().ToLower() == "true"))
                        {
                            model.Activity = true;
                        }
                        else
                        {
                            model.Activity = false;
                        }
                    }
                    model.UserType = dt.Rows[n]["UserType"].ToString();
                    if (dt.Rows[n]["Style"].ToString() != "")
                    {
                        model.Style = int.Parse(dt.Rows[n]["Style"].ToString());
                    }
                    if (dt.Rows[n]["User_iCreator"].ToString() != "")
                    {
                        model.User_iCreator = int.Parse(dt.Rows[n]["User_iCreator"].ToString());
                    }
                    if (dt.Rows[n]["User_dateCreate"].ToString() != "")
                    {
                        model.User_dateCreate = DateTime.Parse(dt.Rows[n]["User_dateCreate"].ToString());
                    }
                    if (dt.Rows[n]["User_dateValid"].ToString() != "")
                    {
                        model.User_dateValid = DateTime.Parse(dt.Rows[n]["User_dateValid"].ToString());
                    }
                    if (dt.Rows[n]["User_dateExpire"].ToString() != "")
                    {
                        model.User_dateExpire = DateTime.Parse(dt.Rows[n]["User_dateExpire"].ToString());
                    }
                    if (dt.Rows[n]["User_iApprover"].ToString() != "")
                    {
                        model.User_iApprover = int.Parse(dt.Rows[n]["User_iApprover"].ToString());
                    }
                    if (dt.Rows[n]["User_dateApprove"].ToString() != "")
                    {
                        model.User_dateApprove = DateTime.Parse(dt.Rows[n]["User_dateApprove"].ToString());
                    }
                    model.UserName = dt.Rows[n]["UserName"].ToString();
                    if (dt.Rows[n]["User_iApproveState"].ToString() != "")
                    {
                        model.User_iApproveState = int.Parse(dt.Rows[n]["User_iApproveState"].ToString());
                    }
                    model.User_cLang = dt.Rows[n]["User_cLang"].ToString();
                    model.Password = dt.Rows[n]["Password"].ToString();
                    model.NickName = dt.Rows[n]["NickName"].ToString();
                    model.TrueName = dt.Rows[n]["TrueName"].ToString();
                    model.Sex = dt.Rows[n]["Sex"].ToString();
                    model.Phone = dt.Rows[n]["Phone"].ToString();
                    model.Email = dt.Rows[n]["Email"].ToString();
                    model.EmployeeName = dt.Rows[n]["EmployeeName"].ToString();
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    

                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion
   
        public bool Login(Model.Accounts_Users model)
        {
            return dal.Login(model);
        }
    }
}
