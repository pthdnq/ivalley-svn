
/****** Object:  StoredProcedure [proc_CommentUserTagLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentUserTagLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentUserTagLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CommentUserTagLoadByPrimaryKey]
(
	@CommentUserTagID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CommentUserTagID],
		[ComboUserID],
		[ComboCommentID],
		[Offset]
	FROM [CommentUserTag]
	WHERE
		([CommentUserTagID] = @CommentUserTagID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentUserTagLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentUserTagLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentUserTagLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentUserTagLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentUserTagLoadAll];
GO

CREATE PROCEDURE [proc_CommentUserTagLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CommentUserTagID],
		[ComboUserID],
		[ComboCommentID],
		[Offset]
	FROM [CommentUserTag]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentUserTagLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentUserTagLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentUserTagUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentUserTagUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentUserTagUpdate];
GO

CREATE PROCEDURE [proc_CommentUserTagUpdate]
(
	@CommentUserTagID int,
	@ComboUserID int = NULL,
	@ComboCommentID int = NULL,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CommentUserTag]
	SET
		[ComboUserID] = @ComboUserID,
		[ComboCommentID] = @ComboCommentID,
		[Offset] = @Offset
	WHERE
		[CommentUserTagID] = @CommentUserTagID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentUserTagUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentUserTagUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CommentUserTagInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentUserTagInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentUserTagInsert];
GO

CREATE PROCEDURE [proc_CommentUserTagInsert]
(
	@CommentUserTagID int = NULL output,
	@ComboUserID int = NULL,
	@ComboCommentID int = NULL,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [CommentUserTag]
	(
		[ComboUserID],
		[ComboCommentID],
		[Offset]
	)
	VALUES
	(
		@ComboUserID,
		@ComboCommentID,
		@Offset
	)

	SET @Err = @@Error

	SELECT @CommentUserTagID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentUserTagInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentUserTagInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentUserTagDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentUserTagDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentUserTagDelete];
GO

CREATE PROCEDURE [proc_CommentUserTagDelete]
(
	@CommentUserTagID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [CommentUserTag]
	WHERE
		[CommentUserTagID] = @CommentUserTagID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentUserTagDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentUserTagDelete Error on Creation'
GO
