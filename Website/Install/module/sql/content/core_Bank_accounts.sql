IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[core_Bank_accounts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[core_Bank_accounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cardNo] [nvarchar](50) NULL,
	[shabaNo] [nvarchar](50) NULL,
	[bankName] [nvarchar](50) NULL,
	[accountNo] [nvarchar](50) NULL,
	[enable] [bit] NULL,
 CONSTRAINT [PK_core_Bank_accounts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
if NOT Exists(select * from sys.columns where Name = N'name'  and Object_ID = Object_ID(N'core_Bank_accounts')) 
begin  
 -- Column Exists 
 ALTER TABLE core_Bank_accounts ADD [name] nvarchar(80) NULL
end 