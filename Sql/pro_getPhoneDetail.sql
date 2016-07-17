USE CustomerSeller
GO
IF OBJECT_ID ('pro_getPhoneDetail', 'P') IS NOT NULL
    DROP PROCEDURE pro_getPhoneDetail;
GO
CREATE PROCEDURE pro_getPhoneDetail
	@phoneType NVARCHAR(10),
	@userId NVARCHAR(50),
	@userName NVARCHAR(50),
	@groupId nvarchar(50)
AS
BEGIN
	SELECT pdi.PhoneType AS '�绰����', pdi.UserID AS '�û����', ui.UserName AS '�û�����', pdi.DailyCount AS '�����ȡ��', pdi.TotalCount AS '��ȡ����', pdi.AllocateTime AS '��ȡʱ��' 
	FROM AllocatePhoneDetailInfo pdi
	LEFT JOIN UserInfo ui ON pdi.UserID = ui.UserID
	WHERE 
	(PhoneType like '%' + @phoneType + '%' OR @phoneType is null)
	AND (pdi.UserID like '%' + @userId + '%' OR @userId  is null)
	AND (ui.UserName like '%' + @userName + '%' OR @userName is null)
	AND (ui.GroupID like '%' + @groupId + '%' OR @groupId is null)
	ORDER BY pdi.UserID desc, pdi.PhoneType;
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



EXEC pro_getPhoneDetail '','006','',''
SELECT * FROM AllocatePhoneDetailInfo
select * from UserInfo
update UserInfo set UserStatus = 0 where UserID = 'T04471'

select * from [dbo].[CustomerInfo]