/****** Object:  Table [dbo].[school_score_cat]    Script Date: 02/03/2011 16:12:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_score_cat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_score_cat](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_school_score_cat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (0, N'نمرات اصلی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (1, N'کتبی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (2, N'شفاهی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (3, N'عملی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (4, N'تستی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (5, N'تستی تشریحی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (6, N'کتبی و شفاهی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (7, N'آزمون علمی')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (8, N'نظر دبیر')
INSERT [dbo].[school_score_cat] ([id], [title]) VALUES (9, N'نمره تمرینات کلاسی')
