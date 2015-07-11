
/****** Object:  StoredProcedure [proc_UserActivityLogLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserActivityLogLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserActivityLogLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_UserActivityLogLoadByPrimaryKey]
(
	@UserActivityLogID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[UserActivityLogID],
		[Date],
		[ComboUserID],
		[DaysToDiscount]
	FROM [UserActivityLog]
	WHERE
		([UserActivityLogID] = @UserActivityLogID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserActivityLogLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserActivityLogLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UserActivityLogLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserActivityLogLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserActivityLogLoadAll];
GO

CREATE PROCEDURE [proc_UserActivityLogLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[UserActivityLogID],
		[Date],
		[ComboUserID],
		[DaysToDiscount]
	FROM [UserActivityLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserActivityLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserActivityLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UserActivityLogUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserActivityLogUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserActivityLogUpdate];
GO

CREATE PROCEDURE [proc_UserActivityLogUpdate]
(
	@UserActivityLogID int,
	@Date datetime = NULL,
	@ComboUserID int = NULL,
	@DaysToDiscount int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [UserActivityLog]
	SET
		[Date] = @Date,
		[ComboUserID] = @ComboUserID,
		[DaysToDiscount] = @DaysToDiscount
	WHERE
		[UserActivityLogID] = @UserActivityLogID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserActivityLogUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserActivityLogUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_UserActivityLogInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserActivityLogInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserActivityLogInsert];
GO

CREATE PROCEDURE [proc_UserActivityLogInsert]
(
	@UserActivityLogID int = NULL output,
	@Date datetime = NULL,
	@ComboUserID int = NULL,
	@DaysToDiscount int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [UserActivityLog]
	(
		[Date],
		[ComboUserID],
		[DaysToDiscount]
	)
	VALUES
	(
		@Date,
		@ComboUserID,
		@DaysToDiscount
	)

	SET @Err = @@Error

	SELECT @UserActivityLogID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserActivityLogInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserActivityLogInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UserActivityLogDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UserActivityLogDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UserActivityLogDelete];
GO

CREATE PROCEDURE [proc_UserActivityLogDelete]
(
	@UserActivityLogID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [UserActivityLog]
	WHERE
		[UserActivityLogID] = @UserActivityLogID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UserActivityLogDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_UserActivityLogDelete Error on Creation'
GO
