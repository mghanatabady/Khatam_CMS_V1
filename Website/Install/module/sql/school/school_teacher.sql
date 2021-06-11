/****** Object:  Table [dbo].[school_Teacher]    Script Date: 08/05/2010 08:18:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Teacher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Teacher](
	[id] [nvarchar](20) COLLATE Arabic_CI_AS NOT NULL,
	[Fname] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Lname] [nvarchar](80) COLLATE Arabic_CI_AS NULL,
	[password] [nvarchar](30) COLLATE Arabic_CI_AS NULL,
	[page] [bit] NULL,
	[enable] [bit] NULL,
	[email] [nvarchar](120) COLLATE Arabic_CI_AS NULL,
	[mobile] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[id_language] [int] NULL,
 CONSTRAINT [PK_school_teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO