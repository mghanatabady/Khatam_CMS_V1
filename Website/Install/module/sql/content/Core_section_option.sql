CREATE TABLE [dbo].[Core_section_option](
	[id] [int] IDENTITY(1000,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[yuig] [nvarchar](10) NULL,
	[yui_id] [nvarchar](10) NULL,
	[yui_class] [nvarchar](10) NULL,
	[background_color] [nvarchar](20) NULL,
	[background_image] [nvarchar](255) NULL,
	[background_repeat] [int] NULL,
	[background_attachment] [int] NULL,
	[keywords] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Author] [nvarchar](50) NULL,
	[IdDictionary] [int] NULL,
 CONSTRAINT [PK_Core_section_option] PRIMARY KEY CLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]