
CREATE TABLE [dbo].[core_country_state_city_area](
	[country_state_city_area_id] [int] NOT NULL,
	[country_state_city_id] [int] NOT NULL,	
	[country_state_city_area_title] [nvarchar](50) NULL,
	[dictionary_id] [int] NULL,
 CONSTRAINT [PK_core_country_state_city_area] PRIMARY KEY CLUSTERED 
(
	[country_state_city_area_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (1,120,N'area 1',997)



INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (2,120,N'area 2',998)




INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (3,120,N'area 3',999)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (4,120,N'area 4',1000)



INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (5,120,N'area 5',1001)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (6,120,N'area 6',1002)




INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (7,120,N'area 7',1003)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (8,120,N'area 8',1004)



INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (9,120,N'area 9',1005)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (10,120,N'area 10',1006)



INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (11,120,N'area 11',1007)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (12,120,N'area 12',1008)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (13,120,N'area 13',1009)




INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (14,120,N'area 14',1010)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (15,120,N'area 15',1011)



INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (16,120,N'area 16',1012)





INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (17,120,N'area 17',1013)




INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (18,120,N'area 18',1014)



INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (19,120,N'area 19',1015)


INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (20,120,N'area 20',1016)

INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (21,120,N'area 21',1017)

INSERT INTO core_country_state_city_area
                      (country_state_city_area_id, country_state_city_id, country_state_city_area_title, dictionary_id)
VALUES     (22,120,N'area 22',1018)

GO

UPDATE     core_country_state_city_area  SET              dictionary_id = 997   WHERE     (country_state_city_area_id = 1)
UPDATE     core_country_state_city_area  SET              dictionary_id = 998   WHERE     (country_state_city_area_id = 2)
UPDATE     core_country_state_city_area  SET              dictionary_id = 999   WHERE     (country_state_city_area_id = 3)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1000   WHERE     (country_state_city_area_id = 4)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1001   WHERE     (country_state_city_area_id = 5)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1002   WHERE     (country_state_city_area_id = 6)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1003   WHERE     (country_state_city_area_id = 7)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1004   WHERE     (country_state_city_area_id = 8)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1005   WHERE     (country_state_city_area_id = 9)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1006   WHERE     (country_state_city_area_id = 10)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1007   WHERE     (country_state_city_area_id = 11)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1008   WHERE     (country_state_city_area_id = 12)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1009   WHERE     (country_state_city_area_id = 13)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1010   WHERE     (country_state_city_area_id = 14)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1011   WHERE     (country_state_city_area_id = 15)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1012   WHERE     (country_state_city_area_id = 16)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1013   WHERE     (country_state_city_area_id = 17)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1014   WHERE     (country_state_city_area_id = 18)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1015   WHERE     (country_state_city_area_id = 19)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1016   WHERE     (country_state_city_area_id = 20)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1017   WHERE     (country_state_city_area_id = 21)
UPDATE     core_country_state_city_area  SET              dictionary_id = 1018   WHERE     (country_state_city_area_id = 22)