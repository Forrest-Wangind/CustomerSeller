USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_addUser', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_addUser;
GO
CREATE PROCEDURE pro_addUser
	@id NVARCHAR(50),
	@name NVARCHAR(20),
	@pass NVARCHAR(50),
	@gender NVARCHAR(20),
	@role VARCHAR(20),
	@exten NVARCHAR(20),
	@entryTime DATETIME,
	@levelId NVARCHAR(50),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranAdd
		SELECT @isExisted = COUNT(UserID) FROM UserInfo WHERE UserID = @id;
		IF(@isExisted=0)
		BEGIN
			IF(@entryTime='')	--如果入职时间为空
			BEGIN
				INSERT INTO UserInfo(UserID,UserName,[Password],UserGender,RoleID,Exten,LevelID)
				VALUES(@id,@name,@pass,@gender,@role,@exten,@levelId);
				IF(@@error=0)
				BEGIN
					SET @flag = 1;	--插入成功
					SET @message = 'success';
				END
				ELSE
				BEGIN
					SET @errorCount += 1;
				END
			END
			ELSE
			BEGIN
				INSERT INTO UserInfo(UserID,UserName,[Password],UserGender,RoleID,Exten,EntryTime,LevelID)
					VALUES(@id,@name,@pass,@gender,@role,@exten,@entryTime,@levelId);
				IF(@@error=0)
				BEGIN
					SET @flag = 1;	--插入成功
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
			SET @flag = 0;	--插入失败
			SET @message = 'fail, there is ' + @id + ' user already.';
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

DECLARE @string VARCHAR(100);
DECLARE @ids VARCHAR(20) ;
SET @ids = 'T04471';
SET @string = 'fail, there is ' + @ids + ' user already.';
select @string;

select len('fail, there is T04471 user already.')