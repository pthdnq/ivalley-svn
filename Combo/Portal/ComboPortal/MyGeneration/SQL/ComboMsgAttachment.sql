
/****** Object:  StoredProcedure [proc_ComboMsgAttachmentLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgAttachmentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgAttachmentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboMsgAttachmentLoadByPrimaryKey]
(
	@ComboMsgAttachmentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboMsgAttachmentID],
		[ComboMsgID],
		[AttachmentID]
	FROM [ComboMsgAttachment]
	WHERE
		([ComboMsgAttachmentID] = @ComboMsgAttachmentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgAttachmentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgAttachmentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboMsgAttachmentLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgAttachmentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgAttachmentLoadAll];
GO

CREATE PROCEDURE [proc_ComboMsgAttachmentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboMsgAttachmentID],
		[ComboMsgID],
		[AttachmentID]
	FROM [ComboMsgAttachment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgAttachmentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgAttachmentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboMsgAttachmentUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgAttachmentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgAttachmentUpdate];
GO

CREATE PROCEDURE [proc_ComboMsgAttachmentUpdate]
(
	@ComboMsgAttachmentID int,
	@ComboMsgID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboMsgAttachment]
	SET
		[ComboMsgID] = @ComboMsgID,
		[AttachmentID] = @AttachmentID
	WHERE
		[ComboMsgAttachmentID] = @ComboMsgAttachmentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgAttachmentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgAttachmentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboMsgAttachmentInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgAttachmentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgAttachmentInsert];
GO

CREATE PROCEDURE [proc_ComboMsgAttachmentInsert]
(
	@ComboMsgAttachmentID int = NULL output,
	@ComboMsgID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboMsgAttachment]
	(
		[ComboMsgID],
		[AttachmentID]
	)
	VALUES
	(
		@ComboMsgID,
		@AttachmentID
	)

	SET @Err = @@Error

	SELECT @ComboMsgAttachmentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgAttachmentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgAttachmentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboMsgAttachmentDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgAttachmentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgAttachmentDelete];
GO

CREATE PROCEDURE [proc_ComboMsgAttachmentDelete]
(
	@ComboMsgAttachmentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboMsgAttachment]
	WHERE
		[ComboMsgAttachmentID] = @ComboMsgAttachmentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgAttachmentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgAttachmentDelete Error on Creation'
GO
