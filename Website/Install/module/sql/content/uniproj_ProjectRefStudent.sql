CREATE TABLE [dbo].[uniproj_ProjectRefStudent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[uniStudentUserId] [int] NULL,
	[project_id] [int] NULL,
	[status] [int] NULL,
	[regdateTime] [datetime] NULL,
	[acceped_date] [datetime] NULL,
	[uniStrudentFname] [nvarchar](50) NULL,
	[uniStrudentLname] [nvarchar](50) NULL,
 CONSTRAINT [PK_uniproj_ProjectRefStudent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


