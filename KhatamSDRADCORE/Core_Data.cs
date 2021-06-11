using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Net;
using System.IO;
using Excel;


namespace khatam
{
    namespace core
    {
        namespace data
        {
            public static class sql
            {



                public struct contentItem
                {
                    public string returnCode;

                    public string returnMessage;

                    public string title;

                    public string image;

                    public string page;

                    public string description;

                    public string author;

                    public DateTime  pub_date;
                }



                public static   contentItem getContentItemBaseInfo(string id, string table)
                {
                    contentItem ci= new contentItem();

                    string strDate;
                    strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                        + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; 

                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                   parameters.Add("id", id);
                   parameters.Add("type_content", table );

                   str_sql = "SELECT     " + table + ".title, " + table + ".author, " + table  + ".description, " + table + ".page, " + table + ".enable, " + table 
                       + ".keywords, " + table + ".pub_date, " 
                       +  table  + ".image ,cat.valid , cat.deleted " +
                    " FROM         " + table + " INNER JOIN " +
                    " Cat ON " + table + ".id = Cat.id_content " +
                    " WHERE    (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND   (" + table + ".id = @id) AND (Cat.type_content = @type_content) ;UPDATE cat  SET visitCounter = (visitCounter + '1' ) where (cat.id_content = @id) AND (Cat.type_content = @type_content)";

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

                   if (dt.Rows.Count < 1)
                   {
                       ci.returnCode = "-2";
                       ci.returnMessage  = "Item not found";
                       return ci;
                   }

                   try
                   {
                       if (bool.Parse(dt.Rows[0].ItemArray[9].ToString()) == true)
                       {
                           ci.returnCode = "-4";
                           ci.returnMessage = "Deleted";
                           return ci;
                       }
                   }
                   catch
                   {
                   }

                   try
                   {
                       if (bool.Parse(dt.Rows[0].ItemArray[4].ToString()) != true)
                       {
                           ci.returnCode = "-3";
                           ci.returnMessage = "Disable";
                           return ci;
                       }
                   }
                   catch
                   {
                       ci.returnCode = "-3";
                       ci.returnMessage = "Disable";
                       return ci;
                   }


             


                   try
                   {
                       if (bool.Parse(dt.Rows[0].ItemArray[8].ToString()) != true)
                       {
                           ci.returnCode = "-5";
                           ci.returnMessage = "Not Valid";
                           return ci;
                       }
                   }
                   catch
                   {
                       ci.returnCode = "-5";
                       ci.returnMessage = "Not Valid";
                       return ci;
                   }

                    ci.title = dt.Rows[0].ItemArray[0].ToString();
                    ci.page = dt.Rows[0].ItemArray[3].ToString();
                    ci.image = dt.Rows[0].ItemArray[7].ToString();
                    ci.author  = dt.Rows[0].ItemArray[1].ToString();
                    ci.description =  dt.Rows[0].ItemArray[2].ToString();
                    ci.returnCode = "1";
                    ci.returnMessage = "right";
                    try
                    {
                        ci.pub_date = DateTime.Parse(dt.Rows[0].ItemArray[6].ToString());
                    }
                    catch
                    {
                        
                    }


                    return ci;

                    //Error Table
                    // 1 right
                    // -1 Database Error
                    // -2 Item Not found
                    // -3 Disable
                    // -4 Deleted
                    // -5 Not Valid
                }


        


                public static string Add(ArrayList a, ArrayList b, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    int i;
                    string str_sql_item = "";
                    string str_sql_value = "";
                    for (i = 0; (i
                                <= (a.Count - 1)); i++)
                    {
                        parameters.Add(a[i].ToString(), b[i].ToString());
                        if ((i
                                    < (a.Count - 1)))
                        {
                            str_sql_item = (str_sql_item
                                        + (a[i].ToString() + " , "));
                            str_sql_value = (str_sql_value + ("@"
                                        + (a[i].ToString() + " , ")));
                        }
                        else
                        {
                            str_sql_item = (str_sql_item + a[i].ToString());
                            str_sql_value = (str_sql_value + ("@" + a[i].ToString()));
                        }
                    }
                    str_sql = "INSERT INTO "
                                + table + " ("
                                + str_sql_item + ")VALUES ("
                                + str_sql_value + ");SELECT SCOPE_IDENTITY();";
                    return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

                }

                public static string AddScope(ArrayList a, ArrayList b, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    int i;
                    string str_sql_item = "";
                    string str_sql_value = "";
                    for (i = 0; (i
                                <= (a.Count - 1)); i++)
                    {
                        parameters.Add(a[i].ToString(), b[i].ToString());
                        if ((i
                                    < (a.Count - 1)))
                        {
                            str_sql_item = (str_sql_item
                                        + (a[i].ToString() + " , "));
                            str_sql_value = (str_sql_value + ("@"
                                        + (a[i].ToString() + " , ")));
                        }
                        else
                        {
                            str_sql_item = (str_sql_item + a[i].ToString());
                            str_sql_value = (str_sql_value + ("@" + a[i].ToString()));
                        }
                    }
                    str_sql = ("INSERT INTO "
                                + (table + (" ("
                                + (str_sql_item + (")VALUES ("
                                + (str_sql_value + ") ; SELECT SCOPE_IDENTITY();  "))))));
                    return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

                }

                public static string addPropertyRow(string Instance, string propertyTitle, string propertyValue, string tableName, string langId)
                {


                    ArrayList a = new ArrayList();
                    ArrayList b = new ArrayList();

                    a.Add(("id_" + tableName).ToString().Replace("Val", ""));
                    b.Add(Instance);

                    a.Add("propertyTitle");
                    b.Add(propertyTitle);

                    if (langId != null)
                    {
                        a.Add("language");
                        b.Add(langId);
                    }

                    if (khatam.core.data.sql.Sql_Check_identityArray(a, b, tableName, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
                    {
                        a.Add("propertyValue");
                        b.Add(propertyValue);
                        khatam.core.data.sql.Add(a, b, tableName);
                    }

                    return "added";
                }


                public static void addColumn(string columnName, string DataType, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);
                    str_sql = "    if NOT Exists(select * from sys.columns where Name = N'" + columnName + "'  and Object_ID = Object_ID(N'" + table + "'))  " +
                    "  begin   " +
                    "  ALTER TABLE " + table + " ADD [" + columnName + "] " + DataType + " NULL " +
                    " end ";
                    //return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

                }
                
                public static bool update(ArrayList a, ArrayList b, string table, string field_where_name, string field_where_value)
                {



                    string str_sql;

                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    int i;
                    string str_sql_item = "";
                    



                    for (i = 0; (i <= (a.Count - 1)); i++)
                    {
                        parameters.Add(a[i].ToString(), b[i].ToString());


                        if (i < a.Count - 1)
                        {
                            str_sql_item = str_sql_item + a[i].ToString() + " = " + "@" + a[i].ToString() + " , ";

                        }
                        else
                        {

                            str_sql_item = str_sql_item + a[i].ToString() + " = " + "@" + a[i].ToString();
                        }

                    }
                    parameters.Add(field_where_name, field_where_value);

                    str_sql = "UPDATE " + table +
                    " set " + str_sql_item + " where (" + field_where_name + "= @" + field_where_name + ")";



                    if (DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) != 1)
                    {

                        return false;
                        //'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"
                    }


                    else
                    {
                        return true;
                    }




                }
                                
                public static string Del(ArrayList a, ArrayList b, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    int i;
                    string str_sql_var = "";
                    
                    for (i = 0; (i
                                <= (a.Count - 1)); i++)
                    {
                        parameters.Add(a[i].ToString(), b[i].ToString());
                        if (i == 0)
                        {
                           // str_sql_var = a[i] + 
                            //str_sql_item = (str_sql_item  + (a[i].ToString() + " , "));
                            str_sql_var = (str_sql_var + " ( " + (a[i].ToString() + " =@" + a[i].ToString()+ " )"));
                        }
                        else
                        {

                            str_sql_var = (str_sql_var + " and (" + (a[i].ToString() + " =@" + a[i].ToString() + " )  "));

                            //str_sql_item = (str_sql_item + a[i].ToString());
                            //str_sql_value = (str_sql_value + ("@" + a[i].ToString()));
                        }
                    }

                    //DELETE FROM corePermissionRefUser  WHERE     (idUser = @idUser) AND (idPermission = @idPermission)

                    str_sql = "DELETE FROM  " + table + " WHERE " + str_sql_var;

                    if ((DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, ConnectionString) != 1))
                    {
                        return "false";
                    }
                    else
                    {
                        return "true";
                    }
                }
                
             
                
                public static void delColumn(string columnName, string table)
                {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


            //parameters.Add("field_where_value", field_where_value);
            //str_sql = "    if NOT Exists(select * from sys.columns where Name = N'" + columnName + "'  and Object_ID = Object_ID(N'" + table + "'))  " +
           // "  begin   " +
           // "  ALTER TABLE " + table + " ADD [" + columnName + "] " + DataType + " NULL " +
           // " end ";

            str_sql = " ALTER TABLE " + table +
            " DROP COLUMN " + columnName;
            //return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
            DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

        }

                public static void delTable(string tableName)
        {
            string str_sql;
            Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


            //parameters.Add("field_where_value", field_where_value);
            //str_sql = "    if NOT Exists(select * from sys.columns where Name = N'" + columnName + "'  and Object_ID = Object_ID(N'" + table + "'))  " +
            // "  begin   " +
            // "  ALTER TABLE " + table + " ADD [" + columnName + "] " + DataType + " NULL " +
            // " end ";

            str_sql = "  drop table " + tableName + "  ";
            //" DROP COLUMN " + columnName;
            //return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
            DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

        }

                /// <summary>getField return string of Filed value. 
                /// <para>"" for null or "" values, and -1 for not found</para>                
                /// </summary> 
                public static string getField( string field_target, string col_where, string where_value, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("field_where_value", where_value);
                    str_sql = ("SELECT  "
                                + (field_target + ("   FROM  "
                                + (table + ("   WHERE     ("
                                + (col_where + " = @field_where_value)"))))));


                    object _obj = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    if (_obj == null)
                    {
                        return "-1" ;
                    }
                    else
                    {
                        return _obj.ToString();
                    }
                                           
                    
                }

                public static string getField(string field_target, string field_where, string field_where_value, string field_where2, string field_where_value2, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("field_where_value", field_where_value);
                    parameters.Add("field_where_value2", field_where_value2);
                    str_sql = ("SELECT  "
                                + (field_target + ("   FROM  "
                                + (table + ("   WHERE     ((" + field_where + " = @field_where_value) AND (" + field_where2 + " = @field_where_value2) )")))));

                    object _obj = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    if (_obj == null)
                    {
                        return "-1";
                    }
                    else
                    {
                        return _obj.ToString();
                    }
                        
                }

                public static string getDicTitle(string field_where, string field_where_value, string table, string id_language, string dictionary_id_colNames)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("id_language", id_language);
                    parameters.Add("field_where_value", field_where_value);

                    str_sql = "SELECT     Dictionary_Lang.title " +
                    " FROM         Dictionary_Lang INNER JOIN " +
                      table + " ON Dictionary_Lang.id_dictionary = " + table + "." + dictionary_id_colNames +
                    " WHERE     (" + table + "." + field_where + " = @field_where_value) AND (Dictionary_Lang.id_language = @id_language) ";


                    object _obj = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    if (_obj == null)
                    {
                        return "-1";
                    }
                    else
                    {
                        return _obj.ToString();
                    }


                }

                 public static string getDicTitle(string DicTitle,string id_language)
                 {
                     string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("id_language", id_language);
                    parameters.Add("title", DicTitle);

                    str_sql = " SELECT     Dictionary_Lang.title  FROM         Dictionary INNER JOIN                      Dictionary_Lang ON Dictionary.id = Dictionary_Lang.id_dictionary   WHERE     (Dictionary.title = @title) AND (Dictionary_Lang.id_language = @id_language)";


                    object _obj = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    if (_obj == null)
                    {
                        return "-1";
                    }
                    else
                    {
                        return _obj.ToString();
                    }

               
                 }

                   public static string getBaseSetting(string title, string langId)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("title", title);
                    parameters.Add("langId", langId);

                    str_sql = "  SELECT     memo " +
                    " FROM         Setting_Base " +
                    " WHERE     (cname = @title) AND (Language = @langId) ";

                    string str="-1";

                                        
                    str= DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();                    
           
                    return str;
                    
                }

                   public static void  setBaseSetting(string cname, string memo, string langId)
                {
                    khatam.core.data.sql.updateField("memo",memo  , "cname", cname , "language",langId , "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());       
               
                    
                }

                
                   public static string getTranslate(string title, string langId)
                   {
                       string str_sql;
                       Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                       parameters.Add("title", title);
                       parameters.Add("langId", langId);

                       str_sql = "      SELECT     TOP (200) Dictionary_Lang.title " +
                       "   FROM         Dictionary INNER JOIN " +
                       "  Dictionary_Lang ON Dictionary.id = Dictionary_Lang.id_dictionary " +
                       "  WHERE     (Dictionary.title = @title) AND (Dictionary_Lang.id_language = @langId) ";


                       string str = "";

                       try
                       {
                           str = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                       }
                       catch /*(Exception ex)*/
                       {
                           //ErrorLogAdd("caller:" + caller + " field_target: " + field_target + " field_where: " + field_where  + " field_where_value: " + field_where_value + " table: " + table  + " ex: "  + ex.InnerException + " " +  ex.Message );
                           //return null;
                           //throw;
                           return str;
                       }

                       return str;

                   }

 

                public static string getField(string field_target, string field_where, string field_where_value, string field_where2, string field_where_value2, string field_where3, string field_where_value3, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("field_where_value", field_where_value);
                    parameters.Add("field_where_value2", field_where_value2);
                    parameters.Add("field_where_value3", field_where_value3);

                    str_sql = ("SELECT  "
                                + (field_target + ("   FROM  "
                                + (table + ("   WHERE     ((" + field_where + " = @field_where_value) AND (" + field_where2 + " = @field_where_value2)  AND (" + field_where3 + " = @field_where_value3) )")))));


                    // try
                    // {

                    // }
                    // catch (Exception)
                    // {

                    //   throw;
                    // }

                    string str = "";

                    try
                    {
                        str = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch (Exception ex)
                    {
                        ErrorLogAdd("caller:" +  " field_target: " + field_target + " field_where: " + field_where + " field_where_value: " + field_where_value + " table: " + table + " ex: " + ex.InnerException + " " + ex.Message);
                        //return null;
                        //throw;
                        return str;
                    }

                    return str;

                }

                public static string getMetaTagByItem(string content_id, string content_type)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("content_id", content_id);
                    parameters.Add("content_type", content_type);
                  
                    str_sql = "SELECT     ST1.tag_title + ',' AS [text()] " +
                    " FROM         core_tags ST1 INNER JOIN " +
                     " core_tag_ref_cat ON ST1.tag_id = core_tag_ref_cat.tag_id INNER JOIN " +
                     " Cat ON core_tag_ref_cat.cat_id = Cat.id  " +
                    " WHERE     (Cat.type_content = @content_type) AND (Cat.id_content = @content_id) " +
                    " ORDER BY ST1.tag_id " +
                    " For XML PATH ('') ";

                    string str = "";

                    try
                    {
                        str = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }
                    catch /*(Exception ex)*/
                    {
                        //ErrorLogAdd("caller:" + caller + " field_target: " + field_target + " field_where: " + field_where + " field_where_value: " + field_where_value + " table: " + table + " ex: " + ex.InnerException + " " + ex.Message);
                        //return null;
                        //throw;
                        return str;
                    }
                    
                    return str.Substring(0, str.Length - 1);

                }




               public static void ErrorLogAdd(string memo)
               {
                 //   ArrayList a = new ArrayList();
                 //   ArrayList b = new ArrayList();

                  //  a.Add("memo");
                  //  b.Add(memo);

                   //### a.Add("datetime");
                   // b.Add(DateTime.UtcNow.ToString);

                  //  khatam.core.data.sql.Add(a, b, "logError", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

                public static DataTable getTable(string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);
                    str_sql = "SELECT  * FROM " + table;
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

                public static DataTable getTable(string field_where, string field_where_value, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);
                    str_sql = "SELECT  * FROM " + table + "  WHERE     (" + field_where + " = @" + field_where + ") "; ;
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

                public static DataTable getTable_string(string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);
                    str_sql = "SELECT  * FROM " + table;
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

                public static DataTable getTableIdTitle(string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);
                    str_sql = "SELECT  id,title FROM " + table;
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, ConnectionString);
                }



                public static string Sql_Del_Row(string field_where, string field_where_value, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add(field_where, field_where_value);
                    str_sql = " DELETE FROM " + table + "  WHERE     (" + field_where + " = @" + field_where + ") ";
                    return DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, ConnectionString).ToString();
                }





                public static DataTable getTableRecent(string table, int top, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);

                    str_sql = "SELECT  TOP (" + top + ") id,title,image,description FROM " + table + " ORDER BY id DESC ";
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, ConnectionString);
                }

                public static DataTable getTableContent(string table, int top, int sortMode)
                {
                    string str_sql="";
                    string str_sql_extra = "";
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    //parameters.Add("field_where_value", field_where_value);,
                    //str_sql = "SELECT  TOP (" + top + ") id,title,image FROM " + table + " ORDER BY id DESC ";

                    string strDate;
                    strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                        + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute  + ":" + DateTime.UtcNow.Second  ;

                    if (table == "estate_1")
                    {
                        table = "estate";
                        str_sql_extra = " AND (" + table + ".agreement_type = 1) ";
                    }

                    if (table == "estate_2")
                    {
                        table = "estate";
                        str_sql_extra = " AND (" + table + ".agreement_type = 2) ";
                    }

                    switch (sortMode )
                    {
                        case 1:
                            str_sql = " SELECT     TOP (" + top + ") " + table + ".id, " + table + ".title , " + table + ".image , " + table + ".description ,"  + table + ".pub_date " +
                            " FROM         " + table + " INNER JOIN " +
                            " Cat ON " + table + ".id = Cat.id_content " +
                            " WHERE     (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND (" + table + ".enable = 1) AND (Cat.Valid = 1) AND (Cat.deleted = 0) AND (Cat.type_content = N'" + table + "') " +
                            str_sql_extra + 
                            " ORDER BY " + table + ".id DESC ";
                            break;
                        case 2:
                            str_sql = " SELECT     TOP (" + top + ") " + table + ".id, " + table + ".title , " + table + ".image , " + table + ".description  ," + table + ".pub_date " +
                            " FROM         " + table + " INNER JOIN " +
                            " Cat ON " + table + ".id = Cat.id_content " +
                            " WHERE     (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND (" + table + ".enable = 1) AND (Cat.Valid = 1) AND (Cat.deleted = 0) AND (Cat.type_content = N'" + table + "') " +
                            str_sql_extra + 
                            " ORDER BY " + table + ".update_date DESC ";
                            break;
                        case 3:
                            str_sql = " SELECT     TOP (" + top + ") " + table + ".id, " + table + ".title , " + table + ".image , " + table + ".description  ," + table + ".pub_date " +
                            " FROM         " + table + " INNER JOIN " +
                            " Cat ON " + table + ".id = Cat.id_content " +
                            " WHERE   (Cat.important =1)  AND (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND (" + table + ".enable = 1) AND (Cat.Valid = 1) AND (Cat.deleted = 0) AND (Cat.type_content = N'" + table + "') " +
                            str_sql_extra + 
                            " ORDER BY " + table + ".id DESC ";
                            break;
                        case 4:
                            str_sql = " SELECT     TOP (" + top + ") " + table + ".id, " + table + ".title , " + table + ".image , " + table + ".description  ," + table + ".pub_date " +
                            " FROM         " + table + " INNER JOIN " +
                            " Cat ON " + table + ".id = Cat.id_content " +
                            " WHERE    (Cat.important =1)  AND  (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND (" + table + ".enable = 1) AND (Cat.Valid = 1) AND (Cat.deleted = 0) AND (Cat.type_content = N'" + table + "') " +
                            str_sql_extra + 
                            " ORDER BY " + table + ".update_date DESC ";
                            break;                           
                        case 5:

                            str_sql = "SELECT      news.id, news.title, news.image, news.description, Cat.type_content, news.enable, COUNT(comment.id_content) AS visitCount " +
                            " FROM         comment INNER JOIN " +
                            " news ON comment.id_content = news.id INNER JOIN " +
                            " Cat ON news.id = Cat.id_content " +
                            " GROUP BY news.id, news.title, news.image, news.description, Cat.type_content, news.enable, Cat.deleted, Cat.Valid, Cat.showTime " +
                            " HAVING      (Cat.type_content = N'news') AND (news.enable = 1) AND (Cat.showTime > CONVERT(DATETIME, '" + DateTime.UtcNow.ToString() + "', 102)) AND (Cat.Valid = 1) AND (Cat.deleted = 0) ORDER BY visitCount DESC, news.id DESC ";

                            break;
                        case 6:
                            str_sql = " SELECT     TOP (" + top + ") " + table + ".id, " + table + ".title , " + table + ".image , " + table + ".description ,"  + table + ".pub_date " +
                            " FROM         " + table + " INNER JOIN " +
                            " Cat ON " + table + ".id = Cat.id_content " +
                            " WHERE     (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND (" + table + ".enable = 1) AND (Cat.Valid = 1) AND (Cat.deleted = 0) AND (Cat.type_content = N'" + table + "') " +
                            str_sql_extra + 
                            " ORDER BY cat.visitCounter DESC,cat.id DESC ";
                            break;
                        default:
                            break;
                    }
                                        

                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

                public static string getTable(string field_target, string field_where, string field_where_value, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    parameters.Add("field_where_value", field_where_value);
                    str_sql = ("SELECT  "
                                + (field_target + ("   FROM  "
                                + (table + ("   WHERE     ("
                                + (field_where + " = @field_where_value)"))))));
                    return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString();
                }

                public static string updateField(string field_target_name, string field_target_value, string field_where_name, string field_where_value, string table)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add(field_target_name, field_target_value);

                    parameters.Add(field_where_name, field_where_value);

                    str_sql = "UPDATE    " + table + "    SET              " + field_target_name + " = @" + field_target_name + "   WHERE     (" + field_where_name + " = @" + field_where_name + ")";


                    return DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();





                }

                public static string updateField(string field_target_name, string field_target_value, string field_where_name, string field_where_value, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add(field_target_name, field_target_value);

                    parameters.Add(field_where_name, field_where_value);

                    str_sql = "UPDATE    " + table + "    SET              " + field_target_name + " = @" + field_target_name + "   WHERE     (" + field_where_name + " = @" + field_where_name + ")";


                    return DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, ConnectionString).ToString();





                }


                public static string updateField(string field_target_name, string field_target_value, string field_where_name, string field_where_value, string field_where_name2, string field_where_value2, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add(field_target_name, field_target_value);

                    parameters.Add(field_where_name, field_where_value);
                    parameters.Add(field_where_name2, field_where_value2);


                    str_sql = "UPDATE    " + table + "    SET              " + field_target_name + " = @" + field_target_name + "   WHERE     ( (" + field_where_name + " = @" + field_where_name + ") AND (" + field_where_name2 + " = @" + field_where_name2 + " ) )";


                    return DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, ConnectionString).ToString();





                }


                public static string updateField(string field_target_name, string field_target_value, string field_where_name, string field_where_value, string field_where_name2, string field_where_value2, string field_where_name3, string field_where_value3, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add(field_target_name, field_target_value);

                    parameters.Add(field_where_name, field_where_value);
                    parameters.Add(field_where_name2, field_where_value2);
                    parameters.Add(field_where_name3, field_where_value3);

                    str_sql = "UPDATE    " + table + "    SET              " + field_target_name + " = @" + field_target_name + "   WHERE     ( (" + field_where_name + " = @" + field_where_name + ") AND (" + field_where_name2 + " = @" + field_where_name2 + " ) AND (" + field_where_name3 + " = @" + field_where_name3 + " ) )";


                    return DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, ConnectionString).ToString();





                }



                public static bool Sql_Check_identity(string field, string field_value, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    parameters.Add("field_value", field_value);
                    str_sql = ("SELECT  *   FROM  "
                                + (table + ("   WHERE     ("
                                + (field + " = @field_value)"))));
                    if ((DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, ConnectionString) == null))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public static bool Sql_Check_identity(string field, string field_value, string field2, string field_value2, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    parameters.Add("field_value", field_value);
                    parameters.Add("field_value2", field_value2);

                    str_sql = "SELECT  *   FROM  "
                                + table + "   WHERE     (" + field + " = @field_value) AND (" + field2 + " = @field_value2)";
                    if ((DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, ConnectionString) == null))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public static bool Sql_Check_identityArray(ArrayList a, ArrayList b, string table, string ConnectionString)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                    for (int i = 0; i < a.Count; i++)
                    {
                        parameters.Add(a[i].ToString(), b[i].ToString());
                    }


                    string str_sql_where = "";
                    for (int i = 0; i < a.Count; i++)
                    {
                        if (i == 0)
                        {
                            str_sql_where = " ( " + a[0].ToString() + " = @" + a[0].ToString() + ")";
                        }
                        str_sql_where = str_sql_where + "  AND ( " + a[i].ToString() + " = @" + a[i].ToString() + ")";

                        //" ( + a[0].ToString() + " = @" + a[0].ToString() + ") And (" + a[1].ToString() + " = @" + a[1].ToString() + ")";
                    }



                    str_sql = "SELECT  *   FROM  "
                                + table + "   WHERE " + str_sql_where;



                    if ((DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, ConnectionString) == null))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public static string InstanceValSet(string InstanceId, string propertyTitle, string propertyValue)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add("id_Core_ServerControlsInstance", InstanceId);

                    parameters.Add("propertyValue", propertyValue);

                    parameters.Add("propertyTitle", propertyTitle);


                    //parameters.Add(field_where_name, field_where_value);

                    str_sql = "UPDATE    Core_serverControlsInstanceVal    SET  propertyValue = @propertyValue   WHERE     (propertyTitle = @propertyTitle) AND (id_Core_ServerControlsInstance = @id_Core_ServerControlsInstance)";


                    return DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

                }

                public static string InstanceValGet(string InstanceId, string propertyTitle)
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                    parameters.Add("InstanceId", InstanceId);

                    parameters.Add("title", propertyTitle);

                    str_sql = "SELECT     propertyValue   FROM         Core_serverControlsInstanceVal    WHERE     (id_Core_ServerControlsInstance = @InstanceId) AND (propertyTitle = @title)";


                    return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

                }



                public static string runSqlFile(string fileurl)
                {
                    SqlConnection conn = null;
                    string str_response = "";

                    try
                    {
                        str_response = str_response + String.Format("Opening url {0}<BR>", fileurl);

                        // read file
                        WebRequest request = WebRequest.Create(fileurl);
                        //using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream())) 

                        StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream());

                        // Create new connection to database
                        str_response = str_response + "Connecting to SQL Server database...<BR>";

                        conn = new SqlConnection(khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        conn.Open();

                        while (!sr.EndOfStream)
                        {
                            StringBuilder sb = new StringBuilder();
                            SqlCommand cmd = conn.CreateCommand();



                            while (!sr.EndOfStream)
                            {
                                string s = sr.ReadLine();

                                if (s != null && s.ToUpper().Trim().Equals("GO"))
                                {
                                    break;
                                    //'''''GoTo break


                                }


                                sb.AppendLine(s);
                            }
                            // Execute T-SQL against the target database
                            cmd.CommandText = sb.ToString();

                            //cmd.CommandTimeout = timeout;
                            cmd.CommandTimeout = 600;
                            cmd.ExecuteNonQuery();

                            str_response = str_response + "T-SQL file executed successfully<br>";

                        }



                    }
                    catch (Exception ex)
                    {

                        str_response = str_response + String.Format("An error occured: {0}<br>", ex.ToString());


                    }


                    return str_response;
                }


                public static DataSet xlsToDataSet(string path, string file)
                {
                    IExcelDataReader iExcelDataReader = null;

                    //FileInfo fileInfo = new FileInfo(FpdUnConLoanUpload.PostedFile.FileName);
                    // string file = fileInfo.Name;
                    //*string path = Server.MapPath(@"upload\");
                    //  FpdUnConLoanUpload.SaveAs(path + FpdUnConLoanUpload.FileName);


                    FileStream oStream = File.Open(path + file , FileMode.Open, FileAccess.Read);


                    if (file.Split('.')[1].Equals("xls"))
                    {
                        iExcelDataReader = ExcelReaderFactory.CreateBinaryReader(oStream);
                    }
                    else if (file.Split('.')[1].Equals("xlsx"))
                    {
                        iExcelDataReader = ExcelReaderFactory.CreateOpenXmlReader(oStream);
                    }

                    iExcelDataReader.IsFirstRowAsColumnNames = true;
                    DataSet dsUnUpdated = new DataSet();
                    dsUnUpdated = iExcelDataReader.AsDataSet();
                    iExcelDataReader.Close();
                    //  if (dsUnUpdated != null)
                    //        {
                    //      }
                    //    else
                    //  {
                    //    Label1.Text = "No Data Found In The Excel Sheet!";
                    //}

                    return dsUnUpdated;


                }


            }


        }
    }
}


public static class DBFunctions
{
    #region Methods
    /// <summary>
    /// Executes an sql command and returns the number of rows affected.
    /// </summary>
    /// <param name="command">sql command</param>
    /// <param name="parameters">parameters to pass to sql command</param>
    /// <param name="commandType">The type of command</param>
    /// <param name="connectionString">connection String used in this query</param>
    /// <returns>Returns the number of effected rows.</returns>
    public static int ExecuteNonQuery(string command, Dictionary<string, object> parameters, CommandType commandType, string connectionString)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(command, connection);
        cmd.CommandType = commandType;
        foreach (string key in parameters.Keys)
            cmd.Parameters.AddWithValue(string.Format("@{0}", key), parameters[key]);
        int output = 0;
        // SELECT Execution


        try
        {
            connection.Open();
            output = cmd.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
        }
        return output;
    }
    /// <summary>
    /// Executes an sql command and returns a field.
    /// </summary>
    /// <param name="command">sql command</param>
    /// <param name="parameters">parameters to pass to sql command</param>
    /// <param name="commandType">The type of command</param>
    /// <param name="connectionString">connection String used in this query</param>
    /// <returns>Returns the result object.</returns>
    public static object ExecuteScaler(string command, Dictionary<string, object> parameters, CommandType commandType, string connectionString)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(command, connection);
        cmd.CommandType = commandType;
        foreach (string key in parameters.Keys)
            cmd.Parameters.AddWithValue(string.Format("@{0}", key), parameters[key]);
        object output = null;
        // SELECT Execution
        try
        {
            connection.Open();
            output = cmd.ExecuteScalar();
        }
        finally
        {
            connection.Close();
        }
        return output;
    }
    /// <summary>
    /// Executes an sql command and returns a DataTable.
    /// </summary>
    /// <param name="command">sql command</param>
    /// <param name="parameters">parameters to pass to sql command</param>
    /// <param name="commandType">The type of command</param>
    /// <param name="connectionString">connection String used in this query</param>
    /// <returns>Returns the result table.</returns>
    public static DataTable ExecuteReader(string command, Dictionary<string, object> parameters, CommandType commandType, string connectionString)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(command, connection);
        cmd.CommandType = commandType;
        foreach (string key in parameters.Keys)
            cmd.Parameters.AddWithValue(string.Format("@{0}", key), parameters[key]);
        DataTable output = new DataTable();
        // SELECT Execution
        try
        {
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            output.Load(reader);
        }
        catch (Exception)
        {
            // Do Nothing ...
        }
        finally
        {
            connection.Close();
        }
        return output;
    }
    #endregion
}
