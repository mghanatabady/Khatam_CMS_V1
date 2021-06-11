CREATE TABLE [dbo].[core_tags](
	[tag_id] [int] IDENTITY(1,1) NOT NULL,
	[tag_title] [nvarchar](80) NULL,
	[counter] [bigint] NULL,
 CONSTRAINT [PK_core_tags] PRIMARY KEY CLUSTERED 
(
	[tag_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO