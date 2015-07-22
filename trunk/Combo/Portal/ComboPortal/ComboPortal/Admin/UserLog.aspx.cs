using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMBO_BLL;

namespace ComboPortal.Admin
{
    public partial class UserLog : System.Web.UI.Page
    {
        public int CurrentUser
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["uid"]))
                    return int.Parse(Request.QueryString["uid"].ToString());
                else
                    return 0;
            }
        }
        public int CurrentReport
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["rid"]))
                    return int.Parse(Request.QueryString["rid"].ToString());
                else
                    return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Master.PageTitle = "تقارير المستخدمين";
            }

            if (CurrentUser > 0 && CurrentReport == 0)
            {
                loadGeneralLog();
                PanelGeneralReports.Visible = true;
                PanelViewReport.Visible = false;
            }
            else if (CurrentUser>0 && CurrentReport>0)
            {
                loadReport();
                PanelGeneralReports.Visible = false;
                PanelViewReport.Visible = true;
            }
            else
                Response.Redirect("userManagement.aspx");

            checkChanges();

        }
        public void loadGeneralLog()
        {
            ComboUserLog objData = new ComboUserLog();
            objData.Where.ComboUserID.Value = CurrentUser;
            objData.Where.ComboUserID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            objData.Query.Load();
            GridViewReports.DataSource = objData.DefaultView;
            GridViewReports.DataBind();
        }
        public void loadReport()
        {
            Country objDataCountry = new Country();
            UserRank objDataRank = new UserRank();

            // Before
            ComboUserLog objDataBefore = new ComboUserLog();
            objDataBefore.LoadByPrimaryKey(CurrentReport - 1);
            if (objDataBefore.RowCount>0)
            {
                lblBirthDateBefore.Text = objDataBefore.BirthDate.ToString("dd/MM/yyyy");

                objDataCountry.LoadByPrimaryKey(objDataBefore.CountryID);
                lblCountryBefore.Text = objDataCountry.Name;

                lblDisplayNameBefore.Text = objDataBefore.DisplayName;
                lblEmailBefore.Text = objDataBefore.Email;

                objDataRank.LoadByPrimaryKey(objDataBefore.UserRankID);
                lblRankBefore.Text = objDataRank.Name;

                lblTelephoneBefore.Text = objDataBefore.Phone;
                lblUserNameBefore.Text = objDataBefore.UserName;
                lblWebsiteBefore.Text = objDataBefore.Website;
            }
            else
            {
                lblBirthDateBefore.Text = "لا يوجد بيانات";
                lblCountryBefore.Text = "لا يوجد بيانات";
                lblDisplayNameBefore.Text = "لا يوجد بيانات";
                lblEmailBefore.Text = "لا يوجد بيانات";
                lblRankBefore.Text = "لا يوجد بيانات";
                lblTelephoneBefore.Text = "لا يوجد بيانات";
                lblUserNameBefore.Text = "لا يوجد بيانات";
                lblWebsiteBefore.Text = "لا يوجد بيانات";
            }
            
            // After
            ComboUserLog objDataAfter = new ComboUserLog();
            objDataAfter.LoadByPrimaryKey(CurrentReport);
            lblBirthDateAfter.Text = objDataAfter.BirthDate.ToString("dd/MM/yyyy");

            objDataCountry.LoadByPrimaryKey(objDataAfter.CountryID);
            lblCountryAfter.Text = objDataCountry.Name;

            lblDisplayNameAfter.Text = objDataAfter.DisplayName;
            lblEmailAfter.Text = objDataAfter.Email;

            objDataRank.LoadByPrimaryKey(objDataAfter.UserRankID);
            lblRankAfter.Text = objDataRank.Name;

            lblTelephoneAfter.Text = objDataAfter.Phone;
            lblUserNameAfter.Text = objDataAfter.UserName;
            lblWebsiteAfter.Text = objDataAfter.Website;
        }
        protected void GridViewReports_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "viewReports":
                    Response.Redirect(Request.Url.ToString() + "&rid=" + e.CommandArgument.ToString());
                    break;
                default:
                    break;
            }
        }
        protected void btnBacktoGeneral_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLog.aspx?uid=" + Request.QueryString["uid"]);
        }
        public void checkChanges()
        {
            if (lblBirthDateAfter.Text != lblBirthDateBefore.Text)
            {
                lblBirthDateBefore.CssClass += " label-old";
                lblBirthDateAfter.CssClass += " label-new";
            }
            if (lblCountryAfter.Text != lblCountryBefore.Text)
            {
                lblCountryBefore.CssClass += " label-old";
                lblCountryAfter.CssClass += " label-new";
            }
            if (lblDisplayNameAfter.Text != lblDisplayNameBefore.Text)
            {
                lblDisplayNameBefore.CssClass += " label-old";
                lblDisplayNameAfter.CssClass += " label-new";
            }
            if (lblEmailAfter.Text != lblEmailBefore.Text)
            {
                lblEmailBefore.CssClass +=" label-old";
                lblEmailAfter.CssClass += " label-new";
            }
            if (lblRankAfter.Text != lblRankBefore.Text)
            {
                lblRankBefore.CssClass += " label-old";
                lblRankAfter.CssClass += " label-new";
            }
            if (lblTelephoneAfter.Text != lblTelephoneBefore.Text)
            {
                lblTelephoneBefore.CssClass += " label-old";
                lblTelephoneAfter.CssClass += " label-new";
            }
            if (lblUserNameAfter.Text != lblUserNameBefore.Text)
            {
                lblUserNameBefore.CssClass += " label-old";
                lblUserNameAfter.CssClass += " label-new";
            }
            if (lblWebsiteAfter.Text != lblWebsiteBefore.Text)
            {
                lblWebsiteBefore.CssClass += " label-old";
                lblWebsiteAfter.CssClass += " label-new";
            }
        }
    }
}