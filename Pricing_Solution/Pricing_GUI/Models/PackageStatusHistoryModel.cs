using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pricing_GUI.Models
{
    public class PackageStatusHistoryModel
    {
        public int StatusHistoryID { get; set; }
        public int TradePricingID { get; set; }
        public int PackageDetailID { get; set; }
        public int CommitteeTypeID { get; set; }
        public int CommitteeDescisionID { get; set; }
        public int CompanyDescisionID { get; set; }
        public int PricingStatusID { get; set; } 
        public DateTime CommitteDate { get; set; }
        public decimal CurrentPrice { get; set; }
        public string Comment { get; set; }
        public string AttachementPath { get; set; }
        public DateTime StatusDate { get; set; }
        public string StatusHolder { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public string TypeText { get; set; }
        public string CssClass { get; set; }
        public int PackID { get; set; }
    }
}