using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Khatam_Functions;

public partial class Manage_c_shop_sendMode_setting : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "شیوه های ارسال سفارش > تنظیمات";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/trasport.gif";

        string naviUrl = "<a href=\"?mode=shop_sendMode\"  style=\"color: black; text-decoration: none\"  >شیوه های ارسال سفارش</a>";



        Literal l = (Literal)this.Parent.FindControl("Literal1");

        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + naviUrl;
        l.Text = l.Text;
        l.Text = l.Text + "</span> ";

        l.Text = l.Text + " > <span style=\" color: #808080\">";
        l.Text = l.Text + " تنظیمات ";
        l.Text = l.Text;
        l.Text = l.Text + "</span> ";
        

        
        if (this.Page.IsPostBack == false)
        {
            rows_mode2.Visible = false;
            rows_mode3.Visible = false;

            switch (this.Request.QueryString["id"])
            {
                case "2":
                    overView.Text = "تنظیمات شیوه ارسال با ایران مارکت سنتر";

                    rows_mode2.Visible = true;
                      Txt_iranmcMaxOrderPrice.Text =
                Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("iranmcMaxOrderPrice",0,
                khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            Txt_iranmcMaxOrderPrice.Attributes.Add("onkeypress", "return isNumberKey(event)");


                    break;

                case  "3":
                    overView.Text = "تنظیمات شیوه ارسال با ترمینال اتوبوس رانی";

                    rows_mode3.Visible = true;

                    this.Txt_sendmode2_by_agent_per502kg.Text =
        Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("sendmode2_by_agent_per502kg", 0,
        khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


                    break;
               
            }

          
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {


        switch (this.Request.QueryString["id"])
        {
            case "2":

                Khatam_Functions.KUI.setting.setting_base.set_Setting_base("iranmcMaxOrderPrice", Txt_iranmcMaxOrderPrice.Text, 0,
                khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                break;

            case "3":

                Khatam_Functions.KUI.setting.setting_base.set_Setting_base("sendmode2_by_agent_per502kg", this.Txt_sendmode2_by_agent_per502kg.Text, 0,
                khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                break;

        }



                RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=shop_sendMode");
    }
    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=shop_sendMode");

    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }
}