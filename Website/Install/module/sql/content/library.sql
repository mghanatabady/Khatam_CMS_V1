/****** Object:  Table [dbo].[library]    Script Date: 07/27/2010 13:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[library]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[library](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[page] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Enable] [bit] NULL,
	[title] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[keywords] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[author_name] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[description] [nvarchar](300) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[author] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[translator] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isbn] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Link1] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Link2] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[pic] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[image] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[pub_date] [datetime] NULL,
	[author_book] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[language] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
	[publisher] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[size] [real] NULL,
	[mode] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[download_counter] [int] NULL,
	[users_rate] [int] NULL,
 CONSTRAINT [PK_library] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO

if NOT Exists(select * from sys.columns where Name = N'Password'  and Object_ID = Object_ID(N'library')) 
begin  
 -- Column Exists 
 ALTER TABLE library ADD [Password] [nvarchar](50) NULL
end 
GO



if NOT Exists(select * from sys.columns where Name = N'fileDL'  and Object_ID = Object_ID(N'library')) 
begin  
 -- Column Exists 
ALTER TABLE library ADD [fileDL] [nvarchar](255) NULL
end 
GO
