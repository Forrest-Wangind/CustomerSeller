USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[UserInfo]    Script Date: 2016/5/8 11:31:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserInfo](
	[UserID] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](20) NULL,
	[UserGender] [nvarchar](20) NULL,
	[RoleID] [nvarchar](50) NULL,
	[EntryTime] [datetime] NULL,
	[UserStatus] [int] NULL,
	[Password] [nvarchar](50) NULL,
	[allocateTime] [datetime] NULL,
	[allocateCount] [int] NULL,
	[totalCount] [int] NULL,
	[Exten] [nvarchar](20) NULL,
	[LevelID] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[UserInfo] ADD  DEFAULT ((0)) FOR [totalCount]
GO

ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[RoleInfo] ([RoleID])
GO


