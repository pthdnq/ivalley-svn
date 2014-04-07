
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Flight_DAL;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;


namespace Flight_BLL
{
	public class FlightPilot : _FlightPilot
	{
		public FlightPilot()
		{
		
		}

        public virtual bool GetPilotByFlightID(int FlightID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@ReportID", SqlDbType.Int, 0), FlightID);

            return LoadFromSql("GetPilotByReportID", parameters);

        }
	}
}