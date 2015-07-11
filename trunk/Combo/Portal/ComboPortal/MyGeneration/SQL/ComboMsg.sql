
/****** Object:  StoredProcedure [proc_ComboMsgLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboMsgLoadByPrimaryKey]
(
	@ComboMsgID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboMsgID],
		[ComboUserID],
		[MsgText],
		[MsgDate],
		[IsDeleted],
		[IsRead]
	FROM [ComboMsg]
	WHERE
		([ComboMsgID] = @ComboMsgID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboMsgLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgLoadAll];
GO

CREATE PROCEDURE [proc_ComboMsgLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboMsgID],
		[ComboUserID],
		[MsgText],
		[MsgDate],
		[IsDeleted],
		[IsRead]
	FROM [ComboMsg]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboMsgUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgUpdate];
GO

CREATE PROCEDURE [proc_ComboMsgUpdate]
(
	@ComboMsgID int,
	@ComboUserID int = NULL,
	@MsgText nvarchar(MAX) = NULL,
	@MsgDate datetime = NULL,
	@IsDeleted bit = NULL,
	@IsRead bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboMsg]
	SET
		[ComboUserID] = @ComboUserID,
		[MsgText] = @MsgText,
		[MsgDate] = @MsgDate,
		[IsDeleted] = @IsDeleted,
		[IsRead] = @IsRead
	WHERE
		[ComboMsgID] = @ComboMsgID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboMsgInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgInsert];
GO

CREATE PROCEDURE [proc_ComboMsgInsert]
(
	@ComboMsgID int = NULL output,
	@ComboUserID int = NULL,
	@MsgText nvarchar(MAX) = NULL,
	@MsgDate datetime = NULL,
	@IsDeleted bit = NULL,
	@IsRead bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboMsg]
	(
		[ComboUserID],
		[MsgText],
		[MsgDate],
		[IsDeleted],
		[IsRead]
	)
	VALUES
	(
		@ComboUserID,
		@MsgText,
		@MsgDate,
		@IsDeleted,
		@IsRead
	)

	SET @Err = @@Error

	SELECT @ComboMsgID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboMsgDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboMsgDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboMsgDelete];
GO

CREATE PROCEDURE [proc_ComboMsgDelete]
(
	@ComboMsgID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboMsg]
	WHERE
		[ComboMsgID] = @ComboMsgID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboMsgDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboMsgDelete Error on Creation'
GO
