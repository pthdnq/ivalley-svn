
/****** Object:  StoredProcedure [proc_ComboPostLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboPostLoadByPrimaryKey]
(
	@ComboPostID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostID],
		[ComboUserID],
		[PostText],
		[PostDate],
		[IsDeleted]
	FROM [ComboPost]
	WHERE
		([ComboPostID] = @ComboPostID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostLoadAll];
GO

CREATE PROCEDURE [proc_ComboPostLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostID],
		[ComboUserID],
		[PostText],
		[PostDate],
		[IsDeleted]
	FROM [ComboPost]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostUpdate];
GO

CREATE PROCEDURE [proc_ComboPostUpdate]
(
	@ComboPostID int,
	@ComboUserID int = NULL,
	@PostText nvarchar(MAX) = NULL,
	@PostDate datetime = NULL,
	@IsDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboPost]
	SET
		[ComboUserID] = @ComboUserID,
		[PostText] = @PostText,
		[PostDate] = @PostDate,
		[IsDeleted] = @IsDeleted
	WHERE
		[ComboPostID] = @ComboPostID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboPostInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostInsert];
GO

CREATE PROCEDURE [proc_ComboPostInsert]
(
	@ComboPostID int = NULL output,
	@ComboUserID int = NULL,
	@PostText nvarchar(MAX) = NULL,
	@PostDate datetime = NULL,
	@IsDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboPost]
	(
		[ComboUserID],
		[PostText],
		[PostDate],
		[IsDeleted]
	)
	VALUES
	(
		@ComboUserID,
		@PostText,
		@PostDate,
		@IsDeleted
	)

	SET @Err = @@Error

	SELECT @ComboPostID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostDelete];
GO

CREATE PROCEDURE [proc_ComboPostDelete]
(
	@ComboPostID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboPost]
	WHERE
		[ComboPostID] = @ComboPostID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostDelete Error on Creation'
GO
