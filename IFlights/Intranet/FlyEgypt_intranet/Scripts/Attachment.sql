
USE [Intranetdb_dod]
GO

/****** Object:  StoredProcedure [proc_AttachmentLoadByPrimaryKey]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AttachmentLoadByPrimaryKey]
(
	@AttachmentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AttachmentID],
		[Path]
	FROM [Attachment]
	WHERE
		([AttachmentID] = @AttachmentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AttachmentLoadAll]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentLoadAll];
GO

CREATE PROCEDURE [proc_AttachmentLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AttachmentID],
		[Path]
	FROM [Attachment]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AttachmentUpdate]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentUpdate];
GO

CREATE PROCEDURE [proc_AttachmentUpdate]
(
	@AttachmentID int,
	@Path nvarchar(2000) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Attachment]
	SET
		[Path] = @Path
	WHERE
		[AttachmentID] = @AttachmentID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AttachmentInsert]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentInsert];
GO

CREATE PROCEDURE [proc_AttachmentInsert]
(
	@AttachmentID int = NULL output,
	@Path nvarchar(2000) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Attachment]
	(
		[Path]
	)
	VALUES
	(
		@Path
	)

	SET @Err = @@Error

	SELECT @AttachmentID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AttachmentDelete]    Script Date: 7/28/2015 10:13:09 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentDelete];
GO

CREATE PROCEDURE [proc_AttachmentDelete]
(
	@AttachmentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Attachment]
	WHERE
		[AttachmentID] = @AttachmentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentDelete Error on Creation'
GO
