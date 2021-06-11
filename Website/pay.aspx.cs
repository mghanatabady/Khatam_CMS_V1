using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using khatam.core.globalization;
using khatam.core.globalization;

public partial class pay : System.Web.UI.Page
{
    khatam.shop.invoiceManager.invoice invoice = new khatam.shop.invoiceManager.invoice();

 

    void checkExp(DateTime dtExp)
    {

        lbl_expire.Text = numbers.GetPersianNumbers(dateTime.GetPersianDateTime(dtExp));
        if (dtExp < DateTime.UtcNow)
        {
            selectPayMode.Visible = false;
            if (khatam.core.data.sql.Sql_Check_identity("idInvoice", invoice.id.ToString(), "state", "0",
                   "core_transaction", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
            {
                MSG_Expire.Visible = true;

            }
            else
            {
                MSG_Expire_FishOntherProcess.Visible = true;
            }
        }


    }

    protected void Page_Load(object sender, EventArgs e)
    {
       
        invoice = khatam.shop.invoiceManager.getInvoiceVirtual(this.Request.QueryString["id"].ToString(), this.Request.QueryString["pass"].ToString(), "1");

        this.Page.Title = "پیش فاکتور || " + invoice.id.ToString();
        this.lbl_title.Text = "پیش فاکتور";
        //imgLogo.Src = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
          //  "Manage/UpLoad/Logo/logo.gif";

        string siteUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath;

        string Logo = khatam.core.data.sql.getBaseSetting("logo", "0");
        string titleSite = khatam.core.data.sql.getBaseSetting("Title", "1");
        string domainName = khatam.core.ConfigurationManager.License.domainsArr[0];
        string tel = khatam.core.data.sql.getBaseSetting("tel", "0");
        string email = khatam.core.data.sql.getBaseSetting("email", "0");
        string cellphone = khatam.core.data.sql.getBaseSetting("cellphone", "0");
        string address = khatam.core.data.sql.getBaseSetting("address", "0");
        string fax = khatam.core.data.sql.getBaseSetting("fax", "0");

        string LogoPathAndFile;

        if (Logo == "")
        {
            LogoPathAndFile = siteUrl + "theme/Flowhub/CssImage/Element/no_photo2.jpg";
        }
        else
        {
            LogoPathAndFile = Logo;
        }
        
        imgLogo.Src = LogoPathAndFile ;
        lblTitle.Text = titleSite + " " + domainName ;

        ph_footer.Controls.Add(new LiteralControl("اطلاعات تماس: "));
        ph_footer.Controls.Add(new LiteralControl(titleSite + " " + domainName));
        if (tel!="")
        {
        ph_footer.Controls.Add(new LiteralControl(" تلفن "));
        ph_footer.Controls.Add(new LiteralControl(tel ));
        }
        if (fax != "")
        {
            ph_footer.Controls.Add(new LiteralControl(" نمابر "));
            ph_footer.Controls.Add(new LiteralControl(fax));
        }
        if (cellphone != "")
        {
            ph_footer.Controls.Add(new LiteralControl(" همراه "));
            ph_footer.Controls.Add(new LiteralControl(cellphone));
        }
        if (email != "")
        {
            ph_footer.Controls.Add(new LiteralControl(" ایمیل "));
            ph_footer.Controls.Add(new LiteralControl(email));
        }
        if (address != "")
        {
            ph_footer.Controls.Add(new LiteralControl(" آدرس "));
            ph_footer.Controls.Add(new LiteralControl(address));
        }







        LblId.Text = Persia.Number.ConvertToPersian(invoice.id.ToString());
        


        if (Page.IsPostBack == false)
        {
            hide_wins();

        }


       
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource4.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource5.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource6.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource7.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
       

        /* set headers important */
        DateTime dt = invoice.orderDate;
      
       // DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dt, TimeZoneInfo.Utc.Id, "Iran Standard Time");
        DateTime dtExp = dt.AddHours(48);
        lblDate.Text =numbers.GetPersianNumbers(dateTime.GetPersianDateTime(dt));
        
        lbl_total_order_and_send_price.Text = invoice.price.ToString();
        lbl_payStatus.Text =khatam.shop.invoiceManager.getStatePay(int.Parse(invoice.payStatus));
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

        if (invoice.payStatus=="2")
        {
            this.Page.Title = "صورتحساب || " + invoice.id.ToString();
            this.lbl_title.Text = "صورتحساب";

            this.selectPayMode.Visible = false;
        }

        switch (invoice.sendMode)
        {
            case 0:
                FillSendMode0();
                if (invoice.payStatus != "2") checkExp(dtExp);
                break;
            
            case 1:
                FillSendMode1();
                if (invoice.payStatus != "2") checkExp(dtExp);
                break;
            case 10:
                FillSendMode10();
                if (invoice.payStatus != "2") checkExp(dtExp);
                break;

            case 2:
                FillSendMode2();                
                break;
            case 3:
                FillSendMode3();
                if (invoice.payStatus != "2") checkExp(dtExp);

                break;
            case 4:
                FillSendMode4();
                if (invoice.payStatus != "2") checkExp(dtExp);

                break;

            default:
                break;
        }




    }

    void FillSendMode0()
    {
        sendinfo.Visible = false;
        this.lbl_total_order_price.Text = invoice.total_order_price.ToString();

    }
    void FillSendMode1()
    {
        lbl_Send_desc.Text = "- هزینه پست";
        div_SendPrice_target.Visible = false;
        FillSendInformation();
    }

    void FillSendMode10()
    {
        lbl_Send_desc.Text = "- هزینه پست";
        div_SendPrice_target.Visible = false;
        FillSendInformation();
    }
    void FillSendMode2()
    {

        FillSendInformation();

        //string iranMcTrackingCode = khatam.core.data.sql.getField( "iranMcTrackingCode", "id"
        //    , invoice.id.ToString(), "core_invoice");
        //KhatamSDRADCORE.info.webimc.www.ShoppingService irmc = new KhatamSDRADCORE.info.webimc.www.ShoppingService();
        //irmc.Credentials = new System.Net.NetworkCredential("mghslam1", "mSlam4050");
        //int Orderstate = irmc.GetState(iranMcTrackingCode);
        //lbl_send_state.Text = khatam.shop.invoiceManager.getStateIranmcMessageByid(Orderstate);
       
        payinfo.Visible = true;
        selectPayMode.Visible = false;
        Panel_saman.Visible = false;
        btn_reg_fish.Visible = false;
        div_transactions.Visible = false;
        div_payStatus.Visible = false;
        div_SendPrice_source.Visible = false;

     //   if (4 == Orderstate)
           // this.Page.Title = "صورتحساب || " + invoice.id.ToString();
    }
    void FillSendMode3()
    {
        lbl_Send_desc.Text = "- هزینه حمل تا ترمینال";
       // div_SendPrice_target.Visible = false;
        FillSendInformation();
        lbl_SendPrice_target.Text = "پس کرایه";
        div_Address.Visible = false;
        lbl_total_order_and_send_price.Text = lbl_total_order_and_send_price.Text + " + پس کرایه ";

    }
    void FillSendMode4()
    {
       // lbl_Send_desc.Text = "- هزینه پست";
     

        FillSendInformation();
        div_SendPrice_source.Visible = false;
        lbl_SendPrice_target.Text = "پس کرایه";
        lbl_total_order_and_send_price.Text = lbl_total_order_and_send_price.Text + " + پس کرایه ";
    }

    void FillSendInformation()
    {
        lbl_senmode_title.Text = khatam.core.data.sql.getField("title", "id", invoice.sendMode.ToString(), "core_sendMode");

        lbl_country.Text =khatam.core.globalization.country.getCountryTitle( invoice.country_id.ToString(),"1");
        lbl_state.Text = khatam.core.globalization.state.getStateTitle(invoice.state_id.ToString(), "1");
        lbl_city.Text = khatam.core.globalization.city.getCityTitle(invoice.city_id.ToString(), "1");

        //lbl_state.Text = invoice.state_id.ToString();
        //lbl_city.Text = invoice.city_id.ToString();

        lbl_Address.Text = invoice.Transferee_Address;
        this.lbl_zipCode.Text = invoice.Transferee_ZipCode;
        lbl_tel.Text = invoice.Transferee_Tel;
        lbl_cellPhone.Text = invoice.Transferee_CellPhone;
        this.lbl_msg.Text = invoice.message;

        this.lbl_SendPrice_source.Text=invoice.price_send_source.ToString();
        this.lbl_SendPrice_target.Text=invoice.price_send_Target.ToString();

        this.lbl_total_order_price.Text = invoice.total_order_price.ToString();

             
             //###show msg          public bool have_cargo_rent_in_Target;

                      


     
    }





    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        hide_wins();


        if (DropDownList1.SelectedValue == "0")
        {
            hide_wins();
        }

        if (DropDownList1.SelectedValue == "3")
        {
            // Button1.Visible = false;
            Panel_saman.Visible = false;
            panelFish.Visible = true;
        }
        if (DropDownList1.SelectedValue == "1")

        {
            sendToSaman.Visible = true;

            // Button1.Visible = true ;
            Panel_saman.Visible = true;
            panelFish.Visible = false;
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Amount"] = invoice.price  ;
        Session["rscode"] = invoice.id;
        //?id=87&pass=Q8W0
        RedirectTo("SendToSaman.aspx?id=" + this.Request.QueryString["id"] + "&pass=" + this.Request.QueryString["pass"]);
    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void btn_reg_fish_Click(object sender, EventArgs e)
    {
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("idPayMode");
        b.Add("3");

        a.Add("idInvoice");
        b.Add(invoice.id);

        a.Add("idCoreBankAccounts");
        b.Add(ddl_accounts.SelectedValue);

        a.Add("accontsDesc");
        b.Add(ddl_accounts.SelectedItem.Text);

        a.Add("fishNo");
        b.Add(txt_fish_no.Text);

        a.Add("amount");
        b.Add(this.txt_fish_amount.Text);


        a.Add("regDate");
        b.Add(DateTime.UtcNow.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));

        a.Add("state");
        b.Add(0);



        //DateTime date_source;
        //date_source =DateTime.Parse( txt_year.Text + " / " + txt_month.Text + " / " + tex);



        // (DateTime.Parse(this.PersianDateTextBox.Text)).Year,
        //   ((DateTime.Parse(this.PersianDateTextBox.Text)).Month,
        //   ((DateTime.Parse(this.PersianDateTextBox.Text)).Day, Persia.DateType.Persian);
        DateTime date_event;
        date_event = Persia.Calendar.ConvertToGregorian(int.Parse(txt_year.Text), int.Parse(txt_month.Text),
        int.Parse(txt_day.Text), Persia.DateType.Persian);
        //Label1.Text = "fff" + date_event.ToString();

        a.Add("FishDateTime");
        b.Add(date_event.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));
        //date_event.ToString("yyyy/MM/dd HHHH:mmmm:ssss")


        khatam.core.data.sql.Add(a, b, "core_transaction");

        gv_fish.DataBind();
        hide_wins();
        MSG_fish_ok.Visible = true;

    }
    protected void gv1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void hide_wins()
    {
        sendToSaman.Visible = false;
        Panel_saman.Visible = false;
        panelFish.Visible = false;
        MSG_fish_ok.Visible = false;
    }

    protected void gv_fish_bound(object sender, EventArgs e)
    {
        for (int i = 0; i < gv_fish.Rows.Count; i++)
        {
            gv_fish.Rows[i].Cells[3].Text =dateTime.GetPersianDate(DateTime.Parse(gv_fish.Rows[i].Cells[3].Text));

            gv_fish.Rows[i].Cells[5].Text = khatam.shop.invoiceManager.getStateTransaction_Fish(int.Parse(gv_fish.Rows[i].Cells[5].Text));
        }

    }

    protected void gv_sbt_bound(object sender, EventArgs e)
    {
        for (int i = 0; i < gv_sbt.Rows.Count; i++)
        {
            gv_sbt.Rows[i].Cells[3].Text =dateTime.GetPersianDateTime(DateTime.Parse(gv_sbt.Rows[i].Cells[3].Text));


            if (gv_sbt.Rows[i].Cells[4].Text != "")
            {
                try
                {
                    gv_sbt.Rows[i].Cells[4].Text = dateTime.GetPersianDateTime(DateTime.Parse(gv_sbt.Rows[i].Cells[4].Text));
                }
                catch (Exception)
                {
                    
                   
                }
               

            }
            if (gv_sbt.Rows[i].Cells[2].Text != "")
            {
                if (gv_sbt.Rows[i].Cells[2].Text == "1")
                    gv_sbt.Rows[i].Cells[2].Text = "موفق";

                if (gv_sbt.Rows[i].Cells[2].Text == "2")
                    gv_sbt.Rows[i].Cells[2].Text = "ناموفق";

            }
            // gv_fish.Rows[i].Cells[5].Text = getStateTransaction_Fish(int.Parse(gv_fish.Rows[i].Cells[5].Text));
        }

    }
}