/****** Object:  Table [dbo].[Core_serverControlsInstanceVal]    Script Date: 04/06/2011 15:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Core_serverControlsInstanceVal]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Core_serverControlsInstanceVal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Core_ServerControlsInstance] [int] NULL,
	[propertyTitle] [nvarchar](50)  NULL,
	[propertyValue] [nvarchar](max)  NULL,
	[propertytype] [nvarchar](50)  NULL,
	[language] [int] NULL,
 CONSTRAINT [PK_Core_ServerControlsVal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
