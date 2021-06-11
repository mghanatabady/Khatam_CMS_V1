using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Manage_c_baseSetting : System.Web.UI.UserControl
{


   

    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "تنظیمات پایه";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/Setting.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " تنظیمات پایه";
        l.Text = l.Text + "</span> ";

        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            this.btnOK.Enabled = false;
            this.btnOK.ToolTip ="این امکان در نسخه نمایشی وجود ندارد";
        }


        if (this.IsPostBack == false)
        {
            txtTitleFa.Text = khatam.core.data.sql.getBaseSetting("Title", "1");
            txtTitleEn.Text = khatam.core.data.sql.getBaseSetting("Title", "2"); 
            txtTitleAR.Text = khatam.core.data.sql.getBaseSetting("Title", "3"); 
            txtTitleDE.Text = khatam.core.data.sql.getBaseSetting("Title", "4");

            txt_tel.Text = khatam.core.data.sql.getBaseSetting("tel", "0");
            txt_email.Text = khatam.core.data.sql.getBaseSetting("email", "0");
            txt_cellphone.Text = khatam.core.data.sql.getBaseSetting("cellphone", "0");
            txt_address.Text = khatam.core.data.sql.getBaseSetting("address", "0");
            txt_fax.Text = khatam.core.data.sql.getBaseSetting("fax", "0");
            
            string Logo = khatam.core.data.sql.getBaseSetting("logo", "0");

            if (Logo == "")
            {
                img_logo.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo2.jpg";
            }
            else
            {
                img_logo.ImageUrl = Logo ;
            }

          

        }

      

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {

        khatam.core.data.sql.updateField("memo", txtTitleFa.Text, "cname", "title", "language", "1", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        khatam.core.data.sql.updateField("memo", txtTitleEn.Text, "cname", "title", "language", "2", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        khatam.core.data.sql.updateField("memo", txtTitleAR.Text, "cname", "title", "language", "3", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        khatam.core.data.sql.updateField("memo", txtTitleDE.Text, "cname", "title", "language", "4", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        khatam.core.data.sql.updateField("memo", txt_tel.Text, "cname", "tel", "language", "0", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        khatam.core.data.sql.updateField("memo", txt_email.Text, "cname", "email", "language", "0", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        khatam.core.data.sql.updateField("memo", txt_cellphone.Text, "cname", "cellphone", "language", "0", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());       
        khatam.core.data.sql.updateField("memo", txt_address.Text, "cname", "address", "language", "0", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());       
        khatam.core.data.sql.updateField("memo", txt_fax.Text, "cname", "fax", "language", "0", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());       
      
 

        //Khatam_Functions.KUI.setting.setting_base.set_Setting_base("logo",
          //  this.Upload1._FileUpload.FileName , 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        //check kardan pasvand

        string path;
        path = Server.MapPath(@"upload\logo\");        
        DirectoryInfo di = new DirectoryInfo(Server.MapPath(@"upload\logo\"));
        
        if (di.Exists == false)
        {
            di.Create();
        }

        Label1.Text = "";

        if (FileUpload1.HasFile)
        {
            string extention= System.IO.Path.GetExtension(FileUpload1.FileName).ToUpper();
            if ((".JPG" == extention) || (".GIF" == extention) || (".PNG" == extention))
            {
                int fileSize = FileUpload1.PostedFile.ContentLength;
                if (fileSize < 100000)
                {
                    FileUpload1.SaveAs(path + FileUpload1.FileName);
                    khatam.core.data.sql.updateField("memo", khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                        @"manage/upload/logo/"  + FileUpload1.FileName ,
                        "cname", "logo", "language", "0", "Setting_Base", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());       

                }
                else 
                {
                    Label1.Text =  fileSize + "حجم فایل انتخابی شما از 100 کیلو بایت بیشتر است";

                }
            }
            else
            {
                Label1.Text = "نوع فایل انتخابی شما برای آپلود مجاز نیست. پسوند های معتبر  jpg,gif,png,jpeg";
            }
        }

        khatam.core.Drawing.windows.msg msg = new khatam.core.Drawing.windows.msg();
        msg.title = "عملیات موفقیت آمیز";
        msg.memo = "تغییرات مورد نظر شما اعمال گردید";
        msg.msgMode= khatam.core.Drawing.windows.msgMode.Success ;
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

   
}