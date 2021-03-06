USE [CustomerSeller]
GO
/****** Object:  Table [dbo].[SaleGroup]    Script Date: 2016/6/19 13:37:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleGroup](
	[GroupID] [nvarchar](50) NOT NULL,
	[GroupName] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
