
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Combo.DAL;
namespace Combo.BLL
{
	public class PostUserTag : _PostUserTag
	{
		public PostUserTag()
		{
		
		}

        public virtual bool GetUserTagsByPostID(int PostID)
        {
            return LoadFromRawSql(@"Select PT.*, CU.Username from PostUserTag PT 
                                    Inner Join ComboUser CU on PT.ComboUserID = CU.ComboUserID where PT.ComboPostID = {0}", PostID);
        }
	}
}
