IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[core_invoice]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[core_invoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sendMode] [int] NULL,
	[payMode] [int] NULL,
	[price] [numeric](18, 0) NULL,
	[idRandom] [nvarchar](5) NULL,
	[paid] [bit] NULL,
	[orderDate] [datetime] NULL,
 CONSTRAINT [PK_core_invoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
if NOT Exists(select * from sys.columns where Name = N'users_id'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [users_id] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'iranMcTrackingCode'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [iranMcTrackingCode] nvarchar(120) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'core_country_id'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [core_country_id] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'core_country_state_id'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [core_country_state_id] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'core_country_state_city_id'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [core_country_state_city_id] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'core_country_state_city_id'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [core_country_state_city_id] int NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Transferee_Address'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [Transferee_Address] nvarchar(300) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Transferee_ZipCode'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [Transferee_ZipCode] nvarchar(30) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Transferee_Tel'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [Transferee_Tel] nvarchar(80) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'Transferee_CellPhone'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [Transferee_CellPhone] nvarchar(80) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'message'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [message] nvarchar(300) NULL
end 

if NOT Exists(select * from sys.columns where Name = N'sendStatus'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [sendStatus] int NULL
end

if NOT Exists(select * from sys.columns where Name = N'payStatus'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [payStatus] int NULL
end  

if NOT Exists(select * from sys.columns where Name = N'price_send_source'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [price_send_source] [numeric](18, 0) NULL
end  

if NOT Exists(select * from sys.columns where Name = N'price_send_Target'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [price_send_Target] [numeric](18, 0) NULL
end  

if NOT Exists(select * from sys.columns where Name = N'have_cargo_rent_in_Target'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [have_cargo_rent_in_Target] bit NULL
end 

if NOT Exists(select * from sys.columns where Name = N'total_order_price'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [total_order_price] [numeric](18, 0) NULL
end  


----reg_id
if NOT Exists(select * from sys.columns where Name = N'reg_id'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [reg_id] int NULL
Print 'Message: core_invoice.reg_id Table Created'
end 
else
begin
Print 'Message: core_invoice.reg_id Table Exist'
end

----reg_email
if NOT Exists(select * from sys.columns where Name = N'reg_email'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [reg_email] [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_email] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_email] Table Exist'
end

----reg_fname
if NOT Exists(select * from sys.columns where Name = N'reg_fname'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_fname [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_fname] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_fname] Table Exist'
end

----reg_lname
if NOT Exists(select * from sys.columns where Name = N'reg_lname'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [reg_lname] [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_lname] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_lname] Table Exist'
end

----reg_company
if NOT Exists(select * from sys.columns where Name = N'reg_company'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [reg_company] [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_company] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_company] Table Exist'
end

----reg_company
if NOT Exists(select * from sys.columns where Name = N'reg_company'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [reg_company] [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_company] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_company] Table Exist'
end

----reg_tel
if NOT Exists(select * from sys.columns where Name = N'reg_tel'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_tel [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_tel] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_tel] Table Exist'
end

----reg_fax
if NOT Exists(select * from sys.columns where Name = N'reg_fax'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_fax [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_fax] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_fax] Table Exist'
end

----reg_cellphone
if NOT Exists(select * from sys.columns where Name = N'reg_cellphone'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD [reg_cellphone] [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_cellphone] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_cellphone] Table Exist'
end

----reg_country
if NOT Exists(select * from sys.columns where Name = N'reg_country'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_country [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_country] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_country] Table Exist'
end

----reg_stats
if NOT Exists(select * from sys.columns where Name = N'reg_stats'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_stats [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_stats] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_stats] Table Exist'
end

----reg_city
if NOT Exists(select * from sys.columns where Name = N'reg_city'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_city [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_city] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_city] Table Exist'
end


----reg_address
if NOT Exists(select * from sys.columns where Name = N'reg_address'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_address [nvarchar](255) NULL
Print 'Message: core_invoice.[reg_address] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_address] Table Exist'
end

----reg_zipcode
if NOT Exists(select * from sys.columns where Name = N'reg_zipcode'  and Object_ID = Object_ID(N'core_invoice')) 
begin  
 -- Column Exists 
 ALTER TABLE core_invoice ADD reg_zipcode [nvarchar](50) NULL
Print 'Message: core_invoice.[reg_zipcode] Table Created'
end 
else
begin
Print 'Message: core_invoice.[reg_zipcode] Table Exist'
end

