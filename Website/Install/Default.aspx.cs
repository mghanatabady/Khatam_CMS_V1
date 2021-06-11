using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;


public partial class Install_Default : System.Web.UI.Page
{
    public string LangChar;


    public string Authorization, pleaseAuthorize, UserName, Password, RememberMeOnthisComputer, Login
        , PleaseInsertYourUsername, Authorize, ForgotYourPassword, Gotothe, requestPasswordForm, CAPTCHAcode,
        IncorrectCAPTCHAcodeEntered, UsernameOrPasswordIsWrong, PleaseInsertUsername, PleaseInsertPassword, PleaseInsertCaptcha;



    protected void Page_Load(object sender, EventArgs e)
    {
        Shinkansen.Web.UI.WebControls.CssInclude css1 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css1.Path = "~/core/themeCP/Bitrix/StyleSheet.css";
        StaticResourceManager1.Css.Add(css1);

        Title = "Khatam Software Development WebSiteBuilder || install";

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;

        if (this.CheckBox1.Checked == true)
        {
            khatam.core.ConfigurationManager.installation.update();


            // System.Configuration.Configuration webConfigApp = WebConfigurationManager.OpenWebConfiguration("~");
            //webConfigApp.AppSettings.Settings["installed"].Value = "true";
            // webConfigApp.Save();

            bool checkIdentity = false;

            checkIdentity = khatam.core.data.sql.Sql_Check_identity("email", this.txtEmail.Text, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            if (checkIdentity)
            {

                 string EmailSalt = khatam.core.Security.Users.CreateSalt(20);

                string userid;
                userid = khatam.core.Security.Users.Add(txtEmail.Text, txtFname.Text, txtLname.Text, txtTel.Text,
                      "", "", "", "", "", "", "", "", txtPassword.Text, "", true, false, EmailSalt);

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("idPermission");
                b.Add("1");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();


                a.Add("idPermission");
                b.Add("335");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();

                a.Add("idPermission");
                b.Add("2");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();

                a.Add("idPermission");
                b.Add("20");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();

                a.Add("idPermission");
                b.Add("21");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();

                a.Add("idPermission");
                b.Add("22");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();

                a.Add("idPermission");
                b.Add("23");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();

                a.Add("idPermission");
                b.Add("25");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();

                a.Add("idPermission");
                b.Add("26");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();


                a.Add("idPermission");
                b.Add("27");

                a.Add("idUser");
                b.Add(userid);

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

                a.Clear();
                b.Clear();




                // idUsers = khatam.core.data.sql.AddScope(a, b, "users",khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                
                
                Label2.Visible = true;
                Label2.Text = khatam.core.email.sendMembershipActive(txtEmail.Text, EmailSalt,"").ToString();
                HttpContext.Current.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/");
            }
            else
            {
                Label2.Visible = true;
            }



        }
        else
        {
            Label1.Visible = true;
        }
    }
}