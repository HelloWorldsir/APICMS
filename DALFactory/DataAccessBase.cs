using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using CommonCustom;

namespace DALFactory
{
    public class DataAccessBase
    {
        protected static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];

        protected static object CreateObject(string AssemblyPath, string classNamespace)
        {
            object cache = DataCache.GetCache(classNamespace);
            if (cache == null)
            {
                try
                {
                    cache = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                    DataCache.SetCache(classNamespace, cache);
                }
                catch
                {
                }
            }
            return cache;
        }

        protected static object CreateObjectNoCache(string AssemblyPath, string classNamespace)
        {
            try
            {
                return Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
            }
            catch
            {
                return null;
            }
        }
    }
}
