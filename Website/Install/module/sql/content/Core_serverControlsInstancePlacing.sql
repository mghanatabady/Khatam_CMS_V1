/****** Object:  Table [dbo].[Core_serverControlsInstancePlacing]    Script Date: 04/06/2011 15:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Core_serverControlsInstancePlacing]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Core_serverControlsInstancePlacing](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_setting_section] [int] NULL,
	[id_setting_placeholder] [int] NULL,
	[id_core_serverControlInstance] [int] NULL,
 CONSTRAINT [PK_Core_placeholder_ref_section] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END

ALTER TABLE Core_serverControlsInstancePlacing
 ADD idLanguage  int;