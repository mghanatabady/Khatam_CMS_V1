CREATE TABLE [dbo].[fb_element_options](
	[aeo_id] [int] IDENTITY(1,1) NOT NULL,
	[form_id] [int] NULL,
	[element_id] [int] NULL,
	[option_id] [int] NULL,
	[position] [int] NULL,
	[option_title] [nvarchar](255) NULL,
	[option_is_default] [bit] NULL,
	[live] [int] NULL,
 CONSTRAINT [PK_fb_element_options] PRIMARY KEY CLUSTERED 
(
	[aeo_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


