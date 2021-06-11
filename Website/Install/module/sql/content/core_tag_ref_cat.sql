CREATE TABLE [dbo].[core_tag_ref_cat](
	[tag_ref_cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_id] [bigint] NULL,
	[tag_id] [int] NULL,
 CONSTRAINT [PK_core_tag_ref_cat] PRIMARY KEY CLUSTERED 
(
	[tag_ref_cat_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[core_tag_ref_cat]  WITH CHECK ADD  CONSTRAINT [FK_core_tag_ref_cat_core_tags] FOREIGN KEY([tag_id])
REFERENCES [dbo].[core_tags] ([tag_id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[core_tag_ref_cat] CHECK CONSTRAINT [FK_core_tag_ref_cat_core_tags]
GO


