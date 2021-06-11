
/****** Object:  Table [dbo].[Core_serverControls]    Script Date: 04/06/2011 15:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Core_serverControls]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Core_serverControls](
	[id] [int] NOT NULL,
	[title] [nvarchar](255)  NULL,
	[module] [int] NULL,
 CONSTRAINT [PK_ServerControls] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
ELSE
BEGIN
Print 'Message: Core_serverControls Exist'
END
GO

if NOT Exists(select * from sys.columns where Name = N'IdDictionary'  and Object_ID = Object_ID(N'Core_serverControls')) 
begin  
 -- Column Exists 
 ALTER TABLE core_serverControls ADD [IdDictionary] int NULL
end 
Else
Begin
print 'Message core---------exist'
end
GO




INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (1, N'khatam.newsLetter.UI.WebControls.newLetterWin', 2)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (2, N'khatam.core.UI.WebControls.Header', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (3, N'khatam.core.UI.WebControls.Menu', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (4, N'khatam.core.UI.WebControls.infoWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (5, N'khatam.core.UI.WebControls.footer', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (6, N'khatam.core.UI.WebControls.TreeCat', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (7, N'khatam.Shop.UI.WebControls.shopList', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (8, N'khatam.core.UI.WebControls.contentWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (9, N'khatam.news.UI.WebControls.Newswin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (10, N'khatam.core.UI.WebControls.flashintrowin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (11, N'khatam.core.UI.WebControls.HeaderFlash', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (12, N'khatam.core.UI.WebControls.contentList', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (13, N'khatam.core.UI.WebControls.contentPaging', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (14, N'khatam.core.UI.WebControls.contentItemWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (15, N'khatam.core.UI.WebControls.loginWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (16, N'khatam.core.UI.WebControls.slider', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (17, N'khatam.core.UI.WebControls.carousel', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (18, N'khatam.core.UI.WebControls.shopCart', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (19, N'khatam.core.UI.WebControls.seacrhWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (20, N'khatam.core.UI.WebControls.membrshipWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (21, N'khatam.core.UI.WebControls.commentWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (22, N'khatam.core.UI.WebControls.OnlineOrderForm', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (23, N'khatam.core.UI.WebControls.domainSearchWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (24, N'khatam.core.UI.WebControls.formPlaceHolder', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (25, N'khatam.core.UI.WebControls.darmanInquiryWin', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (26, N'khatam.core.UI.WebControls.tabs', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (27, N'khatam.core.UI.WebControls.linkToUs', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (28, N'khatam.core.UI.WebControls.estateSearchWin', 1)


/*INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (25, N'khatam.core.UI.WebControls.slideShow', 1)
INSERT [dbo].[Core_serverControls] ([id], [title], [module]) VALUES (26, N'khatam.core.UI.WebControls.tabList', 1)*/





DELETE FROM core_serverControls  WHERE     (id = 1)
DELETE FROM core_serverControls  WHERE     (id = 2)
DELETE FROM core_serverControls  WHERE     (id = 4)
DELETE FROM core_serverControls  WHERE     (id = 5)
DELETE FROM core_serverControls  WHERE     (id = 7)
DELETE FROM core_serverControls  WHERE     (id = 9)
DELETE FROM core_serverControls  WHERE     (id = 10)
DELETE FROM core_serverControls  WHERE     (id = 11)
/*DELETE FROM core_serverControls  WHERE     (id = 16)*/
DELETE FROM core_serverControls  WHERE     (id = 17)
DELETE FROM core_serverControls  WHERE     (id = 22)






UPDATE    Core_serverControls   SET              IdDictionary = 118  WHERE     (id = 3)
UPDATE    Core_serverControls   SET              IdDictionary = 119  WHERE     (id = 6)
UPDATE    Core_serverControls   SET              IdDictionary = 120  WHERE     (id = 8)
UPDATE    Core_serverControls   SET              IdDictionary = 121  WHERE     (id = 12)
UPDATE    Core_serverControls   SET              IdDictionary = 122  WHERE     (id = 13)
UPDATE    Core_serverControls   SET              IdDictionary = 123  WHERE     (id = 14)
UPDATE    Core_serverControls   SET              IdDictionary = 124  WHERE     (id = 15)
UPDATE    Core_serverControls   SET              IdDictionary = 125  WHERE     (id = 16)
UPDATE    Core_serverControls   SET              IdDictionary = 126  WHERE     (id = 17)
UPDATE    Core_serverControls   SET              IdDictionary = 127  WHERE     (id = 18)
UPDATE    Core_serverControls   SET              IdDictionary = 128  WHERE     (id = 19)
UPDATE    Core_serverControls   SET              IdDictionary = 129  WHERE     (id = 20)
UPDATE    Core_serverControls   SET              IdDictionary = 130  WHERE     (id = 21)
UPDATE    Core_serverControls   SET              IdDictionary = 395  WHERE     (id = 22)
UPDATE    Core_serverControls   SET              IdDictionary = 885  WHERE     (id = 23)
UPDATE    Core_serverControls   SET              IdDictionary = 893  WHERE     (id = 24)
UPDATE    Core_serverControls   SET              IdDictionary = 903  WHERE     (id = 25)
UPDATE    Core_serverControls   SET              IdDictionary = 904  WHERE     (id = 26)
UPDATE    Core_serverControls   SET              IdDictionary = 905  WHERE     (id = 27)
UPDATE    Core_serverControls   SET              IdDictionary = 966  WHERE     (id = 28)






/*UPDATE    Core_serverControls   SET              IdDictionary = 895  WHERE     (id = 25)
UPDATE    Core_serverControls   SET              IdDictionary = 896  WHERE     (id = 26)*/

