
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uniproj_sections]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[uniproj_sections](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_uniproj_sections] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO

/*IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=1) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (1, N'کاردانی')
GO*/

DELETE uniproj_sections WHERE (id=1)
GO

/*IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=2) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (2, N'کاردانی به کارشناسی')
GO*/

DELETE uniproj_sections WHERE (id=2)
GO

/*IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=3) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (3, N'کارشناسی')
GO*/

DELETE uniproj_sections WHERE (id=3)
GO

IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=4) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (4, N'ارشد')
GO

IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=5) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (5, N'دکترا')
GO

IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=6) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (6, N'کاردانی پیوسته')
GO

IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=7) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (7, N'کاردانی ناپیوسته')
GO

IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=8) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (8, N'کارشناسی پیوسته')
GO

IF NOT EXISTS (SELECT * FROM uniproj_sections where (id=9) )
INSERT   INTO            uniproj_sections(id, title) VALUES     (9, N'کارشناسی ناپیوسته')
GO 


