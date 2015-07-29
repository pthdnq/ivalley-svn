If Exists (select Name 
		   from sysobjects 
		   where name = 'DeliveryDriverPrint' and
		        xtype = 'P')
Drop Procedure DeliveryDriverPrint
Go
Create Procedure DeliveryDriverPrint @DeliveryOrderID int
							  
as

Select DO.* , C.ClientName ,GL.Name , J.JobOrderCode,DOS.* from DeliveryOrder DO  
inner join  DeliveryOrderDetails DOS on DO.DeliveryOrderID = DOS.DeliveryOrderID
inner join Clients C on DO.ClientID = C.ClientID 
inner join JobOrder J on DO.JobOrderID = J.JobOrderID
inner join GeneralLookup GL on DOS.GeneralLookUpID = GL.GeneralLookupID
 
where (@DeliveryOrderID = DO.DeliveryOrderID Or @DeliveryOrderID = 0)
	  

Go

exec DeliveryDriverPrint 1020