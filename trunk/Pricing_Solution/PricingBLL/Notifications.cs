
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Pricing.DAL;// We should use the namespace of Data access layer generated form business entity
using System.Data; // Added by Michael
using System.Data.SqlClient; // Added by Michael

namespace Pricing.BLL
{
	public class Notifications : _Notifications
	{
		public Notifications()
		{
		
		}

        public virtual bool GetTopGeneralNotifications()
        {
            this.Query.Top = 5;            
            this.Where.CompanyID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.IsNull;
            this.Query.AddOrderBy(ColumnNames.NotifyDate, MyGeneration.dOOdads.WhereParameter.Dir.DESC);
            return this.Query.Load();
        }

        public virtual bool GetTopPrivateNotifications(int CompanyID)
        {
            this.Query.Top = 5;
            this.Where.CompanyID.Value = CompanyID;
            this.Where.CompanyID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            this.Query.AddOrderBy(ColumnNames.NotifyDate, MyGeneration.dOOdads.WhereParameter.Dir.DESC);
            return this.Query.Load();
        }
	}
}