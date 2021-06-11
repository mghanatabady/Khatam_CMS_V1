/****** Object:  Table [dbo].[corePermission]    Script Date: 04/24/2011 12:20:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[corePermission]') AND type in (N'U'))
DROP TABLE [dbo].[corePermission]
GO
/****** Object:  Table [dbo].[corePermission]    Script Date: 04/24/2011 12:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[corePermission]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[corePermission](
	[id] [int] NOT NULL,
	[title] [nvarchar](50)  NOT NULL,
	[IdDictionary] [int] NULL,
	[parentID] [int] NULL,
	[haveIcon] [bit] NULL,
	[IconPath] [nvarchar](50) NULL,
	[IconGroup] [smallint] NULL,
	[idmodule] [int] NULL,
 CONSTRAINT [PK_core_permisson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (1, N'accessVisualContentManager', 106, 0, NULL, NULL, NULL, 1)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (2, N'accessLayoutManager', 107, 0, NULL, NULL, NULL, 1)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (3, N'article', 7, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (4, N'articleAccessALL', 131, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (6, N'articleInsert', 132, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (11, N'articleFolderInsert', 133, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (12, N'articleFolderEdit', 134, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (13, N'articleFolderMove', 135, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (15, N'articleFolderDelete', 136, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (16, N'articleMove', 137, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (18, N'articleValidationALL', 138, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (19, N'articleValidationOwn', 139, 0, NULL, NULL, NULL, 2)




INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (20, N'update', 108, 0, 1, N'update.gif', 5, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (21, N'baseSetting', 109, 0, 1, N'Setting.gif', 5, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (22, N'objects', 110, 0, 1, N'site_explorer.gif', 5, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (23, N'module', 111, 0, 1, N'site_explorer.gif', 5, 1)
/*INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (24, N'runsql', 112, 0, 1, N'sql.gif', 5, 1)*/
DELETE FROM         corePermission WHERE     (id = 24)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (25, N'ManagerUsers', 113, 0, 1, N'icon_user.jpg', 5, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (26, N'ManageUsersGroups', 114, 0, 1, N'icon_lesson_group.gif', 5, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (27, N'theme', 115, 0, 1, N'theme.gif', 5, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (28, N'language', 116, 0, 1, N'language.gif', 5, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (29, N'backup', 117, 0, 1, N'backup-icon.gif', 5, 1)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (30, N'menu', 38, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (31, N'menuAccessALL', 145, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (33, N'menuInsert', 146, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (38, N'menuFolderInsert', 147, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (39, N'menuFolderEdit', 148, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (40, N'menuFolderMove', 149, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (42, N'menuFolderDelete', 150, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (43, N'menuMove', 151, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (45, N'menuValidationALL', 152, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (46, N'menuValidationOwn', 153, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (47, N'news', 8, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (48, N'newsAccessALL', 159, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (50, N'newsInsert', 160, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (55, N'newsFolderInsert', 161, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (56, N'newsFolderEdit', 162, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (57, N'newsFolderMove', 163, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (59, N'newsFolderDelete', 164, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (60, N'newsMove', 165, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (62, N'newsValidationALL', 166, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (63, N'newsValidationOwn', 167, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (64, N'picture', 37, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (65, N'pictureAccessALL', 173, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (67, N'pictureInsert', 174, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (72, N'pictureFolderInsert', 175, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (73, N'pictureFolderEdit', 176, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (74, N'pictureFolderMove', 177, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (76, N'pictureFolderDelete', 178, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (77, N'pictureMove', 179, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (79, N'pictureValidationALL', 180, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (80, N'pictureValidationOwn', 181, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (81, N'special_pages', 33, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (82, N'special_pagesAccessALL', 187, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (84, N'special_pagesInsert', 188, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (89, N'special_pagesFolderInsert', 189, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (90, N'special_pagesFolderEdit', 190, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (91, N'special_pagesFolderMove', 191, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (93, N'special_pagesFolderDelete', 192, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (94, N'special_pagesMove', 193, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (96, N'special_pagesValidationALL', 194, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (97, N'special_pagesValidationOwn', 195, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (98, N'service', 2, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (99, N'serviceAccessALL', 201, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (101, N'serviceInsert', 202, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (106, N'serviceFolderInsert', 203, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (107, N'serviceFolderEdit', 204, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (108, N'serviceFolderMove', 205, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (110, N'serviceFolderDelete', 206, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (111, N'serviceMove', 207, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (113, N'serviceValidationALL', 208, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (114, N'serviceValidationOwn', 209, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (115, N'shop', 13, 0, 1, N'ICON_CONTENT.gif', 3, 2)
UPDATE    corePermission      SET              IconGroup = 1    WHERE     (id = 115)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (116, N'shopAccessALL', 215, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (118, N'shopInsert', 216, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (123, N'shopFolderInsert', 217, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (124, N'shopFolderEdit', 218, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (125, N'shopFolderMove', 219, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (127, N'shopFolderDelete', 220, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (128, N'shopMove', 221, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (130, N'shopValidationALL', 222, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (131, N'shopValidationOwn', 223, 0, NULL, NULL, NULL, 2)



INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (132, N'email', 12, 0, 1, N'ICON_Message.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (133, N'webstats', 14, 0, 1, N'title.gif', 4, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (134, N'software', 35, 0, 1, N'ICON_CONTENT.gif', 1, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (135, N'softwareAccessALL', 229, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (136, N'softwareInsert', 230, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (141, N'softwareFolderInsert', 231, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (142, N'softwareFolderEdit', 232, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (143, N'softwareFolderMove', 233, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (145, N'softwareFolderDelete', 234, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (146, N'softwareMove', 235, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (148, N'softwareValidationALL', 236, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (149, N'softwareValidationOwn', 237, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (150, N'help', 49, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (151, N'helpAccessALL', 243, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (153, N'helpInsert', 244, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (158, N'helpFolderInsert', 245, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (159, N'helpFolderEdit', 246, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (160, N'helpFolderMove', 247, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (162, N'helpFolderDelete', 248, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (163, N'helpMove', 249, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (165, N'helpValidationALL', 250, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (166, N'helpValidationOwn', 251, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (167, N'portal', 62, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (168, N'portalAccessALL', 257, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (170, N'portalInsert', 258, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (175, N'portalFolderInsert', 259, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (176, N'portalFolderEdit', 260, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (177, N'portalFolderMove', 261, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (179, N'portalFolderDelete', 262, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (180, N'portalMove', 263, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (182, N'portalValidationALL', 264, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (183, N'portalValidationOwn', 265, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (184, N'host', 101, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (185, N'hostAccessALL', 271, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (187, N'hostInsert', 272, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (192, N'hostFolderInsert', 273, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (193, N'hostFolderEdit', 274, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (194, N'hostFolderMove', 275, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (196, N'hostFolderDelete', 276, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (197, N'hostMove', 277, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (199, N'hostValidationALL', 278, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (200, N'hostValidationOwn', 279, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (201, N'comment', 103, 0, 1, N'web_forms.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (202, N'commentAccessALL', NULL, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (203, N'commentAccessOwn', NULL, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (204, N'commentValid', NULL, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (205, N'commentDelete', NULL, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (206, N'articleVirtualDelete', 140, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (207, N'articleRealDelete', 141, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (208, N'articleChangeCat', 142, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (209, N'articleEdit', 143, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (210, N'articleUnDelete', 144, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (211, N'menuVirtualDelete', 154, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (212, N'menuRealDelete', 155, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (213, N'menuChangeCat', 156, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (214, N'menuEdit', 157, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (215, N'menuUnDelete', 158, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (216, N'newsVirtualDelete', 168, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (217, N'newsRealDelete', 169, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (218, N'newsChangeCat', 170, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (219, N'newsEdit', 171, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (220, N'newsUnDelete', 172, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (221, N'pictureVirtualDelete', 182, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (222, N'pictureRealDelete', 183, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (223, N'pictureChangeCat', 184, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (224, N'pictureEdit', 185, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (225, N'pictureUnDelete', 186, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (226, N'special_pagesVirtualDelete', 196, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (227, N'special_pagesRealDelete', 197, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (228, N'special_pagesChangeCat', 198, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (229, N'special_pagesEdit', 199, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (230, N'special_pagesUnDelete', 200, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (231, N'serviceVirtualDelete', 210, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (232, N'serviceRealDelete', 211, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (233, N'serviceChangeCat', 212, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (234, N'serviceEdit', 213, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (235, N'serviceUnDelete', 214, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (236, N'shopVirtualDelete', 224, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (237, N'shopRealDelete', 225, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (238, N'shopChangeCat', 226, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (239, N'shopEdit', 227, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (240, N'shopUnDelete', 228, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (241, N'softwareVirtualDelete', 238, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (242, N'softwareRealDelete', 239, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (243, N'softwareChangeCat', 240, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (244, N'softwareEdit', 241, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (245, N'softwareUnDelete', 242, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (246, N'helpVirtualDelete', 252, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (247, N'helpRealDelete', 253, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (248, N'helpChangeCat', 254, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (249, N'helpEdit', 255, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (250, N'helpUnDelete', 256, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (251, N'portalVirtualDelete', 266, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (252, N'portalRealDelete', 267, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (253, N'portalChangeCat', 268, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (254, N'portalEdit', 269, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (255, N'portalUnDelete', 270, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (256, N'hostVirtualDelete', 280, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (257, N'hostRealDelete', 281, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (258, N'hostChangeCat', 282, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (259, N'hostEdit', 283, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (260, N'hostUnDelete', 284, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (261, N'library', 34, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (262, N'libraryAccessALL', 285, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (263, N'libraryInsert', 286, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (264, N'libraryFolderInsert', 287, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (265, N'libraryFolderEdit', 288, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (266, N'libraryFolderMove', 289, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (267, N'libraryFolderDelete', 290, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (268, N'libraryMove',291 , 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (269, N'libraryValidationALL', 292, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (270, N'libraryValidationOwn', 293, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (271, N'libraryVirtualDelete',294, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (272, N'libraryRealDelete', 295, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (273, N'libraryChangeCat', 296, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (274, N'libraryEdit', 297, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (275, N'libraryUnDelete', 298, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (276, N'clip', 60, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (277, N'clipAccessALL', 299, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (278, N'clipInsert', 300, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (279, N'clipFolderInsert', 301, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (280, N'clipFolderEdit',302 , 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (281, N'clipFolderMove', 303, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (282, N'clipFolderDelete', 304, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (283, N'clipMove',305 , 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (284, N'clipValidationALL', 306, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (285, N'clipValidationOwn', 307, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (286, N'clipVirtualDelete',308, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (287, N'clipRealDelete', 309, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (288, N'clipChangeCat', 310, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (289, N'clipEdit', 311, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (290, N'clipUnDelete', 312, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (276, N'clip', 60, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (277, N'clipAccessALL', 299, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (278, N'clipInsert', 300, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (279, N'clipFolderInsert', 301, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (280, N'clipFolderEdit',302 , 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (281, N'clipFolderMove', 303, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (282, N'clipFolderDelete', 304, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (283, N'clipMove',305 , 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (284, N'clipValidationALL', 306, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (285, N'clipValidationOwn', 307, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (286, N'clipVirtualDelete',308, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (287, N'clipRealDelete', 309, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (288, N'clipChangeCat', 310, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (289, N'clipEdit', 311, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (290, N'clipUnDelete', 312, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (291, N'Link', 45, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (292, N'LinkAccessALL', 313, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (293, N'LinkInsert', 314, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (294, N'LinkFolderInsert', 315, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (295, N'LinkFolderEdit',316 , 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (296, N'LinkFolderMove', 317, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (297, N'LinkFolderDelete', 318, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (298, N'LinkMove',319 , 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (299, N'LinkValidationALL', 320, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (300, N'LinkValidationOwn', 321, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (301, N'LinkVirtualDelete',322, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (302, N'LinkRealDelete', 323, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (303, N'LinkChangeCat', 324, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (304, N'LinkEdit', 325, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (305, N'LinkUnDelete', 326, 0, NULL, NULL, NULL, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (306, N'libraryUploadDirectFile', 327, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (307, N'softwareUploadDirectFile', 328, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (308, N'clipUploadDirectFile', 329, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (309, N'pictureUploadDirectFile', 330, 0, NULL, NULL, NULL, 2)

/*School*/ 
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (310, N'school_year', 16, 0, 1, N'title_settings.gif', 5, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (311, N'school_branch', 17, 0, 1, N'title_settings.gif', 5, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (312, N'school_category', 18, 0, 1, N'title_settings.gif', 5, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (313, N'school_base', 19, 0, 1, N'title_settings.gif', 5, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (314, N'school_class', 20, 0, 1, N'title_settings.gif', 5, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (315, N'school_educational_place', 55, 0, 1, N'title_settings.gif', 5, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (316, N'school_student', 21, 0, 1, N'icon_student.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (317, N'school_teacher', 22, 0, 1, N'icon_teacher.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (318, N'school_classroom_calendar', 23, 0, 1, N'icon_Selectunit.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (319, N'school_class_scheme', 24, 0, 1, N'icon_lesson_group.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (320, N'school_lesson', 26, 0, 1, N'icon_Lesson.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (321, N'school_course_personal', 56, 0, 1, N'icon_Lesson.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (322, N'school_course_personal_select', 57, 0, 1, N'icon_Selectunit.gif', 2, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (323, N'school_View_reportCard_linked_student', 368, 0, 1, N'reportCard.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (324, N'school_View_reportCard_All',369 , 0, 1, N'reportCard.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (325, N'school_View_ClassGrade_linked_student', 370, 0, 1, N'classGrade.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (326, N'school_View_ClassGrade_ALL', 371, 0, 1, N'classGrade.gif', 2, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (327, N'school_declaration_reportCard_teacher', 372, 0, 1, N'reportCard.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (328, N'school_declaration_reportCard_All',373, 0, 1, N'reportCard.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (329, N'school_declaration_ClassGrade_teacher', 374, 0, 1, N'classGrade.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (330, N'school_declaration_ClassGrade_All', 375, 0, 1, N'classGrade.gif', 2, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (331, N'school_manageParentChildLink', 376, 0, 1, N'parent.gif', 2, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (332, N'school_View_reportCard_linked_Parent', 377, 0, 1, N'reportCard.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (333, N'school_View_ClassGrade_linked_Parent', 378, 0, 1, N'classGrade.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (334, N'school_Parent', 379, 0, 1, N'parent.gif', 2, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (335, N'password_edit', 15, 0, 1, N'passwordEdit.gif', 5, 2)



INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (336, N'domain', 394, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (337, N'domainAccessALL', 380, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (338, N'domainInsert', 381, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (339, N'domainFolderInsert', 382, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (340, N'domainFolderEdit', 383, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (341, N'domainFolderMove', 384, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (342, N'domainFolderDelete', 385, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (343, N'domainMove', 386, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (344, N'domainValidationALL', 387, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (345, N'domainValidationOwn', 388, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (346, N'domainVirtualDelete', 389, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (347, N'domainRealDelete', 390, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (348, N'domainChangeCat', 391, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (349, N'domainEdit',392, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (350, N'domainUnDelete', 393, 0, NULL, NULL, NULL, 2) 

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (351, N'portals_list_orders', 396, 0, 1, N'cms.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (352, N'portals_my_orders', 397, 0, 1, N'cms.gif', 2, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (353, N'host_list_orders', 398, 0, 1, N'hard.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (354, N'host_my_orders', 399, 0, 1, N'hard.gif', 2, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (355, N'domain_list_orders',400, 0, 1, N'domain_name.gif', 2, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (356, N'domain_my_orders', 401, 0, 1, N'domain_name.gif', 2, 2)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (357, N'shop_trasactions_list',402, 0, 1, N'Commercial_catalog.gif', 3, 2)  DELETE FROM         corePermission WHERE     (id = 357)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (358, N'shop_my_trasactions', 403, 0, 1, N'Commercial_catalog.gif', 3, 2) DELETE FROM         corePermission WHERE     (id = 358)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (359, N'shop_invoices_list',404, 0, 1, N'invoice.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_invoices_list'  WHERE     (id = 359)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (360, N'shop_my_invoice', 405, 0, 1, N'invoice.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_my_invoice'  WHERE     (id = 360)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (361, N'shop_myOrder_renewal_management', 406, 0, 1, N'time_money.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_myOrder_renewal_management'  WHERE     (id = 361)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (362, N'shop_renewal_management_all', 407, 0, 1, N'time_money.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_renewal_management_all'  WHERE     (id = 362)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (363, N'shop_bank_Accounts', 408, 0, 1, N'account.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_bank_Accounts'  WHERE     (id = 363)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (364, N'shop_sendMode', 409, 0, 1, N'trasport.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_sendMode'  WHERE     (id = 364)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (365, N'shop_payMode', 410, 0, 1, N'epay.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_payMode'  WHERE     (id = 365)



INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (366, N'forms', 411, 0, 1, N'forms.gif', 2, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (367, N'shop_currency', 414, 0, 1, N'currency.gif', 3, 2) DELETE FROM         corePermission WHERE     (id = 367)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (368, N'shop_countrys', 415, 0, 1, N'countrys.gif', 3, 2) DELETE FROM         corePermission WHERE     (id = 368)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (369, N'profile', 419, 0, 1, N'profile.gif', 5, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (370, N'shop_trasactions_offline_all',886, 0, 1, N'Commercial_catalog.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_trasactions_offline_all'  WHERE     (id = 370)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (371, N'shop_trasactions_offline_my', 887, 0, 1, N'Commercial_catalog.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_trasactions_offline_my'  WHERE     (id = 371)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (372, N'shop_trasactions_online_all',888, 0, 1, N'Commercial_catalog.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_trasactions_online_all'  WHERE     (id = 372)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (373, N'shop_trasactions_online_my', 889, 0, 1, N'Commercial_catalog.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_trasactions_online_my'  WHERE     (id = 373)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (374, N'shop_settings', 890, 0, 1, N'shopcat_setting.gif', 3, 2)
UPDATE     [dbo].[corePermission]  SET              title = N'eshop_settings'  WHERE     (id = 374)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (375, N'sections', 894, 0, 1, N'section.gif', 5, 1)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (376, N'darman_cards_all', 897, 0, 1, N'profile.gif', 3, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (377, N'darman_cards_my', 898, 0, 1, N'profile.gif', 3, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (378, N'darman_cards_add', 899, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (379, N'darman_cards_manage', 900, 0, 1, N'profile.gif', 3, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (380, N'darman_cards_stats', 901, 0, 1, N'title.gif', 4, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (381, N'darman_cards_print', 902, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (382, N'uniproj_cluster_list_all', 906, 0, 1, N'cluster.gif', 2, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (383, N'uniproj_cluster_add_all', 907, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (384, N'uniproj_cluster_delete_all', 908, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (385, N'uniproj_cluster_edit_all', 909, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (386, N'uniproj_project_list_all', 910, 0, 1, N'uniProj.gif', 2, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (387, N'uniproj_project_Verfication_rd', 911, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (388, N'uniproj_project_delete_all', 912, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (389, N'uniproj_project_add_rd', 913, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (390, N'uniproj_project_edit_rd', 914, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (391, N'uniproj_project_del_request_rd', 915, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (392, N'uniproj_project_add_request', 916, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (393, N'uniproj_cluster_list_group', 917, 0, 1, N'cluster.gif', 2, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (394, N'uniproj_teacher_list_group', 918, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (395, N'uniproj_teacher_group_ProjLimit', 919, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (396, N'uniproj_project_list_group', 920, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (397, N'uniproj_project_GroupUserVerfication', 921, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (398, N'uniproj_project_delete_groupUser', 922, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (399, N'uniproj_project_list_student', 923, 0, 1, N'uniProj.gif', 2, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (400, N'uniproj_project_addRequest_student', 924, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (401, N'uniproj_project_delRequest_student', 925, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (402, N'uniproj_project_list_teacher', 926, 0, 1, N'uniProj.gif', 2, 1)
UPDATE     [dbo].[corePermission]  SET              [haveIcon] = 0,[IconPath] = N'',[IconGroup]=NULL  WHERE     (id = 402) 


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (403, N'uniproj_project_edit_teacher', 927, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (404, N'uniproj_project_delete_teacher_notSelected', 928, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (405, N'uniproj_project_edit_teacher', 929, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (406, N'uniproj_project_acceptRequest_teacher', 930, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (407, N'uniproj_project_add_teacher', 931, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (408, N'uniproj_cluster_list_teacher', 932, 0, 1, N'cluster.gif', 2, 1)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (409, N'uniproj_eduGrroup_list_all', 938, 0, 1, N'category.gif', 2, 1)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (410, N'uniproj_EduGroupRefUsers', 939, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (411, N'uniproj_cluster_student_all', 940, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (412, N'uniproj_cluster_student_import', 941, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (413, N'core_log', 942, 0, 1, N'icon_log.gif',4, 1)


INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (414, N'estate', 944, 0, 1, N'ICON_CONTENT.gif', 1, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (415, N'estateAccessALL', 945, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (416, N'estateInsert', 946, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (417, N'estateFolderInsert', 947, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (418, N'estateFolderEdit', 948, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (419, N'estateFolderMove', 949, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (420, N'estateFolderDelete', 950, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (421, N'estateMove', 951, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (422, N'estateValidationALL', 952, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (423, N'estateValidationOwn', 953, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (424, N'estateVirtualDelete', 954, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (425, N'estateRealDelete', 955, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (426, N'estateChangeCat', 956, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (427, N'estateEdit', 957, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (428, N'estateUnDelete', 958, 0, NULL, NULL, NULL, 2)







 


/*INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule])
 VALUES (383, N'uniproj_project_list', 907, 0, 1, N'uniProj.gif', 2, 1)



INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (383, N'uniproj_add_cluster', 902, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (383, N'uniproj_update_cluster', 902, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (383, N'uniproj_delete_cluster', 902, 0, NULL, NULL, NULL, 2)
INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (383, N'uniproj_Update_ResearchDepartementVerfication', 902, 0, NULL, NULL, NULL, 2)

INSERT [dbo].[corePermission] ([id], [title], [IdDictionary], [parentID], [haveIcon], [IconPath], [IconGroup], [idmodule]) VALUES (384, N'uniproj_Update_ResearchDepartementVerfication', 902, 0, NULL, NULL, NULL, 2)
*/








