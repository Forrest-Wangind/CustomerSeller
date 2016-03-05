use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getUserPermissions', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getUserPermissions;
GO
CREATE PROCEDURE pro_getUserPermissions
	@id varchar(50)
AS
BEGIN
	SELECT func.FunctionID, func.FunctionName FROM UserInfo [user]
		inner join RelationInfo relation ON relation.RoleID = [user].RoleID
		inner join FunctionInfo func ON func.FunctionID = relation.FunctionID
	where[user].UserID = @id
END

execute pro_getUserPermissions 'T04471'

SELECT func.FunctionID, func.FunctionName from UserInfo [user]
				inner join RelationInfo relation on relation.RoleID = [user].RoleID
				inner join FunctionInfo func on func.FunctionID = relation.FunctionID
				where[user].UserID = 'T04471'