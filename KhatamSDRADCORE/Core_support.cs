using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.IO;
using System.Globalization;


namespace khatam
{
    namespace core
    {
     
            public static class support
            {


                public  static void sendEmailToSupport()
                {

                    string str_body = "";

                    try
                    {
                        str_body = str_body + "آدرس در خواست: " +  HttpContext.Current.Request.Url.PathAndQuery + "<br />";
                    }
                    catch
                    {
                        str_body = str_body + "آدرس در خواست: none <br />";
                    }

                    try
                    {
                    //    str_body = str_body + "آدرس صفحه ارجاع داده شده: " + Utilities.LastError_Page + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "آدرس صفحه ارجاع داده شده: none <br />";

                    }

                    try
                    {
                        str_body = str_body + "IP: " + HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "IP: none <br />";

                    }

                    try
                    {
                        str_body = str_body + "زمان درج درخواست: " + DateTime.UtcNow + " | " + khatam.core.globalization.dateTime.GetPersianDate(DateTime.UtcNow) + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "زمان درج درخواست: none <br />";

                    }

                    try
                    {
                      //  str_body = str_body + "Message: " + Utilities.LastError.InnerException.Message + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "Message: none";
                    }

                    try
                    {
                    //    str_body = str_body + "StackTrace: " + Utilities.LastError.InnerException.StackTrace.Replace("\r", " ") + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "StackTrace: none";

                    }

                    try
                    {
                      //  str_body = str_body + "Source: " + Utilities.LastError.InnerException.Source + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "Source: none";

                    }

                    try
                    {
//str_body = str_body + "Message: " + Utilities.LastError.InnerException.Message;
                    }
                    catch
                    {
                        str_body = str_body + "Message: none";
                    }







                    /*     message_str = .Message

                         stacktrace_str = .StackTrace.Replace(vbCr, "<br>")

                         source_str = .Source
           
                         Dim page_reffer_str, user_ip_str As String
                         Try
                             page_reffer_str = Me.Request.UrlReferrer.PathAndQuery
                         Catch ex As Exception
                             page_reffer_str = "none"
                         End Try

                         Try
                             user_ip_str = Request.ServerVariables("REMOTE_ADDR")
                         Catch ex As Exception
                             user_ip_str = "none"
                         End Try




                         EmailSender_Error("support@yourDomain.com", "khatam: Error " & Me.Request.Url.Host & Me.Request.QueryString("aspxerrorpath") DateTime.UtcNow(), Me.Request.Url.PathAndQuery, Utilities.LastError_Page, message_str, stacktrace_str, source_str, Utilities.LastError_Page_reffer, user_ip_str)
                     End With
       
                 End Sub

              */
                    khatam.core.email.sendAllPurposeEmail("mghanatabady@yahoo.com", "KhatamSDRAD : " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") +
                    " support request", str_body, khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_"), false);

                }

                public static void sendToSupport(string txt)
                {

                    string str_body = "" + txt  +"<br />";

                    try
                    {
                        str_body = str_body + "آدرس در خواست: " + HttpContext.Current.Request.Url.PathAndQuery + "<br />";
                    }
                    catch
                    {
                        str_body = str_body + "آدرس در خواست: none <br />";
                    }

                    try
                    {
                        //    str_body = str_body + "آدرس صفحه ارجاع داده شده: " + Utilities.LastError_Page + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "آدرس صفحه ارجاع داده شده: none <br />";

                    }

                    try
                    {
                        str_body = str_body + "IP: " + HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "IP: none <br />";

                    }

                    try
                    {
                        str_body = str_body + "زمان درج درخواست: " + DateTime.UtcNow + " | " + khatam.core.globalization.dateTime.GetPersianDate(DateTime.UtcNow) + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "زمان درج درخواست: none <br />";

                    }

                    try
                    {
                        //  str_body = str_body + "Message: " + Utilities.LastError.InnerException.Message + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "Message: none";
                    }

                    try
                    {
                        //    str_body = str_body + "StackTrace: " + Utilities.LastError.InnerException.StackTrace.Replace("\r", " ") + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "StackTrace: none";

                    }

                    try
                    {
                        //  str_body = str_body + "Source: " + Utilities.LastError.InnerException.Source + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "Source: none";

                    }

                    try
                    {
                        //str_body = str_body + "Message: " + Utilities.LastError.InnerException.Message;
                    }
                    catch
                    {
                        str_body = str_body + "Message: none";
                    }







                    /*     message_str = .Message

                         stacktrace_str = .StackTrace.Replace(vbCr, "<br>")

                         source_str = .Source
           
                         Dim page_reffer_str, user_ip_str As String
                         Try
                             page_reffer_str = Me.Request.UrlReferrer.PathAndQuery
                         Catch ex As Exception
                             page_reffer_str = "none"
                         End Try

                         Try
                             user_ip_str = Request.ServerVariables("REMOTE_ADDR")
                         Catch ex As Exception
                             user_ip_str = "none"
                         End Try




                         EmailSender_Error("support@yourDomain.com", "khatam: Error " & Me.Request.Url.Host & Me.Request.QueryString("aspxerrorpath") DateTime.UtcNow(), Me.Request.Url.PathAndQuery, Utilities.LastError_Page, message_str, stacktrace_str, source_str, Utilities.LastError_Page_reffer, user_ip_str)
                     End With
       
                 End Sub

              */


                    khatam.core.email.sendAllPurposeEmail("mghanatabady@yahoo.com", "KhatamSDRAD : " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") +
                    " support request", str_body, khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_"), false);
                    WriteError(txt);

                }

                public static void sendEmailToSupport(Exception ex)
                {

                    string str_body = "";

                    try
                    {
                        str_body = str_body + "آدرس در خواست: " + HttpContext.Current.Request.Url.PathAndQuery + "<br />";
                    }
                    catch
                    {
                        str_body = str_body + "آدرس در خواست: none <br />";
                    }

             
                    try
                    {
                        str_body = str_body + "IP: " + HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "IP: none <br />";

                    }

                    try
                    {
                        str_body = str_body + "زمان درج درخواست: " + DateTime.UtcNow + " | " + khatam.core.globalization.dateTime.GetPersianDate(DateTime.UtcNow) + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "زمان درج درخواست: none <br />";

                    }

                    try
                    {
                        str_body = str_body + "Message: " + ex.Message + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "Message: none";
                    }

                    try
                    {
                        str_body = str_body + "StackTrace: " + ex.StackTrace.Replace("\r", " ") + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "StackTrace: none";

                    }

                    try
                    {
                        str_body = str_body + "Source: " + ex.Source + "<br />";

                    }
                    catch
                    {
                        str_body = str_body + "Source: none";

                    }

                    try
                    {
                        str_body = str_body + "Message: " + ex.Message;
                    }
                    catch
                    {
                        str_body = str_body + "Message: none";
                    }


                    khatam.core.email.sendAllPurposeEmail("mghanatabady@yahoo.com", "KhatamSDRAD : " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") +
                    " support request", str_body, khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_"), false);

                }

                public static void WriteError(string errorMessage)
                {
                    try
                    {
                        //string path = "~/Error/" + DateTime.Today.ToString("dd-mm-yy") + ".txt";
                        string path = "~/manage/upload/logs/" + DateTime.Today.ToString("dd-mm-yy") + ".txt";

                        if (!File.Exists(System.Web.HttpContext.Current.Server.MapPath(path)))
                        {
                            File.Create(System.Web.HttpContext.Current.Server.MapPath(path)).Close();
                        }
                        using (StreamWriter w = File.AppendText(System.Web.HttpContext.Current.Server.MapPath(path)))
                        {
                            w.WriteLine("\r\nLog Entry : ");
                            w.WriteLine("{0}", DateTime.UtcNow.ToString()); //ToString(CultureInfo.InvariantCulture));
                            string err = "Error in: " + System.Web.HttpContext.Current.Request.Url.ToString() +
                                          ". Error Message:" + errorMessage;
                            w.WriteLine(err);
                            w.WriteLine("__________________________");
                            w.Flush();
                            w.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteError(ex.Message);
                    }

                }
            }


       
    }
}
