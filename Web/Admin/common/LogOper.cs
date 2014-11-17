using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Admin.common
{
    public static class LogOper
    {
        public static bool AddLog(string userID, string operModule, string childModule, string IP, string result)
        {
            Model.Accounts_Log model = new Model.Accounts_Log();
            model.UserID = Convert.ToInt32(userID);
            model.OperModuel = operModule;
            model.ChildModuel = childModule;
            model.IP = IP;
            model.OperResult = result;
            model.OperTime = DateTime.Now;
            BLL.Accounts_Log bll = new BLL.Accounts_Log();
            if (bll.Add(model) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}