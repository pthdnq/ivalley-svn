﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E3zmni.BLL;

namespace E3zemni_WebGUI.MasterPages
{
    public partial class Ar : System.Web.UI.MasterPage
    {
        public string PageTitle
        {
            get
            {
                return uiLabelTitle.Text;
            }
            set
            {
                uiLabelTitle.Text = value;
                uiLabelTopTitle.Text = value;
            }
        }

        public string Path
        {
            get
            {
                return uiLiteralSubPath.Text;
            }
            set
            {
                uiLiteralSubPath.Text = value;
            }
        }

        public bool ViewPath { get { return uiPanelBreadcrumb.Visible; } set { uiPanelBreadcrumb.Visible = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentUser"] != null)
            {
                lbtnLogin.Visible = false;
                lbtnLogout.Visible = true;
                lbtnProfile.Visible = true;

            }
            else
            {
                lbtnLogin.Visible = true;
                lbtnLogout.Visible = false;
                lbtnProfile.Visible = false;

            }

            UserPayement temp = (UserPayement)Session["UserPayment"];
            if (temp == null)
                uiLabelItemsCount.Text = "0";
            else
                uiLabelItemsCount.Text = temp.RowCount.ToString();

        }

        protected void uiLinkButtonEn_Click(object sender, EventArgs e)
        {            
            Response.Redirect(Request.RawUrl.Replace("/ar", ""));
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            if (Session["CurrentUser"] != null)
            {
                Session.Remove("CurrentUser");
                lbtnLogin.Visible = true;
                lbtnLogout.Visible = false;
                lbtnProfile.Visible = false;
                Response.Redirect("default.aspx");
            }

        }
    }
}