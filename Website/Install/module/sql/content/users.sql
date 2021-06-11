/****** Object:  Table [dbo].[users]    Script Date: 07/11/2010 08:00:42 ******/

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50)  NOT NULL,
	[password] [nvarchar](50)  NULL,
	[mode] [nvarchar](50)  NULL,
	[email] [nvarchar](50)  NULL,
	[fname] [nvarchar](50)  NULL,
	[lname] [nvarchar](50)  NULL,
	[id_language] [int] NULL,
	[id_user_cat] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
Print 'Message: Users Table Created'
END
ELSE 
Begin
Print 'Message: Users Table Exist'
END
GO
--Company
if NOT Exists(select * from sys.columns where Name = N'company'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [company] [nvarchar](50) NULL
Print 'Message: Users.Company Table Created'
end 
else
begin
Print 'Message: Users.Company Table Exist'
end
GO
--tel
if NOT Exists(select * from sys.columns where Name = N'tel'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [tel] [nvarchar](50) NULL
Print 'Message: Users.tel Table Created'
end 
else
begin
Print 'Message: Users.tel Table Exist'
end
GO
--fax
if NOT Exists(select * from sys.columns where Name = N'fax'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [fax] [nvarchar](50) NULL
Print 'Message: Users.fax Table Created'
end 
else
begin
Print 'Message: Users.fax Table Exist'
end
GO
--cellphone
if NOT Exists(select * from sys.columns where Name = N'cellphone'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [cellphone] [nvarchar](50) NULL
Print 'Message: Users.cellphone Table Created'
end 
else
begin
Print 'Message: Users.cellphone Table Exist'
end
GO
--country
if NOT Exists(select * from sys.columns where Name = N'country'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [country] [nvarchar](50) NULL
Print 'Message: Users.country Table Created'
end 
else
begin
Print 'Message: Users.country Table Exist'
end
GO
--stats
if NOT Exists(select * from sys.columns where Name = N'stats'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [stats] [nvarchar](50) NULL
Print 'Message: Users.stats Table Created'
end 
else
begin
Print 'Message: Users.stats Table Exist'
end
GO
--city
if NOT Exists(select * from sys.columns where Name = N'city'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [city] [nvarchar](50) NULL
Print 'Message: Users.city Table Created'
end 
else
begin
Print 'Message: Users.city Table Exist'
end
GO

--address
if NOT Exists(select * from sys.columns where Name = N'address'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [address] [nvarchar](255) NULL
Print 'Message: Users.address Table Created'
end 
else
begin
Print 'Message: Users.address Table Exist'
end
GO

--zipcode
if NOT Exists(select * from sys.columns where Name = N'zipcode'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [zipcode] [nvarchar](50) NULL
Print 'Message: Users.zipcode Table Created'
end 
else
begin
Print 'Message: Users.zipcode Table Exist'
end
GO

--activeEmailSalt
if NOT Exists(select * from sys.columns where Name = N'activeEmailSalt'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [activeEmailSalt] [nvarchar](50) NULL
Print 'Message: Users.activeEmailSalt Table Created'
end 
else
begin
Print 'Message: Users.activeEmailSalt Table Exist'
end
GO
----active
if NOT Exists(select * from sys.columns where Name = N'active'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [active] [bit] NULL
Print 'Message: Users.active Table Created'
end 
else
begin
Print 'Message: Users.active Table Exist'
end

GO
----passwordSalt
if NOT Exists(select * from sys.columns where Name = N'passwordSalt'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [passwordSalt] [nvarchar](50)
Print 'Message: Users.passwordSalt Table Created'
end 
else
begin
Print 'Message: Users.passwordSalt Table Exist'
end

GO
----suspended
if NOT Exists(select * from sys.columns where Name = N'suspended'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [suspended] [bit] NULL
Print 'Message: Users.suspended Table Created'
end 
else
begin
Print 'Message: Users.suspended Table Exist'
end
GO

----Announcement
if NOT Exists(select * from sys.columns where Name = N'Announcement'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [Announcement] [nvarchar](MAX)
Print 'Message: Users.Announcement Table Created'
end 
else
begin
Print 'Message: Users.Announcement Table Exist'
end

GO

--teacherCode
if NOT Exists(select * from sys.columns where Name = N'teacherCode'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [teacherCode] [nvarchar](50) NULL
Print 'Message: Users.teacherCode Table Created'
end 
else
begin
Print 'Message: Users.teacherCode Table Exist'
end

--teacherCode
if NOT Exists(select * from sys.columns where Name = N'uniProjStudentId'  and Object_ID = Object_ID(N'users')) 
begin  
 -- Column Exists 
 ALTER TABLE users ADD [uniProjStudentId] [nvarchar](50) NULL
Print 'Message: Users.uniProjStudentId Table Created'
end 
else
begin
Print 'Message: Users.uniProjStudentId Table Exist'
end


ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_suspended]  DEFAULT ((0)) FOR [suspended]

GO
UPDATE    users  SET              suspended = 0  WHERE     (suspended IS NULL)



/**GO
SET IDENTITY_INSERT [dbo].[users] ON
INSERT [dbo].[users] ([id], [username], [password],[passwordsalt], [mode], [email], [fname], [lname], [id_language], [id_user_cat]) VALUES 
(14, N'adminkui', N'93C5725DF9B5DF964FB78A4170BACB3DE53EFB30',N't3Gxldz9y0q4JQ==', NULL, N'a@a.com', N'سید مصطفی', N'قنات آبادی', 1, 1)
SET IDENTITY_INSERT [dbo].[users] OFF
**/






