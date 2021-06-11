/****** Object:  Table [dbo].[school_branch]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_branch]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_branch](
	[id] [int] NOT NULL,
	[title] [nvarchar](120) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_branch] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[school_branch] ([id], [title]) VALUES (1, N'دبستان')
INSERT [dbo].[school_branch] ([id], [title]) VALUES (2, N'راهنمایی')
INSERT [dbo].[school_branch] ([id], [title]) VALUES (3, N'نظری')
INSERT [dbo].[school_branch] ([id], [title]) VALUES (4, N'فنی و حرفه ای')
INSERT [dbo].[school_branch] ([id], [title]) VALUES (5, N'کاردانش')
INSERT [dbo].[school_branch] ([id], [title]) VALUES (6, N'عمومی دبیرستان')
INSERT [dbo].[school_branch] ([id], [title]) VALUES (7, N'پیش  دانشگاهی')