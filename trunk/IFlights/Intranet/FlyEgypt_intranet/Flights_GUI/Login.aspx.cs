using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Flight_BLL;
using System.Web.Security;

namespace Flights_GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["ReturnUrl"] != null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Login1_LoggedIn(object sender, EventArgs e)
        {
            LoginLog objData = new LoginLog();
            objData.AddNew();
            objData.UserID = new Guid(Membership.GetUser(((TextBox)(LoginView1.Controls[0].Controls[1].Controls[0].Controls[1])).Text).ProviderUserKey.ToString());
            objData.ActionID = 6;
            objData.LogDate = DateTime.Now;
            objData.Save();
        }
    }
}