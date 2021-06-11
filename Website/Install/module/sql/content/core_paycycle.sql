CREATE TABLE [dbo].[core_paycycle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[month] [int] NULL,
	[catId] [int] NULL,
	[price] [numeric](18, 0) NULL,
	[enable] [bit] NULL,
 CONSTRAINT [PK_core_paycycle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO