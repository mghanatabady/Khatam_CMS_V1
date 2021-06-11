/****** Object:  Table [dbo].[school_Lesson_Present_Cat]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Lesson_Present_Cat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Lesson_Present_Cat](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_Lesson_Present_Cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[school_Lesson_Present_Cat] ([id], [title]) VALUES (1, N'عملی')
INSERT [dbo].[school_Lesson_Present_Cat] ([id], [title]) VALUES (2, N'نظری')
INSERT [dbo].[school_Lesson_Present_Cat] ([id], [title]) VALUES (3, N'نظری عملی')