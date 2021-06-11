using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace khatam
{
   public static  class estate
    {
        public struct estateItem
        {
            public string returnCode;
            public string returnMessage;

            public  int id;

	
public string 	title;
	
	public string description;
	public string image;
	public string Language;
	public string page;
	public string url;	
	public DateTime? pub_date;
    public DateTime? update_date;	
	public int?  country_id; 
	public int? country_state_id;
	public int? country_state_city_id;
	public int? core_country_state_city_area_id;
	public string address;
	public string number;
	public string zipCode;
	public int? type;
	public int? agreement_type;
	public int? docType;
	public string landlord_fname;
	public string landlord_lname;
	public string landlord_email;
	public string landlord_tel;
	public string landlord_cellPhone;
	public int? metrazh;
	public int? tedadeOtagh;
	public int? tabaghe;
	public int? tedadeTabaghat;
	public int? JameVahedHa;
	public string nama;
	public int? sokonatStatus;
	public int? seneBana;
	public bool?  bazsaziShode;
	public string kabinet;
	public string wc; 
	public string kafpoosh;
	public string meterPrice;
	public string totalPrice;
	public string VadiePrice;
	public string EjarePrice;
	public int?  tedadeParking;
	public int?  tedadeTel;
	public bool?  anbari;
	public bool?  balkon;
	public bool?  OpenKitchen;
	public bool?  shoomine;
	public bool?  shofazh;
	public bool?  chiler;
	public bool?  FanCoil;
	public bool?  package;
	public bool?  cooler;
	public bool?  pool; 
	public bool?  Sauna; 
	public bool?  Jacuzzi;
	public bool?  Elevator; 
	public bool?  Barbecue;
	public bool?  VideoIPhone;
	public bool?  CCTV;
	public bool?  RemoteDoor;
	public bool?  CentralAntenna;
	public bool?  CentralInternet;
	public bool?  Backyard;
	public bool?  Landscape;
	public bool?  Lobby;
	public bool?  communitiesHall;
	public bool?  watchMan;
	public bool?  Patio;
	public bool?  FireFighting;
	public bool?  wasteShoting;
	public string   tourFileName;
            

        }



        public static estateItem  getEstate(string estate_id)
        {
            estateItem ci = new estateItem();
            Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


            parameters.Add("id",khatam.core.Security.input.removeInjectionChars( estate_id ));


            DataTable dt = new DataTable();

            string str_sql="SELECT [id]"
            + " ,[author]" /*1*/
            + " ,[author_email]" /*2*/
            + " ,[translator_name]" /*3*/
            + " ,[users_rate]" /*4*/
            + " ,[title]" /*5*/
            + " ,[title_fa]" /*6*/
            + " ,[description]" /*7*/
            + " ,[image]" /*8*/
            + " ,[Language]" /*9*/
            + " ,[page]" /*10*/
            + " ,[url]" /*11*/
            + " ,[enable]" /*12*/
            + " ,[keywords]" /*13*/
            + " ,[pub_date]" /*14*/
            + " ,[description_robot]" /*15*/
            + " ,[Enable_Show]" /*16*/
            + " ,[update_date]" /*17*/
            + " ,[update_user]" /*18*/
            + " ,[update_user_mode]" /*19*/
            + " ,[country_id]" /*20*/
            + " ,[country_state_id]" /*21*/
            + " ,[country_state_city_id]" /*22*/
            + " ,[core_country_state_city_area_id]" /*23*/
            + " ,[address]" /*24*/
            + " ,[number]" /*25*/
            + " ,[zipCode]" /*26*/
            + " ,[type]" /*27*/
            + " ,[agreement_type]" /*28*/
            + " ,[docType]" /*29*/
            + " ,[landlord_fname]" /*30*/
            + " ,[landlord_lname]" /*31*/
            + " ,[landlord_email]" /*32*/
            + " ,[landlord_tel]" /*33*/
            + " ,[landlord_cellPhone]" /*34*/
            + " ,[metrazh]" /*35*/
            + " ,[tedadeOtagh]" /*36*/
            + " ,[tabaghe]" /*37*/
            + " ,[tedadeTabaghat]" /*38*/
            + " ,[JameVahedHa]" /*39*/
            + " ,[nama]" /*40*/
            + " ,[sokonatStatus]" /*41*/
            + " ,[seneBana]" /*42*/
            + " ,[bazsaziShode]" /*43*/
            + " ,[kabinet]" /*44*/
            + " ,[wc]" /*45*/
            + " ,[kafpoosh]"/*46*/
            + " ,[meterPrice]"/*47*/
            + " ,[totalPrice]"/*48*/
            + " ,[VadiePrice]"/*49*/
            + " ,[EjarePrice]"/*50*/
            + " ,[tedadeParking]"/*51*/
            + " ,[tedadeTel]"/*52*/
            + " ,[anbari]"/*53*/
            + " ,[balkon]"/*54*/
            + " ,[OpenKitchen]"/*55*/
            + " ,[shoomine]"/*56*/
            + " ,[shofazh]"/*57*/
            + " ,[chiler]"/*58*/
            + " ,[FanCoil]"/*59*/
            + " ,[package]"/*60*/
            + " ,[cooler]"/*61*/
            + " ,[pool]"/*62*/
            + " ,[Sauna]"/*63*/
            + " ,[Jacuzzi]"/*64*/
            + " ,[Elevator]"/*65*/
            + " ,[Barbecue]"/*66*/
            + " ,[VideoIPhone]"/*67*/
            + " ,[CCTV]"/*68*/
            + " ,[RemoteDoor]"/*69*/
            + " ,[CentralAntenna]"/*70*/
            + " ,[CentralInternet]"/*71*/
            + " ,[Backyard]"/*72*/
            + " ,[Landscape]"/*73*/
            + " ,[Lobby]"/*74*/
            + " ,[communitiesHall]"/*75*/
            + " ,[watchMan]"/*76*/
            + " ,[Patio]"/*77*/
            + " ,[FireFighting]"/*78*/
            + " ,[wasteShoting]"/*79*/
            + " ,[tourFileName]"/*80*/
            + " FROM [estate]"
            + " where (id=@id)";

            dt = DBFunctions.ExecuteReader(str_sql , parameters, System.Data.CommandType.Text , khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


            ci.id =int.Parse( dt.Rows[0].ItemArray[0].ToString());
            ci.title  = dt.Rows[0].ItemArray[5].ToString();
            ci.description= dt.Rows[0].ItemArray[7].ToString();
            ci.image = dt.Rows[0].ItemArray[8].ToString();
            ci.page  = dt.Rows[0].ItemArray[10].ToString();
            ci.url   = dt.Rows[0].ItemArray[11].ToString();
          

           if (dt.Rows[0].ItemArray[14].ToString() == "")                           
                ci.pub_date = null;                
            else
                ci.pub_date = DateTime.Parse(dt.Rows[0].ItemArray[14].ToString()); 

           if (dt.Rows[0].ItemArray[17].ToString() == "")                           
                ci.update_date = null;                
            else
                ci.update_date = DateTime.Parse(dt.Rows[0].ItemArray[17].ToString());

            if (dt.Rows[0].ItemArray[20].ToString() == "")                           
                 ci.country_id = null ;
             else
            ci.country_id   =int.Parse( dt.Rows[0].ItemArray[20].ToString());


              if (dt.Rows[0].ItemArray[21].ToString() == "")                           
                 ci.country_state_id = null ;
             else
            ci.country_state_id   =int.Parse( dt.Rows[0].ItemArray[21].ToString());

              if (dt.Rows[0].ItemArray[22].ToString() == "")                           
                 ci.country_state_city_id = null ;
             else
            ci.country_state_city_id   =int.Parse( dt.Rows[0].ItemArray[22].ToString());

              if (dt.Rows[0].ItemArray[23].ToString() == "")                           
                 ci.core_country_state_city_area_id = null ;
             else
            ci.core_country_state_city_area_id   =int.Parse( dt.Rows[0].ItemArray[23].ToString());


            ci.address    = dt.Rows[0].ItemArray[24].ToString();
            ci.number  = dt.Rows[0].ItemArray[25].ToString();
            ci.zipCode  = dt.Rows[0].ItemArray[26].ToString();

            if (dt.Rows[0].ItemArray[27].ToString() == "")  
            ci.type=null;
            else
            ci.type  = int.Parse(dt.Rows[0].ItemArray[27].ToString());


            if (dt.Rows[0].ItemArray[28].ToString() == "")
            ci.agreement_type = null;
            else
            ci.agreement_type  = int.Parse(dt.Rows[0].ItemArray[28].ToString());


            if (dt.Rows[0].ItemArray[29].ToString() == "")
                ci.docType = null;
            else
                ci.docType = int.Parse(dt.Rows[0].ItemArray[29].ToString());


            ci.landlord_fname    = dt.Rows[0].ItemArray[30].ToString();
            ci.landlord_lname    = dt.Rows[0].ItemArray[31].ToString();
            ci.landlord_email    = dt.Rows[0].ItemArray[32].ToString();
            ci.landlord_tel    = dt.Rows[0].ItemArray[33].ToString();
            ci.landlord_cellPhone  = dt.Rows[0].ItemArray[34].ToString();

            if (dt.Rows[0].ItemArray[35].ToString() == "")
                ci.metrazh = null;
            else
                ci.metrazh = int.Parse(dt.Rows[0].ItemArray[35].ToString());

            if (dt.Rows[0].ItemArray[36].ToString() == "")
                ci.tedadeOtagh = null;
            else
                ci.tedadeOtagh = int.Parse(dt.Rows[0].ItemArray[36].ToString());

            if (dt.Rows[0].ItemArray[37].ToString() == "")
                ci.tabaghe = null;
            else
                ci.tabaghe = int.Parse(dt.Rows[0].ItemArray[37].ToString());

            if (dt.Rows[0].ItemArray[38].ToString() == "")
                ci.tedadeTabaghat = null;
            else
                ci.tedadeTabaghat = int.Parse(dt.Rows[0].ItemArray[38].ToString());

            if (dt.Rows[0].ItemArray[39].ToString() == "")
                ci.JameVahedHa = null;
            else
                ci.JameVahedHa = int.Parse(dt.Rows[0].ItemArray[39].ToString());

            if (dt.Rows[0].ItemArray[40].ToString() == "")
                ci.nama = null;
            else
                ci.nama = dt.Rows[0].ItemArray[40].ToString();

            if (dt.Rows[0].ItemArray[41].ToString() == "")
                ci.sokonatStatus = null;
            else
                ci.sokonatStatus = int.Parse(dt.Rows[0].ItemArray[41].ToString());

            if (dt.Rows[0].ItemArray[42].ToString() == "")
                ci.seneBana = null;
            else
                ci.seneBana = int.Parse(dt.Rows[0].ItemArray[42].ToString());
            
            if (dt.Rows[0].ItemArray[43].ToString() == "")                           
                ci.bazsaziShode = null;                
            else
                ci.bazsaziShode = bool.Parse(dt.Rows[0].ItemArray[43].ToString());    

            ci.kabinet    = dt.Rows[0].ItemArray[44].ToString();
            ci.wc    = dt.Rows[0].ItemArray[45].ToString();
            ci.kafpoosh    = dt.Rows[0].ItemArray[46].ToString();
            ci.meterPrice    =dt.Rows[0].ItemArray[47].ToString();
            ci.totalPrice    =dt.Rows[0].ItemArray[48].ToString();
            ci.VadiePrice    =dt.Rows[0].ItemArray[49].ToString();
            ci.EjarePrice    =dt.Rows[0].ItemArray[50].ToString();

            if (dt.Rows[0].ItemArray[51].ToString() == "")
                ci.tedadeParking = null;
            else
                ci.tedadeParking = int.Parse(dt.Rows[0].ItemArray[51].ToString());

            if (dt.Rows[0].ItemArray[52].ToString() == "")
                ci.tedadeTel = null;
            else 
            ci.tedadeTel    =int.Parse( dt.Rows[0].ItemArray[52].ToString());

   if (dt.Rows[0].ItemArray[53].ToString() == "")                           
                ci.anbari = null;                
            else
                ci.anbari = bool.Parse(dt.Rows[0].ItemArray[53].ToString());

      if (dt.Rows[0].ItemArray[54].ToString() == "")                           
 ci.balkon = null;                
else
 ci.balkon = bool.Parse(dt.Rows[0].ItemArray[54].ToString()); 

if (dt.Rows[0].ItemArray[55].ToString() == "")                           
 ci.OpenKitchen = null;                
else
 ci.OpenKitchen = bool.Parse(dt.Rows[0].ItemArray[55].ToString()); 

if (dt.Rows[0].ItemArray[56].ToString() == "")                           
 ci.shoomine = null;                
else
 ci.shoomine = bool.Parse(dt.Rows[0].ItemArray[56].ToString()); 

if (dt.Rows[0].ItemArray[57].ToString() == "")                           
 ci.shofazh = null;                
else
 ci.shofazh = bool.Parse(dt.Rows[0].ItemArray[57].ToString()); 

if (dt.Rows[0].ItemArray[58].ToString() == "")                           
 ci.chiler = null;                
else
 ci.chiler = bool.Parse(dt.Rows[0].ItemArray[58].ToString()); 
            
if (dt.Rows[0].ItemArray[59].ToString() == "")                           
 ci.FanCoil = null;                
else
 ci.FanCoil = bool.Parse(dt.Rows[0].ItemArray[59].ToString()); 

if (dt.Rows[0].ItemArray[60].ToString() == "")                           
 ci.package = null;                
else
 ci.package = bool.Parse(dt.Rows[0].ItemArray[60].ToString()); 

if (dt.Rows[0].ItemArray[61].ToString() == "")                           
 ci.cooler = null;                
else
 ci.cooler = bool.Parse(dt.Rows[0].ItemArray[61].ToString()); 

if (dt.Rows[0].ItemArray[62].ToString() == "")                           
 ci.pool = null;                
else
 ci.pool = bool.Parse(dt.Rows[0].ItemArray[62].ToString()); 

if (dt.Rows[0].ItemArray[63].ToString() == "")                           
 ci.Sauna = null;                
else
 ci.Sauna = bool.Parse(dt.Rows[0].ItemArray[63].ToString()); 

if (dt.Rows[0].ItemArray[64].ToString() == "")                           
 ci.Jacuzzi = null;                
else
 ci.Jacuzzi = bool.Parse(dt.Rows[0].ItemArray[64].ToString()); 

if (dt.Rows[0].ItemArray[65].ToString() == "")                           
 ci.Elevator = null;                
else
 ci.Elevator = bool.Parse(dt.Rows[0].ItemArray[65].ToString()); 


if (dt.Rows[0].ItemArray[66].ToString() == "")                           
 ci.Barbecue = null;                
else
 ci.Barbecue = bool.Parse(dt.Rows[0].ItemArray[66].ToString()); 

if (dt.Rows[0].ItemArray[67].ToString() == "")                           
 ci.VideoIPhone = null;                
else
 ci.VideoIPhone = bool.Parse(dt.Rows[0].ItemArray[67].ToString()); 

if (dt.Rows[0].ItemArray[68].ToString() == "")                           
 ci.CCTV = null;                
else
 ci.CCTV = bool.Parse(dt.Rows[0].ItemArray[68].ToString()); 

if (dt.Rows[0].ItemArray[69].ToString() == "")                           
 ci.RemoteDoor = null;                
else
 ci.RemoteDoor = bool.Parse(dt.Rows[0].ItemArray[69].ToString()); 


if (dt.Rows[0].ItemArray[70].ToString() == "")                           
 ci.CentralAntenna = null;                
else
 ci.CentralAntenna = bool.Parse(dt.Rows[0].ItemArray[70].ToString()); 


if (dt.Rows[0].ItemArray[71].ToString() == "")                           
 ci.CentralInternet = null;                
else
 ci.CentralInternet = bool.Parse(dt.Rows[0].ItemArray[71].ToString()); 


if (dt.Rows[0].ItemArray[72].ToString() == "")                           
 ci.Backyard = null;                
else
 ci.Backyard = bool.Parse(dt.Rows[0].ItemArray[72].ToString()); 

if (dt.Rows[0].ItemArray[73].ToString() == "")                           
 ci.Landscape = null;                
else
 ci.Landscape = bool.Parse(dt.Rows[0].ItemArray[73].ToString()); 

if (dt.Rows[0].ItemArray[74].ToString() == "")                           
 ci.Lobby = null;                
else
 ci.Lobby = bool.Parse(dt.Rows[0].ItemArray[74].ToString()); 

if (dt.Rows[0].ItemArray[75].ToString() == "")                           
 ci.communitiesHall = null;                
else
 ci.communitiesHall = bool.Parse(dt.Rows[0].ItemArray[75].ToString()); 

if (dt.Rows[0].ItemArray[76].ToString() == "")                           
 ci.watchMan = null;                
else
 ci.watchMan = bool.Parse(dt.Rows[0].ItemArray[76].ToString()); 

if (dt.Rows[0].ItemArray[77].ToString() == "")                           
 ci.Patio = null;                
else
 ci.Patio = bool.Parse(dt.Rows[0].ItemArray[77].ToString()); 

if (dt.Rows[0].ItemArray[78].ToString() == "")                           
 ci.FireFighting = null;                
else
 ci.FireFighting = bool.Parse(dt.Rows[0].ItemArray[78].ToString()); 

if (dt.Rows[0].ItemArray[79].ToString() == "")                           
 ci.wasteShoting = null;                
else
 ci.wasteShoting = bool.Parse(dt.Rows[0].ItemArray[79].ToString()); 

ci.tourFileName  = dt.Rows[0].ItemArray[80].ToString(); 

       





           // HttpContext.Current.Response.Write(dt.Rows[0].ItemArray[43].ToString());

            



            
           // else
           // {
            //    ci.bazsaziShode = null;
           // }

            /*ci.fname = dt.Rows[0].ItemArray[2].ToString();
            ci.lname = dt.Rows[0].ItemArray[3].ToString();
            ci.id_language = dt.Rows[0].ItemArray[4].ToString();
            ci.company = dt.Rows[0].ItemArray[5].ToString();
            ci.tel = dt.Rows[0].ItemArray[6].ToString();
            ci.fax = dt.Rows[0].ItemArray[7].ToString();
            ci.cellphone = dt.Rows[0].ItemArray[8].ToString();
            ci.country = dt.Rows[0].ItemArray[9].ToString();
            ci.stats = dt.Rows[0].ItemArray[10].ToString();
            ci.city = dt.Rows[0].ItemArray[11].ToString();
            ci.address = dt.Rows[0].ItemArray[12].ToString();
            ci.zipcode = dt.Rows[0].ItemArray[13].ToString();
            ci.active = dt.Rows[0].ItemArray[14].ToString();
            ci.suspended = dt.Rows[0].ItemArray[15].ToString();

              public  int id;

	
public string 	title;
	
	public string description;
	public string image;
	public string Language;
	public string page;
	public string url;
	public string enable;
	public string keywords;
	public DateTime pub_date;
    public DateTime update_date;	
	public int  country_id; 
	public int country_state_id;
	public int country_state_city_id;
	public int core_country_state_city_area_id;
	public string address;
	public string number;
	public string zipCode;
	public int type;
	public int agreement_type;
	public int docType;
	public string landlord_fname;
	public string landlord_lname;
	public string landlord_email;
	public string landlord_tel;
	public string landlord_cellPhone;
	public int metrazh;
	public int tedadeOtagh;
	public int tabaghe;
	public int tedadeTabaghat;
	public int JameVahedHa;
	public string nama;
	public int sokonatStatus;
	public int seneBana;
	public bool  bazsaziShode;
            */
            return ci;

            //Error Table
            // 1 right
            // -1 Database Error
            // -2 Item Not found
            // -3 Disable
            // -4 Deleted
            // -5 Not Valid
        }


        public static DataTable getTableEstate_type()
        {
            string str_sql;
            Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


            //parameters.Add("field_where_value", field_where_value);
            str_sql = "SELECT   estate_type.id, Dictionary_Lang.title  FROM         estate_type INNER JOIN             Dictionary_Lang ON estate_type.dictionary_id = Dictionary_Lang.id_dictionary";
            return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }


    }
}
