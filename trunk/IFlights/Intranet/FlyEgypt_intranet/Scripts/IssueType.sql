
/****** Object:  StoredProcedure [proc_IssueTypeLoadByPrimaryKey]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueTypeLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueTypeLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_IssueTypeLoadByPrimaryKey]
(
	@IssueTypeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IssueTypeID],
		[Name]
	FROM [IssueType]
	WHERE
		([IssueTypeID] = @IssueTypeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueTypeLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueTypeLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueTypeLoadAll]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueTypeLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueTypeLoadAll];
GO

CREATE PROCEDURE [proc_IssueTypeLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IssueTypeID],
		[Name]
	FROM [IssueType]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueTypeLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueTypeLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueTypeUpdate]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueTypeUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueTypeUpdate];
GO

CREATE PROCEDURE [proc_IssueTypeUpdate]
(
	@IssueTypeID int,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [IssueType]
	SET
		[Name] = @Name
	WHERE
		[IssueTypeID] = @IssueTypeID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueTypeUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueTypeUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_IssueTypeInsert]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueTypeInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueTypeInsert];
GO

CREATE PROCEDURE [proc_IssueTypeInsert]
(
	@IssueTypeID int = NULL output,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [IssueType]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)

	SET @Err = @@Error

	SELECT @IssueTypeID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueTypeInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueTypeInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueTypeDelete]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueTypeDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueTypeDelete];
GO

CREATE PROCEDURE [proc_IssueTypeDelete]
(
	@IssueTypeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [IssueType]
	WHERE
		[IssueTypeID] = @IssueTypeID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueTypeDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueTypeDelete Error on Creation'
GO
