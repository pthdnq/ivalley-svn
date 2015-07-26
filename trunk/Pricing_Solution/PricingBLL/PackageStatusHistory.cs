
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using PricingDAL;
namespace PricingBLL
{
	public class PackageStatusHistory : _PackageStatusHistory
	{
		public PackageStatusHistory()
		{
		        
		}

        public bool GetStatusHistoryByPackId(int PackId)
        {
            return LoadFromRawSql(@"SELECT S.* , C.TypeText, PS.Status, PS.Description AS StatusDescription
                                   FROM dbo.PackageStatusHistory S INNER JOIN
                                    dbo.PricingStatus PS ON S.PricingStatusID = PS.PricingStatusID LEFT OUTER JOIN
                                    dbo.CommitteTypes C ON S.CommitteeTypeID = C.CommiteeTypeID
                                    where S.PackID = {0}
                                    order by S.StatusDate desc", PackId);
        }
	}
}
