
USE [Combo_db]
GO

/****** Object:  StoredProcedure [proc_ComboUserLogLoadByPrimaryKey]    Script Date: 22/07/2015 1:30:10 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserLogLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserLogLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboUserLogLoadByPrimaryKey]
(
	@ComboUserLogID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserLogID],
		[ComboUserID],
		[UserName],
		[DisplayName],
		[Email],
		[BirthDate],
		[Bio],
		[CountryID],
		[UserRankID],
		[Phone],
		[Website],
		[LogDate]
	FROM [ComboUserLog]
	WHERE
		([ComboUserLogID] = @ComboUserLogID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserLogLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserLogLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserLogLoadAll]    Script Date: 22/07/2015 1:30:10 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserLogLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserLogLoadAll];
GO

CREATE PROCEDURE [proc_ComboUserLogLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserLogID],
		[ComboUserID],
		[UserName],
		[DisplayName],
		[Email],
		[BirthDate],
		[Bio],
		[CountryID],
		[UserRankID],
		[Phone],
		[Website],
		[LogDate]
	FROM [ComboUserLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserLogUpdate]    Script Date: 22/07/2015 1:30:10 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserLogUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserLogUpdate];
GO

CREATE PROCEDURE [proc_ComboUserLogUpdate]
(
	@ComboUserLogID int,
	@ComboUserID int = NULL,
	@UserName nvarchar(30) = NULL,
	@DisplayName nvarchar(30) = NULL,
	@Email nvarchar(30) = NULL,
	@BirthDate datetime = NULL,
	@Bio nvarchar(MAX) = NULL,
	@CountryID int = NULL,
	@UserRankID int = NULL,
	@Phone nvarchar(20) = NULL,
	@Website nvarchar(20) = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboUserLog]
	SET
		[ComboUserID] = @ComboUserID,
		[UserName] = @UserName,
		[DisplayName] = @DisplayName,
		[Email] = @Email,
		[BirthDate] = @BirthDate,
		[Bio] = @Bio,
		[CountryID] = @CountryID,
		[UserRankID] = @UserRankID,
		[Phone] = @Phone,
		[Website] = @Website,
		[LogDate] = @LogDate
	WHERE
		[ComboUserLogID] = @ComboUserLogID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserLogUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserLogUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboUserLogInsert]    Script Date: 22/07/2015 1:30:10 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserLogInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserLogInsert];
GO

CREATE PROCEDURE [proc_ComboUserLogInsert]
(
	@ComboUserLogID int = NULL output,
	@ComboUserID int = NULL,
	@UserName nvarchar(30) = NULL,
	@DisplayName nvarchar(30) = NULL,
	@Email nvarchar(30) = NULL,
	@BirthDate datetime = NULL,
	@Bio nvarchar(MAX) = NULL,
	@CountryID int = NULL,
	@UserRankID int = NULL,
	@Phone nvarchar(20) = NULL,
	@Website nvarchar(20) = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboUserLog]
	(
		[ComboUserID],
		[UserName],
		[DisplayName],
		[Email],
		[BirthDate],
		[Bio],
		[CountryID],
		[UserRankID],
		[Phone],
		[Website],
		[LogDate]
	)
	VALUES
	(
		@ComboUserID,
		@UserName,
		@DisplayName,
		@Email,
		@BirthDate,
		@Bio,
		@CountryID,
		@UserRankID,
		@Phone,
		@Website,
		@LogDate
	)

	SET @Err = @@Error

	SELECT @ComboUserLogID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserLogInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserLogInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserLogDelete]    Script Date: 22/07/2015 1:30:10 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserLogDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserLogDelete];
GO

CREATE PROCEDURE [proc_ComboUserLogDelete]
(
	@ComboUserLogID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboUserLog]
	WHERE
		[ComboUserLogID] = @ComboUserLogID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserLogDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserLogDelete Error on Creation'
GO
