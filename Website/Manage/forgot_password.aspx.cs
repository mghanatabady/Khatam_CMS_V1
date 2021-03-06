using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Manage_forgot_password : System.Web.UI.Page
{

    public string LangChar;


    public string Authorization, pleaseAuthorize, UserName, Password, RememberMeOnthisComputer, Login, UserNotFound
        , PleaseInsertYourUsername, Authorize, ForgotYourPassword, Gotothe, requestPasswordForm, CAPTCHAcode,
        IncorrectCAPTCHAcodeEntered, UsernameOrPasswordIsWrong, PleaseInsertUsername, PleaseInsertPassword, PleaseInsertCaptcha, Email, PasswordRecovery, BackToLoginPage;



    protected void Page_Load(object sender, EventArgs e)
    {

        Shinkansen.Web.UI.WebControls.CssInclude css1 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css1.Path = "~/core/themeCP/Bitrix/StyleSheet.css";
        StaticResourceManager1.Css.Add(css1);

        if (khatam.core.ConfigurationManager.License.demo)
        {
            ltr_demo.Text = khatam.core.UI.SectionManager.demoBarHtml();
            ltl_status_script.Text = khatam.core.UI.SectionManager.demoFooterScript();

            Button1.ToolTip = "در نسخه دمو این امکان غیر فعال است";
            Button1.Enabled = false;
        }


        LangChar = "en-US";



        if (Request.QueryString["lang"] == null)
        {
            LangChar = "fa-IR";
        }
        else
        {
            LangChar = Request.QueryString["lang"];
        }

        this.Title = khatam.core.ConfigurationManager.Cp.brandTitle(LangChar);


        this.lblEmailSentOD.Visible = false;
        
        //this.Session["Userstatus"] = "Accepted";
        //this.Response.Redirect("~/install/default.aspx");
       
  

       


        //       this.styleTag.Href = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "themeCP/" + khatam.core.ConfigurationManager.Cp.themeTitle + "/StyleSheet.css";


        DataSet ds = new DataSet();

        //ds.ReadXml(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"Module\Install\Localization\" + LangChar + @"\LoginForm.xml");

        //ds.ReadXml( @"Module\Install\Localization\" + LangChar + @"\LoginForm.xml");

        ds.ReadXml(Server.MapPath(@"~\core\Localization\" + LangChar + @"\LoginForm.xml"));

        int length;
        length = ds.Tables[0].Rows.Count;


        for (int i = 0; i < length; i++)
        {
            switch (ds.Tables[0].Rows[i].ItemArray[0].ToString())
            {

                case "PasswordRecovery":
                    PasswordRecovery = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    break;
                case "pleaseAuthorize":
                    pleaseAuthorize = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    break;
                case "UserName":
                    UserName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
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
                case "Send":
                    Button1.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    
                    break;
                case "ForgotYourPassword":
                    ForgotYourPassword = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    break;

                case "Gotothe":
                    Gotothe = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    break;
                case "requestPasswordForm":
                    requestPasswordForm = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    break;
                case "CAPTCHAcode":
                    CAPTCHAcode = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    break;
                case "IncorrectCAPTCHAcodeEntered":
                    IncorrectCAPTCHAcodeEntered = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    LblIncorectCaptcha.Text = IncorrectCAPTCHAcodeEntered;
                    break;
                case "UserNotFound":
                    UserNotFound = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    LblUserNotFound.Text = UserNotFound;
                    break;
                case "PleaseInsertUsername":
                    PleaseInsertUsername = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    this.VrfUsername.ErrorMessage = PleaseInsertUsername;
                    break;
                case "Email":
                    Email = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    //this.TxtEmail = PleaseInsertPassword;
                    break;

                case "EmailSentOD":
                    this.lblEmailSentOD.Text  = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    //this.TxtEmail = PleaseInsertPassword;
                    break;
                    

                case "BackToLoginPage":
                    if (this.Request.QueryString["lang"] != null)
                    {
                        
                        BackToLoginPage = "<a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/login.aspx?lang=" + this.Request.QueryString["lang"] + "\">" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "</a>";
                    }
                    else
                    {
                        BackToLoginPage = "<a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/login.aspx" + "\">" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "</a>";
                    }
                    
                    break;


                default:

                    break;
            }

        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {


        if (!CaptchaImage1.TestText(TxtCaptcha.Text))
        {
            //Inform user that his input was wrong ...
            //return;

            LblIncorectCaptcha.Visible = true;
        }
        else
        {


            int msg;

            msg = khatam.core.email.sendPasswordRecovery(TxtEmail.Text);


            

            this.LblUserNotFound.Visible = true;

            if (msg < 1)
            {
                this.LblUserNotFound.Visible = true;
            }
            else
            {
               // table.Visible = false;
                this.lblEmailSentOD.Visible = true;
            }

           

        }


        
 
       // this.LblUserNotFound.Visible = true;
        
    }
}