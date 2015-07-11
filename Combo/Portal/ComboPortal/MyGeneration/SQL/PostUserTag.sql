
/****** Object:  StoredProcedure [proc_PostUserTagLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostUserTagLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostUserTagLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_PostUserTagLoadByPrimaryKey]
(
	@PostUserTagID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PostUserTagID],
		[ComboUserID],
		[ComboPostID],
		[Offset]
	FROM [PostUserTag]
	WHERE
		([PostUserTagID] = @PostUserTagID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostUserTagLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostUserTagLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PostUserTagLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostUserTagLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostUserTagLoadAll];
GO

CREATE PROCEDURE [proc_PostUserTagLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PostUserTagID],
		[ComboUserID],
		[ComboPostID],
		[Offset]
	FROM [PostUserTag]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostUserTagLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostUserTagLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PostUserTagUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostUserTagUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostUserTagUpdate];
GO

CREATE PROCEDURE [proc_PostUserTagUpdate]
(
	@PostUserTagID int,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PostUserTag]
	SET
		[ComboUserID] = @ComboUserID,
		[ComboPostID] = @ComboPostID,
		[Offset] = @Offset
	WHERE
		[PostUserTagID] = @PostUserTagID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostUserTagUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostUserTagUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_PostUserTagInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostUserTagInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostUserTagInsert];
GO

CREATE PROCEDURE [proc_PostUserTagInsert]
(
	@PostUserTagID int = NULL output,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [PostUserTag]
	(
		[ComboUserID],
		[ComboPostID],
		[Offset]
	)
	VALUES
	(
		@ComboUserID,
		@ComboPostID,
		@Offset
	)

	SET @Err = @@Error

	SELECT @PostUserTagID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostUserTagInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostUserTagInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PostUserTagDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostUserTagDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostUserTagDelete];
GO

CREATE PROCEDURE [proc_PostUserTagDelete]
(
	@PostUserTagID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [PostUserTag]
	WHERE
		[PostUserTagID] = @PostUserTagID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostUserTagDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostUserTagDelete Error on Creation'
GO
