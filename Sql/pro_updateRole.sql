USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_updateRole', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_updateRole;
GO
CREATE PROCEDURE pro_updateRole
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
		IF(@isExisted=1)
		BEGIN
			UPDATE RoleInfo SET RoleName = @name, RoleRemark = @remark WHERE RoleID = @id;
			IF(@@error=0)
			BEGIN
				--����relation
				IF(@functions IS NOT NULL AND @functions != '')
				BEGIN
					--ɾ��role������relation
					DELETE RelationInfo WHERE RoleID = @id;
					SET @functions = LTRIM(RTRIM(@functions));
					SET @location = CHARINDEX(@split,@functions);
					SET @start = 1;
					SET @seed = LEN(@split);
					WHILE @location <> 0
					BEGIN
						SELECT @function = SUBSTRING(@functions,@start,@location-@start);
						--����Ϊ��ǰ�������+1
						SELECT @relationId = MAX(RelationID) + 1 from RelationInfo;
						INSERT INTO RelationInfo values(@relationId,@id,@function);
						IF(@@ERROR <> 0)
						BEGIN
							SET @errorCount += 1;
							SET @flag = 0;	--����ʧ��
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
			SET @flag = 0;	--����ʧ��
			SET @message = 'fail, there is no' + @id + ' role.';
		END

	IF(@errorCount = 0)
	BEGIN
		SET @flag = 1;	--���³ɹ�
		SET @message = 'success';
		COMMIT TRAN tranAdd;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--����ʧ��
		ROLLBACK TRAN tranAdd;
	END
END