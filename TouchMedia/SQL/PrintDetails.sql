
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
