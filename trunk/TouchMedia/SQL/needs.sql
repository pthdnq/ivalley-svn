
/****** Object:  StoredProcedure [proc_needsLoadByPrimaryKey]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_needsLoadByPrimaryKey]
(
	@NeedID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NeedID],
		[JobOrderID],
		[NeedName],
		[NeedSupplier],
		[NeedQuantity],
		[IsNew],
		[IsAvalible],
		[IsMaintenance],
		[isDeleted]
	FROM [needs]
	WHERE
		([NeedID] = @NeedID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_needsLoadAll]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsLoadAll];
GO

CREATE PROCEDURE [proc_needsLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NeedID],
		[JobOrderID],
		[NeedName],
		[NeedSupplier],
		[NeedQuantity],
		[IsNew],
		[IsAvalible],
		[IsMaintenance],
		[isDeleted]
	FROM [needs]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsLoadAll Error on Creation'
GO

/****** Object:  StoredProcedure [proc_needsUpdate]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsUpdate];
GO

CREATE PROCEDURE [proc_needsUpdate]
(
	@NeedID int,
	@JobOrderID int = NULL,
	@NeedName nvarchar(300) = NULL,
	@NeedSupplier nvarchar(300) = NULL,
	@NeedQuantity nvarchar(300) = NULL,
	@IsNew bit = NULL,
	@IsAvalible bit = NULL,
	@IsMaintenance bit = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [needs]
	SET
		[JobOrderID] = @JobOrderID,
		[NeedName] = @NeedName,
		[NeedSupplier] = @NeedSupplier,
		[NeedQuantity] = @NeedQuantity,
		[IsNew] = @IsNew,
		[IsAvalible] = @IsAvalible,
		[IsMaintenance] = @IsMaintenance,
		[isDeleted] = @isDeleted
	WHERE
		[NeedID] = @NeedID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsUpdate Error on Creation'
GO




/****** Object:  StoredProcedure [proc_needsInsert]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsInsert];
GO

CREATE PROCEDURE [proc_needsInsert]
(
	@NeedID int = NULL output,
	@JobOrderID int = NULL,
	@NeedName nvarchar(300) = NULL,
	@NeedSupplier nvarchar(300) = NULL,
	@NeedQuantity nvarchar(300) = NULL,
	@IsNew bit = NULL,
	@IsAvalible bit = NULL,
	@IsMaintenance bit = NULL,
	@isDeleted bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [needs]
	(
		[JobOrderID],
		[NeedName],
		[NeedSupplier],
		[NeedQuantity],
		[IsNew],
		[IsAvalible],
		[IsMaintenance],
		[isDeleted]
	)
	VALUES
	(
		@JobOrderID,
		@NeedName,
		@NeedSupplier,
		@NeedQuantity,
		@IsNew,
		@IsAvalible,
		@IsMaintenance,
		@isDeleted
	)

	SET @Err = @@Error

	SELECT @NeedID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_needsDelete]    Script Date: 30/07/2015 1:07:20 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_needsDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_needsDelete];
GO

CREATE PROCEDURE [proc_needsDelete]
(
	@NeedID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [needs]
	WHERE
		[NeedID] = @NeedID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_needsDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_needsDelete Error on Creation'
GO
