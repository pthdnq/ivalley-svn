
/****** Object:  StoredProcedure [proc_ComboPostAttachmentLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostAttachmentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostAttachmentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboPostAttachmentLoadByPrimaryKey]
(
	@ComboPostAttachmentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostAttachmentID],
		[ComboPostID],
		[AttachmentID]
	FROM [ComboPostAttachment]
	WHERE
		([ComboPostAttachmentID] = @ComboPostAttachmentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostAttachmentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostAttachmentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostAttachmentLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostAttachmentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostAttachmentLoadAll];
GO

CREATE PROCEDURE [proc_ComboPostAttachmentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostAttachmentID],
		[ComboPostID],
		[AttachmentID]
	FROM [ComboPostAttachment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostAttachmentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostAttachmentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostAttachmentUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostAttachmentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostAttachmentUpdate];
GO

CREATE PROCEDURE [proc_ComboPostAttachmentUpdate]
(
	@ComboPostAttachmentID int,
	@ComboPostID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboPostAttachment]
	SET
		[ComboPostID] = @ComboPostID,
		[AttachmentID] = @AttachmentID
	WHERE
		[ComboPostAttachmentID] = @ComboPostAttachmentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostAttachmentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostAttachmentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboPostAttachmentInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostAttachmentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostAttachmentInsert];
GO

CREATE PROCEDURE [proc_ComboPostAttachmentInsert]
(
	@ComboPostAttachmentID int = NULL output,
	@ComboPostID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboPostAttachment]
	(
		[ComboPostID],
		[AttachmentID]
	)
	VALUES
	(
		@ComboPostID,
		@AttachmentID
	)

	SET @Err = @@Error

	SELECT @ComboPostAttachmentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostAttachmentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostAttachmentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostAttachmentDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostAttachmentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostAttachmentDelete];
GO

CREATE PROCEDURE [proc_ComboPostAttachmentDelete]
(
	@ComboPostAttachmentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboPostAttachment]
	WHERE
		[ComboPostAttachmentID] = @ComboPostAttachmentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostAttachmentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostAttachmentDelete Error on Creation'
GO
