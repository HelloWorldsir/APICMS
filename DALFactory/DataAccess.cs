using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DALFactory
{
    public class DataAccess<t>
    {
        protected static readonly string AssemblyPath;

        static DataAccess()
        {
            DataAccess<t>.AssemblyPath = ConfigurationManager.AppSettings["DAL"]; 
        }
        public static t Create(string ClassName)
        {
            string classNamespace = DataAccess<t>.AssemblyPath + "." + ClassName;
            return (t)DataAccess<t>.CreateObjectNoCache(DataAccess<t>.AssemblyPath, classNamespace);
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
