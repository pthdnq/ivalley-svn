
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Flight_DAL;
namespace Flight_BLL
{
	public class FromVersion : _FromVersion
	{
		public FromVersion()
		{
		
		}

        public bool GetVersionsByFormID(int p)
        {
            return LoadFromRawSql(@"select M.*, U.username UpdatedByName , C.username CreatedByName from FromVersion M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID
                                    where ManualFromID = {0} order by CreatedDate desc", p);            
        }
    }
}
