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
	SELECT pdi.PhoneType AS '电话类型', pdi.UserID AS '用户编号', ui.UserName AS '用户姓名', pdi.DailyCount AS '当天获取数', pdi.TotalCount AS '获取总数', pdi.AllocateTime AS '获取时间' 
	FROM AllocatePhoneDetailInfo pdi
	LEFT JOIN UserInfo ui ON pdi.UserID = ui.UserID
	WHERE 
	(PhoneType like '%' + @phoneType + '%' OR @phoneType is null)
	AND (pdi.UserID like '%' + @userId + '%' OR @userId  is null)
	AND (ui.UserName like '%' + @userName + '%' OR @userName is null)
	AND (ui.GroupID like '%' + @groupId + '%' OR @groupId is null)
	ORDER BY pdi.UserID desc, pdi.PhoneType;
	SELECT AD.PhoneType AS '电话类型',AD.typeAllocate AS '分配电话总数',
	(CASE WHEN CG.typeGet is null THEN 0 ELSE CG.typeGet END) AS '客户电话总数',
	0 AS '最多取数/天', 0 AS '最大取数'
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