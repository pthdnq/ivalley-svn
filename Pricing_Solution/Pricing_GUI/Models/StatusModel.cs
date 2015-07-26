using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pricing_GUI.Models
{
    public class StatusModel
    {
        public int PricingStatusID {get; set;}
        public string Status {get; set;}
        public string Description {get; set;}
        public string StatusHolder { get; set; } 
    }
}