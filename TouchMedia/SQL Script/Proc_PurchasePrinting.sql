If Exists (select Name 
		   from sysobjects 
		   where name = 'PurchasePrint' and
		        xtype = 'P')
Drop Procedure PurchasePrint
Go
Create Procedure PurchasePrint @PurchaseID int
							  
as

Select * from PurchaseOrder  inner join  PurchaseOrderDetails on PurchaseOrder.PurchaseOrderID = PurchaseOrderDetails.PurchaseOrderID 
 
where (@PurchaseID = PurchaseOrder.PurchaseOrderID Or @PurchaseID = 0)
	  

Go

exec PurchasePrint 12