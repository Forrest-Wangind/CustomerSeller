USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_getLevels', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getLevels;
GO
CREATE PROCEDURE pro_getLevels
	@name NVARCHAR(50),
	@isSample INT
AS
BEGIN
	IF(@isSample = 1)
	BEGIN
		SELECT sl.ID as 'id',sl.LevelName as 'name' FROM SaleLevel sl
		WHERE (sl.LevelName like '%' + @name + '%') or (@name is null)
	END
	ELSE
	BEGIN
		SELECT sl.ID AS '级别编号',
			sl.LevelName AS '级别名称', 
			ar.MaxNumber AS 'A类电话最大取数',
			ar.DailyNumber AS 'A类电话最大取数/天',
			br.MaxNumber AS 'B类电话最大取数',
			br.DailyNumber AS 'B类电话最大取数/天',
			cr.MaxNumber AS 'C类电话最大取数',
			cr.DailyNumber AS 'C类电话最大取数/天'
		FROM SaleLevel sl
		LEFT JOIN 
			(SELECT * FROM PhoneAllocateRule WHERE UPPER(PhoneType) = 'A') ar ON sl.ID = ar.LevelID
		LEFT JOIN 
			(SELECT * FROM PhoneAllocateRule WHERE UPPER(PhoneType) = 'B') br ON sl.ID = br.LevelID
		LEFT JOIN 
			(SELECT * FROM PhoneAllocateRule WHERE UPPER(PhoneType) = 'C') cr ON sl.ID = cr.LevelID
		WHERE (sl.LevelName like '%' + @name + '%') or (@name is null)
	END
END



SELECT * FROM SaleLevel
exec pro_getLevels ''