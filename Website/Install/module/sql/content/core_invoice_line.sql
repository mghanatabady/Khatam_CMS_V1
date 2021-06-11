IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[core_invoice_line]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[core_invoice_line](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[invocice_id] [int] NULL,
	[price] [numeric](18, 0) NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_core_invoice_line] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
if NOT Exists(select * from sys.columns where Name = N'quantity'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [quantity] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'sum'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [sum] numeric(18, 0) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'catid'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [catid] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'productcode'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [productcode] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'type_content'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [type_content] nvarchar(50) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'virtual'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [virtual] bit NULL
end 


if NOT Exists(select * from sys.columns where Name = N'domain'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [domain] nvarchar(120) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'exp'  and Object_ID = Object_ID(N'core_invoice_line')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice_line ADD [exp] datetime NULL
end 



GO
ALTER TABLE [core_invoice_line] ALTER COLUMN [title] nvarchar(250) 

GO
delete  FROM core_invoice_line WHERE core_invoice_line.invoice_id
NOT IN (SELECT [dbo].[core_invoice].[id]  FROM [dbo].[core_invoice]);
GO
ALTER TABLE [dbo].[core_invoice_line]  WITH CHECK ADD  CONSTRAINT [FK_core_invoice_line] FOREIGN KEY([invoice_id])
REFERENCES [dbo].[core_invoice] ([id])
ON DELETE CASCADE
GO
alter table [core_invoice_line] alter column [title] nvarchar(max) null
GO
ALTER TABLE [dbo].[core_invoice_line] CHECK CONSTRAINT [FK_core_invoice_line]
GO
EXEC sp_rename
    @objname = 'core_invoice_line.invocice_id',
    @newname = 'invoice_id',
    @objtype = 'COLUMN'
GO

