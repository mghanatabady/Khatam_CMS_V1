/****** Object:  Table [dbo].[article]    Script Date: 07/11/2010 08:00:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[article]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[article](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[author] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[author_email] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[translator_name] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[users_rate] [int] NULL,
	[title] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[title_fa] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[image] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Language] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[page] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[url] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[enable] [bit] NULL,
	[keywords] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[pub_date] [datetime] NULL,
	[description_robot] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
 CONSTRAINT [PK_article_content] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO


ALTER TABLE article ALTER COLUMN  
[author] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL

ALTER TABLE article ALTER COLUMN             
				[author_email] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
				
				ALTER TABLE article ALTER COLUMN 
	[translator_name] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
	
	ALTER TABLE article ALTER COLUMN 
	[title] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL

	ALTER TABLE article ALTER COLUMN 
	[title_fa] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL

	ALTER TABLE article ALTER COLUMN 
	[description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL

	ALTER TABLE article ALTER COLUMN 
	[image] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL

	ALTER TABLE article ALTER COLUMN 
	[Language] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL

	ALTER TABLE article ALTER COLUMN 
	[page] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL


	ALTER TABLE article ALTER COLUMN 
	[url] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
	
	ALTER TABLE article ALTER COLUMN 
	[keywords] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
	
	ALTER TABLE article ALTER COLUMN 
	[description_robot] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL

UPDATE    article  SET              enable = 0  WHERE     (enable IS NULL)
