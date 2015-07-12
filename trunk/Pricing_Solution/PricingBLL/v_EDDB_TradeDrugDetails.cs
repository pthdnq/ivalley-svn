using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using View;

namespace PricingBLL
{
    public class v_EDDB_TradeDrugDetails : _v_EDDB_TradeDrugDetails
    {
        public bool SearchDrugs(string name, string generics, decimal strength, string company, string regNo )
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@Trade_name", SqlDbType.VarChar, 300), name);
            parameters.Add(new SqlParameter("@generics", SqlDbType.VarChar, 500), generics);
            parameters.Add(new SqlParameter("@Strength_value", SqlDbType.Decimal, 0), strength);
            parameters.Add(new SqlParameter("@Applicant", SqlDbType.VarChar, 500), company);
            parameters.Add(new SqlParameter("@drug_license_number", SqlDbType.VarChar, 50), regNo);

            return LoadFromSql("SearchDrugs", parameters);
        }

        public bool GetDrugById(int id)
        {
            this.Where.TradeCode.Value = id;
            this.Where.TradeCode.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            return this.Query.Load();
        }

    }
}
