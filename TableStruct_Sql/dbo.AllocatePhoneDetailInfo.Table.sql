USE [CustomerSeller]
GO
/****** Object:  Table [dbo].[AllocatePhoneDetailInfo]    Script Date: 2016/6/19 13:37:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AllocatePhoneDetailInfo](
	[AllocatePhoneDetailID] [uniqueidentifier] NULL,
	[PhoneType] [varchar](10) NULL,
	[DailyCount] [int] NULL,
	[TotalCount] [int] NULL,
	[UserID] [nvarchar](50) NULL,
	[AllocateTime] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
