
/****** Object:  StoredProcedure [proc_ProfileFollowerLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileFollowerLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileFollowerLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ProfileFollowerLoadByPrimaryKey]
(
	@ComboUserID int,
	@ComboFollowerID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboFollowerID],
		[IsRequestApproved]
	FROM [ProfileFollower]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([ComboFollowerID] = @ComboFollowerID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileFollowerLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileFollowerLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProfileFollowerLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileFollowerLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileFollowerLoadAll];
GO

CREATE PROCEDURE [proc_ProfileFollowerLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboFollowerID],
		[IsRequestApproved]
	FROM [ProfileFollower]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileFollowerLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileFollowerLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProfileFollowerUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileFollowerUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileFollowerUpdate];
GO

CREATE PROCEDURE [proc_ProfileFollowerUpdate]
(
	@ComboUserID int,
	@ComboFollowerID int,
	@IsRequestApproved bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ProfileFollower]
	SET
		[IsRequestApproved] = @IsRequestApproved
	WHERE
		[ComboUserID] = @ComboUserID
	AND	[ComboFollowerID] = @ComboFollowerID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileFollowerUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileFollowerUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ProfileFollowerInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileFollowerInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileFollowerInsert];
GO

CREATE PROCEDURE [proc_ProfileFollowerInsert]
(
	@ComboUserID int,
	@ComboFollowerID int,
	@IsRequestApproved bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ProfileFollower]
	(
		[ComboUserID],
		[ComboFollowerID],
		[IsRequestApproved]
	)
	VALUES
	(
		@ComboUserID,
		@ComboFollowerID,
		@IsRequestApproved
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileFollowerInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileFollowerInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProfileFollowerDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileFollowerDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileFollowerDelete];
GO

CREATE PROCEDURE [proc_ProfileFollowerDelete]
(
	@ComboUserID int,
	@ComboFollowerID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ProfileFollower]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[ComboFollowerID] = @ComboFollowerID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileFollowerDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileFollowerDelete Error on Creation'
GO
