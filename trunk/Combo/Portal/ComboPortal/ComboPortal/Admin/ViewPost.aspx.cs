using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMBO_BLL;
using System.Web.UI.HtmlControls;

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
            // Attachment 
            ComboPost objDataPost = new ComboPost();
            objDataPost.LoadByPrimaryKey(CurrentPost);

            ComboPostAttachment objDataPostAttachment = new ComboPostAttachment();
            objDataPostAttachment.Where.ComboPostID.Value = CurrentPost;
            objDataPostAttachment.Where.ComboPostID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            objDataPostAttachment.Query.Load();

            if (objDataPostAttachment.RowCount > 0)
            {
                PanelAttachment.Visible = true;

                Attachment objDataAttachment = new Attachment();
                objDataAttachment.LoadByPrimaryKey(objDataPostAttachment.AttachmentID);

                switch (objDataAttachment.AttachmentTypeID)
                {
                    case 1:
                        imgAttachment.Src = objDataAttachment.Path;
                        imgAttachment.Visible = true;
                        break;
                    case 2:
                        audioAttachment.Src = objDataAttachment.Path;
                        audioAttachment.Visible = true;
                        break;
                    case 3:
                        videoAttachment.Src = objDataAttachment.Path;
                        videoAttachment.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }
        protected void loadComments()
        {
            ComboComment objData = new ComboComment();
            objData.GetPostCommentsByPostID(CurrentPost);
            RepeaterComments.DataSource = objData.DefaultView;
            RepeaterComments.DataBind();
        }
        protected void RepeaterComments_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                HiddenField hfCommentID = e.Item.FindControl("hfCommentID") as HiddenField;
                LinkButton btnViewPost = e.Item.FindControl("btnViewPost") as LinkButton;

                ComboComment objDataPost = new ComboComment();
                objDataPost.LoadByPrimaryKey(int.Parse(hfCommentID.Value.ToString()));

                ComboCommentAttachment objDataCommentAttachment = new ComboCommentAttachment();
                objDataCommentAttachment.Where.ComboCommnetID.Value = (int.Parse(hfCommentID.Value.ToString()));
                objDataCommentAttachment.Where.ComboCommnetID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
                objDataCommentAttachment.Query.Load();

                if (objDataCommentAttachment.RowCount > 0)
                {
                    Panel PanelAttachment = e.Item.FindControl("PanelAttachment") as Panel;
                    PanelAttachment.Visible = true;

                    Attachment objDataAttachment = new Attachment();
                    objDataAttachment.LoadByPrimaryKey(objDataCommentAttachment.AttachmentID);

                    HtmlAudio audioAttachment = e.Item.FindControl("audioAttachment") as HtmlAudio;
                    audioAttachment.Src = "api.combomobile.com" + objDataAttachment.Path;
                    audioAttachment.Visible = true;
                }
            }
        }
    }
}