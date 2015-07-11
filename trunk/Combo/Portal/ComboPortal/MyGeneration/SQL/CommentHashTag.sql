
/****** Object:  StoredProcedure [proc_CommentHashTagLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentHashTagLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentHashTagLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CommentHashTagLoadByPrimaryKey]
(
	@HashTagID int,
	@ComboCommentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HashTagID],
		[ComboCommentID],
		[Offset]
	FROM [CommentHashTag]
	WHERE
		([HashTagID] = @HashTagID) AND
		([ComboCommentID] = @ComboCommentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentHashTagLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentHashTagLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentHashTagLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentHashTagLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentHashTagLoadAll];
GO

CREATE PROCEDURE [proc_CommentHashTagLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HashTagID],
		[ComboCommentID],
		[Offset]
	FROM [CommentHashTag]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentHashTagLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentHashTagLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentHashTagUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentHashTagUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentHashTagUpdate];
GO

CREATE PROCEDURE [proc_CommentHashTagUpdate]
(
	@HashTagID int,
	@ComboCommentID int,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CommentHashTag]
	SET
		[Offset] = @Offset
	WHERE
		[HashTagID] = @HashTagID
	AND	[ComboCommentID] = @ComboCommentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentHashTagUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentHashTagUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CommentHashTagInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentHashTagInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentHashTagInsert];
GO

CREATE PROCEDURE [proc_CommentHashTagInsert]
(
	@HashTagID int,
	@ComboCommentID int,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [CommentHashTag]
	(
		[HashTagID],
		[ComboCommentID],
		[Offset]
	)
	VALUES
	(
		@HashTagID,
		@ComboCommentID,
		@Offset
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentHashTagInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentHashTagInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentHashTagDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentHashTagDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentHashTagDelete];
GO

CREATE PROCEDURE [proc_CommentHashTagDelete]
(
	@HashTagID int,
	@ComboCommentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [CommentHashTag]
	WHERE
		[HashTagID] = @HashTagID AND
		[ComboCommentID] = @ComboCommentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentHashTagDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentHashTagDelete Error on Creation'
GO
