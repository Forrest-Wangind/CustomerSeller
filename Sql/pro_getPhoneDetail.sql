USE CustomerSeller
GO
IF OBJECT_ID ('pro_getPhoneDetail', 'P') IS NOT NULL
    DROP PROCEDURE pro_getPhoneDetail;
GO
CREATE PROCEDURE pro_getPhoneDetail
	@phoneType NVARCHAR(10),
	@userId NVARCHAR(50)
AS
BEGIN
	SELECT PhoneType AS '�绰����', UserID AS '�û�', DailyCount AS '�����ȡ��', TotalCount AS '��ȡ����', AllocateTime AS '��ȡʱ��' 
	FROM AllocatePhoneDetailInfo
	WHERE 
	(PhoneType like '%' + @phoneType + '%' OR @phoneType is null)
	AND (UserID like '%' + @userId + '%' OR @userId  is null)
	ORDER BY �û� desc, �绰����;
	SELECT AD.PhoneType AS '�绰����',AD.typeAllocate AS '����绰����',
	(CASE WHEN CG.typeGet is null THEN 0 ELSE CG.typeGet END) AS '�ͻ��绰����',
	0 AS '���ȡ��/��', 0 AS '���ȡ��'
	FROM
	(
		SELECT SUM(TotalCount) AS 'typeAllocate',PhoneType FROM AllocatePhoneDetailInfo
		GROUP BY PhoneType
	) AS AD
	LEFT JOIN
	(
		SELECT COUNT(1) AS 'typeGet',PhoneType FROM CustomerInfo
		GROUP BY PhoneType
	) AS CG
	ON UPPER(AD.PhoneType) = UPPER(CG.PhoneType)
END



EXEC pro_getPhoneDetail '',''
SELECT * FROM AllocatePhoneDetailInfo
select * from UserInfo
update UserInfo set UserStatus = 0 where UserID = 'T04471'