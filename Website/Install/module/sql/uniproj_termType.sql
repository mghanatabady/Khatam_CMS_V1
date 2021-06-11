CREATE TABLE [dbo].[uniproj_termType](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_termType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT   INTO            uniproj_termType(id, title) VALUES     (1, N'نیم سال اول')
INSERT   INTO            uniproj_termType(id, title) VALUES     (2, N'نیم سال دوم')
INSERT   INTO            uniproj_termType(id, title) VALUES     (3, N'تابستان')
