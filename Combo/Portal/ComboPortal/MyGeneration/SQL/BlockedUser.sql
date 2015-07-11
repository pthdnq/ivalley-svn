
/****** Object:  StoredProcedure [proc_BlockedUserLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BlockedUserLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BlockedUserLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_BlockedUserLoadByPrimaryKey]
(
	@ComboUserID int,
	@BlockedUserID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[BlockedUserID]
	FROM [BlockedUser]
	WHERE
		([ComboUserID] = @ComboUserID) AND
		([BlockedUserID] = @BlockedUserID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BlockedUserLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_BlockedUserLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_BlockedUserLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BlockedUserLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BlockedUserLoadAll];
GO

CREATE PROCEDURE [proc_BlockedUserLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboUserID],
		[BlockedUserID]
	FROM [BlockedUser]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BlockedUserLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_BlockedUserLoadAll Error on Creation'
GO

-------------------------------------------
-- NO UPDATE Stored Procedure Generated    
-- All Columns are part of the Primary key 
-------------------------------------------


/****** Object:  StoredProcedure [proc_BlockedUserInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BlockedUserInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BlockedUserInsert];
GO

CREATE PROCEDURE [proc_BlockedUserInsert]
(
	@ComboUserID int,
	@BlockedUserID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [BlockedUser]
	(
		[ComboUserID],
		[BlockedUserID]
	)
	VALUES
	(
		@ComboUserID,
		@BlockedUserID
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BlockedUserInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_BlockedUserInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_BlockedUserDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_BlockedUserDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_BlockedUserDelete];
GO

CREATE PROCEDURE [proc_BlockedUserDelete]
(
	@ComboUserID int,
	@BlockedUserID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [BlockedUser]
	WHERE
		[ComboUserID] = @ComboUserID AND
		[BlockedUserID] = @BlockedUserID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_BlockedUserDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_BlockedUserDelete Error on Creation'
GO
