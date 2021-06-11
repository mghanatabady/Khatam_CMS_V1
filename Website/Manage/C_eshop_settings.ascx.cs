using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using khatam;

public partial class Manage_C_shop_settings : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "تنظیمات فروشگاه";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/shopcat_setting.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " تنظیمات فروشگاه";
        l.Text = l.Text + "</span> ";
        

        
        if (this.Page.IsPostBack == false)
        {
            rows_saleManagerCellPhone.Visible = this.chk_sendSmsToSaleManager.Checked = bool.Parse(
     Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("sendSmsToSaleManager", 0,
     khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));

            

            this.txt_saleManagerCellPhone.Text = 
  Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("saleManagerCellPhone", 0,
  khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            txt_saleManagerCellPhone.Attributes.Add("onkeypress", "return isNumberKey(event)");

            this.txt_saleManagerEmail.Text =
  Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("saleManagerEmail", 0,
  khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        rows_transManagerCellPhone.Visible=    this.chk_sendSmsToTransManager.Checked = bool.Parse(
  Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("sendSmsToTransManager", 0,
  khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));

            this.txt_transManagerCellPhone.Text = 
                Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("transManagerCellPhone", 0,
  khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            txt_transManagerCellPhone.Attributes.Add("onkeypress", "return isNumberKey(event)");


            this.txt_transManagerEmail.Text = 
  Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("transManagerEmail", 0,
  khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


            ddl_invoice_exp.SelectedValue = khatam.core.data.sql.getBaseSetting("invoice_exp", "0");

           // rows_mode2.Visible = false;
          //  rows_mode3.Visible = false;

         /*   switch (this.Request.QueryString["id"])
            {
                case "2":
                    overView.Text = "تنظیمات شیوه ارسال با ایران مارکت سنتر";

                    //rows_mode2.Visible = true;
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
            */
          
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {

 
        Khatam_Functions.KUI.setting.setting_base.set_Setting_base("sendSmsToSaleManager",
            this.chk_sendSmsToSaleManager.Checked.ToString() , 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        if (chk_sendSmsToSaleManager.Checked)
        {
            Khatam_Functions.KUI.setting.setting_base.set_Setting_base("saleManagerCellPhone",
                this.txt_saleManagerCellPhone.Text, 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }
    
        khatam.core.data.sql.setBaseSetting("saleManagerEmail", this.txt_saleManagerEmail.Text, "0");


        Khatam_Functions.KUI.setting.setting_base.set_Setting_base("sendSmsToTransManager",
            this.chk_sendSmsToTransManager.Checked.ToString(), 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        if (chk_sendSmsToTransManager.Checked)
        {
            Khatam_Functions.KUI.setting.setting_base.set_Setting_base("transManagerCellPhone",
            this.txt_transManagerCellPhone.Text, 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }

        khatam.core.data.sql.setBaseSetting("transManagerEmail",this.txt_transManagerEmail.Text, "0");
        khatam.core.data.sql.setBaseSetting("invoice_exp", ddl_invoice_exp.SelectedValue, "0");

        khatam.core.Drawing.windows.msg msg = new khatam.core.Drawing.windows.msg();
        msg.title = "عملیات موفقیت آمیز";
        msg.memo = "تغییرات مورد نظر شما اعمال گردید";
        msg.msgMode = khatam.core.Drawing.windows.msgMode.Success;
        msg.rtl = true;
        Session["msg"] = msg;
        RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/");


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
    protected void chkbox_sms_CheckedChanged(object sender, EventArgs e)
    {
        rows_saleManagerCellPhone.Visible =chk_sendSmsToSaleManager.Checked;
    }
    protected void chkbox_sms_trans_CheckedChanged(object sender, EventArgs e)
    {
        rows_transManagerCellPhone.Visible =chk_sendSmsToTransManager.Checked;
    }
}

