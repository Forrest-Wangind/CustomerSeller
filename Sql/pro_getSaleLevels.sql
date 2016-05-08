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
		SELECT sl.ID AS '������',
			sl.LevelName AS '��������', 
			ar.MaxNumber AS 'A��绰���ȡ��',
			ar.DailyNumber AS 'A��绰���ȡ��/��',
			br.MaxNumber AS 'B��绰���ȡ��',
			br.DailyNumber AS 'B��绰���ȡ��/��',
			cr.MaxNumber AS 'C��绰���ȡ��',
			cr.DailyNumber AS 'C��绰���ȡ��/��'
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