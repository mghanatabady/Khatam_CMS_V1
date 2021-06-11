CREATE TABLE [dbo].[core_sendMode](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[needPaymode] [bit] NULL,
 CONSTRAINT [PK_core_sendMode] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


INSERT INTO core_sendMode ([id],[title]) Values (1,N'پست پیشتاز - اداره پست ایران')
INSERT INTO core_sendMode ([id],[title]) Values (2,N'پست خرید - ایران مارکت سنتر')
INSERT INTO core_sendMode ([id],[title]) Values (3,N'باربری ترمینال')
INSERT INTO core_sendMode ([id],[title]) Values (4,N'آژانس / پیک موتوری')
INSERT INTO core_sendMode ([id],[title]) Values (5,N'اتوبوس بین شهری')
INSERT INTO core_sendMode ([id],[title]) Values (6,N'وانت بار')
INSERT INTO core_sendMode ([id],[title]) Values (7,N'کامیونت')
INSERT INTO core_sendMode ([id],[title]) Values (8,N'تریلی')
INSERT INTO core_sendMode ([id],[title]) Values (9,N'هواپیما')
INSERT INTO core_sendMode ([id],[title]) Values (10,N'پست سفارشی - اداره پست ایران')

