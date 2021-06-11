CREATE TABLE [dbo].[core_prop_val](
	[core_prop_val_id] [int] IDENTITY(1,1) NOT NULL,
	[value] [nvarchar](255) NULL,
	[core_prop_id] [int] NULL,
	[core_prop_defVal_id] [int] NULL,
	[cat_id] [int] NULL,
 CONSTRAINT [PK_core_prop_val] PRIMARY KEY CLUSTERED 
(
	[core_prop_val_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO