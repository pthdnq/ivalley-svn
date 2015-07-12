using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pricing_GUI.Models
{
    public class TradeDrugModel
    {
        public int  TradeCode { get; set; } 
        public string  Drug_license_number  { get; set; } 
        public string  Trade_name  { get; set; } 
        public decimal  Strength_value  { get; set; } 
        public string  Type_of_license  { get; set; } 
        public string  Strength_unit  { get; set; } 
        public string  Dosage_form  { get; set; } 
        public string  Generics { get; set; } 
        public string  LicHold { get; set; } 
        public string  Manufacturer { get; set; } 
        public string  Packager { get; set; } 
        public string  BatchReleaser { get; set; } 
        public string  APISupplier { get; set; } 
        public string  StorageSite { get; set; } 
        public string  Type { get; set; } 
        public int  CompanyDetID { get; set; }
        public string  Applicant { get; set; }
    }
}