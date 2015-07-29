using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.Admin
{
    public partial class AdminMasterAr : System.Web.UI.MasterPage
    {
        public string PageTitle { set { uiLabelTitle.Text = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}