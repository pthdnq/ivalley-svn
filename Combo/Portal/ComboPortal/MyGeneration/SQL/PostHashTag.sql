
/****** Object:  StoredProcedure [proc_PostHashTagLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostHashTagLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostHashTagLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_PostHashTagLoadByPrimaryKey]
(
	@HashTagID int,
	@ComboPostID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HashTagID],
		[ComboPostID],
		[Offset]
	FROM [PostHashTag]
	WHERE
		([HashTagID] = @HashTagID) AND
		([ComboPostID] = @ComboPostID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostHashTagLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostHashTagLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PostHashTagLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostHashTagLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostHashTagLoadAll];
GO

CREATE PROCEDURE [proc_PostHashTagLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HashTagID],
		[ComboPostID],
		[Offset]
	FROM [PostHashTag]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostHashTagLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostHashTagLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PostHashTagUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostHashTagUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostHashTagUpdate];
GO

CREATE PROCEDURE [proc_PostHashTagUpdate]
(
	@HashTagID int,
	@ComboPostID int,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PostHashTag]
	SET
		[Offset] = @Offset
	WHERE
		[HashTagID] = @HashTagID
	AND	[ComboPostID] = @ComboPostID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostHashTagUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostHashTagUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_PostHashTagInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostHashTagInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostHashTagInsert];
GO

CREATE PROCEDURE [proc_PostHashTagInsert]
(
	@HashTagID int,
	@ComboPostID int,
	@Offset int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [PostHashTag]
	(
		[HashTagID],
		[ComboPostID],
		[Offset]
	)
	VALUES
	(
		@HashTagID,
		@ComboPostID,
		@Offset
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostHashTagInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostHashTagInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_PostHashTagDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_PostHashTagDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_PostHashTagDelete];
GO

CREATE PROCEDURE [proc_PostHashTagDelete]
(
	@HashTagID int,
	@ComboPostID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [PostHashTag]
	WHERE
		[HashTagID] = @HashTagID AND
		[ComboPostID] = @ComboPostID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PostHashTagDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PostHashTagDelete Error on Creation'
GO
