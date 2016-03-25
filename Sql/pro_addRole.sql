USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_addRole', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_addRole;
GO
CREATE PROCEDURE pro_addRole
	@id NVARCHAR(50),
	@name NVARCHAR(20),
	@remark NVARCHAR(50),
	@functions NVARCHAR(4000),
	@split NVARCHAR(10),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @relationId INT;
	DECLARE @function NVARCHAR(50);
	DECLARE @errorCount INT;
	DECLARE @location INT;
	DECLARE @start INT;
	DECLARE @seed INT;

	SET @errorCount = 0;
	BEGIN TRAN tranAdd
		SELECT @isExisted = COUNT(RoleID) FROM RoleInfo WHERE RoleID = @id;
		IF(@isExisted=0)
		BEGIN
			INSERT INTO RoleInfo VALUES(@id,@name,@remark);
			IF(@@error=0)
			BEGIN
				--更新relation
				IF(@functions IS NOT NULL AND @functions != '')
				BEGIN
					--删除role的所有relation
					DELETE RelationInfo WHERE RoleID = @id;
					SET @functions = LTRIM(RTRIM(@functions));
					SET @location = CHARINDEX(@split,@functions);
					SET @start = 1;
					SET @seed = LEN(@split);
					WHILE @location <> 0
					BEGIN
						SELECT @function = SUBSTRING(@functions,@start,@location-@start);
						--主键为当前最大主键+1
						SELECT @relationId = MAX(RelationID) + 1 from RelationInfo;
						INSERT INTO RelationInfo values(@relationId,@id,@function);
						IF(@@ERROR <> 0)
						BEGIN
							SET @errorCount += 1;
							SET @flag = 0;	--添加失败
							SET @message = 'fail when insert value into RelationInfo.';
						END
						SET @start=@location+@seed;
						SET @location=CHARINDEX(@split,@functions,@start);
					END
				END

			END
			ELSE
			BEGIN
				SET @errorCount += 1;
			END
		END
		ELSE
		BEGIN
			SET @flag = 0;	--添加失败
			SET @message = 'fail, there is no' + @id + ' role.';
		END

	IF(@errorCount = 0)
	BEGIN
		SET @flag = 1;	--添加成功
		SET @message = 'success';
		COMMIT TRAN tranAdd;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--添加失败
		ROLLBACK TRAN tranAdd;
	END
END