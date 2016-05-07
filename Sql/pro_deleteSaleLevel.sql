USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_deleteLevel', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_deleteLevel;
GO
CREATE PROCEDURE pro_deleteLevel
	@id NVARCHAR(50),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	DECLARE @levelID NVARCHAR(50);
	SET @errorCount = 0;
	BEGIN TRAN tranAdd		
		SELECT @isExisted = COUNT(ID) FROM SaleLevel WHERE ID = @id;
		IF(@isExisted=1)
		BEGIN
			DELETE PhoneAllocateRule WHERE LevelID = @id;
			SET @errorCount += @@error;
			DELETE SaleLevel WHERE ID = @id;
			SET @errorCount += @@error;
		END
		ELSE
		BEGIN
			SET @flag = 0;	--É¾³ýÊ§°Ü
			SET @message = 'fail, there is no' + @id + ' sale level.';
		END

	IF(@errorCount = 0)
	BEGIN
		SET @flag = 1;	--É¾³ý³É¹¦
		SET @message = 'success';
		COMMIT TRAN tranAdd;
	END
	ELSE
	BEGIN
		SET @flag = 0;	--É¾³ýÊ§°Ü
		ROLLBACK TRAN tranAdd;
	END
END


select * from SaleLevel