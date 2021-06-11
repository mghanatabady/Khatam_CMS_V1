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
        namespace strings
        {
            public static class Messenger
            {

           
                public static string Gen_Yahoo_Status(string yahooID ,int type)
                {
                    string str;
                    str = " <a href=\"ymsgr:sendIM?" + yahooID + "\"> <img border=0 src=http://opi.yahoo.com/online?u=" + yahooID + "&m=g&t=" + type + " /></a>";
                    
                    //            str = str + "<script language=""javascript"" src=""http://www.parstools.net/yahoo_status/?id=" & dt.Rows(i).Item(0).ToString.ToLower & "&type=" & type & """></script>"
                      

                    
                    return str;
                }

             
            }

            public static class Url
            {
                public static string replaceTitleNonChar(string title)
                {
                    title = title.Replace(' ', '-').Replace(':', '-').Replace('/', '-').Replace('\\', '-').Replace("?","").Replace("؟", "");
                    //,'?','')
                    return title;
                }

                public  static void RedirectTo(string url, Page page)
                {
                  
                    //url is in pattern "~myblog/mypage.aspx"
                    string redirectURL = page.ResolveClientUrl(url);
                    string script = "window.location = '" + redirectURL + "';";
                    ScriptManager.RegisterStartupScript(page, typeof(Page), "RedirectTo", script, true);
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


                    public static string domainAndVirtualDir()
                    {
                        string str_temp = "";
                        str_temp= HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath;
                        str_temp = str_temp.Replace("http://www.", "");
                        str_temp=str_temp.Replace("http://", "");
                        //if (str_temp.EndsWith("/"))
                            str_temp = str_temp.TrimEnd('/');
                            return str_temp;

                    }
                }
            }


        }
    }
}
