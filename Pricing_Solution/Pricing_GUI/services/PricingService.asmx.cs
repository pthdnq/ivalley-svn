using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web.Script.Services;
using PricingBLL;
using Pricing.BLL;
using System.Data;
namespace Pricing_GUI.services
{
    /// <summary>
    /// Summary description for PricingService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class PricingService : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]        
        public void GetTradeDrugs(string name, string generics, decimal strength, string company, string regNo )
        {
            v_EDDB_TradeDrugDetails details = new v_EDDB_TradeDrugDetails();
            details.SearchDrugs(name, generics, strength, company, regNo);

            List<Models.TradeDrugModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.TradeDrugModel
                {
                    TradeCode = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.TradeCode].ToString()),
                    Strength_value = Convert.ToDecimal(row[v_EDDB_TradeDrugDetails.ColumnNames.Strength_value].ToString()),
                    CompanyDetID = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.CompanyDetID].ToString()),
                    Drug_license_number = row["Drug_license_number"].ToString(),
                    Trade_name = row["Trade_name"].ToString(),
                    Type_of_license = row["Type_of_license"].ToString(),
                    Strength_unit = row["Strength_unit"].ToString(),
                    Dosage_form = row["Dosage_form"].ToString(),
                    Generics = row["Generics"].ToString(),
                    LicHold = row["LicHold"].ToString(),
                    Manufacturer = row["Manufacturer"].ToString(),
                    Packager = row["Packager"].ToString(),
                    BatchReleaser = row["BatchReleaser"].ToString(),
                    APISupplier = row["APISupplier"].ToString(),
                    StorageSite = row["StorageSite"].ToString(),
                    Type = row["Type"].ToString(),
                    Applicant = row["Applicant"].ToString(),

                };
            }).ToList();

            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void SearchDrugs(string name)
        {
            v_EDDB_TradeDrugDetails details = new v_EDDB_TradeDrugDetails();
            details.SearchDrugs(name, "", 0, "", "");

            List<Models.TradeDrugModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.TradeDrugModel
                {
                    TradeCode = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.TradeCode].ToString()),
                    Strength_value = Convert.ToDecimal(row[v_EDDB_TradeDrugDetails.ColumnNames.Strength_value].ToString()),
                    CompanyDetID = Convert.ToInt32(row[v_EDDB_TradeDrugDetails.ColumnNames.CompanyDetID].ToString()),
                    Drug_license_number = row["Drug_license_number"].ToString(),
                    Trade_name = row["Trade_name"].ToString(),
                    Type_of_license = row["Type_of_license"].ToString(),
                    Strength_unit = row["Strength_unit"].ToString(),
                    Dosage_form = row["Dosage_form"].ToString(),
                    Generics = row["Generics"].ToString(),
                    LicHold = row["LicHold"].ToString(),
                    Manufacturer = row["Manufacturer"].ToString(),
                    Packager = row["Packager"].ToString(),
                    BatchReleaser = row["BatchReleaser"].ToString(),
                    APISupplier = row["APISupplier"].ToString(),
                    StorageSite = row["StorageSite"].ToString(),
                    Type = row["Type"].ToString(),
                    Applicant = row["Applicant"].ToString(),

                };
            }).ToList();

            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetTradeDrugById(int id)
        {
            
            v_EDDB_TradeDrugDetails details = new v_EDDB_TradeDrugDetails();
            details.GetDrugById(id);

            Models.TradeDrugModel Alldetails = new Models.TradeDrugModel();
            
            Alldetails.TradeCode = Convert.ToInt32(details.TradeCode.ToString());
            Alldetails.Strength_value = Convert.ToDecimal(details.Strength_value.ToString());
            Alldetails.CompanyDetID = Convert.ToInt32(details.CompanyDetID.ToString());
            Alldetails.Drug_license_number = details.Drug_license_number.ToString();
            Alldetails.Trade_name = details.Trade_name.ToString();
            Alldetails.Type_of_license = details.Type_of_license.ToString();
            Alldetails.Strength_unit = details.Strength_unit.ToString();
            Alldetails.Dosage_form = details.Dosage_form.ToString();
            Alldetails.Generics = details.Generics.ToString();
            Alldetails.LicHold = details.LicHold.ToString();
            Alldetails.Manufacturer = details.Manufacturer.ToString();
            Alldetails.Packager = details.Packager.ToString();
            Alldetails.BatchReleaser = details.BatchReleaser.ToString();
            Alldetails.APISupplier = details.APISupplier.ToString();
            Alldetails.StorageSite = details.StorageSite.ToString();
            Alldetails.Type = details.Type.ToString();
            Alldetails.Applicant = details.Applicant.ToString();
                
            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetTradeGenericsById(int id)
        {
            
            V_EDDB_DrugGenerics details = new V_EDDB_DrugGenerics();
            details.GetDrugById(id);

            List<Models.GenericModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.GenericModel
                {

                    TradeName_ID = Convert.ToInt32(row["TradeName_ID"].ToString()),
                    GenericName = row["GenericName"].ToString(),
                    Indications = row["Indications"].ToString(),
                    Cautions = row["Cautions"].ToString(),
                    Contra_indications = row["Contra_indications"].ToString(),
                    Side_effects = row["Side_effects"].ToString(),
                    Dose = row["Dose"].ToString(),
                    InterActionLevelCode = row["InterActionLevelCode"].ToString(),
                    Interaction = row["Interaction"].ToString(),
                    General = row["General"].ToString(),
                    HDL = row["HDL"].ToString(),
                    STORE = row["STORE"].ToString(),
                    CPNUM = Convert.IsDBNull(row["CPNUM"]) ? 0 : Convert.ToInt32(row["CPNUM"].ToString()),
                    Dilution = Convert.IsDBNull(row["Dilution"]) ? 0 : Convert.ToInt32(row["Dilution"].ToString()),
                    MaxChemoDose = Convert.IsDBNull(row["MaxChemoDose"]) ? 0 : Convert.ToInt32(row["MaxChemoDose"].ToString()),
                    TPNIngredient = Convert.IsDBNull(row["TPNIngredient"]) ? 0 : Convert.ToInt32(row["TPNIngredient"].ToString()),
                    ChemoCalcType = Convert.IsDBNull(row["ChemoCalcType"]) ? 0 : Convert.ToInt32(row["ChemoCalcType"].ToString()),
                    IsVaccine = Convert.IsDBNull(row["IsVaccine"]) ? 0 : Convert.ToInt32(row["IsVaccine"].ToString()),
                    strengthunit = Convert.IsDBNull(row["strengthunit"]) ? 0 : Convert.ToInt32(row["strengthunit"].ToString()),
                    strengthunitstr = row["strengthunitstr"].ToString(),
                    StrengthValue = Convert.IsDBNull(row["StrengthValue"]) ? 0 : Convert.ToDecimal(row["StrengthValue"].ToString()),
                };
            }).ToList();
            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetTradePackgesById(int id)
        {

            PackageDetails details = new PackageDetails();
            details.GetPackagesByTradeID(id);
            /*
            v_EDDB_PackDetailes details = new v_EDDB_PackDetailes();
            details.GetPacksByTradeId(id);*/

            List<Models.PackageModel> Alldetails = details.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.PackageModel
                {
                    PackID = Convert.IsDBNull(row["PackID"]) ? 0 : Convert.ToInt32(row["PackID"].ToString()),
                    Pack_unit = row["Pack_unit"].ToString(),
                    Pack_Unit_Name = row["Pack_Unit_Name"].ToString(),
                    conver_sub = Convert.IsDBNull(row["conver_sub"]) ? 0 : Convert.ToDecimal(row["conver_sub"].ToString()),
                    unit_price = Convert.IsDBNull(row["unit_price"]) ? 0 : Convert.ToDecimal(row["unit_price"].ToString()),
                };
            }).ToList();
            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetTradePackgesByPackId(int id)
        {

            PackageDetails details = new PackageDetails();
            details.GetPackagesByPackID(id);
            /*
            v_EDDB_PackDetailes details = new v_EDDB_PackDetailes();
            details.GetPacksByTradeId(id);*/

            Models.PackageModel Alldetails = new Models.PackageModel (); 
            Alldetails.PackID = details.PackID;
            Alldetails.Pack_unit = details.GetColumn("Pack_unit").ToString();
            Alldetails.Pack_Unit_Name = details.GetColumn("Pack_Unit_Name").ToString();
            Alldetails.conver_sub = details.Conver_sub;
            Alldetails.unit_price = details.Unit_price;
            
            SetContentResult(Alldetails);
            //return _response;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetPricingInfoByPackageId(int id)
        {

            PackagePricing pricingDetails = new PackagePricing();
            pricingDetails.GetPricingInfoByPackageID(id);

            Models.PackgePricingModel Alldetails = new Models.PackgePricingModel();
            if (pricingDetails.RowCount > 0)
            {
                Alldetails.PackagePricingID = pricingDetails.PackagePricingID;
                Alldetails.PackID = pricingDetails.PackID;
                Alldetails.CompanyID = pricingDetails.IsColumnNull("CompanyID") ? 0 : pricingDetails.CompanyID;
                Alldetails.PricingStatusID = pricingDetails.IsColumnNull("PricingStatusID") ? 0 : pricingDetails.PricingStatusID;
                Alldetails.RegistrationCommitteTypeID = pricingDetails.IsColumnNull("RegistrationCommitteTypeID") ? 0 : pricingDetails.RegistrationCommitteTypeID;
                Alldetails.DosageFormID = pricingDetails.IsColumnNull("DosageFormID") ? 0 : pricingDetails.DosageFormID;
                Alldetails.FileTypeID = pricingDetails.IsColumnNull("FileTypeID") ? 0 : pricingDetails.FileTypeID;
                Alldetails.ManufactureID = pricingDetails.IsColumnNull("ManufactureID") ? 0 : pricingDetails.ManufactureID;
                Alldetails.AssignedUserID = pricingDetails.IsColumnNull("AssignedUserID") ? 0 : pricingDetails.AssignedUserID;
                Alldetails.TradeName = pricingDetails.TradeName;
                Alldetails.PackDetailes = pricingDetails.PackDetailes;
                Alldetails.CompanyPrice = pricingDetails.IsColumnNull("CompanyPrice") ? 0 : pricingDetails.CompanyPrice;
                Alldetails.CommittePrice = pricingDetails.IsColumnNull("CommittePrice") ? 0 : pricingDetails.CommittePrice;
                Alldetails.CommitteDate = pricingDetails.CommitteDate;
                Alldetails.DiscussionDate = pricingDetails.DiscussionDate;
                Alldetails.SubmissionDate = pricingDetails.SubmissionDate;
                Alldetails.Pack = pricingDetails.Pack;
                Alldetails.FileNo = pricingDetails.FileNo;
                Alldetails.Generic = pricingDetails.Generic;
                Alldetails.Trade_Notes = pricingDetails.Trade_Notes;
                Alldetails.ImportedManufacture = pricingDetails.ImportedManufacture;
                Alldetails.RegNo = pricingDetails.RegNo;
                Alldetails.Reference = pricingDetails.Reference;
                Alldetails.Indication = pricingDetails.Indication;
                Alldetails.Dose = pricingDetails.Dose;
                Alldetails.SubmittedToSpecialized = pricingDetails.IsColumnNull("SubmittedToSpecialized") ? false : pricingDetails.SubmittedToSpecialized;
                Alldetails.SalesTaxes = pricingDetails.IsColumnNull("SalesTaxes") ? false : pricingDetails.SalesTaxes;
                Alldetails.EssentialDrugList = pricingDetails.IsColumnNull("EssentialDrugList") ? false : pricingDetails.EssentialDrugList;
                Alldetails.TradePricingStatusID = pricingDetails.IsColumnNull("TradePricingStatusID") ? 0 : pricingDetails.TradePricingStatusID;
                Alldetails.TradePricingLicenseTypeID = pricingDetails.IsColumnNull("TradePricingLicenseTypeID") ? 0 : pricingDetails.TradePricingLicenseTypeID;
                Alldetails.SectorTypeID = pricingDetails.IsColumnNull("SectorTypeID") ? 0 : pricingDetails.SectorTypeID;
                Alldetails.CommitteePrice = pricingDetails.CommitteePrice;
                Alldetails.CommiteeDate = pricingDetails.IsColumnNull("CommiteeDate") ? DateTime.MinValue : pricingDetails.CommiteeDate;
                Alldetails.RationalForPricing = pricingDetails.RationalForPricing;
                Alldetails.NoInBox = pricingDetails.IsColumnNull("NoInBox") ? 0 : pricingDetails.NoInBox;
                Alldetails.LowestIntPrice = pricingDetails.LowestIntPrice;
                Alldetails.PriceInEgy = pricingDetails.PriceInEgy;
                Alldetails.PriceAfter30 = pricingDetails.PriceAfter30;
                Alldetails.PriceAfter35HighTech = pricingDetails.PriceAfter35HighTech;
                Alldetails.PriceAfter35FirstGeneric = pricingDetails.PriceAfter35FirstGeneric;
                Alldetails.PriceAfter40SecondGeneric = pricingDetails.PriceAfter40SecondGeneric;
                Alldetails.LowestPriceGeneric = pricingDetails.LowestPriceGeneric;
                Alldetails.FinalPrice = pricingDetails.FinalPrice;
                Alldetails.IsPricedTo499 = pricingDetails.IsColumnNull("IsPricedTo499") ? false : pricingDetails.IsPricedTo499;
                Alldetails.Notes = pricingDetails.Notes;
                Alldetails.MainGroup = pricingDetails.MainGroup;
                Alldetails.Similar = pricingDetails.IsColumnNull("Similar") ? false : pricingDetails.Similar;
                Alldetails.MonthYear = pricingDetails.MonthYear;
                Alldetails.PreviousPrice = pricingDetails.PreviousPrice;
                Alldetails.PreviousPack = pricingDetails.PreviousPack;
                Alldetails.FilePath = pricingDetails.FilePath;
                Alldetails.File_CoverLetter = pricingDetails.File_CoverLetter;
                Alldetails.File_BoxApproval = pricingDetails.File_BoxApproval;
                Alldetails.File_TradeNameApproval = pricingDetails.File_TradeNameApproval;
                Alldetails.File_CostSheet = pricingDetails.File_CostSheet;
                Alldetails.File_ProformaInvoice = pricingDetails.File_ProformaInvoice;
                Alldetails.File_CifPriceToEgypt = pricingDetails.File_CifPriceToEgypt;
                Alldetails.File_PriceOriginCountry = pricingDetails.File_PriceOriginCountry;
                Alldetails.File_CountryPrices = pricingDetails.File_CountryPrices;
                Alldetails.File_PackArtworkLeaflet = pricingDetails.File_PackArtworkLeaflet;
                Alldetails.File_Others = pricingDetails.File_Others;
                Alldetails.Generics = pricingDetails.Generics;
                Alldetails.GenericStrength = pricingDetails.GenericStrength;
                Alldetails.ApprovedPrice = pricingDetails.ApprovedPrice;
                Alldetails.PriceCategory = pricingDetails.PriceCategory;
                Alldetails.File_ministerapproval = pricingDetails.File_ministerapproval;
                Alldetails.Approvaldate = pricingDetails.IsColumnNull("Approvaldate") ? DateTime.MinValue : pricingDetails.Approvaldate;
                Alldetails.Issuedate = pricingDetails.IsColumnNull("Issuedate") ? DateTime.MinValue : pricingDetails.Issuedate;
                Alldetails.ApprovalLetters = pricingDetails.ApprovalLetters;
                Alldetails.Trade_Code = pricingDetails.IsColumnNull("Trade_Code") ? 0 : pricingDetails.Trade_Code;
            }
            SetContentResult(Alldetails);
            //return _response;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetPricingInfoByID(int ppid)
        {

            PackagePricing pricingDetails = new PackagePricing();
            pricingDetails.LoadByPrimaryKey(ppid);

            Models.PackgePricingModel Alldetails = new Models.PackgePricingModel();
            if (pricingDetails.RowCount > 0)
            {
                Alldetails.PackagePricingID = pricingDetails.PackagePricingID;
                Alldetails.PackID = pricingDetails.PackID;
                Alldetails.CompanyID = pricingDetails.IsColumnNull("CompanyID") ? 0 : pricingDetails.CompanyID;
                Alldetails.PricingStatusID = pricingDetails.IsColumnNull("PricingStatusID") ? 0 : pricingDetails.PricingStatusID;
                Alldetails.RegistrationCommitteTypeID = pricingDetails.IsColumnNull("RegistrationCommitteTypeID") ? 0 : pricingDetails.RegistrationCommitteTypeID;
                Alldetails.DosageFormID = pricingDetails.IsColumnNull("DosageFormID") ? 0 : pricingDetails.DosageFormID;
                Alldetails.FileTypeID = pricingDetails.IsColumnNull("FileTypeID") ? 0 : pricingDetails.FileTypeID;
                Alldetails.ManufactureID = pricingDetails.IsColumnNull("ManufactureID") ? 0 : pricingDetails.ManufactureID;
                Alldetails.AssignedUserID = pricingDetails.IsColumnNull("AssignedUserID") ? 0 : pricingDetails.AssignedUserID;
                Alldetails.TradeName = pricingDetails.TradeName;
                Alldetails.PackDetailes = pricingDetails.PackDetailes;
                Alldetails.CompanyPrice = pricingDetails.IsColumnNull("CompanyPrice") ? 0 : pricingDetails.CompanyPrice;
                Alldetails.CommittePrice = pricingDetails.IsColumnNull("CommittePrice") ? 0 : pricingDetails.CommittePrice;
                Alldetails.CommitteDate = pricingDetails.CommitteDate;
                Alldetails.DiscussionDate = pricingDetails.DiscussionDate;
                Alldetails.SubmissionDate = pricingDetails.SubmissionDate;
                Alldetails.Pack = pricingDetails.Pack;
                Alldetails.FileNo = pricingDetails.FileNo;
                Alldetails.Generic = pricingDetails.Generic;
                Alldetails.Trade_Notes = pricingDetails.Trade_Notes;
                Alldetails.ImportedManufacture = pricingDetails.ImportedManufacture;
                Alldetails.RegNo = pricingDetails.RegNo;
                Alldetails.Reference = pricingDetails.Reference;
                Alldetails.Indication = pricingDetails.Indication;
                Alldetails.Dose = pricingDetails.Dose;
                Alldetails.SubmittedToSpecialized = pricingDetails.IsColumnNull("SubmittedToSpecialized") ? false : pricingDetails.SubmittedToSpecialized;
                Alldetails.SalesTaxes = pricingDetails.IsColumnNull("SalesTaxes") ? false : pricingDetails.SalesTaxes;
                Alldetails.EssentialDrugList = pricingDetails.IsColumnNull("EssentialDrugList") ? false : pricingDetails.EssentialDrugList;
                Alldetails.TradePricingStatusID = pricingDetails.IsColumnNull("TradePricingStatusID") ? 0 : pricingDetails.TradePricingStatusID;
                Alldetails.TradePricingLicenseTypeID = pricingDetails.IsColumnNull("TradePricingLicenseTypeID") ? 0 : pricingDetails.TradePricingLicenseTypeID;
                Alldetails.SectorTypeID = pricingDetails.IsColumnNull("SectorTypeID") ? 0 : pricingDetails.SectorTypeID;
                Alldetails.CommitteePrice = pricingDetails.CommitteePrice;
                Alldetails.CommiteeDate = pricingDetails.IsColumnNull("CommiteeDate") ? DateTime.MinValue : pricingDetails.CommiteeDate;
                Alldetails.RationalForPricing = pricingDetails.RationalForPricing;
                Alldetails.NoInBox = pricingDetails.IsColumnNull("NoInBox") ? 0 : pricingDetails.NoInBox;
                Alldetails.LowestIntPrice = pricingDetails.LowestIntPrice;
                Alldetails.PriceInEgy = pricingDetails.PriceInEgy;
                Alldetails.PriceAfter30 = pricingDetails.PriceAfter30;
                Alldetails.PriceAfter35HighTech = pricingDetails.PriceAfter35HighTech;
                Alldetails.PriceAfter35FirstGeneric = pricingDetails.PriceAfter35FirstGeneric;
                Alldetails.PriceAfter40SecondGeneric = pricingDetails.PriceAfter40SecondGeneric;
                Alldetails.LowestPriceGeneric = pricingDetails.LowestPriceGeneric;
                Alldetails.FinalPrice = pricingDetails.FinalPrice;
                Alldetails.IsPricedTo499 = pricingDetails.IsColumnNull("IsPricedTo499") ? false : pricingDetails.IsPricedTo499;
                Alldetails.Notes = pricingDetails.Notes;
                Alldetails.MainGroup = pricingDetails.MainGroup;
                Alldetails.Similar = pricingDetails.IsColumnNull("Similar") ? false : pricingDetails.Similar;
                Alldetails.MonthYear = pricingDetails.MonthYear;
                Alldetails.PreviousPrice = pricingDetails.PreviousPrice;
                Alldetails.PreviousPack = pricingDetails.PreviousPack;
                Alldetails.FilePath = pricingDetails.FilePath;
                Alldetails.File_CoverLetter = pricingDetails.File_CoverLetter;
                Alldetails.File_BoxApproval = pricingDetails.File_BoxApproval;
                Alldetails.File_TradeNameApproval = pricingDetails.File_TradeNameApproval;
                Alldetails.File_CostSheet = pricingDetails.File_CostSheet;
                Alldetails.File_ProformaInvoice = pricingDetails.File_ProformaInvoice;
                Alldetails.File_CifPriceToEgypt = pricingDetails.File_CifPriceToEgypt;
                Alldetails.File_PriceOriginCountry = pricingDetails.File_PriceOriginCountry;
                Alldetails.File_CountryPrices = pricingDetails.File_CountryPrices;
                Alldetails.File_PackArtworkLeaflet = pricingDetails.File_PackArtworkLeaflet;
                Alldetails.File_Others = pricingDetails.File_Others;
                Alldetails.Generics = pricingDetails.Generics;
                Alldetails.GenericStrength = pricingDetails.GenericStrength;
                Alldetails.ApprovedPrice = pricingDetails.ApprovedPrice;
                Alldetails.PriceCategory = pricingDetails.PriceCategory;
                Alldetails.File_ministerapproval = pricingDetails.File_ministerapproval;
                Alldetails.Approvaldate = pricingDetails.IsColumnNull("Approvaldate") ? DateTime.MinValue : pricingDetails.Approvaldate;
                Alldetails.Issuedate = pricingDetails.IsColumnNull("Issuedate") ? DateTime.MinValue : pricingDetails.Issuedate;
                Alldetails.ApprovalLetters = pricingDetails.ApprovalLetters;
                Alldetails.Trade_Code = pricingDetails.IsColumnNull("Trade_Code") ? 0 : pricingDetails.Trade_Code;
            }
            SetContentResult(Alldetails);
            //return _response;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetStatusHistoryByPackageId(int id)
        {

            PackageStatusHistory statuses = new PackageStatusHistory();
            statuses.GetStatusHistoryByPackId(id);

            List<Models.PackageStatusHistoryModel> Alldetails = statuses.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.PackageStatusHistoryModel
                {
                    StatusHistoryID  = Convert.ToInt32(row["StatusHistoryID"].ToString()),
                    TradePricingID = Convert.IsDBNull(row["TradePricingID"]) ? 0 : Convert.ToInt32(row["TradePricingID"].ToString()),
                    PackageDetailID = Convert.IsDBNull(row["PackageDetailID"]) ? 0 : Convert.ToInt32(row["PackageDetailID"].ToString()),
                    CommitteeTypeID = Convert.IsDBNull(row["CommitteeTypeID"]) ? 0 : Convert.IsDBNull(row["CommitteeTypeID"]) ? 0 : Convert.ToInt32(row["CommitteeTypeID"].ToString()),
                    CommitteeDescisionID = Convert.IsDBNull(row["CommitteeDescisionID"]) ? 0 : Convert.ToInt32(row["CommitteeDescisionID"].ToString()),
                    CompanyDescisionID = Convert.IsDBNull(row["CompanyDescisionID"]) ? 0 : Convert.ToInt32(row["CompanyDescisionID"].ToString()),
                    PricingStatusID = Convert.IsDBNull(row["PricingStatusID"]) ? 0 : Convert.ToInt32(row["PricingStatusID"].ToString()),
                    CommitteDate = Convert.IsDBNull(row["CommitteDate"]) ? DateTime.MinValue : Convert.ToDateTime(row["CommitteDate"].ToString()),
                    CurrentPrice = Convert.IsDBNull(row["CurrentPrice"]) ? 0 : Convert.ToDecimal(row["CurrentPrice"].ToString()),
                    Comment  = row["Comment"].ToString(),
                    AttachementPath = row["AttachementPath"].ToString(),
                    StatusDate = Convert.IsDBNull(row["StatusDate"]) ? DateTime.MinValue : Convert.ToDateTime(row["StatusDate"].ToString()),
                    StatusHolder = row["StatusHolder"].ToString(),
                    Status = row["Status"].ToString(),
                    StatusDescription = row["StatusDescription"].ToString(),
                    TypeText = row["TypeText"].ToString(),
                    CssClass = getCssClass(Convert.IsDBNull(row["PricingStatusID"]) ? 0 : Convert.ToInt32(row["PricingStatusID"].ToString())),
                    PackID = Convert.IsDBNull(row["PackID"]) ? 0 : Convert.ToInt32(row["PackID"].ToString()),
                };

            }).ToList();
            SetContentResult(Alldetails);
            //return _response;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetNextStatuses(int currentStatusID)
        {
            PricingStatus statuses = new PricingStatus();
            statuses.GetStatusByParentID(currentStatusID);

            List<Models.StatusModel> Alldetails = statuses.DefaultView.Table.AsEnumerable().Select(row =>
            {
                return new Models.StatusModel
                {                    
                    PricingStatusID = Convert.IsDBNull(row["PricingStatusID"]) ? 0 : Convert.ToInt32(row["PricingStatusID"].ToString()),                    
                    StatusHolder = row["StatusHolder"].ToString(),
                    Status = row["Status"].ToString(),
                    Description = row["Description"].ToString(),                    
                };

            }).ToList();
            SetContentResult(Alldetails);
            //return _response;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void AddNewStatusHistory(Models.PackageStatusHistoryModel status)
        {
            PricingStatus st = new PricingStatus();
            st.LoadByPrimaryKey(status.PricingStatusID);
            PackageStatusHistory sh = new PackageStatusHistory();
            sh.AddNew();
            sh.TradePricingID = status.TradePricingID;
            sh.PackID = status.PackID;
            sh.Comment = status.Comment;
            sh.PricingStatusID = status.PricingStatusID;
            sh.StatusDate = DateTime.Now;
            sh.StatusHolder = st.StatusHolder;
            sh.Save();

            PackagePricing pp = new PackagePricing();
            pp.GetPricingInfoByPackageID(status.PackID);
            pp.PricingStatusID = sh.PricingStatusID;
            pp.Save();
            //return _response;
        }


        private string getCssClass(int statusid)
        {
            string cssclass="";
            switch (statusid)
            {
                case 1: // initiated
                    cssclass= "Initiated";
                    break;
                case 4: // Need More Info / Complete
                case 10: //Committee Postponded / Need More Info / Complete
                    cssclass = "Complete";
                    break;
                case 5: // Need More Info / Complete
                    cssclass = "CommitteeDateInformed";
                    break;
                case 2:
                    cssclass = "Accepted";
                    break;
                default:
                    cssclass = "default_Status";
                    break;
            }
            return cssclass;
        }


        private void SetContentResult(dynamic data)
        {
            string result = JsonConvert.SerializeObject(data, Formatting.None, new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });
            HttpContext.Current.Response.ContentType = "application/json; charset=utf-8";
            HttpContext.Current.Response.Write(result);
            HttpContext.Current.Response.Flush(); // Sends all currently buffered output to the client.
            HttpContext.Current.Response.SuppressContent = true;  // Gets or sets a value indicating whether to send HTTP content to the client.
            HttpContext.Current.ApplicationInstance.CompleteRequest(); // Causes ASP.NET to bypass all events and filtering in the HTTP pipeline chain of execution and directly execute the EndRequest event.
        }
    }
}
