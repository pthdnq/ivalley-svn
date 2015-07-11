
/****** Object:  StoredProcedure [proc_NotificationTypeLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationTypeLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationTypeLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_NotificationTypeLoadByPrimaryKey]
(
	@NotificationTypeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NotificationTypeID],
		[Name]
	FROM [NotificationType]
	WHERE
		([NotificationTypeID] = @NotificationTypeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationTypeLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationTypeLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NotificationTypeLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationTypeLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationTypeLoadAll];
GO

CREATE PROCEDURE [proc_NotificationTypeLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NotificationTypeID],
		[Name]
	FROM [NotificationType]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationTypeLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationTypeLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NotificationTypeUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationTypeUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationTypeUpdate];
GO

CREATE PROCEDURE [proc_NotificationTypeUpdate]
(
	@NotificationTypeID int,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [NotificationType]
	SET
		[Name] = @Name
	WHERE
		[NotificationTypeID] = @NotificationTypeID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationTypeUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationTypeUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_NotificationTypeInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationTypeInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationTypeInsert];
GO

CREATE PROCEDURE [proc_NotificationTypeInsert]
(
	@NotificationTypeID int = NULL output,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [NotificationType]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)

	SET @Err = @@Error

	SELECT @NotificationTypeID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationTypeInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationTypeInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_NotificationTypeDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_NotificationTypeDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_NotificationTypeDelete];
GO

CREATE PROCEDURE [proc_NotificationTypeDelete]
(
	@NotificationTypeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [NotificationType]
	WHERE
		[NotificationTypeID] = @NotificationTypeID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NotificationTypeDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_NotificationTypeDelete Error on Creation'
GO
