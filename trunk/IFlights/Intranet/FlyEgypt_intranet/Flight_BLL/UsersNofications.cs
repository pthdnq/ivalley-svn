
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using Flight_DAL;
using System.Collections.Generic;


namespace Flight_BLL
{
    public class UsersNofications : _UsersNofications
    {
        public UsersNofications()
        {

        }

        public virtual bool getNotifications(Guid UserID)
        {
            return LoadFromRawSql("SELECT COUNT(UserNotificationID) NotifCount,NotificationTypes.NotificationTypeID, UserID FROM NotificationTypes LEFT JOIN UsersNofications ON NotificationTypes.NotificationTypeID = UsersNofications.NotificationType and UsersNofications.UserID = {0} and (IsRead <> 1 or IsRead is null) GROUP BY NotificationTypes.NotificationTypeID, UserID", UserID);
        }

        public virtual bool getNotificationsByNotificationType(Guid UserID, int NotificationType)
        {
            return LoadFromRawSql("SELECT COUNT(UserNotificationID) NotifCount FROM NotificationTypes left JOIN UsersNofications ON NotificationTypes.NotificationTypeID = UsersNofications.NotificationType and UsersNofications.UserID = {0} WHERE (IsRead <> 1 or IsRead is null) AND NotificationTypes.NotificationTypeID = {1}", UserID, NotificationType);
        }

        public virtual bool getManualsNotificationCounter(Guid UserID)
        {
            return LoadFromRawSql("SELECT COUNT(UserNotificationID) NotifCount FROM NotificationTypes left JOIN UsersNofications ON NotificationTypes.NotificationTypeID = UsersNofications.NotificationType and UsersNofications.UserID = {0} WHERE (IsRead <> 1 or IsRead is null) AND (NotificationTypes.NotificationTypeID = 3 OR NotificationTypes.NotificationTypeID = 4)", UserID);
        }

        public virtual bool getReadedNotifications(Guid UserID)
        {
            return LoadFromRawSql("SELECT COUNT(UserNotificationID) NotifCount,NotificationTypes.NotificationTypeID, UserID FROM NotificationTypes LEFT JOIN UsersNofications ON NotificationTypes.NotificationTypeID = UsersNofications.NotificationType and UsersNofications.UserID = {0} and (IsRead = 1 ) GROUP BY NotificationTypes.NotificationTypeID, UserID", UserID);
        }

        public virtual bool getNotificationByCatID(Guid UserID, int CatID)
        {
            return LoadFromRawSql("SELECT COUNT(UserNotificationID) NotifCount FROM UsersNofications WHERE UserID = {0} AND CategoryID = {1} AND (IsRead <> 1 or IsRead is null)", UserID, CatID);
        }

        public virtual bool MarkNotificationsReadByNotificationType(Guid UserID, int NotificationType)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE UserID = {0} AND NotificationType={1}", UserID, NotificationType);
        }

        public virtual bool MarkNotificationsReadByManualCategoryID(Guid UserID, int NotificationTypeID , int CategoryID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE UserID = {0} AND NotificationType= {1} AND CategoryID = {2} AND FormID is null AND ManualVersionID is null AND FromVersionID is null", UserID, NotificationTypeID, CategoryID);
        }

        public virtual bool MarkSchedulesNotificationsRead(Guid UserID, int NotificationTypeID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE UserID = {0} AND NotificationType= {1} AND ScheduleVersionID is null", UserID, NotificationTypeID);
        }

        public virtual bool MarkNotificationsReadByManualVersionID(Guid UserID, int ManualID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE UserID = {0} AND NotificationType=3 AND ManualID = {1} AND FormID is null AND FromVersionID is null", UserID, ManualID);
        }
        public virtual bool MarkNotificationsReadByScheduleVersionID(Guid UserID, int ScheduleID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE UserID = {0} AND NotificationType=8 AND ScheduleID = {1} AND FormID is null AND FromVersionID is null", UserID, ScheduleID);
        }

        public virtual bool MarkNotificationReadByFormID(Guid UserID, int ManualID )
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE UserID = {0} AND NotificationType=4 AND ManualID = {1} AND ManualVersionID is null AND FromVersionID is null", UserID, ManualID);
        }

        public virtual bool MarkNotificationReadByFormVersionID(Guid UserID, int ManualFormID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE UserID = {0} AND NotificationType=4 AND FormID = {1} AND ManualVersionID is null", UserID, ManualFormID);
        }

        public virtual bool getUnreadSchedulesByUserID(Guid UserID)
        {
            return LoadFromRawSql("SELECT ScheduleID FROM UsersNofications WHERE UserID = {0} AND ScheduleID is not null AND IsRead = 0 AND ScheduleVersionID is null", UserID);
        }
        public virtual bool getUnreadSchedulesVersionsByUserID(Guid UserID)
        {
            return LoadFromRawSql("SELECT ScheduleVersionID FROM UsersNofications WHERE UserID = {0} AND IsRead = 0 AND ScheduleVersionID is not null", UserID);
        }

        public virtual bool getUnreadManualsByUserIDAndCatID(Guid UserID, int CatID)
        {
            return LoadFromRawSql("SELECT ManualID FROM UsersNofications WHERE UserID = {0} AND ManualID is not null AND CategoryID = {1} AND IsRead = 0 AND ManualVersionID is null AND FormID is null AND FromVersionID is null", UserID, CatID);
        }
        public virtual bool getUnreadManualsVersionsByUserIDAndManualID(Guid UserID, int ManualID)
        {
            return LoadFromRawSql("SELECT ManualVersionID FROM UsersNofications WHERE UserID = {0} AND ManualID = {1} AND ManualVersionID is not null AND IsRead = 0 AND FormID is null AND FromVersionID is null", UserID, ManualID);
        }
        public virtual bool getUnreadFormsByUserIDAndManualID(Guid UserID, int ManualID)
        {
            return LoadFromRawSql("SELECT FormID FROM UsersNofications WHERE UserID = {0} AND ManualID = {1} AND FormID is not null AND IsRead = 0 AND ManualVersionID is null AND FromVersionID is null", UserID, ManualID);
        }
        public virtual bool getUnreadFormsVersionsByUserIDAndFormID(Guid UserID, int FormID)
        {
            return LoadFromRawSql("SELECT FromVersionID FROM UsersNofications WHERE UserID = {0} AND FormID = {1} AND FromVersionID is not null AND IsRead = 0 AND ManualVersionID is null", UserID,FormID);
        }
        public virtual bool markDeletedManualNotificationsRead(int ManualID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE ManualID = {0}", ManualID);
        }
        public virtual bool markDeletedManualVersionNotificationsRead(int ManualVersionID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE ManualVersionID = {0}", ManualVersionID);
        }
        public virtual bool markDeletedFormNotificationsRead(int FormID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE FormID = {0}", FormID);
        }
        public virtual bool markDeletedFormVersionNotificationsRead(int FormVersionID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE FromVersionID = {0}", FormVersionID);
        }
        public virtual bool markDeletedScheduleNotificationsRead(int ScheduleID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE ScheduleID = {0}", ScheduleID);
        }
        public virtual bool markDeletedScheduleVersionNotificationsRead(int ScheduleVersionID)
        {
            return LoadFromRawSql("UPDATE UsersNofications SET IsRead = 1 WHERE ScheduleVersionID = {0}", ScheduleVersionID);
        }

    }
}
