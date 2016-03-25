USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_deleteRole', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_deleteRole;
GO
CREATE PROCEDURE pro_deleteRole
	@id NVARCHAR(50),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranDelete
		SELECT @isExisted = COUNT(RoleID) FROM RoleInfo WHERE RoleID = @id;
		IF(@isExisted=1)
		BEGIN
			--����ɾ��role��Ӧ��functions
			DELETE RelationInfo WHERE RoleID = @id;
			IF(@@error=0)
			BEGIN
				--ɾ��
				DELETE FROM RoleInfo WHERE RoleID = @id;
				IF(@@error=0)
				BEGIN
					SET @flag = 1;	--ɾ���ɹ�
					SET @message = 'success';
				END
				ELSE
				BEGIN
					SET @errorCount += 1;
				END
			END
			ELSE
			BEGIN
				SET @errorCount += 1;
			END
		END
		ELSE
		BEGIN
			SET @flag = 0;	--ɾ��ʧ��
			SET @message = 'fail, there is no' + @id + ' role.';
		END

	IF(@errorCount = 0)
	BEGIN
		COMMIT TRAN tranDelete;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--ɾ��ʧ��
		SET @message = 'fail.';
		ROLLBACK TRAN tranDelete;
	END
END