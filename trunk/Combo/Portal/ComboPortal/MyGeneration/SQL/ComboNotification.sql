
/****** Object:  StoredProcedure [proc_ComboNotificationLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboNotificationLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboNotificationLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboNotificationLoadByPrimaryKey]
(
	@ComboNotificationID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboNotificationID],
		[ComboUserID],
		[NotificationBody],
		[NotificationDate],
		[IsRead],
		[NotificationType]
	FROM [ComboNotification]
	WHERE
		([ComboNotificationID] = @ComboNotificationID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboNotificationLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboNotificationLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboNotificationLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboNotificationLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboNotificationLoadAll];
GO

CREATE PROCEDURE [proc_ComboNotificationLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboNotificationID],
		[ComboUserID],
		[NotificationBody],
		[NotificationDate],
		[IsRead],
		[NotificationType]
	FROM [ComboNotification]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboNotificationLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboNotificationLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboNotificationUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboNotificationUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboNotificationUpdate];
GO

CREATE PROCEDURE [proc_ComboNotificationUpdate]
(
	@ComboNotificationID int,
	@ComboUserID int = NULL,
	@NotificationBody nvarchar(MAX) = NULL,
	@NotificationDate datetime = NULL,
	@IsRead bit = NULL,
	@NotificationType int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboNotification]
	SET
		[ComboUserID] = @ComboUserID,
		[NotificationBody] = @NotificationBody,
		[NotificationDate] = @NotificationDate,
		[IsRead] = @IsRead,
		[NotificationType] = @NotificationType
	WHERE
		[ComboNotificationID] = @ComboNotificationID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboNotificationUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboNotificationUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboNotificationInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboNotificationInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboNotificationInsert];
GO

CREATE PROCEDURE [proc_ComboNotificationInsert]
(
	@ComboNotificationID int = NULL output,
	@ComboUserID int = NULL,
	@NotificationBody nvarchar(MAX) = NULL,
	@NotificationDate datetime = NULL,
	@IsRead bit = NULL,
	@NotificationType int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboNotification]
	(
		[ComboUserID],
		[NotificationBody],
		[NotificationDate],
		[IsRead],
		[NotificationType]
	)
	VALUES
	(
		@ComboUserID,
		@NotificationBody,
		@NotificationDate,
		@IsRead,
		@NotificationType
	)

	SET @Err = @@Error

	SELECT @ComboNotificationID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboNotificationInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboNotificationInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboNotificationDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboNotificationDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboNotificationDelete];
GO

CREATE PROCEDURE [proc_ComboNotificationDelete]
(
	@ComboNotificationID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboNotification]
	WHERE
		[ComboNotificationID] = @ComboNotificationID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboNotificationDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboNotificationDelete Error on Creation'
GO
