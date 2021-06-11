using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json.Linq;

namespace khatam
{
    namespace domain
    {
        
      
               public static class Manager
            {
                   public static string AddToShopCart(string productID, Page page1 )
                    {
                        DataSet ds = new DataSet();
                        DataSet dsc = new DataSet();
                        dsc = (DataSet) page1.Session["ds"];
                       
                        try
                        {
                            if (dsc.Tables.Count > 0)
                            {
                                ds = (DataSet)page1.Session["ds"];

                            }
                        }
                        catch
                        {
                        }


                        DataColumn col_productcode = new DataColumn();
                        col_productcode.ColumnName = "productcode";

                        DataColumn col_productname = new DataColumn();
                        col_productname.ColumnName = "productname";

                        DataColumn col_manufact = new DataColumn();
                        col_manufact.ColumnName = "manufac";

                        DataColumn col_quantity = new DataColumn();
                        col_quantity.ColumnName = "quantity";

                        DataColumn col_price = new DataColumn();
                        col_price.ColumnName = "price";



                        DataRow newrow;//= new DataRow();

                        DataTable newtable = new DataTable();

                        //تعریف جدول جدید
                        //فقط در بار اول
                        if (ds.Tables.Count < 1)
                        {

                            ds.Tables.Add(newtable);

                            //تعریف ستون ها در جدول
                            ds.Tables[0].Columns.Add(col_productcode);
                            ds.Tables[0].Columns.Add(col_productname);
                            ds.Tables[0].Columns.Add(col_manufact);
                            ds.Tables[0].Columns.Add(col_quantity);
                            ds.Tables[0].Columns.Add(col_price);
                        }


                        newrow = ds.Tables[0].NewRow();
                        newrow[0] = khatam.core.data.sql.getField( "id", "id", productID, "shop");
                        newrow[1] = khatam.core.data.sql.getField( "title", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("HL_Title"), HyperLink).Text;
                        newrow[2] = khatam.core.data.sql.getField( "id_iranmc", "id", productID, "shop"); //CType(Me.GridView1.Rows(0).Cells(0).FindControl("Lbl_id_iranmc"), Label).Text;
                        newrow[3] = 1;
                        newrow[4] = khatam.core.data.sql.getField( "price_in_rls", "id", productID, "shop");



                        ds.Tables[0].Rows.Add(newrow);

                        //'خواندن در دیتا ست
                        //'در صورتی که درج ستون دیتا گرید به صورت اتوماتیک غیر فعال باشد ستون تعریف کرده
                        //'به جای نام ستون نام ستون درج شود در اینجا col_productname

                       page1.Session["ds"] = ds;
                        //Me.Label1.Text = CType(Me.GridView1.Rows(0).Cells(0).FindControl("Lbl_id_iranmc"), Label).Text;
                        //Me.MSG2.Visible = True;

                        return "0";
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


                   public static string[] CheckDomain(Page page1)
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


                   public static bool  CheckAvailability(string domainName, string TLDs)
                   {

                       if (isDirectiDomain(domainName + "." + TLDs))
                       {
                           return CheckAvailability_Directi(domainName,TLDs);

                       }
                       else if (isNicDomain(domainName + "." + TLDs))
                       {
                           return CheckAvailability_NicDomain(domainName + "." + TLDs);
                       }

                       return false;
                      }


                   public static bool isDirectiDomain(string DomainNameAndTlds)
                   {
                       string test = DomainNameAndTlds;
                       string[] operators = { ".com", ".net", ".org", ".info",
                                                 ".asia",".us",".name",".in",".biz",".co"
                                             };

                       return operators.Any(x => test.EndsWith(x));
                   }

                   public static bool   isNicDomain(string DomainNameAndTlds)
                   {
                       string test = DomainNameAndTlds;
                       string[] operators = { ".ir", "id.ir", ".co.ir", ".org.ir",
                                                 ".ac.ir",".gov.ir",".sch.ir"  };

                       return operators.Any(x => test.EndsWith(x));
                   }

                   public static bool CheckAvailability_NicDomain(string DomainNameAndTlds)
                   {
                       string str_source_page;
                       //'/***before block***/ str_source_page = getPageSource("http://whois.nic.ir/WHOIS?name=" & domain_name & "." & tlds)
                       str_source_page = khatam.core.Net.webclient.getPageSource("http://whois.nic.ir/WHOIS?name=" + DomainNameAndTlds ); //+ "+-h");
                       
                       if ((Regex.IsMatch(str_source_page, "no match")) ||
                           (Regex.IsMatch(str_source_page, "not found")) ||
                           (Regex.IsMatch(str_source_page, "no entries found"))
                           )
                       {
                           return true   ;
                       }
                       else
                       {
                           
                           return false ;
                           
                       }


                       
                   }

                   public static bool  CheckAvailability_Directi(string domainName, string TLDs)
                   {

                       WebClient webclient = new WebClient();

                       var data = webclient.DownloadString("https://httpapi.com/api/domains/available.json?auth-userid=195964&auth-password=Master5572&domain-name=" + domainName + "&tlds=" + TLDs);
                       //   var data = webclient.DownloadString("https://test.httpapi.com/api/domains/available.json?auth-userid=166694&auth-password=span2012&domain-name=khatamsd&domain-name=prasadvemala2&tlds=com&tlds=com");
                       // var data = webclient.DownloadString("https://httpapi.com/api/domains/available.json?auth-userid=195964&auth-password=Master5572&domain-name=khatamsd&tlds=com");


                       // JArray ja = JArray.Parse(data);
                       // Label1.Text ="Embed Count: " + data.ToString() ;
                       //  Console.ReadLine(); 
                       

                       var jObj = JObject.Parse(data); var val = jObj[domainName + "." + TLDs]["status"].Value<string>();

                       var everythingDictionary = jObj.Properties().Select(p => new
                       {
                           key = p.Name,
                           value = new
                           {
                               status = p.Value["status"].Value<string>(),
                               classkey = p.Value["classkey"].Value<string>()
                           }
                       }).ToDictionary(x => x.key, x => x.value);

                       foreach (var k in everythingDictionary.Keys)
                       {
                           var name = k; var status = everythingDictionary[k].status;
                           var classkey = everythingDictionary[k].classkey;
                       }


                       if (val == "available")
                           return true;
                       else

                           return false;
                       


                    

                   }

                   public static int InstallDomainTree()
                   {
                       string intDomainid="";


                       string catPid = "379";

       if (khatam.core.data.sql.Sql_Check_identity("cname", "دامین های بین المللی", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
       {
           intDomainid = khatam.core.explorer.folderAdd("دامین های بین المللی", catPid, "1");
       }
       else
       {
           intDomainid =  khatam.core.data.sql.getField("id","cname", "دامین های بین المللی", "type_content", "domain","cat");
       }
        //"faghat yekbar"

        if (intDomainid != "")
        {

            if (khatam.core.data.sql.Sql_Check_identity("cname", "com", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("com", intDomainid,"1" );
            }

             if (khatam.core.data.sql.Sql_Check_identity("cname", "net", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("net",  intDomainid,"1");
            }

             if (khatam.core.data.sql.Sql_Check_identity("cname", "org", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("org", intDomainid, "1");
            }

             if (khatam.core.data.sql.Sql_Check_identity("cname", "info", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
             {
                 khatam.core.explorer.fileAdd("info", intDomainid, "1");
             }

             if (khatam.core.data.sql.Sql_Check_identity("cname", "asia", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
             {
                 khatam.core.explorer.fileAdd("asia", intDomainid, "1");
             }

             if (khatam.core.data.sql.Sql_Check_identity("cname", "us", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
             {
                 khatam.core.explorer.fileAdd("us", intDomainid, "1");
             }

                if (khatam.core.data.sql.Sql_Check_identity("cname", "name", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
             {
                 khatam.core.explorer.fileAdd("name", intDomainid, "1");
             }

                if (khatam.core.data.sql.Sql_Check_identity("cname", "in", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
             {
                 khatam.core.explorer.fileAdd("in", intDomainid, "1");
             }

                  if (khatam.core.data.sql.Sql_Check_identity("cname", "biz", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
             {
                 khatam.core.explorer.fileAdd("biz", intDomainid, "1");
             }

                     if (khatam.core.data.sql.Sql_Check_identity("cname", "co", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
             {
                 khatam.core.explorer.fileAdd("co", intDomainid, "1");
             }

                     
            
        }

        //nic domain

        string nicDomainid = "";

        if (khatam.core.data.sql.Sql_Check_identity("cname", "دامین های ایرانی", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
        {
            nicDomainid = khatam.core.explorer.folderAdd("دامین های ایرانی", catPid, "1");
        }
        else
        {
            nicDomainid = khatam.core.data.sql.getField( "id", "cname", "دامین های ایرانی", "type_content", "domain", "cat");
        }

        if (nicDomainid != "")
        {

            if (khatam.core.data.sql.Sql_Check_identity("cname", "ir", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("ir", nicDomainid, "1");
            }

            if (khatam.core.data.sql.Sql_Check_identity("cname", "id.ir", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("id.ir", nicDomainid, "1");
            }

            if (khatam.core.data.sql.Sql_Check_identity("cname", "co.ir", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("co.ir", nicDomainid, "1");
            }

            if (khatam.core.data.sql.Sql_Check_identity("cname", "org.ir", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("org.ir", nicDomainid, "1");
            }

            if (khatam.core.data.sql.Sql_Check_identity("cname", "ac.ir", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("ac.ir", nicDomainid, "1");
            }

            if (khatam.core.data.sql.Sql_Check_identity("cname", "gov.ir", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("gov.ir", nicDomainid, "1");
            }

               if (khatam.core.data.sql.Sql_Check_identity("cname", "sch.ir", "type_content", "domain", "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                khatam.core.explorer.fileAdd("sch.ir", nicDomainid, "1");
            }



         
        }

        return 0;   
                   }

               }
}
}

