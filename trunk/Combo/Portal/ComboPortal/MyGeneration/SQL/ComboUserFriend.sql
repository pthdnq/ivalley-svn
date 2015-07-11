
/****** Object:  StoredProcedure [proc_ComboUserFriendLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserFriendLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserFriendLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboUserFriendLoadByPrimaryKey]
(
	@ComboUserID int,
	@ComboFriendID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboFriendID],
		[RequestApproved],
		[IsBanned]
	FROM [ComboUserFriend]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([ComboFriendID] = @ComboFriendID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserFriendLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserFriendLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserFriendLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserFriendLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserFriendLoadAll];
GO

CREATE PROCEDURE [proc_ComboUserFriendLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboFriendID],
		[RequestApproved],
		[IsBanned]
	FROM [ComboUserFriend]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserFriendLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserFriendLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserFriendUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserFriendUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserFriendUpdate];
GO

CREATE PROCEDURE [proc_ComboUserFriendUpdate]
(
	@ComboUserID int,
	@ComboFriendID int,
	@RequestApproved bit = NULL,
	@IsBanned bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboUserFriend]
	SET
		[RequestApproved] = @RequestApproved,
		[IsBanned] = @IsBanned
	WHERE
		[ComboUserID] = @ComboUserID
	AND	[ComboFriendID] = @ComboFriendID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserFriendUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserFriendUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboUserFriendInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserFriendInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserFriendInsert];
GO

CREATE PROCEDURE [proc_ComboUserFriendInsert]
(
	@ComboUserID int,
	@ComboFriendID int,
	@RequestApproved bit = NULL,
	@IsBanned bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboUserFriend]
	(
		[ComboUserID],
		[ComboFriendID],
		[RequestApproved],
		[IsBanned]
	)
	VALUES
	(
		@ComboUserID,
		@ComboFriendID,
		@RequestApproved,
		@IsBanned
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserFriendInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserFriendInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserFriendDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserFriendDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserFriendDelete];
GO

CREATE PROCEDURE [proc_ComboUserFriendDelete]
(
	@ComboUserID int,
	@ComboFriendID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboUserFriend]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[ComboFriendID] = @ComboFriendID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserFriendDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserFriendDelete Error on Creation'
GO
