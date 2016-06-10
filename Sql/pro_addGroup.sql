USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_addGroup', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_addGroup;
GO
CREATE PROCEDURE pro_addGroup
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
		IF(@isExisted=0)
		BEGIN
			INSERT INTO SaleGroup(GroupID,GroupName) VALUES(@id,@name);
			SET @errorCount += @@error;
		END
		ELSE
		BEGIN
			SET @flag = 0;	--插入失败
			SET @message = 'fail, there is ' + @id + ' level already.';
		END

	IF(@errorCount = 0)
	BEGIN
		SET @flag = 1;	--插入成功
		SET @message = 'success';
		COMMIT TRAN tranAdd;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--插入失败
		ROLLBACK TRAN tranAdd;
	END
END


select * from SaleLevel