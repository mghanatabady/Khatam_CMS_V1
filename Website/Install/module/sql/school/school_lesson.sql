/****** Object:  Table [dbo].[school_Lesson]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Lesson]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Lesson](
	[id] [nvarchar](20) COLLATE Arabic_CI_AS NOT NULL,
	[category_id] [int] NOT NULL,
	[title] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[Min_Pass_Value] [smallint] NULL,
	[year_present] [int] NULL,
	[Unit_practical_Quantity] [smallint] NULL,
	[Unit_theoretical_Quantity] [smallint] NULL,
	[TeachHour_pratical_Quantity] [smallint] NULL,
	[TeachHour_theotetical_Quantity] [smallint] NULL,
	[Lesson_Present_Cat_id] [int] NULL,
	[Lesson_cat_id] [int] NULL,
	[Lesson_Present_Date_Cat_id] [int] NULL,
	[Price] [numeric](18, 0) NULL,
	[unit] [int] NULL,
 CONSTRAINT [PK_school_Lesson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO