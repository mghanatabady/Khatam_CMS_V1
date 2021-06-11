using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls ;


using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;


namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:domainSearchWin runat=server></{0}:domainSearchWin>")]
                public class domainSearchWin : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string windowsMode;
                    public string instanceID;
                    public Boolean winVisible;
                    public Boolean showPriceTable;

                    public string UserNameValue
                    {
                        get
                        {
                            TextBox text = (TextBox)this.FindControl("UserNameControl");

                            return text.Text;
                        }
                        set
                        {
                            TextBox text = (TextBox)this.FindControl("UserNameControl");

                            text.Text = value;
                        }
                    }

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


                    public Boolean showWin
                    {
                        get
                        {

                            Boolean s = (Boolean)ViewState["showWin"];
                            return s;


                        }

                        set
                        {
                            ViewState["showWin"] = value;
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


     



               




                    protected override void CreateChildControls()
                    {
                      if (editMode) this.Controls.Add(new LiteralControl("<div class=\"ve_div\">"));


                      if (editMode)
                      {
                          ImageButton btnEdit = new ImageButton();
                          btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                          btnEdit.OnClientClick = "child=window.open(\"" + 
                              khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath 
                              +  "editor.aspx?instanceID=" + instanceID + "&mode=23\",\"_blank\",\" scrollbars=yes, resizable=no, , width=825, height=600\",'child');return false;";
                          this.Controls.Add(btnEdit);
                      }
                         
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));
                        this.Controls.Add(new LiteralControl("<br/>"));


                        UpdatePanel up = new UpdatePanel();                      
                        UpdateProgress alp = new UpdateProgress();
                        alp.Controls.Add(new LiteralControl("<img alt=\"loading...\" src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "RadControls/Ajax/Skins/Default/Loading1.gif\" />"));

                        //if (this.Page.IsPostBack == false)
                        // {

                        alp.AssociatedUpdatePanelID = up.ClientID;
                        // }

                        this.Controls.Add(alp);

                        this.Controls.Add(new LiteralControl("<div style=\" text-align:center\" margin=\"auto\" >"));
                        up.ContentTemplateContainer.Controls.Add(DomainForm());

                        if (showPriceTable)
                        {
                            GridView gv = new GridView();
                            DataTable dt = new DataTable();
                            dt = getDomainsWithPrice();
                            dt.Columns[0].ColumnName = "نوع";
                            dt.Columns[2].ColumnName = "قیمت";
                            dt.Columns[1].ColumnName = "زمان";

                            gv.DataSource = dt;
                            gv.DataBind();



                            up.ContentTemplateContainer.Controls.Add(new LiteralControl("<center>"));

                            up.ContentTemplateContainer.Controls.Add(gv);
                            up.ContentTemplateContainer.Controls.Add(new LiteralControl("</center>"));
                        }
                        up.ContentTemplateContainer.Controls.Add(new LiteralControl("</div>"));



                        this.Controls.Add(up);

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));
                        
                    }

                    public static DataTable getDomainsWithPrice()
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        //parameters.Add("field_where_value", field_where_value);
                        str_sql = "SELECT    Cat.cname, N'مدت زمان:' + CAST(core_paycycle.month / 12 AS nvarchar) + N' سال ' AS month, CAST(core_paycycle.price AS nvarchar) + N' ریال' AS price   " +
                        " FROM         Cat INNER JOIN  " +
                        "                    core_paycycle ON Cat.id = core_paycycle.catId   " +
                        " WHERE     (Cat.type_content = N'domain') AND (core_paycycle.month % 12 = 0)  " +
                        " ORDER BY Cat.cname, month";
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    }
                   

                    Panel pDomainSearch = new Panel();

                    Panel pDomainNotAvailabe = new Panel();

                    TextBox tbDomain = new TextBox();

                    TextBox tbDomainName = new TextBox();

                    Label LblResult = new Label();
                    Panel PaneldomainAvailable = new Panel();
                    DropDownList ddlDomainPrefix = new DropDownList();

                    DropDownList ddlpaycycle = new DropDownList();

                    Label lbl = new Label();

                    Panel pAddedShopCart = new Panel();

                    Button btnNeedLogin = new Button(); Button btnRegOrder = new Button();


                    public Control DomainForm()
                    {




                        PlaceHolder ph = new PlaceHolder();



                    //    RadioButton rb = new RadioButton();
                    //    rb.GroupName = "a";
                    //   rb.Text = "ثبت نام دامنه جدید";
                    //   rb.Checked = true;
                    //    ph.Controls.Add(rb);
                    //    ph.Controls.Add(new LiteralControl("<br/>"));

                    //    RadioButton rb2 = new RadioButton();
                    //    rb2.Text = "انتقال نام دامنه برای نگهداری توسط ما";
                    //    rb2.GroupName = "a";
                    //    ph.Controls.Add(rb2);
                    //    ph.Controls.Add(new LiteralControl("<br/>"));
                    //    ph.Controls.Add(new LiteralControl("<br/>"));


                     //   ph.Controls.Add(new LiteralControl(" نام دامنه "));

                        RequiredFieldValidator rfvtbDomainName = new RequiredFieldValidator();
                        rfvtbDomainName.ControlToValidate = "tbDomainName";
                        rfvtbDomainName.Text = "*";
                        rfvtbDomainName.ValidationGroup = "domainSearchWin";
                        ph.Controls.Add(rfvtbDomainName);


                        tbDomainName.Font.Name = "tahoma";
                        tbDomainName.ID = "tbDomainName";
                        tbDomainName.Width=120;
                        ph.Controls.Add(tbDomainName);


                        ph.Controls.Add(new LiteralControl(" "));


                        ddlDomainPrefix.DataValueField = "id";
                        ddlDomainPrefix.DataTextField = "title";
                        ddlDomainPrefix.Font.Name = "tahoma";
                        ddlDomainPrefix.Font.Size = 9;
                        ddlDomainPrefix.DataSource = getDomains();
                        ddlDomainPrefix.DataBind();
                        ph.Controls.Add(ddlDomainPrefix);




                        ph.Controls.Add(new LiteralControl("<br/>"));
                        ph.Controls.Add(new LiteralControl("<br/>"));

                        Button btn1 = new Button();
                        btn1.ID = "btn1";
                        btn1.Text = "جستجو";
                        btn1.Font.Name = "tahoma";
                        btn1.ValidationGroup = "domainSearchWin";
                        btn1.Click += new EventHandler(btn_ChekDomain_Click);

                        ph.Controls.Add(btn1);
                        ph.Controls.Add(new LiteralControl("<br/>"));
                        ph.Controls.Add(new LiteralControl("<br/>"));


                        //******* PaneldomainAvailable
                        //PaneldomainAvailable.Controls.Add(new LiteralControl("<br/>"));
                        PaneldomainAvailable.Controls.Add(new LiteralControl("<br/>"));

                        PaneldomainAvailable.Controls.Add(lbl);

                        PaneldomainAvailable.Controls.Add(new LiteralControl("<br/>"));
                        PaneldomainAvailable.Controls.Add(new LiteralControl("<br/>"));

                        ddlpaycycle.DataValueField = "id";
                        ddlpaycycle.DataTextField = "title";
                        ddlpaycycle.Font.Name = "tahoma";

                        //ddlpaycycle.DataSource = getPaycycle(ddlDomainPrefix.SelectedValue);
                       // ddlpaycycle.DataBind();

                        PaneldomainAvailable.Controls.Add(ddlpaycycle);

                     /*   GridView gv = new GridView();
                        gv.DataSource = getPaycycle(ddlDomainPrefix.SelectedValue);
                        gv.AutoGenerateColumns = true;
                        gv.DataBind();
                        PaneldomainAvailable.Controls.Add(gv);
                        PaneldomainAvailable.Controls.Add(new LiteralControl("test"));*/


                        PaneldomainAvailable.Controls.Add(new LiteralControl("<br/>"));
                        PaneldomainAvailable.Controls.Add(new LiteralControl("<br/>"));

                        // khatam.core.Security..
                        btnNeedLogin.Visible = false;
                        btnRegOrder.Visible = false;

                        btnRegOrder.ID = "btnRegOrder";
                        btnRegOrder.Text = "اضافه به سبد خرید";
                        btnRegOrder.Font.Name = "tahoma";
                        btnRegOrder.Click += new EventHandler(btnRegOrder_Click);
                        PaneldomainAvailable.Controls.Add(btnRegOrder);


                        // up.Triggers.Add()

                      //  btnNeedLogin.ID = "btnNeedLogin";
                       // btnNeedLogin.Text = "اضافه به سبد خرید";
                       // btnNeedLogin.Font.Name = "tahoma";
                        //##btn2.Click += new EventHandler(btn_ChekDomain_Click);
                       // PaneldomainAvailable.Controls.Add(btnNeedLogin);





                        ph.Controls.Add(PaneldomainAvailable);
                        PaneldomainAvailable.Visible = false;



                        pAddedShopCart.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                         "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));

                                            

                        pAddedShopCart.Visible = false;
                        ph.Controls.Add(pAddedShopCart);


                        //  lw.ShowClicked 








                        return ph;

                    }

                    public static DataTable getDomains()
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        //parameters.Add("field_where_value", field_where_value);
                        str_sql = "SELECT  id,title FROM domain";
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    }

                    void btnRegOrder_Click(object sender, EventArgs e)
                    {
                        //string id = khatam.core.data.sql.getField("btnRegOrder_domain", "id", "title", ddlDomainPrefix.SelectedValue, "domain");

                        string title_invoice;
                        title_invoice = "ثبت نام دامنه " + tbDomainName.Text + "." + ddlDomainPrefix.SelectedItem.Text + " " + ddlpaycycle.SelectedItem.Text;
                        title_invoice = Persia.Number.ConvertToPersian(title_invoice);

                        string catid = 
                         khatam.core.data.sql.getField( "id", "id_content", ddlDomainPrefix.SelectedValue, "type_content","domain","cat");
                        //ddlDomainPrefix.SelectedValue

                        khatam.shop.shopCart.AddToShopCart(catid, 1, int.Parse(ddlpaycycle.SelectedValue), title_invoice, (tbDomainName.Text + "." + ddlDomainPrefix.SelectedItem.Text).ToString());

                        PaneldomainAvailable.Visible = false;
                        pAddedShopCart.Visible = true;
                        


                        string invoiceId;
                        string idRandom;
                        idRandom = khatam.core.Security.Users.MakePassword(4);



                        //invoiceId = invoiceAdd(0, 0, "1000", idRandom, false);

                      //  invoiceLineAdd(invoiceId, tbDomainName.Text, "1000");


                       // RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay/?id=" 
                           // + "&pass=" + idRandom);
                    }
                    private void RedirectTo(string url)
                    {
                        //url is in pattern "~myblog/mypage.aspx"
                        string redirectURL = Page.ResolveClientUrl(url);
                        string script = "window.location = '" + redirectURL + "';";
                        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
                    }

                    public static DataTable getPaycycle(string tlds)
                    {
                        string domainId;
                        domainId = khatam.core.data.sql.getField( "id", "cname", tlds, "type_content", "domain", "cat");

                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        //parameters.Add("field_where_value", field_where_value);
                        str_sql =

                           " SELECT  id ,  N'مدت زمان:' +  CAST( month /12  as nvarchar)  + N' سال '  +  CAST( price as nvarchar) + N' ریال '    as title  FROM core_paycycle where ((catId='" + domainId + "')and ((month %12) =0)) union  SELECT  id , N'مدت زمان:' + CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    + N' ریال '  as title  FROM core_paycycle where ((catId='" + domainId + "') and ((month %12) <>0)) ";

                            
                            //"SELECT  month as id, CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    as title  FROM core_paycycle where (catId='" + domainId + "')";
                        //str_sql = "SELECT  id, CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    as title  FROM core_paycycle where (catId='2092')";
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    }

                    public static DataTable getPaycycle_VProducts(string catid)
                    {
                        
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        //parameters.Add("field_where_value", field_where_value);
                        str_sql =

                           " SELECT  id ,  N'مدت زمان:' +  CAST( month /12  as nvarchar)  + N' سال '  +  CAST( price as nvarchar) + N' ریال '   as title  FROM core_paycycle where ((catId='" + catid + "')and ((month %12) =0)) union  SELECT  id , N'مدت زمان:' + CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    + N' ریال '  as title  FROM core_paycycle where ((catId='" + catid + "') and ((month %12) <>0)) ";


                        //"SELECT  month as id, CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    as title  FROM core_paycycle where (catId='" + domainId + "')";
                        //str_sql = "SELECT  id, CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    as title  FROM core_paycycle where (catId='2092')";
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    }

                    public static DataTable getPaycycle_VProducts_Portal(string catid, string setupPrice)
                    {

                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        //parameters.Add("field_where_value", field_where_value);
                        str_sql =

                           " SELECT  id ,  N'راه اندازی + آبونمان ' +  CAST( month /12  as nvarchar)  + N' سال '  +  CAST( price+" + setupPrice + " as nvarchar) + N' ریال '   as title  FROM core_paycycle where ((catId='" + catid + "')and ((month %12) =0)) union  SELECT  id , N'راه اندازی + آبونمان ' + CAST( month as nvarchar)  + N' ماه ' +  CAST(  price+" + setupPrice + " as nvarchar)    + N' ریال '  as title  FROM core_paycycle where ((catId='" + catid + "') and ((month %12) <>0)) ";


                        //"SELECT  month as id, CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    as title  FROM core_paycycle where (catId='" + domainId + "')";
                        //str_sql = "SELECT  id, CAST( month as nvarchar)  + N' ماه ' +  CAST( price as nvarchar)    as title  FROM core_paycycle where (catId='2092')";
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    }


                    void btn_ChekDomain_Click(object sender, EventArgs e)
                    {

                        //   if (SaveHandler2 != null)
                        //     SaveHandler2(this, e);

                        //   PanelWin.Controls.Clear(); 
                        if (khatam.domain.Manager.CheckAvailability(tbDomainName.Text, ddlDomainPrefix.SelectedItem.Text))
                        //if (1 == 1)
                        {
                            lbl.Text = "دامین " + tbDomainName.Text + "." + ddlDomainPrefix.SelectedItem.Text + " برای ثبت آزاد است.";

                            ddlpaycycle.DataSource = getPaycycle(ddlDomainPrefix.SelectedItem.Text);
                            ddlpaycycle.DataBind();

                            PaneldomainAvailable.Visible = true;
                            btnRegOrder.Visible = true;
                            ddlpaycycle.Visible = true;
                        }
                         else
                        {
                           lbl.Text = "متاسفانه دامین " + tbDomainName.Text + "." + ddlDomainPrefix.SelectedItem.Text + " قبلا ثبت گردیده است.";
                           PaneldomainAvailable.Visible = true;
                           btnRegOrder.Visible = false;
                           ddlpaycycle.Visible = false;
                        }

                        pAddedShopCart.Visible = false;
                   
                        //PanelWin.Controls.Add(new LiteralControl("sssssssssss"));

                    }


                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "جستجوی نام دامنه", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "showPriceTable", "false", "Core_serverControlsInstanceVal", null);



                        return "added";
                    }




                }
            }

        }
    }
}
