using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.HtmlControls;

public partial class print : System.Web.UI.Page
{
    public class PrintHelper
    {

        public PrintHelper()
        {

            // 

            // TODO: Add constructor logic here 

            // 

        }

        public static void PrintWebControl(Control ctrl)
        {

            PrintWebControl(ctrl, string.Empty);

        }
 /*  <asp:button id="BtnPrint" runat="server" text="Print" onclientclick="javascript:CallPrint('bill');" xmlns:asp="#unknown" />*/



        public static void PrintWebControl(Control ctrl, string Script)
        {

            StringWriter stringWrite = new StringWriter();

            System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);

            if (ctrl is WebControl)
            {

                Unit w = new Unit(100, UnitType.Percentage); ((WebControl)ctrl).Width = w;

            }

            Page pg = new Page();

            pg.EnableEventValidation = false;

            if (Script != string.Empty)
            {

                pg.ClientScript.RegisterStartupScript(pg.GetType(), "PrintJavaScript", Script);

            }

            HtmlForm frm = new HtmlForm();

            pg.Controls.Add(frm);

            frm.Attributes.Add("runat", "server");

            frm.Controls.Add(ctrl);

            pg.DesignerInitialize();

            pg.RenderControl(htmlWrite);

            string strHTML = stringWrite.ToString();

            HttpContext.Current.Response.Clear();

            HttpContext.Current.Response.Write(strHTML);

            HttpContext.Current.Response.Write("<script>window.print();</script>");

            HttpContext.Current.Response.End();

        }

    } 


    protected void Page_Load(object sender, EventArgs e)
    {
        string content_id, content_type;

        
        content_id =this.Request.QueryString["id"];
        content_type =this.Request.QueryString["type_content"];
        khatam.core.data.sql.contentItem ci = new khatam.core.data.sql.contentItem();
        ci = khatam.core.data.sql.getContentItemBaseInfo(content_id, content_type);

   
        string siteUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath;

        string Logo = khatam.core.data.sql.getBaseSetting("logo", "0");
        string titleSite = khatam.core.data.sql.getBaseSetting("Title", "1");
        string domainName = khatam.core.ConfigurationManager.License.domainsArr[0];
        string tel = khatam.core.data.sql.getBaseSetting("tel", "0");
        string email = khatam.core.data.sql.getBaseSetting("email", "0");
        string cellphone = khatam.core.data.sql.getBaseSetting("cellphone", "0");
        string address = khatam.core.data.sql.getBaseSetting("address", "0");
        string fax = khatam.core.data.sql.getBaseSetting("fax", "0");

        this.Page.Title =  titleSite  + " | " + ci.title ;


        string LogoPathAndFile;

        if (Logo == "")
        {
            LogoPathAndFile = siteUrl + "theme/Flowhub/CssImage/Element/no_photo2.jpg";
        }
        else
        {
            LogoPathAndFile = Logo;
        }

        imgLogo.Src = LogoPathAndFile;
        lblTitle.Text = titleSite + " " + domainName;

    
        LblId.Text =  content_id + " | " + content_type ;
        if (ci.pub_date > DateTime.MinValue )
        {
            lblDate.Text = khatam.core.globalization.numbers.GetPersianNumbers(khatam.core.globalization.dateTime.GetPersianDateTime(ci.pub_date));
        }
       // lblDate.Text = ci.pub_date.ToString();
        
        hlLink.Text = khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + content_type + "/" + content_id + "/";
        hlLink.NavigateUrl  = khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + content_type + "/" + content_id + "/";
        /* set headers important 
        DateTime dt = invoice.orderDate;

        // DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Utc.Id, "Iran Standard Time");
        DateTime dtExp = dt.AddHours(48);
        

        lbl_total_order_and_send_price.Text = invoice.price.ToString();
        lbl_payStatus.Text = khatam.shop.invoiceManager.getStatePay(int.Parse(invoice.payStatus));
        lbl_send_state.Text = khatam.shop.invoiceManager.getStateSend(int.Parse(invoice.sendStatus));

        gv1.DataBind();
        for (int i = 0; i < gv1.Rows.Count; i++)
        {
            gv1.Rows[i].Cells[0].Text = (i + 1).ToString();
        }

        ph_customer.Controls.Add(new LiteralControl(khatam.core.Security.Users.getEmail(invoice.userId.ToString())));
        ph_customer.Controls.Add(new LiteralControl(" "));
        ph_customer.Controls.Add(new LiteralControl(khatam.core.Security.Users.getRealName(invoice.userId.ToString())));



        txt_fish_amount.Attributes.Add("onkeypress", "return isNumberKey(event)");
        txt_year.Attributes.Add("onkeypress", "return isNumberKey(event)");
        txt_month.Attributes.Add("onkeypress", "return isNumberKey(event)");
        txt_day.Attributes.Add("onkeypress", "return isNumberKey(event)");

        if (invoice.payStatus == "2")
        {
            this.Page.Title = "صورتحساب || " + invoice.id.ToString();
            this.lbl_title.Text = "صورتحساب";

            this.selectPayMode.Visible = false;
        }

     */



        ph.Controls.Add(new LiteralControl("<h1>" + ci.title + "</h1>" ));


        ph.Controls.Add(new LiteralControl("<h3>" + ci.description + "</h3>" ));

        string imageUrl, temp2;
        imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + content_type + "/7/" + ci.image;
        temp2 = " <img alt=\"" + ci.title + "\" src=\"" + imageUrl + "\"  />";
        ph.Controls.Add(new LiteralControl(temp2));

        ph.Controls.Add(new LiteralControl("</br>"));

        
        ph.Controls.Add(new LiteralControl(ci.page ));

        lbl_footer.Text = "© " + domainName + ". All Rights Reserved ";
        


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
     
    }
}