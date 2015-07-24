using Pricing.BLL;
using PricingBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pricing_GUI
{
    public partial class Requests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDDLs();
            }
        }

        private void LoadDDLs()
        {
            ListItem item = new ListItem(" --- Select ----", "-1");

            // Bind Registeration_Committee_Type
            Registeration_Committee_Type objCommitteType = new Registeration_Committee_Type();
            objCommitteType.LoadAll();
            
            uiDropDownListCommitteType.DataSource = objCommitteType.DefaultView;
            uiDropDownListCommitteType.DataTextField = Registeration_Committee_Type.ColumnNames.CommitteType;
            uiDropDownListCommitteType.DataValueField = Registeration_Committee_Type.ColumnNames.ID;
            uiDropDownListCommitteType.DataBind();
            uiDropDownListCommitteType.Items.Insert(0, item);

            //License Type
            TradePricingLicenseType licenseTypes = new TradePricingLicenseType();
            licenseTypes.LoadAll();
            uiDropDownListLicenseType.DataSource = licenseTypes.DefaultView;
            uiDropDownListLicenseType.DataTextField = TradePricingLicenseType.ColumnNames.Name;
            uiDropDownListLicenseType.DataValueField = TradePricingLicenseType.ColumnNames.Name;
            uiDropDownListLicenseType.DataBind();
            uiDropDownListLicenseType.Items.Insert(0, item);

            //status Type
            TradePricingStatus statusTypes = new TradePricingStatus();
            statusTypes.LoadAll();
            uiDropDownListStatusType.DataSource = statusTypes.DefaultView;
            uiDropDownListStatusType.DataTextField = TradePricingStatus.ColumnNames.Name;
            uiDropDownListStatusType.DataValueField = TradePricingStatus.ColumnNames.TradePricingStatusID;
            uiDropDownListStatusType.DataBind();
            uiDropDownListStatusType.Items.Insert(0, item);

            //sector Type
            SectorType sectorTypes = new SectorType();
            sectorTypes.LoadAll();
            uiDropDownListSectorType.DataSource = sectorTypes.DefaultView;
            uiDropDownListSectorType.DataTextField = SectorType.ColumnNames.Name;
            uiDropDownListSectorType.DataValueField = SectorType.ColumnNames.SectorTypeID;
            uiDropDownListSectorType.DataBind();
            uiDropDownListSectorType.Items.Insert(0, item);

        }

        protected void uiLinkButtonSave_Click(object sender, EventArgs e)
        {
            bool isNew = false;
            PackagePricing pp = new PackagePricing();
            if (!string.IsNullOrEmpty(uiHiddenFieldCurrentPPID.Value) && uiHiddenFieldCurrentPPID.Value != "0")
                pp.LoadByPrimaryKey(Convert.ToInt32(uiHiddenFieldCurrentPPID.Value));
            else
            {
                isNew = true;
                pp.AddNew();
                pp.CreatedDate = DateTime.Now;
                pp.PricingStatusID = 1;
            }

            pp.PackID = Convert.ToInt32(uiHiddenFieldCurrentPackID.Value);
            pp.Trade_Code = Convert.ToInt32(uiHiddenFieldCurrentDrugID.Value);

            pp.RegistrationCommitteTypeID = Convert.ToInt32(uiDropDownListCommitteType.SelectedValue);
            pp.Trade_Notes = uiTextBoxNotes.Text;
            if (!string.IsNullOrEmpty(hf1.Value) || hf1.Value != "0")
            {
                pp.File_CoverLetter = hf1.Value;
            }
            if (!string.IsNullOrEmpty(hf2.Value) || hf2.Value != "0")
            {
                pp.File_BoxApproval = hf2.Value;
            }
            if (!string.IsNullOrEmpty(hf3.Value) || hf3.Value != "0")
            {
                pp.File_TradeNameApproval = hf3.Value;
            }
            if (!string.IsNullOrEmpty(hf4.Value) || hf4.Value != "0")
            {
                pp.File_CostSheet = hf4.Value;
            }
            if (!string.IsNullOrEmpty(hf5.Value) || hf5.Value != "0")
            {
                pp.File_ProformaInvoice = hf5.Value;
            }
            if (!string.IsNullOrEmpty(hf6.Value) || hf6.Value != "0")
            {
                pp.File_CifPriceToEgypt = hf6.Value;
            }
            if (!string.IsNullOrEmpty(hf7.Value) || hf7.Value != "0")
            {
                pp.File_PriceOriginCountry = hf7.Value;
            }
            if (!string.IsNullOrEmpty(hf8.Value) || hf8.Value != "0")
            {
                pp.File_CountryPrices = hf8.Value;
            }
            if (!string.IsNullOrEmpty(hf9.Value) || hf9.Value != "0")
            {
                pp.File_PackArtworkLeaflet = hf9.Value;
            }

            if (uiDropDownListSectorType_Before.SelectedIndex != -1)
                pp.SectorTypeID = Convert.ToInt32(uiDropDownListSectorType_Before.SelectedValue);
            if (uiDropDownListStatusType.SelectedIndex != -1)
                pp.TradePricingStatusID = Convert.ToInt32(uiDropDownListStatusType.SelectedValue);

            pp.Reference = uiTextBoxReference.Text;
            pp.Indication = uiTextBoxIndication.Text;
            pp.SubmittedToSpecialized = uiCheckBoxSubmittedToSpecialized.Checked;
            pp.Dose = uiTextBoxDose.Text;
            pp.SalesTaxes = uiCheckBoxSalesTaxes.Checked;
            pp.EssentialDrugList = uiCheckBoxEssentialDrugList.Checked;
            double committePrice =0;
            DateTime committeDate,approvalDate, issueDate;
            double.TryParse(uiTextBoxCommittePrice.Text, out committePrice);
            pp.CommittePrice = committePrice;

            DateTime.TryParseExact(uiTextBoxCommitteDate.Text,"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None, out committeDate);
            if(committeDate != DateTime.MinValue)
                pp.CommiteeDate = committeDate;

            int nob = 0;
            pp.RationalForPricing = uiTextBoxRationalForPricing.Text;
            int.TryParse(uiTextBoxNoInBox.Text, out nob);
            if (nob != 0)
                pp.NoInBox = nob;

            pp.PriceInEgy = uiTextBoxBrandPriceInEgy.Text;
            pp.PriceAfter30 = uiTextBoxPriceAfter30.Text;
            pp.PriceAfter35HighTech= uiTextBoxPriceAfter35.Text;
            pp.PriceAfter35FirstGeneric = uiTextBoxPriceAfter35FirstGeneric.Text;
            pp.PriceAfter40SecondGeneric = uiTextBoxPriceAfter40ndGeneric.Text;
            pp.LowestPriceGeneric = uiTextBoxLowestPriceGeneric.Text;
            pp.IsPricedTo499 = uiCheckBoxIsPricedTo499.Checked;
            pp.Notes = uiTextBoxNotes_After.Text;
            pp.Similar = uiCheckBoxSimilar.Checked;
            pp.MainGroup = uiTextBoxMainGroup.Text;
            pp.PreviousPack = uiTextBoxPreviouspack.Text;
            pp.PreviousPrice = uiTextBoxPreviousPrice.Text;
            pp.ApprovedPrice = uiTextBoxApprovedPrice.Text;
            pp.PriceCategory = uiTextBoxPriceCategory.Text;
            

            if (!string.IsNullOrEmpty(hf10.Value) || hf10.Value != "0")
            {
                pp.File_ministerapproval = hf10.Value;
            }
            if (!string.IsNullOrEmpty(hf11.Value) || hf11.Value != "0")
            {
                pp.ApprovalLetters = hf11.Value;
            }
            DateTime.TryParseExact(uiTextBoxApprovalDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out approvalDate);
            if (approvalDate != DateTime.MinValue)
                pp.Approvaldate = approvalDate;

            DateTime.TryParseExact(uiTextBoxIssueDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out issueDate);
            if (issueDate != DateTime.MinValue)
                pp.Issuedate = issueDate;

            
            pp.Save();

            if (isNew)
            {
                PackageStatusHistory sh = new PackageStatusHistory();
                sh.AddNew();
                sh.TradePricingID = pp.Trade_Code;
                sh.PackID = pp.PackID;
                sh.PricingStatusID = 1;
                sh.StatusDate = DateTime.Now;
                sh.StatusHolder = "Company";
                sh.Save();
            }

            Response.Redirect("requests.aspx?pid=" + pp.PackID.ToString() + "&did=" + pp.Trade_Code.ToString() + "&ppid=" + pp.PackagePricingID.ToString());
        }
    }
}