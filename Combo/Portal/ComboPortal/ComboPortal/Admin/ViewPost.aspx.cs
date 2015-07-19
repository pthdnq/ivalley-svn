using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMBO_BLL;

namespace ComboPortal.Admin
{
    public partial class ViewPost : System.Web.UI.Page
    {
        protected int CurrentPost
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["pid"]))
                    return int.Parse(Request.QueryString["pid"].ToString());
                else
                    return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (CurrentPost > 0)
                {
                    loadPost();
                    loadComments();
                }
                else
                    Response.Redirect("UserManagement.aspx");
            }
        }

        protected void RepeaterComments_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "deleteComment":
                    ComboComment objData = new ComboComment();
                    objData.LoadByPrimaryKey(int.Parse(e.CommandArgument.ToString()));
                    objData.IsDeleted = true;
                    objData.Save();
                    loadComments();
                    break;
                default:
                    break;
            }
        }

        protected void loadPost()
        {
            ComboPost objData = new ComboPost();
            objData.LoadByPrimaryKey(CurrentPost);

            lblPostDate.Text = objData.PostDate.ToString("dd/MM/yyyy");
            lblPostText.Text = objData.PostText;

            ComboUser objDataName = new ComboUser();
            objDataName.LoadByPrimaryKey(objData.ComboUserID);
            lblUserName.Text = objDataName.UserName;

            if (!objDataName.IsColumnNull(ComboUser.ColumnNames.ProfileImgID))
            {
                Attachment objDataAttach = new Attachment();
                objDataAttach.LoadByPrimaryKey(objDataName.ProfileImgID);
                imgUserProfile.Src = objDataAttach.Path;
            }
        }
        protected void loadComments()
        {
            ComboComment objData = new ComboComment();
            objData.GetPostCommentsByPostID(CurrentPost);
            RepeaterComments.DataSource = objData.DefaultView;
            RepeaterComments.DataBind();
        }
    }
}