/****** Object:  Table [dbo].[school_base_cat]    Script Date: 08/05/2010 09:46:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_base_cat]') AND type in (N'U'))
DROP TABLE [dbo].[school_base_cat]
GO
/****** Object:  Table [dbo].[school_base_cat]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_base_cat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_base_cat](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_base_cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[school_base_cat] ([id], [title]) VALUES (1, N'اول')
INSERT [dbo].[school_base_cat] ([id], [title]) VALUES (2, N'دوم')
INSERT [dbo].[school_base_cat] ([id], [title]) VALUES (3, N'سوم')
INSERT [dbo].[school_base_cat] ([id], [title]) VALUES (4, N'چهارم')
INSERT [dbo].[school_base_cat] ([id], [title]) VALUES (5, N'پنجم')
