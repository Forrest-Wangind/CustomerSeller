USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_updateUser', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_updateUser;
GO
CREATE PROCEDURE pro_updateUser
	@id NVARCHAR(50),
	@name NVARCHAR(20),
	@pass NVARCHAR(50),
	@role NVARCHAR(50),
	@gender NVARCHAR(20),
	@exten NVARCHAR(20),
	@entryTime DATETIME,
	@levelId NVARCHAR(50),
	@groupId NVARCHAR(50),
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
				UPDATE UserInfo SET UserName = @name,UserGender=@gender,Exten=@exten,EntryTime=@entryTime,LevelID=@levelId,RoleID=@role,GroupID=@groupId
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
			ELSE
			BEGIN
				UPDATE UserInfo SET UserName = @name,[Password]=@pass,UserGender=@gender,Exten=@exten,EntryTime=@entryTime,LevelID=@levelId,RoleID=@role,GroupID=@groupId
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