USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_addLevel', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_addLevel;
GO
CREATE PROCEDURE pro_addLevel
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
	DECLARE @levelID NVARCHAR(50);
	SET @errorCount = 0;
	SELECT @levelID = NEWID();
	BEGIN TRAN tranAdd		
		SELECT @isExisted = COUNT(ID) FROM SaleLevel WHERE ID = @levelID;
		IF(@isExisted=0)
		BEGIN
			INSERT INTO SaleLevel(ID,LevelName,Remark) VALUES(@levelID,@name,@remark);
			IF(@@error=0)
			BEGIN
				INSERT INTO PhoneAllocateRule(ID,PhoneType,MaxNumber,DailyNumber,LevelID,Remark)
					VALUES(NEWID(),'A',@AMaxNumber,@ADailyNumber,@levelID,@ARemark);
				SET @errorCount += @@error;
				INSERT INTO PhoneAllocateRule(ID,PhoneType,MaxNumber,DailyNumber,LevelID,Remark)
					VALUES(NEWID(),'B',@BMaxNumber,@BDailyNumber,@levelID,@BRemark);
				SET @errorCount += @@error;
				INSERT INTO PhoneAllocateRule(ID,PhoneType,MaxNumber,DailyNumber,LevelID,Remark)
					VALUES(NEWID(),'C',@CMaxNumber,@CDailyNumber,@levelID,@CRemark);
				SET @errorCount += @@error;
			END
			ELSE
			BEGIN
				SET @errorCount += 1;
			END
		END
		ELSE
		BEGIN
			SET @flag = 0;	--插入失败
			SET @message = 'fail, there is ' + @levelID + ' level already.';
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