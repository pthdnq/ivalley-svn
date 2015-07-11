
/****** Object:  StoredProcedure [proc_ComboPostLikeLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostLikeLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostLikeLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboPostLikeLoadByPrimaryKey]
(
	@ComboUserID int,
	@ComboPostID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboPostID]
	FROM [ComboPostLike]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([ComboPostID] = @ComboPostID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostLikeLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostLikeLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostLikeLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostLikeLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostLikeLoadAll];
GO

CREATE PROCEDURE [proc_ComboPostLikeLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboPostID]
	FROM [ComboPostLike]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostLikeLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostLikeLoadAll Error on Creation'
GO

-------------------------------------------
-- NO UPDATE Stored Procedure Generated    
-- All Columns are part of the Primary key 
-------------------------------------------


/****** Object:  StoredProcedure [proc_ComboPostLikeInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostLikeInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostLikeInsert];
GO

CREATE PROCEDURE [proc_ComboPostLikeInsert]
(
	@ComboUserID int,
	@ComboPostID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboPostLike]
	(
		[ComboUserID],
		[ComboPostID]
	)
	VALUES
	(
		@ComboUserID,
		@ComboPostID
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostLikeInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostLikeInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostLikeDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostLikeDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostLikeDelete];
GO

CREATE PROCEDURE [proc_ComboPostLikeDelete]
(
	@ComboUserID int,
	@ComboPostID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboPostLike]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[ComboPostID] = @ComboPostID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostLikeDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostLikeDelete Error on Creation'
GO
