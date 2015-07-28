using Flight_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Flights_GUI.tracker
{
    public partial class ticket : System.Web.UI.Page
    {
        public int CurrentTicket 
        {
            get 
            {
                int id = 0;
                if (Request.QueryString["id"] != null)
                {
                    int.TryParse(Request.QueryString["id"].ToString(), out id);
                }
                return id;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "Ticket";
                
                if (CurrentTicket != 0)
                {
                    LoadDDLs();                
                    BindIssue();
                }
                else
                {
                    Response.Redirect("default.aspx");
                }
            }

        }

        private void BindIssue()
        {
            Issue issue = new Issue();
            issue.LoadByPrimaryKey(Convert.ToInt32(Request.QueryString["id"].ToString()));
            uiLabelTitle.Text = issue.IssueTitle;
            uiLabelDesc.Text = issue.IssueText;
            uiLabelUser.Text = Membership.GetUser(new Guid(issue.UserID.ToString())).UserName;
            
            IssueType type = new IssueType();
            type.LoadByPrimaryKey(issue.IssueTypeID);
            uiDropDownListStatus.SelectedValue = issue.StatusID.ToString();

            uiLabelUser.Text = Membership.GetUser(issue.UserID).UserName;
            uiLabelType.Text = type.Name;

            IssueAttachment att = new IssueAttachment();
            att.GetIssuesAttachment(issue.IssueID);
            uiRepeaterAttachments.DataSource = att.DefaultView;
            uiRepeaterAttachments.DataBind();

            BindComments();
        }
     

        private void LoadDDLs()
        {
            Status status = new Status();
            status.LoadAll();
            uiDropDownListStatus.DataSource = status.DefaultView;
            uiDropDownListStatus.DataTextField = Status.ColumnNames.Name;
            uiDropDownListStatus.DataValueField = Status.ColumnNames.StatusID;
            uiDropDownListStatus.DataBind();
        }

        private void BindComments()
        {
            Comment coms = new Comment();
            coms.GetIssuesComments(Convert.ToInt32(Request.QueryString["id"].ToString()));

            uiGridViewComments.DataSource = coms.DefaultView;
            uiGridViewComments.DataBind();
        }

        protected void uiGridViewComments_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            uiGridViewComments.PageIndex = e.NewPageIndex;
            BindComments();
        }


        protected void uLinkButtonUpdate_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            issue.LoadByPrimaryKey(Convert.ToInt32(Request.QueryString["id"].ToString()));
            issue.StatusID = Convert.ToInt32(uiDropDownListStatus.SelectedValue);
            issue.Save();
            BindIssue();
        }
        protected void uLinkButtonAdd_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.AddNew();
            comment.IssueID = Convert.ToInt32(Request.QueryString["id"].ToString());
            comment.CommentText = uiTextBoxDesc.Text;
            comment.UserID = new Guid(Membership.GetUser().ProviderUserKey.ToString());
            comment.CommentDate = DateTime.Now;
            comment.Save();
            if (uiFileUploadAttach.HasFile)
            {
                string path = "/tracker/attachments/" + Guid.NewGuid() + "_" + uiFileUploadAttach.FileName;
                uiFileUploadAttach.SaveAs(Server.MapPath("~" + path));
                Attachment att = new Attachment();
                att.AddNew();
                att.Path = path;
                att.Save();

                CommentAttachment iA = new CommentAttachment();
                iA.AddNew();
                iA.CommentID = comment.CommentID;
                iA.AttachmentID = att.AttachmentID;
                iA.Save();
            }
            Response.Redirect(Request.RawUrl);
        }
    }
}