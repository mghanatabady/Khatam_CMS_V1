/****** Object:  Table [dbo].[darman_card_use]    Script Date: 02/04/2013 08:43:04 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[darman_card_use]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[darman_card_use](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[darman_cards_id] [int] NULL,
	[reg_user_id] [int] NULL,
	[datetime] [datetime] NULL,
	[memo] [nvarchar](255) NULL,
 CONSTRAINT [PK_darman_card_use] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

Print 'Message: [darman_card_use] Table Created'
END
ELSE 
Begin
Print 'Message: [darman_card_use] Table Exist'
END
GO

if NOT Exists(select * from sys.columns where Name = N'drname'  and Object_ID = Object_ID(N'darman_card_use')) 
begin  
 -- Column Exists 
 ALTER TABLE darman_card_use ADD drname [nvarchar](80) NULL
Print 'Message: [darman_card_use].[drname] Table Created'
end 
else
begin
Print 'Message: [darman_card_use].[drname] Table Exist'
end


