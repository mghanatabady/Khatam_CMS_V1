CREATE TABLE [dbo].[core_SaleMode](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_core_SaleMode] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


INSERT      INTO            core_SaleMode(id, title) VALUES     (1, N'فروش آنلاین')
INSERT      INTO            core_SaleMode(id, title) VALUES     (2, N'فقط تماس')
INSERT      INTO            core_SaleMode(id, title) VALUES     (3, N'توقف فروش')