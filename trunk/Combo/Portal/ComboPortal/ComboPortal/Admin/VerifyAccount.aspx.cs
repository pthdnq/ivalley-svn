using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMBO_BLL;

namespace ComboPortal.Admin
{
    public partial class VerifyAccount : System.Web.UI.Page
    {
        protected int CurrentRequest
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["vid"]))
                    return int.Parse(Request.QueryString["vid"].ToString());
                else
                    return 0;
            }
        }
        protected int CurrentUser
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
                Master.PageTitle = "توثيق الحسابات";
            }
            if (CurrentRequest > 0)
            {
                PanelGeneralRequests.Visible = false;
                PanelRequestDetails.Visible = true;

                loadRequestDetails();
            }
            else
            {
                PanelGeneralRequests.Visible = true;
                PanelRequestDetails.Visible = false;
                loadNewRequests();
                loadAcceptedRequests();
                loadRefusedRequests();
            }
        }
        protected void loadNewRequests()
        {
            VerificationRequest objData = new VerificationRequest();
            objData.getNewRequests();

            GridViewNewRequests.DataSource = objData.DefaultView;
            GridViewNewRequests.DataBind();
        }
        protected void loadAcceptedRequests()
        {
            VerificationRequest objData = new VerificationRequest();
            objData.getAcceptedRequests();

            GridViewAcceptedRequests.DataSource = objData.DefaultView;
            GridViewAcceptedRequests.DataBind();
        }
        protected void loadRefusedRequests()
        {
            VerificationRequest objData = new VerificationRequest();
            objData.getRefusedRequests();

            GridViewRefusedRequests.DataSource = objData.DefaultView;
            GridViewRefusedRequests.DataBind();
        }
        protected void loadRequestDetails()
        {
            VerificationRequest objData = new VerificationRequest();
            objData.LoadByPrimaryKey(CurrentRequest);

            Gender objDataGender = new Gender();
            objDataGender.LoadByPrimaryKey(objData.GenderID);

            Country objDataCountry = new Country();
            objDataCountry.LoadByPrimaryKey(objData.CountryID);
            switch (objData.RequestTypeID)
            {
                case 1:
                case 3:
                    PanelDetailsPersonalStore.Visible = true;
                    PanelDetailsOfficial.Visible = false;

                    lblImgPic1.Text = "صورة الجواز او الهوية";
                    lblImgPic2.Text = "صورة شخصية واضحة الملامح";
                    lblNameInPassport.Text = objData.Name;
                    lblPassportNumber.Text = objData.PassportNo;
                    lblBirthDate.Text = objData.DateOfBirth.ToString("dd/MM/yyyy");
                    lblGender.Text = objDataGender.Name;
                    lblCountry.Text = objDataCountry.Name;
                    break;
                case 2:
                    PanelDetailsPersonalStore.Visible = false;
                    PanelDetailsOfficial.Visible = true;

                    lblImgPic1.Text = "صورة السجل التجارى";
                    lblImgPic2.Text = "صورة للموقع او المبنى";
                    lblOfficialName.Text = objData.Name;
                    lblOfficialCountry.Text = objDataCountry.Name;
                    lblCity.Text = objData.City;
                    lblExtraInfo.Text = objData.Info;
                    lblActivity.Text = objData.Activity;
                    break;
                default:
                    break;
            }
            lblPhone.Text = objData.MobileNo;
            lblPhone2.Text = objData.MobileNo2;
            lblAccountName.Text = objData.AccountName;
            lblEmail.Text = objData.Email;
            imgPic1.Src = objData.PassportPicPath;
            imgPic2.Src = objData.PersonalPicPath;
            lblRequestDate.Text = objData.RequestDate.ToString("dd/MM/yyyy");
            lblReviewerName.Text = objData.ReviewerName;

            if (objData.IsColumnNull(VerificationRequest.ColumnNames.IsAccepted))
            {
                PanelResult.Visible = true;
                txtResult.Enabled = true;
            }
            else
            {
                PanelResult.Visible = true;
                txtResult.Enabled = false;
                txtResult.Text = objData.Description;
                lblStatusDate.Text = objData.StatusDate.ToString("dd/MM/yyyy");
                btnRefuseVerify.Visible = false;
                btnAcceptVerify.Visible = false;
            }
        }
        protected void GridViewNewRequests_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HiddenField hfRequestTypeID = e.Row.FindControl("hfRequestTypeID") as HiddenField;
                Label lblRequestType = e.Row.FindControl("lblRequestType") as Label;

                switch (hfRequestTypeID.Value.ToString())
                {
                    case "1":
                        lblRequestType.Text = "حساب شخصى";
                        break;
                    case "2":
                        lblRequestType.Text = "حساب رسمى";
                        break;
                    case "3":
                        lblRequestType.Text = "حساب متجر";
                        break;
                    default:
                        break;
                }
            }
        }
        protected void GridViewAcceptedRequests_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HiddenField hfRequestTypeID = e.Row.FindControl("hfRequestTypeID") as HiddenField;
                Label lblRequestType = e.Row.FindControl("lblRequestType") as Label;

                switch (hfRequestTypeID.Value.ToString())
                {
                    case "1":
                        lblRequestType.Text = "حساب شخصى";
                        break;
                    case "2":
                        lblRequestType.Text = "حساب رسمى";
                        break;
                    case "3":
                        lblRequestType.Text = "حساب متجر";
                        break;
                    default:
                        break;
                }
            }
        }
        protected void GridViewRefusedRequests_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HiddenField hfRequestTypeID = e.Row.FindControl("hfRequestTypeID") as HiddenField;
                Label lblRequestType = e.Row.FindControl("lblRequestType") as Label;

                switch (hfRequestTypeID.Value.ToString())
                {
                    case "1":
                        lblRequestType.Text = "حساب شخصى";
                        break;
                    case "2":
                        lblRequestType.Text = "حساب رسمى";
                        break;
                    case "3":
                        lblRequestType.Text = "حساب متجر";
                        break;
                    default:
                        break;
                }
            }
        }
        protected void btnRefuseVerify_Click(object sender, EventArgs e)
        {
            VerificationRequest objData = new VerificationRequest();
            objData.LoadByPrimaryKey(CurrentRequest);
            objData.IsAccepted = false;
            objData.Description = txtResult.Text;
            objData.StatusDate = DateTime.Now;
            objData.ReviewerName = Page.User.Identity.Name;
            objData.Save();

            ComboUser objDataUser = new ComboUser();
            objDataUser.LoadByPrimaryKey(CurrentUser);
            objDataUser.IsVerified = false;
            objDataUser.Save();
            Response.Redirect("VerifyAccount.aspx");
        }
        protected void btnAcceptVerify_Click(object sender, EventArgs e)
        {
            VerificationRequest objData = new VerificationRequest();
            objData.LoadByPrimaryKey(CurrentRequest);
            objData.IsAccepted = true;
            objData.Description = txtResult.Text;
            objData.StatusDate = DateTime.Now;
            objData.ReviewerName = Page.User.Identity.Name;
            objData.Save();

            ComboUser objDataUser = new ComboUser();
            objDataUser.LoadByPrimaryKey(CurrentUser);
            objDataUser.IsVerified = true;
            objDataUser.Save();

            Response.Redirect("VerifyAccount.aspx");
        }

        protected void GridViewNewRequests_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewNewRequests.PageIndex = e.NewPageIndex;
            loadNewRequests();
        }

        protected void GridViewAcceptedRequests_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewAcceptedRequests.PageIndex = e.NewPageIndex;
            loadAcceptedRequests();
        }

        protected void GridViewRefusedRequests_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewRefusedRequests.PageIndex = e.NewPageIndex;
            loadRequestDetails();
        }
    }
}