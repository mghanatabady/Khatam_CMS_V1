CREATE TABLE [dbo].[estate_type](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[dictionary_id] [int] NULL,
 CONSTRAINT [PK_estate_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT   INTO            estate_type(id, title,dictionary_id) VALUES     (1, N'apartement',959)
INSERT   INTO            estate_type(id, title,dictionary_id) VALUES     (2, N'villa-house',960)
INSERT   INTO            estate_type(id, title,dictionary_id) VALUES     (3, N'shop',961)
INSERT   INTO            estate_type(id, title,dictionary_id) VALUES     (4, N'yard',962)
INSERT   INTO            estate_type(id, title,dictionary_id) VALUES     (5, N'farm',963)
INSERT   INTO            estate_type(id, title,dictionary_id) VALUES     (6, N'factory',964)
INSERT   INTO            estate_type(id, title,dictionary_id) VALUES     (7, N'complex',965)


