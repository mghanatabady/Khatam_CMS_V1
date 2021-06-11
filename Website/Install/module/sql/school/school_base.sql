/****** Object:  Table [dbo].[school_Base]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_base]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_base](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_school_category] [int] NULL,
	[year_number] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[system_number] [smallint] NULL,
 CONSTRAINT [PK_school_Base] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO