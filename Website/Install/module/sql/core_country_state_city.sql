
CREATE TABLE [dbo].[core_country_state_city](
	[country_state_city_id] [int] NOT NULL,
	[country_state_id] [int] NOT NULL,	
	[country_state_city_title] [nvarchar](50) NULL,
    [iran_mc_code] [int] NULL,
	[dictionary_id] [int] NULL,
 CONSTRAINT [PK_core_country_state_city] PRIMARY KEY CLUSTERED 
(
	[country_state_city_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*iranmc_Code*/
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (1,1, N'Azar Shahr',12,451)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (2,1, N'Osko',14,452)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (3,1, N'Ahar',13,453)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (4,1, N'Bostanabad',17,454)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (5,1, N'Bonab',15,455)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (6,1, N'Bandare Sharafkhaneh',16,456)

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (7,1, N'Tabriz',18,457)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (8,1, N'Tasooj',19,458)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (9,1, N'Jolfa',20,459)

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (10,1, N'Sarab',21,460)

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (11,1, N'Shabestar',22,461)

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (12,1, N'soofian',24,462)

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (13,1, N'Ajabshir',23,463)

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (14,1, N'ghareh Aghaj',1,464)

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (15,1, N'Kayelbar',2,465)

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (16,1, N'Kandovan',3,466)
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (17,1, N'Maragheh',7,467)
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (18,1, N'Marand',6,468)
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (19,1, N'Malekan',4,469)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (20,1, N'Mianeh',5,470)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (21,1, N'Varzeghan',11,473)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (22,1, N'Hadishahr',8,474)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (23,1, N'Heris',9,860)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (24,1, N'Hashtrood',10,475)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (25,1, N'Mamaghan',25,476)  
  
  /* آذربایجان غربی */
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (26,2, N'Oromyeh',7,477)  
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (27,2, N'Oshnavieh',8,478)  
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (28,2, N'Bazargan',19,479)  
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (29,2, N'bookan',9,480)  
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (30,2, N'Piranshahr',6,481)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (31,2, N'takab',10,482)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (32,2, N'Chaldoran',5,483)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (33,2, N'khoy',11,485)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (34,2, N'Sardasht',14,486)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (35,2, N'Salmas',12,487)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (36,2, N'Siahcheshm',13,489)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (37,2, N'Shahin dezh',15,490)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (38,2, N'Shot',18,808)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (39,2, N'Maku',3,809)  

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (40,2, N'Mahabad',1,491)  

      INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (41,2, N'Mian do ab',2,492)  

      INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (42,2, N'Naghadeh',4,493)  

  /* ostan ardebil */

        INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (43,3, N'Ardebil',9,494)  
   
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (44,3, N'BileSavar',10,495)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (45,3, N'ParsAbad',8,496)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (46,3, N'Khalkhal',11,497)  
   
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (47,3, N'Sareyn',12,498)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (48,3, N'givi (kosar)',2,499)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (49,3, N'garmi',7,500)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (50,3, N'meshgin shahr',3,501)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (51,3, N'namin',5,502)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (52,3, N'nir',6,503) 
   
  /* isfehan */
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (53,4, N'Aran and bidgol',11,504)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (54,4, N'Ardestan',12,505)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (55,4, N'Esfehan',13,506)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (56,4, N'baghe bahadoran',14,507)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (57,4, N'Tiran',15,508)  


       INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (58,4, N'chadegan',29,509)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (59,4, N'Khomeynishar',16,510)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (60,4, N'Khansar',17,511)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (61,4, N'Dolatabad',18,512)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (62,4, N'dahaghan',23,513)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (63,4, N'Zarinshahr',19,514)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (64,4, N'Zibashahr',26,515)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (65,4, N'Semirom',20,516)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (66,4, N'Sepahanshahr',30,877)  
  /***eeee***/
       INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (67,4, N'shahinShar',22,861)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (68,4, N'Shahreza',21,862)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (69,4, N'Faridan',3,863)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (70,4, N'fereydoonsharh',4,864)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (71,4, N'falavarjan',1,865)  

       INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (72,4, N'fooladshahr',2,866)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (73,4, N'ghahidarjan',24,867)  

       INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (74,4, N'Kashan',5,868)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (75,4, N'Goldasht',28,869)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (76,4, N'Golpayegan',10,870)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (77,4, N'Mobarake',6,871)  

       INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (78,4, N'Malekshahr',25,872)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (79,4, N'naean',7,873)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (80,4, N'najafabad',8,874)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (81,4, N'natanz',9,875)  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (82,4, N'harand',27,876)  

/*alborz*/  

     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (83,5, N'Asara',5,799)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (84,5, N'eshtehard',7,800)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (85,5, N'charbagh',9,801)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (86,5, N'Safadasht',11,802)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (87,5, N'Taleghan',3,803)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (88,5, N'Karaj',1,804)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (89,5, N'koohsar',6,805)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (90,5, N'nazarabad',8,806)  

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (91,5, N'hashtgerd',4,807)  

/*Ilam */
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (92,6, N'Ab Danan',2,826)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (93,6, N'Ilam',3,827)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (94,6, N'Ivan',4,828)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (95,6, N'Dareshahr',6,829)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (96,6, N'Dehloran',5,830)  
      INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (97,6, N'sarabaleh',7,831)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (98,6, N'mehran',1,832)  

  /*booshehr */
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (99,7, N'Ahrom',3,810)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (100,7, N'borazjan',5,811)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (101,7, N'Abpakhsh',16,812)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (102,7, N'booshehr',4,813)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (103,7, N'tangestan',6,814)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (104,7, N'jam',15,815)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (105,7, N'khark',8,816)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (106,7, N'khoormoj',7,817)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (107,7, N'dashtestan',12,818)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (108,7, N'dashti',11,819)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (109,7, N'delvar',17,820)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (110,7, N'dayer',10,821)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (111,7, N'deylam',9,822)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (112,7, N'asalooye',14,823)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (113,7, N'kangan',1,824)  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (114,7, N'genaveh',2,825)  
  /*  Tehran */

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (115,8, N'Islam shahr',17,837)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (116,8, N'Andisheh',38,838)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (117,8, N'Boomehen',19,839)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (118,8, N'Pakdasht',15,840)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (119,8, N'Tajrish',21,841)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (120,8, N'Tehran',20,842)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (121,8, N'Chahardangeh',10,843)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (122,8, N'Damavand',22,844)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (123,8, N'RobatKarim',25,845)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (124,8, N'Roodehen',23,846)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (125,8, N'Rey',24,847)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (126,8, N'SharifAbad',27,848)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (127,8, N'Shahriyar',26,849)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (128,8, N'Fasham',2,850)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (129,8, N'Firoozkooh',1,851)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (130,8, N'Ghods',3,852)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (131,8, N'Gharchak',4,853)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (132,8, N'Kan',5,854)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (133,8, N'kahrizak',6,855)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (134,8, N'Golestan',14,856)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (135,8, N'Lavasan',8,857)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (136,8, N'Malard',9,858)  
     INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES   
  (137,8, N'Varamin',13,859)  







/* چهار محال و بختیاری */


    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (138,9, N'ardal',4,517)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (139,9, N'boroojen',5,518)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (140,9, N'chelgerd',3,519)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (141,9, N'saman',6,520)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (142,9, N'shahre kord',7,521)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (143,9, N'farsan',1,522)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (145,9, N'farokh shahr',9,523)  
      INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (146,9, N'lordegan',2,524)  
      INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (147,9, N'hafshjan',8,525)  


  /* خراسان جنوبی */


    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (148,10, N'بشرویه',6,526)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (149,10, N'بیرجند',2,527)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (150,10, N'خضری',8,528)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (151,10, N'سرایان',5,529)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (152,10, N'سربیشه',3,530)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (153,10, N'فردوس',7,531)  
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (154,10, N'قائن',4,532)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (155,10, N'نهبندان',1,533)    


    /* 51 خراسان رضوی */
	   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (156,11, N'بردسكن',12,534)    
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (157,11, N'بجستان',23,535)    
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (158,11, N'تايباد',13,536)    
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (159,11, N'تربت جام',14,537)    
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (160,11, N'تربت حيدريه',15,538)    
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (161,11, N'جغتای',2,539) 
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (162,11, N'جوین',5,540) 
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (163,11, N'چناران',9,541) 

  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (164,11, N'خواف',16,542)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (165,11, N'خلیل آباد',22,543) 
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (166,11, N'درگز',17,544)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (167,11, N'رشتخوار',4,545)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (168,11, N'سبزوار',18,546) 
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (169,11, N'سرخس',19,547)  
    
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (170,11, N'طوس',20,548)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (171,11, N'طرقبه',21,549) 
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (172,11, N'فریمان',1,550)  


  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (173,11, N'قوچان',3,551)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (174,11, N'کاشمر',7,552) 
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (175,11, N'کلات',6,553)  

   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (176,11, N'گناباد',11,554)

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (177,11, N'مشهد',8,555)

    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (178,11, N'نیشابور',10,556)

	/* خراسان شمالی 58 */

	  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (179,12, N'آشخانه',1,557)
  	  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (180,12, N'اسفراین',2,558)
  	  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (181,12, N'بجنورد',3,559)
  	  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (182,12, N'جاجرم',4,560)
  	  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (183,12, N'شيروان',5,561)
  	  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (184,12, N'فاروج',6,562)


	/* خوزستان 61 */

		  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (185,13, N'آبادان',5,563)
		  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (186,13, N'اميديه',6,564)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (187,13, N'اندیمشک',7,565)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (188,13, N'اهواز',8,566)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (189,13, N'ایذه',9,567)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (190,13, N'گتوند',10,568)
  
  
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (192,13, N'بندرامام خميني',12,569)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (193,13, N'بندر ماهشهر',11,570)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (194,13, N'بهبهان',13,571)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (195,13, N'خرمشهر',15,572)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (196,13, N'دزفول',16,573)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (197,13, N'رامهرمز',17,574)
      INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (198,13, N'رامشیر',22,575)
      INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (199,13, N'سوسنگرد',18,576)
        INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (200,13, N'شادگان',21,577)
 
 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (201,13, N'شوشتر',20,578)
 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (202,13, N'شوش',19,579) 
 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (203,13, N'لالي',1,580) 
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (204,13, N'مسجد سليمان',2,581)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (205,13, N' هنديجان',3,582) 


  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (206,13, 'هويزه',4,583) 
   /* زنجان 24 */
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (207,14, N'آب بر',4,584) 
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (208,14, N'ابهر',6,585) 
  
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (209,14, N'خرمدره',8,586) 
 
 
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (210,14, N'زرين آباد',10,587) 
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (211,14, N'زنجان',9,588) 
 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (212,14, N'قيدار',1,589) 
 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (213,14, N'ماهنشان',3,590) 

  
  /* سمنان 23 */
  
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (214,15, N'ايوانكي',2,591)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (215,15, N'بسطام',3,592)
 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (216,15, N'دامغان',4,593) 

	 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (217,15, N'سمنان',5,594) 

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (218,15, N'سرخه',7,595)	

INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (219,15, N'شاهرود',6,596)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (220,15, N'شهمیرزاد',9,597)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (221,15, N'گرمسار',1,598)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (222,15, N'مهدیشهر',8,599)




  /* سیستان و بلوچستان 54 */

 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (223,16, N'ايرانشهر',4,600)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (224,16, N'چابهار',3,601)

	 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (225,16, N'خاش',5,602)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (226,16, N'راسك',6,603)
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (227,16, N'زابل',8,604)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (228,16, N'زاهدان',7,605)
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (229,16, N'سراوان',9,606)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (230,16, N'سرباز',10,607)

 INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (231,16, N'فنوج',12,608)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (232,16, N'کنارک',11,609)
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (233,16, N'ميرجاوه',1,793)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (234,16, N'نيكشهر',2,794)

/* فارس 71 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (235,17, N'آباده',13,795)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (236,17, N'اردكان',15,796)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (237,17, N'ارسنجان',16,797)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (238,17, N'استهبان',17,798)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (239,17, N'اقليد',14,610)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (240,17, N'ایزد خواست',27,611)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (241,17, N'بوانات',35,612)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (242,17, N'پاسارگاد',41,613)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (243,17, N'جهرم',18,614)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (244,17, N'حاجي آباد',19,615)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (245,17, N'خرم بید',37,616)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (246,17, N'خنج',36,617)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (247,17, N'خشت',20,618)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (248,17, N'داراب',21,619)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (249,17, N'شيراز',24,620)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (250,17, N'فراشبند',2,621)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (251,17, N'فسا',3,833)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (252,17, N'فيروز آباد',1,834)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (253,17, N'قایمیه',38,622)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (254,17, N'قيرو کارزین',4,623)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (255,17, N'كازرون',5,624)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (256,17, N'گراش',40,625)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (257,17, N'لار',7,626)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (258,17, N'لامرد',6,627)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (259,17, N'مرودشت',10,628)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (260,17, N'مصیری(رستم)',42,629)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (261,17, N'مهر',39,630)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (262,17, N'نورآباد',11,631)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (263,17, N'ني ريز',12,632)


  /* قزوین 28 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (264,18, N'آبیک',2,633)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (265,18, N'شهرک البرز',5,634)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (266,18, N'بوئین زهرا',3,635)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (267,18, N'تاکستان',4,636)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (268,18, N'قزوین',1,637)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (269,18, N'محمود آباد نمونه',6,638)



/* قم 25 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (270,19, N'قم',1,639)
/* کردستان 87 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (271,20, N'بانه',5,640)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (272,20, N'بیجار',4,641)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (273,20, N'دیواندره',6,642)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (274,20, N'دهگلان',9,643)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (275,20, N'سقز',7,644)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (276,20, N'سنندج',8,645)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (277,20, N'قروه',1,646)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (278,20, N'کامیاران',2,647)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (279,20, N'مریوان',3,648)
  

/* کرمان 34 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (280,21, N'شهر بابک',5,649)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (281,21, N'بافت',4,650)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (282,21, N'بردسیر',6,651)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (283,21, N'بم',3,652)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (284,21, N'جیرفت',7,653)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (285,21, N'سرچشمه',12,654)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (286,21, N'راور',9,655)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (287,21, N'رفسنجان',8,656)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (288,21, N'زرند',10,657)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (289,21, N'سیرجان',11,658)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (290,21, N'کرمان',2,659)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (291,21, N'کهنوج',1,660)

/* کرمانشاه 83 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (292,22, N'اسلام آباد غرب',7,661)
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (293,22, N'پاوه',6,662)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (294,22, N'ثلاث باباجانی',12,663)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (295,22, N'جوانرود',8,664)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (296,22, N'خسروی',13,665)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (297,22, N'سر پل ذهاب',10,666)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (298,22, N'سنقر',9,667)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (299,22, N'صحنه',11,668)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (300,22, N'قصر شیرین',1,669)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (301,22, N'کرمانشاه',3,670)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (302,22, N'کنگاور',2,671)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (303,22, N'گيلان غرب',5,672)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (304,22, N'هرسين',4,673)

/* کهگیلویه و بویر احمد 74 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (305,23, N'دنا',3,674)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (306,23, N'دوگنبدان',5,675)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (307,23, N'دهدشت',4,676)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (308,23, N'سي سخت',6,677)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (309,23, N'گچساران',2,678)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (310,23, N'لیکک',7,679)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (311,23, N'ياسوج',1,680)

/* گلستان 17 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (312,24, N'آزاد شهر',7,681)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (313,24, N'آق قلا',6,682)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (314,24, N'بندر گز',8,683)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (315,24, N'ترکمن',9,684)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (316,24, N'جلین',12,685)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (317,24, N'رامیان',10,686)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (318,24, N'علی آباد کتول',11,687)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (319,24, N'کردکوی',2,688)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (320,24, N'كلاله',1,689)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (321,24, N'گالیکش',13,690)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (322,24, N'گرگان',5,691)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (323,24, N'گنبد کاووس',4,692)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (324,24, N'تپه مراوه',14,878)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (325,24, N'دشت مینو',3,693)

/* گیلان 13 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (326,25, N'آستارا',9,694)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (327,25, N'آستانه اشرفيه',8,695)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (328,25, N'املش',10,696)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (329,25, N'بندرانزلي',11,697)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (330,25, N'تالش',12,698)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (331,25, N'خمام',22,699)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (332,25, N'رودبار',14,700)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (333,25, N'سر رود',13,701)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (334,25, N'رستم آباد',23,702)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (335,25, N'رشت',15,703)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (336,25, N'رضوان شهر',16,704)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (337,25, N'سياهكل',17,705)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (338,25, N'شفت',18,706)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (339,25, N'صومعه سرا',19,707)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (340,25, N'فومن',1,708)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (341,25, N'كلاچاي',2,709)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (342,25, N'لاهيجان',20,710)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (343,25, N'لنگرود',3,711)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (344,25, N'لوشان',21,712)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (345,25, N'ماسال',6,713)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (346,25, N'ماسوله',5,714)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (347,25, N'منجيل',4,715)

/* لرستان 66 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (348,26, N'ازنا',7,716)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (349,26, N'الشتر',6,717)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (350,26, N'اليگودرز',5,718)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (351,26, N'بروجرد',8,719)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (352,26, N'پلدختر',4,720)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (353,26, N'خرم آباد',9,721)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (354,26, N'دورود',10,722)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (355,26, N'سراب دوره',11,723)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (356,26, N'سپید دشت',2,724)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (357,26, N'شول آباد',12,725)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (358,26, N'كوهدشت',1,726)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (359,26, N'نور آباد',3,727)

/* مازندران 15 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (360,27, N'آمل',9,728)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (361,27, N'بلده',10,729)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (362,27, N'بهشهر',11,730)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (363,27, N'بابل',12,731)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (364,27, N'بابلسر',13,732)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (365,27, N'پل سفيد',8,733)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (366,27, N'تنكابن',14,734)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (367,27, N'جويبار',15,735)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (368,27, N'چالوس',7,736)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (369,27, N'رامسر',16,737)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (370,27, N'ساري',18,738)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (371,27, N'سلمانشهر',19,739)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (372,27, N'سواد کوه',17,740)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (373,27, N'فریدون کنار',1,741)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (374,27, N'کلاردشت',22,742)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (375,27, N'شهر قائم',2,743)
   INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (376,27, N'گلوگاه',20,744)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (377,27, N'محمود آباد',3,745)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (378,27, N'مرزن آباد',21,746)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (379,27, N'نكا',4,747)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (380,27, N'نور',5,748)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (381,27, N'نوشهر',6,749)

 
  

/* مرکزی 86 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (382,28, N'آشتيان',2,750)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (383,28, N'اراك',3,751)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (384,28, N'تفرش',4,752)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (385,28, N'خمين',5,753)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (386,28, N'خنداب',12,754)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (387,28, N'دليجان',6,755)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (388,28, N'زرندیه',11,756)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (389,28, N'ساوه',7,757)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (390,28, N'شازند',10,758)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (391,28, N'کمیجان',9,759)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (392,28, N'محلات',1,760)


/* هرمزگان 76 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (393,29, N'ابوموسي',5,761)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (394,29, N'انگهران',4,762)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (395,29, N'بندر جاسك',7,763)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (396,29, N'بندر خمیر',14,764)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (397,29, N'بندرعباس',8,765)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (398,29, N'بندر لنگه',6,766)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (399,29, N'بستك',9,767)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (400,29, N'پارسیان',13,768)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (401,29, N'تنب بزرگ',10,769)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (402,29, N'حاجی آباد',11,770)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (403,29, N'دهبارز',12,771)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (404,29, N'قشم',1,772)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (405,29, N'كيش',2,773)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (406,29, N'ميناب',3,774)

/* همدان 81 */
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (407,30, N'اسدآباد',5,775)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (408,30, N'بهار',6,776)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (409,30, N'تويسركان',7,777)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (410,30, N'رزن',8,778)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (411,30, N'کبودر آهنگ',1,779)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (412,30, N'ملاير',2,780)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (413,30, N'نهاوند',3,781)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (414,30, N'همدان',4,782)
/* یزد 35*/
INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (415,31, N'ابركوه',5,783)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (416,31, N'اردكان',6,784)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (417,31, N'اشكذر',7,785)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (418,31, N'بافق',8,786)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (419,31, N'تفت',9,787)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (420,31, N'طبس',10,788)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (421,31, N'مهريز',1,789)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (422,31, N'ميبد',2,790)
  INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (423,31, N'هرات',3,791)
    INSERT INTO core_country_state_city  (country_state_city_id, country_state_id, country_state_city_title,[iran_mc_code], dictionary_id)  VALUES 
  (424,31, N'يزد',4,792)







/*


if (Indx==86){
options[0]=new Option(-لطفا شهر خود را انتخاب کنيد-,--);

}
if (Indx==76){

}
if (Indx==81){
options[0]=new Option(-لطفا شهر خود را انتخاب کنيد-,--);

}
if (Indx==35){
options[0]=new Option(-لطفا شهر خود را انتخاب کنيد-,--);





   VALUES (4,104, N'Isfahan',31,412)
   VALUES (5,104, N'Alborz',26,412)
   VALUES (6,104, N'Ilam',84,412)
   VALUES (7,104, N'Bushehr',77,412)
   VALUES (8,104, N'Tehran',21,412)

/
   VALUES (9,104, N'Chahar Mahaal and Bakhtiari',38,412)

   VALUES (10,104, N'Khorasan, South',56,412)
   VALUES (11,104, N'Khorasan, Razavi',51,412)
   VALUES (12,104, N'Khorasan, North',58,412)
   VALUES (13,104, N'Khuzestan',61,412)
   VALUES (14,104, N'Zanjan',24,412)
   VALUES (15,104, N'Semnan',23,412)


   VALUES (16,104, N'Sistan and Baluchistan',54,412)
   VALUES (17,104, N'Fars',71,412)
   VALUES (18,104, N'Qazvin',28,412)
   VALUES (19,104, N'Qom',25,412)
   VALUES (20,104, N'Kurdistan',87,412)
   VALUES (21,104, N'Kerman',34,412)
   VALUES (22,104, N'Kermanshah',83,412)
   VALUES (23,104, N'Kohgiluyeh and Boyer-Ahmad',74,412)
   VALUES (24,104, N'Golestan',17,412)
   VALUES (25,104, N'Gilan',13,412)
   VALUES (26,104, N'Lorestan',66,412)
   VALUES (27,104, N'Mazandaran',15,412)
   VALUES (28,104, N'Markazi',86,412)
   VALUES (29,104, N'Hormozgān',76,412)
   VALUES (30,104, N'Hamadan',81,412)
   VALUES (31,104, N'Yazd',35,412)*/