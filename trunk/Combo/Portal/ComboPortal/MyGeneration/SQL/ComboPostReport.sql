
/****** Object:  StoredProcedure [proc_ComboPostReportLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostReportLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostReportLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboPostReportLoadByPrimaryKey]
(
	@ComboPostReportID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostReportID],
		[ComboUserID],
		[ComboPostID],
		[ReportText],
		[ReportDate]
	FROM [ComboPostReport]
	WHERE
		([ComboPostReportID] = @ComboPostReportID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostReportLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostReportLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostReportLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostReportLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostReportLoadAll];
GO

CREATE PROCEDURE [proc_ComboPostReportLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboPostReportID],
		[ComboUserID],
		[ComboPostID],
		[ReportText],
		[ReportDate]
	FROM [ComboPostReport]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostReportLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostReportLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostReportUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostReportUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostReportUpdate];
GO

CREATE PROCEDURE [proc_ComboPostReportUpdate]
(
	@ComboPostReportID int,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@ReportText nvarchar(MAX) = NULL,
	@ReportDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboPostReport]
	SET
		[ComboUserID] = @ComboUserID,
		[ComboPostID] = @ComboPostID,
		[ReportText] = @ReportText,
		[ReportDate] = @ReportDate
	WHERE
		[ComboPostReportID] = @ComboPostReportID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostReportUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostReportUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboPostReportInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostReportInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostReportInsert];
GO

CREATE PROCEDURE [proc_ComboPostReportInsert]
(
	@ComboPostReportID int = NULL output,
	@ComboUserID int = NULL,
	@ComboPostID int = NULL,
	@ReportText nvarchar(MAX) = NULL,
	@ReportDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboPostReport]
	(
		[ComboUserID],
		[ComboPostID],
		[ReportText],
		[ReportDate]
	)
	VALUES
	(
		@ComboUserID,
		@ComboPostID,
		@ReportText,
		@ReportDate
	)

	SET @Err = @@Error

	SELECT @ComboPostReportID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostReportInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostReportInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostReportDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostReportDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostReportDelete];
GO

CREATE PROCEDURE [proc_ComboPostReportDelete]
(
	@ComboPostReportID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboPostReport]
	WHERE
		[ComboPostReportID] = @ComboPostReportID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostReportDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostReportDelete Error on Creation'
GO
