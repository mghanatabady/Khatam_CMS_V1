/****** Object:  Table [dbo].[Setting_Base]    Script Date: 07/09/2010 00:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Setting_Base]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Setting_Base](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cname] [nvarchar](50)  NULL,
	[title] [nvarchar](50)  NULL,
	[memo] [nvarchar](255)  NULL,
	[Language] [int] NULL,
	[id_setting_software_cat] [int] NULL,
 CONSTRAINT [PK_Setting_Base] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
/*IF NOT EXISTS (SELECT K.TABLE_NAME, K.COLUMN_NAME, K.CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS C JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS K ON C.TABLE_NAME = K.TABLE_NAME AND C.CONSTRAINT_CATALOG = K.CONSTRAINT_CATALOG AND C.CONSTRAINT_SCHEMA = K.CONSTRAINT_SCHEMA AND C.CONSTRAINT_NAME = K.CONSTRAINT_NAME WHERE C.CONSTRAINT_TYPE = 'PRIMARY KEY' AND K.COLUMN_NAME = 'ID' and K.CONSTRAINT_NAME='pk_setting_baseID' )
BEGIN
ALTER TABLE setting_base ADD CONSTRAINT pk_setting_baseID PRIMARY KEY (id)
END
GO*/
SET IDENTITY_INSERT [dbo].[Setting_Base] ON
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (1, N'Domain', N'نام دامنه', N'yourdomain.com', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (2, N'Title', N'عنوان', N'Under Construction', 1, 0)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (3, N'Title', N'Title', N'Under Construction', 2, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (4, N'Email_Main', N'ایمیل اصلی سایت', N'info@yourdomain.com', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (5, N'Email_do_not_replay', N'ایمیل سیستمی', N'do_not_replay@yourdomain.com', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (6, N'Email_do_not_replay_pass', N'پسورد ایمیل سیستمی', N'EmailGGgg3', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (7, N'Help_Url', N'آدرس راهنما', NULL, 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (8, N'persianstat', N'آدرس پرشین استات', NULL, 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (9, N'persianstat_User', N'نام کاربری پرشین استات', NULL, 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (10, N'persianstat_Pass', N'پسورد پرشین استات', NULL, 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (11, N'WebmailURL', N'آدرس وب میل', N'http://webmail.yourdomain.com/', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (12, N'webstats', N'آدرس وب استات سایت', NULL, 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (13, N'Manage_Cp_URL', N'آدرس کنترل پنل', N'http://www.yourdomain.com/', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (16, N'webstats', N'webstats', N'http://www.yourdomain.com/webstats', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (17, N'webstat', N'webstats', N'http://www.yourdomain.com/webstats', 0, 2)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (18, N'title_11', N'عنوان', N'کنترل پنل معلمین', 1, 3)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (19, N'title_22', N'عنوان', N'کنترل پنل دانش آموزان', 1, 4)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (20, N'title_33', N'عنوان', N'کنترل پنل اولیا', 1, 5)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (21, N'school_active_year', N'سال تحصیلی فعال مدرسه', N'1', 0, 0)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (22, N'id_software', N'کد نرم افزار', N'', 0, 0)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (23, N'persianstats_script', N'اسکریپت پرشین استات', N'', 0, 0)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (24, N'theme_id', N'کد قالب', N'3', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (25, N'doc_id', N'آی دی ساختار', N'doc4', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (26, N'doc_class', N'کلاس ساختار', N'yui-t6', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (28, N'brand_url', N'لینک برند', N'http://www.yourDomain.com/', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (29, N'brand_support_url', N'لینک پشتیبانی برند', N'http://www.yourDomain.com/contactus.aspx', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (30, N'brand_title', N'توسعه نرم افزار خاتم', N'', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (31, N'brand_product1_title', N'عنوان 1 محصول برند', N'پرتال ویژه مدارس هوشمند || سیستم مدیریت محتوا مدرسه الکترونیک', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (32, N'brand_product1_url', N'لینک 1 محصول برند', N'http://www.yourDomain.com/portal_item.aspx?id=8', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (33, N'brand_product2_title', N'عنوان 2 محصول برند', N'طراحی وب', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (34, N'brand_product2_url', N'لینک 2 محصول برند', N'http://www.yourDomain.com/', 1, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (35, N'msg_copyright', N'پیام کپی رایت', N'تمامی حقوق متعلق است به', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (36, N'editor_mode', N'نوع ویرایشگر', N'1', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (37, N'footer_script', N'اسکریپت های فوتر', N'1', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (38, N'header_script', N'اسکریپت های هدر', N'1', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (39, N'theme', N'theme', N'aspnet', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (40, N'Title', N'عنوان', N'Under Construction', 3, 0)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (41, N'Title', N'عنوان', N'Under Construction', 4, 0)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (42, N'iranmcMaxOrderPrice', N'حداکثر مبغ سفارش ایران مارکت سنتر', N'1000000', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (43, N'sendmode2_by_agent_per502kg', N'مبلغ ارسال با آژانس تا ترمینال هر 50 کیلو', N'100000', 0, NULL)

INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (44, N'sendSmsToSaleManager', N'ارسال sms به مدیر فروش', N'false', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (45, N'saleManagerCellPhone', N'شماره موبایل مدیر فروش', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (46, N'saleManagerEmail', N'ایمیل مدیر فروش', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (47, N'sendSmsToTransManager', N'ارسال sms به تایید کننده تراکنش آفلاین', N'false', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (48, N'transManagerCellPhone', N'شماره موبایل تایید کننده تراکنش افلاین', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (49, N'transManagerEmail', N'ایمیل تایید کننده تراکنش آفلاین', N'', 0, NULL)

INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (50, N'logo', N'لوگو', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (51, N'tel', N'تلفن', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (52, N'email', N'ایمیل', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (53, N'cellphone', N'موبایل', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (54, N'address', N'آدرس', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (55, N'fax', N'فکس', N'', 0, NULL)
INSERT [dbo].[Setting_Base] ([id], [cname], [title], [memo], [Language], [id_setting_software_cat]) VALUES (56, N'invoice_exp', N'زمان اعتبار پیش فاکتور', N'48', 0, NULL)






SET IDENTITY_INSERT [dbo].[Setting_Base] OFF



DELETE FROM Setting_Base  WHERE     (id = 1)
DELETE FROM Setting_Base  WHERE     (id = 4)
DELETE FROM Setting_Base  WHERE     (id = 7)
DELETE FROM Setting_Base  WHERE     (id = 8)
DELETE FROM Setting_Base  WHERE     (id = 9)
DELETE FROM Setting_Base  WHERE     (id = 10)
DELETE FROM Setting_Base  WHERE     (id = 12)
DELETE FROM Setting_Base  WHERE     (id = 13)
DELETE FROM Setting_Base  WHERE     (id = 16)
DELETE FROM Setting_Base  WHERE     (id = 18)
DELETE FROM Setting_Base  WHERE     (id = 19)
DELETE FROM Setting_Base  WHERE     (id = 20)
DELETE FROM Setting_Base  WHERE     (id = 22)
DELETE FROM Setting_Base  WHERE     (id = 23)
DELETE FROM Setting_Base  WHERE     (id = 24)
DELETE FROM Setting_Base  WHERE     (id = 25)
DELETE FROM Setting_Base  WHERE     (id = 26)
DELETE FROM Setting_Base  WHERE     (id = 28)
DELETE FROM Setting_Base  WHERE     (id = 29)
DELETE FROM Setting_Base  WHERE     (id = 30)
DELETE FROM Setting_Base  WHERE     (id = 31)
DELETE FROM Setting_Base  WHERE     (id = 32)
DELETE FROM Setting_Base  WHERE     (id = 33)
DELETE FROM Setting_Base  WHERE     (id = 34)
DELETE FROM Setting_Base  WHERE     (id = 35)
DELETE FROM Setting_Base  WHERE     (id = 36)
DELETE FROM Setting_Base  WHERE     (id = 37)
DELETE FROM Setting_Base  WHERE     (id = 38)




ALTER TABLE [dbo].[Setting_Base] ALTER COLUMN [memo] NVARCHAR(Max);

