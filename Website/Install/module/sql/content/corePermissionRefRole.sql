/****** Object:  Table [dbo].[corePermissionRefRole]    Script Date: 04/24/2011 12:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[corePermissionRefRole]') AND type in (N'U'))
BEGIN

CREATE TABLE [dbo].[corePermissionRefRole](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPermission] [int] NULL,
	[idRole] [int] NULL,
 CONSTRAINT [PK_corePermissionRefRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
Print 'ssss'
END
GO
Select * from menu