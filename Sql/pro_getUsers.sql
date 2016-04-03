use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getUsers', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getUsers;
GO
CREATE PROCEDURE pro_getUsers
	@id nvarchar(50),
	@name nvarchar(20),
	@gender nvarchar(20),
	@entryTimeStart datetime,
	@entryTimeEnd datetime
AS
BEGIN
	SELECT UserID as '用户编号',
	UserName as '姓名',
	'性别'=
	CASE
		WHEN UserGender = 'm' THEN '男'
		WHEN UserGender = 'f' THEN '女'
		ELSE '未知'
	END,
	EntryTime as '入职时间',
	Exten as '分机号'
	FROM UserInfo
	WHERE 
		((UserID like '%' + @id + '%') or (@id is null))
		AND ((UserName like '%' + @name + '%') or (UserName is null))
		AND ((UserGender = @gender) or (@gender = ''))
		AND ((EntryTime BETWEEN @entryTimeStart AND @entryTimeEnd) OR (@entryTimeStart = '') OR (@entryTimeEnd = '')) 
END

select GETDATE();

execute pro_getUsers '','','','',''

SELECT * FROM UserInfo

