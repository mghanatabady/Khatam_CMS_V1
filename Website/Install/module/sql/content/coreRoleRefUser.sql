/****** Object:  Table [dbo].[coreRoleRefUser]    Script Date: 06/25/2011 16:05:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[coreRoleRefUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[coreRoleRefUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idRole] [int] NULL,
	[idUser] [int] NULL,
 CONSTRAINT [PK_coreRoleRefUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO