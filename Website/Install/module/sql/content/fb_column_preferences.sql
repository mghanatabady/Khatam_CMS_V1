CREATE TABLE [dbo].[fb_column_preferences](
	[acp_id] [int] IDENTITY(1,1) NOT NULL,
	[form_id] [int] NULL,
	[element_name] [nvarchar](255) NULL,
	[position] [int] NULL,
 CONSTRAINT [PK_fb_column_preferences] PRIMARY KEY CLUSTERED 
(
	[acp_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


