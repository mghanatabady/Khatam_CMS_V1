/****** Object:  Table [dbo].[coreRole]    Script Date: 09/18/2011 11:38:52 ******/

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[coreRole]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[coreRole](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_coreRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END



----Announcement
if NOT Exists(select * from sys.columns where Name = N'Announcement'  and Object_ID = Object_ID(N'coreRole')) 
begin  
 -- Column Exists 
 ALTER TABLE coreRole ADD [Announcement] [nvarchar](MAX)
Print 'Message: coreRole.Announcement Table Created'
end 
else
begin
Print 'Message: coreRole.Announcement Table Exist'
end

SET IDENTITY_INSERT [dbo].[coreRole] ON
INSERT      INTO            coreRole(id, title)  VALUES     (1, N'کاربر عادی')

SET IDENTITY_INSERT [dbo].[coreRole] OFF