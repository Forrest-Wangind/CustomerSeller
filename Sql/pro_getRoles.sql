use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getRoles', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getRoles;
GO
CREATE PROCEDURE pro_getRoles
	@id nvarchar(50),
	@name nvarchar(20),
	@remark nvarchar(1000)
AS
BEGIN
	SELECT * FROM RoleInfo
	WHERE 
		((RoleID like '%' + @id + '%') or (@id is null))
		AND ((RoleName like '%' + @name + '%') or (@name is null))
		AND ((RoleRemark like '%' + @remark + '%') or (@remark is null))
END

exec pro_getRoles¡¡NULL,'admins',NULL

select * from UserInfo
select * from RoleInfo
alter table RoleInfo alter column RoleRemark nvarchar(1000) null