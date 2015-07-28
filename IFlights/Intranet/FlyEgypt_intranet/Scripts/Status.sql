
/****** Object:  StoredProcedure [proc_StatusLoadByPrimaryKey]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_StatusLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_StatusLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_StatusLoadByPrimaryKey]
(
	@StatusID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[StatusID],
		[Name]
	FROM [Status]
	WHERE
		([StatusID] = @StatusID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_StatusLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_StatusLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_StatusLoadAll]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_StatusLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_StatusLoadAll];
GO

CREATE PROCEDURE [proc_StatusLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[StatusID],
		[Name]
	FROM [Status]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_StatusLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_StatusLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_StatusUpdate]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_StatusUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_StatusUpdate];
GO

CREATE PROCEDURE [proc_StatusUpdate]
(
	@StatusID int,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Status]
	SET
		[Name] = @Name
	WHERE
		[StatusID] = @StatusID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_StatusUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_StatusUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_StatusInsert]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_StatusInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_StatusInsert];
GO

CREATE PROCEDURE [proc_StatusInsert]
(
	@StatusID int = NULL output,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Status]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)

	SET @Err = @@Error

	SELECT @StatusID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_StatusInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_StatusInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_StatusDelete]    Script Date: 7/28/2015 10:13:10 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_StatusDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_StatusDelete];
GO

CREATE PROCEDURE [proc_StatusDelete]
(
	@StatusID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Status]
	WHERE
		[StatusID] = @StatusID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_StatusDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_StatusDelete Error on Creation'
GO
