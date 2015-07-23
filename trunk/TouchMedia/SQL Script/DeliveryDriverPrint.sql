If Exists (select Name 
		   from sysobjects 
		   where name = 'DeliveryDriverPrint' and
		        xtype = 'P')
Drop Procedure DeliveryDriverPrint
Go
Create Procedure DeliveryDriverPrint @DeliveryOrderID int
							  
as

Select DO.* , C.ClientName , J.JobOrderCode from DeliveryOrder DO  
inner join  DeliveryOrderDetails on DO.DeliveryOrderID = DeliveryOrderDetails.DeliveryOrderID 
inner join Clients C on DO.ClientID = C.ClientID 
inner join JobOrder J on DO.JobOrderID = J.JobOrderID
 
where (@DeliveryOrderID = DO.DeliveryOrderID Or @DeliveryOrderID = 0)
	  

Go

exec DeliveryDriverPrint 1