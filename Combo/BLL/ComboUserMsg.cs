
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Combo.DAL;
namespace Combo.BLL
{
	public class ComboUserMsg : _ComboUserMsg
	{
		public ComboUserMsg()
		{
		
		}

        public virtual bool GetMessagesByUserID(int userid)
        {
            return LoadFromRawSql(@"Select P.* from ComboPost P
                                    Where P.ComboUserID = {0} and 
                                    (P.IsDeleted <> 1 or P.IsDeleted is null)", userid);
        }
	}
}
