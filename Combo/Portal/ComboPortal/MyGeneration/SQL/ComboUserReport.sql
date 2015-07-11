
/****** Object:  StoredProcedure [proc_ComboUserReportLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserReportLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserReportLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboUserReportLoadByPrimaryKey]
(
	@ComboUserReportID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserReportID],
		[ComboUserID],
		[ComboReportedUserID],
		[ReportText],
		[ReportDate]
	FROM [ComboUserReport]
	WHERE
		([ComboUserReportID] = @ComboUserReportID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserReportLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserReportLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserReportLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserReportLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserReportLoadAll];
GO

CREATE PROCEDURE [proc_ComboUserReportLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserReportID],
		[ComboUserID],
		[ComboReportedUserID],
		[ReportText],
		[ReportDate]
	FROM [ComboUserReport]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserReportLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserReportLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserReportUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserReportUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserReportUpdate];
GO

CREATE PROCEDURE [proc_ComboUserReportUpdate]
(
	@ComboUserReportID int,
	@ComboUserID int = NULL,
	@ComboReportedUserID int = NULL,
	@ReportText nvarchar(200) = NULL,
	@ReportDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboUserReport]
	SET
		[ComboUserID] = @ComboUserID,
		[ComboReportedUserID] = @ComboReportedUserID,
		[ReportText] = @ReportText,
		[ReportDate] = @ReportDate
	WHERE
		[ComboUserReportID] = @ComboUserReportID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserReportUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserReportUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboUserReportInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserReportInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserReportInsert];
GO

CREATE PROCEDURE [proc_ComboUserReportInsert]
(
	@ComboUserReportID int = NULL output,
	@ComboUserID int = NULL,
	@ComboReportedUserID int = NULL,
	@ReportText nvarchar(200) = NULL,
	@ReportDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboUserReport]
	(
		[ComboUserID],
		[ComboReportedUserID],
		[ReportText],
		[ReportDate]
	)
	VALUES
	(
		@ComboUserID,
		@ComboReportedUserID,
		@ReportText,
		@ReportDate
	)

	SET @Err = @@Error

	SELECT @ComboUserReportID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserReportInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserReportInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserReportDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserReportDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserReportDelete];
GO

CREATE PROCEDURE [proc_ComboUserReportDelete]
(
	@ComboUserReportID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboUserReport]
	WHERE
		[ComboUserReportID] = @ComboUserReportID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserReportDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserReportDelete Error on Creation'
GO
