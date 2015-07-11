
/****** Object:  StoredProcedure [proc_ComboCommentAttachmentLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentAttachmentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentAttachmentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboCommentAttachmentLoadByPrimaryKey]
(
	@ComboCommentAttachmentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboCommentAttachmentID],
		[ComboCommnetID],
		[AttachmentID]
	FROM [ComboCommentAttachment]
	WHERE
		([ComboCommentAttachmentID] = @ComboCommentAttachmentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentAttachmentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentAttachmentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentAttachmentLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentAttachmentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentAttachmentLoadAll];
GO

CREATE PROCEDURE [proc_ComboCommentAttachmentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboCommentAttachmentID],
		[ComboCommnetID],
		[AttachmentID]
	FROM [ComboCommentAttachment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentAttachmentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentAttachmentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentAttachmentUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentAttachmentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentAttachmentUpdate];
GO

CREATE PROCEDURE [proc_ComboCommentAttachmentUpdate]
(
	@ComboCommentAttachmentID int,
	@ComboCommnetID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboCommentAttachment]
	SET
		[ComboCommnetID] = @ComboCommnetID,
		[AttachmentID] = @AttachmentID
	WHERE
		[ComboCommentAttachmentID] = @ComboCommentAttachmentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentAttachmentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentAttachmentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboCommentAttachmentInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentAttachmentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentAttachmentInsert];
GO

CREATE PROCEDURE [proc_ComboCommentAttachmentInsert]
(
	@ComboCommentAttachmentID int = NULL output,
	@ComboCommnetID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboCommentAttachment]
	(
		[ComboCommnetID],
		[AttachmentID]
	)
	VALUES
	(
		@ComboCommnetID,
		@AttachmentID
	)

	SET @Err = @@Error

	SELECT @ComboCommentAttachmentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentAttachmentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentAttachmentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentAttachmentDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentAttachmentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentAttachmentDelete];
GO

CREATE PROCEDURE [proc_ComboCommentAttachmentDelete]
(
	@ComboCommentAttachmentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboCommentAttachment]
	WHERE
		[ComboCommentAttachmentID] = @ComboCommentAttachmentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentAttachmentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentAttachmentDelete Error on Creation'
GO
