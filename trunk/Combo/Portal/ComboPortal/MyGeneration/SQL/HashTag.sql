
/****** Object:  StoredProcedure [proc_HashTagLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_HashTagLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_HashTagLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_HashTagLoadByPrimaryKey]
(
	@HashTagID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HashTagID],
		[Name]
	FROM [HashTag]
	WHERE
		([HashTagID] = @HashTagID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HashTagLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_HashTagLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_HashTagLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_HashTagLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_HashTagLoadAll];
GO

CREATE PROCEDURE [proc_HashTagLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HashTagID],
		[Name]
	FROM [HashTag]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HashTagLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_HashTagLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_HashTagUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_HashTagUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_HashTagUpdate];
GO

CREATE PROCEDURE [proc_HashTagUpdate]
(
	@HashTagID int,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [HashTag]
	SET
		[Name] = @Name
	WHERE
		[HashTagID] = @HashTagID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HashTagUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_HashTagUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_HashTagInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_HashTagInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_HashTagInsert];
GO

CREATE PROCEDURE [proc_HashTagInsert]
(
	@HashTagID int = NULL output,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [HashTag]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)

	SET @Err = @@Error

	SELECT @HashTagID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HashTagInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_HashTagInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_HashTagDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_HashTagDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_HashTagDelete];
GO

CREATE PROCEDURE [proc_HashTagDelete]
(
	@HashTagID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [HashTag]
	WHERE
		[HashTagID] = @HashTagID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HashTagDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_HashTagDelete Error on Creation'
GO
