/****** Object:  Table [dbo].[estate]    Script Date: 08/21/2010 19:34:09 ******/
CREATE TABLE [dbo].[estate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[author] [nvarchar](120) NULL,
	[author_email] [nvarchar](50) NULL,
	[translator_name] [nvarchar](120) NULL,
	[users_rate] [int] NULL,
	[title] [nvarchar](150) NULL,
	[title_fa] [nvarchar](150) NULL,
	[description] [nvarchar](max) NULL,
	[image] [nvarchar](255) NULL,
	[Language] [nvarchar](40) NULL,
	[page] [nvarchar](max) NULL,
	[url] [nvarchar](120) NULL,
	[enable] [bit] NULL,
	[keywords] [nvarchar](120) NULL,
	[pub_date] [datetime] NULL,
	[description_robot] [nvarchar](255) NULL,
	[Enable_Show] [bit] NULL,
	[update_date] [datetime] NULL,
	[update_user] [int] NULL,
	[update_user_mode] [int] NULL,
	[country_id] [int] NULL,
	[country_state_id] [int] NULL,
	[country_state_city_id] [int] NULL,
	[core_country_state_city_area_id] [int] NULL,
	[address] [nvarchar](300) NULL,
	[number] [nvarchar](50) NULL,
	[zipCode] [nvarchar](50) NULL,
	[type] [int] NULL,
	[agreement_type] [int] NULL,
	[docType] [int] NULL,
	[landlord_fname] [nvarchar](50) NULL,
	[landlord_lname] [nvarchar](50) NULL,
	[landlord_email] [nvarchar](50) NULL,
	[landlord_tel] [nvarchar](50) NULL,
	[landlord_cellPhone] [nvarchar](50) NULL,
	[metrazh] [int] NULL,
	[tedadeOtagh] [int] NULL,
	[tabaghe] [int] NULL,
	[tedadeTabaghat] [int] NULL,
	[JameVahedHa] [int] NULL,
	[nama] [nvarchar](255) NULL,
	[sokonatStatus] [int] NULL,
	[seneBana] [int] NULL,
	[bazsaziShode] [bit] NULL,
	[kabinet] [nvarchar](255) NULL,
	[wc] [nvarchar](255) NULL,
	[kafpoosh] [nvarchar](255) NULL,
	[meterPrice] [numeric](24, 0) NULL,
	[totalPrice] [numeric](24, 0) NULL,
	[VadiePrice] [numeric](24, 0) NULL,
	[EjarePrice] [numeric](24, 0) NULL,
	[tedadeParking] [int] NULL,
	[tedadeTel] [int] NULL,
	[anbari] [bit] NULL,
	[balkon] [bit] NULL,
	[OpenKitchen] [bit] NULL,
	[shoomine] [bit] NULL,
	[shofazh] [bit] NULL,
	[chiler] [bit] NULL,
	[FanCoil] [bit] NULL,
	[package] [bit] NULL,
	[cooler] [bit] NULL,
	[pool] [bit] NULL,
	[Sauna] [bit] NULL,
	[Jacuzzi] [bit] NULL,
	[Elevator] [bit] NULL,
	[Barbecue] [bit] NULL,
	[VideoIPhone] [bit] NULL,
	[CCTV] [bit] NULL,
	[RemoteDoor] [bit] NULL,
	[CentralAntenna] [bit] NULL,
	[CentralInternet] [bit] NULL,
	[Backyard] [bit] NULL,
	[Landscape] [bit] NULL,
	[Lobby] [bit] NULL,
	[communitiesHall] [bit] NULL,
	[watchMan] [bit] NULL,
	[Patio] [bit] NULL,
	[FireFighting] [bit] NULL,
	[wasteShoting] [bit] NULL,
 CONSTRAINT [PK_estate_content] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



GO
if NOT Exists(select * from sys.columns where Name = N'tourFileName'  and Object_ID = Object_ID(N'estate')) 
begin  
 -- Column Exists 
 ALTER TABLE estate ADD [tourFileName] [nvarchar](50) NULL
end 













