
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
