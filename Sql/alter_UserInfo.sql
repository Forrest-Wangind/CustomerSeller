USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[UserInfo]    Script Date: 2016/6/10 10:19:04 ******/

SET QUOTED_IDENTIFIER ON
GO

ALTER TABLE [dbo].[UserInfo] ADD GroupID [nvarchar](50)

SELECT * FROM UserInfo
UPDATE UserInfo SET UserStatus = 0 WHERE UserID = 'T04471'