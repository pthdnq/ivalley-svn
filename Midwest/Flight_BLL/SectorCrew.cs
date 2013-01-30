
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Flight_DAL;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;

namespace Flight_BLL
{
	public class SectorCrew : _SectorCrew
	{
		public SectorCrew()
		{
		
		}

        public virtual bool GetCrewBySectorID(int SectorID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@SectorID", SqlDbType.Int, 0), SectorID);

            return LoadFromSql("GetCrewBySectorID", parameters);

        }
	}
}
