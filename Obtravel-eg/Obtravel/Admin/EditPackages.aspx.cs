﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace Obtravel.Admin
{
    public partial class EditPackages : System.Web.UI.Page
    {
        public int CurrentPackage
        {
            get
            {
                if (Session["CurrentPackage"] != null && !string.IsNullOrEmpty(Session["CurrentPackage"].ToString()) && Session["CurrentPackage"].ToString() != "0")
                {
                    return Convert.ToInt32(Session["CurrentPackage"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["CurrentPackage"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CurrentUser"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
            Session["FCKeditor:UserFilesPath"] = ConfigurationManager.AppSettings["UserFilePath"];
            uiPanelViewPackages.Visible = true;
            uiPanelEditPackage.Visible = false;
            BindData();
        }

        private void BindData()
        {
            DBLayer db = new DBLayer();
            uiRepeaterCurrentPackages.DataSource = db.GetEnglishPackages();
            uiRepeaterCurrentPackages.DataBind();
        }

        protected void uiLinkButtonAdd_Click(object sender, EventArgs e)
        {
            uiPanelViewPackages.Visible = false;
            uiPanelEditPackage.Visible = true;
            ClearFields();
        }

        private void ClearFields()
        {
            uiTextBoxPackageName.Text = "";
            uiTextBoxBrief.Text = "";
            uiTextBoxOrder.Text = "";
        }

        protected void uiLinkButtonUpdate_Click(object sender, EventArgs e)
        {
            DBLayer db = new DBLayer();
            string imagepath = "";
            if (uiFileUploadImage.HasFile)
            {
                uiFileUploadImage.SaveAs(Server.MapPath(ConfigurationManager.AppSettings["UserFilePath"] + "UploadedImages/" + uiFileUploadImage.FileName));
                imagepath = ConfigurationManager.AppSettings["UserFilePath"] + "UploadedImages/" + uiFileUploadImage.FileName;
            }
            // update
            if (CurrentPackage != 0)
            {
                DataSet ds = new DataSet();
                ds = db.GetPackageContent(CurrentPackage);
                string temp = ds.Tables[0].Rows[0]["Imagepath"].ToString();
                if (temp != imagepath && string.IsNullOrEmpty(imagepath))
                    db.SetEnglishPackageContent(CurrentPackage, uiTextBoxBrief.Text, Server.HtmlEncode(uiFCKeditorContent.Value), uiTextBoxPackageName.Text, temp, Convert.ToInt32(uiTextBoxOrder.Text));
                else
                    db.SetEnglishPackageContent(CurrentPackage, uiTextBoxBrief.Text, Server.HtmlEncode(uiFCKeditorContent.Value), uiTextBoxPackageName.Text, imagepath, Convert.ToInt32(uiTextBoxOrder.Text));
            }
            else // add new
            {
                db.AddEnglishPackageContent(uiTextBoxBrief.Text, Server.HtmlEncode(uiFCKeditorContent.Value), uiTextBoxPackageName.Text, imagepath, Convert.ToInt32(uiTextBoxOrder.Text));
            }
            uiPanelViewPackages.Visible = true;
            uiPanelEditPackage.Visible = false;
            ClearFields();
            CurrentPackage = 0;
            BindData();
        }

        protected void uiLinkButtonCancel_Click(object sender, EventArgs e)
        {
            uiPanelViewPackages.Visible = true;
            uiPanelEditPackage.Visible = false;
            ClearFields();
        }

        protected void uiRepeaterPackages_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "EditPackage")
            {
                CurrentPackage = Convert.ToInt32(e.CommandArgument.ToString());
                DBLayer db = new DBLayer();
                DataSet ds = new DataSet();
                ds = db.GetPackageContent(CurrentPackage);
                uiTextBoxBrief.Text = ds.Tables[0].Rows[0]["Brief"].ToString();
                uiTextBoxOrder.Text = ds.Tables[0].Rows[0]["Order"].ToString();
                uiTextBoxPackageName.Text = ds.Tables[0].Rows[0]["PackageName"].ToString();
                uiFCKeditorContent.Value = Server.HtmlDecode(ds.Tables[0].Rows[0]["Content"].ToString());
                if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["Imagepath"].ToString()))
                {
                    uiImageCurrent.ImageUrl = ds.Tables[0].Rows[0]["Imagepath"].ToString();
                    uiImageCurrent.Visible = true;
                }
                else
                {
                    uiImageCurrent.Visible = false;
                }
                uiPanelViewPackages.Visible = false;
                uiPanelEditPackage.Visible = true;
            }
            else if (e.CommandName == "DeletePackage")
            {
                DBLayer db = new DBLayer();
                db.DeletePackage(Convert.ToInt32(e.CommandArgument.ToString()));
                BindData();
            }
            else if (e.CommandName == "EditSubPackage")
            {
                Session["Parentpackage"] = e.CommandArgument.ToString();
                Response.Redirect("EditTourismLists.aspx");
            }

        }
    }
}