using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using khatam.core.globalization;

namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:contentItemWin runat=server></{0}:contentItemWin>")]
                public class contentItemWin : CompositeControl
                {

                    public string contentTable = "", contentId = "", catid = "";

                    static Button btnok = new Button();

                    DropDownList ddlpaycycle = new DropDownList();

                    Label lbl = new Label();


                    Panel PanelWin = new Panel();
                    Label Lbl1 = new Label();


                    Panel pAddToShopCart = new Panel();
                    Panel pAddedShopCart = new Panel();

                    khatam.core.data.sql.contentItem ci = new khatam.core.data.sql.contentItem();


                    public string memo
                    {
                        get
                        {
                            String s = (String)ViewState["memotxt"];
                            return ((s == null) ? String.Empty : s);
                        }

                        set
                        {
                            ViewState["memotxt"] = value;
                        }
                    }



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


                    public string txtBoxValue2
                    {
                        get
                        {
                            TextBox txtboxt2 = (TextBox)this.FindControl("txtbox" + instanceID);

                            return txtboxt2.Text;
                        }
                        set
                        {
                            TextBox txtboxt2 = (TextBox)this.FindControl("txtbox" + instanceID);

                            txtboxt2.Text = value;
                        }
                    }





                    public string texthf
                    {
                        get
                        {
                            TextBox textb = (TextBox)this.FindControl("Text1" + instanceID);

                            return textb.Text;
                        }
                        set
                        {
                            TextBox textb = (TextBox)this.FindControl("Text1" + instanceID);

                            textb.Text = value;
                        }
                    }


                    public string windowsMode;

                    public string instanceID;

                    public Boolean winVisible;

                    Panel PaneldomainAvailable = new Panel();


                    protected override void CreateChildControls()
                    {


                        try
                        {
                            contentTable = this.Parent.Page.ToString().Replace("ASP.", "").Replace("_aspx", "").Replace("_item", "");
                        }
                        catch
                        {
                        }


                        try
                        {
                            contentTable = HttpContext.Current.Items["contentType"].ToString();// +".aspx";
                        }
                        catch
                        {
                            contentTable = "article";//+ ".aspx";
                        }


                        try
                        {
                            contentId = HttpContext.Current.Items["id"].ToString();// +".aspx";
                        }
                        catch
                        {
                            contentId = "1";
                        }


                        ci = khatam.core.data.sql.getContentItemBaseInfo(contentId, contentTable);

                        if (ci.returnCode == "1")
                        {

                          /*  this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                            this.Controls.Add(new LiteralControl(ci.title));
                            this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                            this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));*/
                           this.Controls.Add(ContentHeader());

                            this.Controls.Add(new LiteralControl(ci.page));
                            this.Controls.Add(ContentFooter());
                            /*this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));*/

                        }
                        else
                        {
                            this.Controls.Add(new LiteralControl("خطا شماره: " + ci.returnCode));
                        }
                    }




                    public Control ContentHeader()
                    {

                        string id;
                        id = contentId;

                        string imageUrl, temp2;


                        string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/" + id + "/" + ci.title.ToString().Replace(" ", "-");


                        PlaceHolder ph = new PlaceHolder();

                       string  timeStr= "";
                      // if (ci.pub_date != null) { timeStr = khatam.core.globalization.dateTime.GetPersianDateTime(ci.pub_date  ); };
                       try
                       {
                           if (ci.pub_date > DateTime.MinValue)
                           {
                               timeStr =
                                   numbers.GetPersianNumbers(dateTime.GetPersianDateTime(ci.pub_date));
                           };
                       }
                       catch
                       {
                       }

                       //if (strposteddate == "1/1/0001")
                        string btnUrl;
                        btnUrl =khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/btn/";

                        ph.Controls.Add(new LiteralControl(" <h1>" + ci.title + " </h1> "));


                        ph.Controls.Add(new LiteralControl("<div  style=\"width:100% ;   display:  inline-block; margin-bottom:10px; margin-right:10px \">"));
                        ph.Controls.Add(new LiteralControl(" <p class=\"desc2\">"));
                        ph.Controls.Add(new LiteralControl("زمان درج: " + timeStr  + " | " +
                            " <a  onclick=\"addBookmark(location.href, document.title);\"> " 
                          + " <img  src=\"" + btnUrl + "ibtn_addToFavi.gif\"  />" + " اضافه به علاقه مندی ها " + "</a> "

                         + "|" + "<a  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                         + "print.aspx?id="+ contentId +"&type_content=" + contentTable + "&lang=fa" + "\">" + " <img  src=\"" + btnUrl + "ibtn_print.gif\"  />" + " چاپ " + "</a>"
                         /*+ "|" + " <img  src=\"" + btnUrl + "ibtn_email.gif\"  />"  + " ایمیل " */));
                        ph.Controls.Add(new LiteralControl(" </p>"));

                        ph.Controls.Add(new LiteralControl(  "</div>   "));

                       // 

                        ph.Controls.Add(new LiteralControl("<div  style=\"width:98% ;   display:  inline-block; margin-bottom:10px; margin-right:10px \">"));




                        if (ci.image != "")
                        {
                            /***************************** old one simple pic
                            ph.Controls.Add(new LiteralControl("<div style=\"float:left; margin-right:10px; margin-left:10px \">"));

                            imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/7/" + ci.image;
                            temp2 = "<a href=\"" + url + "\">" + " <img alt=\"" + ci.title + "\" src=\"" + imageUrl + "\"  />" + "</a>";
                            ph.Controls.Add(new LiteralControl(temp2));
                            ph.Controls.Add(new LiteralControl("</div>   "));
                            *******************************/
                            ph.Controls.Add(new LiteralControl("<div style=\"float:left; margin-right:10px; margin-left:10px \">"));

                            imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/7/" + ci.image;
                           string  imageUrl2 = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + contentTable + "/0/" + ci.image;

                            string html = "<a href=\"" + imageUrl2  +  "\" class=\"highslide\" onclick=\"return hs.expand(this,"
+ " 			{wrapperClassName: 'borderless floating-caption', dimmingOpacity: 0.75, align: 'center'})\">"
+ " 	<img id=\"thumb3\" src=\"" + imageUrl + "\" alt=\"" + title + "\""
+ " 		title=\"" + title  + "\"  /></a>"
+ " <div class=\"highslide-caption\">"
//+ " This caption can be styled using CSS."
+ ci.title 
+ " </div>";
                            ph.Controls.Add(new LiteralControl(html));

                            ph.Controls.Add(new LiteralControl("</div>   "));



                        }



                        ph.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;margin-left:10px\">"));


                        ph.Controls.Add(new LiteralControl("<div style=\"text-align: justify ; margin-left:10px\">"));
                        ph.Controls.Add(new LiteralControl(" <p class=\"desc1\">"));
                        ph.Controls.Add(new LiteralControl(ci.description));
                        ph.Controls.Add(new LiteralControl(" </p>"));
                        ph.Controls.Add(new LiteralControl("</div>"));



                        if (ci.author != "")
                        {
                            ph.Controls.Add(new LiteralControl(" نویسنده:  " + ci.author));
                            ph.Controls.Add(new LiteralControl("</br>"));

                        }


                        if (contentTable == "shop")   ph.Controls.Add(ContentHeaderChildShop());


                        if (contentTable == "library") ph.Controls.Add( ContentHeaderChildLibrary());

                        if (contentTable == "software") ph.Controls.Add(ContentHeaderChildSoftware());

                        if (contentTable == "clip") ph.Controls.Add(ContentHeaderChildClip());

                        if (contentTable == "picture") ph.Controls.Add(ContentHeaderChildPicture());

                        if (contentTable == "host") ph.Controls.Add(ContentHeaderChildHost());
                        if (contentTable == "portal") ph.Controls.Add(ContentHeaderChildPortal());

                        if (contentTable == "link")  ph.Controls.Add(ContentHeaderChildLink());

                        if (contentTable == "estate") ph.Controls.Add(ContentHeaderChildEstate());


                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        // ph.Controls.Add(new LiteralControl("<hr/>"));

                        return ph;

                    }

                    public Control ContentFooter()
                    {
                        PlaceHolder ph = new PlaceHolder();



                        if (contentTable == "estate")
                        {
                            ph.Controls.Add(ContentFooterChildEstate());
                        }

                        /*  if (contentTable == "shop")
                          {
                              DNA.UI.JQuery.Tabs a = new DNA.UI.JQuery.Tabs();
                              DNA.UI.JQuery.View v = new DNA.UI.JQuery.View();
                              v.Text = "مشخصات";
                              //  v.Controls.Add(new LiteralControl(" تست"));
                              a.Views.Add(v);

                              DNA.UI.JQuery.View v2 = new DNA.UI.JQuery.View();
                              // v2.Text = "اطلاعات فروش / فروش عمده";
                              v2.Text = "اطلاعات فروش";
                              //v2.Controls.Add(new LiteralControl("2222222222 تست"));

                              GridView gv = new GridView();
                              gv.AutoGenerateColumns = true;
                              gv.DataSource = khatam.core.data.sql.getTable("core_sale_terms");
                              gv.DataBind();
                              //v2.Controls.Add(gv);

                              a.Views.Add(v2);





                              ph.Controls.Add(a);
                          }*/

                        string html = "<a class=\"a2a_dd\" href=\"http://www.addtoany.com/share_save\"><img src=\"http://static.addtoany.com/buttons/share_save_171_16.png\" width=\"171\" height=\"16\" border=\"0\" alt=\"Share\"/></a> " +
                          " <script type=\"text/javascript\" src=\"http://static.addtoany.com/menu/page.js\"></script>";






                     /*   string html2 = "<!-- Place this tag where you want the +1 button to render. -->"
+ " <div class=\"g-plusone\" data-size=\"medium\" data-annotation=\"none\"></div>"
+ " <!-- Place this tag after the last +1 button tag. -->"
+ " <script type=\"text/javascript\">"
+ " window.___gcfg = {lang: 'fa'};"
+ " (function() {"
+ " var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;"
+ " po.src = 'https://apis.google.com/js/plusone.js';"
+ " var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);"
+ " })();"
+ " </script>";*/
                        // ph.Controls.Add(new LiteralControl(html2));
                        ph.Controls.Add(new LiteralControl(html));


                        return ph;
                    }

                    TextBox txtQ = new TextBox();
                    DropDownList ddl_payCycle = new DropDownList();



                    public static DataTable getPayCylces(string catid)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        //parameters.Add("field_where_value", field_where_value);
                        str_sql = "SELECT      month, price  FROM         core_paycycle " +
                    "WHERE     (catId = " + catid + ") AND (enable = 1)  ORDER BY month ";
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }



                    public Control ContentHeaderChildShop()
                    {
                        
                        string unit;
                        unit = khatam.shop.shopCart.getUnits(contentId);

                        PlaceHolder ph = new PlaceHolder();

                       // ph.Controls.Add(new LiteralControl("test"));

                        ph.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;overflow:hidden;;margin-left:10px\">"));



                      // string price_in_rls = "";
                        string min = "";

                        catid = khatam.core.data.sql.getField( "id", "id_content", contentId, "type_content", "shop", "cat");

                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                      //  khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                      //  khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                       if (!khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
                       //if (false)
                       {
                           DataTable dt = new DataTable();
                           string sql_str = "SELECT     TOP (1) min   FROM         core_sale_terms  WHERE     (catId = " +  catid + ") ORDER BY min";

                          dt = DBFunctions.ExecuteReader(sql_str, parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        //   price_in_rls = dt.Rows[0].ItemArray[1].ToString();
                           min = dt.Rows[0].ItemArray[0].ToString();

                           //side right
                           DataTable dt2 = new DataTable();
                           dt2 = khatam.shop.shopCart.getPrices(catid);
                           ph.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;  float:right; width:200px ;margin-left:10px\">"));

                           for (int i = 0; i < dt2.Rows.Count; i++)
                           {

                               if (i > 0)
                               {

                                   ph.Controls.Add(new LiteralControl("<span class=\"desc2\">  بیش از " + dt2.Rows[i].ItemArray[0].ToString() + " " + unit + " :<span class=\"spanPrice\"> " +

                                   Persia.Number.ConvertToPersian(dt2.Rows[i].ItemArray[1].ToString()) + " </span> ریال </span> "));
                               }
                               else
                               {
                                   ph.Controls.Add(new LiteralControl("<span class=\"desc2\">  قیمت " + dt2.Rows[i].ItemArray[0].ToString() + " " + unit + " :<span class=\"spanPrice\"> " +

                                Persia.Number.ConvertToPersian(dt2.Rows[i].ItemArray[1].ToString()) + " </span> ریال </span> "));
                               }

                               ph.Controls.Add(new LiteralControl("</br>"));


                           }


                           ph.Controls.Add(new LiteralControl("</div>"));

                           ph.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;float:right; width:200px ;margin-left:10px\">"));




                           string id_iranmc = khatam.core.data.sql.getField( "id_iranmc", "id", contentId, contentTable);

                           UpdatePanel up = new UpdatePanel();
                           UpdateProgress alp = new UpdateProgress();

                           alp.Controls.Add(new LiteralControl("<div style=\"text-align:right;\"> <img alt=\"loading...\"  src=\"" +
                           khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                           "RadControls/Ajax/Skins/Default/Loading2.gif\" /> </div>"));

                           up.ID = "ggggg";

                           alp.AssociatedUpdatePanelID="ggggg";
                            
                           // }

                           ph.Controls.Add(alp);

                           pAddToShopCart.Controls.Add(new LiteralControl("</br>"));
                           pAddToShopCart.Controls.Add(new LiteralControl("</br>"));


                           txtQ.ID = "txtQ";
                           txtQ.Attributes.Add("onkeypress", "return isNumberKey(event)");
                           txtQ.ClientIDMode = System.Web.UI.ClientIDMode.Static;
                           txtQ.Text = min;
                           txtQ.Font.Name = "tahoma";
                           txtQ.Width = System.Web.UI.WebControls.Unit.Pixel(40);
                           pAddToShopCart.Controls.Add(txtQ);

                           pAddToShopCart.Controls.Add(new LiteralControl(" "));
                           pAddToShopCart.Controls.Add(new LiteralControl(unit));
                           pAddToShopCart.Controls.Add(new LiteralControl(" "));




                           pAddToShopCart.Controls.Add(new LiteralControl("</br>"));


                           RangeValidator RangeValidator1 = new RangeValidator();
                           RangeValidator1.ControlToValidate = txtQ.ID;
                           RangeValidator1.MinimumValue = min;
                           RangeValidator1.MaximumValue = "10000000";
                           RangeValidator1.Type = ValidationDataType.Integer;
                           RangeValidator1.Text = "حداقل سفارش این محصول " + min + " عدد است";
                           RangeValidator1.ErrorMessage = "msg";
                           pAddToShopCart.Controls.Add(RangeValidator1);



                           pAddToShopCart.Controls.Add(new LiteralControl("</br>"));



                           pAddToShopCart.Controls.Add(ShopCartButton());

                           //pAddedShopCart.Controls.Add(new LiteralControl("محصو"));

                           pAddedShopCart.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                            "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));


                           up.ContentTemplateContainer.Controls.Add(pAddToShopCart);

                           pAddedShopCart.Visible = false;
                           up.ContentTemplateContainer.Controls.Add(pAddedShopCart);

                           
                           //ph.Controls.Add(ShopCartButton());
                     
                           ph.Controls.Add(up);

                           ph.Controls.Add(new LiteralControl("</br>"));
                           ph.Controls.Add(new LiteralControl("</br>"));

                           ph.Controls.Add(new LiteralControl("</div>"));


                       }  

                     //  string YahooID = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "YahooID", "id", contentId, contentTable);
                     //  if (YahooID != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\"> یاهو آیدی فروشنده : " + khatam.core.strings.Messenger.Gen_Yahoo_Status(YahooID, 1) + " </span>     " + "</br>"));

                     //  string shopAssistantTel = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantTel", "id", contentId, contentTable);
                     //  if (shopAssistantTel != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">تلفن فروشنده: " + shopAssistantTel + " </span>     " + "</br>"));

                     //  string shopAssistantMobile = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantMobile", "id", contentId, contentTable);
                     //  if (shopAssistantMobile != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">تلفن همراه فروشنده: " + shopAssistantMobile + " </span>     " + "</br>"));

                     //  string shopAssistantEmail = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantEmail", "id", contentId, contentTable);
                     //  if (shopAssistantEmail != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">ایمیل فروشنده: " + shopAssistantEmail + " </span>     " + "</br>"));
                       
                        ph.Controls.Add(new LiteralControl("</div>"));

                        return ph;

                    }

                    PlaceHolder phWin1 = new PlaceHolder();
                    PlaceHolder phWin2 = new PlaceHolder();
                    PlaceHolder phWin2_box1 = new PlaceHolder();
                    PlaceHolder phWin2_box2 = new PlaceHolder();

                    TextBox txt_domainReg = new TextBox();
                    TextBox txt_domainPrefixSet = new TextBox();
                    TextBox txt_domainSet = new TextBox();


                    DropDownList ddlDomainPrefix = new DropDownList();

                    Button btn_AddToShopCart_HostPortal_search = new Button();

                    public Control ContentHeaderChildHost()
                    {
                        PlaceHolder phHost = new PlaceHolder();


                


                        UpdatePanel up = new UpdatePanel();
                        UpdateProgress alp = new UpdateProgress();
                        alp.Controls.Add(new LiteralControl("<img alt=\"loading...\" src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "RadControls/Ajax/Skins/Default/Loading1.gif\" />"));

                        //if (this.Page.IsPostBack == false)
                        // {

                        alp.AssociatedUpdatePanelID = up.ClientID;
                        // }
                        phHost.Controls.Add(alp);


                        catid = khatam.core.data.sql.getField( "id", "id_content", contentId, "type_content", contentTable, "cat");

                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                        phWin1.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;overflow:hidden;;margin-left:10px\">"));

                        // if (!khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
                        if (true)
                        {
                            /* DataTable dt = new DataTable();
                             string sql_str = "SELECT     min, price, catId   FROM         core_sale_terms   WHERE     (catId = " + catid + " ) AND (min =      (SELECT     MIN(min) AS Expr1          FROM         core_sale_terms AS core_sale_terms_1))";

                             dt = DBFunctions.ExecuteReader(sql_str, parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                             price_in_rls = dt.Rows[0].ItemArray[1].ToString();
                             min = dt.Rows[0].ItemArray[0].ToString();*/

                            //side right
                            DataTable dt2 = new DataTable();
                            dt2 = getPayCylces(catid);
                            phWin1.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;  float:right; width:200px ;margin-left:10px\">"));
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                int month = int.Parse(dt2.Rows[i].ItemArray[0].ToString());


                                if (month % 12 == 0)
                                {
                                    int year = month / 12;
                                    phWin1.Controls.Add(new LiteralControl("<span class=\"desc2\"> " + year.ToString() + " سال " + " :<span class=\"spanPrice\"> " +
                                    Persia.Number.ConvertToPersian(dt2.Rows[i].ItemArray[1].ToString()) + " </span> ریال </span> "));
                                }
                                else
                                {
                                    phWin1.Controls.Add(new LiteralControl("<span class=\"desc2\"> " + dt2.Rows[i].ItemArray[0].ToString() + " ماه " + " :<span class=\"spanPrice\"> " +
                                    Persia.Number.ConvertToPersian(dt2.Rows[i].ItemArray[1].ToString()) + " </span> ریال </span> "));
                                }

                                phWin1.Controls.Add(new LiteralControl("</br>"));
                            }


                            phWin1.Controls.Add(new LiteralControl("</div>"));
         
                            phWin1.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;float:right; width:200px ;margin-left:10px\">"));
                                                                                 
                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));
                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));
                                            
                            pAddToShopCart.Controls.Add(ddl_payCycle);
                            ddl_payCycle.DataSource = khatam.core.UI.WebControls.domainSearchWin.getPaycycle_VProducts(catid);
                            ddl_payCycle.DataValueField = "id";
                            ddl_payCycle.DataTextField = "title";
                            ddl_payCycle.Font.Name = "tahoma";
                            ddl_payCycle.DataBind();



                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));

                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));

                            Button btn = new Button();
                            btn.Text = " سفارش خرید ";
                            btn.Font.Name = "tahoma";

                            btn.Click += new EventHandler(btnOrderPortal_host_Click);
                            
                            pAddToShopCart.Controls.Add(btn);

                          //  pAddToShopCart.Controls.Add(ShopCartButton());


                           // pAddedShopCart.Visible = false;
                           // AjaxPanel.Controls.Add(pAddedShopCart);


                            phWin1.Controls.Add(pAddToShopCart);

                           // phWin1.Controls.Add(AjaxPanel);

                            phWin1.Controls.Add(new LiteralControl("</br>"));
                            phWin1.Controls.Add(new LiteralControl("</br>"));

                            phWin1.Controls.Add(new LiteralControl("</div>"));


                        }
                        //  ph.Controls.Add(new LiteralControl("<span class=\"desc2\">شیوه های ارسال / پرداخت:</span>     " + "</br>"));

                        //    ph.Controls.Add(new LiteralControl("<img src=\"" +
                        //  khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                        //    + "theme/Flowhub/CssImage/btn/iranmc.png\" />"));
                        //  ph.Controls.Add(new LiteralControl("</br>"));
                        //###   }
                        //###}

                        /*  string YahooID = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "YahooID", "id", contentId, contentTable);
                          if (YahooID != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\"> یاهو آیدی فروشنده : " + khatam.core.strings.Messenger.Gen_Yahoo_Status(YahooID, 1) + " </span>     " + "</br>"));

                          string shopAssistantTel = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantTel", "id", contentId, contentTable);
                          if (shopAssistantTel != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">تلفن فروشنده: " + shopAssistantTel + " </span>     " + "</br>"));

                          string shopAssistantMobile = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantMobile", "id", contentId, contentTable);
                          if (shopAssistantMobile != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">تلفن همراه فروشنده: " + shopAssistantMobile + " </span>     " + "</br>"));

                          string shopAssistantEmail = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantEmail", "id", contentId, contentTable);
                          if (shopAssistantEmail != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">ایمیل فروشنده: " + shopAssistantEmail + " </span>     " + "</br>"));
                          */
                        phWin1.Controls.Add(new LiteralControl("</div>"));

                        phHost.Controls.Add(phWin1);

                        phWin2.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;overflow:hidden;;margin-left:10px\">"));
                        phWin2.Controls.Add(new LiteralControl("کالا/سرویسی که انتخاب نموده اید نیاز به نام دامین دارد پس لطفا نام دامین انتخابی خود را در زیر وارد کنید:"));
                        phWin2.Controls.Add(new LiteralControl("</br>"));


                        RadioButtonList rbl = new RadioButtonList();


                        rbl.AutoPostBack = true;
                        rbl.ID = "rblID";

                     

                        // Wire up the eventhandler 
                        rbl.SelectedIndexChanged += new EventHandler(rbl_SelectedIndexChanged);


                        // Add the items 
                        rbl.Items.Add(new ListItem("می خواهم دامین جدید ثبت کنم", "1"));
                        rbl.Items.Add(new ListItem("دامین فعال دارم و DNS های شما را روی دامینم تنظیم خواهم کرد", "2"));

                        rbl.Items[0].Selected = true;


                        rbl.DataBind();


                        phWin2.Controls.Add(rbl); 


                        /*RadioButton rb1 = new RadioButton();
                       // rb1.CheckedChanged
                        rb1.Text = "می خواهم دومین جدید ثبت کنم ";
                        rb1.Checked = true;
                        rb1.GroupName = "domain";
                        rb1.CheckedChanged += new EventHandler(rb1_Click);
                        rb1.AutoPostBack = true;
                        phWin2.Controls.Add(rb1);

                        phWin2.Controls.Add(new LiteralControl("</br>"));

                        RadioButton rb2 = new RadioButton();
                        rb2.Text = "دومین فعال دارم و DNS های شما را روی دومینم تنظیم خواهم کرد";
                        rb2.Checked = false;
                      
                        rb2.GroupName = "domain";
                        phWin2.Controls.Add(rb2);*/

                        phWin2.Controls.Add(new LiteralControl("</br>"));
                        //****************

                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));


                        ddlDomainPrefix.DataValueField = "title";
                        ddlDomainPrefix.DataTextField = "title";
                        ddlDomainPrefix.Font.Name = "tahoma";
                        ddlDomainPrefix.Font.Size = 9;
                        ddlDomainPrefix.Width = 55;
                        ddlDomainPrefix.DataSource = khatam.core.UI.WebControls.domainSearchWin.getDomains();
                       ddlDomainPrefix.DataBind();
                        phWin2_box1.Controls.Add(ddlDomainPrefix);


                        phWin2_box1.Controls.Add(new LiteralControl(" . "));


                       
                        txt_domainReg.Style.Add("direction", "ltr");

                        phWin2_box1.Controls.Add(txt_domainReg);



                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));

                        Button btn1 = new Button();
                        btn1.ID = "btn1";
                        btn1.Text = "جستجو";
                        btn1.Font.Name = "tahoma";
                       // btn1.ValidationGroup = "domainSearchWin";
                        btn1.Click += new EventHandler(btn_ChekDomain_Click);

                        phWin2_box1.Controls.Add(btn1);
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));


                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));

                        phWin2_box1.Controls.Add(lbl);

                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));

                        ddlpaycycle.DataValueField = "id";
                        ddlpaycycle.DataTextField = "title";
                        ddlpaycycle.Font.Name = "tahoma";

                       // ddlpaycycle.DataSource = getPaycycle(ddlDomainPrefix.SelectedValue);
                        //ddlpaycycle.DataBind();

                        phWin2_box1.Controls.Add(ddlpaycycle);

                        /*   GridView gv = new GridView();
                           gv.DataSource = getPaycycle(ddlDomainPrefix.SelectedValue);
                           gv.AutoGenerateColumns = true;
                           gv.DataBind();
                           PaneldomainAvailable.Controls.Add(gv);
                           PaneldomainAvailable.Controls.Add(new LiteralControl("test"));*/

                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));
                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));

                        
                        btn_AddToShopCart_HostPortal_search.Text = "اضافه به سبد خرید";
                        btn_AddToShopCart_HostPortal_search.Font.Name = "tahoma";
                        btn_AddToShopCart_HostPortal_search.Click += new EventHandler(btn_AddToShopCart_Host_search_click);
                        phWin2_box1.Controls.Add(btn_AddToShopCart_HostPortal_search);

                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));

                        phWin2.Visible = false;
                        lbl.Visible = false;
                        btn_AddToShopCart_HostPortal_search.Visible = false;
                        ddlpaycycle.Visible = false;

                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));



                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));

                       // phWin2_box1.Visible = false;

                        //****************

                       

                        txt_domainPrefixSet.Width = 55;

                        phWin2_box2.Controls.Add(txt_domainPrefixSet);

                        phWin2_box2.Controls.Add(new LiteralControl(" . "));

                        txt_domainSet.Style.Add("direction", "ltr");
                        phWin2_box2.Controls.Add(txt_domainSet);

                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));
                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));

                        Button btn_AddToShopCart_HostPortal_dns = new Button();
                        btn_AddToShopCart_HostPortal_dns.Click += new EventHandler(btn_AddToShopCart_Host_dns_click);
                        btn_AddToShopCart_HostPortal_dns.Text = "اضافه به سبد خرید";
                        btn_AddToShopCart_HostPortal_dns.Font.Name = "tahoma";
                        phWin2_box2.Controls.Add(btn_AddToShopCart_HostPortal_dns);

                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));


                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));

                       
                        //***************************

                        phWin2.Controls.Add(phWin2_box1);

                        phWin2_box2.Visible = false;
                        phWin2.Controls.Add(phWin2_box2);
                                         
                        phWin2.Controls.Add(new LiteralControl("</div>"));

                        phHost.Controls.Add(phWin2);

                        pAddedShopCart.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                        "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));

                        phHost.Controls.Add(pAddedShopCart);

                        pAddedShopCart.Visible = false;

                        up.ContentTemplateContainer.Controls.Add(phHost);

                        return up;

                    }

                    public Control ContentHeaderChildPortal()
                    {
                        PlaceHolder phHost = new PlaceHolder();





                        UpdatePanel up = new UpdatePanel();
                        UpdateProgress alp = new UpdateProgress();
                        alp.Controls.Add(new LiteralControl("<img alt=\"loading...\" src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "RadControls/Ajax/Skins/Default/Loading1.gif\" />"));

                        //if (this.Page.IsPostBack == false)
                        // {

                        alp.AssociatedUpdatePanelID = up.ClientID;
                        // }
                        phHost.Controls.Add(alp);


                        catid = khatam.core.data.sql.getField("id", "id_content", contentId, "type_content", contentTable, "cat");

                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();



                        phWin1.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;overflow:hidden;;margin-left:10px\">"));

                        // if (!khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
                        if (true)
                        {
                            /* DataTable dt = new DataTable();
                             string sql_str = "SELECT     min, price, catId   FROM         core_sale_terms   WHERE     (catId = " + catid + " ) AND (min =      (SELECT     MIN(min) AS Expr1          FROM         core_sale_terms AS core_sale_terms_1))";

                             dt = DBFunctions.ExecuteReader(sql_str, parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                             price_in_rls = dt.Rows[0].ItemArray[1].ToString();
                             min = dt.Rows[0].ItemArray[0].ToString();*/

                            //side right
                            DataTable dt2 = new DataTable();
                            dt2 = getPayCylces(catid);
                            phWin1.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;  float:right; width:200px ;margin-left:10px\">"));

                            string setupPrice = khatam.core.data.sql.getField("setupPrice", "id", contentId , "portal");


                            phWin1.Controls.Add(new LiteralControl("<span class=\"desc2\"> راه اندازی اولیه :<span class=\"spanPrice\"> " +
                             Persia.Number.ConvertToPersian(setupPrice  + " </span> ریال </span></br> ")));

                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                int month = int.Parse(dt2.Rows[i].ItemArray[0].ToString());


                                if (month % 12 == 0)
                                {
                                    int year = month / 12;
                                    phWin1.Controls.Add(new LiteralControl("<span class=\"desc2\"> آبونمان " + year.ToString() + " سال " + " :<span class=\"spanPrice\"> " +
                                    Persia.Number.ConvertToPersian(dt2.Rows[i].ItemArray[1].ToString()) + " </span> ریال </span> "));
                                }
                                else
                                {
                                    phWin1.Controls.Add(new LiteralControl("<span class=\"desc2\"> آبونمان " + dt2.Rows[i].ItemArray[0].ToString() + " ماه " + " :<span class=\"spanPrice\"> " +
                                    Persia.Number.ConvertToPersian(dt2.Rows[i].ItemArray[1].ToString()) + " </span> ریال </span> "));
                                }

                                phWin1.Controls.Add(new LiteralControl("</br>"));
                            }


                            phWin1.Controls.Add(new LiteralControl("</div>"));

                            phWin1.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;float:right; width:200px ;margin-left:10px\">"));

                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));
                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));

                            pAddToShopCart.Controls.Add(ddl_payCycle);
                            ddl_payCycle.DataSource = khatam.core.UI.WebControls.domainSearchWin.getPaycycle_VProducts_Portal(catid,setupPrice );
                            ddl_payCycle.DataValueField = "id";
                            ddl_payCycle.DataTextField = "title";
                            ddl_payCycle.Font.Name = "tahoma";
                            ddl_payCycle.DataBind();



                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));

                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));

                            Button btn = new Button();
                            btn.Text = " سفارش خرید ";
                            btn.Font.Name = "tahoma";

                            btn.Click += new EventHandler(btnOrderPortal_host_Click);

                            pAddToShopCart.Controls.Add(btn);

                            //  pAddToShopCart.Controls.Add(ShopCartButton());


                            // pAddedShopCart.Visible = false;
                            // AjaxPanel.Controls.Add(pAddedShopCart);


                            phWin1.Controls.Add(pAddToShopCart);

                            // phWin1.Controls.Add(AjaxPanel);

                            phWin1.Controls.Add(new LiteralControl("</br>"));
                            phWin1.Controls.Add(new LiteralControl("</br>"));

                            phWin1.Controls.Add(new LiteralControl("</div>"));


                        }
                        //  ph.Controls.Add(new LiteralControl("<span class=\"desc2\">شیوه های ارسال / پرداخت:</span>     " + "</br>"));

                        //    ph.Controls.Add(new LiteralControl("<img src=\"" +
                        //  khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                        //    + "theme/Flowhub/CssImage/btn/iranmc.png\" />"));
                        //  ph.Controls.Add(new LiteralControl("</br>"));
                        //###   }
                        //###}

                        /*  string YahooID = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "YahooID", "id", contentId, contentTable);
                          if (YahooID != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\"> یاهو آیدی فروشنده : " + khatam.core.strings.Messenger.Gen_Yahoo_Status(YahooID, 1) + " </span>     " + "</br>"));

                          string shopAssistantTel = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantTel", "id", contentId, contentTable);
                          if (shopAssistantTel != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">تلفن فروشنده: " + shopAssistantTel + " </span>     " + "</br>"));

                          string shopAssistantMobile = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantMobile", "id", contentId, contentTable);
                          if (shopAssistantMobile != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">تلفن همراه فروشنده: " + shopAssistantMobile + " </span>     " + "</br>"));

                          string shopAssistantEmail = khatam.core.data.sql.getField("ContentHeaderChildLibrary", "shopAssistantEmail", "id", contentId, contentTable);
                          if (shopAssistantEmail != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">ایمیل فروشنده: " + shopAssistantEmail + " </span>     " + "</br>"));
                          */
                        phWin1.Controls.Add(new LiteralControl("</div>"));

                        phHost.Controls.Add(phWin1);

                        phWin2.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;overflow:hidden;;margin-left:10px\">"));
                        phWin2.Controls.Add(new LiteralControl("کالا/سرویسی که انتخاب نموده اید نیاز به نام دامین دارد پس لطفا نام دامین انتخابی خود را در زیر وارد کنید:"));
                        phWin2.Controls.Add(new LiteralControl("</br>"));


                        RadioButtonList rbl = new RadioButtonList();


                        rbl.AutoPostBack = true;
                        rbl.ID = "rblID";



                        // Wire up the eventhandler 
                        rbl.SelectedIndexChanged += new EventHandler(rbl_SelectedIndexChanged);


                        // Add the items 
                        rbl.Items.Add(new ListItem("می خواهم دامین جدید ثبت کنم", "1"));
                        rbl.Items.Add(new ListItem("دامین فعال دارم و DNS های شما را روی دامینم تنظیم خواهم کرد", "2"));

                        rbl.Items[0].Selected = true;


                        rbl.DataBind();


                        phWin2.Controls.Add(rbl);


                        /*RadioButton rb1 = new RadioButton();
                       // rb1.CheckedChanged
                        rb1.Text = "می خواهم دومین جدید ثبت کنم ";
                        rb1.Checked = true;
                        rb1.GroupName = "domain";
                        rb1.CheckedChanged += new EventHandler(rb1_Click);
                        rb1.AutoPostBack = true;
                        phWin2.Controls.Add(rb1);

                        phWin2.Controls.Add(new LiteralControl("</br>"));

                        RadioButton rb2 = new RadioButton();
                        rb2.Text = "دومین فعال دارم و DNS های شما را روی دومینم تنظیم خواهم کرد";
                        rb2.Checked = false;
                      
                        rb2.GroupName = "domain";
                        phWin2.Controls.Add(rb2);*/

                        phWin2.Controls.Add(new LiteralControl("</br>"));
                        //****************

                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));


                        ddlDomainPrefix.DataValueField = "title";
                        ddlDomainPrefix.DataTextField = "title";
                        ddlDomainPrefix.Font.Name = "tahoma";
                        ddlDomainPrefix.Font.Size = 9;
                        ddlDomainPrefix.Width = 55;
                        ddlDomainPrefix.DataSource = khatam.core.UI.WebControls.domainSearchWin.getDomains();
                        ddlDomainPrefix.DataBind();
                        phWin2_box1.Controls.Add(ddlDomainPrefix);


                        phWin2_box1.Controls.Add(new LiteralControl(" . "));



                        txt_domainReg.Style.Add("direction", "ltr");

                        phWin2_box1.Controls.Add(txt_domainReg);



                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));

                        Button btn1 = new Button();
                        btn1.ID = "btn1";
                        btn1.Text = "جستجو";
                        btn1.Font.Name = "tahoma";
                        // btn1.ValidationGroup = "domainSearchWin";
                        btn1.Click += new EventHandler(btn_ChekDomain_Click);

                        phWin2_box1.Controls.Add(btn1);
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));


                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));

                        phWin2_box1.Controls.Add(lbl);

                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));

                        ddlpaycycle.DataValueField = "id";
                        ddlpaycycle.DataTextField = "title";
                        ddlpaycycle.Font.Name = "tahoma";

                        // ddlpaycycle.DataSource = getPaycycle(ddlDomainPrefix.SelectedValue);
                        //ddlpaycycle.DataBind();

                        phWin2_box1.Controls.Add(ddlpaycycle);

                        /*   GridView gv = new GridView();
                           gv.DataSource = getPaycycle(ddlDomainPrefix.SelectedValue);
                           gv.AutoGenerateColumns = true;
                           gv.DataBind();
                           PaneldomainAvailable.Controls.Add(gv);
                           PaneldomainAvailable.Controls.Add(new LiteralControl("test"));*/

                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));
                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));


                        btn_AddToShopCart_HostPortal_search.Text = "اضافه به سبد خرید";
                        btn_AddToShopCart_HostPortal_search.Font.Name = "tahoma";
                        btn_AddToShopCart_HostPortal_search.Click += new EventHandler(btn_AddToShopCart_Portal_search_click);
                        phWin2_box1.Controls.Add(btn_AddToShopCart_HostPortal_search);

                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));

                        phWin2.Visible = false;
                        lbl.Visible = false;
                        btn_AddToShopCart_HostPortal_search.Visible = false;
                        ddlpaycycle.Visible = false;

                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));
                        phWin2_box1.Controls.Add(new LiteralControl("<br/>"));



                        phWin2_box1.Controls.Add(new LiteralControl("</br>"));

                        // phWin2_box1.Visible = false;

                        //****************



                        txt_domainPrefixSet.Width = 55;

                        phWin2_box2.Controls.Add(txt_domainPrefixSet);

                        phWin2_box2.Controls.Add(new LiteralControl(" . "));

                        TextBox txt_domainSet = new TextBox();
                        txt_domainSet.Style.Add("direction", "ltr");
                        phWin2_box2.Controls.Add(txt_domainSet);

                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));
                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));

                        Button btn_AddToShopCart_HostPortal_dns = new Button();
                        btn_AddToShopCart_HostPortal_dns.Click += new EventHandler(btn_AddToShopCart_Portal_dns_click);
                        btn_AddToShopCart_HostPortal_dns.Text = "اضافه به سبد خرید";
                        btn_AddToShopCart_HostPortal_dns.Font.Name = "tahoma";
                        phWin2_box2.Controls.Add(btn_AddToShopCart_HostPortal_dns);

                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));


                        phWin2_box2.Controls.Add(new LiteralControl("</br>"));


                        //***************************

                        phWin2.Controls.Add(phWin2_box1);

                        phWin2_box2.Visible = false;
                        phWin2.Controls.Add(phWin2_box2);

                        phWin2.Controls.Add(new LiteralControl("</div>"));

                        phHost.Controls.Add(phWin2);

                        pAddedShopCart.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                        "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));

                        phHost.Controls.Add(pAddedShopCart);

                        pAddedShopCart.Visible = false;

                        up.ContentTemplateContainer.Controls.Add(phHost);

                        return up;

                    }

                    public Control ContentHeaderChildLink()
                    {
                        PlaceHolder phLink = new PlaceHolder();

                        string link1= khatam.core.data.sql.getField( "link1", "id", contentId, "link");

                       

                        phLink.Controls.Add(new LiteralControl("<h2>" +  "<a href=\"" + link1  + "\">"  + ci.title  + "</a>"    + "</h2>"));

                        
                        phLink.Controls.Add(new LiteralControl("<span dir=\"ltr\"><h2>" + "<a href=\"" + link1 + "\">" + link1  + "</a>" + "</h2></span>"));

                        return phLink;
                    }


                    public Control ContentHeaderChildLibrary()
                    {

                        PlaceHolder ph = new PlaceHolder();

                      //  ph.Controls.Add(new LiteralControl("<span class=\"desc2\">نویسنده کتاب: ddddddddddddd </span>     " + "</br>"));
                        //string authe = khatam.core.data.sql.getField("ContentListHeader", "price_in_rls", "id", contentId, contentTable);


                        string author_book = khatam.core.data.sql.getField("author_book", "id", contentId, contentTable);
                        if (author_book != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">نویسنده کتاب: " + author_book + " </span>     " + "</br>"));

                        string translator = khatam.core.data.sql.getField( "translator", "id", contentId, contentTable);
                        if (translator != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">مترجم: " + translator + " </span>     " + "</br>"));

                        string isbn = khatam.core.data.sql.getField( "isbn", "id", contentId, contentTable);
                        if (isbn != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">شابک: " + isbn + " </span>     " + "</br>"));

                        string Password = khatam.core.data.sql.getField( "Password", "id", contentId, contentTable);
                        if (Password != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">پسورد: " + Password + " </span>     " + "</br>"));


                        ph.Controls.Add(new LiteralControl("</br>"));

                        string link1 = khatam.core.data.sql.getField( "link1", "id", contentId, contentTable);


                        if (link1 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link1 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 1"));
                            ph.Controls.Add(new LiteralControl("</a>"));
                        }


                        string link2 = khatam.core.data.sql.getField( "link2", "id", contentId, contentTable);

                        if (link2 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link2 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 2"));
                            ph.Controls.Add(new LiteralControl("</a>"));

                        }

                        string fileDL = khatam.core.data.sql.getField( "fileDL", "id", contentId, contentTable);

                        if (fileDL != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));

                            string directLink = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +

                                @"manage\upload\content\" + contentTable + @"\DL\" + fileDL;
                            ph.Controls.Add(new LiteralControl("<a href=\"" + directLink + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود مستقیم"));
                            ph.Controls.Add(new LiteralControl("</a>"));
                        }

                        return ph;

                    }

                    public Control ContentHeaderChildEstate()
                    {

                        PlaceHolder ph = new PlaceHolder();

                        //  ph.Controls.Add(new LiteralControl("<span class=\"desc2\">نویسنده کتاب: ddddddddddddd </span>     " + "</br>"));
                        //string authe = khatam.core.data.sql.getField("ContentListHeader", "price_in_rls", "id", contentId, contentTable);


                        /*  string author_book = khatam.core.data.sql.getField("author_book", "id", contentId, contentTable);
                          if (author_book != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">نویسنده کتاب: " + author_book + " </span>     " + "</br>"));

                          string translator = khatam.core.data.sql.getField("translator", "id", contentId, contentTable);
                          if (translator != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">مترجم: " + translator + " </span>     " + "</br>"));

                          string isbn = khatam.core.data.sql.getField("isbn", "id", contentId, contentTable);
                          if (isbn != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">شابک: " + isbn + " </span>     " + "</br>"));
                          */
                        string str_tourFileName = khatam.core.data.sql.getField("tourFileName", "id", contentId, contentTable);


                        if ((str_tourFileName != null) && (str_tourFileName != "") && (str_tourFileName != "-1"))
                        {
                            ph.Controls.Add(new LiteralControl("<a  href=\"#\" onClick=\"javascript:window.open('" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "Manage/upload/Content/estate/tour/" + contentId + "/_flash/" + str_tourFileName + "','_blank','status=yes,resizable=yes,top=0,left=0');\"><img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                           "core/themeCP/Bitrix/CssImage/btn/stateVitualTour.gif\" /></a>"));
                            ph.Controls.Add(new LiteralControl("</br>"));
                        }
                         

                        return ph;

                    }

                    public Control ContentHeaderChildSoftware()
                    {

                        PlaceHolder ph = new PlaceHolder();


                        //string authe = khatam.core.data.sql.getField("ContentListHeader", "price_in_rls", "id", contentId, contentTable);



                        string Password = khatam.core.data.sql.getField( "Password", "id", contentId, contentTable);
                        if (Password != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">پسورد: " + Password + " </span>     " + "</br>"));

                        string sitebuilder = khatam.core.data.sql.getField( "sitebuilder", "id", contentId, contentTable);
                        if (sitebuilder != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">سایت سازنده: " + sitebuilder + " </span>     " + "</br>"));


                        ph.Controls.Add(new LiteralControl("</br>"));

                        string link1 = khatam.core.data.sql.getField( "link1", "id", contentId, contentTable);


                        if (link1 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link1 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 1"));
                            ph.Controls.Add(new LiteralControl("</a>"));
                        }


                        string link2 = khatam.core.data.sql.getField( "link2", "id", contentId, contentTable);

                        if (link2 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link2 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 2"));
                            ph.Controls.Add(new LiteralControl("</a>"));

                        }

                        string link3 = khatam.core.data.sql.getField( "link3", "id", contentId, contentTable);

                        if (link3 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link3 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 2"));
                            ph.Controls.Add(new LiteralControl("</a>"));

                        }


                        string crack1 = khatam.core.data.sql.getField( "crack1", "id", contentId, contentTable);

                        if (crack1 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + crack1 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک کرک 1"));
                            ph.Controls.Add(new LiteralControl("</a>"));

                        }


                        string crack2 = khatam.core.data.sql.getField( "crack2", "id", contentId, contentTable);

                        if (crack2 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + crack2 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک کرک 2"));
                            ph.Controls.Add(new LiteralControl("</a>"));

                        }

                        string fileDL = khatam.core.data.sql.getField( "fileDL", "id", contentId, contentTable);

                        if (fileDL != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));

                            string directLink = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +

                                @"manage\upload\content\" + contentTable + @"\DL\" + fileDL;
                            ph.Controls.Add(new LiteralControl("<a href=\"" + directLink + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود مستقیم"));
                            ph.Controls.Add(new LiteralControl("</a>"));
                        }

                        return ph;

                    }

                    public Control ContentHeaderChildClip()
                    {

                        PlaceHolder ph = new PlaceHolder();


                        //string authe = khatam.core.data.sql.getField("ContentListHeader", "price_in_rls", "id", contentId, contentTable);



                        string Password = khatam.core.data.sql.getField( "Password", "id", contentId, contentTable);
                        if (Password != "") ph.Controls.Add(new LiteralControl("<span class=\"desc2\">پسورد: " + Password + " </span>     " + "</br>"));


                        ph.Controls.Add(new LiteralControl("</br>"));

                        string link1 = khatam.core.data.sql.getField( "link1", "id", contentId, contentTable);


                        if (link1 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link1 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 1"));
                            ph.Controls.Add(new LiteralControl("</a>"));
                        }


                        string link2 = khatam.core.data.sql.getField( "link2", "id", contentId, contentTable);

                        if (link2 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link2 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 2"));
                            ph.Controls.Add(new LiteralControl("</a>"));

                        }

                        string link3 = khatam.core.data.sql.getField( "link3", "id", contentId, contentTable);

                        if (link3 != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));
                            ph.Controls.Add(new LiteralControl("<a href=\"" + link3 + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود 2"));
                            ph.Controls.Add(new LiteralControl("</a>"));

                        }




                        string fileDL = khatam.core.data.sql.getField( "fileDL", "id", contentId, contentTable);

                        if (fileDL != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));

                            string directLink = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +

                                @"manage\upload\content\" + contentTable + @"\DL\" + fileDL;
                            ph.Controls.Add(new LiteralControl("<a href=\"" + directLink + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود مستقیم"));
                            ph.Controls.Add(new LiteralControl("</a>"));
                        }

                        return ph;

                    }

                    public Control ContentHeaderChildPicture()
                    {

                        PlaceHolder ph = new PlaceHolder();


                        string fileDL = khatam.core.data.sql.getField("fileDL", "id", contentId, contentTable);

                        if (fileDL != "")
                        {
                            ph.Controls.Add(new LiteralControl("</br>"));

                            string directLink = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +

                                @"manage\upload\content\" + contentTable + @"\DL\" + fileDL;
                            ph.Controls.Add(new LiteralControl("<a href=\"" + directLink + "\" class=\"public_Link\">"));
                            ph.Controls.Add(new LiteralControl("<img src=\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "theme/Flowhub/CssImage/btn/dlShuttleCock16.png\" class=\"imgAlpha\" />  "));
                            ph.Controls.Add(new LiteralControl("لینک دانلود مستقیم"));
                            ph.Controls.Add(new LiteralControl("</a>"));
                        }

                        return ph;

                    }

                    public Control ContentFooterChildEstate()
                    {

                        khatam.estate.estateItem _estateItem = new khatam.estate.estateItem();
                        _estateItem = khatam.estate.getEstate(contentId );

                        PlaceHolder ph = new PlaceHolder();

                        string html2 = " <div style=\"width:500px\">"
+ " <div style=\"width:100%\">"
+ " <h2><img src=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath  + "core/themeCP/Bitrix/CssImage/icon/icon_package.gif\" alt=\"\">ویژگی ها</h2>"
+ " </div>"


+ rowGenerator("انباری",_estateItem.anbari    )
+ rowGenerator("بالکن",_estateItem.balkon  )
+ rowGenerator("آشپزخانه اپن",_estateItem.OpenKitchen  )
+ rowGenerator("شومینه",_estateItem.shoomine  )
+ rowGenerator("شوفاژ",_estateItem.shofazh  )
+ rowGenerator("چیلر",_estateItem.chiler  )
+ rowGenerator("فن کوئل",_estateItem.FanCoil  )
+ rowGenerator("پکیج",_estateItem.package  )
+ rowGenerator("کولر",_estateItem.cooler  )
+ rowGenerator("استخر",_estateItem.pool  )
+ rowGenerator("سونا",_estateItem.Sauna  )
+ rowGenerator("جکوزی",_estateItem.Jacuzzi  )
+ rowGenerator("آسانسور",_estateItem.Elevator  )
+ rowGenerator("باربیکیو",_estateItem.Barbecue  )
+ rowGenerator("آیفون تصویری",_estateItem.VideoIPhone  )
+ rowGenerator("دوربین مدار بسته",_estateItem.CCTV  )
+ rowGenerator("درب ریموت دار",_estateItem.RemoteDoor  )
+ rowGenerator("آنتن مرکزی",_estateItem.CentralAntenna  )
+ rowGenerator("اینترنت مرکزی",_estateItem.CentralInternet  )
+ rowGenerator("حیاط خلوت",_estateItem.Backyard  )
+ rowGenerator("فضای سبز",_estateItem.Landscape  )
+ rowGenerator("لابی",_estateItem.Lobby  )
+ rowGenerator("سالن اجتماعات",_estateItem.communitiesHall  )
+ rowGenerator("سرایداری",_estateItem.watchMan  )
+ rowGenerator("پاسیو",_estateItem.Patio  )
+ rowGenerator("اطفاء حریق",_estateItem.FireFighting   )
+ rowGenerator("شوتینگ زباله",_estateItem.wasteShoting   )
+ "  <div style=\"clear:both \"></div>"
+ " </div>";
                        ph.Controls.Add(new LiteralControl(html2));
                       
                        return ph;

                    }

                    public string rowGenerator(string  title ,  object value)
                    {
                       string row="";

                       if (value!= null )
                       {
                           if (bool.Parse(value.ToString()) == true)
                           {
                               row = " <div id=\"row\" style=\"width:100%\">"
                               + " <div style=\"width:400px; float:right \">"
                               + title.ToString()
                               + " </div>"
                               + " <div style=\"width:100px;float:right\">"
                               + " <img src=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/check_green.gif\" alt=\"\">"
                               + " </div>"
                               + " </div> ";
                           }
                       }
                        return row;
                    }

                    protected void btnAddSave_Click(object sender, EventArgs e)
                    {
                        Page.Validate("Add");

                        if (Page.IsValid)
                        {
                            //Names.Add(Guid.NewGuid(), txtNewName.Text);
                            //LoadNames();
                            CloseDialog("newPerson" + instanceID);

                            //reset
                            ///txtNewName.Text = string.Empty;

                            khatam.core.data.sql.InstanceValSet(instanceID, "title", txtBoxValue2);








                            //fck.ID = "fck" + instanceID;

                            System.Web.UI.HtmlControls.HtmlInputText tbb = new System.Web.UI.HtmlControls.HtmlInputText();

                            //tbb = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("Text1" + instanceID );

                            khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);

                            Page.Response.Redirect(Page.Request.Url.PathAndQuery);
                            //refresh grid
                            //upGrid.Update();
                        }
                    }

                    private void CloseDialog(string dialogId)
                    {
                        string script = string.Format(@"closeDialog('{0}')", dialogId);
                        ///ScriptManager.RegisterClientScriptBlock(this, typeof(Page), UniqueID, script, true);
                    }


                    public string addInstanceProperty(string Instance)
                    {

                        // khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان");
                        // khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا");
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }


                    #region Events



                    public void btnShopCart_Click(object sender, EventArgs e)
                    {

                        //khatam.shop.shopCart.AddToShopCart(contentId, int.Parse(txtQ.Text), this.Page, catid,0,null);
                        khatam.shop.shopCart.AddToShopCart(catid, int.Parse(txtQ.Text), 0, null, "");
                        pAddedShopCart.Visible = true;
                        pAddToShopCart.Visible = false;
                    }


                    public void btnOrderPortal_host_Click(object sender, EventArgs e)
                    {

                        //khatam.shop.shopCart.AddToShopCart(contentId, int.Parse(txtQ.Text), this.Page, catid,0,null);
                       // khatam.shop.shopCart.AddToShopCart(contentId, 1, this.Page, catid, 0, null);
                      //  pAddedShopCart.Visible = true;
                      //  pAddToShopCart.Visible = false;
                        phWin2.Visible = true;
                        phWin1.Visible =false;
                    }


                    public void btnShopCart_Host_Click(object sender, EventArgs e)
                    {

                        //khatam.shop.shopCart.AddToShopCart(contentId, int.Parse(txtQ.Text), this.Page, catid,0,null);
                        khatam.shop.shopCart.AddToShopCart(catid, 1 , 0, null,"domainname");
                        pAddedShopCart.Visible = true;
                        pAddToShopCart.Visible = false;
                    }

                    public void btnOkQ_Click(object sender, EventArgs e)
                    {

                        this.Page.Response.Redirect("http://www.google.com");
                    }


                    public void btn_AddToShopCart_Host_search_click(object sender, EventArgs e)
                    {
                        
                    
                        //lbl.Visible = true;
                        //lbl.Text = "search";


                        string title_invoice;
                        title_invoice = "ثبت نام دامنه " + txt_domainReg.Text + "." + ddlDomainPrefix.Text + " " + ddlpaycycle.SelectedItem.Text;
                        title_invoice = Persia.Number.ConvertToPersian(title_invoice);
                       // khatam.shop.shopCart.AddToShopCart("10", 1, this.Page, "2079", int.Parse(ddlpaycycle.SelectedValue), title_invoice, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);

                        string catid2= khatam.core.data.sql.getField("id", "cname", ddlDomainPrefix.SelectedItem.Text, "cat");

                        khatam.shop.shopCart.AddToShopCart(catid2, 1 ,int.Parse( ddlpaycycle.SelectedValue), title_invoice, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);

                       
                        
                     
                        
                        string title_invoice_host;
                        title_invoice_host = ci.title + " | " + txt_domainReg.Text + "." + ddlDomainPrefix.Text + " " + ddl_payCycle.SelectedItem.Text;
                        title_invoice_host = Persia.Number.ConvertToPersian(title_invoice_host);


                        khatam.shop.shopCart.AddToShopCart(catid, 1, int.Parse(ddl_payCycle.SelectedValue), title_invoice_host, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);

                       //khatam.shop.shopCart.AddToShopCart("10", 1, this.Page, "2070", int.Parse(ddlpaycycle.SelectedValue), title_invoice, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);

                       
                       //contentId.ToString(),1, this.Page, catid.ToString(),int.Parse( ddl_payCycle.SelectedValue), txt_domainReg);

                        pAddedShopCart.Visible = true;
                        phWin1.Visible = false;
                        phWin2.Visible = false;
                    }

                    public void btn_AddToShopCart_Portal_search_click(object sender, EventArgs e)
                    {


                        //lbl.Visible = true;
                        //lbl.Text = "search";


                        string title_invoice;
                        title_invoice = "ثبت نام دامنه " + txt_domainReg.Text + "." + ddlDomainPrefix.Text + " " + ddlpaycycle.SelectedItem.Text;
                        title_invoice = Persia.Number.ConvertToPersian(title_invoice);
                        // khatam.shop.shopCart.AddToShopCart("10", 1, this.Page, "2079", int.Parse(ddlpaycycle.SelectedValue), title_invoice, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);

                        
                        string catid2 = khatam.core.data.sql.getField( "id", "cname", ddlDomainPrefix.SelectedItem.Text, "cat");

                        khatam.shop.shopCart.AddToShopCart(catid2, 1, int.Parse(ddlpaycycle.SelectedValue), title_invoice, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);





                       
                        string title_invoice_host;
                        string memo_invoice = khatam.core.data.sql.getField( "memo_invoice", "id", contentId, "portal");

                        title_invoice_host = ci.title + " | " + txt_domainSet.Text + "." + txt_domainPrefixSet.Text + " " + ddl_payCycle.SelectedItem.Text + " | " + memo_invoice;
                        title_invoice_host = Persia.Number.ConvertToPersian(title_invoice_host);




                        khatam.shop.shopCart.AddToShopCart(catid, 1, int.Parse(ddl_payCycle.SelectedValue), title_invoice_host, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);

                        //khatam.shop.shopCart.AddToShopCart("10", 1, this.Page, "2070", int.Parse(ddlpaycycle.SelectedValue), title_invoice, txt_domainReg.Text + "." + ddlDomainPrefix.SelectedItem.Text);


                        //contentId.ToString(),1, this.Page, catid.ToString(),int.Parse( ddl_payCycle.SelectedValue), txt_domainReg);

                        pAddedShopCart.Visible = true;
                        phWin1.Visible = false;
                        phWin2.Visible = false;
                    }




                    public void btn_AddToShopCart_Host_dns_click(object sender, EventArgs e)
                    {
                        pAddedShopCart.Visible = true;
                        phWin1.Visible = false;
                        phWin2.Visible = false;

                        string title_invoice_host;
                        title_invoice_host = ci.title + " | " + txt_domainSet.Text + "." + txt_domainPrefixSet.Text + " " + ddl_payCycle.SelectedItem.Text;
                        title_invoice_host = Persia.Number.ConvertToPersian(title_invoice_host);



                        khatam.shop.shopCart.AddToShopCart(catid, 1, int.Parse(ddl_payCycle.SelectedValue), title_invoice_host, txt_domainSet.Text + "." + txt_domainPrefixSet.Text);

                        //lbl.Visible = true;
                        //lbl.Text = "dns";
                    }

                    public void btn_AddToShopCart_Portal_dns_click(object sender, EventArgs e)
                    {
                        pAddedShopCart.Visible = true;
                        phWin1.Visible = false;
                        phWin2.Visible = false;

                        string title_invoice_host;
                        string memo_invoice = khatam.core.data.sql.getField( "memo_invoice", "id", contentId, "portal");

                        title_invoice_host = ci.title +" | " + txt_domainSet.Text + "." + txt_domainPrefixSet.Text + " " + ddl_payCycle.SelectedItem.Text + " | " + memo_invoice  ;
                        title_invoice_host = Persia.Number.ConvertToPersian(title_invoice_host);


                        khatam.shop.shopCart.AddToShopCart(catid, 1, int.Parse(ddl_payCycle.SelectedValue), title_invoice_host, txt_domainSet.Text + "." + txt_domainPrefixSet.Text);

                        //lbl.Visible = true;
                        //lbl.Text = "dns";
                    }


                    void rbl_SelectedIndexChanged(object sender, EventArgs e)
                    {

                        lbl.Visible =false;
btn_AddToShopCart_HostPortal_search.Visible =false;
ddlpaycycle.Visible = false;

                        // Get the control and cast it to the 
                        // appropriate type. In our case a RadioButtonList. 
                        RadioButtonList c = (RadioButtonList)FindControl("rblID");

                        if (c.SelectedIndex == 0)
                        {
                            //Label1.Text = c.SelectedItem.Text;
                            phWin2_box1.Visible = true;
                            phWin2_box2.Visible = false;

                            
                        }
                        if (c.SelectedIndex == 1)
                        {
                            phWin2_box1.Visible = false;
                            phWin2_box2.Visible = true;

                        }

                    }

                    void btn_ChekDomain_Click(object sender, EventArgs e)
                    {
                       // phWin1.Visible = false;
                        //   if (SaveHandler2 != null)
                        //     SaveHandler2(this, e);

                        //   PanelWin.Controls.Clear(); 
                        if (khatam.domain.Manager.CheckAvailability(txt_domainReg.Text, ddlDomainPrefix.SelectedValue))
        
                        {
                            lbl.Text = "دامین " + txt_domainReg.Text + "." + ddlDomainPrefix.SelectedValue + " برای ثبت آزاد است.";

                            ddlpaycycle.DataSource =UI.WebControls.domainSearchWin.getPaycycle(ddlDomainPrefix.SelectedValue);
                            ddlpaycycle.DataBind();

                         //   PaneldomainAvailable.Visible = true;

                          
                        lbl.Visible=true;
                        btn_AddToShopCart_HostPortal_search.Visible = true;
                        ddlpaycycle.Visible = true;

                        }
                        else
                        {
                            lbl.Text = "متاسفانه دامین " + txt_domainReg.Text + "." + ddlDomainPrefix.SelectedValue + " قبلا ثبت گردیده است.";
                         //   PaneldomainAvailable.Visible = true;
                           
                         //   ddlpaycycle.Visible = false;
                            lbl.Visible = true;
                            btn_AddToShopCart_HostPortal_search.Visible = false;
                            ddlpaycycle.Visible = false;

                        }

                      //  pAddedShopCart.Visible = false;

                        //PanelWin.Controls.Add(new LiteralControl("sssssssssss"));

                    }



                    #endregion


                    #region Controls





                    public Control ShopCartButton()
                    {


                        PlaceHolder ph1 = new PlaceHolder();

                        //Button Btn1 = new Button();
                        //Btn1.Text = "اضافه به سبد خرید";
                        //Btn1.Width = 130;
                        //Btn1.ID = "btnGoto";

                        //Btn1.Click += new EventHandler(btnShopCart_Click);

                        //Btn1.Font.Name = "tahoma";
                        //ph1.Controls.Add(Btn1);

                        ImageButton Btn1 = new ImageButton();

                        Btn1.Click += new ImageClickEventHandler(btnShopCart_Click);
                        Btn1.CssClass = "imgAlpha";
                        Btn1.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                            "theme/Flowhub/CssImage/btn/btnShopCart.gif";

                        ph1.Controls.Add(Btn1);

                        return ph1;
                    }

     
                    #endregion

                }
            }
        }
    }
}
