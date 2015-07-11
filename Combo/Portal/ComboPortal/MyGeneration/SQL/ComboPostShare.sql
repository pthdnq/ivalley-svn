
/****** Object:  StoredProcedure [proc_ComboPostShareLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostShareLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostShareLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboPostShareLoadByPrimaryKey]
(
	@ComboPostShareID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostShareID],
		[ComboUserID],
		[ComboPostID],
		[ShareDate]
	FROM [ComboPostShare]
	WHERE
		([ComboPostShareID] = @ComboPostShareID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostShareLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostShareLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostShareLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostShareLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostShareLoadAll];
GO

CREATE PROCEDURE [proc_ComboPostShareLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostShareID],
		[ComboUserID],
		[ComboPostID],
		[ShareDate]
	FROM [ComboPostShare]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostShareLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostShareLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostShareUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostShareUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostShareUpdate];
GO

CREATE PROCEDURE [proc_ComboPostShareUpdate]
(
	@ComboPostShareID int,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@ShareDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboPostShare]
	SET
		[ComboUserID] = @ComboUserID,
		[ComboPostID] = @ComboPostID,
		[ShareDate] = @ShareDate
	WHERE
		[ComboPostShareID] = @ComboPostShareID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostShareUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostShareUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboPostShareInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostShareInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostShareInsert];
GO

CREATE PROCEDURE [proc_ComboPostShareInsert]
(
	@ComboPostShareID int = NULL output,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@ShareDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboPostShare]
	(
		[ComboUserID],
		[ComboPostID],
		[ShareDate]
	)
	VALUES
	(
		@ComboUserID,
		@ComboPostID,
		@ShareDate
	)

	SET @Err = @@Error

	SELECT @ComboPostShareID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostShareInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostShareInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostShareDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostShareDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostShareDelete];
GO

CREATE PROCEDURE [proc_ComboPostShareDelete]
(
	@ComboPostShareID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboPostShare]
	WHERE
		[ComboPostShareID] = @ComboPostShareID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostShareDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostShareDelete Error on Creation'
GO
