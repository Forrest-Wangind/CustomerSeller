use CustomerSeller
GO
IF OBJECT_ID ( 'pro_getSingleUser', 'P' ) IS NOT NULL
    DROP PROCEDURE pro_getSingleUser;
GO
CREATE PROCEDURE pro_getSingleUser
	@id varchar(50)
AS
BEGIN
	SELECT ui.UserID, ui.UserName,ui.[Password],ui.UserGender,ui.RoleID,ui.Exten,ui.EntryTime,ui.LevelID FROM UserInfo ui
	WHERE 
		UserID = @id
END


execute pro_getSingleUser T04475

SELECT TOP {0} [CustomerID],RowNumber 序号,[CustomerName] 客户姓名,[CustomerGender] 客户性别,CustomerPhone 客户的电话,[PhoneStratus] 电话的状态, 
                                             [CreateTime] 创建时间,[DealTime] 成交时间 FROM (
                                             SELECT ROW_NUMBER() OVER (ORDER BY CustomerID) AS RowNumber,[CustomerID],[CustomerName],[CustomerGender],STUFF([CustomerPhone],4,5,'*****') as CustomerPhone,[CustomerAddress],[PhoneStratus],[CreateTime],[DealTime]
		                                     FROM CustomerInfo where 1=1 {2} ) A WHERE RowNumber > {0}*({1}-1)