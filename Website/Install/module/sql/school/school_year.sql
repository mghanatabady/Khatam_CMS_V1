/****** Object:  Table [dbo].[school_Year]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Year]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Year](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[year1] [nvarchar](10) COLLATE Arabic_CI_AS NOT NULL,
	[year2] [nvarchar](10) COLLATE Arabic_CI_AS NULL,
	[Enable] [bit] NULL,
 CONSTRAINT [PK_school_Year_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
SET IDENTITY_INSERT [dbo].[school_Year] ON
INSERT [dbo].[school_Year] ([id], [year1], [year2], [Enable]) VALUES (1, N'1387', N'1388', 1)
INSERT [dbo].[school_Year] ([id], [year1], [year2], [Enable]) VALUES (2, N'1388', N'1389', 1)
INSERT [dbo].[school_Year] ([id], [year1], [year2], [Enable]) VALUES (3, N'1389', N'1390', 1)
INSERT [dbo].[school_Year] ([id], [year1], [year2], [Enable]) VALUES (4, N'1390', N'1391', 1)
INSERT [dbo].[school_Year] ([id], [year1], [year2], [Enable]) VALUES (5, N'1391', N'1392', 1)
INSERT [dbo].[school_Year] ([id], [year1], [year2], [Enable]) VALUES (5, N'1392', N'1393', 1)
SET IDENTITY_INSERT [dbo].[school_Year] OFF