/****** Object:  Table [dbo].[host]    Script Date: 07/21/2011 10:15:37 ******/

CREATE TABLE [dbo].[host](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[author] [nvarchar](120) NULL,
	[author_email] [nvarchar](50) NULL,
	[translator_name] [nvarchar](120) NULL,
	[users_rate] [int] NULL,
	[title] [nvarchar](150) NULL,
	[description] [nvarchar](300) NULL,
	[Language] [nvarchar](40) NULL,
	[page] [nvarchar](max) NULL,
	[url] [nvarchar](120) NULL,
	[enable] [bit] NULL,
	[keywords] [nvarchar](120) NULL,
	[pub_date] [datetime] NULL,
	[description_robot] [nvarchar](255) NULL,
	[image] [nvarchar](255) NULL,
	[inmain] [bit] NULL,
	[pic] [nvarchar](255) NULL,
	[enable_show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
	[priceRLS] [numeric](18, 0) NULL,
 CONSTRAINT [PK_host_content] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]