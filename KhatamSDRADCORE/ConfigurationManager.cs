using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace khatam
{
    namespace core
    {
        namespace ConfigurationManager
        {
            public static class ConnectionStrings
            {
                public static string ConnectionString()
                {


                    string dataSource;
                    string catalog;
                    string idStr;
                    string PasswordStr;
                    string TconStr;




                    // if (khatam.core.License.LicenceValidator())
                    if (true)
                    {


                        dataSource = @"185.49.85.134";
                        //  dataSource = @"70.87.28.215";

                        //   catalog = "8gerd";
                        // catalog = "abzarforoshi";
                        catalog = "tsdcarddb";
                        idStr = "tsdcarddba";
                        PasswordStr = "d0d2tE0%";




                        TconStr = "Data Source=" + dataSource + ";Initial Catalog=" + catalog + ";User Id=" + idStr + ";Password=" + PasswordStr;


                        //TconStr = @"Data Source=localhost\sqlexpress;Initial Catalog=" + catalog + ";Integrated Security=True";

                        return TconStr;

                    }
                    else
                    {
                        return "-1";
                    }
                }


            }

            public static class ApplicationPaths
            {
                public static string FullyQualifiedApplicationPath
                {
                    get
                    {
                        //Return variable declaration
                        string appPath = null;

                        //Getting the current context of HTTP request
                        HttpContext context = HttpContext.Current;

                        //Checking the current context content
                        if (context != null)
                        {
                            //Formatting the fully qualified website url/name
                            appPath = string.Format("{0}://{1}{2}{3}",
                            context.Request.Url.Scheme,
                            context.Request.Url.Host,
                                //":" + context.Request.Url.Port,
                            context.Request.Url.Port == 80 ? string.Empty : ":" + context.Request.Url.Port,
                            context.Request.ApplicationPath);
                            // context.Request.ApplicationPath + "/");
                        }
                        if (!appPath.EndsWith("/"))
                            appPath += "/";

                        return appPath;
                    }
                }

            }

            public static class Cp
            {
                public static string themeTitle
                {
                    get
                    {
                        return "Bitrix";
                    }
                }


                public static string brandTitle(string language)
                {
                    if (language == "fa-IR")
                    {
                        return "شرکت تکمیل سلامت دارمان - سیستم مدیریت محتوا";
                    }

                    if (language == "en-US")
                    {
                        return "Takmil salamat Darman (Content Management System)";
                    }

                    if (language == "ar-AE")
                    {
                        return "الشركة تکمیل سلامت دارمان - نظام إدارة المحتوى";
                    }


                    return "Takmil salamat Darman (Content Management System)";
                }



                public static string supportUrl()
                {


                    return "http://www.yourDomain.com";
                }

                public static string brandUrl()
                {


                    return "http://www.yourDomain.com";
                }

            }


            public static class License
            {

                public static string[] domainsArr = { "tsdcard.com" };

                public static string hostip = "46.143.228.12";
                public static DateTime BeginTime = Convert.ToDateTime("2010/11/01");
                public static DateTime ExpireTime = Convert.ToDateTime("2020/11/01");
                public static Int32 userLimit = 1000;
                public static bool demo = false;
                public static string demoNo = "0";

                // "school", "article", "news" , "picture" , "service", "car" , "clip" , "help", "host"
                // "library" , "link" , "portal" , "shop" , "software" , "template" , "trouble_ticket" ,"host", "service", "domain"

                //internal static string[] moduleArr = { "forms", "news", "picture", "forms", "article" };

                internal static string[] moduleArr = { "news", "service", "forms", "trouble_ticket", "darman", "eshop" };


            }


        }


    }
}
