USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_logoutAllUsers', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_logoutAllUsers;
GO
CREATE PROCEDURE pro_logoutAllUsers
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranAdd
		UPDATE UserInfo SET UserStatus = 0
			IF(@@error=0)
			BEGIN
				SET @flag = 1;	--退出成功
				SET @message = 'success';
			END
			ELSE
			BEGIN
				SET @errorCount += 1;
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