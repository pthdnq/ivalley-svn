
/****** Object:  StoredProcedure [proc_ComboPostFavLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostFavLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostFavLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboPostFavLoadByPrimaryKey]
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
	FROM [ComboPostFav]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([ComboPostID] = @ComboPostID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostFavLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostFavLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostFavLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostFavLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostFavLoadAll];
GO

CREATE PROCEDURE [proc_ComboPostFavLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[ComboPostID]
	FROM [ComboPostFav]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostFavLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostFavLoadAll Error on Creation'
GO

-------------------------------------------
-- NO UPDATE Stored Procedure Generated    
-- All Columns are part of the Primary key 
-------------------------------------------


/****** Object:  StoredProcedure [proc_ComboPostFavInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostFavInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostFavInsert];
GO

CREATE PROCEDURE [proc_ComboPostFavInsert]
(
	@ComboUserID int,
	@ComboPostID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboPostFav]
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
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostFavInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostFavInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboPostFavDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboPostFavDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboPostFavDelete];
GO

CREATE PROCEDURE [proc_ComboPostFavDelete]
(
	@ComboUserID int,
	@ComboPostID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboPostFav]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[ComboPostID] = @ComboPostID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboPostFavDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboPostFavDelete Error on Creation'
GO
