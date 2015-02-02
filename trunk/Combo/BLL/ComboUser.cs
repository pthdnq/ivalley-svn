
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Combo.DAL;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;
namespace Combo.BLL
{
	public class ComboUser : _ComboUser
	{
		public ComboUser()
		{
		
		}

        public virtual bool GetUserByUserNameAndPassword(string UserName, string Password)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 200), UserName);
            parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 200), Password);
            return LoadFromSql("GetUserByUserNameAndPassword", parameters);

        }

        public virtual bool GetUserByUserName(string UserName)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 200), UserName);            
            return LoadFromSql("GetUserByUserName", parameters);

        }

        public virtual bool GetUserStatisticsByUserId(int UserId)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@UserId", SqlDbType.Int, 0), UserId);
            return LoadFromSql("GetUserStatisticsByUserId", parameters);

        }

        
        
	}
}
