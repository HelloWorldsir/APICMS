using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonCustom;
using Web.Admin.common;
using System.Data;

namespace Web.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod.ToLower() == "post")
            {
                string username = Request.Form["username"].Trim();
                string password = Request.Form["password"].Trim();
                password= EncodeHelp.Md5Help(password);
                Model.Accounts_Users users = new Model.Accounts_Users();
                users.UserName = username;
                users.Password = password;
                BLL.Accounts_Users bll = new BLL.Accounts_Users();
                DataTable dt = bll.GetList("UserName='"+username+"' and Password='"+password+"'").Tables[0];
                if (dt.Rows.Count>0)
                {
                    users.UserID=Convert.ToInt32( dt.Rows[0]["UserID"]);
                    LogOper.AddLog(users.UserID.ToString(), "登录", "用户登录", IpHelper.GetUserIp(),"true");
                    Response.Redirect("index.aspx");
                }
                else
                {
                    users.UserID =0;
                    LogOper.AddLog(users.UserID.ToString(), "登录", "用户登录", IpHelper.GetUserIp(), "false");
                    Response.Write("<script>alert('登录失败')</script>");
                }
            }
        }
    }
}