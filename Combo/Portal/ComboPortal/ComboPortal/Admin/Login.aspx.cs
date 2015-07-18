using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            AdminLogin objData = new AdminLogin();
            objData.Where.AdminUserName.Value = UserName.Text;
            objData.Where.AdminUserName.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            objData.Where.AdminUserName.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            objData.Where.AdminPassword.Value = Password.Text;
            objData.Where.AdminPassword.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            objData.Query.Load();

            if (objData.RowCount>0)
            {
                Session["Admin"] = objData.AdminName;
                Response.Redirect("EditUser.aspx");
            }
        }
    }
}