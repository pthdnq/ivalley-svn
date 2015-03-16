
Alter Table Pilot
Alter column StaffNo Nvarchar(10)
Go

Alter table Pilot 
add address nvarchar(400),
    PassportNo nvarchar(20),
    PassportExpiryDate Datetime,
    PICDayHours int, 
    PICDayMin int, 
    SICDayHours int, 
    SICDayMin int,
    PICNightHours int, 
    PICNightMin int, 
    SICNightHours int, 
    SICNightMin int    
Go

    
If Exists (select Name 
		   from sysobjects 
		   where name = 'ProfilePropertyType' and
		        xtype = 'U')
Drop Table ProfilePropertyType
Go
Create Table ProfilePropertyType
(
	ProfilePropertyTypeID int not null
			identity(1,1)
			Primary Key,	
	Name Nvarchar(200)
)
Go    


If Exists (select Name 
		   from sysobjects 
		   where name = 'ProfileProperty' and
		        xtype = 'U')
Drop Table ProfileProperty
Go
Create Table ProfileProperty
(
	ProfilePropertyID int not null
			identity(1,1)
			Primary Key,	
	Name Nvarchar(200),
	ProfilePropertyTypeID int foreign key references ProfilePropertyType(ProfilePropertyTypeID),
	PilotProperty bit, 
	CrewProperty bit
)
Go  



If Exists (select Name 
		   from sysobjects 
		   where name = 'ProfilePropertyValue' and
		        xtype = 'U')
Drop Table ProfilePropertyValue
Go
Create Table ProfilePropertyValue
(
	ProfilePropertyValueID int not null
			identity(1,1)
			Primary Key,	
	PropertyValue Nvarchar(200),
	ProfilePropertyID int foreign key references ProfileProperty(ProfilePropertyID),
	PilotID int foreign key references Pilot(PilotID),
	CrewID int foreign key references Crew(CrewID)
)
Go    

If Exists (select Name 
		   from sysobjects 
		   where name = 'VisaInfo' and
		        xtype = 'U')
Drop Table VisaInfo
Go
Create Table VisaInfo
(
	VisaInfoID int not null
			identity(1,1)
			Primary Key,	
	Country Nvarchar(200),
	VisaNo nvarchar(200),
	ExpiryDate DateTime,
	PilotID int foreign key references Pilot(PilotID),
	CrewID int foreign key references Crew(CrewID)
)
Go

Alter table crew 
alter column StaffNo nvarchar(10)
Add ShortName nvarchar(6)




If Exists (select Name 
		   from sysobjects 
		   where name = 'Announcement' and
		        xtype = 'U')
Drop Table Announcement
Go
Create Table Announcement
(
	AnnouncementID int not null
			identity(1,1)
			Primary Key,	
	Title Nvarchar(500),
	Content nvarchar(max),
	CreatedBy nvarchar(200),
	createdDate Datetime
)
Go  



If Exists (select Name 
		   from sysobjects 
		   where name = 'Manual' and
		        xtype = 'U')
Drop Table Manual
Go
Create Table Manual
(
	ManualID int not null
			identity(1,1)
			Primary Key,	
	Title Nvarchar(500),
	Path nvarchar(1000),
	CreatedBy nvarchar(200),
	createdDate Datetime,
	ManualCategoryID int foreign key references ManualCategory(ManualCategoryID)
)
Go  


If Exists (select Name 
		   from sysobjects 
		   where name = 'ManualCategory' and
		        xtype = 'U')
Drop Table ManualCategory
Go
Create Table ManualCategory
(
	ManualCategoryID int not null
			identity(1,1)
			Primary Key,	
	Title Nvarchar(500),
	ParentCategoryID int foreign key references ManualCategory(ManualCategoryID)
)
Go  

