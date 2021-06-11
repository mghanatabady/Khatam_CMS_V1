

CREATE TABLE [dbo].[core_country_state](
	[country_state_id]  [int]  NOT NULL,
	[country_country_id] [int] NOT NULL,
	[country_state_title] [nvarchar](50) NULL,
	[iran_mc_code] [int] NULL,
	[dictionary_id] [int] NULL,
 CONSTRAINT [PK_core_country_state] PRIMARY KEY CLUSTERED 
(
	[country_state_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[core_country_state]  WITH CHECK ADD  CONSTRAINT [FK_core_country_state_core_country] FOREIGN KEY([country_country_id])
REFERENCES [dbo].[core_country] ([country_id])
ON DELETE CASCADE
GO

/*INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[dictionary_id]) VALUES (0,'00', N'All Country',412)*/
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (1,104, N'Azerbaijan, East',41,420)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (2,104, N'Azerbaijan, West',44,421)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (3,104, N'Ardabil',45,422)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (4,104, N'Isfahan',31,423)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (5,104, N'Alborz',26,424)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (6,104, N'Ilam',84,425)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (7,104, N'Bushehr',77,426)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (8,104, N'Tehran',21,427)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (9,104, N'Chahar Mahaal and Bakhtiari',38,428)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (10,104, N'Khorasan, South',56,429)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (11,104, N'Khorasan, Razavi',51,430)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (12,104, N'Khorasan, North',58,431)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (13,104, N'Khuzestan',61,432)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (14,104, N'Zanjan',24,433)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (15,104, N'Semnan',23,434)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (16,104, N'Sistan and Baluchistan',54,435)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (17,104, N'Fars',71,436)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (18,104, N'Qazvin',28,437)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (19,104, N'Qom',25,438)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (20,104, N'Kurdistan',87,439)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (21,104, N'Kerman',34,440)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (22,104, N'Kermanshah',83,441)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (23,104, N'Kohgiluyeh and Boyer-Ahmad',74,442)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (24,104, N'Golestan',17,443)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (25,104, N'Gilan',13,444)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (26,104, N'Lorestan',66,445)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (27,104, N'Mazandaran',15,446)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (28,104, N'Markazi',86,447)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (29,104, N'Hormozgān',76,448)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (30,104, N'Hamadan',81,449)
INSERT [dbo].[core_country_state] ([country_state_id], [country_country_id],[country_state_title],[iran_mc_code],[dictionary_id]) VALUES (31,104, N'Yazd',35,450)

									
