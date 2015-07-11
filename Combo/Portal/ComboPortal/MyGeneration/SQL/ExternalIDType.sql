
/****** Object:  StoredProcedure [proc_ExternalIDTypeLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ExternalIDTypeLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ExternalIDTypeLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ExternalIDTypeLoadByPrimaryKey]
(
	@ExternalIDTypeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ExternalIDTypeID],
		[Name]
	FROM [ExternalIDType]
	WHERE
		([ExternalIDTypeID] = @ExternalIDTypeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ExternalIDTypeLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ExternalIDTypeLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ExternalIDTypeLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ExternalIDTypeLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ExternalIDTypeLoadAll];
GO

CREATE PROCEDURE [proc_ExternalIDTypeLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ExternalIDTypeID],
		[Name]
	FROM [ExternalIDType]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ExternalIDTypeLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ExternalIDTypeLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ExternalIDTypeUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ExternalIDTypeUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ExternalIDTypeUpdate];
GO

CREATE PROCEDURE [proc_ExternalIDTypeUpdate]
(
	@ExternalIDTypeID int,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ExternalIDType]
	SET
		[Name] = @Name
	WHERE
		[ExternalIDTypeID] = @ExternalIDTypeID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ExternalIDTypeUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ExternalIDTypeUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ExternalIDTypeInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ExternalIDTypeInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ExternalIDTypeInsert];
GO

CREATE PROCEDURE [proc_ExternalIDTypeInsert]
(
	@ExternalIDTypeID int = NULL output,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ExternalIDType]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)

	SET @Err = @@Error

	SELECT @ExternalIDTypeID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ExternalIDTypeInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ExternalIDTypeInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ExternalIDTypeDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ExternalIDTypeDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ExternalIDTypeDelete];
GO

CREATE PROCEDURE [proc_ExternalIDTypeDelete]
(
	@ExternalIDTypeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ExternalIDType]
	WHERE
		[ExternalIDTypeID] = @ExternalIDTypeID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ExternalIDTypeDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ExternalIDTypeDelete Error on Creation'
GO
