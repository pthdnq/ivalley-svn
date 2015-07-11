
/****** Object:  StoredProcedure [proc_ComboCommentLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboCommentLoadByPrimaryKey]
(
	@ComboCommentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboCommentID],
		[ComboUserID],
		[ComboPostID],
		[CommentText],
		[CommentDate],
		[ComboMsgID],
		[IsRead],
		[IsDeleted]
	FROM [ComboComment]
	WHERE
		([ComboCommentID] = @ComboCommentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentLoadAll];
GO

CREATE PROCEDURE [proc_ComboCommentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboCommentID],
		[ComboUserID],
		[ComboPostID],
		[CommentText],
		[CommentDate],
		[ComboMsgID],
		[IsRead],
		[IsDeleted]
	FROM [ComboComment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentUpdate];
GO

CREATE PROCEDURE [proc_ComboCommentUpdate]
(
	@ComboCommentID int,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@CommentText nvarchar(MAX) = NULL,
	@CommentDate datetime = NULL,
	@ComboMsgID int = NULL,
	@IsRead bit = NULL,
	@IsDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboComment]
	SET
		[ComboUserID] = @ComboUserID,
		[ComboPostID] = @ComboPostID,
		[CommentText] = @CommentText,
		[CommentDate] = @CommentDate,
		[ComboMsgID] = @ComboMsgID,
		[IsRead] = @IsRead,
		[IsDeleted] = @IsDeleted
	WHERE
		[ComboCommentID] = @ComboCommentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboCommentInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentInsert];
GO

CREATE PROCEDURE [proc_ComboCommentInsert]
(
	@ComboCommentID int = NULL output,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@CommentText nvarchar(MAX) = NULL,
	@CommentDate datetime = NULL,
	@ComboMsgID int = NULL,
	@IsRead bit = NULL,
	@IsDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboComment]
	(
		[ComboUserID],
		[ComboPostID],
		[CommentText],
		[CommentDate],
		[ComboMsgID],
		[IsRead],
		[IsDeleted]
	)
	VALUES
	(
		@ComboUserID,
		@ComboPostID,
		@CommentText,
		@CommentDate,
		@ComboMsgID,
		@IsRead,
		@IsDeleted
	)

	SET @Err = @@Error

	SELECT @ComboCommentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentDelete];
GO

CREATE PROCEDURE [proc_ComboCommentDelete]
(
	@ComboCommentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboComment]
	WHERE
		[ComboCommentID] = @ComboCommentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentDelete Error on Creation'
GO
