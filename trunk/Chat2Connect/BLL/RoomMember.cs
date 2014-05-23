
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public class RoomMember : _RoomMember
    {
        public RoomMember()
        {

        }

        public virtual bool GetAllAdminMembersByRoomID(int RoomID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int, 0), RoomID);

            return LoadFromSql("GetAllAdminMembersByRoomID", parameters);

        }

        public virtual bool GetAllMembersByRoomID(int RoomID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int, 0), RoomID);

            return LoadFromSql("GetAllMembersByRoomID", parameters);

        }

        public virtual bool GetOnlineMembersByRoomID(int RoomID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int, 0), RoomID);

            return LoadFromSql("GetOnlineMembersByRoomID", parameters);

        }

        public virtual bool GetAllMembersByRoomIDNoQueue(int RoomID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int, 0), RoomID);

            return LoadFromSql("GetAllMembersByRoomIDNoQueue", parameters);

        }

        public virtual bool GetAllMembersByRoomIDInQueue(int RoomID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int, 0), RoomID);

            return LoadFromSql("GetAllMembersByRoomIDQueue", parameters);

        }

        public virtual bool GetMaxQueueOrderByRoomID(int RoomID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int, 0), RoomID);

            return LoadFromSql("GetMaxQueueOrderByRoomID", parameters);

        }

        public virtual bool GetAllRoomsByMemberID(int MemberID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int, 0), MemberID);

            return LoadFromSql("GetAllRoomsByMemberID", parameters);

        }

        public bool GetAllRoomsByAdminMemberID(int MemberID)
        {
            return LoadFromRawSql("select RoomMember.*,[RoomName]=Room.Name from RoomMember INNER JOIN Room ON Room.RoomID=RoomMember.RoomID WHERE IsAdmin=1 AND RoomMember.MemberID={0}", MemberID);
        }

        public bool LoadAllRoomMembersWithSettings(int roomID)
        {
            string sql = @"SELECT RM.MemberID,RM.RoomID,MemberName=M.Name,CanAccessCam=ISNULL(RM.CanAccessCam,0),CanAccessMic=ISNULL(RM.CanAccessMic,0),CanWrite=ISNULL(RM.CanWrite,0)
	                            ,BanDays=DATEDIFF(day,B.EndDate,B.StartDate)
                                ,B.EndDate,B.StartDate
	                            ,IsMemberBanned=CASE WHEN B.RoomID IS NULL THEN 0 ELSE 1 END 
                            FROM RoomMember RM INNER JOIN Member M on RM.MemberID=M.MemberID
                            LEFT JOIN RoomMemberBanning B ON B.RoomID=RM.RoomID AND B.MemberID=RM.MemberID AND (B.EndDate>=GETDATE() OR B.EndDate IS NULL)
                            WHERE RM.RoomID={0}";
            return LoadFromRawSql(sql, roomID);
        }

        #region override properties reading
        public override bool CanAccessCam
        {
            get
            {
                if (IsColumnNull(RoomMember.ColumnNames.CanAccessCam))
                    return false;
                return base.CanAccessCam;
            }
            set
            {
                base.CanAccessCam = value;
            }
        }
        public override bool CanAccessMic
        {
            get
            {
                if (IsColumnNull(RoomMember.ColumnNames.CanAccessMic))
                    return false;
                return base.CanAccessMic;
            }
            set
            {
                base.CanAccessMic = value;
            }
        }
        public override bool CanWrite
        {
            get
            {
                if (IsColumnNull(RoomMember.ColumnNames.CanWrite))
                    return false;
                return base.CanWrite;
            }
            set
            {
                base.CanWrite = value;
            }
        }
        public override bool IsBanned
        {
            get
            {
                if (IsColumnNull(RoomMember.ColumnNames.IsBanned))
                    return false;
                return base.IsBanned;
            }
            set
            {
                base.IsBanned = value;
            }
        }
        public override bool IsMarked
        {
            get
            {
                if (IsColumnNull(RoomMember.ColumnNames.IsMarked))
                    return false;
                return base.IsMarked;
            }
            set
            {
                base.IsMarked = value;
            }
        }
        #endregion
    }
}
