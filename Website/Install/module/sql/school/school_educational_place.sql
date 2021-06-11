﻿/****** Object:  Table [dbo].[school_educational_place]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_educational_place]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_educational_place](
	[id] [nvarchar](20) COLLATE Arabic_CI_AS NOT NULL,
	[title] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_school_educational_place_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[school_educational_place] ([id], [title]) VALUES (N'999', N'غیر حضوری')
