CREATE TABLE [dbo].[uniproj_cluster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[uniSection] [int] NULL,
	[year_id] [int] NULL,
	[termType] [int] NULL,
	[EduGroupId] [int] NULL,
	[uniGroupUserId] [int] NULL,
	[uniGroupUserFname] [nvarchar](50) NULL,
	[uniGroupUserLname] [nvarchar](50) NULL,
	[uniGroupTeacherCode] [int] NULL,
	[capacity] [int] NULL,
 CONSTRAINT [PK_uniproj_cluster] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

