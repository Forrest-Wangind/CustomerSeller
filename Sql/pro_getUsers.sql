use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getUsers', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getUsers;
GO
CREATE PROCEDURE [dbo].[pro_getUsers]
	@id nvarchar(50),
	@name nvarchar(20),
	@role nvarchar(50),
	@loginerId nvarchar(50),
	@gender nvarchar(20),
	@entryTimeStart datetime,
	@entryTimeEnd datetime
AS
BEGIN
	DECLARE @saleGroup nvarchar(50);
	DECLARE @roleID nvarchar(50);
	SELECT @roleID = RoleID, @saleGroup = GroupID FROM UserInfo WHERE UserID = @loginerId;
	IF(@roleID is not null AND @roleID = '003')
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
		sLevel.LevelName as '销售级别名称',
		sGroup.GroupName as '销售部门名称'
		FROM UserInfo [users]
		INNER JOIN RoleInfo [roles] ON [users].RoleID = [roles].RoleID
		LEFT JOIN SaleLevel sLevel ON [users].LevelID = sLevel.ID
		LEFT JOIN SaleGroup sGroup ON [users].GroupID = sGroup.GroupID
		WHERE 
			((UserID like '%' + @id + '%') or (@id is null))
			AND ((UserName like '%' + @name + '%') OR (@name is null))
			AND [users].GroupID = @saleGroup
			AND ((UserGender = @gender) or (@gender = '') or (@gender is null))
			AND ((EntryTime BETWEEN @entryTimeStart AND @entryTimeEnd) OR (@entryTimeStart = '') OR (@entryTimeStart is null) OR (@entryTimeEnd = '') OR (@entryTimeEnd is null));
	END
	ELSE
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
		sLevel.LevelName as '销售级别名称',
		sGroup.GroupName as '销售部门名称'
		FROM UserInfo [users]
		INNER JOIN RoleInfo [roles] ON [users].RoleID = [roles].RoleID
		LEFT JOIN SaleLevel sLevel ON [users].LevelID = sLevel.ID
		LEFT JOIN SaleGroup sGroup ON [users].GroupID = sGroup.GroupID
		WHERE 
			((UserID like '%' + @id + '%') or (@id is null))
			AND ((UserName like '%' + @name + '%') OR (@name is null))
			AND ((RoleName = @role) or (@role is null))
			AND ((UserGender = @gender) or (@gender = '') or (@gender is null))
			AND ((EntryTime BETWEEN @entryTimeStart AND @entryTimeEnd) OR (@entryTimeStart = '') OR (@entryTimeStart is null) OR (@entryTimeEnd = '') OR (@entryTimeEnd is null));
	END
END
GO

select GETDATE();

execute pro_getUsers null,null,'管理员',null,null,null

SELECT * FROM UserInfo
SELECT * FROM RoleInfo
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




