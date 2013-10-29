
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using WhiteChat.DAL;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data;
namespace WhiteChat.BLL
{
	public class ChatRoom : _ChatRoom
	{
		public ChatRoom()
		{
		
		}

        public virtual bool GetChatRoomsByCategoryID(int CategoryID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@CategoryID", SqlDbType.Int, 0), CategoryID);

            return LoadFromSql("GetChatRoomsByCategoryID", parameters);

        }



        public virtual bool GetChatRoomsBySubCategoryID(int SubCategoryID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@SubCategoryID", SqlDbType.Int, 0), SubCategoryID);

            return LoadFromSql("GetChatRoomsBySubCategoryID", parameters);

        }
	}
}