/****** Object:  Table [dbo].[Core_section]    Script Date: 04/06/2011 15:41:04 ******/

/* error drop and rebuild dictionarys*/
if not exists (select * from sys.objects  WHERE  object_id = OBJECT_ID(N'Core_section') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Core_section](
	[id] [int] NOT NULL,
	[title] [nvarchar](50)  NULL,
	[yuig] [nvarchar](10)  NULL,
	[yui_id] [nvarchar](10)  NULL,
	[yui_class] [nvarchar](10)  NULL,
	[background_color] [nvarchar](20)  NULL,
	[background_image] [nvarchar](255)  NULL,
	[background_repeat] [int] NULL,
	[background_attachment] [int] NULL,
	[keywords] [nvarchar](255)  NULL,
	[Description] [nvarchar](255)  NULL,
	[Author] [nvarchar](50)  NULL,
 CONSTRAINT [PK_Core_section] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
if not exists (select * from syscolumns
  where id=object_id('core_section') and name='title')
begin
    alter table core_section add [title] nvarchar(120) NULL
end
GO
/*error */ 	
if not exists (select * from syscolumns
  where id=object_id('core_section') and name='IdDictionary')
  Begin
    alter table core_section add [IdDictionary] [int] NULL
	End
	GO


INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (1, N'teacher.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (2, N'page.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (3, N'default.aspx', N'yui-gc', N'doc4', N'yui-t2', NULL, N'theme/prime/CssImage/bg.jpg', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (4, N'news.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (5, N'article.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (6, N'software.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (7, N'library.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (8, N'picture.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (9, N'link.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (10, N'register.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (11, N'news_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (12, N'article_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (13, N'software_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (14, N'library_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (15, N'picture_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (17, N'contactus.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (18, N'special_pages_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (19, N'teacher_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (20, N'shop.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (21, N'shop_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (22, N'service.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (23, N'service_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (24, N'shopcart.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (25, N'membership.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (26, N'Payment_SB.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (27, N'Payment_Accounts.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (28, N'Payment_proforma.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (29, N'portal.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (30, N'portal_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (31, N'domain.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (32, N'form_nic.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (33, N'host_windows.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (34, N'digital_certificate_ssl.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (35, N'partner_pricing.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (36, N'Membership_partner.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (37, N'help.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (38, N'help_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (39, N'template.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (40, N'template_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (41, N'order_service.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (42, N'host_order_detail.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (43, N'paymode.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (44, N'Payment_shop_proforma.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (45, N'Payment_shop_account.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (46, N'sitemap.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (47, N'search.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (48, N'host_linux.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (49, N'sample_exam.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (50, N'sample_exam_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (51, N'host.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (52, N'host_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (53, N'car.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (54, N'car_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (55, N'login.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (56, N'clip.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (57, N'clip_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (58, N'OnlineOrderForm.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (59, N'tag.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (60, N'tag_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (61, N'link_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (62, N'estate.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Core_section] ([id], [title], [yuig], [yui_id], [yui_class], [background_color], [background_image], [background_repeat], [background_attachment], [keywords], [Description], [Author]) VALUES (63, N'estate_item.aspx', N'yui-g', N'doc4', N'yui-t6', NULL, NULL, NULL, NULL, NULL, NULL, NULL)




UPDATE    Core_section  SET              IdDictionary = 331  WHERE     (title = N'default.aspx')
UPDATE    Core_section  SET              IdDictionary = 332  WHERE     (title = N'news.aspx')
UPDATE    Core_section  SET              IdDictionary = 333  WHERE     (title = N'article.aspx')
UPDATE    Core_section  SET              IdDictionary = 334  WHERE     (title = N'software.aspx')
UPDATE    Core_section  SET              IdDictionary = 335  WHERE     (title = N'library.aspx')
UPDATE    Core_section  SET              IdDictionary = 336  WHERE     (title = N'picture.aspx')
UPDATE    Core_section  SET              IdDictionary = 337  WHERE     (title = N'link.aspx')
UPDATE    Core_section  SET              IdDictionary = 338  WHERE     (title = N'news_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 339  WHERE     (title = N'article_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 340  WHERE     (title = N'software_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 341  WHERE     (title = N'library_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 342  WHERE     (title = N'picture_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 343  WHERE     (title = N'contactus.aspx')
UPDATE    Core_section  SET              IdDictionary = 344  WHERE     (title = N'special_pages_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 345  WHERE     (title = N'shop.aspx')
UPDATE    Core_section  SET              IdDictionary = 346  WHERE     (title = N'shop_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 347  WHERE     (title = N'service.aspx')
UPDATE    Core_section  SET              IdDictionary = 348  WHERE     (title = N'service_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 349  WHERE     (title = N'shopcart.aspx')
UPDATE    Core_section  SET              IdDictionary = 350  WHERE     (title = N'portal.aspx')
UPDATE    Core_section  SET              IdDictionary = 351  WHERE     (title = N'portal_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 352  WHERE     (title = N'help.aspx')
UPDATE    Core_section  SET              IdDictionary = 353  WHERE     (title = N'help_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 356  WHERE     (title = N'sitemap.aspx')
UPDATE    Core_section  SET              IdDictionary = 357  WHERE     (title = N'search.aspx')
UPDATE    Core_section  SET              IdDictionary = 358  WHERE     (title = N'sample_exam.aspx')
UPDATE    Core_section  SET              IdDictionary = 359  WHERE     (title = N'sample_exam_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 360  WHERE     (title = N'host.aspx')
UPDATE    Core_section  SET              IdDictionary = 361  WHERE     (title = N'host_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 362  WHERE     (title = N'car.aspx')
UPDATE    Core_section  SET              IdDictionary = 363  WHERE     (title = N'car_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 364  WHERE     (title = N'login.aspx')
UPDATE    Core_section  SET              IdDictionary = 365  WHERE     (title = N'clip.aspx')
UPDATE    Core_section  SET              IdDictionary = 366  WHERE     (title = N'clip_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 367  WHERE     (title = N'membership.aspx')
UPDATE    Core_section  SET              IdDictionary = 395  WHERE     (title = N'OnlineOrderForm.aspx')
UPDATE    Core_section  SET              IdDictionary = 891  WHERE     (title = N'tag.aspx')
UPDATE    Core_section  SET              IdDictionary = 892  WHERE     (title = N'tag_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 943  WHERE     (title = N'link_item.aspx')
UPDATE    Core_section  SET              IdDictionary = 63  WHERE     (title = N'domain.aspx')
UPDATE    Core_section  SET              IdDictionary = 967  WHERE     (title = N'estate.aspx')
UPDATE    Core_section  SET              IdDictionary = 968  WHERE     (title = N'estate_item.aspx')



GO
