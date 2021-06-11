CREATE TABLE [dbo].[core_sendMode_Instance](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[country_id] [int] NULL,
	[state_id] [int] NULL,
	[city_id] [int] NULL,
	[area_id] [int] NULL,
	[sendMode_id] [int] NULL,
 CONSTRAINT [PK_core_sendMode_Instance] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]