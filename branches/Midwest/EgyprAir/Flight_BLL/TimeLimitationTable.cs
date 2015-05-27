
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Flight_DAL;
namespace Flight_BLL
{
	public class TimeLimitationTable : _TimeLimitationTable
	{
		public TimeLimitationTable()
		{
		
		}

        public virtual bool GetTimeLimitationPeriod(TimeSpan StartDutyTime, int NoOfSectors)
        {
            if (StartDutyTime >= new TimeSpan(22, 0, 0) || StartDutyTime <= new TimeSpan(5, 59, 0))
            {
                return LoadFromRawSql(@"select * from TimeLimitationTable
                                        where ({0} >= cast(TimeIntervalFrom as Time)  or 
	                                           {0} <= cast(TimeIntervalTo as Time) ) and 
	                                          NoOfSectors = {1} and 
	                                          cast(TimeIntervalFrom as Time) = '22:00'", StartDutyTime, NoOfSectors);
            }
            else
                return LoadFromRawSql(@"select * from TimeLimitationTable
                                        where {0} >= cast(TimeIntervalFrom as Time)  and 
	                                          {0} <= cast(TimeIntervalTo as Time)  and 
	                                          NoOfSectors = {1}", StartDutyTime, NoOfSectors);
        }
	}
}
