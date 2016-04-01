use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getRoleDetail', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getRoleDetail;
GO
CREATE PROCEDURE pro_getRoleDetail

	@id nvarchar(50)
AS
BEGIN
	SELECT * FROM RoleInfo
	WHERE 
		RoleID = @id
END


execute pro_getRoleDetail '001'