
/****** Object:  StoredProcedure [proc_ComboUserLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboUserLoadByPrimaryKey]
(
	@ComboUserID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[UserName],
		[DisplayName],
		[Password],
		[Email],
		[ProfileImgID],
		[CoverImgID],
		[GenderID],
		[Bio],
		[IsActivated],
		[ActivationCode],
		[ExternalID],
		[ExternalIDType],
		[DeviceID],
		[PassResetCode],
		[IsDeactivated],
		[SecurityQuestion],
		[SecurityAnswer],
		[UserRankID],
		[SecurityWord],
		[BirthDate],
		[Country],
		[Phone],
		[Website],
		[CountryID],
		[Location],
		[IsPrivateAccount]
	FROM [ComboUser]
	WHERE
		([ComboUserID] = @ComboUserID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserLoadAll];
GO

CREATE PROCEDURE [proc_ComboUserLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[UserName],
		[DisplayName],
		[Password],
		[Email],
		[ProfileImgID],
		[CoverImgID],
		[GenderID],
		[Bio],
		[IsActivated],
		[ActivationCode],
		[ExternalID],
		[ExternalIDType],
		[DeviceID],
		[PassResetCode],
		[IsDeactivated],
		[SecurityQuestion],
		[SecurityAnswer],
		[UserRankID],
		[SecurityWord],
		[BirthDate],
		[Country],
		[Phone],
		[Website],
		[CountryID],
		[Location],
		[IsPrivateAccount]
	FROM [ComboUser]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserUpdate];
GO

CREATE PROCEDURE [proc_ComboUserUpdate]
(
	@ComboUserID int,
	@UserName nvarchar(200) = NULL,
	@DisplayName nvarchar(200) = NULL,
	@Password nvarchar(200) = NULL,
	@Email nvarchar(200) = NULL,
	@ProfileImgID int = NULL,
	@CoverImgID int = NULL,
	@GenderID int = NULL,
	@Bio nvarchar(MAX) = NULL,
	@IsActivated bit = NULL,
	@ActivationCode uniqueidentifier = NULL,
	@ExternalID nvarchar(200) = NULL,
	@ExternalIDType int = NULL,
	@DeviceID nvarchar(200) = NULL,
	@PassResetCode uniqueidentifier = NULL,
	@IsDeactivated bit = NULL,
	@SecurityQuestion nvarchar(200) = NULL,
	@SecurityAnswer nvarchar(200) = NULL,
	@UserRankID int = NULL,
	@SecurityWord nvarchar(50) = NULL,
	@BirthDate datetime = NULL,
	@Country nvarchar(100) = NULL,
	@Phone nvarchar(20) = NULL,
	@Website nvarchar(200) = NULL,
	@CountryID int = NULL,
	@Location nvarchar(100) = NULL,
	@IsPrivateAccount bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboUser]
	SET
		[UserName] = @UserName,
		[DisplayName] = @DisplayName,
		[Password] = @Password,
		[Email] = @Email,
		[ProfileImgID] = @ProfileImgID,
		[CoverImgID] = @CoverImgID,
		[GenderID] = @GenderID,
		[Bio] = @Bio,
		[IsActivated] = @IsActivated,
		[ActivationCode] = @ActivationCode,
		[ExternalID] = @ExternalID,
		[ExternalIDType] = @ExternalIDType,
		[DeviceID] = @DeviceID,
		[PassResetCode] = @PassResetCode,
		[IsDeactivated] = @IsDeactivated,
		[SecurityQuestion] = @SecurityQuestion,
		[SecurityAnswer] = @SecurityAnswer,
		[UserRankID] = @UserRankID,
		[SecurityWord] = @SecurityWord,
		[BirthDate] = @BirthDate,
		[Country] = @Country,
		[Phone] = @Phone,
		[Website] = @Website,
		[CountryID] = @CountryID,
		[Location] = @Location,
		[IsPrivateAccount] = @IsPrivateAccount
	WHERE
		[ComboUserID] = @ComboUserID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboUserInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserInsert];
GO

CREATE PROCEDURE [proc_ComboUserInsert]
(
	@ComboUserID int = NULL output,
	@UserName nvarchar(200) = NULL,
	@DisplayName nvarchar(200) = NULL,
	@Password nvarchar(200) = NULL,
	@Email nvarchar(200) = NULL,
	@ProfileImgID int = NULL,
	@CoverImgID int = NULL,
	@GenderID int = NULL,
	@Bio nvarchar(MAX) = NULL,
	@IsActivated bit = NULL,
	@ActivationCode uniqueidentifier = NULL,
	@ExternalID nvarchar(200) = NULL,
	@ExternalIDType int = NULL,
	@DeviceID nvarchar(200) = NULL,
	@PassResetCode uniqueidentifier = NULL,
	@IsDeactivated bit = NULL,
	@SecurityQuestion nvarchar(200) = NULL,
	@SecurityAnswer nvarchar(200) = NULL,
	@UserRankID int = NULL,
	@SecurityWord nvarchar(50) = NULL,
	@BirthDate datetime = NULL,
	@Country nvarchar(100) = NULL,
	@Phone nvarchar(20) = NULL,
	@Website nvarchar(200) = NULL,
	@CountryID int = NULL,
	@Location nvarchar(100) = NULL,
	@IsPrivateAccount bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboUser]
	(
		[UserName],
		[DisplayName],
		[Password],
		[Email],
		[ProfileImgID],
		[CoverImgID],
		[GenderID],
		[Bio],
		[IsActivated],
		[ActivationCode],
		[ExternalID],
		[ExternalIDType],
		[DeviceID],
		[PassResetCode],
		[IsDeactivated],
		[SecurityQuestion],
		[SecurityAnswer],
		[UserRankID],
		[SecurityWord],
		[BirthDate],
		[Country],
		[Phone],
		[Website],
		[CountryID],
		[Location],
		[IsPrivateAccount]
	)
	VALUES
	(
		@UserName,
		@DisplayName,
		@Password,
		@Email,
		@ProfileImgID,
		@CoverImgID,
		@GenderID,
		@Bio,
		@IsActivated,
		@ActivationCode,
		@ExternalID,
		@ExternalIDType,
		@DeviceID,
		@PassResetCode,
		@IsDeactivated,
		@SecurityQuestion,
		@SecurityAnswer,
		@UserRankID,
		@SecurityWord,
		@BirthDate,
		@Country,
		@Phone,
		@Website,
		@CountryID,
		@Location,
		@IsPrivateAccount
	)

	SET @Err = @@Error

	SELECT @ComboUserID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserDelete];
GO

CREATE PROCEDURE [proc_ComboUserDelete]
(
	@ComboUserID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboUser]
	WHERE
		[ComboUserID] = @ComboUserID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserDelete Error on Creation'
GO
