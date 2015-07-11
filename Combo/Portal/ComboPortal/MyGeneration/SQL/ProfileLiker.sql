
/****** Object:  StoredProcedure [proc_ProfileLikerLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileLikerLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileLikerLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ProfileLikerLoadByPrimaryKey]
(
	@ComboUserID int,
	@ComboLikerID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboLikerID]
	FROM [ProfileLiker]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([ComboLikerID] = @ComboLikerID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileLikerLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileLikerLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProfileLikerLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileLikerLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileLikerLoadAll];
GO

CREATE PROCEDURE [proc_ProfileLikerLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboLikerID]
	FROM [ProfileLiker]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileLikerLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileLikerLoadAll Error on Creation'
GO

-------------------------------------------
-- NO UPDATE Stored Procedure Generated    
-- All Columns are part of the Primary key 
-------------------------------------------


/****** Object:  StoredProcedure [proc_ProfileLikerInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileLikerInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileLikerInsert];
GO

CREATE PROCEDURE [proc_ProfileLikerInsert]
(
	@ComboUserID int,
	@ComboLikerID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ProfileLiker]
	(
		[ComboUserID],
		[ComboLikerID]
	)
	VALUES
	(
		@ComboUserID,
		@ComboLikerID
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileLikerInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileLikerInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ProfileLikerDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ProfileLikerDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ProfileLikerDelete];
GO

CREATE PROCEDURE [proc_ProfileLikerDelete]
(
	@ComboUserID int,
	@ComboLikerID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ProfileLiker]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[ComboLikerID] = @ComboLikerID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ProfileLikerDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ProfileLikerDelete Error on Creation'
GO
