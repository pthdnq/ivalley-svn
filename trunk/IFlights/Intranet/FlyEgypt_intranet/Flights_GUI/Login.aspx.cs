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
        public string LoginImagePath { get { AppConfig config = new AppConfig();
                config.LoadByPrimaryKey(1);
                return config.DefaultLoginImagePath;
        } }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["ReturnUrl"] != null)
            {
                Response.Redirect("login.aspx");
            }

            if (!IsPostBack)
            {
                AppConfig config = new AppConfig();
                config.LoadByPrimaryKey(1);                
                uiLiteralMainTitle.Text = config.Title;
                uiLiteralTheme.Text = "<link rel='stylesheet' href='" + config.CssPath + "'>";
                uiLiteralWelcomeText.Text = config.Title;
            }
        }

        protected void Login1_LoggedIn(object sender, EventArgs e)
        {
            AppConfig config = new AppConfig();
            config.LoadByPrimaryKey(1);    
            LoginLog objData = new LoginLog();
            objData.AddNew();
            objData.UserID = new Guid(Membership.GetUser(((TextBox)(LoginView1.Controls[0].Controls[1].Controls[0].Controls[1])).Text).ProviderUserKey.ToString());
            objData.ActionID = 6;
            objData.LogDate = config.GetDateTimeUsingLocalZone();
            objData.Save();
        }
    }
}