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
                if (CurrentCommentReport > 0)
                {
                    ComboCommentReport objData = new ComboCommentReport();
                    objData.getCommentReportsByCommentID(CurrentCommentReport);
                    GridCommentReports.DataSource = objData.DefaultView;
                    GridCommentReports.DataBind();

                    PanelGridGeneralReports.Visible = false;
                    PanelGridCommentReports.Visible = true;
                    PanelGridPostReports.Visible = false;
                    PanelGridUserReports.Visible = false;
                }
                else if (CurrentPostReport > 0)
                {
                    ComboPostReport objData = new ComboPostReport();
                    objData.getPostReportsByPostID(CurrentPostReport);
                    GridPostReports.DataSource = objData.DefaultView;
                    GridPostReports.DataBind();

                    PanelGridGeneralReports.Visible = false;
                    PanelGridCommentReports.Visible = false;
                    PanelGridPostReports.Visible = true;
                    PanelGridUserReports.Visible = false;
                }
                else if (CurrentUserReport > 0)
                {
                    ComboUserReport objData = new ComboUserReport();
                    objData.getReportsByUserID(CurrentUserReport);
                    GridViewUserReports.DataSource = objData.DefaultView;
                    GridViewUserReports.DataBind();

                    PanelGridGeneralReports.Visible = false;
                    PanelGridCommentReports.Visible = false;
                    PanelGridPostReports.Visible = false;
                    PanelGridUserReports.Visible = true;
                }

                Master.PageTitle = "البلاغات";
                bindUserReports();
                bindCommentReports();
                bindPostReports();
            }
        }

        public void bindUserReports()
        {
            ComboUserReport objData = new ComboUserReport();
            objData.getGeneralUserReports();

            GridViewAccountReports.DataSource = objData.DefaultView;
            GridViewAccountReports.DataBind();
        }

        public void bindPostReports()
        {
            ComboPostReport objData = new ComboPostReport();
            objData.getGeneralPostReports();

            GridViewPostReports.DataSource = objData.DefaultView;
            GridViewPostReports.DataBind();
        }

        public void bindCommentReports()
        {
            ComboCommentReport objData = new ComboCommentReport();
            objData.getGeneralCommentReports();

            GridViewCommentReports.DataSource = objData.DefaultView;
            GridViewCommentReports.DataBind();
        }
    }
}