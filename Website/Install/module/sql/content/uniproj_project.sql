CREATE TABLE [dbo].[uniproj_project](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](120) NULL,
	[memo] [nvarchar](300) NULL,
	[htmlPage] [nvarchar](max) NULL,
	[clusterId] [int] NULL,
	[uniTeacherUserId] [int] NULL,
	[uniTeacherUserFname] [nvarchar](50) NULL,
	[uniTeacherUserLname] [nvarchar](50) NULL,
	[uniProjTeacherCode] [nvarchar](50) NULL,
	[uniStudentUserId] [int] NULL,
	[uniStrudentFname] [nvarchar](50) NULL,
	[uniStudentLname] [nvarchar](50) NULL,
	[uniGroupUserIdVerification] [int] NULL,
	[uniGroupUserFnameVerfication] [nvarchar](50) NULL,
	[uniGroupUserLnameVerfication] [nvarchar](50) NULL,
	[uniGroupUserTeacherCodeVerfication] [nvarchar](50) NULL,
	[researchDepartementUserIdVerfication] [int] NULL,
	[researchDepartementUserFnameVerfication] [nvarchar](50) NULL,
	[researchDepartementUserLnameVerfication] [nvarchar](50) NULL,
	[regDatetime] [datetime] NULL,
	[updateDatetime] [datetime] NULL,
	[GroupUserIdVerificationState] [int] NULL,
	[DepartementUserIdVerficationState] [int] NULL,
	[projectType] [int] NULL,
	[sendToGroupId] [bit] NULL,
 CONSTRAINT [PK_uniproj_project] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO