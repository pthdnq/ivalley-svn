
USE [Intranetdb_final]
GO

/****** Object:  StoredProcedure [proc_ActionsLoadByPrimaryKey]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ActionsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ActionsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ActionsLoadByPrimaryKey]
(
	@ActionID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ActionID],
		[ActionName]
	FROM [Actions]
	WHERE
		([ActionID] = @ActionID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ActionsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ActionsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ActionsLoadAll]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ActionsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ActionsLoadAll];
GO

CREATE PROCEDURE [proc_ActionsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ActionID],
		[ActionName]
	FROM [Actions]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ActionsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ActionsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ActionsUpdate]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ActionsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ActionsUpdate];
GO

CREATE PROCEDURE [proc_ActionsUpdate]
(
	@ActionID int,
	@ActionName nvarchar(250) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Actions]
	SET
		[ActionName] = @ActionName
	WHERE
		[ActionID] = @ActionID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ActionsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ActionsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ActionsInsert]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ActionsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ActionsInsert];
GO

CREATE PROCEDURE [proc_ActionsInsert]
(
	@ActionID int = NULL output,
	@ActionName nvarchar(250) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Actions]
	(
		[ActionName]
	)
	VALUES
	(
		@ActionName
	)

	SET @Err = @@Error

	SELECT @ActionID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ActionsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ActionsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ActionsDelete]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ActionsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ActionsDelete];
GO

CREATE PROCEDURE [proc_ActionsDelete]
(
	@ActionID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Actions]
	WHERE
		[ActionID] = @ActionID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ActionsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ActionsDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnnouncementLogLoadByPrimaryKey]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementLogLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementLogLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AnnouncementLogLoadByPrimaryKey]
(
	@AnnouncementLogID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AnnouncementLogID],
		[AnnouncementID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [AnnouncementLog]
	WHERE
		([AnnouncementLogID] = @AnnouncementLogID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementLogLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementLogLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnnouncementLogLoadAll]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementLogLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementLogLoadAll];
GO

CREATE PROCEDURE [proc_AnnouncementLogLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AnnouncementLogID],
		[AnnouncementID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [AnnouncementLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnnouncementLogUpdate]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementLogUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementLogUpdate];
GO

CREATE PROCEDURE [proc_AnnouncementLogUpdate]
(
	@AnnouncementLogID int,
	@AnnouncementID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [AnnouncementLog]
	SET
		[AnnouncementID] = @AnnouncementID,
		[UserID] = @UserID,
		[ActionID] = @ActionID,
		[LogDate] = @LogDate
	WHERE
		[AnnouncementLogID] = @AnnouncementLogID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementLogUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementLogUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AnnouncementLogInsert]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementLogInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementLogInsert];
GO

CREATE PROCEDURE [proc_AnnouncementLogInsert]
(
	@AnnouncementLogID int = NULL output,
	@AnnouncementID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [AnnouncementLog]
	(
		[AnnouncementID],
		[UserID],
		[ActionID],
		[LogDate]
	)
	VALUES
	(
		@AnnouncementID,
		@UserID,
		@ActionID,
		@LogDate
	)

	SET @Err = @@Error

	SELECT @AnnouncementLogID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementLogInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementLogInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnnouncementLogDelete]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementLogDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementLogDelete];
GO

CREATE PROCEDURE [proc_AnnouncementLogDelete]
(
	@AnnouncementLogID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [AnnouncementLog]
	WHERE
		[AnnouncementLogID] = @AnnouncementLogID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementLogDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementLogDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateLogLoadByPrimaryKey]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateLogLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateLogLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CertificateLogLoadByPrimaryKey]
(
	@CertificateLogID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CertificateLogID],
		[CertificateID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [CertificateLog]
	WHERE
		([CertificateLogID] = @CertificateLogID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateLogLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateLogLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateLogLoadAll]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateLogLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateLogLoadAll];
GO

CREATE PROCEDURE [proc_CertificateLogLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CertificateLogID],
		[CertificateID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [CertificateLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateLogUpdate]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateLogUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateLogUpdate];
GO

CREATE PROCEDURE [proc_CertificateLogUpdate]
(
	@CertificateLogID int,
	@CertificateID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CertificateLog]
	SET
		[CertificateID] = @CertificateID,
		[UserID] = @UserID,
		[ActionID] = @ActionID,
		[LogDate] = @LogDate
	WHERE
		[CertificateLogID] = @CertificateLogID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateLogUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateLogUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CertificateLogInsert]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateLogInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateLogInsert];
GO

CREATE PROCEDURE [proc_CertificateLogInsert]
(
	@CertificateLogID int = NULL output,
	@CertificateID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [CertificateLog]
	(
		[CertificateID],
		[UserID],
		[ActionID],
		[LogDate]
	)
	VALUES
	(
		@CertificateID,
		@UserID,
		@ActionID,
		@LogDate
	)

	SET @Err = @@Error

	SELECT @CertificateLogID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateLogInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateLogInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateLogDelete]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateLogDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateLogDelete];
GO

CREATE PROCEDURE [proc_CertificateLogDelete]
(
	@CertificateLogID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [CertificateLog]
	WHERE
		[CertificateLogID] = @CertificateLogID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateLogDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateLogDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_LoginLogLoadByPrimaryKey]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_LoginLogLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_LoginLogLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_LoginLogLoadByPrimaryKey]
(
	@LoginLogID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoginLogID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [LoginLog]
	WHERE
		([LoginLogID] = @LoginLogID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LoginLogLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LoginLogLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_LoginLogLoadAll]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_LoginLogLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_LoginLogLoadAll];
GO

CREATE PROCEDURE [proc_LoginLogLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoginLogID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [LoginLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LoginLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LoginLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_LoginLogUpdate]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_LoginLogUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_LoginLogUpdate];
GO

CREATE PROCEDURE [proc_LoginLogUpdate]
(
	@LoginLogID int,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LoginLog]
	SET
		[UserID] = @UserID,
		[ActionID] = @ActionID,
		[LogDate] = @LogDate
	WHERE
		[LoginLogID] = @LoginLogID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LoginLogUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LoginLogUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_LoginLogInsert]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_LoginLogInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_LoginLogInsert];
GO

CREATE PROCEDURE [proc_LoginLogInsert]
(
	@LoginLogID int = NULL output,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [LoginLog]
	(
		[UserID],
		[ActionID],
		[LogDate]
	)
	VALUES
	(
		@UserID,
		@ActionID,
		@LogDate
	)

	SET @Err = @@Error

	SELECT @LoginLogID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LoginLogInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LoginLogInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_LoginLogDelete]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_LoginLogDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_LoginLogDelete];
GO

CREATE PROCEDURE [proc_LoginLogDelete]
(
	@LoginLogID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [LoginLog]
	WHERE
		[LoginLogID] = @LoginLogID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LoginLogDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LoginLogDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualLogLoadByPrimaryKey]    Script Date: 29/06/2015 3:25:30 PM ******/
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
		[LogDate]
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

/****** Object:  StoredProcedure [proc_ManualLogLoadAll]    Script Date: 29/06/2015 3:25:30 PM ******/
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
		[LogDate]
	FROM [ManualLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualLogUpdate]    Script Date: 29/06/2015 3:25:30 PM ******/
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
	@LogDate datetime = NULL
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
		[LogDate] = @LogDate
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




/****** Object:  StoredProcedure [proc_ManualLogInsert]    Script Date: 29/06/2015 3:25:30 PM ******/
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
	@LogDate datetime = NULL
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
		[LogDate]
	)
	VALUES
	(
		@ManualID,
		@ManualVersionID,
		@ManualFormID,
		@FromVersionID,
		@UserID,
		@ActionID,
		@LogDate
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

/****** Object:  StoredProcedure [proc_ManualLogDelete]    Script Date: 29/06/2015 3:25:30 PM ******/
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

/****** Object:  StoredProcedure [proc_ScheduleLogLoadByPrimaryKey]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleLogLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleLogLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ScheduleLogLoadByPrimaryKey]
(
	@ScheduleLogID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ScheduleLogID],
		[ScheduleID],
		[ScheduleVersionID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [ScheduleLog]
	WHERE
		([ScheduleLogID] = @ScheduleLogID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleLogLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleLogLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleLogLoadAll]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleLogLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleLogLoadAll];
GO

CREATE PROCEDURE [proc_ScheduleLogLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ScheduleLogID],
		[ScheduleID],
		[ScheduleVersionID],
		[UserID],
		[ActionID],
		[LogDate]
	FROM [ScheduleLog]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleLogLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleLogLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleLogUpdate]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleLogUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleLogUpdate];
GO

CREATE PROCEDURE [proc_ScheduleLogUpdate]
(
	@ScheduleLogID int,
	@ScheduleID int = NULL,
	@ScheduleVersionID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ScheduleLog]
	SET
		[ScheduleID] = @ScheduleID,
		[ScheduleVersionID] = @ScheduleVersionID,
		[UserID] = @UserID,
		[ActionID] = @ActionID,
		[LogDate] = @LogDate
	WHERE
		[ScheduleLogID] = @ScheduleLogID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleLogUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleLogUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ScheduleLogInsert]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleLogInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleLogInsert];
GO

CREATE PROCEDURE [proc_ScheduleLogInsert]
(
	@ScheduleLogID int = NULL output,
	@ScheduleID int = NULL,
	@ScheduleVersionID int = NULL,
	@UserID uniqueidentifier = NULL,
	@ActionID int = NULL,
	@LogDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ScheduleLog]
	(
		[ScheduleID],
		[ScheduleVersionID],
		[UserID],
		[ActionID],
		[LogDate]
	)
	VALUES
	(
		@ScheduleID,
		@ScheduleVersionID,
		@UserID,
		@ActionID,
		@LogDate
	)

	SET @Err = @@Error

	SELECT @ScheduleLogID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleLogInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleLogInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleLogDelete]    Script Date: 29/06/2015 3:25:30 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleLogDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleLogDelete];
GO

CREATE PROCEDURE [proc_ScheduleLogDelete]
(
	@ScheduleLogID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ScheduleLog]
	WHERE
		[ScheduleLogID] = @ScheduleLogID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleLogDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleLogDelete Error on Creation'
GO
