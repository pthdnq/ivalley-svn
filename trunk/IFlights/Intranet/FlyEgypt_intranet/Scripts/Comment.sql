
/****** Object:  StoredProcedure [proc_CommentLoadByPrimaryKey]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CommentLoadByPrimaryKey]
(
	@CommentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CommentID],
		[IssueID],
		[UserID],
		[CommentText],
		[CommentDate]
	FROM [Comment]
	WHERE
		([CommentID] = @CommentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentLoadAll]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentLoadAll];
GO

CREATE PROCEDURE [proc_CommentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CommentID],
		[IssueID],
		[UserID],
		[CommentText],
		[CommentDate]
	FROM [Comment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentUpdate]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentUpdate];
GO

CREATE PROCEDURE [proc_CommentUpdate]
(
	@CommentID int,
	@IssueID int = NULL,
	@UserID uniqueidentifier = NULL,
	@CommentText nvarchar(MAX) = NULL,
	@CommentDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Comment]
	SET
		[IssueID] = @IssueID,
		[UserID] = @UserID,
		[CommentText] = @CommentText,
		[CommentDate] = @CommentDate
	WHERE
		[CommentID] = @CommentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CommentInsert]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentInsert];
GO

CREATE PROCEDURE [proc_CommentInsert]
(
	@CommentID int = NULL output,
	@IssueID int = NULL,
	@UserID uniqueidentifier = NULL,
	@CommentText nvarchar(MAX) = NULL,
	@CommentDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Comment]
	(
		[IssueID],
		[UserID],
		[CommentText],
		[CommentDate]
	)
	VALUES
	(
		@IssueID,
		@UserID,
		@CommentText,
		@CommentDate
	)

	SET @Err = @@Error

	SELECT @CommentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentDelete]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentDelete];
GO

CREATE PROCEDURE [proc_CommentDelete]
(
	@CommentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Comment]
	WHERE
		[CommentID] = @CommentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentDelete Error on Creation'
GO
