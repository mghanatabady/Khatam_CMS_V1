/****** Object:  Table [dbo].[Core_sectionVal]    Script Date: 08/05/2011 08:19:48 ******/

CREATE TABLE [dbo].[Core_sectionVal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Core_Section] [int] NULL,
	[propertyTitle] [nvarchar](50) NULL,
	[propertyValue] [nvarchar](max) NULL,
	[propertytype] [nvarchar](50) NULL,
	[language] [int] NULL,
 CONSTRAINT [PK_Core_SecionVal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
