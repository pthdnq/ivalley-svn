
/****** Object:  StoredProcedure [proc_ComboCommentLikeLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentLikeLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentLikeLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboCommentLikeLoadByPrimaryKey]
(
	@ComboUserID int,
	@ComboCommentID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboCommentID]
	FROM [ComboCommentLike]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([ComboCommentID] = @ComboCommentID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentLikeLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentLikeLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentLikeLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentLikeLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentLikeLoadAll];
GO

CREATE PROCEDURE [proc_ComboCommentLikeLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboCommentID]
	FROM [ComboCommentLike]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentLikeLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentLikeLoadAll Error on Creation'
GO

-------------------------------------------
-- NO UPDATE Stored Procedure Generated    
-- All Columns are part of the Primary key 
-------------------------------------------


/****** Object:  StoredProcedure [proc_ComboCommentLikeInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentLikeInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentLikeInsert];
GO

CREATE PROCEDURE [proc_ComboCommentLikeInsert]
(
	@ComboUserID int,
	@ComboCommentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboCommentLike]
	(
		[ComboUserID],
		[ComboCommentID]
	)
	VALUES
	(
		@ComboUserID,
		@ComboCommentID
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentLikeInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentLikeInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboCommentLikeDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboCommentLikeDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboCommentLikeDelete];
GO

CREATE PROCEDURE [proc_ComboCommentLikeDelete]
(
	@ComboUserID int,
	@ComboCommentID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboCommentLike]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[ComboCommentID] = @ComboCommentID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboCommentLikeDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboCommentLikeDelete Error on Creation'
GO
