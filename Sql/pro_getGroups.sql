USE CustomerSeller
GO
IF OBJECT_ID ( 'pro_getGroups', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getGroups;
GO
CREATE PROCEDURE pro_getGroups
	@name NVARCHAR(50)
AS
BEGIN
	SELECT sg.GroupID AS '销售部门编号',
	sg.GroupName  AS '销售部门名称'
	 FROM SaleGroup sg WHERE (sg.GroupName like '%' + @name + '%') or (@name is null)
END



SELECT * FROM SaleGroup
INSERT INTO SaleGroup values ('001','001');
INSERT INTO SaleGroup values ('002','002');
exec pro_getGroups '1'