using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using View;

namespace PricingBLL
{
    public class v_EDDB_PackDetailes : _v_EDDB_PackDetailes
    {
        public bool GetDrugById(int id)
        {
            this.Where.TradeCode.Value = id;
            this.Where.TradeCode.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            return this.Query.Load();
        }
    }
}
