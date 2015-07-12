using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using View;

namespace PricingBLL
{
    public class V_EDDB_DrugGenerics : _V_EDDB_DrugGenerics
    {
        public bool GetDrugById(int id)
        {
            this.Where.TradeName_ID.Value = id;
            this.Where.TradeName_ID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            return this.Query.Load();
        }
    }
}
