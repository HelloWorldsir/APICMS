using IDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DALFactory
{
    public class Users : DataAccessBase
    {
        public static IAccounts_Users CreateIUser()
        {
            string classNamespace = DataAccessBase.AssemblyPath + ".Accounts_Users";
            return (IAccounts_Users)DataAccessBase.CreateObject(DataAccessBase.AssemblyPath, classNamespace);
        }
    }
}
