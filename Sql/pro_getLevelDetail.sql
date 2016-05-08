use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getLevelDetail', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getLevelDetail;
GO
CREATE PROCEDURE pro_getLevelDetail

	@id nvarchar(50)
AS
BEGIN
	SELECT sl.ID AS '������',
		sl.LevelName AS '��������',
		sl.Remark AS '��ע', 
		ar.MaxNumber AS 'A��绰���ȡ��',
		ar.DailyNumber AS 'A��绰���ȡ��/��',
		ar.Remark AS 'A��ע',
		br.MaxNumber AS 'B��绰���ȡ��',
		br.DailyNumber AS 'B��绰���ȡ��/��',
		br.Remark AS 'B��ע',
		cr.MaxNumber AS 'C��绰���ȡ��',
		cr.DailyNumber AS 'C��绰���ȡ��/��',
		cr.Remark AS 'C��ע'
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