using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using khatam.shop;
public partial class c_shopcart : System.Web.UI.UserControl
{

   

    protected void Page_Load(object sender, EventArgs e)
    {
       
        //{*********[Add Controls]*****
        khatam.core.UI.WebControls.loginWin lw = new khatam.core.UI.WebControls.loginWin();
        lw.LoginValidUserOnly = false;
        lw.LoggedIn += new EventHandler(logged);
        lw.showStyled = true;
        Ph_login.Controls.Add(lw);
        
        khatam.core.UI.WebControls.membrshipWin mw = new khatam.core.UI.WebControls.membrshipWin();
        mw.oncreateduser += new EventHandler(oncreateduser);        
        Ph_login.Controls.Add(mw);
        //**********[Add Controls]*****}
        
        if (Page.IsPostBack == false)
        {
            hideTabs();
            gv_bindData();
            checkShopCartEmpty();
           

            tab1.Visible = true;
            LinkButton1.Font.Bold = true;

            if (khatam.core.Security.Users.login() > 0)
            {
                LinkButton2.Font.Strikeout = true;
            }                   
        }
        
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        
    }

    void checkShopCartEmpty()
    {
        if (gv1.Rows.Count > 0)
        {
         
                Button1.Visible = true;

                div_msg_session.Visible = true;

                if (khatam.core.Security.Users.login() > 0)
            {
             

               // LinkButton3.Enabled = true;
               // LinkButton3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            }
            else
            {
               // LinkButton3.Enabled = false;
               // LinkButton3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
               // LinkButton4.Enabled = false;
               // LinkButton4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
              //  LinkButton5.Enabled = false;
              //  LinkButton5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
              //  LinkButton6.Enabled = false;
              //  LinkButton6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");

            }
        }
        else
        {
            Button1.Visible = false;

            div_msg_session.Visible = false;

            LinkButton2.Enabled = false;
            LinkButton2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
            LinkButton3.Enabled = false;
            LinkButton3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
            LinkButton4.Enabled = false;
            LinkButton4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
            LinkButton5.Enabled = false;
            LinkButton5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
            LinkButton6.Enabled = false;
            LinkButton6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7D7D7D");
        }
    }

    

    public void logged(object sender, EventArgs e)
    {
        //this.Response.Redirect("http://www.google.com");


        if (lbl_totalPrice_phisical.Text.ToString() == "0")
        {
            hideTabs();
            tab6.Visible = true;
            LinkButton6.Font.Bold = true;
            FinalOk_Gen();
        }
        else
        {
            hideTabs();
            tab3.Visible = true;
            LinkButton3.Font.Bold = true;
        }



    }



    public void oncreateduser(object sender, EventArgs e)
    {
        if (lbl_totalPrice_phisical.Text.ToString() == "0")
        {
            hideTabs();
            tab6.Visible = true;
            LinkButton6.Font.Bold = true;
            FinalOk_Gen();
        }
        else
        {
            hideTabs();
            tab3.Visible = true;
            LinkButton3.Font.Bold = true;
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

            DataSet ds = new DataSet();
            ds = (DataSet)HttpContext.Current.Session["ds"];
          
            
            TextBox scshtxt = new TextBox();
            scshtxt = (TextBox) this.gv1.Rows[gv1.SelectedIndex].Cells[7].FindControl("TextBox1");
           // If (scshtxt.Text = Nothing) Or (Int(scshtxt.Text) < 1) Then scshtxt.Text = 1;
            //ds.Tables[0].Rows[gv1.SelectedIndex].ItemArray[3] = scshtxt.Text;

            ds.Tables[0].Rows[1].ItemArray[3] = "33";

            HttpContext.Current.Session["ds"] = ds;
            gv_bindData();

      //    Dim ds As New DataSet()
      //  ds = Me.Session("ds")
      //  Dim i As Integer
     //   For i = 0 To dg1.Items.Count - 1
       //     Dim scshtxt As New TextBox
        
       // Next i
      //  Me.Session("ds") = ds
      //Me.Response.Redirect("shopcart.aspx")
        
        //  this.dg1.Columns[8].Visible = true;
       // this.dg1.Columns[7].Visible = false;
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        this.Page.Title = "ok";
            //  this.dg1.Columns[8].Visible = true;
      //  this.dg1.Columns[7].Visible = false;
    }

    private void grid_ItemCommand(object sender, GridViewCommandEventArgs e)
  {
   /*  if(e.CommandName == "Select")
     {
        dg1.SelectedIndex = e.Item.ItemIndex;

        }*/

  }

    protected void Button4_Click(object sender, EventArgs e)
    {
        
       

        
    }
    protected void btn_login_Click(object sender, EventArgs e)
    {

    }
    protected void btn_pay_Click(object sender, EventArgs e)
    {

    }




        


  

    public void gv_bindData()
    {
        DataSet ds = new DataSet();

       // dg1.ID = "dg1";



        //  dg1.DataSource = khatam.core.data.sql.getTable("users");

        //       if (! this.Page.IsPostBack )
        //     {
        ds = (DataSet)HttpContext.Current.Session["ds"];

        gv1.DataSource = ds;
        gv1_mirror.DataSource = ds;
     //   dg1.AutoGenerateColumns = false;
      
        gv1.DataBind();
        gv1_mirror.DataBind();

        for (int i = 0; i < gv1.Rows.Count; i++)
        {
          //  ds = (DataSet)this.Session["ds"];
          //  TextBox scshtxt = new TextBox();
          //  scshtxt = (TextBox)this.dg1.Items[i].Cells[7].FindControl("TextBox1");
          //  scshtxt.Text = ds.Tables[0].Rows[i].ItemArray[3].ToString();

            this.gv1.Rows[i].Cells[6].Visible = false;
            this.gv1.Rows[i].Cells[7].Visible = false;

            //this.gv1.Rows[i].Cells[6].ColumnSpan=2;

            this.gv1.Rows[i].Cells[8].ColumnSpan = 3;

            this.gv1.Rows[i].Cells[0].Text = (i +1).ToString() ;
            this.gv1_mirror.Rows[i].Cells[0].Text = (i + 1).ToString();
            
            //this.dg1.Items[i].Cells[8].Visible = false;


        }


       



        //dg1.DataBind();
        //          }



        //dg1.DataKeyNames = new string[] { "productcode" };
        
     /*  int sumPh=0;
        int sum=0;
       for (int i = 0; i < gv1.Rows.Count ; i++)
			{
                sum = int.Parse(gv1.Rows[i].Cells[5].Text) + sum;
//if (
          //      sum = int.Parse(ds. .Rows[i].Cells[5].Text) + sum;

			}
       lbl_totalPrice.Text= sum.ToString();*/
        //Hidden_lbl_totalPricePhisical


       if (ds != null)
       {
           int totalWeight = 0;
           int totalPrice = 0;
           int totalPricePhisical = 0;
           int totalPriceVirtual = 0;

           for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
           {
               totalWeight = int.Parse(ds.Tables[0].Rows[j].ItemArray[8].ToString()) + totalWeight;
               totalPrice = int.Parse(ds.Tables[0].Rows[j].ItemArray[5].ToString()) + totalPrice;

               if (bool.Parse(ds.Tables[0].Rows[j].ItemArray[10].ToString()) ==false)               
               totalPricePhisical = int.Parse(ds.Tables[0].Rows[j].ItemArray[5].ToString()) + totalPricePhisical;
               else
               totalPriceVirtual = int.Parse(ds.Tables[0].Rows[j].ItemArray[5].ToString()) + totalPriceVirtual;


               
           }
           lbl_totalweight.Text =  totalWeight.ToString();
           lbl_totalPrice.Text = totalPrice.ToString();
           lbl_totalPrice_phisical.Text = totalPricePhisical.ToString();
           lbl_totalPrice_virtual.Text = totalPriceVirtual.ToString();
           
           if (totalWeight == 0) div_totalweight.Visible = false;
           
       }


       if (lbl_totalPrice_phisical.Text.ToString() == "0") 
       {
           LinkButton3.Font.Strikeout = true;
           LinkButton4.Font.Strikeout = true;
           LinkButton5.Font.Strikeout = true;


       }
      

      // sendMode_iranmc = false;
        //   dg1.EditIndex = 0;




    }

    protected void gv1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void gv1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e  )
    {
        gv1.SelectedIndex =int.Parse( e.CommandArgument.ToString());

        

        if (e.CommandName == "quantity")
        {
            this.Page.Title = e.CommandArgument.ToString() + "quantity";

            TextBox scshtxt = new TextBox();
            scshtxt = (TextBox)this.gv1.Rows[gv1.SelectedIndex].Cells[7].FindControl("TextBox1");
            scshtxt.Text = gv1.Rows[gv1.SelectedIndex].Cells[3].Text;


            gv1.Rows[gv1.SelectedIndex].Cells[7].Visible=true;
   
            gv1.Rows[gv1.SelectedIndex].Cells[6].Visible = false;

            gv1.Rows[gv1.SelectedIndex].Cells[7].ColumnSpan=2;
      
        }

        if (e.CommandName == "del")
        {
            //this.Page.Title = e.CommandArgument.ToString() + "del";
            DataSet ds = new DataSet();
            ds = (DataSet)HttpContext.Current.Session["ds"];
            ds.Tables[0].Rows[gv1.SelectedIndex].Delete();
            HttpContext.Current.Session["ds"] = ds;

            gv_bindData();

            checkShopCartEmpty();
        }

       // If e.CommandName = "student_del" Then
       //     Me.Response.Redirect("~/manage/?mode=school_student_del&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
       // End If
       // If e.CommandName = "student_account" Then
        //    Me.Response.Redirect("~/manage/?mode=school_student_account_list&id=" + Me.GridView1.SelectedRow.Cells(0).Text)
       // End If
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        hideTabs();
        checkShopCartEmpty();

        tab1.Visible = true;
        LinkButton1.Font.Bold=true;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        hideTabs();
        if ((khatam.core.Security.Users.login() > 0) || (Session["id_user"] != null))
        {

            if (lbl_totalPrice_phisical.Text.ToString() == "0")
            {
                tab6.Visible = true;
                LinkButton6.Font.Bold = true;
                FinalOk_Gen();
            }
            else
            {
                tab3.Visible = true;
                LinkButton3.Font.Bold = true;
            }
        }
        else
        {

            tab2.Visible = true;
            LinkButton2.Font.Bold = true;
        }
       
       

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab4.Visible = true;
        LinkButton4.Font.Bold = true;

        //KhatamSDRADCORE.info.webimc.www.ShoppingService irmc = new KhatamSDRADCORE.info.webimc.www.ShoppingService();
        //irmc.Credentials = new System.Net.NetworkCredential("mghslam1", "mSlam4050");
        string stateMcid;
        string cityMcid;
        //stateMcid = khatam.core.data.sql.getField("btn_link3 shop cart", "iran_mc_code", "country_state_id", this.ddl_state.SelectedValue, "core_country_state");
        //cityMcid = khatam.core.data.sql.getField("btn_link3 shop cart", "iran_mc_code", "country_state_city_id", this.ddl_city.SelectedValue, "core_country_state_city");
        //string result = irmc.GetSendPrice(lbl_totalPrice.Text, this.lbl_totalweight.Text, int.Parse(stateMcid), int.Parse(cityMcid), 0);


        ///lbl_sendmode1.Text = result;
        //lbl_sendmode2.Text =(int.Parse(result) + 5000).ToString();

        

        //if ( (int.Parse(lbl_totalPrice_virtual.Text) > 0)|| (int.Parse(lbl_totalPrice.Text) > int.Parse(Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("iranmcMaxOrderPrice",0,khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))))
        //{
        lbl_sendmode1.Text = khatam.shop.shopCart.getPostPishtazPrice(
            int.Parse(lbl_totalweight.Text),ddl_country.SelectedValue, ddl_state.SelectedValue, ddl_city.SelectedValue);

        lbl_sendmode10.Text = khatam.shop.shopCart.getPostSefareshiPrice(
    int.Parse(lbl_totalweight.Text), ddl_country.SelectedValue, ddl_state.SelectedValue, ddl_city.SelectedValue);

        selectSendMode2.Visible = false;       


        //}
        //else
       // {
            
        selectSendMode3.Visible = false;
        selectSendMode4.Visible = false;
       // }

        //if (int.Parse(khatam.shop.shopCart.checkSendModeGeoSupport("", "4", ddl_country.SelectedValue,

        if (int.Parse(khatam.shop.shopCart.checkSendModeGeoSupport("none", "3", ddl_country.SelectedValue, ddl_state.SelectedValue, ddl_city.SelectedValue).ToString()) > 0)
        {
         int price_send2_unit   =
         int.Parse(  Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("sendmode2_by_agent_per502kg", 0,
         khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));

            lbl_sendmode3_by_agent.Text = (khatam.core.Math.DivideRoundUp(int.Parse(lbl_totalweight.Text) , 50000) * price_send2_unit).ToString();
            selectSendMode3.Visible = true;
        }


        if (int.Parse(khatam.shop.shopCart.checkSendModeGeoSupport("none", "4", ddl_country.SelectedValue,ddl_state.SelectedValue, ddl_city.SelectedValue).ToString()) > 0)
        {
            selectSendMode4.Visible = true;
        }

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab4.Visible = true;
        LinkButton4.Font.Bold = true;
    }

   

    void hideTabs()
    {
       

        tab1.Visible = false;
        tab2.Visible = false;
        tab3.Visible = false;
        tab4.Visible = false;
        tab5.Visible = false;
        tab6.Visible = false;

       

        LinkButton1.Font.Bold = false;
        LinkButton2.Font.Bold = false;
        LinkButton3.Font.Bold = false;
        LinkButton4.Font.Bold = false;
        LinkButton5.Font.Bold = false;
        LinkButton6.Font.Bold = false;
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    Panel sendMode_selectCountry_pl = new Panel();
    Panel sendMode_selectSendMode_pl = new Panel();
    Panel sendMode_inputAdrress_pl = new Panel();


    DropDownList sendMode_ddl_Country = new DropDownList();
    DropDownList sendMode_ddl_Country_state = new DropDownList();
    DropDownList sendMode_ddl_Country_state_city = new DropDownList();
    DropDownList sendMode_ddl_Country_state_city_area = new DropDownList();
    void generate_sendMode_selectCountry_pl()
    {
        string html = "<div id=\"stylized\" class=\"myform\">"
            //+ " <form id=\"form\" name=\"form\" method=\"post\" action=\"index.html\">"
+ " <h1>اطلاعات محدوده جغرافیایی</h1>"
+ " <p>لطفا محدوده جغرافیایی محل تحویل سفارش را به دقت انتخاب نمایید:</p>";
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(html));

        DataTable dt = new DataTable();
        dt = khatam.core.globalization.country.getCountryList();
        DataRow row = dt.NewRow();
        row["country_title"] = "لطفا یک کشور را انتخاب کنید";
        row["country_id"] = "11";

        dt.Rows.Add(row);
        dt.AcceptChanges();



        sendMode_ddl_Country.DataSource = dt;


        sendMode_ddl_Country.ID = "gv_country";
        sendMode_ddl_Country.ClientIDMode = System.Web.UI.ClientIDMode.Static;
        sendMode_ddl_Country.SelectedValue = "104";
        sendMode_ddl_Country.DataTextField = "country_title";
        sendMode_ddl_Country.DataValueField = "country_id";
        sendMode_ddl_Country.AutoPostBack = true;
        //sendMode_ddl_Country.SelectedIndexChanged += new EventHandler(sendMode_ddl_Country_changed);
        sendMode_ddl_Country.DataBind();

        sendMode_ddl_Country.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>کشور<span class=\"small\">کشوری مقصد مرسوله</span></label>"));





        sendMode_ddl_Country_state.DataSource = khatam.core.globalization.country.getCountryList();
        sendMode_ddl_Country_state.DataTextField = "country_title";
        sendMode_ddl_Country_state.DataValueField = "country_id";

        sendMode_ddl_Country_state.DataBind();

        sendMode_ddl_Country_state.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country_state);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>استان / ایالت<span class=\"small\">استان مقصد مرسوله</span></label>"));




        sendMode_ddl_Country_state_city.DataSource = khatam.core.globalization.country.getCountryList();
        sendMode_ddl_Country_state_city.DataTextField = "country_title";
        sendMode_ddl_Country_state_city.DataValueField = "country_id";
        sendMode_ddl_Country_state_city.DataBind();

        sendMode_ddl_Country_state_city.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country_state_city);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>شهر / شهرستان<span class=\"small\">شهر / شهرستان مقصد مرسوله</span></label>"));



        sendMode_ddl_Country_state_city_area.DataSource = khatam.core.globalization.country.getCountryList();
        sendMode_ddl_Country_state_city_area.DataTextField = "country_title";
        sendMode_ddl_Country_state_city_area.DataValueField = "country_id";
        sendMode_ddl_Country_state_city_area.DataBind();

        sendMode_ddl_Country_state_city_area.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country_state_city_area);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>منطقه / بخش<span class=\"small\">منطقه / بخش مقصد مرسوله</span></label>"));



        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<br />"));
        Button sendModeBtn = new Button();
        sendModeBtn.Text = "جستجوی شیوه های ارسال";
        sendModeBtn.Font.Name = "tahoma";
        sendModeBtn.CssClass = "btnSS";
        sendModeBtn.Width = 200;
        sendModeBtn.Height = 31;
        //## btnlogin.Click += new EventHandler(btnlogin_Click);
        sendMode_selectCountry_pl.Controls.Add(sendModeBtn);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        /******************/
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <div ><b> لطفا یکی از شیوه های ارسال سفارش را انتخاب کنید: </b>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        DropDownList ddl = new DropDownList();
        /******************/


        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("</div>"));

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));


        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<b>آدرس محل تحویل:</b>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        TextBox tb = new TextBox();
        tb.Width = Unit.Pixel(389);
        tb.TextMode = TextBoxMode.MultiLine;
        sendMode_selectCountry_pl.Controls.Add(tb);

        /******************/
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<div style=\"width:389px\">"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<b>پیام:</b>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        TextBox tbMessage2 = new TextBox();
        tbMessage2.Width = Unit.Pixel(389);
        tbMessage2.TextMode = TextBoxMode.MultiLine;
        sendMode_selectCountry_pl.Controls.Add(tbMessage2);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("</div>"));

        /******************/

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));


        TextBox tbPostCode = new TextBox();
        tbPostCode.Width = Unit.Pixel(200);
        sendMode_selectCountry_pl.Controls.Add(tbPostCode);
        tbPostCode.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>کدپستی<span class=\"small\">کد پستی محل تحویل</span></label>"));



        /******************/


        TextBox tbTel = new TextBox();
        tbTel.Width = Unit.Pixel(200);
        tbTel.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(tbTel);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>تلفن<span class=\"small\">تلفن ثابت تحویل گیرنده</span></label>"));



        /******************/



        TextBox tbMob = new TextBox();
        tbMob.Width = Unit.Pixel(200);
        tbMob.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(tbMob);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>موبایل<span class=\"small\">موبایل تحویل گیرنده</span></label>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));




        /******************/
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<br />"));
        Button btnSendMakeOrder = new Button();
        btnSendMakeOrder.Text = "تایید";
        btnSendMakeOrder.Font.Name = "tahoma";
        btnSendMakeOrder.CssClass = "btnSS";
        btnSendMakeOrder.Width = 100;
        btnSendMakeOrder.Height = 31;
        //## btnlogin.Click += new EventHandler(btnlogin_Click);
        sendMode_selectCountry_pl.Controls.Add(btnSendMakeOrder);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));


        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <div class=\"spacer\"></div>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("</div>"));




    }

    void generate_sendMode_selectSendMode_pl()
    {
        string html = "<div id=\"stylized\" class=\"myform\">"
            //+ " <form id=\"form\" name=\"form\" method=\"post\" action=\"index.html\">"
+ " <h1>شیوه های ارسال سفارش</h1>"
+ " <p>لطفا فرم ذیل را با دقت کامل نمایید:</p>";
        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(html));

        DataTable dt = new DataTable();
        dt = khatam.core.globalization.country.getCountryList();
        DataRow row = dt.NewRow();
        row["country_title"] = "لطفا یک کشور را انتخاب کنید";
        row["country_id"] = "11";

        dt.Rows.Add(row);
        dt.AcceptChanges();



        string htmlRow1 = "<div id=\"selectSendMode\" style=\"width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden\" >"
+ " "
+ " <div class=\"icon\"  >"
+ " <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/sendMode/pishtaz.jpg\" />"
+ " "
+ " </div>"
+ "<div class=\"memo\" >"
+ "<strong>ترمینال اتوبوس رانی</strong><br />"
+ "هزینه ارسال با اتوبوس پس کرایه می گردد"
+ " و فقط 10 هزار تومان برای ارسال به ترمینال دریافت می گردد"
+ " "
+ " </div>"
+ "<div style=\" float:right\" >";
        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(htmlRow1));

        Button btn = new Button();
        btn.Text = "انتخاب";
        btn.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn);

        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl("</div></div>"));

        //222222222
        string htmlRow2 = "<div  id=\"selectSendMode\"  style=\"width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden\" >"
+ " "
+ " <div  class=\"icon\"  >"
+ " <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/sendMode/iranmc.jpg\" />"
+ " "
+ " </div>"
+ "<div class=\"memo\" >"
+ "<strong>ترمینال اتوبوس رانی</strong><br />"
+ "هزینه ارسال با اتوبوس پس کرایه می گردد"
+ " و فقط 10 هزار تومان برای ارسال به ترمینال دریافت می گردد"
+ " "
+ " </div>"
+ "<div style=\" float:right\" >";
        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(htmlRow2));

        //KhatamSDRADCORE.info.webimc.www.ShoppingService irmc = new KhatamSDRADCORE.info.webimc.www.ShoppingService();

        //irmc.Credentials = new System.Net.NetworkCredential("mghslam1", "mSlam4050");

        //string result = irmc.GetSendPrice("30000000", "200", 51, 8, 0);

      //  sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(result));

        Button btn2 = new Button();
        btn2.Text = "انتخاب";
        btn2.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn2);

        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl("</div></div>"));


        //333333333
        string htmlRow3 = "<div  id=\"selectSendMode\"  style=\"width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden\" >"
+ " "
+ " <div  class=\"icon\"  >"
+ " <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/sendMode/bus.jpg\" />"
+ " "
+ " </div>"
+ "<div class=\"memo\" >"
+ "<strong>ترمینال اتوبوس رانی</strong><br />"
+ "هزینه ارسال با اتوبوس پس کرایه می گردد"
+ " و فقط 10 هزار تومان برای ارسال به ترمینال دریافت می گردد"
+ " "
+ " </div>"
+ "<div style=\" float:right\" >";
        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(htmlRow3));

        Button btn3 = new Button();
        btn3.Text = "انتخاب";
        btn3.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn3);

        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl("</div></div>"));


        //4444444
        string htmlRow5 = "<div  id=\"selectSendMode\"  style=\"width: 380px; margin-bottom:10px; border:1px solid #aacfe4 ; background-color:White ; overflow:hidden\" >"
        + " <div  class=\"icon\"  >"
        + " <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/sendMode/car.jpg\" />"
        + " </div>"
        + "<div class=\"memo\" >"
        + "<strong>ترمینال اتوبوس رانی</strong><br />"
        + "هزینه ارسال با اتوبوس پس کرایه می گردد"
        + " و فقط 10 هزار تومان برای ارسال به ترمینال دریافت می گردد"
        + " </div>"
        + "<div style=\" float:right\" >";
        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(htmlRow5));

        Button btn5 = new Button();
        btn5.Text = "انتخاب";
        btn5.CssClass = "btnSelect";
        sendMode_selectSendMode_pl.Controls.Add(btn5);

        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl("</div></div>"));

        /////////////


        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(" <div class=\"spacer\"></div>"));
        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl("</div>"));




    }

    void generate_sendMode_inputAdrress_pl()
    {
        string html = "<div id=\"stylized\" class=\"myform\">"
            //+ " <form id=\"form\" name=\"form\" method=\"post\" action=\"index.html\">"
+ " <h1>اطلاعات ارسال سفارش</h1>"
+ " <p>لطفا فرم ذیل را با دقت کامل نمایید:</p>";
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(html));

        DataTable dt = new DataTable();
        dt = khatam.core.globalization.country.getCountryList();
        DataRow row = dt.NewRow();
        row["country_title"] = "لطفا یک کشور را انتخاب کنید";
        row["country_id"] = "11";

        dt.Rows.Add(row);
        dt.AcceptChanges();



        sendMode_ddl_Country.DataSource = dt;


        sendMode_ddl_Country.ID = "gv_country";
        sendMode_ddl_Country.ClientIDMode = System.Web.UI.ClientIDMode.Static;
        sendMode_ddl_Country.SelectedValue = "104";
        sendMode_ddl_Country.DataTextField = "country_title";
        sendMode_ddl_Country.DataValueField = "country_id";
        sendMode_ddl_Country.AutoPostBack = true;
       // sendMode_ddl_Country.SelectedIndexChanged += new EventHandler(sendMode_ddl_Country_changed);
        sendMode_ddl_Country.DataBind();

        sendMode_ddl_Country.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>کشور<span class=\"small\">کشوری مقصد مرسوله</span></label>"));





        sendMode_ddl_Country_state.DataSource = khatam.core.globalization.country.getCountryList();
        sendMode_ddl_Country_state.DataTextField = "country_title";
        sendMode_ddl_Country_state.DataValueField = "country_id";

        sendMode_ddl_Country_state.DataBind();

        sendMode_ddl_Country_state.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country_state);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>استان / ایالت<span class=\"small\">استان مقصد مرسوله</span></label>"));




        sendMode_ddl_Country_state_city.DataSource = khatam.core.globalization.country.getCountryList();
        sendMode_ddl_Country_state_city.DataTextField = "country_title";
        sendMode_ddl_Country_state_city.DataValueField = "country_id";
        sendMode_ddl_Country_state_city.DataBind();

        sendMode_ddl_Country_state_city.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country_state_city);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>شهر / شهرستان<span class=\"small\">شهر / شهرستان مقصد مرسوله</span></label>"));



        sendMode_ddl_Country_state_city_area.DataSource = khatam.core.globalization.country.getCountryList();
        sendMode_ddl_Country_state_city_area.DataTextField = "country_title";
        sendMode_ddl_Country_state_city_area.DataValueField = "country_id";
        sendMode_ddl_Country_state_city_area.DataBind();

        sendMode_ddl_Country_state_city_area.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(sendMode_ddl_Country_state_city_area);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>منطقه / بخش<span class=\"small\">منطقه / بخش مقصد مرسوله</span></label>"));



        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<br />"));
        Button sendModeBtn = new Button();
        sendModeBtn.Text = "جستجوی شیوه های ارسال";
        sendModeBtn.Font.Name = "tahoma";
        sendModeBtn.CssClass = "btnSS";
        sendModeBtn.Width = 200;
        sendModeBtn.Height = 31;
        //## btnlogin.Click += new EventHandler(btnlogin_Click);
        sendMode_selectCountry_pl.Controls.Add(sendModeBtn);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        /******************/
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <div ><b> لطفا یکی از شیوه های ارسال سفارش را انتخاب کنید: </b>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        DropDownList ddl = new DropDownList();
        /******************/


        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("</div>"));

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));


        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<b>آدرس محل تحویل:</b>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        TextBox tb = new TextBox();
        tb.Width = Unit.Pixel(389);
        tb.TextMode = TextBoxMode.MultiLine;
        sendMode_selectCountry_pl.Controls.Add(tb);

        /******************/
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<div style=\"width:389px\">"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<b>پیام:</b>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));

        TextBox tbMessage2 = new TextBox();
        tbMessage2.Width = Unit.Pixel(389);
        tbMessage2.TextMode = TextBoxMode.MultiLine;
        sendMode_selectCountry_pl.Controls.Add(tbMessage2);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("</div>"));

        /******************/

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));


        TextBox tbPostCode = new TextBox();
        tbPostCode.Width = Unit.Pixel(200);
        sendMode_selectCountry_pl.Controls.Add(tbPostCode);
        tbPostCode.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>کدپستی<span class=\"small\">کد پستی محل تحویل</span></label>"));



        /******************/


        TextBox tbTel = new TextBox();
        tbTel.Width = Unit.Pixel(200);
        tbTel.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(tbTel);

        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>تلفن<span class=\"small\">تلفن ثابت تحویل گیرنده</span></label>"));



        /******************/



        TextBox tbMob = new TextBox();
        tbMob.Width = Unit.Pixel(200);
        tbMob.CssClass = "input";
        sendMode_selectCountry_pl.Controls.Add(tbMob);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<label>موبایل<span class=\"small\">موبایل تحویل گیرنده</span></label>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));




        /******************/
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("<br />"));
        Button btnSendMakeOrder = new Button();
        btnSendMakeOrder.Text = "تایید";
        btnSendMakeOrder.Font.Name = "tahoma";
        btnSendMakeOrder.CssClass = "btnSS";
        btnSendMakeOrder.Width = 100;
        btnSendMakeOrder.Height = 31;
        //## btnlogin.Click += new EventHandler(btnlogin_Click);
        sendMode_selectCountry_pl.Controls.Add(btnSendMakeOrder);
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <br />"));


        sendMode_selectCountry_pl.Controls.Add(new LiteralControl(" <div class=\"spacer\"></div>"));
        sendMode_selectCountry_pl.Controls.Add(new LiteralControl("</div>"));




    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {

    }
    protected void btnSendMode1_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab5.Visible = true;
        LinkButton5.Font.Bold = true;
        ViewState["sendMode"] = 1;
    }
    protected void btnSendMode2_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab5.Visible = true;
        LinkButton5.Font.Bold = true;
        ViewState["sendMode"] = 2;
    }
    protected void btnSendMode3_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab5.Visible = true;
        LinkButton5.Font.Bold = true;
        div_Address.Visible = false;
        ViewState["sendMode"] = 3;
    }
  
    protected void btnSendMode4_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab5.Visible = true;
        LinkButton5.Font.Bold = true;
        ViewState["sendMode"] = 4;
    }

    protected void Button4_Click1(object sender, EventArgs e)
    {

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab6.Visible = true;
        LinkButton6.Font.Bold = true;

        FinalOk_Gen();


        //##div_mirror_Address

    }

    void FinalOk_Gen()
    {
        if (lbl_totalPrice_phisical.Text == "0")
        {
            lbl_total_order_and_send_price.Text = lbl_totalPrice.Text;
            rows_finalOk_physical.Visible = false;
            ViewState["sendMode"] = "0";
        }
        else
        {

            lbl_Miror_totalPrice.Text = lbl_totalPrice.Text;
            lbl_Miror_totalWeight.Text = lbl_totalweight.Text;

            lbl_mirror_country.Text = ddl_country.SelectedItem.Text;
            lbl_mirror_state.Text = ddl_state.SelectedItem.Text;
            lbl_mirror_city.Text = ddl_city.SelectedItem.Text;


            switch (ViewState["sendMode"].ToString())
            {
                case "1":
                    lbl_mirror_sendmode2_by_agent.Text = this.lbl_sendmode1.Text + " ریال";
                    lbl_total_order_and_send_price.Text = (int.Parse(this.lbl_sendmode1.Text) + int.Parse(lbl_totalPrice.Text)).ToString() + " ریال ";
                    break;
                case "10":
                    lbl_mirror_sendmode2_by_agent.Text = this.lbl_sendmode10.Text + " ریال";
                    lbl_total_order_and_send_price.Text = (int.Parse(this.lbl_sendmode10.Text) + int.Parse(lbl_totalPrice.Text)).ToString() + " ریال ";
                    break;

                case "2":
                    lbl_mirror_sendmode2_by_agent.Text = this.lbl_sendmode2.Text + " ریال";
                    lbl_total_order_and_send_price.Text = (int.Parse(this.lbl_sendmode2.Text) + int.Parse(lbl_totalPrice.Text)).ToString() + " ریال ";
                    break;
                case "3":

                    lbl_mirror_sendmode2_by_agent.Text = "پس کرایه + هزینه حمل تا ترمینال : " + lbl_sendmode3_by_agent.Text + " ریال";
                    lbl_total_order_and_send_price.Text = (int.Parse(lbl_sendmode3_by_agent.Text) + int.Parse(lbl_totalPrice.Text)).ToString() + " ریال " + "+ پس کرایه";
                    break;
                case "4":
                    lbl_mirror_sendmode2_by_agent.Text = "پس کرایه :";
                    lbl_total_order_and_send_price.Text = lbl_totalPrice.Text + " + پس کرایه";

                    break;
                default:
                    break;
            }



            lbl_mirror_sendMode.Text = khatam.core.data.sql.getField( "title", "id", ViewState["sendMode"].ToString(), "core_sendMode");

            if (ViewState["sendMode"].ToString() != "3")
            {
                lbl_mirror_Address.Text = txt_address.Text;
                lbl_mirror_zipCode.Text = txt_ZipCode.Text;
            }
            else
            {
                div_mirror_Address.Visible = false;

            }



            lbl_mirror_tel.Text = this.txt_tel.Text;
            lbl_mirror_cellPhone.Text = txt_cellPhone.Text;
            lbl_mirror_msg.Text = txt_message.Text;
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
    

        DataSet ds = new DataSet();
        ds = (DataSet)HttpContext.Current.Session["ds"];
        string orders = "";

        string invoiceId=""; string idRandom;
        int userid = khatam.core.Security.Users.login();

        if ((userid <1))
        {
            //if ( Page.Session["id_user"] != null)
           // {
                

                userid =int.Parse(Session["id_user"].ToString());
           // }
        }

        idRandom = khatam.core.Security.Users.MakePassword(4);

        string EmailBodyNeedPay="";

        if (ds != null)
        {

            switch (ViewState["sendMode"].ToString())
            {
                case "0":
                    //
                    invoiceId = invoiceManager.invoiceAdd(0, 0, this.lbl_total_order_and_send_price.Text, idRandom, false, userid, ""
                    , "", "", "", "", "", "", "", "", 0, 0, "0", "0", false, lbl_totalPrice.Text);
                 


                    for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                    {



                        invoiceManager.invoiceLineAdd(invoiceId, ds.Tables[0].Rows[k].ItemArray[1].ToString(), ds.Tables[0].Rows[k].ItemArray[4].ToString(),
                            ds.Tables[0].Rows[k].ItemArray[3].ToString(), ds.Tables[0].Rows[k].ItemArray[0].ToString(),
                            ds.Tables[0].Rows[k].ItemArray[5].ToString(),
                            ds.Tables[0].Rows[k].ItemArray[11].ToString(), ds.Tables[0].Rows[k].ItemArray[10].ToString(), ds.Tables[0].Rows[k].ItemArray[12].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[6].ToString(),""
                            , DateTime.UtcNow);
                       /* invoiceLineAdd(invoiceId, ds.Tables[0].Rows[k].ItemArray[1].ToString(), "1", "1", "1", "1", "1", "1", "true");*/
                    }

                    //userid
       
                                        EmailBodyNeedPay = " <br />"
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

                    khatam.core.email.sendAllPurposeEmail_old  (khatam.core.Security.Users.getEmail(userid.ToString()), khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir() + ": Customer PreInvoice No," + invoiceId
, EmailBodyNeedPay, "اطلاعات پیش فاکتور");

          
                    RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                              + "&pass=" + idRandom);
                    break;

                case "1":




                    invoiceId = invoiceManager.invoiceAdd(1, 0, (int.Parse(this.lbl_sendmode1.Text) + int.Parse(lbl_totalPrice.Text)).ToString(), idRandom, false, userid, ""
                        ,ddl_country.SelectedValue,ddl_state.SelectedValue,this.ddl_city.SelectedValue,
                        txt_address.Text, txt_ZipCode.Text, txt_tel.Text, txt_cellPhone.Text, txt_message.Text, 1, 0, lbl_sendmode1.Text, "0", false, lbl_totalPrice.Text);
                        
                    
                    for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                    {


                         invoiceManager.invoiceLineAdd(invoiceId, ds.Tables[0].Rows[k].ItemArray[1].ToString(), ds.Tables[0].Rows[k].ItemArray[4].ToString(),
                         ds.Tables[0].Rows[k].ItemArray[3].ToString(), ds.Tables[0].Rows[k].ItemArray[0].ToString(),
                         ds.Tables[0].Rows[k].ItemArray[5].ToString(),
                         ds.Tables[0].Rows[k].ItemArray[11].ToString(), ds.Tables[0].Rows[k].ItemArray[10].ToString(), ds.Tables[0].Rows[k].ItemArray[12].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[6].ToString(), ""
                         , DateTime.UtcNow);
           
                    }


                   invoiceManager.sendInfoNeedPay(userid.ToString(), invoiceId.ToString(), idRandom);         

                    RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                              + "&pass=" + idRandom);
                    break;

                case "10":




                    invoiceId = invoiceManager.invoiceAdd(10, 0, (int.Parse(this.lbl_sendmode10.Text) + int.Parse(lbl_totalPrice.Text)).ToString(), idRandom, false, userid, ""
                        , ddl_country.SelectedValue, ddl_state.SelectedValue, this.ddl_city.SelectedValue,
                        txt_address.Text, txt_ZipCode.Text, txt_tel.Text, txt_cellPhone.Text, txt_message.Text, 1, 0, lbl_sendmode10.Text, "0", false, lbl_totalPrice.Text);


                    for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                    {


                        invoiceManager.invoiceLineAdd(invoiceId, ds.Tables[0].Rows[k].ItemArray[1].ToString(), ds.Tables[0].Rows[k].ItemArray[4].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[3].ToString(), ds.Tables[0].Rows[k].ItemArray[0].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[5].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[11].ToString(), ds.Tables[0].Rows[k].ItemArray[10].ToString(), ds.Tables[0].Rows[k].ItemArray[12].ToString(),
                       ds.Tables[0].Rows[k].ItemArray[6].ToString(), ""
                        , DateTime.UtcNow);

                    }


                    invoiceManager.sendInfoNeedPay(userid.ToString(), invoiceId.ToString(), idRandom);

                    RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                              + "&pass=" + idRandom);
                    break;

                case "2":
                     KhatamSDRADCORE.info.webimc.www.ShoppingService irmc = new KhatamSDRADCORE.info.webimc.www.ShoppingService();

                        irmc.Credentials = new System.Net.NetworkCredential("mghslam1", "mSlam4050");

                        string stateMcid; string cityMcid;

                        stateMcid = khatam.core.data.sql.getField( "iran_mc_code", "country_state_id", this.ddl_state.SelectedValue, "core_country_state");
                        cityMcid = khatam.core.data.sql.getField( "iran_mc_code", "country_state_city_id", this.ddl_city.SelectedValue, "core_country_state_city");
                       
                        string userEmail;
                        userEmail= khatam.core.data.sql.getField("okShopcart","email","id",userid.ToString() ,"users",khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        string name;
                        name = khatam.core.data.sql.getField("okShopcart", "fname", "id", userid.ToString(), "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        string LastName;
                        LastName = khatam.core.data.sql.getField("okShopcart", "lname", "id", userid.ToString(), "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        string Company;
                        Company = khatam.core.data.sql.getField("okShopcart", "Company", "id", userid.ToString(), "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                        {
                            //if virual      
                            //id^name^price^weight^count;
                            //orders = "1^name^100^500^1;";
                            orders = orders + ds.Tables[0].Rows[j].ItemArray[0].ToString() + "^" +
                                ds.Tables[0].Rows[j].ItemArray[1].ToString() + "^" +
                                      ds.Tables[0].Rows[j].ItemArray[4].ToString() + "^" +
                                      ds.Tables[0].Rows[j].ItemArray[8].ToString() + "^" +
                                     ds.Tables[0].Rows[j].ItemArray[3].ToString() + ";";
                        }
                        try
                        {
                            string iranMcTrackingCode = irmc.RegisterOrder(name, LastName, Company, "",
                            txt_tel.Text, txt_cellPhone.Text, userEmail, txt_ZipCode.Text, txt_address.Text, txt_message.Text,
                            int.Parse(stateMcid), int.Parse(cityMcid), orders, 0, 0);

                            lbl_trace.Text = iranMcTrackingCode;


                            idRandom = khatam.core.Security.Users.MakePassword(4);

                            invoiceId = invoiceManager.invoiceAdd(2, 0, (int.Parse(this.lbl_sendmode2.Text) + int.Parse(lbl_totalPrice.Text)).ToString(), idRandom, false,
                                    userid, iranMcTrackingCode
                                   , ddl_country.SelectedValue, ddl_state.SelectedValue, this.ddl_city.SelectedValue,
                            txt_address.Text, txt_ZipCode.Text, txt_tel.Text, txt_cellPhone.Text, txt_message.Text, 1, 0, "0", lbl_sendmode2.Text, false, lbl_totalPrice.Text);


                                for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                                {


                                    invoiceManager.invoiceLineAdd(invoiceId, ds.Tables[0].Rows[k].ItemArray[1].ToString(), ds.Tables[0].Rows[k].ItemArray[4].ToString(),
                          ds.Tables[0].Rows[k].ItemArray[3].ToString(), ds.Tables[0].Rows[k].ItemArray[0].ToString(),
                          ds.Tables[0].Rows[k].ItemArray[5].ToString(),
                          ds.Tables[0].Rows[k].ItemArray[11].ToString(), ds.Tables[0].Rows[k].ItemArray[10].ToString(), ds.Tables[0].Rows[k].ItemArray[12].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[6].ToString(), ""
                          , DateTime.UtcNow);
                                }


            

                                invoiceManager.sendInfoPayOnDelivery(userid.ToString(), invoiceId.ToString(), idRandom); 

                                RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                                    + "&pass=" + idRandom);
                            
                         

                        }
                        catch (Exception ex)
                        {
                            lbl_trace.Text = ex.Message;
                            //lbl_msg_final.Text = "خطایی در ثبت خرید رخداده است";
                        }


            
                    break;
                case "3":

                    invoiceId = invoiceManager.invoiceAdd(3, 0, (int.Parse(this.lbl_sendmode3_by_agent.Text) + int.Parse(lbl_totalPrice.Text)).ToString(), idRandom, false, userid, ""
                        ,ddl_country.SelectedValue,ddl_state.SelectedValue,this.ddl_city.SelectedValue,
                        "", "", txt_tel.Text, txt_cellPhone.Text, txt_message.Text, 1, 0, lbl_sendmode3_by_agent.Text, "0", true, lbl_totalPrice.Text);
                        
                    
                    for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                    {


                        invoiceManager.invoiceLineAdd(invoiceId, ds.Tables[0].Rows[k].ItemArray[1].ToString(), ds.Tables[0].Rows[k].ItemArray[4].ToString(),
                      ds.Tables[0].Rows[k].ItemArray[3].ToString(), ds.Tables[0].Rows[k].ItemArray[0].ToString(),
                      ds.Tables[0].Rows[k].ItemArray[5].ToString(),
                      ds.Tables[0].Rows[k].ItemArray[11].ToString(), ds.Tables[0].Rows[k].ItemArray[10].ToString(), ds.Tables[0].Rows[k].ItemArray[12].ToString() ,
                      ds.Tables[0].Rows[k].ItemArray[6].ToString(), "", DateTime.UtcNow);
           
                    }



                    invoiceManager.sendInfoNeedPay(userid.ToString(), invoiceId.ToString(), idRandom);         

                    RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                              + "&pass=" + idRandom);
                    break;
                case "4":
                    invoiceId = invoiceManager.invoiceAdd(4, 0, int.Parse(lbl_totalPrice.Text).ToString(), idRandom, false, userid, ""
                        ,ddl_country.SelectedValue,ddl_state.SelectedValue,this.ddl_city.SelectedValue,
                        txt_address.Text, txt_ZipCode.Text, txt_tel.Text, txt_cellPhone.Text, txt_message.Text, 1, 0, "0", "0", true,lbl_totalPrice.Text);
                        
                    
                    for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                    {


                        invoiceManager.invoiceLineAdd(invoiceId, ds.Tables[0].Rows[k].ItemArray[1].ToString(), ds.Tables[0].Rows[k].ItemArray[4].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[3].ToString(), ds.Tables[0].Rows[k].ItemArray[0].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[5].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[11].ToString(), ds.Tables[0].Rows[k].ItemArray[10].ToString(), ds.Tables[0].Rows[k].ItemArray[12].ToString(),
                        ds.Tables[0].Rows[k].ItemArray[6].ToString(), "", DateTime.UtcNow);
           
                    }


                    invoiceManager.sendInfoNeedPay(userid.ToString(), invoiceId.ToString(), idRandom);         


                    RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" + invoiceId
                              + "&pass=" + idRandom);
                    break;
            }


   
        }
        else
        {
            hideTabs();
            tab1.Visible = true;
            LinkButton1.Font.Bold = true;
            gv_bindData();
        }

    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }



    protected void btn_Cancel_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab1.Visible = true;
        LinkButton1.Font.Bold = true;
    }

    protected void btnSendMode5_Click(object sender, EventArgs e)
    {
  
    }
    protected void btnSendMode10_Click(object sender, EventArgs e)
    {
        hideTabs();
        tab5.Visible = true;
        LinkButton5.Font.Bold = true;
        ViewState["sendMode"] = 10;
    }
}