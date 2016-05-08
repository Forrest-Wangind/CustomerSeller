USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[RoleInfo]    Script Date: 2016/5/8 11:33:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RoleInfo](
	[RoleID] [nvarchar](50) NOT NULL,
	[RoleName] [nvarchar](20) NULL,
	[RoleRemark] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


