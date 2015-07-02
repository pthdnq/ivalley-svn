If Exists (select Name 
		   from sysobjects 
		   where name = 'PurchaseOrderSearch' and
		        xtype = 'P')
Drop Procedure PurchaseOrderSearch
Go
Create Procedure PurchaseOrderSearch @PurNumber int = 0,  @PurDeliveryDateFrom datetime = null , 
                               @PurDeliveryDateTo datetime = null , 
							   @PurFromDate DateTime = null,
							   @PurToDate DateTime = null
as

Select P.* From PurchaseOrder P
where ( @PurNumber= P.PurchaseOrderNumber Or @PurNumber = 0) And
      
	  (P.DeliveryDate >= (ISNULL(@PurDeliveryDateFrom,'01/01/1900')) And 
	  	  P.DeliveryDate <= (ISNULL(@PurDeliveryDateTo,'01/01/2500'))) And
	  (P.PurchaseOrderDate >=(ISNULL(@PurFromDate,'01/01/1900')) And
	  	  P.PurchaseOrderDate <=(ISNULL(@PurToDate,'01/01/2500')) )

order by CreatedDate 
GO
 
 exec PurchaseOrderSearch 1


 Select * from PurchaseOrder 
 where PurchaseOrderNumber = 1