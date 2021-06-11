/****** Object:  Table [dbo].[school_Score]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Score]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Score](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[value] [numeric](18, 2) NULL,
	[score_cat_id] [int] NULL,
	[score_type_type] [int] NULL,
	[classroom_select] [int] NULL,
	[student_id] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[school_course_personal] [int] NULL,
 CONSTRAINT [PK_school_Score] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
/******-----*/
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'school_Score' AND COLUMN_NAME = 'title')
BEGIN
  ALTER TABLE [dbo].[school_Score] ADD title [nvarchar](80) NULL
END
GO
/******-----*/
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'school_Score' AND COLUMN_NAME = 'ExamDate')
BEGIN
  ALTER TABLE [dbo].[school_Score] ADD ExamDate datetime NULL
END
GO
/******-----*/
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'school_Score' AND COLUMN_NAME = 'baseOfScore')
BEGIN
  ALTER TABLE [dbo].[school_Score] ADD baseOfScore numeric(18, 2) NULL
END
GO