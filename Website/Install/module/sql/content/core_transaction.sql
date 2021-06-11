IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[core_transaction]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[core_transaction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPayMode] [int] NULL,
	[idInvoice] [int] NULL,
	[idCoreBankAccounts] [int] NULL,
	[accontsDesc] [nvarchar](255) NULL,
	[fishNo] [nvarchar](50) NULL,
	[FishDateTime] [datetime] NULL,
	[amount] [numeric](18, 0) NULL,
	[regDate] [datetime] NULL,
	[valid] [bit] NULL,
 CONSTRAINT [PK_core_transaction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
if NOT Exists(select * from sys.columns where Name = N'state'  and Object_ID = Object_ID(N'core_transaction')) 
begin  
 -- Column Exists 
 ALTER TABLE core_transaction ADD [state] int NULL
end 