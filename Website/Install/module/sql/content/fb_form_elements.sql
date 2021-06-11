CREATE TABLE [dbo].[fb_form_elements](
	[element_id] [int] IDENTITY(1,1) NOT NULL,
	[form_id] [int] NULL,
	[element_title] [nvarchar](255) NULL,
	[element_guidelines] [nvarchar](255) NULL,
	[element_size] [varchar](6) NULL,
	[element_is_required] [bit] NOT NULL,
	[element_is_unique] [bit] NOT NULL,
	[element_is_private] [bit] NOT NULL,
	[element_type] [varchar](50) NULL,
	[element_position] [int] NULL,
	[element_default_value] [nvarchar](255) NULL,
	[element_constraint] [varchar](50) NULL,
	[element_total_child] [int] NULL,
 CONSTRAINT [PK_fb_form_elements] PRIMARY KEY CLUSTERED 
(
	[element_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


