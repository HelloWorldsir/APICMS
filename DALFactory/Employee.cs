using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;

namespace DALFactory
{
    public class Employee:DataAccessBase
    {
        public static IEmployee CreateEmployee()
        {
            string classNamespace = DataAccessBase.AssemblyPath + ".Employee";
            return (IEmployee)DataAccessBase.CreateObject(DataAccessBase.AssemblyPath, classNamespace);
        }
    }
}
