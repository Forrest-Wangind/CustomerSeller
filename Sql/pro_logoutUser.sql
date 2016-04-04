USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_logoutUser', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_logoutUser;
GO
CREATE PROCEDURE pro_logoutUser
	@id NVARCHAR(50),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranAdd
		SELECT @isExisted = COUNT(UserID) FROM UserInfo WHERE UserID = @id;
		IF(@isExisted=1)
		BEGIN
			UPDATE UserInfo SET UserStatus = 0 WHERE UserID = @id
			IF(@@error=0)
			BEGIN
				SET @flag = 1;	--退出成功
				SET @message = 'success';
			END
			ELSE
			BEGIN
				SET @errorCount += 1;
			END
		END
		ELSE
		BEGIN
			SET @flag = 0;	--退出失败
			SET @message = 'logout fail, there is no' + @id + ' user.';
		END

	IF(@errorCount = 0)
	BEGIN
		COMMIT TRAN tranAdd;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--退出失败
		ROLLBACK TRAN tranAdd;
	END
END