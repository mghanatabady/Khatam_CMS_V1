/****** Object:  Table [dbo].[school_Category]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_school_branch] [int] NULL,
	[title] [nvarchar](120) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO