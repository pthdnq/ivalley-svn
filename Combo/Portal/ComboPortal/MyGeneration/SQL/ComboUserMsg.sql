
/****** Object:  StoredProcedure [proc_ComboUserMsgLoadByPrimaryKey]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserMsgLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserMsgLoadByPrimaryKey];
GO

CREATE PROCEDURE [proc_ComboUserMsgLoadByPrimaryKey]
(
	@ComboMsgID int,
	@ComboUserID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboMsgID],
		[ComboUserID]
	FROM [ComboUserMsg]
	WHERE
		([ComboMsgID] = @ComboMsgID) AND
		([ComboUserID] = @ComboUserID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserMsgLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserMsgLoadByPrimaryKey Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserMsgLoadAll]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserMsgLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserMsgLoadAll];
GO

CREATE PROCEDURE [proc_ComboUserMsgLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ComboMsgID],
		[ComboUserID]
	FROM [ComboUserMsg]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserMsgLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserMsgLoadAll Error on Creation'
GO

-------------------------------------------
-- NO UPDATE Stored Procedure Generated    
-- All Columns are part of the Primary key 
-------------------------------------------


/****** Object:  StoredProcedure [proc_ComboUserMsgInsert]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserMsgInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserMsgInsert];
GO

CREATE PROCEDURE [proc_ComboUserMsgInsert]
(
	@ComboMsgID int,
	@ComboUserID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [ComboUserMsg]
	(
		[ComboMsgID],
		[ComboUserID]
	)
	VALUES
	(
		@ComboMsgID,
		@ComboUserID
	)

	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserMsgInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserMsgInsert Error on Creation'
GO

/****** Object:  StoredProcedure [proc_ComboUserMsgDelete]    Script Date: 09/07/2015 3:06:31 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[proc_ComboUserMsgDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [proc_ComboUserMsgDelete];
GO

CREATE PROCEDURE [proc_ComboUserMsgDelete]
(
	@ComboMsgID int,
	@ComboUserID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [ComboUserMsg]
	WHERE
		[ComboMsgID] = @ComboMsgID AND
		[ComboUserID] = @ComboUserID
	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ComboUserMsgDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ComboUserMsgDelete Error on Creation'
GO
