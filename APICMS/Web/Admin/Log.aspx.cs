using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class Log : System.Web.UI.Page
    {
        public List<Model.Accounts_Log> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Accounts_Log bll = new BLL.Accounts_Log();
            list = bll.GetModelList(" Accounts_Log.UserID=Accounts_Users.UserID ");
        }
    }
}