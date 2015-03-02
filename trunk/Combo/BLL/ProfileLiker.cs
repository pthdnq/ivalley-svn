
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Combo.DAL;
namespace Combo.BLL
{
	public class ProfileLiker : _ProfileLiker
	{
		public ProfileLiker()
		{
		
		}

        public virtual bool GetProfileLikerByUserID(int userid)
        {
            return LoadFromRawSql(@"Select CU.*, A.Path ProfilePic from ProfileLiker PF
                                    Inner Join ComboUser CU on PF.ComboLikerID = CU.ComboUserID
                                    Left join Attachment A on CU.ProfileImgID = A.AttachmentID
                                    Where PF.ComboUserID = {0} and (CU.IsDeactivated <> 1 or CU.IsDeactivated is null)", userid);
        }



	}
}
