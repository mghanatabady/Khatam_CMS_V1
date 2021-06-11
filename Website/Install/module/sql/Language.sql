﻿/****** Object:  Table [dbo].[Language]    Script Date: 08/05/2010 09:46:18 ******/

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Language]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Language](
	[id] [int] NOT NULL,
	[title] [nvarchar](50)  NULL,
	[symbol] [char](3)  NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
END
GO
ALTER TABLE [Language] ALTER COLUMN [symbol] [char](5)  NULL 
GO
if NOT Exists(select * from sys.columns where Name = N'currency_id'  and Object_ID = Object_ID(N'Language')) 
begin  
 -- Column Exists 
ALTER TABLE [Language]
ADD currency_id [int] NULL
end 
GO

if NOT Exists(select * from sys.columns where Name = N'url'  and Object_ID = Object_ID(N'Language')) 
begin  
 -- Column Exists 
ALTER TABLE [Language]
ADD url varchar(5) NULL
end 


GO

INSERT [dbo].[Language] ([id], [title], [symbol]) VALUES (1, N'Perisan', N'FA ')
INSERT [dbo].[Language] ([id], [title], [symbol]) VALUES (2, N'English', N'EN ')
INSERT [dbo].[Language] ([id], [title], [symbol]) VALUES (3, N'Arabic', N'AR ')
INSERT [dbo].[Language] ([id], [title], [symbol]) VALUES (4, N'German', N'DE ')
GO
DELETE FROM [Language] WHERE id=0
GO

UPDATE [Language] SET [symbol]='fa-IR',[title]=N'Persian فارسی (Iran)' , currency_id=68,url='fa' WHERE [ID] = '1'
UPDATE [Language] SET [symbol]='en-US',[title]=N'English (United States)', currency_id=146,url='en' WHERE [ID] = '2'
UPDATE [Language] SET [symbol]='ar-AE',[title]=N'Arabic العربی (U.A.E.)', currency_id=151,url='ar' WHERE [ID] = '3'
UPDATE [Language] SET [symbol]='de-DE',[title]=N'German (Germany)', currency_id=68,url='de' WHERE [ID] = '4'
GO


   

/*older  INSERT [dbo].[Language] ([id], [title], [symbol]) VALUES (0, N'Global', N'GB ')
*/

/*

Arabic (Saudi Arabia) ar-SA
 Bulgarian (Bulgaria) bg-BG
 Catalan (Catalan) ca-ES
 Chinese (Taiwan) zh-TW
 Czech (Czech Republic) cs-CZ
 Danish (Denmark) da-DK
 ///////////German (Germany) de-DE
 Greek (Greece) el-GR
//////////// English (United States) en-US
 Finnish (Finland) fi-FI
 French (France) fr-FR
 Hebrew (Israel) he-IL
 Hungarian (Hungary) hu-HU
 Icelandic (Iceland) is-IS
 Italian (Italy) it-IT
 Japanese (Japan) ja-JP
 Korean (Korea) ko-KR
 Dutch (Netherlands) nl-NL
 Norwegian, Bokmål (Norway) nb-NO
 Polish (Poland) pl-PL
 Portuguese (Brazil) pt-BR
 Romanian (Romania) ro-RO
 Russian (Russia) ru-RU
 Croatian (Croatia) hr-HR
 Slovak (Slovakia) sk-SK
 Albanian (Albania) sq-AL
 Swedish (Sweden) sv-SE
 Thai (Thailand) th-TH
 Turkish (Turkey) tr-TR
 Urdu (Islamic Republic of Pakistan) ur-PK
 Indonesian (Indonesia) id-ID
 Ukrainian (Ukraine) uk-UA
 Belarusian (Belarus) be-BY
 Slovenian (Slovenia) sl-SI
 Estonian (Estonia) et-EE
 Latvian (Latvia) lv-LV
 Lithuanian (Lithuania) lt-LT
 //////////Persian (Iran) fa-IR
 Vietnamese (Vietnam) vi-VN
 Armenian (Armenia) hy-AM
 Azeri (Latin, Azerbaijan) az-Latn-AZ
 Basque (Basque) eu-ES
 Macedonian (Former Yugoslav Republic of Macedonia) mk-MK
 Afrikaans (South Africa) af-ZA
 Georgian (Georgia) ka-GE
 Faroese (Faroe Islands) fo-FO
 Hindi (India) hi-IN
 Malay (Malaysia) ms-MY
 Kazakh (Kazakhstan) kk-KZ
 Kyrgyz (Kyrgyzstan) ky-KG
 Kiswahili (Kenya) sw-KE
 Uzbek (Latin, Uzbekistan) uz-Latn-UZ
 Tatar (Russia) tt-RU
 Punjabi (India) pa-IN
 Gujarati (India) gu-IN
 Tamil (India) ta-IN
 Telugu (India) te-IN
 Kannada (India) kn-IN
 Marathi (India) mr-IN
 Sanskrit (India) sa-IN
 Mongolian (Cyrillic, Mongolia) mn-MN
 Galician (Galician) gl-ES
 Konkani (India) kok-IN
 Syriac (Syria) syr-SY
 Divehi (Maldives) dv-MV
 Arabic (Iraq) ar-IQ
 Chinese (People's Republic of China) zh-CN
 German (Switzerland) de-CH
 English (United Kingdom) en-GB
 Spanish (Mexico) es-MX
 French (Belgium) fr-BE
 Italian (Switzerland) it-CH
 Dutch (Belgium) nl-BE
 Norwegian, Nynorsk (Norway) nn-NO
 Portuguese (Portugal) pt-PT
 Serbian (Latin, Serbia) sr-Latn-CS
 Swedish (Finland) sv-FI
 Azeri (Cyrillic, Azerbaijan) az-Cyrl-AZ
 Malay (Brunei Darussalam) ms-BN
 Uzbek (Cyrillic, Uzbekistan) uz-Cyrl-UZ
 Arabic (Egypt) ar-EG
 Chinese (Hong Kong S.A.R.) zh-HK
 German (Austria) de-AT
 English (Australia) en-AU
 Spanish (Spain) es-ES
 French (Canada) fr-CA
 Serbian (Cyrillic, Serbia) sr-Cyrl-CS
 Arabic (Libya) ar-LY
 Chinese (Singapore) zh-SG
 German (Luxembourg) de-LU
 English (Canada) en-CA
 Spanish (Guatemala) es-GT
 French (Switzerland) fr-CH
 Arabic (Algeria) ar-DZ
 Chinese (Macao S.A.R.) zh-MO
 German (Liechtenstein) de-LI
 English (New Zealand) en-NZ
 Spanish (Costa Rica) es-CR
 French (Luxembourg) fr-LU
 Arabic (Morocco) ar-MA
 English (Ireland) en-IE
 Spanish (Panama) es-PA
 French (Principality of Monaco) fr-MC
 Arabic (Tunisia) ar-TN
 English (South Africa) en-ZA
 Spanish (Dominican Republic) es-DO
 Arabic (Oman) ar-OM
 English (Jamaica) en-JM
 Spanish (Venezuela) es-VE
 Arabic (Yemen) ar-YE
 English (Caribbean) en-029
 Spanish (Colombia) es-CO
 Arabic (Syria) ar-SY
 English (Belize) en-BZ
 Spanish (Peru) es-PE
 Arabic (Jordan) ar-JO
 English (Trinidad and Tobago) en-TT
 Spanish (Argentina) es-AR
 Arabic (Lebanon) ar-LB
 English (Zimbabwe) en-ZW
 Spanish (Ecuador) es-EC
 Arabic (Kuwait) ar-KW
 English (Republic of the Philippines) en-PH
 Spanish (Chile) es-CL
 /////////Arabic (U.A.E.) ar-AE
 Spanish (Uruguay) es-UY
 Arabic (Bahrain) ar-BH
 Spanish (Paraguay) es-PY
 Arabic (Qatar) ar-QA
 Spanish (Bolivia) es-BO
 Spanish (El Salvador) es-SV
 Spanish (Honduras) es-HN
 Spanish (Nicaragua) es-NI
 Spanish (Puerto Rico) es-PR
 Chinese (Traditional) zh-CHT
 Serbian sr
 Sami, Southern (Norway) sma-NO
 Bengali (Bangladesh) bn-BD
 Bosnian (Cyrillic, Bosnia and Herzegovina) bs-Cyrl-BA
 Tajik (Cyrillic, Tajikistan) tg-Cyrl-TJ
 English (Singapore) en-SG
 English (Malaysia) en-MY
 Mongolian (Traditional Mongolian, PRC) mn-Mong-CN
 Dari (Afghanistan) prs-AF
 Wolof (Senegal) wo-SN
 Kinyarwanda (Rwanda) rw-RW
 K'iche (Guatemala) qut-GT
 Yakut (Russia) sah-RU
 Alsatian (France) gsw-FR
 Corsican (France) co-FR
 Romansh (Switzerland) rm-CH
 Maori (New Zealand) mi-NZ
 Uighur (PRC) ug-CN
 Breton (France) br-FR
 Mohawk (Mohawk) moh-CA
 Mapudungun (Chile) arn-CL
 Irish (Ireland) ga-IE
 Yi (PRC) ii-CN
 Sami, Southern (Sweden) sma-SE
 Serbian (Latin, Bosnia and Herzegovina) sr-Latn-BA
 Quechua (Peru) quz-PE
 Igbo (Nigeria) ig-NG
 Greenlandic (Greenland) kl-GL
 Luxembourgish (Luxembourg) lb-LU
 Bashkir (Russia) ba-RU
 Sesotho sa Leboa (South Africa) nso-ZA
 Quechua (Bolivia) quz-BO
 Yoruba (Nigeria) yo-NG
 Sami, Skolt (Finland) sms-FI
 Hausa (Latin, Nigeria) ha-Latn-NG
 Croatian (Latin, Bosnia and Herzegovina) hr-BA
 Filipino (Philippines) fil-PH
 Pashto (Afghanistan) ps-AF
 Frisian (Netherlands) fy-NL
 Nepali (Nepal) ne-NP
 Amharic (Ethiopia) am-ET
 Inuktitut (Syllabics, Canada) iu-Cans-CA
 Quechua (Ecuador) quz-EC
 Sinhala (Sri Lanka) si-LK
 Sami, Lule (Sweden) smj-SE
 Lao (Lao P.D.R.) lo-LA
 Khmer (Cambodia) km-KH
 Welsh (United Kingdom) cy-GB
 Tibetan (PRC) bo-CN
 Sami, Northern (Sweden) se-SE
 Sami, Lule (Norway) smj-NO
 Assamese (India) as-IN
 Malayalam (India) ml-IN
 Sami, Northern (Finland) se-FI
 Oriya (India) or-IN
 Serbian (Cyrillic, Bosnia and Herzegovina) sr-Cyrl-BA
 Bengali (India) bn-IN
 English (India) en-IN
 Lower Sorbian (Germany) dsb-DE
 Turkmen (Turkmenistan) tk-TM
 Sami, Inari (Finland) smn-FI
 Occitan (France) oc-FR
 Spanish (United States) es-US
 Sami, Northern (Norway) se-NO
 Maltese (Malta) mt-MT
 Bosnian (Latin, Bosnia and Herzegovina) bs-Latn-BA
 isiZulu (South Africa) zu-ZA
 isiXhosa (South Africa) xh-ZA
 Setswana (South Africa) tn-ZA
 Tamazight (Latin, Algeria) tzm-Latn-DZ
 Inuktitut (Latin, Canada) iu-Latn-CA
 Upper Sorbian (Germany) hsb-DE 
 */