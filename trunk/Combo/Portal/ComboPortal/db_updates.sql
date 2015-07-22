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

CREATE TABLE AdminLogin
(
	AdminLoginID int primary key not null identity(1,1),
	AdminUserName nvarchar(30),
	AdminPassword nvarchar(50),
	AdminName nvarchar(30)
)
GO


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetUserByPassCode' and
		        xtype = 'P')
Drop Procedure GetUserByPassCode
Go
Create Procedure GetUserByPassCode @Code uniqueidentifier
as
Select CU.*, A.Path ProfilePic                                    
from ComboUser CU                                                              
Left join Attachment A on CU.ProfileImgID = A.AttachmentID                                    
where CU.PassResetCode = @Code
Go 