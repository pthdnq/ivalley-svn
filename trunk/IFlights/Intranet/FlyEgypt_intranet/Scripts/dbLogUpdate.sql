create table Actions
(
	ActionID int not null identity(1,1) primary key,
	ActionName nvarchar(250)
)
GO

create table AnnouncementLog
(
	AnnouncementLogID int not null identity(1,1) Primary key ,
	AnnouncementID int foreign key references Announcement(AnnouncementID),
	UserID uniqueIdentifier foreign key references aspnet_Users(UserId) , 
	ActionID int foreign key references Actions(ActionID),
	LogDate Datetime
)
GO

create table CertificateLog
(
	CertificateLogID int not null identity(1,1) primary key,
	CertificateID int foreign key references Certificate(CertificateID),
	UserID uniqueIdentifier foreign key references aspnet_Users(UserId) ,
	ActionID int foreign key references Actions(ActionID),
	LogDate Datetime
)
GO

create table ScheduleLog
(
	ScheduleLogID int not null identity(1,1) primary key,
	ScheduleID int foreign key references Schedule(ScheduleID),
	ScheduleVersionID int foreign key references ScheduleVersion(ScheduleVersionID),
	UserID uniqueIdentifier foreign key references aspnet_Users(UserId) , 
	ActionID int foreign key references Actions(ActionID),
	LogDate Datetime
)
GO

create table ManualLog
(
	ManualLogID int not null identity(1,1) primary key,
	ManualID int foreign key references Manual(ManualID),
	ManualVersionID int foreign key references ManualVersion(ManualVersionID),
	ManualFormID int foreign key references ManualForm(ManualFormID),
	FromVersionID int foreign key references FromVersion(FromVersionID),
	UserID uniqueIdentifier foreign key references aspnet_Users(UserId), 
	ActionID int foreign key references Actions(ActionID),
	LogDate Datetime
)
GO


alter table manuallog
add ManualCategoryID int foreign key references ManualCategory(ManualCategoryID)
Go

create table LoginLog
(
	LoginLogID int not null identity(1,1) primary key,
	UserID uniqueIdentifier foreign key references aspnet_Users(UserId),
	ActionID int foreign key references Actions(ActionID),
	LogDate Datetime
)
GO

Insert into Actions
values ('Create')

Insert into Actions
values ('Update')

Insert into Actions
values ('Delete')

Insert into Actions
values ('Read')

Insert into Actions
values ('Download')

Insert into Actions
values ('Login')

Insert into Actions
values ('Logout')