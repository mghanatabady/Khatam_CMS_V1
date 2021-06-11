IF NOT EXISTS
( 

SELECT [name] 
    FROM sys.tables where [name] = N'core_payMode'


)
CREATE TABLE [dbo].[core_payMode](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NULL,
	[Enable] [bit] NULL,
 CONSTRAINT [PK_core_payMode] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT      INTO            core_payMode(id, title, Enable)   VALUES     (0, N'لطفا یک شیوه را انتخاب کنید', 1)
INSERT      INTO            core_payMode(id, title, Enable)   VALUES     (1, N'پرداخت آنلاین کارت های شتاب با همکاری بانک سامان', 1)
INSERT      INTO            core_payMode(id, title, Enable)   VALUES     (2, N'پرداخت آنلاین کارت های شتاب با همکاری زرین پال', 0)
INSERT      INTO            core_payMode(id, title, Enable)   VALUES     (3, N'واریز فیش بانکی', 1)


DELETE  FROM         core_payMode WHERE     (id = 2)