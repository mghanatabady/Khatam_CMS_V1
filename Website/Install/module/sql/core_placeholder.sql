/****** Object:  Table [dbo].[core_placeholder]    Script Date: 04/06/2011 15:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[core_placeholder]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[core_placeholder](
	[id] [int] NOT NULL,
	[title] [nvarchar](50)  NULL,
 CONSTRAINT [PK_core_placeholder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (1, N'PH_header')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (2, N'PH_content')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (3, N'PH_NAVIGATION')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (4, N'PH_ufrist')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (5, N'PH_u')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (6, N'PH_content2')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (7, N'ph_beforeft')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (8, N'PH_Footer')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (9, N'PH_exFooter')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (10, N'PH_first_script')
INSERT [dbo].[core_placeholder] ([id], [title]) VALUES (11, N'PH_exheader')


