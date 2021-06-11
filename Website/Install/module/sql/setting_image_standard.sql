/****** Object:  Table [dbo].[setting_image_standard]    Script Date: 07/27/2010 13:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[setting_image_standard]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[setting_image_standard](
	[id] [int] NOT NULL,
	[height] [nvarchar](50)  NULL,
	[Width] [nvarchar](50)  NULL,
 CONSTRAINT [PK_setting_image_standard] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (1, N'Free', N'Free')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (2, N'80', N'223')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (3, N'78', N'78')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (4, N'70', N'70')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (5, N'100', N'100')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (6, N'150', N'150')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (7, N'107', N'446')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (8, N'120', N'120')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (9, N'763', N'188')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (10, N'213', N'153')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (11, N'97', N'147')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (12, N'150', N'250')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (13, N'210', N'160')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (14, N'150', N'200')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (15, N'160', N'145')
INSERT [dbo].[setting_image_standard] ([id], [height], [Width]) VALUES (16, N'95', N'169')