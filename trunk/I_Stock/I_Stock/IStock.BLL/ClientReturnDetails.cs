
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using IStock.DAL;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;
namespace IStock.BLL
{
	public class ClientReturnDetails : _ClientReturnDetails
	{
		public ClientReturnDetails()
		{
		
		}

        public virtual bool GetClientReturnDetails(int ClientReturnID)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@ClientReturnID", SqlDbType.Int, 0), ClientReturnID);
            return LoadFromSql("GetClientReturnDetails", parameters);
        }
	}
}
