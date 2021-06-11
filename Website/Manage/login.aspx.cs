
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manage_Login : System.Web.UI.Page
{
   public  string LangChar;
   public int c_passwordTry ;

   public string Authorization, pleaseAuthorize, UserName, Password, RememberMeOnthisComputer, Login
       , PleaseInsertYourUsername, Authorize, ForgotYourPassword, Gotothe, requestPasswordForm, CAPTCHAcode,uniStudentId,
       IncorrectCAPTCHAcodeEntered, UsernameOrPasswordIsWrong, PleaseInsertUsername, PleaseInsertPassword, PleaseInsertCaptcha, EmailNotActive,
      student,Employee,UniversityTeachers;


   protected void Page_Load(object sender, EventArgs e)
   {


       //this.CaptchaControl1.DataBind();

       Shinkansen.Web.UI.WebControls.CssInclude css1 = new Shinkansen.Web.UI.WebControls.CssInclude();
       css1.Path = "~/core/themeCP/Bitrix/StyleSheet.css";
       StaticResourceManager1.Css.Add(css1);

       //this.Session["Userstatus"] = "Accepted";
       //this.Response.Redirect("~/install/default.aspx");
       if (khatam.core.ConfigurationManager.License.demo)
       {
           ltr_demo.Text = khatam.core.UI.SectionManager.demoBarHtml();
           ltl_status_script.Text = khatam.core.UI.SectionManager.demoFooterScript();
           if (Page.IsPostBack == false)
           {
               TxtUserName.Text = "demo@yourDomain.com";
           }
          // TxtPassword.TextMode = TextBoxMode.SingleLine;
          // TxtPassword.Text = "demo";


       }

       demoUserPass.Visible = khatam.core.ConfigurationManager.License.demo;


       LangChar = "en-US";



       if (Request.QueryString["lang"] == null )
       {
           LangChar = "fa-IR";
       }
       else
       {
         LangChar = Request.QueryString["lang"];
       }

      this.Title =khatam.core.ConfigurationManager.Cp.brandTitle(LangChar ) ;



       DataSet ds = new DataSet();

       //ds.ReadXml(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"Module\Install\Localization\" + LangChar + @"\LoginForm.xml");

       //ds.ReadXml( @"Module\Install\Localization\" + LangChar + @"\LoginForm.xml");

       ds.ReadXml(Server.MapPath( @"~\core\Localization\" + LangChar + @"\LoginForm.xml"));

       int length;
      length = ds.Tables[0].Rows.Count;
       

       for (int i = 0; i < length; i++)
       {
           switch (ds.Tables[0].Rows[i].ItemArray[0].ToString())
           {

               case "Authorization":
                   Authorization = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;
               case "pleaseAuthorize":
                   pleaseAuthorize = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;
               case "UserName":
                   UserName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   if (khatam.core.License.ValidModule("uniproj")){
                       UserName =  " ایمیل / شماره دانشجویی ";
                   };
                   break;
               case "Password":
                   Password = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;
               case "RememberMeOnthisComputer":
                   RememberMeOnthisComputer = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;
               case "PleaseInsertYourUsername":
                   PleaseInsertYourUsername = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;
               case "Authorize":
                   Authorize = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   Button1.Text = Authorize;
                

                   break;
               case "ForgotYourPassword":
                   ForgotYourPassword = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;

               case "Gotothe":
                   Gotothe = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;
               case "requestPasswordForm":
                   //requestPasswordForm = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   if (this.Request.QueryString["lang"] != null)
                   {
                       requestPasswordForm = "<a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/forgot_password.aspx?lang=" + this.Request.QueryString["lang"] + "\">" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "</a>";
                   }
                   else
                   {
                       requestPasswordForm = "<a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/forgot_password.aspx" + "\">" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "</a>";
                   }
                   break;
               case "CAPTCHAcode":
                   CAPTCHAcode = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;
               case "IncorrectCAPTCHAcodeEntered":
                   IncorrectCAPTCHAcodeEntered = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   LblIncorectCaptcha.Text = IncorrectCAPTCHAcodeEntered;
                   break;
               case "EmailNotActive":
                   EmailNotActive = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   LblEmailNotActive.Text =   EmailNotActive +  "</ br>" +
                       
                       "<a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/ActivationReSend.aspx" + "\">"  + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/ActivationReSend.aspx" +"</a>" +  "</ br>" ;
                   
                   break;
               case "UsernameOrPasswordIsWrong":
                   UsernameOrPasswordIsWrong = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   LblIncorectUserOrPass.Text = UsernameOrPasswordIsWrong;
                   break;
               case "PleaseInsertUsername":
                   PleaseInsertUsername = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   this.VrfUsername.ErrorMessage = PleaseInsertUsername;
                   break;
               case "PleaseInsertPassword":
                   PleaseInsertPassword = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   this.VrfPassword.ErrorMessage = PleaseInsertPassword;
                   break;

               case "PleaseInsertCaptcha":
                   PleaseInsertCaptcha = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   this.VrfCaptcha.ErrorMessage = PleaseInsertCaptcha;
                   break;

               case "uniStudentId":
                   uniStudentId = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;

              case "student":
                   student = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;

              case "Employee":
                   Employee = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;

              case "UniversityTeachers":
                   UniversityTeachers = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   break;

               default:

                   break;
           }

       }


    


   }




   protected override void InitializeCulture()
   {
       string _culture;
       // TODO: On Error GoTo 10 Warning!!!: The statement is not translatable 
       try
       {
           _culture = Request.QueryString["lang"];
       }
       catch
       {
           _culture = "fa-ir";
       }
       finally
       {
           _culture = "fa-ir";
       }


       this.UICulture = _culture;
       this.Culture = _culture;
       LangChar = _culture;
   }

   protected void Button1_Click(object sender, EventArgs e)
   {
       //this.Session["studentId"] = null ;
     //  this.Session.Clear();
       
       //  ValidationSummary1.
       this.LblIncorectUserOrPass.Visible = false ;
       this.LblIncorectCaptcha.Visible = false;
       this.LblEmailNotActive.Visible = false;                  

     //      if (!CaptchaImage1.TestText(TxtCaptcha.Text))
       //    {
               //Inform user that his input was wrong ...
               //return;

         //      LblIncorectCaptcha.Visible = true;
              
         //  }
         //  else
   //        {
               //   login();
               Login_proccess();


     //      }
       
    
   }

   public void Login_proccess()
    {

       string userName = khatam.core.Security.input.removeInjectionChars(this.TxtUserName.Text);
       string password = khatam.core.Security.input.removeInjectionChars(this.TxtPassword.Text);

      int loginResult=khatam.core.Security.Users.login(userName, password);

      if (loginResult >0)
      {
          set_cookie(userName, password);
          Session["uid"] = loginResult;
          khatam.core.strings.Url.RedirectTo("~/manage/default.aspx", this.Page);
      }
      switch (loginResult)
      {
          //faild user pass
          case -2:
            LblIncorectUserOrPass.Visible = true;
            break;
          //faild email is not active
          case -3:
             LblEmailNotActive.Visible = true;
            break;
       
      }
          
    }

  


   bool set_cookie(string userName, string password)
   {
       
       this.Response.Cookies["UID"].Value = userName;
       this.Response.Cookies["PID"].Value = password;
       if (this.USER_REMEMBER.Checked)
       {
           this.Response.Cookies["UID"].Expires = DateTime.Now.AddDays(10);
           this.Response.Cookies["PID"].Expires = DateTime.Now.AddDays(10);
       }
       


       return true;
   }

   protected void Button2_Click(object sender, EventArgs e)
   {

   }
}