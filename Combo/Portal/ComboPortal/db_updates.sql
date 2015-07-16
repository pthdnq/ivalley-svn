Alter table ComboUser
add IsVerified bit,
	CreatedDate Datetime




If Exists (select Name 
		   from sysobjects  
		   where name = 'VerificationRequest' and
		        xtype = 'U')
Drop Table VerificationRequest
Go
Create Table VerificationRequest
(
	VerificationRequestID int primary key identity(1,1),	
	ComboUserID int foreign key references ComboUser(ComboUserID),
	Name nvarchar(200),
	PassportNo nvarchar(200),
	DateOfBirth Datetime,
	GenderID int foreign key references Gender(GenderID),
	CountryID int foreign key references Country(CountryID),
	MobileNo nvarchar(15),
	MobileNo2 nvarchar(15),
	AccountName nvarchar(30),
	Email nvarchar(100),
	PassportPicPath nvarchar(500),
	PersonalPicPath nvarchar(500),
	IsAccepted bit,
	Description nvarchar(500),
	RequestDate Datetime,
	StatusDate DateTime, 
	ReviewerName nvarchar(100),
	RequestTypeID int, 
	City nvarchar(100),
	Info nvarchar(500),
	Activity nvarchar(500),
)
Go