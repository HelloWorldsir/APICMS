using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin.MemberManagement
{
    public partial class EditMember : System.Web.UI.Page
    {
        public List<Model.Employee> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Employee bll = new BLL.Employee();
            list = bll.GetModelList("");
            string personalinfo=Request.QueryString[""];
        }
    }
}