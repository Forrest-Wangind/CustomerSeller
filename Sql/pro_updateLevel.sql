USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_updateLevel', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_updateLevel;
GO
CREATE PROCEDURE pro_updateLevel
	@id NVARCHAR(50),
	@name NVARCHAR(50),
	@remark NVARCHAR(100),
	@AMaxNumber INT,
	@ADailyNumber INT,
	@ARemark NVARCHAR(100),
	@BMaxNumber INT,
	@BDailyNumber INT,
	@BRemark NVARCHAR(100),
	@CMaxNumber INT,
	@CDailyNumber INT,
	@CRemark NVARCHAR(100),
	@flag INT OUTPUT,
	@message NVARCHAR(100) OUTPUT
AS
BEGIN
	DECLARE @isExisted INT;
	DECLARE @errorCount INT;
	SET @errorCount = 0;
	BEGIN TRAN tranAdd		
		SELECT @isExisted = COUNT(ID) FROM SaleLevel WHERE ID = @id;
		IF(@isExisted=1)
		BEGIN
			UPDATE SaleLevel SET levelName = @name, Remark = @remark WHERE ID = @id;
			IF(@@error=0)
			BEGIN
				DELETE PhoneAllocateRule WHERE LevelID = @id;
				INSERT INTO PhoneAllocateRule(ID,PhoneType,MaxNumber,DailyNumber,LevelID,Remark)
					VALUES(NEWID(),'A',@AMaxNumber,@ADailyNumber,@id,@ARemark);
				SET @errorCount += @@error;
				INSERT INTO PhoneAllocateRule(ID,PhoneType,MaxNumber,DailyNumber,LevelID,Remark)
					VALUES(NEWID(),'B',@BMaxNumber,@BDailyNumber,@id,@BRemark);
				SET @errorCount += @@error;
				INSERT INTO PhoneAllocateRule(ID,PhoneType,MaxNumber,DailyNumber,LevelID,Remark)
					VALUES(NEWID(),'C',@CMaxNumber,@CDailyNumber,@id,@CRemark);
				SET @errorCount += @@error;
			END
			ELSE
			BEGIN
				SET @errorCount += 1;
			END
		END
		ELSE
		BEGIN
			SET @flag = 0;	--更新失败
			SET @message = 'fail, there is no' + @ID + 'sale level.';
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


select * from SaleLevel