use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getRoleFunctions', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getRoleFunctions;
GO
CREATE PROCEDURE pro_getRoleFunctions
	@id NVARCHAR(50)
AS
BEGIN
	--get all functions
	SELECT FunctionID as 'id', FunctionName as 'name', FunctionRemark as 'remark' FROM FunctionInfo;

	IF(@id is not null AND @id != '')
	BEGIN
		SELECT fun.FunctionID as 'id', fun.FunctionName as 'name', fun.FunctionRemark as 'remark' FROM FunctionInfo fun
			inner join RelationInfo relation on fun.FunctionID = relation.FunctionID
		WHERE relation.RoleID = @id
	END
END

select * from RoleInfo
select * from RelationInfo
select * from FunctionInfo
execute pro_getRoleFunctions '001'