CREATE TABLE [dbo].[core_prop_defVal](
	[core_prop_defVal_id] [int] IDENTITY(1,1) NOT NULL,
	[core_prop_id] [int] NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_core_prop_defVal] PRIMARY KEY CLUSTERED 
(
	[core_prop_defVal_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

