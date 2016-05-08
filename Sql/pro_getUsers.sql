use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getUsers', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getUsers;
GO
CREATE PROCEDURE pro_getUsers
	@id nvarchar(50),
	@name nvarchar(20),
	@role nvarchar(50),
	@gender nvarchar(20),
	@entryTimeStart datetime,
	@entryTimeEnd datetime
AS
BEGIN
	SELECT [users].UserID as '用户编号',
	[users].UserName as '姓名',
	'性别'=
	CASE
		WHEN [users].UserGender = 'm' THEN '男'
		WHEN [users].UserGender = 'f' THEN '女'
		ELSE '未知'
	END,
	[users].EntryTime as '入职时间',
	[users].Exten as '坐席工号',
	[roles].RoleName as '角色名称',
	sLevel.LevelName as '销售级别名称'
	FROM UserInfo [users]
	INNER JOIN RoleInfo [roles] ON [users].RoleID = [roles].RoleID
	LEFT JOIN SaleLevel sLevel ON [users].LevelID = sLevel.ID
	WHERE 
		((UserID like '%' + @id + '%') or (@id is null))
		AND ((UserName like '%' + @name + '%') OR (@name is null))
		AND ((RoleName = @role) or (@role is null))
		AND ((UserGender = @gender) or (@gender = '') or (@gender is null))
		AND ((EntryTime BETWEEN @entryTimeStart AND @entryTimeEnd) OR (@entryTimeStart = '') OR (@entryTimeStart is null) OR (@entryTimeEnd = '') OR (@entryTimeEnd is null))
END

select GETDATE();

execute pro_getUsers null,null,null,null,null,null

SELECT * FROM UserInfo

SELECT [users].UserID as '用户编号',
[users].UserName as '姓名',
'性别'=
CASE
	WHEN [users].UserGender = 'm' THEN '男'
	WHEN [users].UserGender = 'f' THEN '女'
	ELSE '未知'
END,
[users].EntryTime as '入职时间',
[users].Exten as '坐席工号',
[roles].RoleName as '角色名称'
FROM UserInfo [users]
INNER JOIN RoleInfo [roles] ON [users].RoleID = [roles].RoleID
WHERE
	(RoleName = 'salesman') or (RoleName is null)

