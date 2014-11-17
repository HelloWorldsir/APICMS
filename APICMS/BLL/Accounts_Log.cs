using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonCustom;
using System.Data;

namespace BLL
{
    //Accounts_Log
		public partial class Accounts_Log
	{
		private readonly IAccounts_Log dal=DALFactory.Accounts_Log.CreateAccounts_Log();
		public Accounts_Log()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Accounts_Log model)
		{
			return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.Accounts_Log model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Accounts_Log GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.Accounts_Log GetModelByCache(int ID)
		{
			
			string CacheKey = "Accounts_LogModel-" + ID;
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
						DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Model.Accounts_Log)objModel;
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Accounts_Log> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Accounts_Log> DataTableToList(DataTable dt)
		{
			List<Model.Accounts_Log> modelList = new List<Model.Accounts_Log>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.Accounts_Log model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.Accounts_Log();					
				if(dt.Rows[n]["ID"].ToString()!="")
				{
					model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
				}
				if(dt.Rows[n]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(dt.Rows[n]["UserID"].ToString());
				}
				model.OperModuel= dt.Rows[n]["OperModuel"].ToString();
				model.ChildModuel= dt.Rows[n]["ChildModuel"].ToString();
				model.IP= dt.Rows[n]["IP"].ToString();
				model.OperResult= dt.Rows[n]["OperResult"].ToString();
                model.UserName = dt.Rows[n]["UserName"].ToString();																		
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

