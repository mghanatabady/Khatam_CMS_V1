
/****** Object:  Table [dbo].[core_units]    Script Date: 09/23/2012 21:16:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[core_units](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[id_dictonary] [int] NULL,
 CONSTRAINT [PK_core_units] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


INSERT into  core_units(id,title, id_dictonary) values (1,N'quatity',879)
INSERT into  core_units(id,title, id_dictonary) values (2,N'gram',880)
INSERT into  core_units(id,title, id_dictonary) values (3,N'kilogeram',881)
INSERT into  core_units(id,title, id_dictonary) values (4,N'ton',882)
INSERT into  core_units(id,title, id_dictonary) values (5,N'Meter',883)
INSERT into  core_units(id,title, id_dictonary) values (6,N'Square meters',884)
 