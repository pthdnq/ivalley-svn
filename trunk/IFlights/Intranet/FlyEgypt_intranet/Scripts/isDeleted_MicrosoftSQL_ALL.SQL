
USE [Intranetdb_final]
GO

/****** Object:  StoredProcedure [proc_AnnouncementLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_AnnouncementLoadByPrimaryKey]
(
	@AnnouncementID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AnnouncementID],
		[Title],
		[Content],
		[CreatedBy],
		[createdDate],
		[MainPic],
		[Brief],
		[IsBulletin],
		[IsBlog],
		[UploadedFile],
		[GroupID],
		[isDeleted]
	FROM [Announcement]
	WHERE
		([AnnouncementID] = @AnnouncementID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnnouncementLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementLoadAll];
GO

CREATE PROCEDURE [proc_AnnouncementLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[AnnouncementID],
		[Title],
		[Content],
		[CreatedBy],
		[createdDate],
		[MainPic],
		[Brief],
		[IsBulletin],
		[IsBlog],
		[UploadedFile],
		[GroupID],
		[isDeleted]
	FROM [Announcement]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnnouncementUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementUpdate];
GO

CREATE PROCEDURE [proc_AnnouncementUpdate]
(
	@AnnouncementID int,
	@Title nvarchar(500) = NULL,
	@Content nvarchar(MAX) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@createdDate datetime = NULL,
	@MainPic nvarchar(500) = NULL,
	@Brief nvarchar(1000) = NULL,
	@IsBulletin bit = NULL,
	@IsBlog bit = NULL,
	@UploadedFile nvarchar(500) = NULL,
	@GroupID int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Announcement]
	SET
		[Title] = @Title,
		[Content] = @Content,
		[CreatedBy] = @CreatedBy,
		[createdDate] = @createdDate,
		[MainPic] = @MainPic,
		[Brief] = @Brief,
		[IsBulletin] = @IsBulletin,
		[IsBlog] = @IsBlog,
		[UploadedFile] = @UploadedFile,
		[GroupID] = @GroupID,
		[isDeleted] = @isDeleted
	WHERE
		[AnnouncementID] = @AnnouncementID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_AnnouncementInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementInsert];
GO

CREATE PROCEDURE [proc_AnnouncementInsert]
(
	@AnnouncementID int = NULL output,
	@Title nvarchar(500) = NULL,
	@Content nvarchar(MAX) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@createdDate datetime = NULL,
	@MainPic nvarchar(500) = NULL,
	@Brief nvarchar(1000) = NULL,
	@IsBulletin bit = NULL,
	@IsBlog bit = NULL,
	@UploadedFile nvarchar(500) = NULL,
	@GroupID int = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Announcement]
	(
		[Title],
		[Content],
		[CreatedBy],
		[createdDate],
		[MainPic],
		[Brief],
		[IsBulletin],
		[IsBlog],
		[UploadedFile],
		[GroupID],
		[isDeleted]
	)
	VALUES
	(
		@Title,
		@Content,
		@CreatedBy,
		@createdDate,
		@MainPic,
		@Brief,
		@IsBulletin,
		@IsBlog,
		@UploadedFile,
		@GroupID,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @AnnouncementID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_AnnouncementDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_AnnouncementDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_AnnouncementDelete];
GO

CREATE PROCEDURE [proc_AnnouncementDelete]
(
	@AnnouncementID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Announcement]
	WHERE
		[AnnouncementID] = @AnnouncementID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_AnnouncementDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_AnnouncementDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_CertificateLoadByPrimaryKey]
(
	@CertificateID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CertificateID],
		[Name],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Certificate]
	WHERE
		([CertificateID] = @CertificateID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateLoadAll];
GO

CREATE PROCEDURE [proc_CertificateLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CertificateID],
		[Name],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Certificate]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateUpdate];
GO

CREATE PROCEDURE [proc_CertificateUpdate]
(
	@CertificateID int,
	@Name nvarchar(300) = NULL,
	@Path nvarchar(500) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Certificate]
	SET
		[Name] = @Name,
		[Path] = @Path,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[isDeleted] = @isDeleted
	WHERE
		[CertificateID] = @CertificateID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_CertificateInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateInsert];
GO

CREATE PROCEDURE [proc_CertificateInsert]
(
	@CertificateID int = NULL output,
	@Name nvarchar(300) = NULL,
	@Path nvarchar(500) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Certificate]
	(
		[Name],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	)
	VALUES
	(
		@Name,
		@Path,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @CertificateID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_CertificateDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_CertificateDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_CertificateDelete];
GO

CREATE PROCEDURE [proc_CertificateDelete]
(
	@CertificateID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Certificate]
	WHERE
		[CertificateID] = @CertificateID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CertificateDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CertificateDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_FromVersionLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_FromVersionLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_FromVersionLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_FromVersionLoadByPrimaryKey]
(
	@FromVersionID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[FromVersionID],
		[ManualFromID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	FROM [FromVersion]
	WHERE
		([FromVersionID] = @FromVersionID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_FromVersionLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_FromVersionLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_FromVersionLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_FromVersionLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_FromVersionLoadAll];
GO

CREATE PROCEDURE [proc_FromVersionLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[FromVersionID],
		[ManualFromID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	FROM [FromVersion]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_FromVersionLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_FromVersionLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_FromVersionUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_FromVersionUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_FromVersionUpdate];
GO

CREATE PROCEDURE [proc_FromVersionUpdate]
(
	@FromVersionID int,
	@ManualFromID int = NULL,
	@Title nvarchar(300) = NULL,
	@Path nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@Notes nvarchar(MAX) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [FromVersion]
	SET
		[ManualFromID] = @ManualFromID,
		[Title] = @Title,
		[Path] = @Path,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[IssueNumber] = @IssueNumber,
		[IssueDate] = @IssueDate,
		[RevisionNumber] = @RevisionNumber,
		[RevisionDate] = @RevisionDate,
		[Notes] = @Notes,
		[isDeleted] = @isDeleted
	WHERE
		[FromVersionID] = @FromVersionID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_FromVersionUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_FromVersionUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_FromVersionInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_FromVersionInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_FromVersionInsert];
GO

CREATE PROCEDURE [proc_FromVersionInsert]
(
	@FromVersionID int = NULL output,
	@ManualFromID int = NULL,
	@Title nvarchar(300) = NULL,
	@Path nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@Notes nvarchar(MAX) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [FromVersion]
	(
		[ManualFromID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	)
	VALUES
	(
		@ManualFromID,
		@Title,
		@Path,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@IssueNumber,
		@IssueDate,
		@RevisionNumber,
		@RevisionDate,
		@Notes,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @FromVersionID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_FromVersionInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_FromVersionInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_FromVersionDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_FromVersionDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_FromVersionDelete];
GO

CREATE PROCEDURE [proc_FromVersionDelete]
(
	@FromVersionID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [FromVersion]
	WHERE
		[FromVersionID] = @FromVersionID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_FromVersionDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_FromVersionDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ManualLoadByPrimaryKey]
(
	@ManualID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualID],
		[Title],
		[Path],
		[CreatedBy],
		[createdDate],
		[ManualCategoryID],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[IsForm],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Manual]
	WHERE
		([ManualID] = @ManualID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualLoadAll];
GO

CREATE PROCEDURE [proc_ManualLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualID],
		[Title],
		[Path],
		[CreatedBy],
		[createdDate],
		[ManualCategoryID],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[IsForm],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Manual]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualUpdate];
GO

CREATE PROCEDURE [proc_ManualUpdate]
(
	@ManualID int,
	@Title nvarchar(500) = NULL,
	@Path nvarchar(1000) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@createdDate datetime = NULL,
	@ManualCategoryID int = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@IsForm bit = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Manual]
	SET
		[Title] = @Title,
		[Path] = @Path,
		[CreatedBy] = @CreatedBy,
		[createdDate] = @createdDate,
		[ManualCategoryID] = @ManualCategoryID,
		[IssueNumber] = @IssueNumber,
		[IssueDate] = @IssueDate,
		[RevisionNumber] = @RevisionNumber,
		[RevisionDate] = @RevisionDate,
		[IsForm] = @IsForm,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[isDeleted] = @isDeleted
	WHERE
		[ManualID] = @ManualID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ManualInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualInsert];
GO

CREATE PROCEDURE [proc_ManualInsert]
(
	@ManualID int = NULL output,
	@Title nvarchar(500) = NULL,
	@Path nvarchar(1000) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@createdDate datetime = NULL,
	@ManualCategoryID int = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@IsForm bit = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Manual]
	(
		[Title],
		[Path],
		[CreatedBy],
		[createdDate],
		[ManualCategoryID],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[IsForm],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	)
	VALUES
	(
		@Title,
		@Path,
		@CreatedBy,
		@createdDate,
		@ManualCategoryID,
		@IssueNumber,
		@IssueDate,
		@RevisionNumber,
		@RevisionDate,
		@IsForm,
		@UpdatedBy,
		@LastUpdatedDate,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @ManualID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualDelete];
GO

CREATE PROCEDURE [proc_ManualDelete]
(
	@ManualID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Manual]
	WHERE
		[ManualID] = @ManualID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualFormLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualFormLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualFormLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ManualFormLoadByPrimaryKey]
(
	@ManualFormID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualFormID],
		[ManualID],
		[Name],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [ManualForm]
	WHERE
		([ManualFormID] = @ManualFormID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualFormLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualFormLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualFormLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualFormLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualFormLoadAll];
GO

CREATE PROCEDURE [proc_ManualFormLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualFormID],
		[ManualID],
		[Name],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [ManualForm]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualFormLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualFormLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualFormUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualFormUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualFormUpdate];
GO

CREATE PROCEDURE [proc_ManualFormUpdate]
(
	@ManualFormID int,
	@ManualID int = NULL,
	@Name nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ManualForm]
	SET
		[ManualID] = @ManualID,
		[Name] = @Name,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[isDeleted] = @isDeleted
	WHERE
		[ManualFormID] = @ManualFormID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualFormUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualFormUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ManualFormInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualFormInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualFormInsert];
GO

CREATE PROCEDURE [proc_ManualFormInsert]
(
	@ManualFormID int = NULL output,
	@ManualID int = NULL,
	@Name nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ManualForm]
	(
		[ManualID],
		[Name],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	)
	VALUES
	(
		@ManualID,
		@Name,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @ManualFormID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualFormInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualFormInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualFormDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualFormDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualFormDelete];
GO

CREATE PROCEDURE [proc_ManualFormDelete]
(
	@ManualFormID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ManualForm]
	WHERE
		[ManualFormID] = @ManualFormID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualFormDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualFormDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualVersionLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualVersionLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualVersionLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ManualVersionLoadByPrimaryKey]
(
	@ManualVersionID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualVersionID],
		[ManualID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	FROM [ManualVersion]
	WHERE
		([ManualVersionID] = @ManualVersionID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualVersionLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualVersionLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualVersionLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualVersionLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualVersionLoadAll];
GO

CREATE PROCEDURE [proc_ManualVersionLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ManualVersionID],
		[ManualID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	FROM [ManualVersion]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualVersionLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualVersionLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualVersionUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualVersionUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualVersionUpdate];
GO

CREATE PROCEDURE [proc_ManualVersionUpdate]
(
	@ManualVersionID int,
	@ManualID int = NULL,
	@Title nvarchar(300) = NULL,
	@Path nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@Notes nvarchar(MAX) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ManualVersion]
	SET
		[ManualID] = @ManualID,
		[Title] = @Title,
		[Path] = @Path,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[IssueNumber] = @IssueNumber,
		[IssueDate] = @IssueDate,
		[RevisionNumber] = @RevisionNumber,
		[RevisionDate] = @RevisionDate,
		[Notes] = @Notes,
		[isDeleted] = @isDeleted
	WHERE
		[ManualVersionID] = @ManualVersionID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualVersionUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualVersionUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ManualVersionInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualVersionInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualVersionInsert];
GO

CREATE PROCEDURE [proc_ManualVersionInsert]
(
	@ManualVersionID int = NULL output,
	@ManualID int = NULL,
	@Title nvarchar(300) = NULL,
	@Path nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@Notes nvarchar(MAX) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ManualVersion]
	(
		[ManualID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	)
	VALUES
	(
		@ManualID,
		@Title,
		@Path,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@IssueNumber,
		@IssueDate,
		@RevisionNumber,
		@RevisionDate,
		@Notes,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @ManualVersionID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualVersionInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualVersionInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ManualVersionDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ManualVersionDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ManualVersionDelete];
GO

CREATE PROCEDURE [proc_ManualVersionDelete]
(
	@ManualVersionID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ManualVersion]
	WHERE
		[ManualVersionID] = @ManualVersionID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ManualVersionDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ManualVersionDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ScheduleLoadByPrimaryKey]
(
	@ScheduleID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ScheduleID],
		[Name],
		[StartDate],
		[EndDate],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Schedule]
	WHERE
		([ScheduleID] = @ScheduleID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleLoadAll];
GO

CREATE PROCEDURE [proc_ScheduleLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ScheduleID],
		[Name],
		[StartDate],
		[EndDate],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	FROM [Schedule]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleUpdate];
GO

CREATE PROCEDURE [proc_ScheduleUpdate]
(
	@ScheduleID int,
	@Name nvarchar(300) = NULL,
	@StartDate datetime = NULL,
	@EndDate datetime = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Schedule]
	SET
		[Name] = @Name,
		[StartDate] = @StartDate,
		[EndDate] = @EndDate,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[isDeleted] = @isDeleted
	WHERE
		[ScheduleID] = @ScheduleID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ScheduleInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleInsert];
GO

CREATE PROCEDURE [proc_ScheduleInsert]
(
	@ScheduleID int = NULL output,
	@Name nvarchar(300) = NULL,
	@StartDate datetime = NULL,
	@EndDate datetime = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Schedule]
	(
		[Name],
		[StartDate],
		[EndDate],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[isDeleted]
	)
	VALUES
	(
		@Name,
		@StartDate,
		@EndDate,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @ScheduleID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleDelete];
GO

CREATE PROCEDURE [proc_ScheduleDelete]
(
	@ScheduleID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [Schedule]
	WHERE
		[ScheduleID] = @ScheduleID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleVersionLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleVersionLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleVersionLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ScheduleVersionLoadByPrimaryKey]
(
	@ScheduleVersionID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ScheduleVersionID],
		[ScheduleID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	FROM [ScheduleVersion]
	WHERE
		([ScheduleVersionID] = @ScheduleVersionID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleVersionLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleVersionLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleVersionLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleVersionLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleVersionLoadAll];
GO

CREATE PROCEDURE [proc_ScheduleVersionLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ScheduleVersionID],
		[ScheduleID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	FROM [ScheduleVersion]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleVersionLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleVersionLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleVersionUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleVersionUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleVersionUpdate];
GO

CREATE PROCEDURE [proc_ScheduleVersionUpdate]
(
	@ScheduleVersionID int,
	@ScheduleID int = NULL,
	@Title nvarchar(300) = NULL,
	@Path nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@Notes nvarchar(MAX) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [ScheduleVersion]
	SET
		[ScheduleID] = @ScheduleID,
		[Title] = @Title,
		[Path] = @Path,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[IssueNumber] = @IssueNumber,
		[IssueDate] = @IssueDate,
		[RevisionNumber] = @RevisionNumber,
		[RevisionDate] = @RevisionDate,
		[Notes] = @Notes,
		[isDeleted] = @isDeleted
	WHERE
		[ScheduleVersionID] = @ScheduleVersionID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleVersionUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleVersionUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_ScheduleVersionInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleVersionInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleVersionInsert];
GO

CREATE PROCEDURE [proc_ScheduleVersionInsert]
(
	@ScheduleVersionID int = NULL output,
	@ScheduleID int = NULL,
	@Title nvarchar(300) = NULL,
	@Path nvarchar(300) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@IssueNumber nvarchar(10) = NULL,
	@IssueDate datetime = NULL,
	@RevisionNumber nvarchar(10) = NULL,
	@RevisionDate datetime = NULL,
	@Notes nvarchar(MAX) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ScheduleVersion]
	(
		[ScheduleID],
		[Title],
		[Path],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[IssueNumber],
		[IssueDate],
		[RevisionNumber],
		[RevisionDate],
		[Notes],
		[isDeleted]
	)
	VALUES
	(
		@ScheduleID,
		@Title,
		@Path,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@IssueNumber,
		@IssueDate,
		@RevisionNumber,
		@RevisionDate,
		@Notes,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @ScheduleVersionID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleVersionInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleVersionInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ScheduleVersionDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ScheduleVersionDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ScheduleVersionDelete];
GO

CREATE PROCEDURE [proc_ScheduleVersionDelete]
(
	@ScheduleVersionID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ScheduleVersion]
	WHERE
		[ScheduleVersionID] = @ScheduleVersionID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ScheduleVersionDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ScheduleVersionDelete Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UsefulLinkLoadByPrimaryKey]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UsefulLinkLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UsefulLinkLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_UsefulLinkLoadByPrimaryKey]
(
	@UsefulLinkID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[UsefulLinkID],
		[Title],
		[Description],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[URL],
		[isDeleted]
	FROM [UsefulLink]
	WHERE
		([UsefulLinkID] = @UsefulLinkID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UsefulLinkLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_UsefulLinkLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UsefulLinkLoadAll]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UsefulLinkLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UsefulLinkLoadAll];
GO

CREATE PROCEDURE [proc_UsefulLinkLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[UsefulLinkID],
		[Title],
		[Description],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[URL],
		[isDeleted]
	FROM [UsefulLink]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UsefulLinkLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_UsefulLinkLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UsefulLinkUpdate]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UsefulLinkUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UsefulLinkUpdate];
GO

CREATE PROCEDURE [proc_UsefulLinkUpdate]
(
	@UsefulLinkID int,
	@Title nvarchar(300) = NULL,
	@Description nvarchar(1000) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@URL nvarchar(500) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [UsefulLink]
	SET
		[Title] = @Title,
		[Description] = @Description,
		[CreatedBy] = @CreatedBy,
		[CreatedDate] = @CreatedDate,
		[UpdatedBy] = @UpdatedBy,
		[LastUpdatedDate] = @LastUpdatedDate,
		[URL] = @URL,
		[isDeleted] = @isDeleted
	WHERE
		[UsefulLinkID] = @UsefulLinkID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UsefulLinkUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_UsefulLinkUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_UsefulLinkInsert]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UsefulLinkInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UsefulLinkInsert];
GO

CREATE PROCEDURE [proc_UsefulLinkInsert]
(
	@UsefulLinkID int = NULL output,
	@Title nvarchar(300) = NULL,
	@Description nvarchar(1000) = NULL,
	@CreatedBy uniqueidentifier = NULL,
	@CreatedDate datetime = NULL,
	@UpdatedBy uniqueidentifier = NULL,
	@LastUpdatedDate datetime = NULL,
	@URL nvarchar(500) = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [UsefulLink]
	(
		[Title],
		[Description],
		[CreatedBy],
		[CreatedDate],
		[UpdatedBy],
		[LastUpdatedDate],
		[URL],
		[isDeleted]
	)
	VALUES
	(
		@Title,
		@Description,
		@CreatedBy,
		@CreatedDate,
		@UpdatedBy,
		@LastUpdatedDate,
		@URL,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @UsefulLinkID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UsefulLinkInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_UsefulLinkInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_UsefulLinkDelete]    Script Date: 29/06/2015 11:17:48 AM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_UsefulLinkDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_UsefulLinkDelete];
GO

CREATE PROCEDURE [proc_UsefulLinkDelete]
(
	@UsefulLinkID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [UsefulLink]
	WHERE
		[UsefulLinkID] = @UsefulLinkID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_UsefulLinkDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_UsefulLinkDelete Error on Creation'
GO
