/****** Object:  Table [dbo].[school_form_registration_request]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_form_registration_request]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_form_registration_request](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[national_code] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[Fname] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Lname] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[shsh] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[shregplace] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[birthday] [datetime] NULL,
	[base] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[section] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[branch] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[current_school_type] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[current_school_name] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[current_school_address] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[current_avrage] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[current_math_score] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[current_discipline_Score] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[father_fnmae] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[father_age] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[father_job] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[father_Education_grade] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[father_mobile] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[father_job_tel] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[father_email] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[mother_job] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[mother_Education_grade] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_form_registration_request_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO