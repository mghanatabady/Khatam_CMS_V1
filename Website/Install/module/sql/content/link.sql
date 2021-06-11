/****** Object:  Table [dbo].[link]    Script Date: 07/27/2010 13:06:10 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[link]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[link](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[description] [nvarchar](300) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[image] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[enable] [bit] NULL,
	[keywords] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[pub_date] [datetime] NULL,
	[author_name] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[link1] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Enable_Show] [bit] NULL,
 CONSTRAINT [PK_link] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO

	if NOT Exists(select * from sys.columns where Name = N'author'  and Object_ID = Object_ID(N'link')) 
begin  
 -- Column Exists 
 ALTER TABLE link ADD [author] [nvarchar](120) NULL
end 
GO

	if NOT Exists(select * from sys.columns where Name = N'update_date'  and Object_ID = Object_ID(N'link')) 
begin  
 -- Column Exists 
 ALTER TABLE link ADD [update_date] [datetime] NULL
end 
GO

	if NOT Exists(select * from sys.columns where Name = N'update_user'  and Object_ID = Object_ID(N'link')) 
begin  
 -- Column Exists 
 ALTER TABLE link ADD [update_user] [int] NULL
end 
GO

--Company
if NOT Exists(select * from sys.columns where Name = N'page'  and Object_ID = Object_ID(N'link')) 
begin  
 -- Column Exists 
 ALTER TABLE link ADD [page] [nvarchar](max) NULL
Print 'Message: link.page Table Created'
end 
else
begin
Print 'Message: link.page Table Exist'
end
GO