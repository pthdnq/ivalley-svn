
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class RoomMember : _RoomMember
    {
        public RoomMember()
        {

        }

        public virtual bool GetAllAdminMembersByRoomID(int RoomID)
        {
            return LoadFromRawSql(@"select RM.MemberID,RM.RoomID,MemberName=aspnet_Users.UserName
		                            ,RoomMemberLevelID=CASE WHEN RM.MemberID=Room.CreatedBy THEN {1} ELSE RM.RoomMemberLevelID END
                                    from RoomMember RM
                                    Inner Join Member M on RM.MemberId = M.MemberID
                                    Inner Join aspnet_Users on M.UserID = aspnet_Users.UserID
                                    INNER JOIN Room ON Room.RoomID=RM.RoomID
                                    where RM.RoomID = {0} and 
	                              RM.RoomMemberLevelID > 1", RoomID, (int)Helper.Enums.RoomMemberLevel.Owner);

        }

        public List<Helper.ChatMember> GetAdminsMembersByRoomID(int roomid)
        {
            GetAllAdminMembersByRoomID(roomid);
            return DefaultView.Table.AsEnumerable().Select(m =>
                new Helper.ChatMember()
                {
                    MemberID = Helper.TypeConverter.ToInt32(m[ColumnNames.MemberID]),
                    MemberName = m["MemberName"],
                    MemberLevelID = Helper.TypeConverter.ToInt32(m[ColumnNames.RoomMemberLevelID])
                }).ToList();
        }

        public virtual bool GetAllMembersByRoomID(int RoomID)
        {
            ListDictionary parameters = new ListDictionary();

            parameters.Add(new SqlParameter("@RoomID", SqlDbType.Int, 0), RoomID);

            return LoadFromSql("GetAllMembersByRoomID", parameters);

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

        public List<Helper.ChatMember> LoadWithSettings(int roomID,int? memberID)
        {
            int currentMemberID = BLL.Member.CurrentMemberID;
            string sql = @"SELECT RM.*,MemberName=aspnet_Users.UserName,M.ProfilePic,MTSpec.MemberTypeSpecID
                                ,B.EndDate,B.StartDate
                                ,IsMemberBanned=CASE WHEN B.RoomID IS NULL THEN 0 ELSE 1 END , 
                                HasGift = 0,
                                IsFriend= CASE WHEN Exists (Select * From MemberFriend WHERE FriendID=RM.MemberID AND MemberID={2}) THEN 1 ELSE 0 END
                            FROM RoomMember RM INNER JOIN Member M on RM.MemberID=M.MemberID
                            Inner Join aspnet_Users on M.UserID = aspnet_Users.UserID
                            LEFT JOIN MemberType MT ON MT.MemberID=M.MemberID
                            LEFT JOIN MemberTypeSpecDuration MTSpec ON MTSpec.ID=ISNULL(MT.MemberTypeSpecDurationID,{1}) 
                            LEFT JOIN RoomMemberBanning B ON B.RoomID=RM.RoomID AND B.MemberID=RM.MemberID AND (B.EndDate>=GETDATE() OR B.EndDate IS NULL)
                            WHERE RM.RoomID={0}";
            if (memberID.HasValue)
                sql += String.Format(" AND RM.MemberID={0}", memberID.Value);

            LoadFromRawSql(sql, roomID, Helper.Defaults.MemberTypeSpecDurationID,currentMemberID);

            return DefaultView.Table.AsEnumerable().Select(m =>
                new Helper.ChatMember()
            {
                MemberID = Helper.TypeConverter.ToInt32(m[ColumnNames.MemberID]),
                MemberName = m["MemberName"],
                ProfileImg = Helper.TypeConverter.ToString(m["ProfilePic"]),
                InRoom = Helper.TypeConverter.ToBoolean(m[ColumnNames.InRoom]),
                MemberTypeID = Helper.TypeConverter.ToInt32(m["MemberTypeSpecID"]),
                MemberLevelID = Helper.TypeConverter.ToInt32(m[ColumnNames.RoomMemberLevelID]),
                IsFavorite = Helper.TypeConverter.ToBoolean(m[ColumnNames.IsFavorite]),
                UserRate = Helper.TypeConverter.ToInt32(m[ColumnNames.UserRate]),
                CanAccessCam = Helper.TypeConverter.ToBoolean(m[ColumnNames.CanAccessCam]),
                CanAccessMic = Helper.TypeConverter.ToBoolean(m[ColumnNames.CanAccessMic]),
                CanWrite = Helper.TypeConverter.ToBoolean(m[ColumnNames.CanWrite]),
                IsMemberBanned = m["IsMemberBanned"],
                BanType = GetBanType(m["StartDate"], m["EndDate"]),
                QueueOrder = m[ColumnNames.QueueOrder],
                IsMicOpened = Helper.TypeConverter.ToBoolean(m[ColumnNames.HasMic]),
                IsCamOpened = Helper.TypeConverter.ToBoolean(m[ColumnNames.HasCam]),
                IsCamViewed = false,
                NotifyOnCloseCam = Helper.TypeConverter.ToBoolean(m[ColumnNames.NotifyOnCloseCam]),
                NotifyOnFriendsLogOff = Helper.TypeConverter.ToBoolean(m[ColumnNames.NotifyOnFriendsLogOff]),
                NotifyOnFriendsLogOn = Helper.TypeConverter.ToBoolean(m[ColumnNames.NotifyOnFriendsLogOn]),
                NotifyOnMicOff = Helper.TypeConverter.ToBoolean(m[ColumnNames.NotifyOnMicOff]),
                NotifyOnMicOn = Helper.TypeConverter.ToBoolean(m[ColumnNames.NotifyOnMicOn]),
                NotifyOnOpenCam = Helper.TypeConverter.ToBoolean(m[ColumnNames.NotifyOnOpenCam]),
                ShowMessageTime = Helper.TypeConverter.ToBoolean(m[ColumnNames.ShowMessageTime]),
                IsFriend = Helper.TypeConverter.ToBoolean(m["IsFriend"])
            }).ToList();
        }
        private int? GetBanType(object startDate, object endDate)
        {
            if (startDate == DBNull.Value)
                return null;
            if (endDate == DBNull.Value)
            {
                return (int)Helper.Enums.BanningType.Permanent;
            }
            DateTime start = (DateTime)startDate
                , end = (DateTime)endDate;
            int diffDays = (end.Date - start.Date).Days;
            if (diffDays == 1)
            {
                return (int)Helper.Enums.BanningType.Day;
            }
            if (diffDays == 7)
            {
                return (int)Helper.Enums.BanningType.Week;
            }

            return (int)Helper.Enums.BanningType.Month;
        }
        #region override properties reading
        public override short UserRate
        {
            get
            {
                if (IsColumnNull(ColumnNames.UserRate))
                    return 0;
                return base.UserRate;
            }
            set
            {
                base.UserRate = value;
            }
        }
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

        public override bool NotifyOnCloseCam
        {
            get
            {
                if (IsColumnNull(ColumnNames.NotifyOnCloseCam))
                    return false;
                return base.NotifyOnCloseCam;
            }
            set
            {
                base.NotifyOnCloseCam = value;
            }
        }
        public override bool NotifyOnFriendsLogOff
        {
            get
            {
                if (IsColumnNull(ColumnNames.NotifyOnFriendsLogOff))
                    return false;
                return base.NotifyOnFriendsLogOff;
            }
            set
            {
                base.NotifyOnFriendsLogOff = value;
            }
        }
        public override bool NotifyOnFriendsLogOn
        {
            get
            {
                if (IsColumnNull(ColumnNames.NotifyOnFriendsLogOn))
                    return false;
                return base.NotifyOnFriendsLogOn;
            }
            set
            {
                base.NotifyOnFriendsLogOn = value;
            }
        }
        public override bool NotifyOnMicOff
        {
            get
            {
                if (IsColumnNull(ColumnNames.NotifyOnMicOff))
                    return false;
                return base.NotifyOnMicOff;
            }
            set
            {
                base.NotifyOnMicOff = value;
            }
        }
        public override bool NotifyOnMicOn
        {
            get
            {
                if (IsColumnNull(ColumnNames.NotifyOnMicOn))
                    return false;
                return base.NotifyOnMicOn;
            }
            set
            {
                base.NotifyOnMicOn = value;
            }
        }
        public override bool NotifyOnOpenCam
        {
            get
            {
                if (IsColumnNull(ColumnNames.NotifyOnOpenCam))
                    return false;
                return base.NotifyOnOpenCam;
            }
            set
            {
                base.NotifyOnOpenCam = value;
            }
        }
        public override bool HasCam
        {
            get
            {
                if (IsColumnNull(ColumnNames.HasCam))
                    return false;
                return base.HasCam;
            }
            set
            {
                base.HasCam = value;
            }
        }
        public override bool HasMic
        {
            get
            {
                if (IsColumnNull(ColumnNames.HasMic))
                    return false;
                return base.HasMic;
            }
            set
            {
                base.HasMic = value;
            }
        }
        public override bool IsFavorite
        {
            get
            {
                if (IsColumnNull(ColumnNames.IsFavorite))
                    return false;
                return base.IsFavorite;
            }
            set
            {
                base.IsFavorite = value;
            }
        }
        public override bool InRoom
        {
            get
            {
                if (IsColumnNull(ColumnNames.InRoom))
                    return false;
                return base.InRoom;
            }
            set
            {
                base.InRoom = value;
            }
        }
        public override bool ShowMessageTime
        {
            get
            {
                if (IsColumnNull(ColumnNames.ShowMessageTime))
                    return false;
                return base.ShowMessageTime;
            }
            set
            {
                base.ShowMessageTime = value;
            }
        }
        #endregion
        public override void AddNew()
        {
            base.AddNew();
            CanAccessCam = true;
            CanAccessMic = true;
            CanWrite = true;
            RoomMemberLevelID = (int)Helper.Enums.RoomMemberLevel.Visitor;
        }

        public void ClearQueue(int roomID)
        {
            LoadFromRawSql(@"UPDATE RoomMember SET QueueOrder=NULL WHERE QueueOrder IS NOT NULL AND RoomID={0}", roomID);
        }

        public void OutRoomMembers(int roomID)
        {
            LoadFromRawSql(@"UPDATE RoomMember SET QueueOrder=NULL ,InRoom=0 WHERE RoomID={0}", roomID);
        }

        public bool HasExisitingMembersExceedCurrentMemberLevel(int roomID, int adminID)
        {
            return LoadFromRawSql(@"select RM.*,MemberName=aspnet_Users.UserName
                                    FROM RoomMember  RM 
                                    INNER JOIN Member M on RM.MemberID=M.MemberID
                                    Inner Join aspnet_Users on M.UserID = aspnet_Users.UserID
                                    WHERE RM.InRoom=1 AND RM.RoomID={0}
	                                    AND RM.RoomMemberLevelID > (SELECT RoomMemberLevelID FROM RoomMember WHERE  RoomID={0} AND MemberID={1})", 
                                  roomID, adminID);
        }
    }
}
