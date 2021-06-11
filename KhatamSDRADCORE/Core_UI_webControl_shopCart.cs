using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:shopCart runat=server></{0}:shopCart>")]
                public class shopCart : CompositeControl
                {

                    /// <summary> 
                    /// Summary description for Employee. 
                    /// </summary> 


                    static Button btnok = new Button();
                    Panel PanelWin = new Panel();
                    Label Lbl1 = new Label();
                    public string windowsMode;
                    public string instanceID;
                    public Boolean winVisible;

                    Panel loginMemberShip_pl = new Panel();

                    Panel sendMode_selectCountry_pl = new Panel();
                    Panel sendMode_selectSendMode_pl = new Panel();
                    Panel sendMode_inputAdrress_pl = new Panel();


                    DropDownList sendMode_ddl_Country = new DropDownList();
                    DropDownList sendMode_ddl_Country_state = new DropDownList();
                    DropDownList sendMode_ddl_Country_state_city = new DropDownList();
                    DropDownList sendMode_ddl_Country_state_city_area = new DropDownList();

                    Button BtnContinueShop = new Button();


                    public string title
                    {
                        get
                        {
                            String s = (String)ViewState["textproperty"];
                            return ((s == null) ? String.Empty : s);
                        }

                        set
                        {
                            ViewState["textproperty"] = value;
                        }
                    }


                    protected override void CreateChildControls()
                    {

                        string str_content;
                        str_content = this.Parent.Page.ToString().Replace("ASP.", "").Replace("_aspx", "").Replace("_item", "");

                        //if (str_content == "layout") layout = true;

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));

                        this.Controls.Add(new LiteralControl(title));

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));

                        //this.Controls.Add(new LiteralControl(memo));

                        //if (str_content != "layout") this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField("page", "id", Page.Request.QueryString["id"], str_content, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())));

                       // UpdatePanel up1 = new UpdatePanel();

                       // up1.ContentTemplateContainer.Controls.Add(ShopCartGrid());
                       // this.Controls.Add(up1);

                      //  this.Controls.Add(ShopCartGrid());

                        Control TempControl = new Control();
                        TempControl = this.Page.LoadControl("c_shopcart.ascx");
                        this.Controls.Add(TempControl);

                        
                 /*    UpdatePanel up = new UpdatePanel();
                        khatam.core.UI.WebControls.loginWin lw = new loginWin();
                        lw.LoggedIn += new EventHandler(lw_loggedin);

                        loginMemberShip_pl.Controls.Add(lw);
                        up.ContentTemplateContainer.Controls.Add(loginMemberShip_pl);


                        khatam.core.UI.WebControls.membrshipWin mw = new membrshipWin();

                        loginMemberShip_pl.Controls.Add(mw);

                        up.ContentTemplateContainer.Controls.Add(loginMemberShip_pl);

                        loginMemberShip_pl.Visible = false;

                        sendMode_selectCountry_pl.Visible = true;


                      //  generate_sendMode_selectCountry_pl();

                       generate_sendMode_selectSendMode_pl();

                        //   generate_sendMode_inputAdrress_pl();


                     //   up.ContentTemplateContainer.Controls.Add(sendMode_selectSendMode_pl);

                        up.ContentTemplateContainer.Controls.Add(sendMode_selectCountry_pl);

                        //  up.ContentTemplateContainer.Controls.Add(sendMode_inputAdrress_pl);

                        // add triger for fire fox ajax debug for dropp down list
                        AsyncPostBackTrigger upe = new AsyncPostBackTrigger();
                        upe.ControlID = "gv_country";
                        up.Triggers.Add(upe);


                        this.Controls.Add(up);*/


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));



                    }

                    public string addInstanceProperty(string Instance)
                    {


                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }



                    #region Events


                    public void btnShopCart_iranmc_Click_(object sender, EventArgs e)
                    {

                        // http://466.ir/Card/add.php?PID=2112000110&B1=++++++++%D8%A7%D8%B1%D8%B3%D8%A7%D9%84+%D8%A8%D9%87+%D8%B3%D8%A8%D8%AF+%D8%AE%D8%B1%DB%8C%D8%AF++++++++");


                        //http://466.ir/Card/add.php?PID=212900423660&B1=++++++++%D8%A7%D8%B1%D8%B3%D8%A7%D9%84+%D8%A8%D9%87+%D8%B3%D8%A8%D8%AF+%D8%AE%D8%B1%DB%8C%D8%AF++++++++
                        //                      khatam






                        string str_shopcart = "";


                        string[] strShopCartId;// = new string[];
                        strShopCartId = khatam.shop.shopCart.GetShopCartArrayID_IranMC(this.Page);



                        foreach (string s in strShopCartId)
                        {
                            if ((s != null) && (s != ""))
                            {
                                str_shopcart = s + "^" + str_shopcart;
                            }
                        }

                        str_shopcart = "http://466.ir/Card/add.php?PID=" + str_shopcart + "&B1=++++++++%D8%A7%D8%B1%D8%B3%D8%A7%D9%84+%D8%A8%D9%87+%D8%B3%D8%A8%D8%AF+%D8%AE%D8%B1%DB%8C%D8%AF++++++++";


                        this.Page.Response.Redirect(str_shopcart, false);

                    }


                    public void BtnContinueShop_Click(object sender, EventArgs e)
                    {

                        BtnContinueShop.Visible = false;

                        loginMemberShip_pl.Visible = true;


                    }

                    public void lw_loggedin(object sender, EventArgs e)
                    {


                        loginMemberShip_pl.Visible = false;
                        sendMode_selectCountry_pl.Visible = true;

                    }

                    public void sendMode_ddl_Country_changed(object sender, EventArgs e)
                    {
                        sendMode_ddl_Country_state.DataSource =
                            khatam.core.globalization.state.getStateListByCountry(sendMode_ddl_Country.SelectedValue);
                        sendMode_ddl_Country_state.DataValueField = "state_id";
                        sendMode_ddl_Country_state.DataTextField = "state_title";

                        sendMode_ddl_Country_state.DataBind();


                        //sendMode_ddl_Country_state.Visible = false;

                    }


                    #endregion


                    #region Child Controls


                    protected void grdContact_RowEditing(object sender, DataGridCommandEventArgs e)
                    {
                       // e.Cancel = true;
                      //  dg1.EditIndex = -1;

                      //  dg1.EditIndex = e.NewEditIndex;
                        
                       
                        //FillGrid();
                        dg1.EditItemIndex = e.Item.ItemIndex;

                        this.Page.Title = "edit";

                       
                    }

                    protected void grdContact_RowDeleting(object sender, GridViewDeleteEventArgs e)
                    {
                        e.Cancel = true;
                     //   dg1.EditIndex = -1;

                        //dg1.EditIndex = e.NewEditIndex;
                        //dg1.DataBind();
                        //FillGrid();
                        dg1.DataBind();

                        this.Page.Title = "delete";


                    }

  

                    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
                    {
                        e.Cancel = true;
                      //  dg1.EditIndex = -1;
                       dg1.DataBind();

                       this.Page.Title = "cancel";
                    }

                 /*   public void FillGrid()
                    {
                        ContactTableAdapter contact = new ContactTableAdapter();
                        DataTable contacts = contact.GetData();
                        if (contacts.Rows.Count > 0)
                        {
                            grdContact.DataSource = contacts;
                            grdContact.DataBind();
                        }
                        else
                        {
                            contacts.Rows.Add(contacts.NewRow());
                            grdContact.DataSource = contacts;
                            grdContact.DataBind();

                            int TotalColumns = grdContact.Rows[0].Cells.Count;
                            grdContact.Rows[0].Cells.Clear();
                            grdContact.Rows[0].Cells.Add(new TableCell());
                            grdContact.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                            grdContact.Rows[0].Cells[0].Text = "No Record Found";
                        }
                    }*/



                    DataGrid dg1 = new DataGrid();

                    public void bindData()
                    {
                        DataSet ds = new DataSet();

                        dg1.ID = "dg1";



                        //  dg1.DataSource = khatam.core.data.sql.getTable("users");

                        //       if (! this.Page.IsPostBack )
                        //     {
                        ds = (DataSet)this.Page.Session["ds"];

                        dg1.DataSource = ds;
                        dg1.AutoGenerateColumns = false;

                        //dg1.DataBind();
                        //          }

                        BoundColumn b1 = new BoundColumn();
                        b1.HeaderText = "کد محتوا";
                        b1.DataField = "productcode";
                        b1.ReadOnly = true;
                        dg1.Columns.Add(b1);

                        BoundColumn b2 = new BoundColumn();
                        b2.HeaderText = "شرح";
                        b2.DataField = "productname";
                        b2.ReadOnly = true;
                        dg1.Columns.Add(b2);

                        BoundColumn b3 = new BoundColumn();
                        b3.HeaderText = "تعداد";
                        b3.DataField = "quantity";
                        dg1.Columns.Add(b3);

                         // BoundField b4 = new BoundField();
                       //   b4.HeaderText = "واحد کالا";
                        //   b4.DataField = "productcode";
                        //   dg1.Columns.Add(b4);

                        BoundColumn b5 = new BoundColumn();
                        b5.HeaderText = "قیمت";
                        b5.DataField = "price";
                        b5.ReadOnly = true;
                        dg1.Columns.Add(b5);

                        BoundColumn b6 = new BoundColumn();
                        b6.HeaderText = "جمع";
                        b6.DataField = "sum";
                        b6.ReadOnly = true;
                        dg1.Columns.Add(b6);






                        EditCommandColumn c = new EditCommandColumn();
                        c.EditText = "eee";
                        c.CancelText = "CCC";
                        c.UpdateText = "UUUU";
                       
                        dg1.EditCommand += new  DataGridCommandEventHandler (grdContact_RowEditing);
                       // c.ShowEditButton = true;
                       // c.ShowDeleteButton = true;

                        dg1.Columns.Add(c);

           

                     

                        dg1.Attributes.Add("DataKeyNames", "productcode");


                        //dg1.DataKeyNames = new string[] { "productcode" };


                        dg1.Width = Unit.Percentage(100);

                        //dg1.RowEditing += new GridViewEditEventHandler(grdContact_RowEditing);
                        //dg1.RowCancelingEdit += new  GridViewCancelEditEventHandler(GridView1_RowCancelingEdit);
                        //dg1.RowDeleting += new GridViewDeleteEventHandler(grdContact_RowDeleting);
                        
                        //dg1.RowUpdating += new GridViewUpdateEventHandler(GridView1_RowUpdating);

                      //  dg1.Attributes.Add("onrowupdating", "GridView1_RowUpdating");

                       // dg1.RowUpdating += new GridViewUpdateEventHandler(GridView1_RowUpdating); 

   
                        //dg1.RowUpdating += new GridViewUpdateEventHandler(GridView1_RowUpdating); 
                      //  dg1.RowCommand += new GridViewRowEventArgs(UpdateRecord); 
   
 
 


                     //   dg1.EditIndex = 0;

                     
                           dg1.DataBind();
                     
                    }



                    public  void BtnContinueShop_Click2(object sender, EventArgs e)
                    {

                        this.Page.Title = "update";
                        

                    }

              
                    public Control ShopCartGrid()
                    {


                        PlaceHolder ph1 = new PlaceHolder();

                        ph1.Controls.Add(new LiteralControl("<div style=\"direction:rtl\">"));




                      
                            bindData();
                      

                        ph1.Controls.Add(dg1);

                        //this.Controls.Add(new LiteralControl(dg1.Columns.Count.ToString()));


                        BtnContinueShop.Text = "ادامه مراحل خرید";
                        BtnContinueShop.Width = 150;

                        BtnContinueShop.ID = "btnGoto";

                        BtnContinueShop.Click += new EventHandler(BtnContinueShop_Click);

                        BtnContinueShop.Font.Name = "tahoma";


                        if (dg1.Items.Count > 0)
                        {
                            ph1.Controls.Add(BtnContinueShop);
                            //dg1.Columns[0].HeaderText = "کد";

                        }
                        else
                        {
                            this.Controls.Add(new LiteralControl("سبد خرید شما خالی است"));
                        }

                        ph1.Controls.Add(new LiteralControl("</div>"));

                        return ph1;
                    }

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
                        sendMode_ddl_Country.SelectedIndexChanged += new EventHandler(sendMode_ddl_Country_changed);
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

                        KhatamSDRADCORE.info.webimc.www.ShoppingService irmc = new KhatamSDRADCORE.info.webimc.www.ShoppingService();

                        irmc.Credentials = new System.Net.NetworkCredential("mghslam1", "mSlam4050");

                        string result = irmc.GetSendPrice("30000000", "200", 51, 8, 0);

                        sendMode_selectSendMode_pl.Controls.Add(new LiteralControl(result));

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
                        sendMode_ddl_Country.SelectedIndexChanged += new EventHandler(sendMode_ddl_Country_changed);
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


                    #endregion

                }
            }
        }
    }
}

