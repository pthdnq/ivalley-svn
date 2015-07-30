
USE [tm_final]
GO

/****** Object:  StoredProcedure [proc_CategoriesLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CategoriesLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CategoriesLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CategoriesLoadByPrimaryKey]
(
	@CategoryID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CategoryID],
		[CategoryName]
	FROM [Categories]
	WHERE
		([CategoryID] = @CategoryID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CategoriesLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CategoriesLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CategoriesLoadAll]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CategoriesLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CategoriesLoadAll];
GO

CREATE PROCEDURE [proc_CategoriesLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CategoryID],
		[CategoryName]
	FROM [Categories]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CategoriesLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CategoriesLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CategoriesUpdate]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CategoriesUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CategoriesUpdate];
GO

CREATE PROCEDURE [proc_CategoriesUpdate]
(
	@CategoryID int,
	@CategoryName nvarchar(300) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Categories]
	SET
		[CategoryName] = @CategoryName
	WHERE
		[CategoryID] = @CategoryID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CategoriesUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CategoriesUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CategoriesInsert]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CategoriesInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CategoriesInsert];
GO

CREATE PROCEDURE [proc_CategoriesInsert]
(
	@CategoryID int = NULL output,
	@CategoryName nvarchar(300) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Categories]
	(
		[CategoryName]
	)
	VALUES
	(
		@CategoryName
	)

	SET @Err = @@Error

	SELECT @CategoryID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CategoriesInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CategoriesInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CategoriesDelete]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CategoriesDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CategoriesDelete];
GO

CREATE PROCEDURE [proc_CategoriesDelete]
(
	@CategoryID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Categories]
	WHERE
		[CategoryID] = @CategoryID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CategoriesDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CategoriesDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ClientsLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ClientsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ClientsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ClientsLoadByPrimaryKey]
(
	@ClientID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ClientID],
		[ClientName],
		[ClientPhone],
		[ClientEmail],
		[ClientCode],
		[isDeleted]
	FROM [Clients]
	WHERE
		([ClientID] = @ClientID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ClientsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ClientsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ClientsLoadAll]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ClientsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ClientsLoadAll];
GO

CREATE PROCEDURE [proc_ClientsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ClientID],
		[ClientName],
		[ClientPhone],
		[ClientEmail],
		[ClientCode],
		[isDeleted]
	FROM [Clients]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ClientsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ClientsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ClientsUpdate]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ClientsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ClientsUpdate];
GO

CREATE PROCEDURE [proc_ClientsUpdate]
(
	@ClientID int,
	@ClientName nvarchar(300) = NULL,
	@ClientPhone nvarchar(50) = NULL,
	@ClientEmail nvarchar(300) = NULL,
	@ClientCode nvarchar(300) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Clients]
	SET
		[ClientName] = @ClientName,
		[ClientPhone] = @ClientPhone,
		[ClientEmail] = @ClientEmail,
		[ClientCode] = @ClientCode,
		[isDeleted] = @isDeleted
	WHERE
		[ClientID] = @ClientID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ClientsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ClientsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ClientsInsert]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ClientsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ClientsInsert];
GO

CREATE PROCEDURE [proc_ClientsInsert]
(
	@ClientID int = NULL output,
	@ClientName nvarchar(300) = NULL,
	@ClientPhone nvarchar(50) = NULL,
	@ClientEmail nvarchar(300) = NULL,
	@ClientCode nvarchar(300) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Clients]
	(
		[ClientName],
		[ClientPhone],
		[ClientEmail],
		[ClientCode],
		[isDeleted]
	)
	VALUES
	(
		@ClientName,
		@ClientPhone,
		@ClientEmail,
		@ClientCode,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @ClientID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ClientsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ClientsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ClientsDelete]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ClientsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ClientsDelete];
GO

CREATE PROCEDURE [proc_ClientsDelete]
(
	@ClientID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Clients]
	WHERE
		[ClientID] = @ClientID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ClientsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ClientsDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_DeliveryOrderLoadByPrimaryKey]
(
	@DeliveryOrderID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DeliveryOrderID],
		[KilometerCounterBefore],
		[KilometerCounterAfter],
		[TotalPrice],
		[DeliveryOrderStatusID],
		[GeneralDeliveryCode],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[TransformationSupplier],
		[DriverName],
		[DriverNationID],
		[CarNumber],
		[DriverTelephone],
		[WatingHours],
		[PermationNumber],
		[Department],
		[ClientCode],
		[DeliveryOrderName],
		[DeliveryOrderDate],
		[DepartmentResponsableName],
		[CarType],
		[DepartmentID],
		[JobOrderID],
		[ClientID],
		[isDeleted]
	FROM [DeliveryOrder]
	WHERE
		([DeliveryOrderID] = @DeliveryOrderID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderLoadAll]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderLoadAll];
GO

CREATE PROCEDURE [proc_DeliveryOrderLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DeliveryOrderID],
		[KilometerCounterBefore],
		[KilometerCounterAfter],
		[TotalPrice],
		[DeliveryOrderStatusID],
		[GeneralDeliveryCode],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[TransformationSupplier],
		[DriverName],
		[DriverNationID],
		[CarNumber],
		[DriverTelephone],
		[WatingHours],
		[PermationNumber],
		[Department],
		[ClientCode],
		[DeliveryOrderName],
		[DeliveryOrderDate],
		[DepartmentResponsableName],
		[CarType],
		[DepartmentID],
		[JobOrderID],
		[ClientID],
		[isDeleted]
	FROM [DeliveryOrder]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderUpdate]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderUpdate];
GO

CREATE PROCEDURE [proc_DeliveryOrderUpdate]
(
	@DeliveryOrderID int,
	@KilometerCounterBefore decimal(8,2) = NULL,
	@KilometerCounterAfter decimal(8,2) = NULL,
	@TotalPrice float = NULL,
	@DeliveryOrderStatusID int = NULL,
	@GeneralDeliveryCode nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@TransformationSupplier nvarchar(300) = NULL,
	@DriverName nvarchar(300) = NULL,
	@DriverNationID nvarchar(100) = NULL,
	@CarNumber nvarchar(50) = NULL,
	@DriverTelephone nvarchar(50) = NULL,
	@WatingHours float = NULL,
	@PermationNumber int = NULL,
	@Department nvarchar(300) = NULL,
	@ClientCode int = NULL,
	@DeliveryOrderName nvarchar(300) = NULL,
	@DeliveryOrderDate datetime = NULL,
	@DepartmentResponsableName nvarchar(300) = NULL,
	@CarType nvarchar(300) = NULL,
	@DepartmentID int = NULL,
	@JobOrderID int = NULL,
	@ClientID int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [DeliveryOrder]
	SET
		[KilometerCounterBefore] = @KilometerCounterBefore,
		[KilometerCounterAfter] = @KilometerCounterAfter,
		[TotalPrice] = @TotalPrice,
		[DeliveryOrderStatusID] = @DeliveryOrderStatusID,
		[GeneralDeliveryCode] = @GeneralDeliveryCode,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[TransformationSupplier] = @TransformationSupplier,
		[DriverName] = @DriverName,
		[DriverNationID] = @DriverNationID,
		[CarNumber] = @CarNumber,
		[DriverTelephone] = @DriverTelephone,
		[WatingHours] = @WatingHours,
		[PermationNumber] = @PermationNumber,
		[Department] = @Department,
		[ClientCode] = @ClientCode,
		[DeliveryOrderName] = @DeliveryOrderName,
		[DeliveryOrderDate] = @DeliveryOrderDate,
		[DepartmentResponsableName] = @DepartmentResponsableName,
		[CarType] = @CarType,
		[DepartmentID] = @DepartmentID,
		[JobOrderID] = @JobOrderID,
		[ClientID] = @ClientID,
		[isDeleted] = @isDeleted
	WHERE
		[DeliveryOrderID] = @DeliveryOrderID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_DeliveryOrderInsert]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderInsert];
GO

CREATE PROCEDURE [proc_DeliveryOrderInsert]
(
	@DeliveryOrderID int = NULL output,
	@KilometerCounterBefore decimal(8,2) = NULL,
	@KilometerCounterAfter decimal(8,2) = NULL,
	@TotalPrice float = NULL,
	@DeliveryOrderStatusID int = NULL,
	@GeneralDeliveryCode nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@TransformationSupplier nvarchar(300) = NULL,
	@DriverName nvarchar(300) = NULL,
	@DriverNationID nvarchar(100) = NULL,
	@CarNumber nvarchar(50) = NULL,
	@DriverTelephone nvarchar(50) = NULL,
	@WatingHours float = NULL,
	@PermationNumber int = NULL,
	@Department nvarchar(300) = NULL,
	@ClientCode int = NULL,
	@DeliveryOrderName nvarchar(300) = NULL,
	@DeliveryOrderDate datetime = NULL,
	@DepartmentResponsableName nvarchar(300) = NULL,
	@CarType nvarchar(300) = NULL,
	@DepartmentID int = NULL,
	@JobOrderID int = NULL,
	@ClientID int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [DeliveryOrder]
	(
		[KilometerCounterBefore],
		[KilometerCounterAfter],
		[TotalPrice],
		[DeliveryOrderStatusID],
		[GeneralDeliveryCode],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[TransformationSupplier],
		[DriverName],
		[DriverNationID],
		[CarNumber],
		[DriverTelephone],
		[WatingHours],
		[PermationNumber],
		[Department],
		[ClientCode],
		[DeliveryOrderName],
		[DeliveryOrderDate],
		[DepartmentResponsableName],
		[CarType],
		[DepartmentID],
		[JobOrderID],
		[ClientID],
		[isDeleted]
	)
	VALUES
	(
		@KilometerCounterBefore,
		@KilometerCounterAfter,
		@TotalPrice,
		@DeliveryOrderStatusID,
		@GeneralDeliveryCode,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@TransformationSupplier,
		@DriverName,
		@DriverNationID,
		@CarNumber,
		@DriverTelephone,
		@WatingHours,
		@PermationNumber,
		@Department,
		@ClientCode,
		@DeliveryOrderName,
		@DeliveryOrderDate,
		@DepartmentResponsableName,
		@CarType,
		@DepartmentID,
		@JobOrderID,
		@ClientID,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @DeliveryOrderID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderDelete]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderDelete];
GO

CREATE PROCEDURE [proc_DeliveryOrderDelete]
(
	@DeliveryOrderID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [DeliveryOrder]
	WHERE
		[DeliveryOrderID] = @DeliveryOrderID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderDetailsLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderDetailsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderDetailsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_DeliveryOrderDetailsLoadByPrimaryKey]
(
	@DeliveryOrderDetailsID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DeliveryOrderDetailsID],
		[DeliveryOrderID],
		[DeliveryOrderStatusID],
		[DeliveryFrom],
		[DeliveryTo],
		[DateFrom],
		[DateTo],
		[ReceivableName],
		[ReceivableTelephone],
		[Price],
		[DeliveryOrderCode],
		[DeliveryOrderDetailsStatusID],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[WatingHours],
		[GeneralLookUpID],
		[ClientID],
		[isDeleted]
	FROM [DeliveryOrderDetails]
	WHERE
		([DeliveryOrderDetailsID] = @DeliveryOrderDetailsID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderDetailsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderDetailsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderDetailsLoadAll]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderDetailsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderDetailsLoadAll];
GO

CREATE PROCEDURE [proc_DeliveryOrderDetailsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DeliveryOrderDetailsID],
		[DeliveryOrderID],
		[DeliveryOrderStatusID],
		[DeliveryFrom],
		[DeliveryTo],
		[DateFrom],
		[DateTo],
		[ReceivableName],
		[ReceivableTelephone],
		[Price],
		[DeliveryOrderCode],
		[DeliveryOrderDetailsStatusID],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[WatingHours],
		[GeneralLookUpID],
		[ClientID],
		[isDeleted]
	FROM [DeliveryOrderDetails]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderDetailsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderDetailsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderDetailsUpdate]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderDetailsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderDetailsUpdate];
GO

CREATE PROCEDURE [proc_DeliveryOrderDetailsUpdate]
(
	@DeliveryOrderDetailsID int,
	@DeliveryOrderID int = NULL,
	@DeliveryOrderStatusID int = NULL,
	@DeliveryFrom nvarchar(300) = NULL,
	@DeliveryTo nvarchar(300) = NULL,
	@DateFrom datetime = NULL,
	@DateTo datetime = NULL,
	@ReceivableName nvarchar(300) = NULL,
	@ReceivableTelephone nvarchar(50) = NULL,
	@Price float = NULL,
	@DeliveryOrderCode nvarchar(300) = NULL,
	@DeliveryOrderDetailsStatusID int = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@WatingHours float = NULL,
	@GeneralLookUpID int = NULL,
	@ClientID int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [DeliveryOrderDetails]
	SET
		[DeliveryOrderID] = @DeliveryOrderID,
		[DeliveryOrderStatusID] = @DeliveryOrderStatusID,
		[DeliveryFrom] = @DeliveryFrom,
		[DeliveryTo] = @DeliveryTo,
		[DateFrom] = @DateFrom,
		[DateTo] = @DateTo,
		[ReceivableName] = @ReceivableName,
		[ReceivableTelephone] = @ReceivableTelephone,
		[Price] = @Price,
		[DeliveryOrderCode] = @DeliveryOrderCode,
		[DeliveryOrderDetailsStatusID] = @DeliveryOrderDetailsStatusID,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[WatingHours] = @WatingHours,
		[GeneralLookUpID] = @GeneralLookUpID,
		[ClientID] = @ClientID,
		[isDeleted] = @isDeleted
	WHERE
		[DeliveryOrderDetailsID] = @DeliveryOrderDetailsID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderDetailsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderDetailsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_DeliveryOrderDetailsInsert]    Script Date: 30/07/2015 1:07:19 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderDetailsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderDetailsInsert];
GO

CREATE PROCEDURE [proc_DeliveryOrderDetailsInsert]
(
	@DeliveryOrderDetailsID int = NULL output,
	@DeliveryOrderID int = NULL,
	@DeliveryOrderStatusID int = NULL,
	@DeliveryFrom nvarchar(300) = NULL,
	@DeliveryTo nvarchar(300) = NULL,
	@DateFrom datetime = NULL,
	@DateTo datetime = NULL,
	@ReceivableName nvarchar(300) = NULL,
	@ReceivableTelephone nvarchar(50) = NULL,
	@Price float = NULL,
	@DeliveryOrderCode nvarchar(300) = NULL,
	@DeliveryOrderDetailsStatusID int = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@WatingHours float = NULL,
	@GeneralLookUpID int = NULL,
	@ClientID int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [DeliveryOrderDetails]
	(
		[DeliveryOrderID],
		[DeliveryOrderStatusID],
		[DeliveryFrom],
		[DeliveryTo],
		[DateFrom],
		[DateTo],
		[ReceivableName],
		[ReceivableTelephone],
		[Price],
		[DeliveryOrderCode],
		[DeliveryOrderDetailsStatusID],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[WatingHours],
		[GeneralLookUpID],
		[ClientID],
		[isDeleted]
	)
	VALUES
	(
		@DeliveryOrderID,
		@DeliveryOrderStatusID,
		@DeliveryFrom,
		@DeliveryTo,
		@DateFrom,
		@DateTo,
		@ReceivableName,
		@ReceivableTelephone,
		@Price,
		@DeliveryOrderCode,
		@DeliveryOrderDetailsStatusID,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@WatingHours,
		@GeneralLookUpID,
		@ClientID,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @DeliveryOrderDetailsID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderDetailsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderDetailsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderDetailsDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderDetailsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderDetailsDelete];
GO

CREATE PROCEDURE [proc_DeliveryOrderDetailsDelete]
(
	@DeliveryOrderDetailsID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [DeliveryOrderDetails]
	WHERE
		[DeliveryOrderDetailsID] = @DeliveryOrderDetailsID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderDetailsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderDetailsDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderStatusLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderStatusLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderStatusLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_DeliveryOrderStatusLoadByPrimaryKey]
(
	@DeliveryOrderStatusID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DeliveryOrderStatusID],
		[DeliveryOrderStatusName],
		[DeliveryOrderStatusNameAr],
		[StatusClass],
		[isDeleted]
	FROM [DeliveryOrderStatus]
	WHERE
		([DeliveryOrderStatusID] = @DeliveryOrderStatusID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderStatusLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderStatusLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderStatusLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderStatusLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderStatusLoadAll];
GO

CREATE PROCEDURE [proc_DeliveryOrderStatusLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DeliveryOrderStatusID],
		[DeliveryOrderStatusName],
		[DeliveryOrderStatusNameAr],
		[StatusClass],
		[isDeleted]
	FROM [DeliveryOrderStatus]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderStatusLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderStatusLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderStatusUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderStatusUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderStatusUpdate];
GO

CREATE PROCEDURE [proc_DeliveryOrderStatusUpdate]
(
	@DeliveryOrderStatusID int,
	@DeliveryOrderStatusName nvarchar(300) = NULL,
	@DeliveryOrderStatusNameAr nvarchar(300) = NULL,
	@StatusClass nvarchar(100) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [DeliveryOrderStatus]
	SET
		[DeliveryOrderStatusName] = @DeliveryOrderStatusName,
		[DeliveryOrderStatusNameAr] = @DeliveryOrderStatusNameAr,
		[StatusClass] = @StatusClass,
		[isDeleted] = @isDeleted
	WHERE
		[DeliveryOrderStatusID] = @DeliveryOrderStatusID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderStatusUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderStatusUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_DeliveryOrderStatusInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderStatusInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderStatusInsert];
GO

CREATE PROCEDURE [proc_DeliveryOrderStatusInsert]
(
	@DeliveryOrderStatusID int = NULL output,
	@DeliveryOrderStatusName nvarchar(300) = NULL,
	@DeliveryOrderStatusNameAr nvarchar(300) = NULL,
	@StatusClass nvarchar(100) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [DeliveryOrderStatus]
	(
		[DeliveryOrderStatusName],
		[DeliveryOrderStatusNameAr],
		[StatusClass],
		[isDeleted]
	)
	VALUES
	(
		@DeliveryOrderStatusName,
		@DeliveryOrderStatusNameAr,
		@StatusClass,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @DeliveryOrderStatusID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderStatusInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderStatusInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DeliveryOrderStatusDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DeliveryOrderStatusDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DeliveryOrderStatusDelete];
GO

CREATE PROCEDURE [proc_DeliveryOrderStatusDelete]
(
	@DeliveryOrderStatusID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [DeliveryOrderStatus]
	WHERE
		[DeliveryOrderStatusID] = @DeliveryOrderStatusID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DeliveryOrderStatusDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_DeliveryOrderStatusDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DepartmentLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DepartmentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DepartmentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_DepartmentLoadByPrimaryKey]
(
	@DepartmentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DepartmentID],
		[DepartmentName],
		[isDeleted]
	FROM [Department]
	WHERE
		([DepartmentID] = @DepartmentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DepartmentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_DepartmentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DepartmentLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DepartmentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DepartmentLoadAll];
GO

CREATE PROCEDURE [proc_DepartmentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[DepartmentID],
		[DepartmentName],
		[isDeleted]
	FROM [Department]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DepartmentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_DepartmentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DepartmentUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DepartmentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DepartmentUpdate];
GO

CREATE PROCEDURE [proc_DepartmentUpdate]
(
	@DepartmentID int,
	@DepartmentName nvarchar(300) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Department]
	SET
		[DepartmentName] = @DepartmentName,
		[isDeleted] = @isDeleted
	WHERE
		[DepartmentID] = @DepartmentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DepartmentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_DepartmentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_DepartmentInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DepartmentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DepartmentInsert];
GO

CREATE PROCEDURE [proc_DepartmentInsert]
(
	@DepartmentID int = NULL output,
	@DepartmentName nvarchar(300) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Department]
	(
		[DepartmentName],
		[isDeleted]
	)
	VALUES
	(
		@DepartmentName,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @DepartmentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DepartmentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_DepartmentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_DepartmentDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_DepartmentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_DepartmentDelete];
GO

CREATE PROCEDURE [proc_DepartmentDelete]
(
	@DepartmentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Department]
	WHERE
		[DepartmentID] = @DepartmentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_DepartmentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_DepartmentDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GeneralLookupLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GeneralLookupLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GeneralLookupLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_GeneralLookupLoadByPrimaryKey]
(
	@GeneralLookupID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[GeneralLookupID],
		[CategoryID],
		[Name],
		[Address],
		[Telephone],
		[Email],
		[isDeleted]
	FROM [GeneralLookup]
	WHERE
		([GeneralLookupID] = @GeneralLookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GeneralLookupLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_GeneralLookupLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GeneralLookupLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GeneralLookupLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GeneralLookupLoadAll];
GO

CREATE PROCEDURE [proc_GeneralLookupLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[GeneralLookupID],
		[CategoryID],
		[Name],
		[Address],
		[Telephone],
		[Email],
		[isDeleted]
	FROM [GeneralLookup]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GeneralLookupLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_GeneralLookupLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GeneralLookupUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GeneralLookupUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GeneralLookupUpdate];
GO

CREATE PROCEDURE [proc_GeneralLookupUpdate]
(
	@GeneralLookupID int,
	@CategoryID int = NULL,
	@Name nvarchar(300) = NULL,
	@Address nvarchar(300) = NULL,
	@Telephone nvarchar(300) = NULL,
	@Email nvarchar(300) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [GeneralLookup]
	SET
		[CategoryID] = @CategoryID,
		[Name] = @Name,
		[Address] = @Address,
		[Telephone] = @Telephone,
		[Email] = @Email,
		[isDeleted] = @isDeleted
	WHERE
		[GeneralLookupID] = @GeneralLookupID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GeneralLookupUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_GeneralLookupUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_GeneralLookupInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GeneralLookupInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GeneralLookupInsert];
GO

CREATE PROCEDURE [proc_GeneralLookupInsert]
(
	@GeneralLookupID int = NULL output,
	@CategoryID int = NULL,
	@Name nvarchar(300) = NULL,
	@Address nvarchar(300) = NULL,
	@Telephone nvarchar(300) = NULL,
	@Email nvarchar(300) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [GeneralLookup]
	(
		[CategoryID],
		[Name],
		[Address],
		[Telephone],
		[Email],
		[isDeleted]
	)
	VALUES
	(
		@CategoryID,
		@Name,
		@Address,
		@Telephone,
		@Email,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @GeneralLookupID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GeneralLookupInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_GeneralLookupInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GeneralLookupDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GeneralLookupDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GeneralLookupDelete];
GO

CREATE PROCEDURE [proc_GeneralLookupDelete]
(
	@GeneralLookupID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [GeneralLookup]
	WHERE
		[GeneralLookupID] = @GeneralLookupID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GeneralLookupDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_GeneralLookupDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GiveawaysLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GiveawaysLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GiveawaysLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_GiveawaysLoadByPrimaryKey]
(
	@GiveawayID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[GiveawayID],
		[JobOrderID],
		[ItemName],
		[GiveawayDescription],
		[GiveawayQuantity],
		[PricePerItem],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate]
	FROM [Giveaways]
	WHERE
		([GiveawayID] = @GiveawayID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GiveawaysLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_GiveawaysLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GiveawaysLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GiveawaysLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GiveawaysLoadAll];
GO

CREATE PROCEDURE [proc_GiveawaysLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[GiveawayID],
		[JobOrderID],
		[ItemName],
		[GiveawayDescription],
		[GiveawayQuantity],
		[PricePerItem],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate]
	FROM [Giveaways]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GiveawaysLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_GiveawaysLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GiveawaysUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GiveawaysUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GiveawaysUpdate];
GO

CREATE PROCEDURE [proc_GiveawaysUpdate]
(
	@GiveawayID int,
	@JobOrderID int = NULL,
	@ItemName nvarchar(300) = NULL,
	@GiveawayDescription nvarchar(300) = NULL,
	@GiveawayQuantity int = NULL,
	@PricePerItem float = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Giveaways]
	SET
		[JobOrderID] = @JobOrderID,
		[ItemName] = @ItemName,
		[GiveawayDescription] = @GiveawayDescription,
		[GiveawayQuantity] = @GiveawayQuantity,
		[PricePerItem] = @PricePerItem,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate
	WHERE
		[GiveawayID] = @GiveawayID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GiveawaysUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_GiveawaysUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_GiveawaysInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GiveawaysInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GiveawaysInsert];
GO

CREATE PROCEDURE [proc_GiveawaysInsert]
(
	@GiveawayID int = NULL output,
	@JobOrderID int = NULL,
	@ItemName nvarchar(300) = NULL,
	@GiveawayDescription nvarchar(300) = NULL,
	@GiveawayQuantity int = NULL,
	@PricePerItem float = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Giveaways]
	(
		[JobOrderID],
		[ItemName],
		[GiveawayDescription],
		[GiveawayQuantity],
		[PricePerItem],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate]
	)
	VALUES
	(
		@JobOrderID,
		@ItemName,
		@GiveawayDescription,
		@GiveawayQuantity,
		@PricePerItem,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate
	)

	SET @Err = @@Error

	SELECT @GiveawayID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GiveawaysInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_GiveawaysInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GiveawaysDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GiveawaysDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GiveawaysDelete];
GO

CREATE PROCEDURE [proc_GiveawaysDelete]
(
	@GiveawayID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Giveaways]
	WHERE
		[GiveawayID] = @GiveawayID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GiveawaysDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_GiveawaysDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_JobOrderLoadByPrimaryKey]
(
	@JobOrderID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[JobOrderID],
		[JobOrderStatusID],
		[JobOrderCode],
		[JobOrderDescription],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[JobOrderName],
		[ClientID]
	FROM [JobOrder]
	WHERE
		([JobOrderID] = @JobOrderID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderLoadAll];
GO

CREATE PROCEDURE [proc_JobOrderLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[JobOrderID],
		[JobOrderStatusID],
		[JobOrderCode],
		[JobOrderDescription],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[JobOrderName],
		[ClientID]
	FROM [JobOrder]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderUpdate];
GO

CREATE PROCEDURE [proc_JobOrderUpdate]
(
	@JobOrderID int,
	@JobOrderStatusID int = NULL,
	@JobOrderCode nvarchar(300) = NULL,
	@JobOrderDescription nvarchar(500) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@JobOrderName nvarchar(300) = NULL,
	@ClientID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [JobOrder]
	SET
		[JobOrderStatusID] = @JobOrderStatusID,
		[JobOrderCode] = @JobOrderCode,
		[JobOrderDescription] = @JobOrderDescription,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[JobOrderName] = @JobOrderName,
		[ClientID] = @ClientID
	WHERE
		[JobOrderID] = @JobOrderID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_JobOrderInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderInsert];
GO

CREATE PROCEDURE [proc_JobOrderInsert]
(
	@JobOrderID int = NULL output,
	@JobOrderStatusID int = NULL,
	@JobOrderCode nvarchar(300) = NULL,
	@JobOrderDescription nvarchar(500) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@JobOrderName nvarchar(300) = NULL,
	@ClientID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [JobOrder]
	(
		[JobOrderStatusID],
		[JobOrderCode],
		[JobOrderDescription],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[JobOrderName],
		[ClientID]
	)
	VALUES
	(
		@JobOrderStatusID,
		@JobOrderCode,
		@JobOrderDescription,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@JobOrderName,
		@ClientID
	)

	SET @Err = @@Error

	SELECT @JobOrderID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderDelete];
GO

CREATE PROCEDURE [proc_JobOrderDelete]
(
	@JobOrderID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [JobOrder]
	WHERE
		[JobOrderID] = @JobOrderID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderStatusLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderStatusLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderStatusLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_JobOrderStatusLoadByPrimaryKey]
(
	@JobOrderStatusID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[JobOrderStatusID],
		[JobOrderStatusName],
		[JobOrderStatusNameAr],
		[StatusClass],
		[isDeleted]
	FROM [JobOrderStatus]
	WHERE
		([JobOrderStatusID] = @JobOrderStatusID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderStatusLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderStatusLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderStatusLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderStatusLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderStatusLoadAll];
GO

CREATE PROCEDURE [proc_JobOrderStatusLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[JobOrderStatusID],
		[JobOrderStatusName],
		[JobOrderStatusNameAr],
		[StatusClass],
		[isDeleted]
	FROM [JobOrderStatus]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderStatusLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderStatusLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderStatusUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderStatusUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderStatusUpdate];
GO

CREATE PROCEDURE [proc_JobOrderStatusUpdate]
(
	@JobOrderStatusID int,
	@JobOrderStatusName nvarchar(300) = NULL,
	@JobOrderStatusNameAr nvarchar(300) = NULL,
	@StatusClass nvarchar(100) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [JobOrderStatus]
	SET
		[JobOrderStatusName] = @JobOrderStatusName,
		[JobOrderStatusNameAr] = @JobOrderStatusNameAr,
		[StatusClass] = @StatusClass,
		[isDeleted] = @isDeleted
	WHERE
		[JobOrderStatusID] = @JobOrderStatusID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderStatusUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderStatusUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_JobOrderStatusInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderStatusInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderStatusInsert];
GO

CREATE PROCEDURE [proc_JobOrderStatusInsert]
(
	@JobOrderStatusID int = NULL output,
	@JobOrderStatusName nvarchar(300) = NULL,
	@JobOrderStatusNameAr nvarchar(300) = NULL,
	@StatusClass nvarchar(100) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [JobOrderStatus]
	(
		[JobOrderStatusName],
		[JobOrderStatusNameAr],
		[StatusClass],
		[isDeleted]
	)
	VALUES
	(
		@JobOrderStatusName,
		@JobOrderStatusNameAr,
		@StatusClass,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @JobOrderStatusID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderStatusInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderStatusInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_JobOrderStatusDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_JobOrderStatusDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_JobOrderStatusDelete];
GO

CREATE PROCEDURE [proc_JobOrderStatusDelete]
(
	@JobOrderStatusID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [JobOrderStatus]
	WHERE
		[JobOrderStatusID] = @JobOrderStatusID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_JobOrderStatusDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_JobOrderStatusDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_needsLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_needsLoadByPrimaryKey]
(
	@NeedID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NeedID],
		[JobOrderID],
		[NeedName],
		[NeedSupplier],
		[NeedQuantity],
		[IsNew],
		[IsAvalible],
		[IsMaintenance],
		[isDeleted]
	FROM [needs]
	WHERE
		([NeedID] = @NeedID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_needsLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsLoadAll];
GO

CREATE PROCEDURE [proc_needsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NeedID],
		[JobOrderID],
		[NeedName],
		[NeedSupplier],
		[NeedQuantity],
		[IsNew],
		[IsAvalible],
		[IsMaintenance],
		[isDeleted]
	FROM [needs]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_needsUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsUpdate];
GO

CREATE PROCEDURE [proc_needsUpdate]
(
	@NeedID int,
	@JobOrderID int = NULL,
	@NeedName nvarchar(300) = NULL,
	@NeedSupplier nvarchar(300) = NULL,
	@NeedQuantity nvarchar(300) = NULL,
	@IsNew bit = NULL,
	@IsAvalible bit = NULL,
	@IsMaintenance bit = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [needs]
	SET
		[JobOrderID] = @JobOrderID,
		[NeedName] = @NeedName,
		[NeedSupplier] = @NeedSupplier,
		[NeedQuantity] = @NeedQuantity,
		[IsNew] = @IsNew,
		[IsAvalible] = @IsAvalible,
		[IsMaintenance] = @IsMaintenance,
		[isDeleted] = @isDeleted
	WHERE
		[NeedID] = @NeedID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_needsInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsInsert];
GO

CREATE PROCEDURE [proc_needsInsert]
(
	@NeedID int = NULL output,
	@JobOrderID int = NULL,
	@NeedName nvarchar(300) = NULL,
	@NeedSupplier nvarchar(300) = NULL,
	@NeedQuantity nvarchar(300) = NULL,
	@IsNew bit = NULL,
	@IsAvalible bit = NULL,
	@IsMaintenance bit = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [needs]
	(
		[JobOrderID],
		[NeedName],
		[NeedSupplier],
		[NeedQuantity],
		[IsNew],
		[IsAvalible],
		[IsMaintenance],
		[isDeleted]
	)
	VALUES
	(
		@JobOrderID,
		@NeedName,
		@NeedSupplier,
		@NeedQuantity,
		@IsNew,
		@IsAvalible,
		@IsMaintenance,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @NeedID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_needsDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsDelete];
GO

CREATE PROCEDURE [proc_needsDelete]
(
	@NeedID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [needs]
	WHERE
		[NeedID] = @NeedID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintDetailsLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintDetailsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintDetailsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_PrintDetailsLoadByPrimaryKey]
(
	@PrintDetailsID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PrintDetailsID],
		[PrintGeneralID],
		[AfterPrintingJob],
		[Supplier],
		[Quantity],
		[isDeleted]
	FROM [PrintDetails]
	WHERE
		([PrintDetailsID] = @PrintDetailsID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintDetailsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintDetailsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintDetailsLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintDetailsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintDetailsLoadAll];
GO

CREATE PROCEDURE [proc_PrintDetailsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PrintDetailsID],
		[PrintGeneralID],
		[AfterPrintingJob],
		[Supplier],
		[Quantity],
		[isDeleted]
	FROM [PrintDetails]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintDetailsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintDetailsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintDetailsUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintDetailsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintDetailsUpdate];
GO

CREATE PROCEDURE [proc_PrintDetailsUpdate]
(
	@PrintDetailsID int,
	@PrintGeneralID int = NULL,
	@AfterPrintingJob int = NULL,
	@Supplier nvarchar(50) = NULL,
	@Quantity int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PrintDetails]
	SET
		[PrintGeneralID] = @PrintGeneralID,
		[AfterPrintingJob] = @AfterPrintingJob,
		[Supplier] = @Supplier,
		[Quantity] = @Quantity,
		[isDeleted] = @isDeleted
	WHERE
		[PrintDetailsID] = @PrintDetailsID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintDetailsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintDetailsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_PrintDetailsInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintDetailsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintDetailsInsert];
GO

CREATE PROCEDURE [proc_PrintDetailsInsert]
(
	@PrintDetailsID int,
	@PrintGeneralID int = NULL,
	@AfterPrintingJob int = NULL,
	@Supplier nvarchar(50) = NULL,
	@Quantity int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [PrintDetails]
	(
		[PrintDetailsID],
		[PrintGeneralID],
		[AfterPrintingJob],
		[Supplier],
		[Quantity],
		[isDeleted]
	)
	VALUES
	(
		@PrintDetailsID,
		@PrintGeneralID,
		@AfterPrintingJob,
		@Supplier,
		@Quantity,
		@isDeleted
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintDetailsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintDetailsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintDetailsDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintDetailsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintDetailsDelete];
GO

CREATE PROCEDURE [proc_PrintDetailsDelete]
(
	@PrintDetailsID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [PrintDetails]
	WHERE
		[PrintDetailsID] = @PrintDetailsID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintDetailsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintDetailsDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintGeneralLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintGeneralLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintGeneralLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_PrintGeneralLoadByPrimaryKey]
(
	@PrintGeneralID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PrintGeneralID],
		[JobOrderID],
		[PrintingHouseID],
		[PrintingDescription],
		[PrintingSizeID],
		[RRV],
		[PrintingPaperSize],
		[PaperType],
		[PaperQuantity],
		[Notices],
		[isDeleted]
	FROM [PrintGeneral]
	WHERE
		([PrintGeneralID] = @PrintGeneralID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintGeneralLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintGeneralLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintGeneralLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintGeneralLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintGeneralLoadAll];
GO

CREATE PROCEDURE [proc_PrintGeneralLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PrintGeneralID],
		[JobOrderID],
		[PrintingHouseID],
		[PrintingDescription],
		[PrintingSizeID],
		[RRV],
		[PrintingPaperSize],
		[PaperType],
		[PaperQuantity],
		[Notices],
		[isDeleted]
	FROM [PrintGeneral]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintGeneralLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintGeneralLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintGeneralUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintGeneralUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintGeneralUpdate];
GO

CREATE PROCEDURE [proc_PrintGeneralUpdate]
(
	@PrintGeneralID int,
	@JobOrderID int = NULL,
	@PrintingHouseID int = NULL,
	@PrintingDescription nvarchar(500) = NULL,
	@PrintingSizeID int = NULL,
	@RRV int = NULL,
	@PrintingPaperSize nvarchar(50) = NULL,
	@PaperType int = NULL,
	@PaperQuantity int = NULL,
	@Notices nvarchar(500) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PrintGeneral]
	SET
		[JobOrderID] = @JobOrderID,
		[PrintingHouseID] = @PrintingHouseID,
		[PrintingDescription] = @PrintingDescription,
		[PrintingSizeID] = @PrintingSizeID,
		[RRV] = @RRV,
		[PrintingPaperSize] = @PrintingPaperSize,
		[PaperType] = @PaperType,
		[PaperQuantity] = @PaperQuantity,
		[Notices] = @Notices,
		[isDeleted] = @isDeleted
	WHERE
		[PrintGeneralID] = @PrintGeneralID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintGeneralUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintGeneralUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_PrintGeneralInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintGeneralInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintGeneralInsert];
GO

CREATE PROCEDURE [proc_PrintGeneralInsert]
(
	@PrintGeneralID int,
	@JobOrderID int = NULL,
	@PrintingHouseID int = NULL,
	@PrintingDescription nvarchar(500) = NULL,
	@PrintingSizeID int = NULL,
	@RRV int = NULL,
	@PrintingPaperSize nvarchar(50) = NULL,
	@PaperType int = NULL,
	@PaperQuantity int = NULL,
	@Notices nvarchar(500) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [PrintGeneral]
	(
		[PrintGeneralID],
		[JobOrderID],
		[PrintingHouseID],
		[PrintingDescription],
		[PrintingSizeID],
		[RRV],
		[PrintingPaperSize],
		[PaperType],
		[PaperQuantity],
		[Notices],
		[isDeleted]
	)
	VALUES
	(
		@PrintGeneralID,
		@JobOrderID,
		@PrintingHouseID,
		@PrintingDescription,
		@PrintingSizeID,
		@RRV,
		@PrintingPaperSize,
		@PaperType,
		@PaperQuantity,
		@Notices,
		@isDeleted
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintGeneralInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintGeneralInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintGeneralDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintGeneralDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintGeneralDelete];
GO

CREATE PROCEDURE [proc_PrintGeneralDelete]
(
	@PrintGeneralID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [PrintGeneral]
	WHERE
		[PrintGeneralID] = @PrintGeneralID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintGeneralDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintGeneralDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintingPapersLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintingPapersLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintingPapersLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_PrintingPapersLoadByPrimaryKey]
(
	@PrintingPapersID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PrintingPapersID],
		[PrintingPaperName],
		[PurchasePaperDate],
		[PurcahsePaperQuantity],
		[isDeleted]
	FROM [PrintingPapers]
	WHERE
		([PrintingPapersID] = @PrintingPapersID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintingPapersLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintingPapersLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintingPapersLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintingPapersLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintingPapersLoadAll];
GO

CREATE PROCEDURE [proc_PrintingPapersLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PrintingPapersID],
		[PrintingPaperName],
		[PurchasePaperDate],
		[PurcahsePaperQuantity],
		[isDeleted]
	FROM [PrintingPapers]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintingPapersLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintingPapersLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintingPapersUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintingPapersUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintingPapersUpdate];
GO

CREATE PROCEDURE [proc_PrintingPapersUpdate]
(
	@PrintingPapersID int,
	@PrintingPaperName nvarchar(500) = NULL,
	@PurchasePaperDate datetime = NULL,
	@PurcahsePaperQuantity int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PrintingPapers]
	SET
		[PrintingPaperName] = @PrintingPaperName,
		[PurchasePaperDate] = @PurchasePaperDate,
		[PurcahsePaperQuantity] = @PurcahsePaperQuantity,
		[isDeleted] = @isDeleted
	WHERE
		[PrintingPapersID] = @PrintingPapersID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintingPapersUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintingPapersUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_PrintingPapersInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintingPapersInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintingPapersInsert];
GO

CREATE PROCEDURE [proc_PrintingPapersInsert]
(
	@PrintingPapersID int = NULL output,
	@PrintingPaperName nvarchar(500) = NULL,
	@PurchasePaperDate datetime = NULL,
	@PurcahsePaperQuantity int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [PrintingPapers]
	(
		[PrintingPaperName],
		[PurchasePaperDate],
		[PurcahsePaperQuantity],
		[isDeleted]
	)
	VALUES
	(
		@PrintingPaperName,
		@PurchasePaperDate,
		@PurcahsePaperQuantity,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @PrintingPapersID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintingPapersInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintingPapersInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintingPapersDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintingPapersDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintingPapersDelete];
GO

CREATE PROCEDURE [proc_PrintingPapersDelete]
(
	@PrintingPapersID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [PrintingPapers]
	WHERE
		[PrintingPapersID] = @PrintingPapersID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintingPapersDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintingPapersDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProductionLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProductionLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProductionLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ProductionLoadByPrimaryKey]
(
	@ProductionID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ProductionID],
		[JobOrderID],
		[ItemID],
		[Size],
		[MaterialID],
		[DeliveryDate],
		[SupplierID],
		[DeliveryTo],
		[DeliveryAddress],
		[ISRemovable],
		[RemovableDate],
		[installationDate],
		[ProductStatusID],
		[InstallStatusID],
		[Note],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Production]
	WHERE
		([ProductionID] = @ProductionID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProductionLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProductionLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProductionLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProductionLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProductionLoadAll];
GO

CREATE PROCEDURE [proc_ProductionLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ProductionID],
		[JobOrderID],
		[ItemID],
		[Size],
		[MaterialID],
		[DeliveryDate],
		[SupplierID],
		[DeliveryTo],
		[DeliveryAddress],
		[ISRemovable],
		[RemovableDate],
		[installationDate],
		[ProductStatusID],
		[InstallStatusID],
		[Note],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Production]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProductionLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProductionLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProductionUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProductionUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProductionUpdate];
GO

CREATE PROCEDURE [proc_ProductionUpdate]
(
	@ProductionID int,
	@JobOrderID int = NULL,
	@ItemID int = NULL,
	@Size decimal(6,2) = NULL,
	@MaterialID int = NULL,
	@DeliveryDate datetime = NULL,
	@SupplierID int = NULL,
	@DeliveryTo nvarchar(50) = NULL,
	@DeliveryAddress nvarchar(500) = NULL,
	@ISRemovable bit = NULL,
	@RemovableDate datetime = NULL,
	@installationDate datetime = NULL,
	@ProductStatusID int = NULL,
	@InstallStatusID int = NULL,
	@Note nvarchar(500) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Production]
	SET
		[JobOrderID] = @JobOrderID,
		[ItemID] = @ItemID,
		[Size] = @Size,
		[MaterialID] = @MaterialID,
		[DeliveryDate] = @DeliveryDate,
		[SupplierID] = @SupplierID,
		[DeliveryTo] = @DeliveryTo,
		[DeliveryAddress] = @DeliveryAddress,
		[ISRemovable] = @ISRemovable,
		[RemovableDate] = @RemovableDate,
		[installationDate] = @installationDate,
		[ProductStatusID] = @ProductStatusID,
		[InstallStatusID] = @InstallStatusID,
		[Note] = @Note,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[isDeleted] = @isDeleted
	WHERE
		[ProductionID] = @ProductionID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProductionUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProductionUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ProductionInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProductionInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProductionInsert];
GO

CREATE PROCEDURE [proc_ProductionInsert]
(
	@ProductionID int = NULL output,
	@JobOrderID int = NULL,
	@ItemID int = NULL,
	@Size decimal(6,2) = NULL,
	@MaterialID int = NULL,
	@DeliveryDate datetime = NULL,
	@SupplierID int = NULL,
	@DeliveryTo nvarchar(50) = NULL,
	@DeliveryAddress nvarchar(500) = NULL,
	@ISRemovable bit = NULL,
	@RemovableDate datetime = NULL,
	@installationDate datetime = NULL,
	@ProductStatusID int = NULL,
	@InstallStatusID int = NULL,
	@Note nvarchar(500) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Production]
	(
		[JobOrderID],
		[ItemID],
		[Size],
		[MaterialID],
		[DeliveryDate],
		[SupplierID],
		[DeliveryTo],
		[DeliveryAddress],
		[ISRemovable],
		[RemovableDate],
		[installationDate],
		[ProductStatusID],
		[InstallStatusID],
		[Note],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	)
	VALUES
	(
		@JobOrderID,
		@ItemID,
		@Size,
		@MaterialID,
		@DeliveryDate,
		@SupplierID,
		@DeliveryTo,
		@DeliveryAddress,
		@ISRemovable,
		@RemovableDate,
		@installationDate,
		@ProductStatusID,
		@InstallStatusID,
		@Note,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @ProductionID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProductionInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProductionInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProductionDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProductionDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProductionDelete];
GO

CREATE PROCEDURE [proc_ProductionDelete]
(
	@ProductionID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Production]
	WHERE
		[ProductionID] = @ProductionID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProductionDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProductionDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_PurchaseOrderLoadByPrimaryKey]
(
	@PurchaseOrderID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchaseOrderID],
		[PurchaseOrderNumber],
		[PurchaseOrderDate],
		[Management],
		[ISFinalProduct],
		[ISSample],
		[ISProductUnderManufacturing],
		[DeliveryDate],
		[DeliveryPlace],
		[PaymentRequierment],
		[ManagerName],
		[Signature],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[JobOrderID]
	FROM [PurchaseOrder]
	WHERE
		([PurchaseOrderID] = @PurchaseOrderID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderLoadAll];
GO

CREATE PROCEDURE [proc_PurchaseOrderLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchaseOrderID],
		[PurchaseOrderNumber],
		[PurchaseOrderDate],
		[Management],
		[ISFinalProduct],
		[ISSample],
		[ISProductUnderManufacturing],
		[DeliveryDate],
		[DeliveryPlace],
		[PaymentRequierment],
		[ManagerName],
		[Signature],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[JobOrderID]
	FROM [PurchaseOrder]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderUpdate];
GO

CREATE PROCEDURE [proc_PurchaseOrderUpdate]
(
	@PurchaseOrderID int,
	@PurchaseOrderNumber nvarchar(300) = NULL,
	@PurchaseOrderDate datetime = NULL,
	@Management nvarchar(500) = NULL,
	@ISFinalProduct bit = NULL,
	@ISSample bit = NULL,
	@ISProductUnderManufacturing bit = NULL,
	@DeliveryDate datetime = NULL,
	@DeliveryPlace nvarchar(500) = NULL,
	@PaymentRequierment nvarchar(500) = NULL,
	@ManagerName nvarchar(300) = NULL,
	@Signature nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@JobOrderID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PurchaseOrder]
	SET
		[PurchaseOrderNumber] = @PurchaseOrderNumber,
		[PurchaseOrderDate] = @PurchaseOrderDate,
		[Management] = @Management,
		[ISFinalProduct] = @ISFinalProduct,
		[ISSample] = @ISSample,
		[ISProductUnderManufacturing] = @ISProductUnderManufacturing,
		[DeliveryDate] = @DeliveryDate,
		[DeliveryPlace] = @DeliveryPlace,
		[PaymentRequierment] = @PaymentRequierment,
		[ManagerName] = @ManagerName,
		[Signature] = @Signature,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[JobOrderID] = @JobOrderID
	WHERE
		[PurchaseOrderID] = @PurchaseOrderID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_PurchaseOrderInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderInsert];
GO

CREATE PROCEDURE [proc_PurchaseOrderInsert]
(
	@PurchaseOrderID int = NULL output,
	@PurchaseOrderNumber nvarchar(300) = NULL,
	@PurchaseOrderDate datetime = NULL,
	@Management nvarchar(500) = NULL,
	@ISFinalProduct bit = NULL,
	@ISSample bit = NULL,
	@ISProductUnderManufacturing bit = NULL,
	@DeliveryDate datetime = NULL,
	@DeliveryPlace nvarchar(500) = NULL,
	@PaymentRequierment nvarchar(500) = NULL,
	@ManagerName nvarchar(300) = NULL,
	@Signature nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@JobOrderID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [PurchaseOrder]
	(
		[PurchaseOrderNumber],
		[PurchaseOrderDate],
		[Management],
		[ISFinalProduct],
		[ISSample],
		[ISProductUnderManufacturing],
		[DeliveryDate],
		[DeliveryPlace],
		[PaymentRequierment],
		[ManagerName],
		[Signature],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[JobOrderID]
	)
	VALUES
	(
		@PurchaseOrderNumber,
		@PurchaseOrderDate,
		@Management,
		@ISFinalProduct,
		@ISSample,
		@ISProductUnderManufacturing,
		@DeliveryDate,
		@DeliveryPlace,
		@PaymentRequierment,
		@ManagerName,
		@Signature,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@JobOrderID
	)

	SET @Err = @@Error

	SELECT @PurchaseOrderID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderDelete];
GO

CREATE PROCEDURE [proc_PurchaseOrderDelete]
(
	@PurchaseOrderID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [PurchaseOrder]
	WHERE
		[PurchaseOrderID] = @PurchaseOrderID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderDetailsLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderDetailsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderDetailsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_PurchaseOrderDetailsLoadByPrimaryKey]
(
	@PurchaseOrderDetailsID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchaseOrderDetailsID],
		[PurchaseOrderID],
		[TotalValue],
		[UnitPrice],
		[QuantityRequired],
		[StockOnHand],
		[Unit],
		[Description],
		[Serial],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate]
	FROM [PurchaseOrderDetails]
	WHERE
		([PurchaseOrderDetailsID] = @PurchaseOrderDetailsID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderDetailsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderDetailsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderDetailsLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderDetailsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderDetailsLoadAll];
GO

CREATE PROCEDURE [proc_PurchaseOrderDetailsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchaseOrderDetailsID],
		[PurchaseOrderID],
		[TotalValue],
		[UnitPrice],
		[QuantityRequired],
		[StockOnHand],
		[Unit],
		[Description],
		[Serial],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate]
	FROM [PurchaseOrderDetails]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderDetailsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderDetailsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderDetailsUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderDetailsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderDetailsUpdate];
GO

CREATE PROCEDURE [proc_PurchaseOrderDetailsUpdate]
(
	@PurchaseOrderDetailsID int,
	@PurchaseOrderID int = NULL,
	@TotalValue float = NULL,
	@UnitPrice float = NULL,
	@QuantityRequired int = NULL,
	@StockOnHand int = NULL,
	@Unit int = NULL,
	@Description nvarchar(500) = NULL,
	@Serial nvarchar(1) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PurchaseOrderDetails]
	SET
		[PurchaseOrderID] = @PurchaseOrderID,
		[TotalValue] = @TotalValue,
		[UnitPrice] = @UnitPrice,
		[QuantityRequired] = @QuantityRequired,
		[StockOnHand] = @StockOnHand,
		[Unit] = @Unit,
		[Description] = @Description,
		[Serial] = @Serial,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate
	WHERE
		[PurchaseOrderDetailsID] = @PurchaseOrderDetailsID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderDetailsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderDetailsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_PurchaseOrderDetailsInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderDetailsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderDetailsInsert];
GO

CREATE PROCEDURE [proc_PurchaseOrderDetailsInsert]
(
	@PurchaseOrderDetailsID int = NULL output,
	@PurchaseOrderID int = NULL,
	@TotalValue float = NULL,
	@UnitPrice float = NULL,
	@QuantityRequired int = NULL,
	@StockOnHand int = NULL,
	@Unit int = NULL,
	@Description nvarchar(500) = NULL,
	@Serial nvarchar(1) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [PurchaseOrderDetails]
	(
		[PurchaseOrderID],
		[TotalValue],
		[UnitPrice],
		[QuantityRequired],
		[StockOnHand],
		[Unit],
		[Description],
		[Serial],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate]
	)
	VALUES
	(
		@PurchaseOrderID,
		@TotalValue,
		@UnitPrice,
		@QuantityRequired,
		@StockOnHand,
		@Unit,
		@Description,
		@Serial,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate
	)

	SET @Err = @@Error

	SELECT @PurchaseOrderDetailsID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderDetailsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderDetailsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PurchaseOrderDetailsDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PurchaseOrderDetailsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PurchaseOrderDetailsDelete];
GO

CREATE PROCEDURE [proc_PurchaseOrderDetailsDelete]
(
	@PurchaseOrderDetailsID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [PurchaseOrderDetails]
	WHERE
		[PurchaseOrderDetailsID] = @PurchaseOrderDetailsID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PurchaseOrderDetailsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PurchaseOrderDetailsDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TransformationSupplierLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TransformationSupplierLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TransformationSupplierLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_TransformationSupplierLoadByPrimaryKey]
(
	@TransformationSupplierID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[TransformationSupplierID],
		[TransformationSupplierName],
		[TransformationSupplierTelephone],
		[TransformationSupplierAddress],
		[isDeleted]
	FROM [TransformationSupplier]
	WHERE
		([TransformationSupplierID] = @TransformationSupplierID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TransformationSupplierLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_TransformationSupplierLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TransformationSupplierLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TransformationSupplierLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TransformationSupplierLoadAll];
GO

CREATE PROCEDURE [proc_TransformationSupplierLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[TransformationSupplierID],
		[TransformationSupplierName],
		[TransformationSupplierTelephone],
		[TransformationSupplierAddress],
		[isDeleted]
	FROM [TransformationSupplier]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TransformationSupplierLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_TransformationSupplierLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TransformationSupplierUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TransformationSupplierUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TransformationSupplierUpdate];
GO

CREATE PROCEDURE [proc_TransformationSupplierUpdate]
(
	@TransformationSupplierID int,
	@TransformationSupplierName nvarchar(300) = NULL,
	@TransformationSupplierTelephone nvarchar(50) = NULL,
	@TransformationSupplierAddress nvarchar(500) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [TransformationSupplier]
	SET
		[TransformationSupplierName] = @TransformationSupplierName,
		[TransformationSupplierTelephone] = @TransformationSupplierTelephone,
		[TransformationSupplierAddress] = @TransformationSupplierAddress,
		[isDeleted] = @isDeleted
	WHERE
		[TransformationSupplierID] = @TransformationSupplierID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TransformationSupplierUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_TransformationSupplierUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_TransformationSupplierInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TransformationSupplierInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TransformationSupplierInsert];
GO

CREATE PROCEDURE [proc_TransformationSupplierInsert]
(
	@TransformationSupplierID int = NULL output,
	@TransformationSupplierName nvarchar(300) = NULL,
	@TransformationSupplierTelephone nvarchar(50) = NULL,
	@TransformationSupplierAddress nvarchar(500) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [TransformationSupplier]
	(
		[TransformationSupplierName],
		[TransformationSupplierTelephone],
		[TransformationSupplierAddress],
		[isDeleted]
	)
	VALUES
	(
		@TransformationSupplierName,
		@TransformationSupplierTelephone,
		@TransformationSupplierAddress,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @TransformationSupplierID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TransformationSupplierInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_TransformationSupplierInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_TransformationSupplierDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_TransformationSupplierDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_TransformationSupplierDelete];
GO

CREATE PROCEDURE [proc_TransformationSupplierDelete]
(
	@TransformationSupplierID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [TransformationSupplier]
	WHERE
		[TransformationSupplierID] = @TransformationSupplierID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TransformationSupplierDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_TransformationSupplierDelete Error on Creation'
GO
