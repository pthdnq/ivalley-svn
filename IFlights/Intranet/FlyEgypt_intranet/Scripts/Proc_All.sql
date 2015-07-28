
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





If Exists (select Name 
		   from sysobjects 
		   where name = 'GetManualsByCatID_Admin' and
		        xtype = 'P')
Drop Procedure GetManualsByCatID_Admin
Go
Create Procedure GetManualsByCatID_Admin @CatID int, 
										 @filterText nvarchar(50)
as

select M.*, U.username UpdatedByName , C.username CreatedByName ,
                                    (Select Top 1 path from ManualVersion MV where MV.ManualID = M.ManualID Order by MV.LastUpdatedDate desc) VersionPath
                                    from Manual M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID                                    
                                    where ManualCategoryID = @CatID and (isDeleted is null or isDeleted <> 1 ) and 
                                         (M.Title like '%'+@filterText+'%' or @filterText = '')
                                    order by CreatedDate desc
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetManualsByCatID_User' and
		        xtype = 'P')
Drop Procedure GetManualsByCatID_User
Go
Create Procedure GetManualsByCatID_User @CatID int, 
										@UserID uniqueidentifier,
										 @filterText nvarchar(50)
as
select M.*, U.username UpdatedByName , C.username CreatedByName ,-- ,sum(case when UMV.UserNotificationID is not null then 1 else 0 end) ManualVersionUpdates ,
                                    (Select Top 1 path from ManualVersion MV where MV.ManualID = M.ManualID Order by MV.LastUpdatedDate desc) VersionPath   ,
                                    (Select Top 1 ManualVersionID from ManualVersion MV where MV.ManualID = M.ManualID Order by MV.LastUpdatedDate desc) ManualVersionID   ,
                                    (select isnull(sum(case when UM.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UM where M.ManualID = UM.ManualID and 
								                                     UM.FormID is null and 
								                                     UM.ManualVersionID is null and 
								                                     UM.FromVersionID is null and 
								                                     (UM.IsRead is null OR UM.IsRead <> 1) and
								                                     UM.UserID = @UserID) ManualUpdates, 
                                    (select isnull(sum(case when UMV.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UMV where M.ManualID = UMV.ManualID and 
								                                     UMV.FormID is null and 								 
								                                     UMV.FromVersionID is null and 
								                                     UMV.ManualVersionID is not null and
								                                     (UMV.IsRead is null OR UMV.IsRead <> 1) and
								                                     UMV.UserID = @UserID) ManualVersionUpdates,
                                    (select isnull(sum(case when UF.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UF where M.ManualID = UF.ManualID and 
								                                     UF.FormID is not null and 
								                                     UF.ManualVersionID is null and 
								                                     UF.FromVersionID is null and 
								                                     (UF.IsRead is null OR UF.IsRead <> 1) and
								                                     UF.UserID = @UserID) ManualFormUpdates, 
                                    (select isnull(sum(case when UFV.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UFV where M.ManualID = UFV.ManualID and 
								                                     UFV.FormID is not null and 								 
								                                     UFV.FromVersionID is not null and 
								                                     UFV.ManualVersionID is null and
								                                     (UFV.IsRead is null OR UFV.IsRead <> 1) and
								                                     UFV.UserID = @UserID) ManualFormVersionUpdates										 								    
                                    from Manual M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID     
                                    where ManualCategoryID = @CatID and (isDeleted is null or isDeleted <> 1 )and 
                                          (M.Title like '%'+@filterText+'%' or @filterText = '')
                                    order by CreatedDate desc
GO


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetVersionsByManualID' and
		        xtype = 'P')
Drop Procedure GetVersionsByManualID
Go
Create Procedure GetVersionsByManualID @ManualID int, 
									   @filterText nvarchar(50)
as
select M.*, U.username UpdatedByName , C.username CreatedByName from ManualVersion M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID
                                    where ManualID = @ManualID and (isDeleted is null or isDeleted <> 1 ) and 
									     (M.IssueNumber like '%'+ @filterText +'%' OR
										  M.RevisionNumber like '%'+ @filterText +'%' OR
										  M.Title like '%'+ @filterText +'%' OR
										  @filterText = '')
										  order by CreatedDate desc
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetFormsByManualID_User' and
		        xtype = 'P')
Drop Procedure GetFormsByManualID_User
Go
Create Procedure GetFormsByManualID_User @ManualID int, 
										@UserID uniqueidentifier,
										 @filterText nvarchar(50)
as

select M.*, U.username UpdatedByName , C.username CreatedByName,
                                    (Select Top 1 path from FromVersion MV where MV.ManualFromID = M.ManualFormID Order by MV.LastUpdatedDate desc) VersionPath,                                    
                                    (Select Top 1 FromVersionID from FromVersion MV where MV.ManualFromID = M.ManualFormID Order by MV.LastUpdatedDate desc) FromVersionID,                                    
                                    (select isnull(sum(case when UF.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UF where M.ManualID = UF.ManualID and 
								                                     UF.FormID is not null and 
								                                     UF.ManualVersionID is null and 
								                                     UF.FromVersionID is null and 
								                                     (UF.IsRead is null OR UF.IsRead <> 1) and
								                                     UF.UserID = @UserID) ManualFormUpdates, 
                                    (select isnull(sum(case when UFV.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UFV where M.ManualID = UFV.ManualID and 
								                                     UFV.FormID is not null and 								 
								                                     UFV.FromVersionID is not null and 
								                                     UFV.ManualVersionID is null and
								                                     (UFV.IsRead is null OR UFV.IsRead <> 1) and
								                                     UFV.UserID = @UserID) ManualFormVersionUpdates	 
                                    from ManualForm M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID
                                    where ManualID = @ManualID and (isDeleted is null or isDeleted <> 1 ) and 
										(M.Name like '%'+ @filterText+'%' or @filterText = '') 
order by CreatedDate desc
GO


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetFormsByManualID_Admin' and
		        xtype = 'P')
Drop Procedure GetFormsByManualID_Admin
Go
Create Procedure GetFormsByManualID_Admin @ManualID int, 
										 @filterText nvarchar(50)
as
select M.*, U.username UpdatedByName , C.username CreatedByName,
                                    (Select Top 1 path from FromVersion MV where MV.ManualFromID = M.ManualFormID Order by MV.LastUpdatedDate desc) VersionPath 
                                    from ManualForm M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID
                                    where ManualID = @ManualID and (isDeleted is null or isDeleted <> 1 ) 
									and (M.Name like '%'+@filterText+'%' or @filterText = '') 
									order by CreatedDate desc
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetVersionsByFormID' and
		        xtype = 'P')
Drop Procedure GetVersionsByFormID
Go
Create Procedure GetVersionsByFormID @FormID int, 
										 @filterText nvarchar(50)
as
select M.*, U.username UpdatedByName , C.username CreatedByName from FromVersion M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID
                                    where ManualFromID = @FormID and (isDeleted is null or isDeleted <> 1 )
									 and (M.IssueNumber like '%'+ @filterText +'%' OR
										  M.RevisionNumber like '%'+ @filterText +'%' OR
										  M.Title like '%'+ @filterText +'%' OR
										  @filterText = '')
									  order by CreatedDate desc

Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllSchedules' and
		        xtype = 'P')
Drop Procedure GetAllSchedules
Go
Create Procedure GetAllSchedules @filterText nvarchar(50),
								 @From DateTime = null,
								 @To DateTime = null
as
select M.*, U.username UpdatedByName , C.username CreatedByName ,
                                    (Select Top 1 path from scheduleVersion MV where MV.scheduleID = M.scheduleID Order by MV.LastUpdatedDate desc) VersionPath       
                                    from schedule M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID 
                                    WHERE (isDeleted is null or isDeleted <> 1 ) and 
										  (M.Name like '%'+@filterText+'%' or @filterText = '') and 
										  M.StartDate >= isnull(@From, '01/01/1950') and 
										  M.EndDate >= isnull(@To, '01/01/2500') 
                                    order by CreatedDate desc



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllCircularsGroups' and
		        xtype = 'P')
Drop Procedure GetAllCircularsGroups
Go
Create Procedure GetAllCircularsGroups @groupID int,
									 @query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select Announcement.*, U.UserName, U.UserID, G.GroupName as Groups
                                    from Announcement inner join AnnouncementGroup
                                    on Announcement.AnnouncementID = AnnouncementGroup.AnnouncementID
                                    inner join Groups G on AnnouncementGroup.GroupID = G.GroupID  
                                    Left join aspnet_users U on Announcement.createdby = u.UserID 
                                    where (IsBulletin is null or IsBulletin <> 1 ) 
                                    and (IsBlog is null or IsBlog <> 1 )
                                    and AnnouncementGroup.GroupID = @groupID
                                    and (isDeleted is null or isDeleted <> 1 )
                                    AND ((Announcement.Title LIKE '%'+@query+'%') OR (Announcement.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
											AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllCircularsPublic' and
		        xtype = 'P')
Drop Procedure GetAllCircularsPublic
Go
Create Procedure GetAllCircularsPublic @query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID, 'Public' as Groups from Announcement A 
                                    left join AnnouncementGroup G on A.AnnouncementID = G.AnnouncementID                                                 
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBulletin is null or IsBulletin <> 1 ) and 
                                          (IsBlog is null or IsBlog <> 1 ) and
										  G.AnnouncementID is null 
                                          and (isDeleted is null or isDeleted <> 1 )
                                          AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
											AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllCircularsPublicAndGroups' and
		        xtype = 'P')
Drop Procedure GetAllCircularsPublicAndGroups
Go
Create Procedure GetAllCircularsPublicAndGroups @UserID uniqueidentifier,
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as

select A.*, U.UserName, U.UserID, 'Public' as Groups from Announcement A 
                                    left join AnnouncementGroup G on A.AnnouncementID = G.AnnouncementID                                                 
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBulletin is null or IsBulletin <> 1 ) and 
                                            (IsBlog is null or IsBlog <> 1 ) and
		                                    G.AnnouncementID is null 
                                            and (isDeleted is null or isDeleted <> 1 )
                                            AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
											AND createdDate <= ISNULL(@ToDate, '01/01/2500')

                                    union 

                                    select distinct A.*, U.UserName, U.UserID, 
									Stuff((select ' , ' + GroupName from groups gs left join AnnouncementGroup G on gs.GroupID = G.GroupID where g.AnnouncementID = a.AnnouncementID for XML path('')),1,3,'')                                    
                                    from Announcement A 
                                    left join AnnouncementGroup G2 on A.AnnouncementID = G2.AnnouncementID
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBulletin is null or IsBulletin <> 1 ) and 
                                            (IsBlog is null or IsBlog <> 1 ) and
		                                    G2.GroupID in (select groupid from usergroup where userid = @UserID)
                                            and (isDeleted is null or isDeleted <> 1 )
                                            AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
											AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBulletinsPublicAndGroups' and
		        xtype = 'P')
Drop Procedure GetAllBulletinsPublicAndGroups
Go

Create Procedure GetAllBulletinsPublicAndGroups @UserID uniqueidentifier,
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID, 'Public' as Groups from Announcement A 
                                    left join AnnouncementGroup G on A.AnnouncementID = G.AnnouncementID                                                 
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBulletin = 1 ) and                                             
		                                    G.AnnouncementID is null 
                                            and (isDeleted is null or isDeleted <> 1 )
                                            AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
											AND createdDate <= ISNULL(@ToDate, '01/01/2500')

                                    union 

                                    select distinct A.*, U.UserName, U.UserID, 
									Stuff((select ' , ' + GroupName from groups gs left join AnnouncementGroup G on gs.GroupID = G.GroupID where g.AnnouncementID = a.AnnouncementID for XML path('')),1,3,'')                                    
                                    from Announcement A 
                                    left join AnnouncementGroup G2 on A.AnnouncementID = G2.AnnouncementID                                                 
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBulletin = 1 ) and                                             
		                                    G2.GroupID in (select groupid from usergroup where userid = @UserID)
                                            and (isDeleted is null or isDeleted <> 1 )
                                            AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
											AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBulletinsPublic' and
		        xtype = 'P')
Drop Procedure GetAllBulletinsPublic
Go

Create Procedure GetAllBulletinsPublic
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID, 'Public' as groups from Announcement A 
                                    left join AnnouncementGroup G on A.AnnouncementID = G.AnnouncementID
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBulletin = 1 ) and
										  G.AnnouncementID is null 
                                          and (isDeleted is null or isDeleted <> 1 )
                                          AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
										  AND createdDate >= ISNULL(@FromDate, '01/01/1900')
											AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO





If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBulletinsGroups' and
		        xtype = 'P')
Drop Procedure GetAllBulletinsGroups
Go

Create Procedure GetAllBulletinsGroups
									@groupID int,
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select Announcement.*, U.UserName, U.UserID, G.GroupName as Groups from Announcement 
inner join AnnouncementGroup on Announcement.AnnouncementID = AnnouncementGroup.AnnouncementID 
inner join Groups G on AnnouncementGroup.GroupID = G.GroupID
Left join aspnet_users U on Announcement.createdby = u.UserID where IsBulletin = 1
and AnnouncementGroup.GroupID = @groupID
and (isDeleted is null or isDeleted <> 1 )
AND ((Announcement.Title LIKE '%'+@query+'%') OR (Announcement.Code LIKE '%'+@query+'%')) 
AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
order by CreatedDate desc
GO



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBlogsPublicAndGroups' and
		        xtype = 'P')
Drop Procedure GetAllBlogsPublicAndGroups
Go

Create Procedure GetAllBlogsPublicAndGroups
									 @UserID uniqueidentifier,
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID, 'Public' as Groups from Announcement A 
                                    left join AnnouncementGroup G on A.AnnouncementID = G.AnnouncementID                                                 
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where  (IsBlog = 1 ) and
		                                    G.AnnouncementID is null 
                                            and (isDeleted is null or isDeleted <> 1 )
                                            AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    union 

                                    select distinct A.*, U.UserName, U.UserID ,
                                    Stuff((select ' , ' + GroupName from groups gs left join AnnouncementGroup G on gs.GroupID = G.GroupID where g.AnnouncementID = a.AnnouncementID for XML path('')),1,3,'')                                    
                                    from Announcement A 
                                    left join AnnouncementGroup G2 on A.AnnouncementID = G2.AnnouncementID                                                 
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBlog = 1 ) and
		                                    G2.GroupID in (select groupid from usergroup where userid = @UserID)
                                            and (isDeleted is null or isDeleted <> 1 )
                                            AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
											AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBlogsPublic' and
		        xtype = 'P')
Drop Procedure GetAllBlogsPublic
Go

Create Procedure GetAllBlogsPublic
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID, 'Public' as Groups from Announcement A 
                                    left join AnnouncementGroup G on A.AnnouncementID = G.AnnouncementID                                                 
                                    Left join aspnet_users U on A.createdby = u.UserID 
                                    where (IsBlog = 1 ) and
										  G.AnnouncementID is null 
                                          and (isDeleted is null or isDeleted <> 1 )
                                          AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
										  AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBlogsGroups' and
		        xtype = 'P')
Drop Procedure GetAllBlogsGroups
Go

Create Procedure GetAllBlogsGroups @groupID int,
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select Announcement.*, U.UserName, U.UserID, G.GroupName as Groups 
from Announcement inner join AnnouncementGroup on Announcement.AnnouncementID = AnnouncementGroup.AnnouncementID 
inner join Groups G on AnnouncementGroup.GroupID = G.GroupID  Left join aspnet_users U on Announcement.createdby = u.UserID 
where IsBlog = 1 and AnnouncementGroup.GroupID = @groupID and (isDeleted is null or isDeleted <> 1 ) 
AND ((Announcement.Title LIKE '%'+@query+'%') OR (Announcement.Code LIKE '%'+@query+'%'))
AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
order by CreatedDate desc
GO

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllCirculars' and
		        xtype = 'P')
Drop Procedure GetAllCirculars
Go

Create Procedure GetAllCirculars
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID 
from Announcement A Left join aspnet_users U on A.createdby = u.UserID 
where (IsBulletin is null or IsBulletin <> 1 ) 
and (IsBlog is null or IsBlog <> 1 ) 
and (isDeleted is null or isDeleted <> 1 )
AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
order by CreatedDate desc
GO


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBulletins' and
		        xtype = 'P')
Drop Procedure GetAllBulletins
Go

Create Procedure GetAllBulletins
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID 
from Announcement A Left join aspnet_users U on A.createdby = u.UserID 
where (IsBulletin = 1 ) and (isDeleted is null or isDeleted <> 1 ) 
AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
order by CreatedDate desc
GO


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllBlogs' and
		        xtype = 'P')
Drop Procedure GetAllBlogs
Go

Create Procedure GetAllBlogs
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select A.*, U.UserName, U.UserID 
from Announcement A Left join aspnet_users U on A.createdby = u.UserID 
where (IsBlog = 1 ) and (isDeleted is null or isDeleted <> 1 ) 
AND ((A.Title LIKE '%'+@query+'%') OR (A.Code LIKE '%'+@query+'%'))
AND createdDate >= ISNULL(@FromDate, '01/01/1900')
AND createdDate <= ISNULL(@ToDate, '01/01/2500')
order by CreatedDate desc
GO




If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllCertificates' and
		        xtype = 'P')
Drop Procedure GetAllCertificates
Go

Create Procedure GetAllCertificates
as
select A.*, U.UserName, U.UserID 
from certificate A Left join aspnet_users U on A.createdby = u.UserID 
WHERE (A.isDeleted is null or A.isDeleted <> 1 ) 
order by CreatedDate desc
GO

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllCertificatesSearch' and
		        xtype = 'P')
Drop Procedure GetAllCertificatesSearch
Go

Create Procedure GetAllCertificatesSearch
									@query nvarchar(50)

as
select A.*, U.UserName, U.UserID 
from certificate A Left join aspnet_users U on A.createdby = u.UserID 
WHERE (A.isDeleted is null or A.isDeleted <> 1 ) 
AND (A.Name LIKE '%'+@query+'%')
order by CreatedDate desc
GO

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllSchedules' and
		        xtype = 'P')
Drop Procedure GetAllSchedules
Go

Create Procedure GetAllSchedules
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select M.*, U.username UpdatedByName , C.username CreatedByName ,
                                    (Select Top 1 path from scheduleVersion MV where MV.scheduleID = M.scheduleID Order by MV.LastUpdatedDate desc) VersionPath       
                                    from schedule M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID 
                                    WHERE (isDeleted is null or isDeleted <> 1 )
									AND (M.Name LIKE '%'+@query+'%')
									AND createdDate >= ISNULL(@FromDate, '01/01/1900')
									AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO

If Exists (select Name 
		   from sysobjects 
		   where name = 'GetSchedulesByUserID' and
		        xtype = 'P')
Drop Procedure GetSchedulesByUserID
Go

Create Procedure GetSchedulesByUserID @UserID uniqueidentifier,
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select M.*, U.username UpdatedByName , C.username CreatedByName ,-- ,sum(case when UMV.UserNotificationID is not null then 1 else 0 end) ManualVersionUpdates ,
                                    (Select Top 1 path from ScheduleVersion MV where MV.ScheduleID = M.ScheduleID Order by MV.LastUpdatedDate desc) VersionPath   ,
                                    (Select Top 1 ScheduleVersionID from ScheduleVersion MV where MV.ScheduleID = M.ScheduleID Order by MV.LastUpdatedDate desc) ScheduleVersionID   ,
                                    (select isnull(sum(case when UM.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UM where M.ScheduleID = UM.ScheduleID and 
								                                     UM.FormID is null and 
								                                     UM.ManualVersionID is null and 
								                                     UM.FromVersionID is null and 
                                                                     UM.ScheduleID is not null and
                                                                     UM.ScheduleVersionID is null and
								                                     (UM.IsRead is null OR UM.IsRead <> 1) and
								                                     UM.UserID = @UserID) ManualUpdates, 
                                    (select isnull(sum(case when UMV.UserNotificationID is not null then 1 else 0 end),0)  from UsersNofications UMV where M.ScheduleID = UMV.ScheduleID and 
								                                     UMV.FormID is null and 								 
								                                     UMV.FromVersionID is null and 
								                                     UMV.ManualVersionID is null and
                                                                     UMV.ScheduleID is not null and
                                                                     UMV.ScheduleVersionID is not null and
								                                     (UMV.IsRead is null OR UMV.IsRead <> 1) and
								                                     UMV.UserID = @UserID) ManualVersionUpdates
                                    from Schedule M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID
                                    WHERE (isDeleted is null or isDeleted <> 1 )
									AND (M.Name LIKE '%'+@query+'%')
									AND createdDate >= ISNULL(@FromDate, '01/01/1900')
									AND createdDate <= ISNULL(@ToDate, '01/01/2500')
                                    order by CreatedDate desc
GO


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetVersionsByScheduleID' and
		        xtype = 'P')
Drop Procedure GetVersionsByScheduleID
Go

Create Procedure GetVersionsByScheduleID @ScheduleID int,
									@query nvarchar(50),
									@FromDate DateTime = null,
									@ToDate DateTime = null
as
select M.*, U.username UpdatedByName , C.username CreatedByName from ScheduleVersion M
                                    Left join aspnet_users U on M.UpdatedBy = U.UserID
                                    Left join aspnet_users C on M.CreatedBy = C.UserID
                                    where ScheduleID = @ScheduleID and (isDeleted is null or isDeleted <> 1 ) 
									AND (M.Title LIKE '%'+@query+'%')
									AND createdDate >= ISNULL(@FromDate, '01/01/1900')
									AND createdDate <= ISNULL(@ToDate, '01/01/2500')
									order by CreatedDate desc
GO

