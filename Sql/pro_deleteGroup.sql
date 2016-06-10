USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_deleteGroup', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_deleteGroup;
GO
CREATE PROCEDURE pro_deleteGroup
	@id NVARCHAR(50),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranDelete
		SELECT @isExisted = COUNT(GroupID) FROM SaleGroup WHERE GroupID = @id;
		IF(@isExisted=1)
		BEGIN
			DELETE FROM SaleGroup WHERE GroupID = @id;
			SET @errorCount += @@ERROR;
		END
		ELSE
		BEGIN
			SET @flag = 0;	--ɾ��ʧ��
			SET @message = 'fail, there is no' + @id + ' sale group.';
		END

	IF(@errorCount = 0)
	BEGIN
		SET @flag = 1;	--ɾ���ɹ�
		SET @message = 'success';
		COMMIT TRAN tranDelete;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--ɾ��ʧ��
		ROLLBACK TRAN tranDelete;
	END
END