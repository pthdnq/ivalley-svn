
/****** Object:  StoredProcedure [proc_UserRankLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserRankLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserRankLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_UserRankLoadByPrimaryKey]
(
	@UserRankID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[UserRankID],
		[Name],
		[IconPath]
	FROM [UserRank]
	WHERE
		([UserRankID] = @UserRankID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserRankLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserRankLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UserRankLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserRankLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserRankLoadAll];
GO

CREATE PROCEDURE [proc_UserRankLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[UserRankID],
		[Name],
		[IconPath]
	FROM [UserRank]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserRankLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserRankLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UserRankUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserRankUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserRankUpdate];
GO

CREATE PROCEDURE [proc_UserRankUpdate]
(
	@UserRankID int,
	@Name nvarchar(200) = NULL,
	@IconPath nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [UserRank]
	SET
		[Name] = @Name,
		[IconPath] = @IconPath
	WHERE
		[UserRankID] = @UserRankID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserRankUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserRankUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_UserRankInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserRankInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserRankInsert];
GO

CREATE PROCEDURE [proc_UserRankInsert]
(
	@UserRankID int = NULL output,
	@Name nvarchar(200) = NULL,
	@IconPath nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [UserRank]
	(
		[Name],
		[IconPath]
	)
	VALUES
	(
		@Name,
		@IconPath
	)

	SET @Err = @@Error

	SELECT @UserRankID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserRankInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserRankInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UserRankDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserRankDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserRankDelete];
GO

CREATE PROCEDURE [proc_UserRankDelete]
(
	@UserRankID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [UserRank]
	WHERE
		[UserRankID] = @UserRankID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserRankDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserRankDelete Error on Creation'
GO
