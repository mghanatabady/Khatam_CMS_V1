using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace khatam
{
    namespace shop
    {
        
      
               public static class shopCart
            {
                   public static string AddToShopCart(string catid, int Quantity, int payCycleId, string title, string domain)
                    {


                        DataSet ds = new DataSet();
                        DataSet dsc = new DataSet();
                     
                        dsc = (DataSet) HttpContext.Current.Session["ds"];
                       
                        try
                        {
                            if (dsc.Tables.Count > 0)
                            {
                                ds = (DataSet)HttpContext.Current.Session["ds"];

                            }
                        }
                        catch
                        {
                        }


                        DataColumn col_catid = new DataColumn();
                        col_catid.ColumnName = "catid";

                        DataColumn col_productname = new DataColumn();
                        col_productname.ColumnName = "productname";

                        DataColumn col_manufact = new DataColumn();
                        col_manufact.ColumnName = "manufac";

                        DataColumn col_quantity = new DataColumn();
                        col_quantity.ColumnName = "quantity";

                        DataColumn col_price = new DataColumn();
                        col_price.ColumnName = "price";

                        DataColumn col_sum = new DataColumn();
                        col_sum.ColumnName = "sum";

                        DataColumn col_payCycle = new DataColumn();
                        col_payCycle.ColumnName = "payCycle";

                        DataColumn col_weight = new DataColumn();
                        col_weight.ColumnName = "weight";

                        DataColumn col_Totalweight = new DataColumn();
                        col_Totalweight.ColumnName = "Totalweight";

                        DataColumn col_iranmc = new DataColumn();
                        col_iranmc.ColumnName = "iranmc";

                        DataColumn col_virtual = new DataColumn();
                        col_virtual.ColumnName = "virtual";
                                   

                        DataColumn col_type_content = new DataColumn();
                        col_type_content.ColumnName = "type_content";

                        DataColumn col_domain = new DataColumn();
                        col_domain.ColumnName = "col_domain";

                      // string type_content

                        DataRow newrow;//= new DataRow();

                        DataTable newtable = new DataTable();

                        //تعریف جدول جدید
                        //فقط در بار اول
                        if (ds.Tables.Count < 1)
                        {

                            ds.Tables.Add(newtable);

                            //تعریف ستون ها در جدول
                            ds.Tables[0].Columns.Add(col_catid);//0
                            ds.Tables[0].Columns.Add(col_productname);//1
                            ds.Tables[0].Columns.Add(col_manufact);//2
                            ds.Tables[0].Columns.Add(col_quantity);//3
                            ds.Tables[0].Columns.Add(col_price);//4
                            ds.Tables[0].Columns.Add(col_sum);//5
                            ds.Tables[0].Columns.Add(col_payCycle);//6
                            ds.Tables[0].Columns.Add(col_weight);//7
                            ds.Tables[0].Columns.Add(col_Totalweight);//8
                            ds.Tables[0].Columns.Add(col_iranmc);//9
                            ds.Tables[0].Columns.Add(col_virtual);//10                      
                            ds.Tables[0].Columns.Add(col_type_content);//11
                            ds.Tables[0].Columns.Add(col_domain);//12
                            
                            
                            
                        }

                        string type_content =
                            khatam.core.data.sql.getField( "type_content","id",catid,"cat");

                        if (type_content == "shop")
                        {
                            string productID = khatam.core.data.sql.getField( "id_content", "id", catid, "cat");

                            newrow = ds.Tables[0].NewRow();
                            newrow[0] = catid;
                            newrow[1] =   khatam.core.data.sql.getField( "title", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("HL_Title"), HyperLink).Text;
                            newrow[2] = 0; //CType(Me.GridView1.Rows(0).Cells(0).FindControl("Lbl_id_iranmc"), Label).Text;
                            newrow[3] = Quantity;
                            int price = int.Parse(getPrice(Quantity, catid).Rows[0].ItemArray[0].ToString());
                            newrow[4] = price;
                            newrow[5] = Quantity * price;
                            newrow[6] = null;// months
                            int weight = int.Parse( khatam.core.data.sql.getField( "weight", "id", productID, "shop"));
                            newrow[7] = weight; 
                            newrow[8] = Quantity * weight;
                            newrow[9] = getPrice(Quantity, catid).Rows[0].ItemArray[1].ToString();
                            newrow[10] = false;
                            newrow[11] = "shop";
                            newrow[12] = "";

                   


                            //khatam.core.data.sql.getField("AddToShopCart", "price_in_rls", "id", productID, "shop");



                        ds.Tables[0].Rows.Add(newrow);
                        }
                        if (type_content == "domain")
                        {
                            newrow = ds.Tables[0].NewRow();
                            newrow[0] = catid; //productID;//
                            newrow[1] = title.ToString(); // months + " ماه " +khatam.core.data.sql.getField("AddToShopCart", "title", "id", productID, "domain") ; //CType(Me.GridView1.Rows(0).Cells(0).FindControl("HL_Title"), HyperLink).Text;
                            newrow[2] = 1;//khatam.core.data.sql.getField("AddToShopCart", "id_iranmc", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("Lbl_id_iranmc"), Label).Text;
                            newrow[3] = 1;//Quantity;
                            int price = int.Parse( khatam.core.data.sql.getField("addToShopCartDomain", "price", "id", payCycleId.ToString(), "core_paycycle",
                                khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));
                                //int.Parse(getPrice(Quantity, catid));
                            newrow[4] = price;
                            newrow[5] = price;// Quantity* price;
                            int month = int.Parse(khatam.core.data.sql.getField("addToShopCartDomain", "month", "id", payCycleId.ToString(), "core_paycycle",
                              khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));
                            newrow[6] = month;// months
                            newrow[7] = 0;
                            newrow[8] = 0;
                            newrow[9] = "";
                            newrow[10] = true;
                            newrow[11] = "domain";
                            newrow[12] = domain;



                            //khatam.core.data.sql.getField("AddToShopCart", "price_in_rls", "id", productID, "shop");



                            ds.Tables[0].Rows.Add(newrow);
                        }


                        if (type_content == "host")
                        {
                            newrow = ds.Tables[0].NewRow();                           
                            newrow[0] = catid;//khatam.core.data.sql.getField("AddToShopCart", "id", "id", productID, "shop");
                            newrow[1] =title;//khatam.core.data.sql.getField("AddToShopCart", "title", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("HL_Title"), HyperLink).Text;
                            newrow[2] = "123456" ;//khatam.core.data.sql.getField("AddToShopCart", "id_iranmc", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("Lbl_id_iranmc"), Label).Text;
                            newrow[3] = 1;
                            int price = int.Parse(khatam.core.data.sql.getField("addToShopCartDomain", "price", "id", payCycleId.ToString(), "core_paycycle",
                             khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));

                            newrow[4] = price;
                            newrow[5] = price;
                            int month = int.Parse(khatam.core.data.sql.getField("addToShopCartDomain", "month", "id", payCycleId.ToString(), "core_paycycle",
                              khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));
                            newrow[6] =  month;// months
                            newrow[7] =0;
                            newrow[8] = 0;
                            newrow[9] = ""; //getPrice(Quantity, catid).Rows[0].ItemArray[1].ToString();
                            newrow[10] = true;
                            newrow[11] = "host";
                            newrow[12] = domain;


                            //khatam.core.data.sql.getField("AddToShopCart", "price_in_rls", "id", productID, "shop");



                            ds.Tables[0].Rows.Add(newrow);
                        }


                        if (type_content == "portal")
                        {
                            newrow = ds.Tables[0].NewRow();
                            newrow[0] = catid;//khatam.core.data.sql.getField("AddToShopCart", "id", "id", productID, "shop");
                            newrow[1] = title;//khatam.core.data.sql.getField("AddToShopCart", "title", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("HL_Title"), HyperLink).Text;
                            newrow[2] = "123456";//khatam.core.data.sql.getField("AddToShopCart", "id_iranmc", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("Lbl_id_iranmc"), Label).Text;
                            newrow[3] = 1;
                            int price = int.Parse(khatam.core.data.sql.getField("addToShopCartDomain", "price", "id", payCycleId.ToString(), "core_paycycle",
                             khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));

                            string contentId = khatam.core.data.sql.getField("id_content", "id", catid, "cat");
                            int setupPrice = int.Parse(khatam.core.data.sql.getField( "setupPrice", "id", contentId, "portal"));

                            newrow[4] = price + setupPrice;
                            newrow[5] = price + setupPrice;
                            int month = int.Parse(khatam.core.data.sql.getField("addToShopCartDomain", "month", "id", payCycleId.ToString(), "core_paycycle",
                              khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));
                            newrow[6] = month;// months
                            //int weight = int.Parse(khatam.core.data.sql.getField("AddToShopCart", "weight", "id", productID, "shop"));
                            newrow[7] = 0;
                            newrow[8] = 0;
                            newrow[9] = ""; //getPrice(Quantity, catid).Rows[0].ItemArray[1].ToString();
                            newrow[10] = true;
                            newrow[11] = "portal";
                            newrow[12] = domain;


                            //khatam.core.data.sql.getField("AddToShopCart", "price_in_rls", "id", productID, "shop");



                            ds.Tables[0].Rows.Add(newrow);
                        }


                        //'خواندن در دیتا ست
                        //'در صورتی که درج ستون دیتا گرید به صورت اتوماتیک غیر فعال باشد ستون تعریف کرده
                        //'به جای نام ستون نام ستون درج شود در اینجا col_productname

                       HttpContext.Current.Session["ds"] = ds;
                        //Me.Label1.Text = CType(Me.GridView1.Rows(0).Cells(0).FindControl("Lbl_id_iranmc"), Label).Text;
                        //Me.MSG2.Visible = True;

                        return "0";
                    }


                   public static DataTable getPrices(string catid)
                   {
                       string str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                       //parameters.Add("field_where_value", field_where_value);
                       str_sql = "SELECT  min,price FROM core_sale_terms where (catid=" + catid + ") order by min ";
                       return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                   }

                   public static string[] GetShopCartArrayID( Page page1)
                   {
                       string[] test = new string[100];
                       

                       DataSet ds = new DataSet();
                       DataSet dsc = new DataSet();
                       dsc = (DataSet)page1.Session["ds"];

                       try
                       {
                           if (dsc.Tables.Count > 0)
                           {
                               ds = (DataSet)page1.Session["ds"];


                               for (int i = 0; i < ds.Tables[0].Rows.Count  ; i++)
                               {
                                   test[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                               }

                               


                           }
                       }
                       catch
                       {
                       }

                       

                             return test ;
                   }


                   public static string[] GetShopCartArrayID_IranMC(Page page1)
                   {
                       string[] test = new string[100];


                       DataSet ds = new DataSet();
                       DataSet dsc = new DataSet();
                       dsc = (DataSet)page1.Session["ds"];

                       try
                       {
                           if (dsc.Tables.Count > 0)
                           {
                               ds = (DataSet)page1.Session["ds"];


                               for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                               {
                                   test[i] = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                               }




                           }
                       }
                       catch
                       {
                       }



                       return test;
                   }

                   public static string checkSendModeGeoSupport(string caller, string ManualsendMode_id, string country_id, string state_id, string city_id)
                   {
                       string str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                       parameters.Add("sendMode_id", ManualsendMode_id);
                       parameters.Add("country_id", country_id);
                       parameters.Add("state_id", state_id);
                       parameters.Add("city_id", city_id);

                      string  str_sql_exist1= "if exists (";
                      string str_sqlMain = ("SELECT     id   FROM         core_sendMode_Instance  WHERE     (city_id = @city_id) AND (state_id = @state_id) AND (country_id = @country_id) AND (sendMode_id = @sendMode_id)");
                       string str_sql_exist2 = ")";
                       string str_sql_exist3 = " else select -1";

                       str_sql = str_sql_exist1 + str_sqlMain + str_sql_exist2 + str_sqlMain + str_sql_exist3;

                       string output;

                       try
                       {
                           /*rerutn */
                           output = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                       }
                       catch /*(Exception ex)*/
                       {
                        // khatam.core.data.sql.ErrorLogAdd("caller:" + caller + " field_target: " +  ex.InnerException + " " + ex.Message);
                      
                           //throw;
                           return "-2";
                       }
                       
                       
                       return output;

                   }


                   public static  DataTable getPrice(int Quantity, string CatId)
                   {
                       string str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                       parameters.Add("Quantity", Quantity);
                       parameters.Add("CatId", CatId);

                       str_sql = "SELECT     TOP (1) price, iranmc    FROM         core_sale_terms   WHERE     (min <= @Quantity) AND (catId = @CatId) ORDER BY price ";
                       
                       
                       
                       //SELECT     MIN(price) AS Expr1 FROM         core_sale_terms WHERE     (min <= @Quantity) AND (catId = @CatId)");
                       return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, 
                           khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                   }


                   public static string getPostPishtazPrice(int weight, string country_id, string state_id, string city_id)
                   {
                       /// country select
                       //string str_sql;
                       string source_state_id="5";
                       string source_city_id="91";
                       int KerayePosti=-1;

                       /*************************  درون شهری***********************/

                       if ((city_id == source_city_id)&& (state_id == source_state_id ))
                       {
                           if (weight <= 250)
                               KerayePosti = 25500;
                           if ((weight > 250) && (weight <= 500))
                               KerayePosti = 30600;
                           if ((weight > 500) && (weight <= 1000))
                               KerayePosti = 37300;
                           if ((weight > 1000) && (weight <= 2000))
                               KerayePosti = 49100;
                           if ((weight > 2000))
                           {
                               int MazakKg;
                               if ((weight % 1000) == 0)
                               {
                                   MazakKg = (weight / 1000)-2;
                               }
                               else
                               {
                                   MazakKg  = ((weight / 1000) + 1)-2;
                               }
                               KerayePosti = 49100 + (MazakKg * 10800);

                           }

                       }
                           /*************************  درون استانی***********************/
                       else if ((city_id != source_city_id) && (state_id == source_state_id))
                       {
                           if (weight <= 250)
                               KerayePosti = 27000;
                           if ((weight > 250) && (weight <= 500))
                               KerayePosti = 32400;
                           if ((weight > 500) && (weight <= 1000))
                               KerayePosti = 39400;
                           if ((weight > 1000) && (weight <= 2000))
                               KerayePosti = 51800;
                           if ((weight > 2000))
                           {
                               int MazakKg;
                               if ((weight % 1000) == 0)
                               {
                                   MazakKg = (weight / 1000) - 2;
                               }
                               else
                               {
                                   MazakKg = ((weight / 1000) + 1) - 2;
                               }
                               KerayePosti = 51800 + (MazakKg * 11300);

                           }
                       }
                       else if ((city_id != source_city_id) && (state_id != source_state_id))
                       {
                           if (check_HamjavariOstan(source_state_id, state_id))
                           {
                               if (weight <= 250)
                                   KerayePosti = 28100;
                               if ((weight > 250) && (weight <= 500))
                                   KerayePosti = 33600;
                               if ((weight > 500) && (weight <= 1000))
                                   KerayePosti = 40900;
                               if ((weight > 1000) && (weight <= 2000))
                                   KerayePosti = 53600;
                               if ((weight > 2000))
                               {
                                   int MazakKg;
                                   if ((weight % 1000) == 0)
                                   {
                                       MazakKg = (weight / 1000) - 2;
                                   }
                                   else
                                   {
                                       MazakKg = ((weight / 1000) + 1) - 2;
                                   }
                                   KerayePosti = 53600 + (MazakKg * 11800);

                               }
                           }
                           else
                           {
                               if (weight <= 250)
                                   KerayePosti = 35300;
                               if ((weight > 250) && (weight <= 500))
                                   KerayePosti = 43400;
                               if ((weight > 500) && (weight <= 1000))
                                   KerayePosti = 53500;
                               if ((weight > 1000) && (weight <= 2000))
                                   KerayePosti = 71800;
                               if ((weight > 2000))
                               {
                                   int MazakKg;
                                   if ((weight % 1000) == 0)
                                   {
                                       MazakKg = (weight / 1000) - 2;
                                   }
                                   else
                                   {
                                       MazakKg = ((weight / 1000) + 1) - 2;
                                   }
                                   KerayePosti = 71800 + (MazakKg * 15300);

                               }
                           }
                       }
                      
                       //Dictionary<string, obj select> parameters = new System.Collections.Generic.Dictionary<string, object>();
                       int hagholSahmPost= KerayePosti+
                           2000 // bime
                          + 5000; // agahi tahvi
                       ///gheymat baste bandi
                       ///gheymat gheyre standard 10 darsad
                       int HazinePostiVaMaliat = hagholSahmPost + ((hagholSahmPost / 100) * 2);
                          
                       //parameters.Add("id", id);

                       //str_sql = ("SELECT    Dictionary_Lang.title   FROM         Shop INNER JOIN                        core_units ON Shop.sale_unit = core_units.id INNER JOIN                        Dictionary_Lang ON core_units.id_dictonary = Dictionary_Lang.id_dictionary  WHERE     (Shop.id = @id) ");
                       //return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text,
                         //  khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                       return HazinePostiVaMaliat.ToString();
                   }

                   public static string getPostSefareshiPrice(int weight, string country_id, string state_id, string city_id)
                   {
                       /// country select
                       //string str_sql;
                       string source_state_id = "5";
                       string source_city_id = "91";
                       int KerayePosti = -1;

                       /*************************  درون شهری***********************/

                       if ((city_id == source_city_id) && (state_id == source_state_id))
                       {
                           if (weight <= 250)
                               KerayePosti = 6900;
                           if ((weight > 250) && (weight <= 500))
                               KerayePosti = 8500;
                           if ((weight > 500) && (weight <= 1000))
                               KerayePosti = 10400;
                           if ((weight > 1000) && (weight <= 2000))
                               KerayePosti = 13800;
                           if ((weight > 2000))
                           {
                               int MazakKg;
                               if ((weight % 1000) == 0)
                               {
                                   MazakKg = (weight / 1000) - 2;
                               }
                               else
                               {
                                   MazakKg = ((weight / 1000) + 1) - 2;
                               }
                               KerayePosti = 13800 + (MazakKg * 8800);

                           }

                       }
                       /*************************  درون استانی***********************/
                       else if ((city_id != source_city_id) && (state_id == source_state_id))
                       {
                           if (weight <= 250)
                               KerayePosti = 7500;
                           if ((weight > 250) && (weight <= 500))
                               KerayePosti = 9200;
                           if ((weight > 500) && (weight <= 1000))
                               KerayePosti = 11300;
                           if ((weight > 1000) && (weight <= 2000))
                               KerayePosti = 15100;
                           if ((weight > 2000))
                           {
                               int MazakKg;
                               if ((weight % 1000) == 0)
                               {
                                   MazakKg = (weight / 1000) - 2;
                               }
                               else
                               {
                                   MazakKg = ((weight / 1000) + 1) - 2;
                               }
                               KerayePosti = 15100 + (MazakKg * 9400);

                           }
                       }
                       else if ((city_id != source_city_id) && (state_id != source_state_id))
                       {
                           if (check_HamjavariOstan(source_state_id, state_id))
                           {
                               if (weight <= 250)
                                   KerayePosti = 7900;
                               if ((weight > 250) && (weight <= 500))
                                   KerayePosti = 9700;
                               if ((weight > 500) && (weight <= 1000))
                                   KerayePosti = 11900;
                               if ((weight > 1000) && (weight <= 2000))
                                   KerayePosti = 15900;
                               if ((weight > 2000))
                               {
                                   int MazakKg;
                                   if ((weight % 1000) == 0)
                                   {
                                       MazakKg = (weight / 1000) - 2;
                                   }
                                   else
                                   {
                                       MazakKg = ((weight / 1000) + 1) - 2;
                                   }
                                   KerayePosti = 15900 + (MazakKg * 13100);

                               }
                           }
                           else
                           {
                               if (weight <= 250)
                                   KerayePosti = 8700;
                               if ((weight > 250) && (weight <= 500))
                                   KerayePosti = 10700;
                               if ((weight > 500) && (weight <= 1000))
                                   KerayePosti = 13200;
                               if ((weight > 1000) && (weight <= 2000))
                                   KerayePosti = 17600;
                               if ((weight > 2000))
                               {
                                   int MazakKg;
                                   if ((weight % 1000) == 0)
                                   {
                                       MazakKg = (weight / 1000) - 2;
                                   }
                                   else
                                   {
                                       MazakKg = ((weight / 1000) + 1) - 2;
                                   }
                                   KerayePosti = 17600 + (MazakKg * 10600);

                               }
                           }
                       }

                       //Dictionary<string, obj select> parameters = new System.Collections.Generic.Dictionary<string, object>();
                       int hagholSahmPost = KerayePosti +
                           2000 // bime
                          + 5000; // agahi tahvi
                       ///gheymat baste bandi
                       ///gheymat gheyre standard 10 darsad
                       int HazinePostiVaMaliat = hagholSahmPost + ((hagholSahmPost / 100) * 2) + 15000;
                       
                       //parameters.Add("id", id);

                       //str_sql = ("SELECT    Dictionary_Lang.title   FROM         Shop INNER JOIN                        core_units ON Shop.sale_unit = core_units.id INNER JOIN                        Dictionary_Lang ON core_units.id_dictonary = Dictionary_Lang.id_dictionary  WHERE     (Shop.id = @id) ");
                       //return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text,
                       //  khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                       return HazinePostiVaMaliat.ToString();
                   }

                   public static bool check_HamjavariOstan(string source_state_id, string state_id)
                   {
                       switch (source_state_id )
                       {
                           case "1":
                                switch (state_id )
	                            {
		                            case "3":
                                    case "14":
                                    case "2":
                                        return true ;
	                            }                               
                           break;
                           case "2":
                           switch (state_id)
                           {
                               case "3":
                               case "14":
                               case "2":
                                   return true;
                           }
                           break;
                           case "3":
                           switch (state_id)
                           {
                               case "25":
                               case "14":
                               case "1":
                                   return true;
                           }
                           break;
                           case "4":
                           switch (state_id)
                           {
                               case "19":
                               case "28":
                               case "26":
                               case "9":
                               case "17":
                               case "23":
                               case "31":
                               case "15":
                                   return true;
                           }
                           break;
                           case "5":
                           switch (state_id)
                           {
                               case "18":
                               case "28":
                               case "27":
                               case "8":
                                   return true;
                           }
                           break;
                           case "6":
                           switch (state_id)
                           {
                               case "22":
                               case "26":
                               case "13":                              
                                   return true;
                           }
                           break;
                           case "7":
                           switch (state_id)
                           {
                               case "29":
                               case "17":
                               case "23":
                               case "13":
                                   return true;
                           }
                           break;
                           case "8":
                           switch (state_id)
                           {
                               case "5":
                               case "28":
                               case "19":
                               case "27":
                               case "15":
                                   return true;
                           }
                           break;
                           case "9":
                           switch (state_id)
                           {
                               case "13":
                               case "23":
                               case "4":                               
                                   return true;
                           }
                           break;
                           case "10":
                           switch (state_id)
                           {
                               case "11":
                               case "31":
                               case "21":
                               case "16":
                                   return true;
                           }
                           break;
                           case "11":
                           switch (state_id)
                           {
                               case "12":
                               case "15":
                               case "31":
                               case "10":
                                   return true;
                           }
                           break;
                           case "12":
                           switch (state_id)
                           {
                               case "24":
                               case "15":
                               case "11":                               
                                   return true;
                           }
                           break;
                           case "13":
                           switch (state_id)
                           {
                               case "6":
                               case "26":
                               case "9":
                               case "4":
                               case "23":
                               case "7":

                                   return true;
                           }
                           break;
                           case "14":
                           switch (state_id)
                           {
                               case "3":
                               case "1":
                               case "2":
                               case "20":
                               case "30":
                               case "18":
                               case "25":
                                   return true;
                           }
                           break;
                           case "15":
                           switch (state_id)
                           {
                               case "27":
                               case "8":
                               case "19":
                               case "4":
                               case "31":
                               case "11":
                               case "12":
                               case "24":
                                   return true;
                           }
                           break;
                           case "16":
                           switch (state_id)
                           {
                               case "10":
                               case "21":
                               case "29":                               
                                   return true;
                           }
                           break;
                           case "17":
                           switch (state_id)
                           {
                               case "29":
                               case "21":
                               case "31":
                               case "4":
                               case "23":
                               case "7":
                                   return true;
                           }
                           break;
                           case "18":
                           switch (state_id)
                           {
                               case "25":
                               case "14":
                               case "30":
                               case "28":
                               case "5":
                               case "27":
                                   return true;
                           }
                           break;
                           case "19":
                           switch (state_id)
                           {
                               case "28":
                               case "4":
                               case "15":
                               case "5":
                               case "8":
                                   return true;
                           }
                           break;
                           case "20":
                           switch (state_id)
                           {
                               case "2":
                               case "14":
                               case "30":
                               case "22":
                                   return true;
                           }
                           break;
                           case "21":
                           switch (state_id)
                           {
                               case "16":
                               case "10":
                               case "31":
                               case "17":
                               case "29":
                                   return true;
                           }
                           break;
                           case "22":
                           switch (state_id)
                           {
                               case "20":
                               case "30":
                               case "26":
                               case "6":
                                   return true;
                           }
                           break;
                           case "23":
                           switch (state_id)
                           {
                               case "13":
                               case "9":
                               case "17":
                               case "7":
                               case "4":
                                   return true;
                           }
                           break;
                           case "24":
                           switch (state_id)
                           {
                               case "12":
                               case "27":
                               case "15":
                                   return true;
                           }
                           break;
                           case "25":
                           switch (state_id)
                           {
                               case "27":
                               case "18":
                               case "14":
                               case "3":
                                   return true;
                           }
                           break;
                           case "26":
                           switch (state_id)
                           {
                               case "30":
                               case "28":
                               case "4":
                               case "13":
                               case "6":
                               case "23":
                               case "9":  
                                   return true;
                           }
                           break;
                           case "27":
                           switch (state_id)
                           {
                               case "15":
                               case "24":
                               case "8":
                               case "18":
                               case "25":
                               case "5":
                                   return true;
                           }
                           break;
                           case "28":
                           switch (state_id)
                           {
                               case "18":
                               case "5":
                               case "8":
                               case "4":
                               case "26":
                               case "30":
                               case "19": 
                                   return true;
                           }
                           break;
                           case "29":
                           switch (state_id)
                           {
                               case "7":
                               case "17":
                               case "21":
                               case "16":
                                   return true;
                           }
                           break;
                           case "30":
                           switch (state_id)
                           {
                               case "14":
                               case "18":
                               case "28":
                               case "26":
                               case "22":
                               case "20":
                                   return true;
                           }
                           break;
                           case "31":
                           switch (state_id)
                           {
                               case "15":
                               case "10":
                               case "11":
                               case "21":
                               case "17":
                               case "4":                               
                                   return true;
                           }
                           break;

                       }
                       return false;
                   }

                   public static string getUnits(string id)
                   {
                       string str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                       parameters.Add("id", id);

                       str_sql = ("SELECT    Dictionary_Lang.title   FROM         Shop INNER JOIN                        core_units ON Shop.sale_unit = core_units.id INNER JOIN                        Dictionary_Lang ON core_units.id_dictonary = Dictionary_Lang.id_dictionary  WHERE     (Shop.id = @id) " );
                       return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text,
                           khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                   }



               }

               public  class invoiceManager
               {


                   public struct invoice
                   {

                       public string returnCode;

                       public string returnMessage;

                       public int id;

                       public int sendMode;

                       public int payMode;

                       public int price;

                       public string idRandom;

                       public bool  paid;

                       public DateTime  orderDate;

                       public string orderDatePerisan;

                       public string author;

                       public int userId;


                       public int country_id;

                       public int state_id;

                       public int city_id;

                       public string Transferee_Address;

                         public string Transferee_ZipCode;

                       public string Transferee_Tel;

                       public string Transferee_CellPhone;

                       public string message;

                          public string country_title ;

                        public string state_title;

                        public string city_title;

                        public string sendStatus;

                        public string payStatus;

                       public int price_send_source;

                       public int price_send_Target;

                       public bool have_cargo_rent_in_Target;

                       public int total_order_price;


                       

  
                   }


                   public static string invoiceAdd_old(int sendMode, int payMode, string price, string idRandom,
   bool paid, int users_id, string iranMcTrackingCode, string core_country_id,
   string core_country_state_id, string core_country_state_city_id, string Transferee_Address,
   string Transferee_ZipCode, string Transferee_Tel, string Transferee_CellPhone, string message, int sendStatus, int payStatus,
   string price_send_source, string price_send_Target, bool have_cargo_rent_in_Target, string total_order_price

   )
                   {



                       ArrayList a = new ArrayList();
                       ArrayList b = new ArrayList();

                       a.Add("sendMode");
                       b.Add(sendMode);

                       a.Add("payMode");
                       b.Add(payMode);

                       a.Add("price");
                       b.Add(price);

                       a.Add("idRandom");
                       b.Add(idRandom);

                       a.Add("paid");
                       b.Add(paid);

                       a.Add("users_id");
                       b.Add(users_id);

                       a.Add("iranMcTrackingCode");
                       b.Add(iranMcTrackingCode);

                       a.Add("core_country_id");
                       b.Add(core_country_id);

                       a.Add("core_country_state_id");
                       b.Add(core_country_state_id);

                       a.Add("core_country_state_city_id");
                       b.Add(core_country_state_city_id);

                       a.Add("Transferee_Address");
                       b.Add(Transferee_Address);

                       a.Add("Transferee_ZipCode");
                       b.Add(Transferee_ZipCode);

                       a.Add("Transferee_Tel");
                       b.Add(Transferee_Tel);

                       a.Add("Transferee_CellPhone");
                       b.Add(Transferee_CellPhone);

                       a.Add("message");
                       b.Add(message);


                       a.Add("orderDate");
                       b.Add(DateTime.UtcNow.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));

                       a.Add("sendStatus");
                       b.Add(sendStatus);

                       a.Add("payStatus");
                       b.Add(payStatus);

                       a.Add("price_send_source");
                       b.Add(price_send_source);

                       a.Add("price_send_Target");
                       b.Add(price_send_Target);

                       a.Add("have_cargo_rent_in_Target");
                       b.Add(have_cargo_rent_in_Target);

                       a.Add("total_order_price");
                       b.Add(total_order_price);

                       khatam.core.Security.Users.user Ouser = new khatam.core.Security.Users.user();
                       Ouser = khatam.core.Security.Users.getUser(users_id.ToString() );
                                        
                   a.Add("reg_id");
                   b.Add(Ouser.id );

                   a.Add("reg_email");
                   b.Add(Ouser.email );
                       
                   a.Add("reg_fname");
                   b.Add(Ouser.fname );

                   a.Add("reg_lname");
                   b.Add(Ouser.lname );
                  
                   a.Add("reg_company");
                   b.Add(Ouser.company );

                   a.Add("reg_tel");
                   b.Add(Ouser.tel  );

                   a.Add("reg_fax");
                   b.Add(Ouser.fax );

                    a.Add("reg_cellphone");
                    b.Add(Ouser.cellphone );
 
                    a.Add("reg_country");
                    b.Add(Ouser.country );
 
                    a.Add("reg_stats");
                    b.Add(Ouser.stats );

                    a.Add("reg_city");
                    b.Add(Ouser.city );

                    a.Add("reg_address");
                    b.Add(Ouser.address );

                    a.Add("reg_zipcode");
                    b.Add(Ouser.zipcode );

                       return khatam.core.data.sql.Add(a, b, "core_invoice");

                   }

                   public static string invoiceLineAdd_old(string invoice_id, string title,
                       string price, string quantity, string catid, string sum, string type_content, string virtual_bool,
                       string domain)
                   {

                       ArrayList a = new ArrayList();
                       ArrayList b = new ArrayList();



                       a.Add("invoice_id");
                       b.Add(invoice_id);

                       a.Add("title");
                       b.Add(title);

                       a.Add("price");
                       b.Add(price);

                       a.Add("quantity");
                       b.Add(quantity);

                       a.Add("catid");
                       b.Add(catid);

                       a.Add("sum");
                       b.Add(sum);

                       a.Add("virtual");
                       b.Add(virtual_bool);


                       a.Add("type_content");
                       b.Add(type_content);

                       a.Add("domain");
                       b.Add(domain);


                       return khatam.core.data.sql.Add(a, b, "core_invoice_line");

                   }

                   public static void updateStatus(string invoiceId)
                   {
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
                       
                       parameters.Add("invoiceId", invoiceId);
                       //return int.Parse(  )
                       DBFunctions.ExecuteNonQuery("invoice_updateStatus", parameters, System.Data.CommandType.StoredProcedure, 
                           khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                        
                   }

                   public static invoice getInvoice(string id,string idRandom,string LangId)
                   {
                       invoice ci = new invoice();

                       string str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        parameters.Add("id", id);
                        parameters.Add("idRandom", idRandom);

                       
                       
                        str_sql ="SELECT core_invoice.id, core_invoice.sendMode, core_invoice.payMode, core_invoice.price, core_invoice.idRandom, core_invoice.paid, core_invoice.orderDate, "
+" core_invoice.users_id, core_invoice.core_country_id, core_invoice.core_country_state_id, core_invoice.core_country_state_city_id, "
+" core_invoice.Transferee_Address, core_invoice.Transferee_ZipCode, core_invoice.Transferee_Tel, core_invoice.Transferee_CellPhone, core_invoice.message, "
+ " Dictionary_Lang.title AS country, Dictionary_Lang_2.title AS state, Dictionary_Lang_1.title AS city   ,  sendStatus    ,payStatus ,price_send_source,price_send_Target,have_cargo_rent_in_Target,total_order_price"
+" FROM core_country_state_city INNER JOIN "
+" core_invoice INNER JOIN "
+" core_country ON core_invoice.core_country_id = core_country.country_id INNER JOIN"
+" core_country_state ON core_invoice.core_country_state_id = core_country_state.country_state_id ON "
+" core_country_state_city.country_state_city_id = core_invoice.core_country_state_city_id INNER JOIN "
+" Dictionary_Lang ON core_country.dictionary_id = Dictionary_Lang.id INNER JOIN "
+" Dictionary_Lang AS Dictionary_Lang_2 ON core_country_state.dictionary_id = Dictionary_Lang_2.id_dictionary INNER JOIN "
+" Dictionary_Lang AS Dictionary_Lang_1 ON core_country_state_city.dictionary_id = Dictionary_Lang_1.id_dictionary "
+" WHERE (core_invoice.id = @id) AND (core_invoice.idRandom = @idRandom) ";

                       DataTable dt = new DataTable();

                       try
                       {
                           dt = DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                       }
                       catch (Exception e)
                       {
                           ci.returnCode = "-1";
                           ci.returnMessage = e.Message;
                           return ci;
                       }


                       ci.id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                       ci.sendMode = int.Parse(dt.Rows[0].ItemArray[1].ToString());
                       ci.payMode = int.Parse(dt.Rows[0].ItemArray[2].ToString());
                       ci.price = int.Parse(dt.Rows[0].ItemArray[3].ToString());

                  /*  " 0core_invoice.id, 1core_invoice.sendMode, 2core_invoice.payMode, 3core_invoice.price, 4core_invoice.idRandom, 5core_invoice.paid, 6core_invoice.orderDate, "
+" 7core_invoice.users_id, 8core_invoice.core_country_id, 9core_invoice.core_country_state_id, 10core_invoice.core_country_state_city_id, "
+" 11core_invoice.Transferee_Address, 12core_invoice.Transferee_ZipCode, 13core_invoice.Transferee_Tel, 14core_invoice.Transferee_CellPhone, 15core_invoice.message, "
+" 16Dictionary_Lang.title AS country, 17Dictionary_Lang_2.title AS state, 18Dictionary_Lang_1.title AS city*/

                      ci.idRandom = dt.Rows[0].ItemArray[4].ToString();
                       ci.paid = bool.Parse(dt.Rows[0].ItemArray[5].ToString());

                       ci.orderDate = DateTime.Parse(dt.Rows[0].ItemArray[6].ToString());

                       ci.orderDatePerisan = Persia.Calendar.ConvertToPersian(ci.orderDate).Simple.ToString();

                       ci.userId = int.Parse(dt.Rows[0].ItemArray[7].ToString()) ;

                       ci.country_id = int.Parse(dt.Rows[0].ItemArray[8].ToString());

                       ci.state_id = int.Parse(dt.Rows[0].ItemArray[9].ToString());

                       ci.city_id = int.Parse(dt.Rows[0].ItemArray[10].ToString());

                       ci.Transferee_Address = dt.Rows[0].ItemArray[11].ToString() ;
                       ci.Transferee_ZipCode = dt.Rows[0].ItemArray[12].ToString() ;
                       ci.Transferee_Tel = dt.Rows[0].ItemArray[13].ToString() ;
                       ci.Transferee_CellPhone = dt.Rows[0].ItemArray[14].ToString() ;
                       ci.message = dt.Rows[0].ItemArray[15].ToString() ;
                       ci.country_title = dt.Rows[0].ItemArray[16].ToString() ;
                       ci.state_title = dt.Rows[0].ItemArray[17].ToString() ;
                       ci.city_title = dt.Rows[0].ItemArray[18].ToString() ;

                       ci.sendStatus =  dt.Rows[0].ItemArray[19].ToString();

                       ci.payStatus =  dt.Rows[0].ItemArray[20].ToString();


                       ci.price_send_source = int.Parse(dt.Rows[0].ItemArray[21].ToString());

                       ci.price_send_Target =int.Parse(  dt.Rows[0].ItemArray[22].ToString());

                       ci.have_cargo_rent_in_Target =bool.Parse( dt.Rows[0].ItemArray[23].ToString());

                       ci.total_order_price =int.Parse( dt.Rows[0].ItemArray[24].ToString());




                       //         if (dt.Rows.Count < 1)
                       //       {
                       //         ci.returnCode = "-2";
                       //       ci.returnMessage = "Item not found";
                       //                  return ci;
                       //            }






                       return ci;

                       //Error Table
                       // 1 right
                       // -1 Database Error
                       // -2 Item Not found
                       // -3 Disable
                       // -4 Deleted
                       // -5 Not Valid
                   }

                   public static invoice getInvoiceVirtual(string id, string idRandom, string LangId)
                   {
                       invoice ci = new invoice();

                       string str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                       parameters.Add("id", id);
                       parameters.Add("idRandom", idRandom);


                       str_sql = "SELECT     id, sendMode, payMode, price, idRandom, paid, orderDate, users_id, core_country_id, core_country_state_id, core_country_state_city_id, Transferee_Address, " +
                      " Transferee_ZipCode, Transferee_Tel, Transferee_CellPhone, message,   sendStatus    ,payStatus  ,price_send_source,price_send_Target,have_cargo_rent_in_Target,total_order_price" +
                      " FROM         core_invoice " +
                      " WHERE     (id = @id) AND (idRandom = @idRandom) ";

                       DataTable dt = new DataTable();

                       try
                       {
                           dt = DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                       }
                       catch (Exception e)
                       {
                           ci.returnCode = "-1";
                           ci.returnMessage = e.Message;
                           return ci;
                       }


                       ci.id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                       ci.sendMode = int.Parse(dt.Rows[0].ItemArray[1].ToString());
                       ci.payMode = int.Parse(dt.Rows[0].ItemArray[2].ToString());
                       ci.price = int.Parse(dt.Rows[0].ItemArray[3].ToString());
                       
                       ci.idRandom = dt.Rows[0].ItemArray[4].ToString();
                       ci.paid = bool.Parse(dt.Rows[0].ItemArray[5].ToString());

                       ci.orderDate = DateTime.Parse(dt.Rows[0].ItemArray[6].ToString());

                       ci.orderDatePerisan = Persia.Calendar.ConvertToPersian(ci.orderDate).Simple.ToString();
                       
                               /*       11 Transferee_Address, 
                  12    Transferee_ZipCode, Transferee_Tel, Transferee_CellPhone, message
FROM         core_invoice
WHERE     (id = @id) AND (idRandom = @idRandom)*/

                       ci.userId = int.Parse(dt.Rows[0].ItemArray[7].ToString());

                       ci.country_id = int.Parse(dt.Rows[0].ItemArray[8].ToString());

                       ci.state_id = int.Parse(dt.Rows[0].ItemArray[9].ToString());

                       ci.city_id = int.Parse(dt.Rows[0].ItemArray[10].ToString());

                       ci.Transferee_Address = dt.Rows[0].ItemArray[11].ToString();
                       ci.Transferee_ZipCode = dt.Rows[0].ItemArray[12].ToString();
                       ci.Transferee_Tel = dt.Rows[0].ItemArray[13].ToString();
                       ci.Transferee_CellPhone = dt.Rows[0].ItemArray[14].ToString();
                       ci.message = dt.Rows[0].ItemArray[15].ToString();
                       ci.country_title = "";
                       ci.state_title = "";
                       ci.city_title = "";


                       ci.sendStatus = dt.Rows[0].ItemArray[16].ToString();

                       ci.payStatus = dt.Rows[0].ItemArray[17].ToString();

                       ci.price_send_source = int.Parse(dt.Rows[0].ItemArray[18].ToString());

                       ci.price_send_Target = int.Parse(dt.Rows[0].ItemArray[19].ToString());

                       ci.have_cargo_rent_in_Target = bool.Parse(dt.Rows[0].ItemArray[20].ToString());

                       ci.total_order_price =  int.Parse(dt.Rows[0].ItemArray[21].ToString());




                       //         if (dt.Rows.Count < 1)
                       //       {
                       //         ci.returnCode = "-2";
                       //       ci.returnMessage = "Item not found";
                       //                  return ci;
                       //            }






                       return ci;

                       //Error Table
                       // 1 right
                       // -1 Database Error
                       // -2 Item Not found
                       // -3 Disable
                       // -4 Deleted
                       // -5 Not Valid
                   }


                   public static string getStateIranmcMessageByid(int state)
                   {

                       switch (state)
                       {
                           case 0:
                               return "در حال پیگیری";

                           case 1:
                               return "آماده به ارسال";

                           case 2:
                               return "ارسال شده";

                           case 3:
                               return "توزیع شده";

                           case 4:
                               return "وصول شده";

                           case 5:
                               return "برگشتی";

                           case 6:
                               return "انصرافی";

                       }
                       return "-1";
                   }


                   public static string getStateSend(int state)
                   {

                       switch (state)
                       {
                           case 0:
                               return "فاکتور مجازی";
                           case 1:
                               return "در انتظار پرداخت";

                           case 2:
                               return "آماده به ارسال";

                           case 3:
                               return "ارسال شده";

                           case 4:
                               return "برگشتی";

                           case 5:
                               return "انصرافی";

                       }
                       return "-1";
                   }

                   public static string getVirtualServiceStatus(int state)
                   {

                       switch (state)
                       {                   
                           case 1:
                               return "راه اندازی نشده";
                           case 2:
                               return "در انتظار ارسال مدارک";
                           case 3:
                               return "در حال راه اندازی";
                           case 4:
                               return "فعال";
                           case 5:
                               return "غیر فعال";
                           case 6:
                               return "منقضی شده";
                           case 7:
                               return "ارجاع به سفارش جدید";

                       }
                       return "-1";
                   }

                   public static string getStatePay(int state)
                   {

                       switch (state)
                       {
                           case 0:
                               return "پرداخت نشده";

                           case 1:
                               return "در انتظار تایید پرداخت";

                           case 2:
                               return "پرداخت شده";

                           case 3:
                               return "انصرافی";

                           case 4:
                               return "انصرافی و باز پرداخت وجه";



                       }
                       return "-1";
                   }


                   public static string getStateTransaction_Fish(int state)
                   {

                       switch (state)
                       {
                           case 0:
                               return "در انتظار تایید";

                           case 1:
                               return "معتبر نیست";

                           case 2:
                               return "تایید شده";


                       }
                       return "-1";
                   }

                   public static string invoiceAdd(int sendMode, int payMode, string price, string idRandom,
    bool paid, int users_id, string iranMcTrackingCode, string core_country_id,
    string core_country_state_id, string core_country_state_city_id, string Transferee_Address,
    string Transferee_ZipCode, string Transferee_Tel, string Transferee_CellPhone, string message, int sendStatus, int payStatus,
    string price_send_source, string price_send_Target, bool have_cargo_rent_in_Target, string total_order_price)
                   {



                       ArrayList a = new ArrayList();
                       ArrayList b = new ArrayList();

                       a.Add("sendMode");
                       b.Add(sendMode);

                       a.Add("payMode");
                       b.Add(payMode);

                       a.Add("price");
                       b.Add(price);

                       a.Add("idRandom");
                       b.Add(idRandom);

                       a.Add("paid");
                       b.Add(paid);

                       a.Add("users_id");
                       b.Add(users_id);

                       a.Add("iranMcTrackingCode");
                       b.Add(iranMcTrackingCode);

                       a.Add("core_country_id");
                       b.Add(core_country_id);

                       a.Add("core_country_state_id");
                       b.Add(core_country_state_id);

                       a.Add("core_country_state_city_id");
                       b.Add(core_country_state_city_id);

                       a.Add("Transferee_Address");
                       b.Add(Transferee_Address);

                       a.Add("Transferee_ZipCode");
                       b.Add(Transferee_ZipCode);

                       a.Add("Transferee_Tel");
                       b.Add(Transferee_Tel);

                       a.Add("Transferee_CellPhone");
                       b.Add(Transferee_CellPhone);

                       a.Add("message");
                       b.Add(message);


                       a.Add("orderDate");
                       b.Add(DateTime.UtcNow.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));

                       a.Add("sendStatus");
                       b.Add(sendStatus);

                       a.Add("payStatus");
                       b.Add(payStatus);

                       a.Add("price_send_source");
                       b.Add(price_send_source);

                       a.Add("price_send_Target");
                       b.Add(price_send_Target);

                       a.Add("have_cargo_rent_in_Target");
                       b.Add(have_cargo_rent_in_Target);

                       a.Add("total_order_price");
                       b.Add(total_order_price);





                       return khatam.core.data.sql.Add(a, b, "core_invoice");

                   }


                   /// <summary>
                   /// this will be the tooltip
                   /// </summary>
                   /// <param name="invoice_id">به به از این خبر ها این گشت و این د در ها</param>
                   /// <param name="start">زمان شروع سرویس، برای  سرویس جدید زمان فعلی و برای  سرویس تمدیدی شامل تاریخ انقضای سرویس قبلی</param>
                   /// <returns>My result</returns>


                   public static string invoiceLineAdd(string invoice_id, string title,
                       string price, string quantity, string catid, string sum, string type_content, string virtual_bool,
                       string domain, string month, string renewParentId, DateTime start )
                   {

                       ArrayList a = new ArrayList();
                       ArrayList b = new ArrayList();



                       a.Add("invoice_id");
                       b.Add(invoice_id);

                       a.Add("title");
                       b.Add(title);

                       a.Add("price");
                       b.Add(price);

                       a.Add("quantity");
                       b.Add(quantity);

                       a.Add("catid");
                       b.Add(catid);

                       a.Add("sum");
                       b.Add(sum);

                       a.Add("virtual");
                       b.Add(virtual_bool);


                       a.Add("type_content");
                       b.Add(type_content);


                       if (bool.Parse(virtual_bool))
                       {
                           //a.Add("domain");
                           //b.Add(domain);

                           //a.Add("month");
                           //b.Add(month);

                           //a.Add("exp");

                           //b.Add(start.AddMonths(int.Parse(month)).ToString("yyyy/MM/dd HHHH:mmmm:ssss"));

                           //a.Add("virtualServiceStatus");
                           //b.Add("1");

                           //a.Add("renewParentId");
                           //b.Add(renewParentId);

                           //a.Add("start");
                           //b.Add(start.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));


                       }

                       return khatam.core.data.sql.AddScope(a, b, "core_invoice_line");
                       //return "444";

                   }


                   public static void sendInfoNeedPay(string userid, string invoiceId, string idRandom)
                   {
                       string EmailBodyNeedPay = "";
                       EmailBodyNeedPay = " <br />"
                            + " <strong>کاربر گرامی،"
                            + khatam.core.Security.Users.getRealName(userid) + " <br />"
                            + " سلام علیکم،</strong><br />"
                           //+ " نام کاربری شما: " + sendTo + "  <br />"
                           // + "کلمه عبور:" + khatam.core.Security.Users.changePasswordRecovery(sendTo) + "<br />"
                            + " پیش فاکتور شماره " + invoiceId + " برای شما صادر گردیده است. لطفا نسبت به پرداخت آن اقدام نمایید:<br />"
                            + " <br />"
                            + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay.aspx?id=" + invoiceId + "&pass=" + idRandom + "\">مشاهده و پرداخت پیش فاکتور</a><br />"
                            + " <br />"
                            + " با تشکر<br />"
                          + " <span>"
                          + " <br />"
                          + " "
                          + " <br />"
                          + " </span>";

                       if (khatam.core.Security.Users.getCellphone(userid.ToString()) != "")
                       {
                           khatam.core.Net.sms.sendSMS(khatam.core.Security.Users.getCellphone(userid.ToString()),
                              "خریدار گرامی " + " پیش فاکتور شماره  " + invoiceId +
                              " ثبت گردید. " +
                              khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir());
                       }

                       string saleManagerCellPhone = khatam.core.data.sql.getBaseSetting("saleManagerCellPhone", "0");


                      /// khatam.core.Net.sms.sendSMS(saleManagerCellPhone,
                         ///     "سفارش جدید " + " پیش فاکتور شماره  " + invoiceId +
                           ///   " ثبت گردید. " +
                            ///  khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir());




                       // if (bool.Parse( Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("sendSmsToSaleManager", 0,
                       //khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())))
                       try
                       {
                           string saleManagerEmail = khatam.core.data.sql.getBaseSetting("saleManagerEmail","0");

                           khatam.core.email.sendAllPurposeEmail_old(saleManagerEmail, khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + ": Customer PreInvoice No," + invoiceId
                   , EmailBodyNeedPay, "اطلاعات صورتحساب");
                       }
                       catch
                       {

                       }

                       khatam.core.email.sendAllPurposeEmail_old(khatam.core.Security.Users.getEmail(userid.ToString()), khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + ": Customer PreInvoice No," + invoiceId
                       , EmailBodyNeedPay, "اطلاعات پیش فاکتور");








                   }

                   public static void sendInfoPayOnDelivery(string userid, string invoiceId, string idRandom)
                   {

                       string EmailBodyNeedPay = " <br />"
               + " <strong>کاربر گرامی،"
               + khatam.core.Security.Users.getRealName(userid.ToString()) + " <br />"
               + " سلام علیکم،</strong><br />"
                           //+ " نام کاربری شما: " + sendTo + "  <br />"
                           // + "کلمه عبور:" + khatam.core.Security.Users.changePasswordRecovery(sendTo) + "<br />"
               + " صورتحساب شماره " + invoiceId + " برای شما صادر گردیده است. و در اسرع وقت سفارش شما ارسال می گردد:<br />"
               + " <br />"
               + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay.aspx?id=" + invoiceId + "&pass=" + idRandom + "\">مشاهده و پیگیری صورتحساب</a><br />"
               + " <br />"
               + " با تشکر<br />"
               + " <span>"
               + " <br />"
               + " "
               + " <br />"
               + " </span>";





                       if (khatam.core.Security.Users.getCellphone(userid.ToString()) != "")
                       {
                           khatam.core.Net.sms.sendSMS(khatam.core.Security.Users.getCellphone(userid.ToString()),
                              "خریدار گرامی " + " سفارش شماره  " + invoiceId +
                              " ثبت گردید. " +
                              khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir());
                       }

                       string saleManagerCellPhone = khatam.core.data.sql.getBaseSetting ("saleManagerCellPhone","0");

                       khatam.core.Net.sms.sendSMS(saleManagerCellPhone,
                               " سفارش پست خرید شماره  " + invoiceId +
                              " ثبت گردید. " +
                              khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir());

                       try
                       {
                           string saleManagerEmail = khatam.core.data.sql.getBaseSetting("saleManagerEmail", "0");

                           khatam.core.email.sendAllPurposeEmail_old(saleManagerEmail, khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + ": Customer PreInvoice No," + invoiceId
                   , EmailBodyNeedPay, "اطلاعات صورتحساب");
                       }
                       catch
                       {

                       }

                       // if (bool.Parse( Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("sendSmsToSaleManager", 0,
                       //khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())))

                       khatam.core.email.sendAllPurposeEmail_old(khatam.core.Security.Users.getEmail(userid.ToString()), khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + ": Customer PreInvoice No," + invoiceId
                , EmailBodyNeedPay, "اطلاعات صورتحساب");


                   }

               }
}
}

