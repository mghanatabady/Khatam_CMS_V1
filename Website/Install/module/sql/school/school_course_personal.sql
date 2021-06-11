/****** Object:  Table [dbo].[school_course_personal]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_course_personal]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_course_personal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[school_educational_place_id] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[school_teacher_id] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[school_lesson_id] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[school_year_id] [int] NULL,
 CONSTRAINT [PK_school_course_personal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO