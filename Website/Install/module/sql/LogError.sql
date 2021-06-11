/****** Object:  Table [dbo].[LogError]    Script Date: 09/01/2011 23:06:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogError](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[memo] [nvarchar](max) NULL,
	[datetime] [datetime] NULL,
 CONSTRAINT [PK_LogError] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
