USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[DeletedCustomerInfo]    Script Date: 2016/6/19 16:56:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DeletedCustomerInfo](
	[CustomerID] [uniqueidentifier] NOT NULL,
	[CustomerGender] [nvarchar](20) NULL,
	[CustomerPhone] [nvarchar](20) NULL,
	[CustomerAddress] [nvarchar](20) NULL,
	[Remark] [nvarchar](500) NULL,
	[PhoneStratus] [nvarchar](20) NULL,
	[CreateTime] [nvarchar](20) NULL,
	[EmployeeID] [nvarchar](20) NULL,
	[DealTime] [nvarchar](20) NULL,
	[RecycleTime] [nvarchar](20) NULL,
	[CustomerName] [nchar](20) NULL,
	[AllocateTime] [datetime] NULL,
	[PhoneType] [varchar](10) NULL,
	[DeleteTime] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


