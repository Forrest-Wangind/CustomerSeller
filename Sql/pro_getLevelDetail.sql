use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getLevelDetail', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getLevelDetail;
GO
CREATE PROCEDURE pro_getLevelDetail

	@id nvarchar(50)
AS
BEGIN
	SELECT sl.ID AS '级别编号',
		sl.LevelName AS '级别名称',
		sl.Remark AS '备注', 
		ar.MaxNumber AS 'A类电话最大取数',
		ar.DailyNumber AS 'A类电话最大取数/天',
		ar.Remark AS 'A备注',
		br.MaxNumber AS 'B类电话最大取数',
		br.DailyNumber AS 'B类电话最大取数/天',
		br.Remark AS 'B备注',
		cr.MaxNumber AS 'C类电话最大取数',
		cr.DailyNumber AS 'C类电话最大取数/天',
		cr.Remark AS 'C备注'
	FROM SaleLevel sl
	LEFT JOIN 
		(SELECT * FROM PhoneAllocateRule WHERE UPPER(PhoneType) = 'A') ar ON sl.ID = ar.LevelID
	LEFT JOIN 
		(SELECT * FROM PhoneAllocateRule WHERE UPPER(PhoneType) = 'B') br ON sl.ID = br.LevelID
	LEFT JOIN 
		(SELECT * FROM PhoneAllocateRule WHERE UPPER(PhoneType) = 'C') cr ON sl.ID = cr.LevelID
	WHERE sl.ID = @id;
END

SELECT * FROM SaleLevel
execute pro_getLevelDetail '1A8E928F-A4C8-4EB7-80D4-77DCEC6A44D8'