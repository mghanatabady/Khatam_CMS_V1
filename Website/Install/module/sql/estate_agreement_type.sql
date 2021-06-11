CREATE TABLE [dbo].[estate_agreement_type](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[dictionary_id] [int] NULL,
 CONSTRAINT [PK_estate_agreement_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT   INTO            estate_agreement_type(id, title,dictionary_id) VALUES     (1, N'Buy',959)
INSERT   INTO            estate_agreement_type(id, title,dictionary_id) VALUES     (2, N'Mortgage and Rent',960)

