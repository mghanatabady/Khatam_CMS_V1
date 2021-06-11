using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace khatam
{
    namespace core
    {
        public static class email
        {

            public static int sendAllPurposeEmail(string sendTo, string Subject, string body, string title,bool needTobeValiduserEmail)
            {


                //## string siteName;
                //## siteName = khatam.core.data.sql.getField("emailsenduser", "memo", "title", "title", "");
                //Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                if (needTobeValiduserEmail)
                {
                    if (khatam.core.Security.Users.ValidEmailOnly(sendTo) == false) return -3001;
                }


                MailMessage mail = new MailMessage();


              //string strFileText=
                  string strHTML; 
strHTML = 

"<html><head><META http-equiv='Content-Type' content='text/html; charset=utf-8'/><style type='text/css'>td{font-family: tahoma;}</style></head>";
 strHTML = strHTML + "<body>";

 string Title = khatam.core.data.sql.getBaseSetting("Title", "1") ;


 string html = "<table width=\"640px\" style=\"font-family: Tahoma\" >"
+ " <tr>"
+ " <td style=\"text-align: right; direction: rtl\">"
+ "<br /> " + "  ||  " + Title + "  ||  "
+  "<a href=\"http://" + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + "\">" + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + "</a> </td>"
+ " </tr>"
+ " <tr>"
+ " <td style=\"direction: rtl\">"
+ "<h4>" + title + "</h4>"
+ body

+ "</td>"
+ " </tr>"
//+ " <tr>"
//+ " <td style=\"direction: rtl\">"
//+ " شهر جدید هشتگرد</td>"
//+ " </tr>"
+ " </table>";




 strHTML = strHTML + html;


 strHTML = strHTML + "</body>";strHTML = strHTML + "</html>"; 




                mail.From = new MailAddress("Do_not_reply@yourDomain.com");

                //'KUI.setting.setting_base.Get_Setting_base("Email_do_not_replay", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))

                mail.To.Add(sendTo);
                //'customer_email)
                //'start select mail to
                mail.Subject = Subject;
                mail.Body = strHTML;
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                //  mail.HeadersEncoding = System.Text.Encoding.UTF8;
                SmtpClient smtp = new SmtpClient();


                smtp.Send(mail);

                return 1;

            }

            public static int sendAllPurposeEmail_old(string sendTo,string Subject,string body,string title)
            {


                //## string siteName;
                //## siteName = khatam.core.data.sql.getField("emailsenduser", "memo", "title", "title", "");
                //Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                if (khatam.core.Security.Users.ValidEmailOnly(sendTo) == false) return -3001;



                MailMessage mail = new MailMessage();


                string strFileText = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">"
        + " <html xmlns=\"http://www.w3.org/1999/xhtml\" >"
        + " <head>"
        + " <title>Untitled Page</title>"
        + " <META content=fa http-equiv=Content-Language>"
        + " <META content=\"text/html; charset=utf-8\" http-equiv=Content-Type>"
        + " "
        + " </head>"
        + " <body style=\"text-align: center; font-family:Tahoma;\">"
        + " <div style=\"width: 785px; font-family:Tahoma \">"
        + " <div style=\"width: 100%; text-align: right\">"
        + " <div style=\"float: left; width: 208px; height: 77px; text-align: center\">"
        + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "\">" +
        khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() +
        " </a> </div>"
                    //+  khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir()  + " Portal 
        + "</div>"
        + " <div dir=\"rtl\" style=\"width: 100%; color: #ff7300; height: 42px; background-color: #ffeac2;"
        + " text-align: center; padding-top: 15px;\">"
        + " <h3>"
        + title + " </h3>"
        + " </div>"
        + " <div style=\"width: 100%\">"
        + " <div dir=\"rtl\" style=\"padding-right: 2%; padding-left: 2%; width: 96%; text-align: justify; font-size: 10pt;\">"
                    //    + " <br />"
                    //    + " <strong>کاربر گرامی،"
                    //    + khatam.core.Security.Users.getRealNameByEmail(sendTo) + " <br />"
                    //    + " سلام علیکم،</strong><br />"
                    //    + " نام کاربری شما: " + sendTo + "  <br />"
                    //     + "کلمه عبور:" + khatam.core.Security.Users.changePasswordRecovery(sendTo) + "<br />"
                    //       + " برای ورود به کنترل پنل از لینک زیر استفاده کنید:<br />"
                    // + " <br />"
                    //  + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/" + "\">Control Panel</a><br />"
                    // + " <br />"
                    // + " با تشکر<br />"
                    //  + " <span>"
                    //  + " <br />"
                    //  + " "
                    //  + " <br />"
                    //  + " </span>"
      + body
        + " </div>"
        + " </div>"
        + " <div style=\"width: 100%; background-color: #ffeac2; height: 20px;\">"
        + " </div>"
        + " </div>"
        + " </body>"
        + " </html>";






                mail.From = new MailAddress("Do_not_reply@yourDomain.com");

                //'KUI.setting.setting_base.Get_Setting_base("Email_do_not_replay", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))

                mail.To.Add(sendTo);
                //'customer_email)
                //'start select mail to
                mail.Subject =Subject;
                mail.Body = strFileText;
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
              //  mail.HeadersEncoding = System.Text.Encoding.UTF8;
                SmtpClient smtp = new SmtpClient();


                smtp.Send(mail);

                return 1;

            }

            public static int sendPasswordRecovery(string userEmail)
            {
                

                //## string siteName;
                //## siteName = khatam.core.data.sql.getField("emailsenduser", "memo", "title", "title", "");
                //Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                if (khatam.core.Security.Users.ValidEmailOnly(userEmail) == false) return -3001;

     

             string EmailBodyNeedPay = " کاربر گرامی، "
        + khatam.core.Security.Users.getRealNameByEmail(userEmail) + " <br />"
        + " سلام علیکم<br /><br />"
        + " نام کاربری شما: " + userEmail + "  <br />"
        + "کلمه عبور:" + khatam.core.Security.Users.changePasswordRecovery(userEmail) + "<br />"
        + " برای ورود به کنترل پنل از لینک زیر استفاده کنید:<br />"
        + " <br />"
        + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/" + "\">Control Panel</a><br />"
        + " <br />"
        + " با تشکر<br />";

             khatam.core.email.sendAllPurposeEmail(userEmail,"Your new password for " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + " Portal "
, EmailBodyNeedPay, "کلمه عبور جدید",true );

//////////////////////////////////////////

              

                return 1;

            }

            public static int sendMembershipActive(string userEmail, string EmailSalt,string password)
            {
                string str_pass ="";
                if (password != "")
                {
                str_pass  = " کلمه عبور: " + password  + "<br /><br />";
                }

                if (khatam.core.Security.Users.ValidEmailOnly(userEmail) == false) return -3001;



                string EmailBodyNeedPay = " کاربر گرامی، "
           + khatam.core.Security.Users.getRealNameByEmail(userEmail) + " <br />"
           + " سلام علیکم<br /><br />"

           + " نام کاربری شما: " + userEmail +     "<br /><br />"
           +str_pass   
           

            + " برای فعال سازی نام کاربری: " + userEmail + "  <br />"      
            + " لطفا بر روی لینک زیر کلیک کنید:<br />"
        + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Activation.aspx?e=" + userEmail + "&s=" + EmailSalt + "\">Link</a>"

        + " <br />"
        + "و یا آدرس زیر را در مرور گر خود کپی کنید:"
        + " <br />" 
        + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Activation.aspx?e=" + userEmail  + "&s=" + EmailSalt  
        + " <br />"
           + " با تشکر<br />";

               
                khatam.core.email.sendAllPurposeEmail(userEmail, "Confirm your " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + " membership "
   , EmailBodyNeedPay, "فعال سازی نام کاربری",true );

                //////////////////////////////////////////



                return 1;

            }

            public static int sendMembershipActive_old(string userEmail,string EmailSalt)
            {

                //## string siteName;
                //## siteName = khatam.core.data.sql.getField("emailsenduser", "memo", "title", "title", "");
                //Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                if (khatam.core.Security.Users.ValidEmailOnly(userEmail) == false) return -3001;



                MailMessage mail = new MailMessage();



                string strFileText = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">"
        + " <html xmlns=\"http://www.w3.org/1999/xhtml\" >"
        + " <head>"
        + " <title>Untitled Page</title>"
        + " <META content=fa http-equiv=Content-Language>"
        + " <META content=\"text/html; charset=utf-8\" http-equiv=Content-Type>"
        + " "
        + " </head>"
        + " <body style=\"text-align: center; font-family:Tahoma;\">"
        + " <div style=\"width: 785px; font-family:Tahoma \">"
        + " <div style=\"width: 100%; text-align: right\">"
        + " <div style=\"float: left; width: 208px; height: 77px; text-align: center\">"
        + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "\">" +
        khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() +
        " </a> </div>"
                    //+  khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir()  + " Portal 
        + "</div>"
        + " <div dir=\"rtl\" style=\"width: 100%; color: #ff7300; height: 42px; background-color: #ffeac2;"
        + " text-align: center; padding-top: 15px;\">"
        + " <h3>"
        + " به جمع کاربران با بپیوندید</h3>"
        + " </div>"
        + " <div style=\"width: 100%\">"
        + " <div dir=\"rtl\" style=\"padding-right: 2%; padding-left: 2%; width: 96%; text-align: justify; font-size: 10pt;\">"
        + " <br />"
        + " <strong>کاربر گرامی،"
        + khatam.core.Security.Users.getRealNameByEmail(userEmail) + " <br />"
        + " سلام علیکم،</strong><br />"
         + " برای فعال سازی نام کاربری: " + userEmail + "  <br />"        
        + " لطفا بر روی لینک زیر کلیک کنید:<br />"
        + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Activation.aspx?e=" + userEmail + "&s=" + EmailSalt + "\">Link</a>"

        + " <br />"
        + "و یا آدرس زیر را در مرور گر خود کپی کنید:"
        + " <br />" 
        + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Activation.aspx?e=" + userEmail  + "&s=" + EmailSalt  
        + " <br />"
        + " با تشکر<br />"
        + " <span>"
        + " <br />"
        + " "
        + " <br />"
        + " </span>"
        + " </div>"
        + " </div>"
        + " <div style=\"width: 100%; background-color: #ffeac2; height: 20px;\">"
        + " </div>"
        + " </div>"
        + " </body>"
        + " </html>";






                mail.From = new MailAddress("Do_not_reply@yourDomain.com" );

                //'KUI.setting.setting_base.Get_Setting_base("Email_do_not_replay", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))

                mail.To.Add(userEmail);
                //'customer_email)
                //'start select mail to
                mail.Subject = "Confirm your " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + " membership ";
                mail.Body = strFileText;
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
               
                SmtpClient smtp = new SmtpClient();


                smtp.Send(mail);

                return 1;

            }



            public static int sendInvoiceToCustomer(string invoice_id,string userId,string sendToEmail)
            {
                
                MailMessage mail = new MailMessage();



                string strFileText = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">"
        + " <html xmlns=\"http://www.w3.org/1999/xhtml\" >"
        + " <head>"
        + " <title>Untitled Page</title>"
        + " <META content=fa http-equiv=Content-Language>"
        + " <META content=\"text/html; charset=utf-8\" http-equiv=Content-Type>"
        + " "
        + " </head>"
        + " <body style=\"text-align: center; font-family:Tahoma;\">"
        + " <div style=\"width: 785px; font-family:Tahoma \">"
        + " <div style=\"width: 100%; text-align: right\">"
        + " <div style=\"float: left; width: 208px; height: 77px; text-align: center\">"
        + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "\">" +
        khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() +
        " </a> </div>"
                    //+  khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir()  + " Portal 
        + "</div>"
        + " <div dir=\"rtl\" style=\"width: 100%; color: #ff7300; height: 42px; background-color: #ffeac2;"
        + " text-align: center; padding-top: 15px;\">"
        + " <h3>"
        + " اطلاعات کلمه عبور جدید</h3>"
        + " </div>"
        + " <div style=\"width: 100%\">"
        + " <div dir=\"rtl\" style=\"padding-right: 2%; padding-left: 2%; width: 96%; text-align: justify; font-size: 10pt;\">"
        + " <br />"
        + " <strong>کاربر گرامی،"
        + khatam.core.Security.Users.getRealName(userId) + " <br />"
        + " سلام علیکم،</strong><br />"
                    //   + " نام کاربری شما: " + userEmail + "  <br />"

      //   + " نام کاربری شما: " + userEmail + "  <br />"
     //   + "کلمه عبور:" + khatam.core.Security.Users.changePasswordRecovery(userEmail) + "<br />"
        + " برای ورود به کنترل پنل از لینک زیر استفاده کنید:<br />"
        + " <br />"
        + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/" + "\">Control Panel</a><br />"
        + " <br />"
        + " با تشکر<br />"
        + " <span>"
        + " <br />"
        + " "
        + " <br />"
        + " </span>"
        + " </div>"
        + " </div>"
        + " <div style=\"width: 100%; background-color: #ffeac2; height: 20px;\">"
        + " </div>"
        + " </div>"
        + " </body>"
        + " </html>";


                



                mail.From = new MailAddress("Do_not_reply@yourDomain.com");

                //'KUI.setting.setting_base.Get_Setting_base("Email_do_not_replay", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))

                mail.To.Add("info@yourDomain.com");
                //'customer_email)
                //'start select mail to
                mail.Subject = "Customer Invoice from " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + " No "  + invoice_id;
                mail.Body = strFileText;
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                SmtpClient smtp = new SmtpClient();


                smtp.Send(mail);

                return 1;

            }


            public static string EmailSendUserEnable111()
            {

               //## string siteName;
               //## siteName = khatam.core.data.sql.getField("emailsenduser", "memo", "title", "title", "");
                    //Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        
        MailMessage mail = new MailMessage();

                

        string strFileText = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">"
+ " <html xmlns=\"http://www.w3.org/1999/xhtml\" >"
+ " <head>"
+ " <title>Untitled Page</title>"
+ " <META content=fa http-equiv=Content-Language>"
+ " <META content=\"text/html; charset=utf-8\" http-equiv=Content-Type>"
+ " "
+ " </head>"
+ " <body style=\"text-align: center; font-family:Tahoma;\">"
+ " <div style=\"width: 785px; font-family:Tahoma \">"
+ " <div style=\"width: 100%; text-align: right\">"
+ " <div style=\"float: left; width: 208px; height: 77px; text-align: center\">"
+ " <a href=\"http://www.yourDomain.com\">www.yourDomain.com </a> </div>"
+ " توسعه نرم افزار خاتم</div>"
+ " <div dir=\"rtl\" style=\"width: 100%; color: #ff7300; height: 42px; background-color: #ffeac2;"
+ " text-align: center; padding-top: 15px;\">"
+ " <h3>"
+ " به جمع کاربران ما بپیوندید</h3>"
+ " </div>"
+ " <div style=\"width: 100%\">"
+ " <div dir=\"rtl\" style=\"padding-right: 2%; padding-left: 2%; width: 96%; text-align: justify; font-size: 10pt;\">"
+ " <br />"
+ " <strong>کاربر گرامی،"
+ " #realname#<br />"
+ " سلام علیکم،</strong><br />"
+ " ضمن تشکر از شما به خاطر تکمیل فرم ثبت نام لطفا برای فعال سازی نام کاربری خود بر "
+ " روی لینک زیر کلیک کنید:<br />"
+ " <br />"
+ " <a href=\"http://www.yourDomain.com\">Linl</a><br />"
+ " <br />"
+ " با تشکر<br />"
+ " <span>"
+ " <br />"
+ " "
+ " <br />"
+ " </span>"
+ " </div>"
+ " </div>"
+ " <div style=\"width: 100%; background-color: #ffeac2; height: 20px;\">"
+ " </div>"
+ " </div>"
+ " </body>"
+ " </html>";
                        
        




        mail.From = new  MailAddress("Do_not_reply@yourDomain.com");

        //'KUI.setting.setting_base.Get_Setting_base("Email_do_not_replay", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))

        mail.To.Add("mghanatabady@yahoo.com");
        //'customer_email)
        //'start select mail to
        mail.Subject = "test mail";
        mail.Body = strFileText;
        mail.IsBodyHtml = true ;
        mail.BodyEncoding = System.Text.Encoding.UTF8;
      SmtpClient smtp = new SmtpClient();


      smtp.Send(mail);

                return "ddddd";

            }




            public static void sendInvoiceToCustomer(string p)
            {
                throw new NotImplementedException();
            }
        }
        namespace Net
        {
            public static class webclient
            {

                public static string getPageSource(string URL)
                {
                    System.Net.WebClient webclient = new System.Net.WebClient();
                    //'System.Net.WebClient(webClient = New System.Net.WebClient())
                    //Dim webclient As New System.Net.WebClient()

                    string strSource;
                    strSource = webclient.DownloadString(URL);
                    webclient.Dispose();
                    return strSource;
                }



            }

            public static class sms
            {

                public static int sendSMS(string MobileNo, string Memo)
                {
                   // try
                   // {
                    KhatamSDRADCORE.com.imencms.www.SMSService ImenCMSService = new KhatamSDRADCORE.com.imencms.www.SMSService();

                    ImenCMSService.SendOneSMS(MobileNo, Memo, @"Co2TR5CCC+U=");                  

                  //  }
                   // catch 
                  //  {
                        
                       
                   // }


                    return 1;

                }

        
            }

        }
    }
}