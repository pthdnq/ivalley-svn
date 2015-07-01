
USE [Intranetdb_final]
GO

/****** Object:  StoredProcedure [proc_ManualLogLoadByPrimaryKey]    Script Date: 7/1/2015 1:32:28 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualLogLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualLogLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ManualLogLoadByPrimaryKey]
(
	@ManualLogID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualLogID],
		[ManualID],
		[ManualVersionID],
		[ManualFormID],
		[FromVersionID],
		[UserID],
		[ActionID],
		[LogDate],
		[ManualCategoryID]
	FROM [ManualLog]
	WHERE
		([ManualLogID] = @ManualLogID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLogLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLogLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualLogLoadAll]    Script Date: 7/1/2015 1:32:28 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualLogLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualLogLoadAll];
GO

CREATE PROCEDURE [proc_ManualLogLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualLogID],
		[ManualID],
		[ManualVersionID],
		[ManualFormID],
		[FromVersionID],
		[UserID],
		[ActionID],
		[LogDate],
		[ManualCategoryID]
	FROM [ManualLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualLogUpdate]    Script Date: 7/1/2015 1:32:28 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualLogUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualLogUpdate];
GO

CREATE PROCEDURE [proc_ManualLogUpdate]
(
	@ManualLogID int,
	@ManualID int = NULL,
	@ManualVersionID int = NULL,
	@ManualFormID int = NULL,
	@FromVersionID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL,
	@ManualCategoryID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ManualLog]
	SET
		[ManualID] = @ManualID,
		[ManualVersionID] = @ManualVersionID,
		[ManualFormID] = @ManualFormID,
		[FromVersionID] = @FromVersionID,
		[UserID] = @UserID,
		[ActionID] = @ActionID,
		[LogDate] = @LogDate,
		[ManualCategoryID] = @ManualCategoryID
	WHERE
		[ManualLogID] = @ManualLogID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLogUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLogUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ManualLogInsert]    Script Date: 7/1/2015 1:32:28 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualLogInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualLogInsert];
GO

CREATE PROCEDURE [proc_ManualLogInsert]
(
	@ManualLogID int = NULL output,
	@ManualID int = NULL,
	@ManualVersionID int = NULL,
	@ManualFormID int = NULL,
	@FromVersionID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL,
	@ManualCategoryID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ManualLog]
	(
		[ManualID],
		[ManualVersionID],
		[ManualFormID],
		[FromVersionID],
		[UserID],
		[ActionID],
		[LogDate],
		[ManualCategoryID]
	)
	VALUES
	(
		@ManualID,
		@ManualVersionID,
		@ManualFormID,
		@FromVersionID,
		@UserID,
		@ActionID,
		@LogDate,
		@ManualCategoryID
	)

	SET @Err = @@Error

	SELECT @ManualLogID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLogInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLogInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualLogDelete]    Script Date: 7/1/2015 1:32:28 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualLogDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualLogDelete];
GO

CREATE PROCEDURE [proc_ManualLogDelete]
(
	@ManualLogID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ManualLog]
	WHERE
		[ManualLogID] = @ManualLogID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLogDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLogDelete Error on Creation'
GO
