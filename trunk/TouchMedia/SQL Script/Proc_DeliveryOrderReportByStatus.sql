If Exists (select Name 
		   from sysobjects 
		   where name = 'DeliveryOrderReportByStatus' and
		        xtype = 'P')
Drop Procedure DeliveryOrderReportByStatus
Go
Create Procedure DeliveryOrderReportByStatus @Status int
							  
as

Select D.* , DS.DeliveryOrderStatusNameAr , TS.TransformationSupplierName , Dep.DepartmentName from DeliveryOrder D 
INNER JOIN TransformationSupplier TS on D.TransformationSupplier = TS.TransformationSupplierID  
INNER JOIN DeliveryOrderStatus DS on D.DeliveryOrderStatusID = DS.DeliveryOrderStatusID 
INNER JOIN Department Dep on D.DepartmentID = Dep.DepartmentID
where (@Status = D.DeliveryOrderStatusID Or @Status = 0)
	  

Go

exec DeliveryOrderReportByStatus 3