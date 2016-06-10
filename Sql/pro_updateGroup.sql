USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_updateGroup', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_updateGroup;
GO
CREATE PROCEDURE pro_updateGroup
	@id NVARCHAR(50),
	@name NVARCHAR(50),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranAdd		
		SELECT @isExisted = COUNT(GroupID) FROM SaleGroup WHERE GroupID = @id;
		IF(@isExisted=1)
		BEGIN
			UPDATE SaleGroup SET GroupName = @name WHERE GroupID = @id;
			SET @errorCount += @@error;
		END
		ELSE
		BEGIN
			SET @flag = 0;	--更新失败
			SET @message = 'fail, there is no' + @ID + 'sale group.';
		END

	IF(@errorCount = 0)
	BEGIN
		SET @flag = 1;	--更新成功
		SET @message = 'success';
		COMMIT TRAN tranAdd;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--更新失败
		ROLLBACK TRAN tranAdd;
	END
END


select * from SaleGroup