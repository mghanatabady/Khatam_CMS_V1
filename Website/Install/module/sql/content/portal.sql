/****** Object:  Table [dbo].[portal]    Script Date: 08/24/2010 23:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[portal]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[portal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](150)  NULL,
	[description] [nvarchar](300)  NULL,
	[page] [nvarchar](max)  NULL,
	[image] [nvarchar](255)  NULL,
	[enable] [bit] NULL,
	[keywords] [nvarchar](120)  NULL,
	[pub_date] [datetime] NULL,
	[author] [nvarchar](120)  NULL,
	[Customer_Group] [nvarchar](120)  NULL,
	[Link_Demo] [nvarchar](255)  NULL,
	[Link_Demo_manage] [nvarchar](255)  NULL,
	[Link_Pdf] [nvarchar](255)  NULL,
	[Link_present] [nvarchar](255)  NULL,
	[price_in_rls] [numeric](18, 0) NULL,
	[Pic] [nvarchar](255)  NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
 CONSTRAINT [PK_portal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END

if NOT Exists(select * from sys.columns where Name = N'setupPrice'  and Object_ID = Object_ID(N'portal')) 
begin  
 -- Column Exists 
 ALTER TABLE portal ADD [setupPrice] [numeric](18, 0) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'memo_invoice'  and Object_ID = Object_ID(N'portal')) 
begin  
 -- Column Exists 
 ALTER TABLE portal ADD [memo_invoice] [nvarchar](max) NULL
end 



