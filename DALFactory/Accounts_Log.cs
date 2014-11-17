using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALFactory
{
    public class Accounts_Log : DataAccessBase
    {
        public static IAccounts_Log CreateAccounts_Log()
        {
            string classNamespace = DataAccessBase.AssemblyPath + ".Accounts_Log";
            return (IAccounts_Log)DataAccessBase.CreateObject(DataAccessBase.AssemblyPath, classNamespace);
        }
    }
}
