
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Flight_DAL;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;
namespace Flight_BLL
{
	public class Manual : _Manual
	{
		public Manual()
		{
		
		}


        public virtual bool GetManualsByCatID(int CatID, string filterText)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@CatID", SqlDbType.Int, 0), CatID);
            parameters.Add(new SqlParameter("@filterText", SqlDbType.NVarChar, 50), filterText);

            return LoadFromSql("GetManualsByCatID_Admin", parameters);
        }

        public virtual bool GetManualsByCatID(int CatID, Guid UserID, string filterText)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@CatID", SqlDbType.Int, 0), CatID);
            parameters.Add(new SqlParameter("@filterText", SqlDbType.NVarChar, 50), filterText);
            parameters.Add(new SqlParameter("@UserID", SqlDbType.UniqueIdentifier, 0), UserID);
            return LoadFromSql("GetManualsByCatID_User", parameters);
        }

        public virtual bool GetFormsByCatID(int CatID)
        {
            this.Where.ManualCategoryID.Value = CatID;
            this.Where.ManualCategoryID.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            this.Where.IsForm.Value = true;
            this.Where.IsForm.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            this.Where.IsForm.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            return this.Query.Load();
        }
	}
}
