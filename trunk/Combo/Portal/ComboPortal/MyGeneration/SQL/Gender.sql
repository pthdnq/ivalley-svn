
/****** Object:  StoredProcedure [proc_GenderLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GenderLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GenderLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_GenderLoadByPrimaryKey]
(
	@GenderID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[GenderID],
		[Name]
	FROM [Gender]
	WHERE
		([GenderID] = @GenderID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GenderLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_GenderLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GenderLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GenderLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GenderLoadAll];
GO

CREATE PROCEDURE [proc_GenderLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[GenderID],
		[Name]
	FROM [Gender]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GenderLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_GenderLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GenderUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GenderUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GenderUpdate];
GO

CREATE PROCEDURE [proc_GenderUpdate]
(
	@GenderID int,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Gender]
	SET
		[Name] = @Name
	WHERE
		[GenderID] = @GenderID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GenderUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_GenderUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_GenderInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GenderInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GenderInsert];
GO

CREATE PROCEDURE [proc_GenderInsert]
(
	@GenderID int = NULL output,
	@Name nvarchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Gender]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)

	SET @Err = @@Error

	SELECT @GenderID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GenderInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_GenderInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_GenderDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_GenderDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_GenderDelete];
GO

CREATE PROCEDURE [proc_GenderDelete]
(
	@GenderID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Gender]
	WHERE
		[GenderID] = @GenderID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_GenderDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_GenderDelete Error on Creation'
GO
