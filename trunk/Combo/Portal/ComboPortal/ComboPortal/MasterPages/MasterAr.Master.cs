using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.MasterPages
{
    public partial class MasterAr : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ComboUser"] != null)
                {
                    ComboUser user = (ComboUser)Session["ComboUser"];
                    uiLoginName.Text = user.UserName;
                }
            }
            else
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["ComboUser"] = null;
            Response.Redirect("default.aspx");
        }
    }
}