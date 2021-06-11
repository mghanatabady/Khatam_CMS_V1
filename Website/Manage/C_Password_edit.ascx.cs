using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using System.IO;

public partial class Manage_C_Password_edit : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "تغییر کلمه عبور";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/passwordEdit.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text  = l.Text + " تغییر کلمه عبور" ;
        l.Text = l.Text + "</span> ";

        hidewins();
        Page.ClientScript.RegisterStartupScript(this.GetType(), "setDialogInCenter", "setDialogInCenter();", true);


        if (khatam.core.ConfigurationManager.License.demo == true)
        {

            this.btnOK.Enabled = false;
            btnOK.ToolTip = "در نسخه دمو این امکان وجود ندارد";
        }


    }


    void  hidewins()
    {
        MSG1.Visible = false;
        MSG2.Visible = false;


    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        

        hidewins();
        if (khatam.core.Security.Users.validatorPassOnlyUserFromCookies(this.Txt_Password_old.Text) != "0")
        {


            int userid =  // khatam.core.Security.Users.getRealName
                khatam.core.Security.Users.login();
            khatam.core.Security.Users.changePassword(userid.ToString(), Txt_Password_new2.Text);

            DemoDialog.AutoOpen = true;
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>startCount();</script>", false);

            //MSG2.Visible = true;


        }
        //from my cat!!! 
        //"""""Y&^trrrrrr4    ````````````````````````````````````````````````````````````
        else
        {
            MSG1.Visible = true;

   
        }
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {


        RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/");

    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }

    protected void btn3(object sender, EventArgs e)
    {
        
 
          }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
    


}

