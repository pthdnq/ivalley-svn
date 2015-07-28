
/****** Object:  StoredProcedure [proc_CommentAttachmentLoadByPrimaryKey]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentAttachmentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentAttachmentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CommentAttachmentLoadByPrimaryKey]
(
	@CommentAttachmentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CommentAttachmentID],
		[CommentID],
		[AttachmentID]
	FROM [CommentAttachment]
	WHERE
		([CommentAttachmentID] = @CommentAttachmentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentAttachmentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentAttachmentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentAttachmentLoadAll]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentAttachmentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentAttachmentLoadAll];
GO

CREATE PROCEDURE [proc_CommentAttachmentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CommentAttachmentID],
		[CommentID],
		[AttachmentID]
	FROM [CommentAttachment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentAttachmentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentAttachmentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentAttachmentUpdate]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentAttachmentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentAttachmentUpdate];
GO

CREATE PROCEDURE [proc_CommentAttachmentUpdate]
(
	@CommentAttachmentID int,
	@CommentID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CommentAttachment]
	SET
		[CommentID] = @CommentID,
		[AttachmentID] = @AttachmentID
	WHERE
		[CommentAttachmentID] = @CommentAttachmentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentAttachmentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentAttachmentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CommentAttachmentInsert]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentAttachmentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentAttachmentInsert];
GO

CREATE PROCEDURE [proc_CommentAttachmentInsert]
(
	@CommentAttachmentID int = NULL output,
	@CommentID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [CommentAttachment]
	(
		[CommentID],
		[AttachmentID]
	)
	VALUES
	(
		@CommentID,
		@AttachmentID
	)

	SET @Err = @@Error

	SELECT @CommentAttachmentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentAttachmentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentAttachmentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CommentAttachmentDelete]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CommentAttachmentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CommentAttachmentDelete];
GO

CREATE PROCEDURE [proc_CommentAttachmentDelete]
(
	@CommentAttachmentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [CommentAttachment]
	WHERE
		[CommentAttachmentID] = @CommentAttachmentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CommentAttachmentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CommentAttachmentDelete Error on Creation'
GO
