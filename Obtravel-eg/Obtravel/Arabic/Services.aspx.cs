﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Obtravel.Arabic
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["SID"] != null && !string.IsNullOrEmpty(Request.QueryString["SID"]))
                {
                    uiPanelAllServices.Visible = false;
                    uiPanelViewService.Visible = true;
                    int id = Convert.ToInt32(Request.QueryString["SID"].ToString());
                    DBLayer db = new DBLayer();
                    DataSet ds = new DataSet();
                    ds = db.GetServicesContent(id);
                    uiImageService.ImageUrl = ds.Tables[0].Rows[0]["arImagePath"].ToString();
                    uiLabelTitle.Text = ds.Tables[0].Rows[0]["arTitle"].ToString();
                    uiLiteralBrief.Text = ds.Tables[0].Rows[0]["arBrief"].ToString();
                    uiLiteralContent.Text = Server.HtmlDecode(ds.Tables[0].Rows[0]["arContent"].ToString());
                }
                else
                {
                    uiPanelAllServices.Visible = true;
                    uiPanelViewService.Visible = false;
                    BindData();
                }
            }
            RegisterStartupScript("menu", "<script type='text/javascript'>$(\"#m4\").addClass(\"selected\");</script>");
        }

        private void BindData()
        {
            DBLayer db = new DBLayer();
            uiRepeaterCurrentServices.DataSource = db.GetArabicServices();
            uiRepeaterCurrentServices.DataBind();
        }
    }
}