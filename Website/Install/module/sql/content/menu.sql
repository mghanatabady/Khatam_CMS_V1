IF NOT EXISTS
( 

SELECT [name] 
    FROM sys.tables where [name] = N'menu'


)
CREATE TABLE [dbo].[menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](150) NULL,
	[image] [nvarchar](255) NULL,
	[link] [nvarchar](255) NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


if NOT Exists(select * from sys.columns where Name = N'enable'  and Object_ID = Object_ID(N'menu')) 
begin  
 -- Column Exists 
 ALTER TABLE menu ADD [Enable] bit NULL
end

if NOT Exists(select * from sys.columns where Name = N'pub_date'  and Object_ID = Object_ID(N'menu')) 
begin  
 -- Column Exists 
 ALTER TABLE menu ADD [pub_date] datetime NULL
end


UPDATE     menu  SET              Enable = 1