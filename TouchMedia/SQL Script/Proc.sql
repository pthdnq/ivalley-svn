If Exists (select Name 
		   from sysobjects 
		   where name = 'DeliveryOrderSearch' and
		        xtype = 'P')
Drop Procedure DeliveryOrderSearch
Go
Create Procedure DeliveryOrderSearch @StatusID int = 0, @DepartmentID int = 0 , @DeliveryNumberText nvarchar(50) , @DeliveryOrderName nvarchar(100) ,  
							   @FromDate DateTime = null,
							   @ToDate DateTime = null
as

Select D.* , DS.DeliveryOrderStatusNameAr StatusNameAr ,   DS.StatusClass  , Dep.DepartmentName from DeliveryOrder D 
 
INNER JOIN DeliveryOrderStatus DS on D.DeliveryOrderStatusID = DS.DeliveryOrderStatusID 
INNER JOIN Department Dep on D.DepartmentID = Dep.DepartmentID
where ( @StatusID= D.DeliveryOrderStatusID Or @StatusID = 0) And
(@DepartmentID = D.DepartmentID or @DepartmentID = 0)ANd 
(ISNULL(@DeliveryNumberText,'') = '' Or D.GeneralDeliveryCode Like N'%' + @DeliveryNumberText + N'%') And
(ISNULL(@DeliveryOrderName,'') = '' Or D.DeliveryOrderName Like N'%' + @DeliveryOrderName + N'%') And

	  DeliveryOrderDate >= (ISNULL(@FromDate, '01/01/1900')) And 
	  DeliveryOrderDate <= (ISNULL(@ToDate, '01/01/2500'))
	  
	  order by createdDate desc
Go

