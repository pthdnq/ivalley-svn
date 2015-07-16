﻿using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.Admin
{
    public partial class EditUser : System.Web.UI.Page
    {
        int CurrentUser
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["uid"]))
                    return int.Parse(Request.QueryString["uid"].ToString());
                else
                    return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (CurrentUser > 0)
                    loadUser();
                else
                    Response.Redirect("UserManagement.aspx");
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            PanelProfile.Visible = true;
            PanelResetSecretWord.Visible = false;
            PanelResetPass.Visible = false;
            PanelPosts.Visible = false;
        }
        protected void btnSavePass_Click(object sender, EventArgs e)
        {
            ComboUser objData = new ComboUser();
            objData.LoadByPrimaryKey(CurrentUser);
            objData.Password = txtUserPassword.Text;
            objData.Save();

            PanelProfile.Visible = true;
            PanelResetSecretWord.Visible = false;
            PanelResetPass.Visible = false;
            PanelPosts.Visible = false;

        }
        protected void bindPosts()
        {
            ComboPost objData = new ComboPost();
            objData.GetUserPostByUserID(CurrentUser);
            RepeaterUserPosts.DataSource = objData.DefaultView;
            RepeaterUserPosts.DataBind();
        }
        protected void RepeaterUserPosts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "deletePost":
                    ComboPost objData = new ComboPost();
                    objData.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                    objData.IsDeleted = true;
                    objData.Save();
                    bindPosts();
                    break;
                default:
                    break;
            }
        }
        protected void btnViewPosts_Click(object sender, EventArgs e)
        {
            PanelProfile.Visible = false;
            PanelPosts.Visible = true;
            PanelResetSecretWord.Visible = false;
            PanelResetPass.Visible = false;
            bindPosts();
        }
        protected void btnResetPass_Click(object sender, EventArgs e)
        {
            PanelProfile.Visible = false;
            PanelPosts.Visible = false;
            PanelResetSecretWord.Visible = false;
            PanelResetPass.Visible = true;
        }
        protected void btnChangeSecretWord_Click(object sender, EventArgs e)
        {
            ComboUser objData = new ComboUser();
            objData.LoadByPrimaryKey(CurrentUser);
            objData.SecurityWord = txtSecretWord.Text;
            objData.Save();

            PanelProfile.Visible = true;
            PanelResetPass.Visible = false;
            PanelPosts.Visible = false;
            PanelResetSecretWord.Visible = false;

        }
        protected void btnResetSecureWord_Click(object sender, EventArgs e)
        {
            PanelProfile.Visible = false;
            PanelPosts.Visible = false;
            PanelResetSecretWord.Visible = true;
            PanelResetPass.Visible = false;
        }
        protected void loadUser()
        {
            loadCountry();
            loadGender();

            ComboUser objData = new ComboUser();
            objData.LoadByPrimaryKey(CurrentUser);

            lblUserName.Text = objData.UserName;
            lblDisplayName.Text = objData.DisplayName;
            lblEmail.Text = objData.Email;
            if (!objData.IsColumnNull(ComboUser.ColumnNames.GenderID))
                drpDwnGender.SelectedValue = objData.GenderID.ToString();

            if (!objData.IsColumnNull(ComboUser.ColumnNames.CountryID))
                drpDwnCountry.SelectedValue = objData.CountryID.ToString();

            lblTelephone.Text = objData.Phone;
            lblWebsite.Text = objData.Website;

            if (!objData.IsColumnNull(ComboUser.ColumnNames.BirthDate))
                lblBirthday.Text = objData.BirthDate.ToShortDateString();

            literalBio.Text = objData.Bio;
            if (!objData.IsColumnNull(ComboUser.ColumnNames.ProfileImgID))
            {
                Attachment objData2 = new Attachment();
                objData2.LoadByPrimaryKey(objData.ProfileImgID);
                ImgUser.Src = objData2.Path;
            }

            if (!objData.IsColumnNull(ComboUser.ColumnNames.IsVerified))
            {
                if (objData.IsVerified == true)
                {
                    DivAccountNotVerified.Visible = false;
                    DivAccountVerified.Visible = true;
                }
                else if (objData.IsVerified == false)
                {
                    DivAccountNotVerified.Visible = true;
                    DivAccountVerified.Visible = false;
                }
            }
            else
            {
                DivAccountNotVerified.Visible = true;
                DivAccountVerified.Visible = false;
            }
            if (!objData.IsColumnNull(ComboUser.ColumnNames.CreatedDate))
            {
                lblCreatedDate.Text = objData.CreatedDate.ToString("DD/mm/YYYY");
            }

            updateCounters();
        }
        protected void loadGender()
        {
            Gender objData = new Gender();
            objData.LoadAll();
            drpDwnGender.DataTextField = Gender.ColumnNames.Name;
            drpDwnGender.DataValueField = Gender.ColumnNames.GenderID;
            drpDwnGender.DataSource = objData.DefaultView;
            drpDwnGender.DataBind();
            drpDwnGender.Items.Insert(0, new ListItem("Select Gender", "0"));
        }
        protected void loadCountry()
        {
            Country objData = new Country();
            objData.LoadAll();
            drpDwnCountry.DataTextField = Country.ColumnNames.Name;
            drpDwnCountry.DataValueField = Country.ColumnNames.CountryID;
            drpDwnCountry.DataSource = objData.DefaultView;
            drpDwnCountry.DataBind();
            drpDwnCountry.Items.Insert(0, new ListItem("Select Country", "0"));
        }
        protected void updateCounters()
        {
            ComboUser objData = new ComboUser();
            objData.GetUserStatisticsByUserId(CurrentUser);
            objData.GetColumn("PostsCount");
            objData.GetColumn("FollowersCount");
            objData.GetColumn("FollowingsCount");

            lblPostsCounter.Text = objData.GetColumn("PostsCount").ToString();
            lblFollowersCounter.Text = objData.GetColumn("FollowersCount").ToString();
            lblFollowingCounter.Text = objData.GetColumn("FollowingsCount").ToString();

        }

        protected void btnDisableVerification_Click(object sender, EventArgs e)
        {
            ComboUser objData = new ComboUser();
            objData.LoadByPrimaryKey(CurrentUser);
            objData.IsVerified = false;
            objData.Save();
            loadUser();
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            ComboUser objData = new ComboUser();
            objData.LoadByPrimaryKey(CurrentUser);
            objData.IsVerified = true;
            objData.Save();
            loadUser();
        }

        protected void btnDeletePosts_Click(object sender, EventArgs e)
        {
            ComboPost objData = new ComboPost();
            objData.Where.ComboUserID.Value = CurrentUser;
            objData.Where.ComboUserID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            objData.Query.Load();

            objData.Rewind();
            for (int i = 0; i < objData.RowCount; i++)
            {
                objData.IsDeleted = true;
                objData.MoveNext();
            }
            objData.Save();

            updateCounters();
        }

        protected void btnDeleteFollowers_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnDeleteFollowing_Click(object sender, EventArgs e)
        {

        }
    }
}