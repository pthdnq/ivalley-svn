
If Exists (select Name 
		   from sysobjects 
		   where name = 'Status' and
		        xtype = 'U')
Drop Table Status
Go
Create Table Status
(
	StatusID int not null
			identity(1,1)
			Primary Key,	
	Name Nvarchar(200)
)
Go

If Exists (select Name 
		   from sysobjects 
		   where name = 'IssueType' and
		        xtype = 'U')
Drop Table IssueType
Go
Create Table IssueType
(
	IssueTypeID int not null
			identity(1,1)
			Primary Key,	
	Name Nvarchar(200)
)
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'Attachment' and
		        xtype = 'U')
Drop Table Attachment
Go
Create Table Attachment
(
	AttachmentID int not null
			identity(1,1)
			Primary Key,	
	Path Nvarchar(2000)
)
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'Issue' and
		        xtype = 'U')
Drop Table Issue
Go
Create Table Issue
(
	IssueID int not null
			identity(1,1)			
			Primary Key,	
	UserID uniqueidentifier foreign key references aspnet_Users(UserID),
	IssueText Nvarchar(max),
	IssueTitle Nvarchar(500),
	IssueDate DateTime,
	StatusID int foreign key references Status(StatusID),
	IssueTypeID int foreign key references IssueType(IssueTypeID),
)
Go

If Exists (select Name 
		   from sysobjects 
		   where name = 'IssueAttachment' and
		        xtype = 'U')
Drop Table IssueAttachment
Go
Create Table IssueAttachment
(
	IssueAttachmentID int not null
			identity(1,1)			
			Primary Key,	
	IssueID int foreign key references Issue(IssueID),
	AttachmentID int foreign key references Attachment(AttachmentID)
)
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'Comment' and
		        xtype = 'U')
Drop Table Comment
Go
Create Table Comment
(
	CommentID int not null
			identity(1,1)			
			Primary Key,		
	IssueID int foreign key references Issue(IssueID),
	UserID uniqueidentifier foreign key references aspnet_Users(UserID),
	CommentText Nvarchar(max),
	CommentDate DateTime
)
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'CommentAttachment' and
		        xtype = 'U')
Drop Table CommentAttachment
Go
Create Table CommentAttachment
(
	CommentAttachmentID int not null
			identity(1,1)			
			Primary Key,	
	CommentID int foreign key references Comment(CommentID),
	AttachmentID int foreign key references Attachment(AttachmentID)
)
Go




If Exists (select Name 
		   from sysobjects 
		   where name = 'GetAllIssuesByUserID' and
		        xtype = 'P')
Drop Procedure GetAllIssuesByUserID
Go
Create Procedure GetAllIssuesByUserID 	@UserId uniqueidentifier = null
as

select I.* , S.Name StatusName, u.UserName , T.Name TypeName
from Issue I 
Left Join Status S on I.StatusID = S.StatusID
Left Join aspnet_Users U on I.UserID = u.UserID
Left Join IssueType T on I.IssueTypeID = T.IssueTypeID
where (U.UserId = @UserId or @UserId is null)
Order by S.StatusID asc, I.IssueDate Desc
Go



If Exists (select Name 
		   from sysobjects 
		   where name = 'GetIssuesAttachment' and
		        xtype = 'P')
Drop Procedure GetIssuesAttachment
Go
Create Procedure GetIssuesAttachment @IssueID int 	
as

select  *
from IssueAttachment I 
Inner Join Attachment A on I.AttachmentID = A.AttachmentID
where I.IssueID = @IssueID
Go


If Exists (select Name 
		   from sysobjects 
		   where name = 'GetIssuesComments' and
		        xtype = 'P')
Drop Procedure GetIssuesComments
Go
Create Procedure GetIssuesComments @IssueID int 	
as

select  C.*,A.*, U.UserName
from Comment C
Left Join CommentAttachment CA on C.CommentID = CA.CommentID 
Left Join Attachment A on CA.AttachmentID = A.AttachmentID
Left Join aspnet_Users U on C.UserID = U.UserID
where C.IssueID = @IssueID
Go