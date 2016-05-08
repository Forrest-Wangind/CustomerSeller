USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 2016/5/8 11:34:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CustomerInfo](
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
 CONSTRAINT [PK__Customer__A4AE64B805B325B4] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[CustomerInfo] ADD  DEFAULT (NULL) FOR [AllocateTime]
GO


