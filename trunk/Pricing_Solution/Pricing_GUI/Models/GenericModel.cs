using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pricing_GUI.Models
{
    public class GenericModel
    {
        public int GenericName_ID { get; set; }
        public string GenericName { get; set; }
        public string Indications { get; set; }
        public string Cautions { get; set; }
        public string Contra_indications { get; set; }
        public string Side_effects { get; set; }
        public string Dose { get; set; }
        public string InterActionLevelCode { get; set; }
        public string Interaction { get; set; }
        public string General { get; set; }
        public string HDL { get; set; }
        public string STORE { get; set; }
        public int CPNUM { get; set; }
        public int Dilution { get; set; }
        public decimal MaxChemoDose { get; set; }
        public int TPNIngredient { get; set; }
        public int ChemoCalcType { get; set; }
        public int IsVaccine { get; set; }
        public int TradeName_ID { get; set; }
        public string strengthunitstr { get; set; }
        public decimal StrengthValue { get; set; }
        public int strengthunit { get; set; }
    }
}