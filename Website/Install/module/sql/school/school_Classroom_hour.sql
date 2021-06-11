/****** Object:  Table [dbo].[school_Classroom_hour]    Script Date: 08/05/2010 09:46:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[school_Classroom_hour]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[school_Classroom_hour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_school_classroom_select] [int] NULL,
	[alarm_number] [smallint] NULL,
	[day_number] [smallint] NULL,
	[half_number] [smallint] NULL,
 CONSTRAINT [PK_school_Classroom_hour_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO