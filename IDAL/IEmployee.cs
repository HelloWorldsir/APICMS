using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IEmployee
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int EmployeeID);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Model.Employee model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(Model.Employee model);
        /// <summary>
        /// 删除数据
        /// </summary>
        bool Delete(int EmployeeID);
        bool DeleteList(string EmployeeIDlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Model.Employee GetModel(int EmployeeID);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法
    }
}
