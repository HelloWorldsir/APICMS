using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin.MemberManagement
{
    public partial class MemberList : System.Web.UI.Page
    {
        public List<Model.Accounts_Users> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Accounts_Users bll = new BLL.Accounts_Users();
            list = bll.GetUserModelList(" Employee.EmployeeID=Accounts_Users.EmployeeID");
            if (Request.HttpMethod.ToLower() == "get")
            {
                string idarry = Request.QueryString["id"] ;
                if (!String.IsNullOrEmpty(idarry))
                {
                    //1,2,4,5,
                    if (bll.DeleteList(idarry))
                    {
                        Response.Write("<script>alert(删除成功)</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert(删除失败)</script>");
                    }
                }

            }
        }
    }
}