
/****** Object:  StoredProcedure [proc_PrintingPapersLoadByPrimaryKey]    Script Date: 7/23/2015 12:52:38 PM ******/
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
		[PurcahsePaperQuantity]
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

/****** Object:  StoredProcedure [proc_PrintingPapersLoadAll]    Script Date: 7/23/2015 12:52:38 PM ******/
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
		[PurcahsePaperQuantity]
	FROM [PrintingPapers]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PrintingPapersLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PrintingPapersLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PrintingPapersUpdate]    Script Date: 7/23/2015 12:52:38 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintingPapersUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintingPapersUpdate];
GO

CREATE PROCEDURE [proc_PrintingPapersUpdate]
(
	@PrintingPapersID int,
	@PrintingPaperName nvarchar(500) = NULL,
	@PurchasePaperDate datetime = NULL,
	@PurcahsePaperQuantity int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PrintingPapers]
	SET
		[PrintingPaperName] = @PrintingPaperName,
		[PurchasePaperDate] = @PurchasePaperDate,
		[PurcahsePaperQuantity] = @PurcahsePaperQuantity
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




/****** Object:  StoredProcedure [proc_PrintingPapersInsert]    Script Date: 7/23/2015 12:52:38 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PrintingPapersInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PrintingPapersInsert];
GO

CREATE PROCEDURE [proc_PrintingPapersInsert]
(
	@PrintingPapersID int = NULL output,
	@PrintingPaperName nvarchar(500) = NULL,
	@PurchasePaperDate datetime = NULL,
	@PurcahsePaperQuantity int = NULL
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
		[PurcahsePaperQuantity]
	)
	VALUES
	(
		@PrintingPaperName,
		@PurchasePaperDate,
		@PurcahsePaperQuantity
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

/****** Object:  StoredProcedure [proc_PrintingPapersDelete]    Script Date: 7/23/2015 12:52:38 PM ******/
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
