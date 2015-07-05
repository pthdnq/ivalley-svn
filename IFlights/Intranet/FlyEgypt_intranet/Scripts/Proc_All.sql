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
Go