/****** Object:  Table [dbo].[school_Class]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Class]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Class](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_school_base] [int] NULL,
	[id_school_year] [smallint] NULL,
	[title] [nvarchar](120) COLLATE Arabic_CI_AS NULL,
	[description] [nvarchar](300) COLLATE Arabic_CI_AS NULL,
	[page] [nvarchar](max) COLLATE Arabic_CI_AS NULL,
	[image] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
	[enable] [bit] NULL,
	[keywords] [nvarchar](120) COLLATE Arabic_CI_AS NULL,
	[Capacity] [int] NULL,
	[Address] [nvarchar](255) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_Class] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO