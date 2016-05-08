USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[SaleLevel]    Script Date: 2016/5/8 11:32:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SaleLevel](
	[ID] [uniqueidentifier] NOT NULL,
	[LevelName] [nvarchar](50) NULL,
	[Remark] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


