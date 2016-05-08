USE [CustomerSeller]
GO

/****** Object:  Table [dbo].[RelationInfo]    Script Date: 2016/5/8 11:33:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RelationInfo](
	[RelationID] [nvarchar](50) NOT NULL,
	[RoleID] [nvarchar](50) NULL,
	[FunctionID] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RelationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[RelationInfo]  WITH CHECK ADD FOREIGN KEY([FunctionID])
REFERENCES [dbo].[FunctionInfo] ([FunctionID])
GO

ALTER TABLE [dbo].[RelationInfo]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[RoleInfo] ([RoleID])
GO


