
/****** Object:  StoredProcedure [proc_ComboCommentReportLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentReportLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentReportLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboCommentReportLoadByPrimaryKey]
(
	@ComboCommentReportID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboCommentReportID],
		[ComboUserID],
		[ComboCommentID],
		[ReportText],
		[ReportDate]
	FROM [ComboCommentReport]
	WHERE
		([ComboCommentReportID] = @ComboCommentReportID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentReportLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentReportLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentReportLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentReportLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentReportLoadAll];
GO

CREATE PROCEDURE [proc_ComboCommentReportLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboCommentReportID],
		[ComboUserID],
		[ComboCommentID],
		[ReportText],
		[ReportDate]
	FROM [ComboCommentReport]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentReportLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentReportLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentReportUpdate]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentReportUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentReportUpdate];
GO

CREATE PROCEDURE [proc_ComboCommentReportUpdate]
(
	@ComboCommentReportID int,
	@ComboUserID int = NULL,
	@ComboCommentID int = NULL,
	@ReportText nvarchar(200) = NULL,
	@ReportDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ComboCommentReport]
	SET
		[ComboUserID] = @ComboUserID,
		[ComboCommentID] = @ComboCommentID,
		[ReportText] = @ReportText,
		[ReportDate] = @ReportDate
	WHERE
		[ComboCommentReportID] = @ComboCommentReportID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentReportUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentReportUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ComboCommentReportInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentReportInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentReportInsert];
GO

CREATE PROCEDURE [proc_ComboCommentReportInsert]
(
	@ComboCommentReportID int = NULL output,
	@ComboUserID int = NULL,
	@ComboCommentID int = NULL,
	@ReportText nvarchar(200) = NULL,
	@ReportDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboCommentReport]
	(
		[ComboUserID],
		[ComboCommentID],
		[ReportText],
		[ReportDate]
	)
	VALUES
	(
		@ComboUserID,
		@ComboCommentID,
		@ReportText,
		@ReportDate
	)

	SET @Err = @@Error

	SELECT @ComboCommentReportID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentReportInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentReportInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentReportDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentReportDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentReportDelete];
GO

CREATE PROCEDURE [proc_ComboCommentReportDelete]
(
	@ComboCommentReportID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboCommentReport]
	WHERE
		[ComboCommentReportID] = @ComboCommentReportID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentReportDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentReportDelete Error on Creation'
GO
