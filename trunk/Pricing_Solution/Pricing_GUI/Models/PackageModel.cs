using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pricing_GUI.Models
{
    public class PackageModel
    {
        public int PackID { get; set; }
        public string Pack_unit { get; set; }
        public string Pack_Unit_Name { get; set; }
        public decimal conver_sub { get; set; }
        public decimal unit_price { get; set; }
    }
}