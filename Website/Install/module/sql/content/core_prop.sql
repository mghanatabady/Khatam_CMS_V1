CREATE TABLE [dbo].[core_prop](
	[core_prop_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_id] [int] NULL,
	[title] [nvarchar](50) NULL,
	[isOption] [bit] NULL,
 CONSTRAINT [PK_core_prop] PRIMARY KEY CLUSTERED 
(
	[core_prop_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
