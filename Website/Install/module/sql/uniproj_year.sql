CREATE TABLE [dbo].[uniproj_year](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_uniproj_year] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT   INTO            uniproj_year(id, title) VALUES     (1, N'1391-1392')
INSERT   INTO            uniproj_year(id, title) VALUES     (2, N'1392-1393')
INSERT   INTO            uniproj_year(id, title) VALUES     (3, N'1393-1394')
INSERT   INTO            uniproj_year(id, title) VALUES     (4, N'1394-1395')
INSERT   INTO            uniproj_year(id, title) VALUES     (5, N'1395-1396')


