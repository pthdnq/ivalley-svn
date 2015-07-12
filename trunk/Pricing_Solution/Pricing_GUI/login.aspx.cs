using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pricing.BLL;
namespace Pricing_GUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_LoggedIn(object sender, EventArgs e)
        {
            if (Roles.IsUserInRole("company"))
            {
                Companies obj = new Companies();
                obj.GetCompanyByUserID(new Guid(Membership.GetUser().ProviderUserKey.ToString()));
                CodeGlobal.LogedInCompany = obj;
                Response.Redirect("Home.aspx");
            }
        }
    }
}