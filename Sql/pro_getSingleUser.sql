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

SELECT TOP {0} [CustomerID],RowNumber ���,[CustomerName] �ͻ�����,[CustomerGender] �ͻ��Ա�,CustomerPhone �ͻ��ĵ绰,[PhoneStratus] �绰��״̬, 
                                             [CreateTime] ����ʱ��,[DealTime] �ɽ�ʱ�� FROM (
                                             SELECT ROW_NUMBER() OVER (ORDER BY CustomerID) AS RowNumber,[CustomerID],[CustomerName],[CustomerGender],STUFF([CustomerPhone],4,5,'*****') as CustomerPhone,[CustomerAddress],[PhoneStratus],[CreateTime],[DealTime]
		                                     FROM CustomerInfo where 1=1 {2} ) A WHERE RowNumber > {0}*({1}-1)