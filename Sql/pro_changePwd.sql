USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_changeUserPwd', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_changeUserPwd;
GO
CREATE PROCEDURE pro_changeUserPwd
	@id NVARCHAR(50),
	@pass NVARCHAR(50),
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
			IF(@pass IS NULL OR @pass = '')
			BEGIN
				SET @flag = 0;	--更新失败
				SET @message = 'pass is null';
			END
			ELSE
			BEGIN
				UPDATE UserInfo SET [Password]=@pass
					WHERE UserID = @id
				IF(@@error=0)
				BEGIN
					SET @flag = 1;	--更新成功
					SET @message = 'success';
				END
				ELSE
				BEGIN
					SET @errorCount += 1;
				END
			END
		END
		ELSE
		BEGIN
			SET @flag = 0;	--更新失败
			SET @message = 'fail, there is no' + @id + ' user.';
		END

	IF(@errorCount = 0)
	BEGIN
		COMMIT TRAN tranAdd;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--插入失败
		ROLLBACK TRAN tranAdd;
	END
END

select * from UserInfo

