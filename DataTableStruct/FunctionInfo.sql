USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[FunctionInfo]    Script Date: 2016/5/8 11:33:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FunctionInfo](
	[FunctionID] [nvarchar](50) NOT NULL,
	[FunctionName] [nvarchar](50) NULL,
	[FunctionRemark] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[FunctionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


