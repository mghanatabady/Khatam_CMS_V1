﻿CREATE TABLE [dbo].[uniproj_ClusterRefTeacher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[uniTeacherId] [int] NULL,
	[cluster_id] [int] NULL,
	[capacity] [int] NULL,
 CONSTRAINT [PK_uniproj_ClusterRefTeacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


