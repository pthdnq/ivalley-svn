
If Exists (select Name 
		   from sysobjects 
		   where name = 'AppConfig' and
		        xtype = 'U')
Drop Table AppConfig
Go
Create Table AppConfig
(
	AppConfigId int identity(1,1) primary key,
	AppName nvarchar(200),
	Title nvarchar(400),
	LogoPath nvarchar(700),
	CssPath nvarchar(700)
)
Go




If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAppConfig' and
		        xtype = 'P')
Drop Procedure GetAppConfig
Go
Create Procedure GetAppConfig 
as

Select Top 1 * from AppConfig 
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'UserGroup' and
		        xtype = 'U')
Drop Table UserGroup
Go
Create Table UserGroup
(
	UserId uniqueidentifier foreign key references aspnet_users(userID),
	GroupId int foreign key references Groups(GroupID),
	Primary key (UserId, GroupId)
)
Go

insert into UserGroup
select U.UserID, U.GroupID from UsersProfiles U
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetUserLoginReport' and
		        xtype = 'P')
Drop Procedure GetUserLoginReport
Go
Create Procedure GetUserLoginReport @UserID uniqueidentifier,
							   @FromDate DateTime = null,
							   @ToDate DateTime = null
as

Select U.FullName, A.ActionName, L.LogDate
from LoginLog L
INNER JOIN UsersProfiles U on L.UserID = U.UserID
Inner JOIN Actions A on L.ActionID = A.ActionID

where ( @UserID = L.UserID or @UserID is null) And
	  l.LogDate >= (ISNULL(@FromDate, '01/01/1900')) And 
	  l.LogDate <= (ISNULL(@ToDate, '01/01/2500')) 
order by L.LogDate desc
Go

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetUsersNotLoginReport' and
		        xtype = 'P')
Drop Procedure GetUsersNotLoginReport
Go
Create Procedure GetUsersNotLoginReport 
							   @NoOfDays int = 0
as
Select U.FullName, A.ActionName, Max(L.LogDate) LogDate
from UsersProfiles U
Left JOIN LoginLog L on L.UserID = U.UserID 
Left JOIN Actions A on L.ActionID = A.ActionID 
--and					   L.ActionID = 6

Group by U.FullName, A.ActionName, L.ActionID
having  DateDiff(day, max(isnull(l.LogDate,'01/01/1900')), GetDate()) >= (ISNULL(@NoOfDays, 0)) and (L.ActionID = 6 or L.ActionID is null)

Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAnnouncementLogReport' and
		        xtype = 'P')
Drop Procedure GetAnnouncementLogReport
Go
Create Procedure GetAnnouncementLogReport @AnnouncementID int							   
as

Select U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
Left JOIN AnnouncementLog L on L.UserID = U.UserID 
left JOIN Actions A on L.ActionID = A.ActionID
left join Announcement an on an.AnnouncementID = l.AnnouncementID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.AnnouncementID = @AnnouncementID or L.AnnouncementID is null
order by L.LogDate desc
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAnnouncementLogReportForGroup' and
		        xtype = 'P')
Drop Procedure GetAnnouncementLogReportForGroup
Go
Create Procedure GetAnnouncementLogReportForGroup @AnnouncementID int							   
as

Select distinct U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
inner join UserGroup ug on U.UserID = ug.UserId
Left JOIN AnnouncementLog L on L.UserID = U.UserID and
							   L.announcementID = @AnnouncementID
left JOIN Actions A on L.ActionID = A.ActionID
left join Announcement an on an.AnnouncementID = l.AnnouncementID
left join aspnet_Users us on us.UserId = an.CreatedBy

where ug.GroupId in (select GroupId from AnnouncementGroup where AnnouncementID = @AnnouncementID)
order by L.LogDate desc
Go

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAnnouncementByID' and
		        xtype = 'P')
Drop Procedure GetAnnouncementByID
Go
Create Procedure GetAnnouncementByID @AnnouncementID int							   
as

Select an.*, us.UserName Creator
from Announcement an 
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.AnnouncementID = @AnnouncementID 
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetManualLogReport' and
		        xtype = 'P')
Drop Procedure GetManualLogReport
Go
Create Procedure GetManualLogReport @ManualID int							   
as

Select U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
left JOIN ManualLog L on L.UserID = U.UserID and 
						 L.ManualID = @ManualID
left JOIN Actions A on L.ActionID = A.ActionID
left join Manual an on an.ManualID = l.ManualID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.ManualID = @ManualID or L.ManualID is null
order by L.LogDate desc
Go




If Exists (select Name 
		   from sysobjects 
		   where name = 'GetManualVersionLogReport' and
		        xtype = 'P')
Drop Procedure GetManualVersionLogReport
Go
Create Procedure GetManualVersionLogReport @ManualVersionID int							   
as

Select U.UserID,U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
left JOIN ManualLog L on L.UserID = U.UserID and 
						 L.ManualVersionID = @ManualVersionID
left JOIN Actions A on L.ActionID = A.ActionID
left join ManualVersion an on an.ManualVersionID = l.ManualVersionID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.ManualVersionID = @ManualVersionID or L.ManualVersionID is null
order by L.LogDate desc
Go




If Exists (select Name 
		   from sysobjects 
		   where name = 'GetFormLogReport' and
		        xtype = 'P')
Drop Procedure GetFormLogReport
Go
Create Procedure GetFormLogReport @FormID int							   
as

Select U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
left JOIN ManualLog L on L.UserID = U.UserID and 
						 L.ManualFormID = @FormID
left JOIN Actions A on L.ActionID = A.ActionID
left join ManualForm an on an.ManualFormID = l.ManualFormID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.ManualFormID = @FormID  or L.ManualFormID is null
order by L.LogDate desc
Go




If Exists (select Name 
		   from sysobjects 
		   where name = 'GetFormVersionLogReport' and
		        xtype = 'P')
Drop Procedure GetFormVersionLogReport
Go
Create Procedure GetFormVersionLogReport @FormVersionID int							   
as

Select U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
left JOIN ManualLog L on L.UserID = U.UserID and 
						 L.FromVersionID = @FormVersionID
left JOIN Actions A on L.ActionID = A.ActionID
left join FromVersion an on an.FromVersionID = l.FromVersionID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.FromVersionID = @FormVersionID or L.FromVersionID is null
order by L.LogDate desc
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetScheduleLogReport' and
		        xtype = 'P')
Drop Procedure GetScheduleLogReport
Go
Create Procedure GetScheduleLogReport @ScheduleID int							   
as

Select U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
left JOIN ScheduleLog L on L.UserID = U.UserID and 
						 L.ScheduleID = @ScheduleID
left JOIN Actions A on L.ActionID = A.ActionID
left join Schedule an on an.ScheduleID = l.ScheduleID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.ScheduleID = @ScheduleID or L.ScheduleID is null
order by L.LogDate desc
Go




If Exists (select Name 
		   from sysobjects 
		   where name = 'GetScheduleVersionLogReport' and
		        xtype = 'P')
Drop Procedure GetScheduleVersionLogReport
Go
Create Procedure GetScheduleVersionLogReport @ScheduleVersionID int							   
as

Select U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
left JOIN ScheduleLog L on L.UserID = U.UserID  and 
						 L.scheduleVersionID = @ScheduleVersionID
left JOIN Actions A on L.ActionID = A.ActionID
left join ScheduleVersion an on an.ScheduleVersionID = l.ScheduleVersionID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.scheduleVersionID = @ScheduleVersionID or L.ScheduleVersionID is null
order by L.LogDate desc
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetManualByID' and
		        xtype = 'P')
Drop Procedure GetManualByID
Go
Create Procedure GetManualByID @ManualID int							   
as

Select an.*, us.UserName Creator
from Manual an 
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.ManualID = @ManualID 
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetManualVersionByID' and
		        xtype = 'P')
Drop Procedure GetManualVersionByID
Go
Create Procedure GetManualVersionByID @ManualVersionID int							   
as

Select an.*, M.*,us.UserName Creator
from ManualVersion an 
inner join Manual m on m.ManualID = an.ManualID
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.ManualVersionID = @ManualVersionID 
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetFormByID' and
		        xtype = 'P')
Drop Procedure GetFormByID
Go
Create Procedure GetFormByID @FormID int							   
as

Select an.*, M.*,us.UserName Creator
from ManualForm an 
inner join Manual M on an.ManualID = M.ManualID
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.ManualFormID = @FormID 
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetFormVersionByID' and
		        xtype = 'P')
Drop Procedure GetFormVersionByID
Go
Create Procedure GetFormVersionByID @FormVersionID int							   
as

Select an.*,M.*, MF.*, us.UserName Creator
from FromVersion an 
inner join ManualForm MF on MF.ManualFormID = an.ManualFromID
inner join Manual M on M.ManualID = MF.ManualID
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.FromVersionID = @FormVersionID 
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetScheduleByID' and
		        xtype = 'P')
Drop Procedure GetScheduleByID
Go
Create Procedure GetScheduleByID @ScheduleID int							   
as

Select an.*, us.UserName Creator
from Schedule an 
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.ScheduleID = @ScheduleID
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetScheduleVersionByID' and
		        xtype = 'P')
Drop Procedure GetScheduleVersionByID
Go
Create Procedure GetScheduleVersionByID @ScheduleVersionID int							   
as

Select an.*,s.*, us.UserName Creator
from ScheduleVersion an 
inner join Schedule S on s.ScheduleID = an.ScheduleID
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.ScheduleVersionID = @ScheduleVersionID 
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetCertificateByID' and
		        xtype = 'P')
Drop Procedure GetCertificateByID
Go
Create Procedure GetCertificateByID @CertificateID int							   
as

Select an.*, us.UserName Creator
from Certificate an 
inner join aspnet_Users us on us.UserId = an.CreatedBy
where an.CertificateID = @CertificateID
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetCertificateLogReport' and
		        xtype = 'P')
Drop Procedure GetCertificateLogReport
Go
Create Procedure GetCertificateLogReport @CertificateID int							   
as

Select U.UserID, U.FullName, isnull(A.ActionName, 'Unread') ActionName, L.LogDate, an.*, us.UserName Creator
from UsersProfiles U
left JOIN CertificateLog L on L.UserID = U.UserID and
							L.CertificateID = @CertificateID
left JOIN Actions A on L.ActionID = A.ActionID
left join Certificate an on an.CertificateID = l.CertificateID
left join aspnet_Users us on us.UserId = an.CreatedBy

where L.CertificateID = @CertificateID or L.CertificateID is null
order by L.LogDate desc
Go