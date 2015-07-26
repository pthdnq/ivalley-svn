using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pricing_GUI.Models
{
    public class PackgePricingModel
    {
        public int PackagePricingID { get; set; } 
        public int PackID { get; set; } 
        public int CompanyID { get; set; } 
        public int PricingStatusID { get; set; } 
        public int RegistrationCommitteTypeID { get; set; } 
        public int DosageFormID { get; set; } 
        public int FileTypeID { get; set; } 
        public int ManufactureID { get; set; } 
        public int AssignedUserID { get; set; } 
        public string TradeName { get; set; } 
        public string PackDetailes { get; set; } 
        public double CompanyPrice { get; set; } 
        public double CommittePrice { get; set; } 
        public string CommitteDate { get; set; } 
        public string DiscussionDate { get; set; } 
        public string SubmissionDate { get; set; } 
        public string Pack { get; set; } 
        public string FileNo { get; set; } 
        public string Generic { get; set; } 
        public string Trade_Notes { get; set; } 
        public string ImportedManufacture { get; set; }
        public string RegNo { get; set; }
        public string Reference { get; set; } 
        public string Indication { get; set; }
        public string Dose { get; set; } 
        public bool SubmittedToSpecialized { get; set; }
        public bool SalesTaxes { get; set; } 
        public bool EssentialDrugList { get; set; } 
        public int TradePricingStatusID { get; set; } 
        public int TradePricingLicenseTypeID { get; set; } 
        public int SectorTypeID { get; set; } 
        public string CommitteePrice { get; set; } 
        public DateTime CommiteeDate { get; set; } 
        public string RationalForPricing { get; set; } 
        public int NoInBox { get; set; }
        public string LowestIntPrice { get; set; } 
        public string PriceInEgy { get; set; }
        public string PriceAfter30 { get; set; } 
        public string PriceAfter35HighTech { get; set; } 
        public string PriceAfter35FirstGeneric { get; set; } 
        public string PriceAfter40SecondGeneric { get; set; }
        public string LowestPriceGeneric { get; set; } 
        public string FinalPrice { get; set; } 
        public bool IsPricedTo499 { get; set; }
        public string Notes { get; set; } 
        public string MainGroup { get; set; } 
        public bool Similar { get; set; } 
        public string MonthYear { get; set; } 
        public string PreviousPrice { get; set; } 
        public string PreviousPack { get; set; } 
        public string FilePath { get; set; } 
        public string File_CoverLetter { get; set; } 
        public string File_BoxApproval { get; set; } 
        public string File_TradeNameApproval { get; set; }
        public string File_CostSheet { get; set; } 
        public string File_ProformaInvoice { get; set; } 
        public string File_CifPriceToEgypt { get; set; } 
        public string File_PriceOriginCountry { get; set; } 
        public string File_CountryPrices { get; set; }
        public string File_PackArtworkLeaflet { get; set; }
        public string File_Others { get; set; } 
        public string Generics { get; set; } 
        public string GenericStrength { get; set; } 
        public string ApprovedPrice { get; set; } 
        public string PriceCategory { get; set; } 
        public string File_ministerapproval { get; set; } 
        public DateTime Approvaldate { get; set; }
        public DateTime Issuedate { get; set; }
        public string ApprovalLetters { get; set; } 
        public int Trade_Code { get; set; } 
    }
}