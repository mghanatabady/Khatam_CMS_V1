/****** Object:  Table [dbo].[school_Classroom_select]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Classroom_select]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Classroom_select](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[school_class_id] [int] NULL,
	[school_lesson_id] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[school_teacher_id] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_Classroom_select] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO