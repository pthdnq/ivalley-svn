
USE [Combo_db]
GO

/****** Object:  StoredProcedure [proc_AdminLoginLoadByPrimaryKey]    Script Date: 18/07/2015 7:15:15 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AdminLoginLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AdminLoginLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AdminLoginLoadByPrimaryKey]
(
	@AdminLoginID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AdminLoginID],
		[AdminUserName],
		[AdminPassword],
		[AdminName]
	FROM [AdminLogin]
	WHERE
		([AdminLoginID] = @AdminLoginID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AdminLoginLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AdminLoginLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AdminLoginLoadAll]    Script Date: 18/07/2015 7:15:15 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AdminLoginLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AdminLoginLoadAll];
GO

CREATE PROCEDURE [proc_AdminLoginLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AdminLoginID],
		[AdminUserName],
		[AdminPassword],
		[AdminName]
	FROM [AdminLogin]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AdminLoginLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AdminLoginLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AdminLoginUpdate]    Script Date: 18/07/2015 7:15:15 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AdminLoginUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AdminLoginUpdate];
GO

CREATE PROCEDURE [proc_AdminLoginUpdate]
(
	@AdminLoginID int,
	@AdminUserName nvarchar(30) = NULL,
	@AdminPassword nvarchar(50) = NULL,
	@AdminName nvarchar(30) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [AdminLogin]
	SET
		[AdminUserName] = @AdminUserName,
		[AdminPassword] = @AdminPassword,
		[AdminName] = @AdminName
	WHERE
		[AdminLoginID] = @AdminLoginID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AdminLoginUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AdminLoginUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AdminLoginInsert]    Script Date: 18/07/2015 7:15:15 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AdminLoginInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AdminLoginInsert];
GO

CREATE PROCEDURE [proc_AdminLoginInsert]
(
	@AdminLoginID int = NULL output,
	@AdminUserName nvarchar(30) = NULL,
	@AdminPassword nvarchar(50) = NULL,
	@AdminName nvarchar(30) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [AdminLogin]
	(
		[AdminUserName],
		[AdminPassword],
		[AdminName]
	)
	VALUES
	(
		@AdminUserName,
		@AdminPassword,
		@AdminName
	)

	SET @Err = @@Error

	SELECT @AdminLoginID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AdminLoginInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AdminLoginInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AdminLoginDelete]    Script Date: 18/07/2015 7:15:15 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AdminLoginDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AdminLoginDelete];
GO

CREATE PROCEDURE [proc_AdminLoginDelete]
(
	@AdminLoginID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [AdminLogin]
	WHERE
		[AdminLoginID] = @AdminLoginID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AdminLoginDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AdminLoginDelete Error on Creation'
GO
