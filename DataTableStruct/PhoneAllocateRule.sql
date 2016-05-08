USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[PhoneAllocateRule]    Script Date: 2016/5/8 11:33:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PhoneAllocateRule](
	[ID] [uniqueidentifier] NOT NULL,
	[PhoneType] [varchar](20) NULL,
	[MaxNumber] [int] NULL,
	[DailyNumber] [int] NULL,
	[LevelID] [uniqueidentifier] NULL,
	[Remark] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[PhoneAllocateRule]  WITH CHECK ADD FOREIGN KEY([LevelID])
REFERENCES [dbo].[SaleLevel] ([ID])
GO


