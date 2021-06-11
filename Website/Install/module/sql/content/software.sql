/****** Object:  Table [dbo].[software]    Script Date: 07/27/2010 13:06:10 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[software]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[software](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[type] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[page] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[size] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[author] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[user_rate] [smallint] NULL,
	[crack1] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[crack2] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Enable] [bit] NULL,
	[Password] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[pic] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[image] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Link1] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Link2] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Link3] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[sitebuilder] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[keywords] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[author_name] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[description] [nvarchar](300) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[pub_date] [datetime] NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
 CONSTRAINT [PK_software] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO

	if NOT Exists(select * from sys.columns where Name = N'Valid'  and Object_ID = Object_ID(N'cat')) 
begin  
 -- Column Exists 
 ALTER TABLE cat ADD [Valid] bit NULL
end 
GO

	if NOT Exists(select * from sys.columns where Name = N'pub_date'  and Object_ID = Object_ID(N'software')) 
begin  
 -- Column Exists 
 ALTER TABLE software ADD [pub_date] [datetime] NULL
end 
GO


if NOT Exists(select * from sys.columns where Name = N'fileDL'  and Object_ID = Object_ID(N'software')) 
begin  
 -- Column Exists 
ALTER TABLE software ADD [fileDL] [nvarchar](255) NULL
end 
GO

UPDATE    software  SET              enable = 0  WHERE     (enable IS NULL)