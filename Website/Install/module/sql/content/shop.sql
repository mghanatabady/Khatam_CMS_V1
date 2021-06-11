IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[shop]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Shop](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[author] [nvarchar](120) NULL,
	[author_email] [nvarchar](50) NULL,
	[users_rate] [int] NULL,
	[title] [nvarchar](150) NULL,
	[description] [nvarchar](300) NULL,
	[page] [nvarchar](max) NULL,
	[enable] [bit] NULL,
	[keywords] [nchar](10) NULL,
	[pub_date] [nchar](10) NULL,
	[description_robot] [nvarchar](255) NULL,
	[image] [nvarchar](255) NULL,
	[pic] [nvarchar](255) NULL,
	[price_in_rls] [numeric](18, 0) NULL,
	[price_in_rls_old] [numeric](18, 0) NULL,
	[manufacturer] [nvarchar](80) NULL,
	[pdf] [nvarchar](255) NULL,
	[driver] [nvarchar](255) NULL,
	[link1] [nvarchar](255) NULL,
	[inmain] [bit] NULL,
	[sortid] [nvarchar](max) NULL,
	[enable_show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
	[id_iranmc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

	if NOT Exists(select * from sys.columns where Name = N'YahooID'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [YahooID] [nvarchar](80) NULL
end 

	if NOT Exists(select * from sys.columns where Name = N'shopAssistantTel'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [shopAssistantTel] [nvarchar](80) NULL
end 
if NOT Exists(select * from sys.columns where Name = N'shopAssistantMobile'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [shopAssistantMobile] [nvarchar](80) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'shopAssistantEmail'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [shopAssistantEmail] [nvarchar](80) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'weight'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [weight] float NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Width'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [Width] float NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Length'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [Length] float NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Height'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [Height] float NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Breakable'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [Breakable] bit NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Liquid'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [Liquid] bit NULL
end 

if NOT Exists(select * from sys.columns where Name = N'sale_unit'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [sale_unit] int NULL
end 


if NOT Exists(select * from sys.columns where Name = N'sale_mode'  and Object_ID = Object_ID(N'Shop')) 
begin  
 -- Column Exists 
 ALTER TABLE Shop ADD [sale_mode] int NULL
end 


GO

UPDATE    shop  SET              enable = 0  WHERE     (enable IS NULL)

GO
ALTER TABLE shop  ALTER COLUMN pub_date datetime
