IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[news]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[news](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[description] [nvarchar](300) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[page] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[image] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[enable] [bit] NULL,
	[keywords] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[pub_date] [datetime] NULL,
	[author] [nvarchar](120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
	[source] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[newsdate] [datetime] NULL,
 CONSTRAINT [PK_news] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
UPDATE    news  SET              enable = 0  WHERE     (enable IS NULL)
