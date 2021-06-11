using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient ;
using System.IO;


public partial class Manage_c_darman_cards_add : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        txt_birthday.Style.Add("direction", "ltr");

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دارمان : ایجاد کارت جدید";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/profile.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=" + this.Request.QueryString["from"] +  "\">دارمان : لیست کارتها</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " دارمان : ایجاد کارت جدید";
        l.Text = l.Text + "</span> ";

        ddl_darman_cards_type.DataSource = getDarman_cards_type();
        ddl_darman_cards_type.DataTextField = "titleFa";
        ddl_darman_cards_type.DataValueField = "id";
        ddl_darman_cards_type.DataBind();

     

    }

    public static DataTable getDarman_cards_type()
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        //parameters.Add("field_where_value", field_where_value);
        str_sql = "SELECT  [id]      ,[title]  + ' ' + cast([price_rls] as nvarchar) + N' ریال'   as titleFa FROM [darman_cards_type]";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {


        int userid = khatam.core.Security.Users.login();

        string invoiceId = ""; string idRandom;

        idRandom = khatam.core.Security.Users.MakePassword(4);


        string path;
        path = Server.MapPath(@"upload\content\darmancard\0\");
        for (int i = 0; i < 10; i++)
        {
            DirectoryInfo di = new DirectoryInfo(Server.MapPath(@"upload\content\darmancard\0\"));
            if (di.Exists == false)
            {
                di.Create();
            }
        }
        if (FileUpload1.HasFile)
        {          
       
               // ltrMessage.Text = khatam.core.Drawing.windows.getErrorMessage("خطا!", System.IO.Path.GetExtension(FileUpload1.FileName), true);

                if (".JPG" == System.IO.Path.GetExtension(FileUpload1.FileName).ToUpper())
                {
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    if (fileSize < 200000)
                    {

                      
                        string guid = Guid.NewGuid().ToString();
                        guid = guid.ToString().Replace("-", "");



                       FileUpload1.SaveAs(path + guid + "_" + FileUpload1.FileName);

                       string cardPrice = khatam.core.data.sql.getField( "price_rls", "id", ddl_darman_cards_type.SelectedValue, "darman_cards_type");
                       string cardTitle = khatam.core.data.sql.getField( "title", "id", ddl_darman_cards_type.SelectedValue, "darman_cards_type");

                       invoiceId = khatam.shop.invoiceManager.invoiceAdd(0, 0, cardPrice, idRandom, false, userid, ""
                                , "", "", "", "", "", "", "", "", 0, 0, "0", "0", false, cardPrice);


                       string invoice_line_id = khatam.shop.invoiceManager.invoiceLineAdd(invoiceId, cardTitle, cardPrice,
                           "1", "0", cardPrice, "darman_cards", "true", "","","",DateTime.UtcNow );


                        ArrayList a = new ArrayList();
                        ArrayList b = new ArrayList();



                        a.Add("darman_cards_type_id");
                        b.Add(ddl_darman_cards_type.SelectedValue );

                        a.Add("fname");
                        b.Add(txt_fname.Text);

                        a.Add("lname");
                        b.Add(txt_lname.Text);

                        a.Add("iranNationalCode");
                        b.Add(txt_iranNationalCode.Text);

                        a.Add("fatherName");
                        b.Add(txt_fatherName.Text);

                        a.Add("birthday");
                        b.Add(txt_birthday.PersianDateString );

                        a.Add("shsh");
                        b.Add(txt_shsh.Text);

                        a.Add("shMahalSodor");
                        b.Add(txt_shMahalSodor.Text);

                        a.Add("tel");
                        b.Add(txt_tel.Text);
                        
                        a.Add("mobile");
                        b.Add(txt_mobile.Text);

                        a.Add("address");
                        b.Add(txt_address.Text);

                        a.Add("regDate");
                        b.Add(DateTime.UtcNow );

                        a.Add("expDate");
                        b.Add(DateTime.UtcNow.AddYears(1));

                        a.Add("pic");
                        b.Add(guid + "_" + FileUpload1.FileName);

                        a.Add("invoice_line_id");
                        b.Add(invoice_line_id);

                        a.Add("invoice_id");
                        b.Add(invoiceId);


                        string cardId=   khatam.core.data.sql.Add(a, b, "darman_cards");


                        khatam.core.data.sql.updateField("title", cardTitle + " شماره کارت " + cardId, "id", invoice_line_id,
                            "core_invoice_line", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());



                        //کنترل خطا
           

                        string EmailBodyNeedPay = " <br />"
            + " <strong>کاربر گرامی،"
            + khatam.core.Security.Users.getRealName(userid.ToString()) + " <br />"
            + " سلام علیکم،</strong><br />"
                            //+ " نام کاربری شما: " + sendTo + "  <br />"
                            // + "کلمه عبور:" + khatam.core.Security.Users.changePasswordRecovery(sendTo) + "<br />"
            + " پیش فاکتور شماره " + invoiceId + " برای شما صادر گردیده است. لطفا نسبت به پرداخت آن اقدام نمایید:<br />"
            + " <br />"
            + " <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay.aspx?id=" + invoiceId + "&pass=" + idRandom + "\">مشاهده و پرداخت پیش فاکتور</a><br />"
            + " <br />"
            + " با تشکر<br />"
            + " <span>"
            + " <br />"
            + " "
            + " <br />"
            + " </span>";

                        //khatam.core.email.sendAllPurposeEmail_old(khatam.core.Security.Users.getEmail(userid.ToString()), khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + ": Customer PreInvoice No," + invoiceId
               // , EmailBodyNeedPay, "اطلاعات پیش فاکتور");


                            RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                                 + "&pass=" + idRandom);

                       // string[] stringBuffer;
                       // stringBuffer = this.FileUpload1.PostedFile.FileName.Split('\\');
                       
                    }
                    else
                    {
                        ltrMessage.Text = khatam.core.Drawing.windows.getErrorMessage("خطا!", "حجم فایل انتخابی بیش از 200 کیلو بایت است", true);
                    }

                }
                else
                {
                    ltrMessage.Text = khatam.core.Drawing.windows.getErrorMessage("خطا!", "لطفا برای ارسال تصویر فایلی با پسوند jpg انتخاب نمایید", true);

                }

  

        }
        else
        {
            ltrMessage.Text = khatam.core.Drawing.windows.getErrorMessage("خطا!","فایل تصویر انتخاب نشده است",true );
            //'پیام در صورت عدم انتخاب فایل
         //   Literal2.Text = "فایلی انتخاب نشده است";
        }

               
        

    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }

    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=" + this.Request.QueryString["from"] );

    }


   


    public static string invoiceLineAdd_changed(string invoice_id, string title,
    string price, string quantity, string catid, string sum, string type_content, string virtual_bool,
    string domain)
    {

        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();



        a.Add("fname");
        b.Add("invoice_id");

        a.Add("lname");
        b.Add("title");


        return khatam.core.data.sql.Add(a, b, "darman_cards");

    }

   

    protected void btnUploadDirectLinkImage_Click(object sender, EventArgs e)
    {

    }
}