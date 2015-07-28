
/****** Object:  StoredProcedure [proc_IssueLoadByPrimaryKey]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_IssueLoadByPrimaryKey]
(
	@IssueID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IssueID],
		[UserID],
		[IssueText],
		[IssueTitle],
		[IssueDate],
		[StatusID],
		[IssueTypeID]
	FROM [Issue]
	WHERE
		([IssueID] = @IssueID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueLoadAll]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueLoadAll];
GO

CREATE PROCEDURE [proc_IssueLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IssueID],
		[UserID],
		[IssueText],
		[IssueTitle],
		[IssueDate],
		[StatusID],
		[IssueTypeID]
	FROM [Issue]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueUpdate]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueUpdate];
GO

CREATE PROCEDURE [proc_IssueUpdate]
(
	@IssueID int,
	@UserID uniqueidentifier = NULL,
	@IssueText nvarchar(MAX) = NULL,
	@IssueTitle nvarchar(500) = NULL,
	@IssueDate datetime = NULL,
	@StatusID int = NULL,
	@IssueTypeID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Issue]
	SET
		[UserID] = @UserID,
		[IssueText] = @IssueText,
		[IssueTitle] = @IssueTitle,
		[IssueDate] = @IssueDate,
		[StatusID] = @StatusID,
		[IssueTypeID] = @IssueTypeID
	WHERE
		[IssueID] = @IssueID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_IssueInsert]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueInsert];
GO

CREATE PROCEDURE [proc_IssueInsert]
(
	@IssueID int = NULL output,
	@UserID uniqueidentifier = NULL,
	@IssueText nvarchar(MAX) = NULL,
	@IssueTitle nvarchar(500) = NULL,
	@IssueDate datetime = NULL,
	@StatusID int = NULL,
	@IssueTypeID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Issue]
	(
		[UserID],
		[IssueText],
		[IssueTitle],
		[IssueDate],
		[StatusID],
		[IssueTypeID]
	)
	VALUES
	(
		@UserID,
		@IssueText,
		@IssueTitle,
		@IssueDate,
		@StatusID,
		@IssueTypeID
	)

	SET @Err = @@Error

	SELECT @IssueID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueDelete]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueDelete];
GO

CREATE PROCEDURE [proc_IssueDelete]
(
	@IssueID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Issue]
	WHERE
		[IssueID] = @IssueID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueDelete Error on Creation'
GO
