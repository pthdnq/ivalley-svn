﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GlobalLogistics.WebSite.Controls
{
    public partial class Times : System.Web.UI.UserControl
    {
        public string Currentlang
        {
            get
            {
                if (Session["CurrentLang"] != null && !string.IsNullOrEmpty(Session["CurrentLang"].ToString()))
                {
                    return Session["CurrentLang"].ToString();
                }
                else
                {
                    return "EN";
                }
            }

            set { Session["CurrentLang"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Currentlang == "EN")
                {
                    EnPanel.Visible = true;
                    ArPanel.Visible = false;
                    BindEnglishData();
                }
                else if (Currentlang == "AR")
                {
                    EnPanel.Visible = false;
                    ArPanel.Visible = true;
                    BindArabicData();
                }
            }
        }

        private void BindArabicData()
        {
            
        }

        private void BindEnglishData()
        {
            
        }
    }
}