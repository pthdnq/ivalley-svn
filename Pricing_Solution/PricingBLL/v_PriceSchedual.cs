
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using View;// We should use the namespace of Data access layer generated form business entity

namespace Pricing.BLL
{
	public class v_PriceSchedual : _v_PriceSchedual
	{
        public v_PriceSchedual()
		{
		
		}

        public void SearchByTradeID(int _tradeID)
        {
            this.Where.TradePricingID.Value = _tradeID;
            this.Where.TradePricingID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;

            this.Query.Load();
        }
	}
}
