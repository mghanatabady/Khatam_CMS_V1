using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class error : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Shinkansen.Web.UI.WebControls.CssInclude css1 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css1.Path = "~/core/themeCP/Bitrix/StyleSheet.css";
        StaticResourceManager1.Css.Add(css1);

        if (this.Request.QueryString["mode"] == "404")
        {

         
            Title = "صفحه مورد نظر شما یافت نگردید - خطای 404";
            PlaceHolder1.Controls.Add(new LiteralControl("<h1>صفحه مورد نظر شما یافت نگردید - خطای 404</h1>"));
            PlaceHolder1.Controls.Add(new LiteralControl("کاربر گرامی، ضمن عرض پوزش به اطلاع می رساند این خطا ممکن است به علت تغییر نام، حذف صفحه و یا اشتباه تایپی شما بوجود آمده باشد. "));
            PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
            PlaceHolder1.Controls.Add(new LiteralControl("<ul>"));
            PlaceHolder1.Controls.Add(new LiteralControl("<li>اگر آدرس را تایپ نموده اید، به درست بودن آن توجه نمایید.</li>"));
            string linkHome = "<a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  +"\">صفحه اصلی</a>";

            PlaceHolder1.Controls.Add(new LiteralControl("<li>به " + linkHome  + " سایت بروید و با بهرگیری از اطلاعات و لینک ها صفحه مورد نظر خود را پیدا کنید.</li>"));
            string linkBack = "<a href=\"javascript:history.back(1)\">صفحه قبلی</a>";
            PlaceHolder1.Controls.Add(new LiteralControl("<li>به " + linkBack  + " بازگردید. </li>"));
            PlaceHolder1.Controls.Add(new LiteralControl("</ul>"));
            
                //    <li>If you typed the address in the address bar, make sure that is spelled correctly.</li>
                //    <li>Go to the Netregistry homepage, or the sitemap and then look for links to the information you want.</li>
                //    <li>Click the Back button to try another link.</li>
            
        }
        else
        {
            Title = "متاسفانه در نمایش این صفحه خطایی رخ داده است";
            PlaceHolder1.Controls.Add(new LiteralControl("<h1>متاسفانه در نمایش این صفحه خطایی رخ داده است</h1>"));
            PlaceHolder1.Controls.Add(new LiteralControl("کاربر گرامی، ضمن عرض پوزش به اطلاع می رساند  این خطا برای گروه پشتیبانی ارسال گردید و در اسرع وقت برطرف می گردد. از شکیبایی شما متشکریم. "));
            PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
            PlaceHolder1.Controls.Add(new LiteralControl("<ul>"));
          //  PlaceHolder1.Controls.Add(new LiteralControl("<li>اگر آدرس را تایپ نموده اید، به درست بودن آن توجه نمایید.</li>"));
            string linkHome = "<a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "\">صفحه اصلی</a>";

            PlaceHolder1.Controls.Add(new LiteralControl("<li>به " + linkHome + " سایت بروید و با بهرگیری از اطلاعات و لینک ها صفحه مورد نظر خود را پیدا کنید.</li>"));
            string linkBack = "<a href=\"javascript:history.back(1)\">صفحه قبلی</a>";
            PlaceHolder1.Controls.Add(new LiteralControl("<li>به " + linkBack + " بازگردید. </li>"));
            PlaceHolder1.Controls.Add(new LiteralControl("</ul>"));

        }
    //    PlaceHolder1.Controls.Add(new LiteralControl("<h1>صفحه مورد نظر شما یافت نگردید</h1>"));

//        <h1>تیتتر</h1>
  //      <br />
              //  شرببببببببببببب ببببب

/*        Oops, looking for something? (404 error)

We're sorry, the page you are looking for might have been removed, had its name changed or be temporarily unavailable.

Please try the following:

    If you typed the address in the address bar, make sure that is spelled correctly.
    Go to the Netregistry homepage, or the sitemap and then look for links to the information you want.
    Click the Back button to try another link.
        */
    }

  

   

   

}