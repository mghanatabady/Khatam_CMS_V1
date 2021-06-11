IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sbt]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[sbt](
	[resnum] [int] IDENTITY(1,1) NOT NULL,
	[id_core_invoice] [int] NULL,
	[RefNum] [char](40) NULL,
	[state] [nvarchar](80) NULL,
 CONSTRAINT [PK_sbt] PRIMARY KEY CLUSTERED 
(
	[resnum] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
if NOT Exists(select * from sys.columns where Name = N'regDate'  and Object_ID = Object_ID(N'sbt')) 
begin  
 -- Column Exists 
 ALTER TABLE sbt ADD [regDate] datetime NULL
end 
if NOT Exists(select * from sys.columns where Name = N'backDate'  and Object_ID = Object_ID(N'sbt')) 
begin  
 -- Column Exists 
 ALTER TABLE sbt ADD [backDate] datetime NULL
end 

GO

alter table [sbt] alter column [refnum] char(40) null
