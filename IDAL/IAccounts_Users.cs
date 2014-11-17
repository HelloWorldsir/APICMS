using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IAccounts_Users
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int UserID);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Model.Accounts_Users model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(Model.Accounts_Users model);
        /// <summary>
        /// 删除数据
        /// </summary>
        bool Delete(int UserID);
        bool DeleteList(string UserIDlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Model.Accounts_Users GetModel(int UserID);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        DataSet GetUserList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法
        bool Login(Model.Accounts_Users model);
       
    }
}
