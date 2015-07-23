﻿using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.ar
{
    public partial class changepassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                uiPanelsuccess.Visible = false;
                uiPanelReset.Visible = true;
                uiPanelError.Visible = false;
            }
        }

        protected void uiButtonSave_Click(object sender, EventArgs e)
        {
            ComboUser user = (ComboUser)Session["ComboUser"];
            if (user.SecurityWord == uiTextBoxSecurityWord.Text)
            {
                user.Password = uiTextBoxPass.Text;
                user.Save();
                uiPanelsuccess.Visible = true;
                uiPanelReset.Visible = false;
                uiPanelError.Visible = false;
            }
            else 
            {
                uiPanelReset.Visible = true;
                uiPanelsuccess.Visible = false;
                uiPanelError.Visible = true;
            }
            
        }
    }
}