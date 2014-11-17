using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod.ToLower() == "post")
            {
                string trueName = Request.Form["truename"].Trim();
                string email = Request.Form["email"].Trim();
                string sex=Request.Form["sex"].Trim();
                string userName = Request.Form["username"].Trim();
                string passWord = Request.Form["password"].Trim();
                //创建MD5 实例 
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                //将输入的字符串转换成字节数组
                byte[] bt = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passWord));
                //加密后的字符串为strMD5
                 passWord = BitConverter.ToString(bt);

                Model.Accounts_Users model = new Model.Accounts_Users();
                model.TrueName = trueName;
                model.Email = email;
                model.Sex = sex;
                model.UserName = userName;
                model.Password = passWord;
                model.EmployeeID = 0;
                model.Activity = false;
                model.Style = 1;
                model.User_iCreator = 1;
                model.User_dateCreate = DateTime.Now;
                model.User_dateExpire = DateTime.Now;
                model.User_dateValid = DateTime.Now;
                model.User_iApprover = 1;
                model.User_dateApprove = DateTime.Now;
                model.User_iApproveState = 0;
                BLL.Accounts_Users bll = new BLL.Accounts_Users();
                if (bll.Add(model) > 0)
                {
                    //添加成功
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    //失败
                    Response.Write("<script>alert('添加失败')</script>");
                }
            }
        }
    }
}