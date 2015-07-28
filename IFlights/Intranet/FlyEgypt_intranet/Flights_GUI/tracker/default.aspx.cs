using Flight_BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Flights_GUI.tracker
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "Tickets";
                LoadDDLs();
                BindIssues();
            }
        }

        private void LoadDDLs()
        {
            IssueType status = new IssueType();
            status.LoadAll();
            uiDropDownListType.DataSource = status.DefaultView;
            uiDropDownListType.DataTextField = IssueType.ColumnNames.Name;
            uiDropDownListType.DataValueField = IssueType.ColumnNames.IssueTypeID;
            uiDropDownListType.DataBind();
            uiDropDownListType.Items.Insert(0, new ListItem("All", "0"));
        }


        protected void uiGridViewIssues_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            uiGridViewIssues.PageIndex = e.NewPageIndex;
            BindIssues();
        }

        protected void uiGridViewIssues_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditIssue")
            {
                int ID = Convert.ToInt32(e.CommandArgument.ToString());
                Response.Redirect("ticket.aspx?id=" + ID.ToString());
            }
        }

        protected void uiGridViewIssues_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView row = (DataRowView)e.Row.DataItem;
                if (row["StatusID"].ToString() == "1") // initiated
                {
                    e.Row.BackColor = Color.FromArgb(255, 255, 255);
                }
                else if (row["StatusID"].ToString() == "2") // in progress
                {
                    e.Row.BackColor = Color.FromArgb(255,246,191);
                }
                else if (row["StatusID"].ToString() == "3") // resolved
                {
                    e.Row.BackColor = Color.FromArgb(187, 221, 140);
                }
                else if (row["StatusID"].ToString() == "4") // not resolved
                {
                    e.Row.BackColor = Color.FromArgb(241,213,214);
                }
                else if (row["StatusID"].ToString() == "5") // can't be produced
                {
                    e.Row.BackColor = Color.FromArgb(194, 225, 238);
                }
            }
        }


        private void BindIssues()
        {
            Issue all = new Issue();
            if (Roles.IsUserInRole("admin"))
                all.GetAllIssues(txtSearch.Text, Convert.ToInt32(uiDropDownListType.SelectedValue));
            else
                all.GetAllIssuesByUserID(new Guid(Membership.GetUser().ProviderUserKey.ToString()), txtSearch.Text, Convert.ToInt32(uiDropDownListType.SelectedValue));
            uiGridViewIssues.DataSource = all.DefaultView;
            uiGridViewIssues.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindIssues();
        }
    }
}