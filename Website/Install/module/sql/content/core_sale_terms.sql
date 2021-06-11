
CREATE TABLE [dbo].[core_sale_terms](
	[core_sale_terms_id] [int] IDENTITY(1,1) NOT NULL,
	[catId] [int] NULL,
	sale_mode [int] NOT NULL,
	[core_country_id] [int] NULL,
	[min] [bigint] NULL,
	[justCall] [bit] NULL,
	[price] [numeric](18, 0) NULL,
	[price_unit] [int] NULL,
	[sendAndPayFromShopCartSetting] [bit] NULL,
	[core_sendMode_id] [int] NULL,
	[core_PayMode_id] [int] NULL,
	[sellIfOnlyAvailableInStock] [bit] NULL,
	[fromDate] [datetime] NULL,
	[toDate] [datetime] NULL,
	[enable] [bit] NULL,
	[iranmc] nvarchar(50)
 CONSTRAINT [PK_core_sale_terms] PRIMARY KEY CLUSTERED 
(
	[core_sale_terms_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
