IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[clip]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[clip](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](80) NULL,
	[type] [nvarchar](80) NULL,
	[page] [nvarchar](max) NULL,
	[size] [nvarchar](50) NULL,
	[author] [nvarchar](50) NULL,
	[user_rate] [smallint] NULL,
	[crack1] [nvarchar](255) NULL,
	[crack2] [nvarchar](255) NULL,
	[Enable] [bit] NULL,
	[Password] [nvarchar](50) NULL,
	[pic] [nvarchar](255) NULL,
	[image] [nvarchar](255) NULL,
	[Link1] [nvarchar](255) NULL,
	[Link2] [nvarchar](255) NULL,
	[Link3] [nvarchar](255) NULL,
	[sitebuilder] [nvarchar](255) NULL,
	[keywords] [nvarchar](120) NULL,
	[author_name] [nvarchar](120) NULL,
	[description] [nvarchar](300) NULL,
	[pub_date] [datetime] NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
 CONSTRAINT [PK_clip] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END

GO

if NOT Exists(select * from sys.columns where Name = N'fileDL'  and Object_ID = Object_ID(N'clip')) 
begin  
 -- Column Exists 
 ALTER TABLE clip ADD [fileDL] nvarchar(255) NULL
end 
