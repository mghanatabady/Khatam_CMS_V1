/****** Object:  Table [dbo].[darman_cards]    Script Date: 02/04/2013 08:43:08 ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[darman_cards]') AND type in (N'U'))
begin  
CREATE TABLE [dbo].[darman_cards](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[darman_cards_type_id] [int] NULL,
	[fname] [nvarchar](50) NULL,
	[lname] [nvarchar](50) NULL,
	[iranNationalCode] [nvarchar](50) NULL,
	[fatherName] [nvarchar](50) NULL,
	[birthday] [nvarchar](50) NULL,
	[shsh] [nvarchar](50) NULL,
	[shMahalSodor] [nvarchar](50) NULL,
	[tel] [nvarchar](50) NULL,
	[mobile] [nvarchar](50) NULL,
	[address] [nvarchar](255) NULL,
	[regDate] [datetime] NULL,
	[expDate] [datetime] NULL,
	[pic] [nvarchar](255) NULL,
	[invoice_line_id] [int] NULL,
 CONSTRAINT [PK_darman_cards] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
end

/*error not run*/
if NOT Exists(select * from sys.columns where Name = N'invoice_id'  and Object_ID = Object_ID(N'darman_cards')) 
begin  
 -- Column Exists 
 ALTER TABLE darman_cards ADD [invoice_id] [int] NULL
end  

/**********rel***********/
/*SELECT * FROM <foreign_key_table> WHERE <foreign_key_column> 
NOT IN (SELECT <primary_key_column> FROM <primary_key_table>);*/

delete  FROM darman_cards WHERE darman_cards.invoice_id
NOT IN (SELECT core_invoice.id  FROM core_invoice);
GO
ALTER TABLE [dbo].[darman_cards]  WITH CHECK ADD  CONSTRAINT [FK_darman_cards] FOREIGN KEY([invoice_id])
REFERENCES [dbo].[core_invoice] ([id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[darman_cards] CHECK CONSTRAINT [FK_darman_cards]
GO