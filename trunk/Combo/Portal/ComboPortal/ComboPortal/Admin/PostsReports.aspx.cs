using COMBO_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComboPortal.Admin
{
    public partial class PostsReports : System.Web.UI.Page
    {
        public int CurrentUserReport
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["cur"]))
                    return int.Parse(Request.QueryString["cur"].ToString());
                else
                    return 0;
            }
        }
        public int CurrentCommentReport
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["ccr"]))
                    return int.Parse(Request.QueryString["ccr"].ToString());
                else
                    return 0;
            }
        }
        public int CurrentPostReport
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["cpr"]))
                    return int.Parse(Request.QueryString["cpr"].ToString());
                else
                    return 0;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "البلاغات";
                bindGeneralUserReports();
                bindGeneralCommentReports();
                bindGeneralPostReports();

            }
            if (CurrentCommentReport > 0)
            {
                loadCommentReport();

                PanelGridGeneralReports.Visible = false;
                PanelGridCommentReports.Visible = true;
                PanelGridPostReports.Visible = false;
                PanelGridUserReports.Visible = false;
            }
            else if (CurrentPostReport > 0)
            {
                loadPostReport();

                PanelGridGeneralReports.Visible = false;
                PanelGridCommentReports.Visible = false;
                PanelGridPostReports.Visible = true;
                PanelGridUserReports.Visible = false;
            }
            else if (CurrentUserReport > 0)
            {
                loadUserReport();

                PanelGridGeneralReports.Visible = false;
                PanelGridCommentReports.Visible = false;
                PanelGridPostReports.Visible = false;
                PanelGridUserReports.Visible = true;
            }
            else
            {
                PanelGridGeneralReports.Visible = true;
                PanelGridCommentReports.Visible = false;
                PanelGridPostReports.Visible = false;
                PanelGridUserReports.Visible = false;
            }
        }
        public void bindGeneralUserReports()
        {
            ComboUserReport objData = new ComboUserReport();
            objData.getGeneralUserReports();

            GridViewAccountReports.DataSource = objData.DefaultView;
            GridViewAccountReports.DataBind();
        }
        public void bindGeneralPostReports()
        {
            ComboPostReport objData = new ComboPostReport();
            objData.getGeneralPostReports();

            GridViewPostReports.DataSource = objData.DefaultView;
            GridViewPostReports.DataBind();
        }
        public void bindGeneralCommentReports()
        {
            ComboCommentReport objData = new ComboCommentReport();
            objData.getGeneralCommentReports();

            GridViewCommentReports.DataSource = objData.DefaultView;
            GridViewCommentReports.DataBind();
        }
        public void loadUserReport()
        {
            ComboUserReport objData = new ComboUserReport();
            objData.getReportsByUserID(CurrentUserReport);
            GridViewUserReports.DataSource = objData.DefaultView;
            GridViewUserReports.DataBind();
        }
        public void loadPostReport()
        {
            ComboPostReport objData = new ComboPostReport();
            objData.getPostReportsByPostID(CurrentPostReport);
            GridPostReports.DataSource = objData.DefaultView;
            GridPostReports.DataBind();
        }
        public void loadCommentReport()
        {
            ComboCommentReport objData = new ComboCommentReport();
            objData.getCommentReportsByCommentID(CurrentCommentReport);
            GridCommentReports.DataSource = objData.DefaultView;
            GridCommentReports.DataBind();
        }

        protected void GridViewAccountReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCommentReports.PageIndex = e.NewPageIndex;
            bindGeneralUserReports();
            
        }
        protected void GridViewPostReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewPostReports.PageIndex = e.NewPageIndex;
            bindGeneralPostReports();
        }
        protected void GridViewCommentReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewCommentReports.PageIndex = e.NewPageIndex;
            bindGeneralCommentReports();
        }
        protected void GridViewUserReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewUserReports.PageIndex = e.NewPageIndex;
            loadUserReport();
        }
        protected void GridCommentReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCommentReports.PageIndex = e.NewPageIndex;
            loadCommentReport();
        }
        protected void GridPostReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridPostReports.PageIndex = e.NewPageIndex;
            loadPostReport();
        }
    }
}