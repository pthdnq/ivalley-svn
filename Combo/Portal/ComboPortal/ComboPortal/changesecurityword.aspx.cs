using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal
{
    public partial class changesecurityword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                uiPanelsuccess.Visible = false;
                uiPanelReset.Visible = true;
            }
        }

        protected void uiButtonSave_Click(object sender, EventArgs e)
        {
            ComboUser user = (ComboUser)Session["ComboUser"];
            user.SecurityWord = uiTextBoxPass.Text;
            user.Save();
            uiPanelsuccess.Visible = true;
            uiPanelReset.Visible = false;
        }
    }
}