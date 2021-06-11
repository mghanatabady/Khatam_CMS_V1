/****** Object:  Table [dbo].[Core_serverControlsInstance]    Script Date: 04/06/2011 15:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Core_serverControlsInstance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Core_serverControlsInstance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_core_serverControl] [int] NULL,
 CONSTRAINT [PK_Core_ServerControlsInstance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END

ALTER TABLE [dbo].[Core_serverControlsInstance] ADD [title] nvarchar(50) NULL
