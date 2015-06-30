If Exists (select Name 
		   from sysobjects 
		   where name = 'DeliveryOrderReport' and
		        xtype = 'P')
Drop Procedure DeliveryOrderReport
Go
Create Procedure DeliveryOrderReport @TransformationSupplierID int,
							   @FromDate DateTime = null,
							   @ToDate DateTime = null
as

Select D.* , DS.DeliveryOrderStatusNameAr , TS.TransformationSupplierName , Dep.DepartmentName from DeliveryOrder D 
INNER JOIN TransformationSupplier TS on D.TransformationSupplier = TS.TransformationSupplierID  
INNER JOIN DeliveryOrderStatus DS on D.DeliveryOrderStatusID = DS.DeliveryOrderStatusID 
INNER JOIN Department Dep on D.DepartmentID = Dep.DepartmentID
where (@TransformationSupplierID = TransformationSupplier Or @TransformationSupplierID = 0) and 
	  DeliveryOrderDate >= (ISNULL(@FromDate, '01/01/1900')) And 
	  DeliveryOrderDate <= (ISNULL(@ToDate, '01/01/2500'))
	  

Go

exec DeliveryOrderReport 0, '06/28/2015', '06/28/2015'