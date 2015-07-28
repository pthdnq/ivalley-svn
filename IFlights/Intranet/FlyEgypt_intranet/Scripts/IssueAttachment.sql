
/****** Object:  StoredProcedure [proc_IssueAttachmentLoadByPrimaryKey]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueAttachmentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueAttachmentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_IssueAttachmentLoadByPrimaryKey]
(
	@IssueAttachmentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IssueAttachmentID],
		[IssueID],
		[AttachmentID]
	FROM [IssueAttachment]
	WHERE
		([IssueAttachmentID] = @IssueAttachmentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueAttachmentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueAttachmentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueAttachmentLoadAll]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueAttachmentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueAttachmentLoadAll];
GO

CREATE PROCEDURE [proc_IssueAttachmentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IssueAttachmentID],
		[IssueID],
		[AttachmentID]
	FROM [IssueAttachment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueAttachmentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueAttachmentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueAttachmentUpdate]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueAttachmentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueAttachmentUpdate];
GO

CREATE PROCEDURE [proc_IssueAttachmentUpdate]
(
	@IssueAttachmentID int,
	@IssueID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [IssueAttachment]
	SET
		[IssueID] = @IssueID,
		[AttachmentID] = @AttachmentID
	WHERE
		[IssueAttachmentID] = @IssueAttachmentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueAttachmentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueAttachmentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_IssueAttachmentInsert]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueAttachmentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueAttachmentInsert];
GO

CREATE PROCEDURE [proc_IssueAttachmentInsert]
(
	@IssueAttachmentID int = NULL output,
	@IssueID int = NULL,
	@AttachmentID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [IssueAttachment]
	(
		[IssueID],
		[AttachmentID]
	)
	VALUES
	(
		@IssueID,
		@AttachmentID
	)

	SET @Err = @@Error

	SELECT @IssueAttachmentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueAttachmentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueAttachmentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_IssueAttachmentDelete]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_IssueAttachmentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_IssueAttachmentDelete];
GO

CREATE PROCEDURE [proc_IssueAttachmentDelete]
(
	@IssueAttachmentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [IssueAttachment]
	WHERE
		[IssueAttachmentID] = @IssueAttachmentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_IssueAttachmentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_IssueAttachmentDelete Error on Creation'
GO
