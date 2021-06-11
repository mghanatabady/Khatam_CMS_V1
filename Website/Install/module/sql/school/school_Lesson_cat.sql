/****** Object:  Table [dbo].[school_Lesson_cat]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Lesson_cat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Lesson_cat](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_Lasson_cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[school_Lesson_cat] ([id], [title]) VALUES (1, N'عمومی')
INSERT [dbo].[school_Lesson_cat] ([id], [title]) VALUES (2, N'انتخابی')
INSERT [dbo].[school_Lesson_cat] ([id], [title]) VALUES (3, N'پایه')
INSERT [dbo].[school_Lesson_cat] ([id], [title]) VALUES (4, N'اصلی')
INSERT [dbo].[school_Lesson_cat] ([id], [title]) VALUES (5, N'اختصاصی')
INSERT [dbo].[school_Lesson_cat] ([id], [title]) VALUES (6, N'اختصاصی کاردانش')
INSERT [dbo].[school_Lesson_cat] ([id], [title]) VALUES (7, N'اصلی کاردانش')