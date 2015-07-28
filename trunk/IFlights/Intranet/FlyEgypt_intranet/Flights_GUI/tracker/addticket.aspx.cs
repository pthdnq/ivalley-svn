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
    public partial class addticket : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "Add Ticket";
                LoadDDLs();                
            }

        }

       
        private void LoadDDLs()
        {
            IssueType types = new IssueType();
            types.LoadAll();
            uiDropDownListIssueType.DataSource = types.DefaultView;
            uiDropDownListIssueType.DataTextField = IssueType.ColumnNames.Name;
            uiDropDownListIssueType.DataValueField = IssueType.ColumnNames.IssueTypeID;
            uiDropDownListIssueType.DataBind();
        }

        protected void uLinkButtonAdd_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();           
            issue.AddNew();
            issue.IssueDate = DateTime.Now;
            issue.StatusID = 1; // opened           
            issue.IssueTitle = uiTextBoxTitle.Text;
            issue.IssueText = uiTextBoxDesc.Text;
            issue.UserID = new Guid(Membership.GetUser().ProviderUserKey.ToString());
            issue.IssueTypeID = Convert.ToInt32(uiDropDownListIssueType.SelectedValue);
            issue.Save();

            if (uiFileUploadAttach.HasFile)
            {
                string path = "/tracker/attachments/" + Guid.NewGuid() + "_" + uiFileUploadAttach.FileName;
                uiFileUploadAttach.SaveAs(Server.MapPath("~" + path));
                Attachment att = new Attachment();
                att.AddNew();
                att.Path = path;
                att.Save();

                IssueAttachment iA = new IssueAttachment();
                iA.AddNew();
                iA.IssueID = issue.IssueID;
                iA.AttachmentID = att.AttachmentID;
                iA.Save();
            }
            Response.Redirect("default.aspx");
        }
    }
}