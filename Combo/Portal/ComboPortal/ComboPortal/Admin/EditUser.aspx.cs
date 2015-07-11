using COMBO_BLL;
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
                {
                    ComboUser objData = new ComboUser();
                    objData.LoadByPrimaryKey(CurrentUser);

                    lblUserName.Text = objData.UserName;
                    lblDisplayName.Text = objData.DisplayName;
                    lblEmail.Text = objData.Email;
                    if (!objData.IsColumnNull(ComboUser.ColumnNames.GenderID))
                    {
                       switch (objData.GenderID)
                        {
                            case 1:
                                lblGender.Text = "Male";
                                break;
                            case 2:
                                lblGender.Text = "Female";
                                break;
                            default:
                                break;
                        }
                    }
                    lblCountry.Text = objData.Country;
                    lblTelephone.Text = objData.Phone;
                    lblWebsite.Text = objData.Website;
                    if (!objData.IsColumnNull(ComboUser.ColumnNames.BirthDate))
                    {
                        lblBirthday.Text = objData.BirthDate.ToShortDateString();
                    }
                    literalBio.Text = objData.Bio;
                    if (!objData.IsColumnNull(ComboUser.ColumnNames.ProfileImgID))
                    {
                        Attachment objData2 = new Attachment();
                        objData2.LoadByPrimaryKey(objData.ProfileImgID);
                        ImgUser.Src = objData2.Path;
                    }
                }
                else
                    Response.Redirect("UserManagement.aspx");
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            PanelProfile.Visible = true;
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
            PanelResetPass.Visible = false;
            bindPosts();
        }

        protected void btnResetPass_Click(object sender, EventArgs e)
        {
            PanelProfile.Visible = false;
            PanelPosts.Visible = false;
            PanelResetPass.Visible = true;
        }
    }
}