USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_deleteUser', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_deleteUser;
GO
CREATE PROCEDURE pro_deleteUser
	@id NVARCHAR(50),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranDelete
		SELECT @isExisted = COUNT(UserID) FROM UserInfo WHERE UserID = @id;
		IF(@isExisted=1)
		BEGIN
			DELETE FROM UserInfo WHERE UserID = @id;
			SET @errorCount += @@ERROR;
			UPDATE CustomerInfo SET EmployeeID = NULL, AllocateTime = NULL WHERE EmployeeID = @id;
			SET @errorCount += @@ERROR;
			DELETE AllocatePhoneDetailInfo WHERE UserID = @id;
			SET @errorCount += @@ERROR;
			IF(@errorCount=0)
			BEGIN
				SET @flag = 1;	--É¾³ý³É¹¦
				SET @message = 'success';
			END
			ELSE
			BEGIN
				SET @errorCount += 1;
			END
		END
		ELSE
		BEGIN
			SET @flag = 0;	--É¾³ýÊ§°Ü
			SET @message = 'fail, there is no' + @id + ' user.';
		END

	IF(@errorCount = 0)
	BEGIN
		COMMIT TRAN tranDelete;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--²åÈëÊ§°Ü
		SET @message = 'fail.';
		ROLLBACK TRAN tranDelete;
	END
END