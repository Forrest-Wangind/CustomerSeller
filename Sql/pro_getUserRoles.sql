use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getUserRoles', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getUserRoles;
GO
CREATE PROCEDURE pro_getUserRoles
	@id varchar(50)
AS
BEGIN
	--get all roles
	SELECT RoleID as 'id', RoleName as 'name', RoleRemark as 'remark' FROM RoleInfo;

	IF(@id is not null AND @id != '')
	BEGIN
		SELECT [role].RoleID as 'id', [role].RoleName as 'name', [role].RoleRemark as 'remark' FROM RoleInfo [role]
			inner join UserInfo [user] on [user].RoleID = [role].RoleID
		WHERE [user].UserID = @id
	END
END

exec pro_getUserRoles 'T04471'

select * from UserInfo