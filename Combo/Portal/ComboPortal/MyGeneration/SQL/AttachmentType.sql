
/****** Object:  StoredProcedure [proc_AttachmentTypeLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentTypeLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentTypeLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AttachmentTypeLoadByPrimaryKey]
(
	@AttachmentTypeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AttachmentTypeID],
		[Name]
	FROM [AttachmentType]
	WHERE
		([AttachmentTypeID] = @AttachmentTypeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentTypeLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentTypeLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AttachmentTypeLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentTypeLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentTypeLoadAll];
GO

CREATE PROCEDURE [proc_AttachmentTypeLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AttachmentTypeID],
		[Name]
	FROM [AttachmentType]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentTypeLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentTypeLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AttachmentTypeUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentTypeUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentTypeUpdate];
GO

CREATE PROCEDURE [proc_AttachmentTypeUpdate]
(
	@AttachmentTypeID int,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [AttachmentType]
	SET
		[Name] = @Name
	WHERE
		[AttachmentTypeID] = @AttachmentTypeID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentTypeUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentTypeUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AttachmentTypeInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentTypeInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentTypeInsert];
GO

CREATE PROCEDURE [proc_AttachmentTypeInsert]
(
	@AttachmentTypeID int = NULL output,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [AttachmentType]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)

	SET @Err = @@Error

	SELECT @AttachmentTypeID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentTypeInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentTypeInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AttachmentTypeDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AttachmentTypeDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AttachmentTypeDelete];
GO

CREATE PROCEDURE [proc_AttachmentTypeDelete]
(
	@AttachmentTypeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [AttachmentType]
	WHERE
		[AttachmentTypeID] = @AttachmentTypeID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AttachmentTypeDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AttachmentTypeDelete Error on Creation'
GO
