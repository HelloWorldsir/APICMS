using IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class Employee
    {
        private readonly IEmployee dal = DALFactory.Employee.CreateEmployee();
        public Employee()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int EmployeeID)
        {
            return dal.Exists(EmployeeID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Employee model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Employee model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int EmployeeID)
        {

            return dal.Delete(EmployeeID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string EmployeeIDlist)
        {
            return dal.DeleteList(EmployeeIDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Employee GetModel(int EmployeeID)
        {

            return dal.GetModel(EmployeeID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.Employee GetModelByCache(int EmployeeID)
        {

            string CacheKey = "EmployeeModel-" + EmployeeID;
            object objModel = CommonCustom.DataCache.GetCache(CacheKey);
            
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(EmployeeID);
                    if (objModel != null)
                    {
                        int ModelCache = CommonCustom.ConfigHelper.GetConfigInt("ModelCache");
                        CommonCustom.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Model.Employee)objModel;
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
        public List<Model.Employee> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Employee> DataTableToList(DataTable dt)
        {
            List<Model.Employee> modelList = new List<Model.Employee>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.Employee model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.Employee();
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    model.EmployeeName = dt.Rows[n]["EmployeeName"].ToString();
                    model.EmployeeMark = dt.Rows[n]["EmployeeMark"].ToString();


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

    }
}