/****** Object:  Table [dbo].[school_Student]    Script Date: 08/05/2010 08:18:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Student]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Student](
	[id] [nvarchar](20) COLLATE Arabic_CI_AS NOT NULL,
	[school_base_id] [int] NULL,
	[school_class_id] [int] NULL,
	[id_category] [nvarchar](30) COLLATE Arabic_CI_AS NULL,
	[national_code] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[Fname] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Lname] [nvarchar](60) COLLATE Arabic_CI_AS NULL,
	[fathername] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[shsh] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[shsh_sn] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[shregplace] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[birthday] [datetime] NULL,
	[ppassword] [nvarchar](30) COLLATE Arabic_CI_AS NULL,
	[password] [nvarchar](30) COLLATE Arabic_CI_AS NULL,
	[groupid] [int] NULL,
	[tel] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Mobile] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[pMobile] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[pic] [nvarchar](120) COLLATE Arabic_CI_AS NULL,
	[Email] [nvarchar](80) COLLATE Arabic_CI_AS NULL,
	[pemail] [nvarchar](80) COLLATE Arabic_CI_AS NULL,
	[enable] [bit] NULL,
	[Address] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[postal_code] [nvarchar](20) COLLATE Arabic_CI_AS NULL,
	[system_type] [smallint] NULL,
	[Vazife_status] [smallint] NULL,
	[marriage_status] [smallint] NULL,
	[Average_guidance_school] [numeric](18, 2) NULL,
	[id_language] [int] NULL,
 CONSTRAINT [PK_school_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO