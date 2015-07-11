
/****** Object:  StoredProcedure [proc_ComboUserSettingsLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserSettingsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserSettingsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboUserSettingsLoadByPrimaryKey]
(
	@ComboUserSettingsID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserSettingsID],
		[ComboUserID],
		[IsPostsDownloadable],
		[ReceiveNotificationType]
	FROM [ComboUserSettings]
	WHERE
		([ComboUserSettingsID] = @ComboUserSettingsID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserSettingsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserSettingsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserSettingsLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserSettingsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserSettingsLoadAll];
GO

CREATE PROCEDURE [proc_ComboUserSettingsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserSettingsID],
		[ComboUserID],
		[IsPostsDownloadable],
		[ReceiveNotificationType]
	FROM [ComboUserSettings]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserSettingsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserSettingsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserSettingsUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserSettingsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserSettingsUpdate];
GO

CREATE PROCEDURE [proc_ComboUserSettingsUpdate]
(
	@ComboUserSettingsID int,
	@ComboUserID int,
	@IsPostsDownloadable bit = NULL,
	@ReceiveNotificationType smallint = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboUserSettings]
	SET
		[ComboUserID] = @ComboUserID,
		[IsPostsDownloadable] = @IsPostsDownloadable,
		[ReceiveNotificationType] = @ReceiveNotificationType
	WHERE
		[ComboUserSettingsID] = @ComboUserSettingsID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserSettingsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserSettingsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboUserSettingsInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserSettingsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserSettingsInsert];
GO

CREATE PROCEDURE [proc_ComboUserSettingsInsert]
(
	@ComboUserSettingsID int = NULL output,
	@ComboUserID int,
	@IsPostsDownloadable bit = NULL,
	@ReceiveNotificationType smallint = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboUserSettings]
	(
		[ComboUserID],
		[IsPostsDownloadable],
		[ReceiveNotificationType]
	)
	VALUES
	(
		@ComboUserID,
		@IsPostsDownloadable,
		@ReceiveNotificationType
	)

	SET @Err = @@Error

	SELECT @ComboUserSettingsID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserSettingsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserSettingsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserSettingsDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserSettingsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserSettingsDelete];
GO

CREATE PROCEDURE [proc_ComboUserSettingsDelete]
(
	@ComboUserSettingsID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboUserSettings]
	WHERE
		[ComboUserSettingsID] = @ComboUserSettingsID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserSettingsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserSettingsDelete Error on Creation'
GO
