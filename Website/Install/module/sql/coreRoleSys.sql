IF NOT EXISTS
( 

SELECT [name] 
    FROM sys.tables where [name] = N'coreRoleSys'


)
CREATE TABLE [dbo].[coreRoleSys](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[IdDictionary] [int] NULL,
	[Announcement] [nvarchar](max) NULL,
	[Module] [varchar](10) NULL,
 CONSTRAINT [PK_coreRoleSys] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT     INTO            coreRoleSys(id, title, IdDictionary,Module)  VALUES     (10001, N'defaultUser', 937,N'core')
INSERT     INTO            coreRoleSys(id, title, IdDictionary,Module)  VALUES     (10002, N'groupUser', 933, N'uniproj')
INSERT     INTO            coreRoleSys(id, title, IdDictionary,Module)  VALUES     (10003, N'teacher', 934, N'uniproj')
INSERT     INTO            coreRoleSys(id, title, IdDictionary,Module)  VALUES     (10004, N'student', 935, N'uniproj')
INSERT     INTO            coreRoleSys(id, title, IdDictionary,Module)  VALUES     (10005, N'researchDepartementUser', 936, N'uniproj')