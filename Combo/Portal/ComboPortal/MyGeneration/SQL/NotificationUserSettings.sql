
/****** Object:  StoredProcedure [proc_NotificationUserSettingsLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationUserSettingsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationUserSettingsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_NotificationUserSettingsLoadByPrimaryKey]
(
	@ComboUserID int,
	@NotificationTypeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[NotificationTypeID],
		[Status]
	FROM [NotificationUserSettings]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([NotificationTypeID] = @NotificationTypeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationUserSettingsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationUserSettingsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NotificationUserSettingsLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationUserSettingsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationUserSettingsLoadAll];
GO

CREATE PROCEDURE [proc_NotificationUserSettingsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[NotificationTypeID],
		[Status]
	FROM [NotificationUserSettings]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationUserSettingsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationUserSettingsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NotificationUserSettingsUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationUserSettingsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationUserSettingsUpdate];
GO

CREATE PROCEDURE [proc_NotificationUserSettingsUpdate]
(
	@ComboUserID int,
	@NotificationTypeID int,
	@Status smallint = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [NotificationUserSettings]
	SET
		[Status] = @Status
	WHERE
		[ComboUserID] = @ComboUserID
	AND	[NotificationTypeID] = @NotificationTypeID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationUserSettingsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationUserSettingsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_NotificationUserSettingsInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationUserSettingsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationUserSettingsInsert];
GO

CREATE PROCEDURE [proc_NotificationUserSettingsInsert]
(
	@ComboUserID int,
	@NotificationTypeID int,
	@Status smallint = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [NotificationUserSettings]
	(
		[ComboUserID],
		[NotificationTypeID],
		[Status]
	)
	VALUES
	(
		@ComboUserID,
		@NotificationTypeID,
		@Status
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationUserSettingsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationUserSettingsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NotificationUserSettingsDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationUserSettingsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationUserSettingsDelete];
GO

CREATE PROCEDURE [proc_NotificationUserSettingsDelete]
(
	@ComboUserID int,
	@NotificationTypeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [NotificationUserSettings]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[NotificationTypeID] = @NotificationTypeID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationUserSettingsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationUserSettingsDelete Error on Creation'
GO
