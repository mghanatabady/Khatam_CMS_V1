using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


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
                [ToolboxData("<{0}:estateSearchWin runat=server></{0}:estateSearchWin>")]
                public class estateSearchWin : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string windowsMode;
                    public string instanceID;
                    public Boolean winVisible;

                    public string tab1InstanceID;
                    public string tab2InstanceID;
                    public string tab3InstanceID;
                    public string tab4InstanceID;
                    public string tab5InstanceID;
                    public string tab6InstanceID;
                    public string tab7InstanceID;
                    public string tab8InstanceID;
                    public string tab9InstanceID;
                    public string tab10InstanceID;                   
                    public string ordering;


                    public string theme;

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
                              +  "editor.aspx?instanceID=" + instanceID + "&mode=28\",\"_blank\",\" scrollbars=yes, resizable=no, , width=890, height=600\",'child');return false;";
                          this.Controls.Add(btnEdit);
                      }
                         
                      //  this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                      //  this.Controls.Add(new LiteralControl(title));
                      //  this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                      //  this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                      //  this.Controls.Add(new LiteralControl(memo));



                        this.Controls.Add(new LiteralControl(" <div class=\"Otabs" + this.UniqueID  +  "\" >"));
           



                            this.Controls.Add(new LiteralControl("      <a href='#tab1" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl("خرید ملک"));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));



                            this.Controls.Add(new LiteralControl("      <a href='#tab2" + this.UniqueID + "'  >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl("رهن و اجاره"));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                       

                      
                        /*    this.Controls.Add(new LiteralControl("      <a href='#tab3" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl("درخواست های خرید"));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                    

                       
                            this.Controls.Add(new LiteralControl("      <a href='#tab4" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl("درخواست های رهن و اجاره"));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));*/
                        

                      

                        this.Controls.Add(new LiteralControl( " <div style=\"clear:both\"></div>"));
                        this.Controls.Add(new LiteralControl( " </div>"));

                    
                            this.Controls.Add(new LiteralControl(" <div id='tab1" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            this.Controls.Add(tab1());
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));                          

                        

                            this.Controls.Add(new LiteralControl(" <div id='tab2" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            this.Controls.Add(tab2());
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));

                            int agreement_type;

                            if (this.Page.Request.QueryString["agreement_type"] != null)
                            {
                                agreement_type = int.Parse(this.Page.Request.QueryString["agreement_type"]);
                            }
                            else
                            {
                                agreement_type = 1;
                            }


                        string html = " <script type=\"text/javascript\">"
                            + " $(document).ready(function () {"
                            + " $('.Otabs" + this.UniqueID + "').each(function () {"
                           // + " // For each set of tabs, we want to keep track of"
                         //   + " // which tab is active and it's associated content"
                            + " var $active, $content, $links = $(this).find('a');"
                        //    + " // If the location.hash matches one of the links, use that as the active tab."
                        //    + " // If no match is found, use the first link as the initial active tab."
                            + " $active = $($links.filter('[href=\"' + location.hash + '\"]')[0] || $links[" + (agreement_type -1).ToString() + "]);"
                            + " $active.addClass('active');"
                            + " $content = $($active.attr('href'));"
                      //      + " // Hide the remaining content"
                            + " $links.not($active).each(function () {"
                            + " $($(this).attr('href')).hide();"
                            + " });"
                        //    + " // Bind the click event handler"
                            + " $(this).on('click', 'a', function (e) {"
                          //  + " // Make the old tab inactive."
                //            + " //alert($(this).find('.winTabActive1t_tb').attr('class'));"
                  //          + " //$(this).find('.winTabActive1t_tb').removeClass();"
                            + " $active.removeClass('active');"
                            + " $content.hide();"
                    //        + " // Update the variables with the new link and content"
                            + " $active = $(this);"
                            + " $content = $($(this).attr('href'));"
                      //      + " // Make the tab active."
                            + " $active.addClass('active');"
                            + " $content.fadeIn();"
                        //    + " // Prevent the anchor's default click action"
                            + " e.preventDefault();"
                            + " });"
                            + " });"
                            + ""
                            + " });"
                            + " </script>";

                         this.Controls.Add(new LiteralControl(html ));


                   //     this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));

                    }

                    khatam.core.UI.baseControl.GeoSelector geo1 = new baseControl.GeoSelector();
                    DropDownList ddl_type1 = new DropDownList();
                    DropDownList ddl_metrazh1 = new DropDownList();
                    TextBox tb_buy_minPrice1 = new TextBox();
                    TextBox tb_buy_maxPrice1 = new TextBox();


                    private Control tab1()
                    {
                        //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                        //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                        //  string id_core_serverControl1 = khatam.core.data.sql.getField("none", "id_core_serverControl", "id", tab1InstanceID, "Core_serverControlsInstance");
                        //   this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl1, tab1InstanceID, "1", editMode, true, theme));
                        PlaceHolder ph = new PlaceHolder();

                        ph.Controls.Add(new LiteralControl("	<div class=\"searchEstateArea\">"));


                        geo1.ID ="geoTab1" + UniqueID;
                        geo1.ordering = ordering;


                        string fieldCssClass="";

                        if (ordering == "1") fieldCssClass = "field_horizontal";
                        if (ordering == "2") fieldCssClass = "field_vertical";

                 

                    

                      
                        geo1.searchAllMode = true ;
                        geo1.searchEstateMode   = true;


                        geo1.editMode = editMode ;
                        geo1.searchEstate_agreement_type = 1;
                        ph.Controls.Add(geo1);


                        /************************************/

                        ph.Controls.Add(new LiteralControl("<div class=\"search_rows\" >"));



                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                      //  ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">نوع ملک</div>" ) );
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">نوع ملک</div>"));

                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                        ddl_type1.DataSource = khatam.estate.getTableEstate_type();
                        ddl_type1.DataValueField = "id";
                        ddl_type1.DataTextField = "title";
                        ddl_type1.Font.Name = "tahoma";
                        
                        ddl_type1.DataBind();                   



                        ListItem li = new ListItem();
                        li.Text = "همه موارد";
                        li.Value = "all";
                        ddl_type1.Items.Insert(0,li);

                        ph.Controls.Add(ddl_type1);
                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">متراژ</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                        ddl_metrazh1.Font.Name = "tahoma";

                        ListItem li0 = new ListItem();
                        li0.Text = "همه موارد";
                        li0.Value = "all";
                        ddl_metrazh1.Items.Add(li0);

                        ListItem li1 = new ListItem();
                        li1.Text = "تا 100 متر";
                        li1.Value = "max100";
                        ddl_metrazh1.Items.Add(li1);

                        ListItem li2 = new ListItem();
                        li2.Text = "تا 150 متر";
                        li2.Value = "max150";
                        ddl_metrazh1.Items.Add(li2);

                        ListItem li3 = new ListItem();
                        li3.Text = "تا 200 متر";
                        li3.Value = "max200";
                        ddl_metrazh1.Items.Add(li3);

                        ListItem li4 = new ListItem();
                        li4.Text = "تا 1000 متر";
                        li4.Value = "max1000";
                        ddl_metrazh1.Items.Add(li4);

                        ListItem li5 = new ListItem();
                        li5.Text = "بیش از 1000 متر";
                        li5.Value = "min1000";
                        ddl_metrazh1.Items.Add(li5);

                        ph.Controls.Add(ddl_metrazh1);

                        

                  



                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">حداقل قیمت به ریال</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                   

                        tb_buy_minPrice1.Font.Name = "tahoma";
                        tb_buy_minPrice1.Text = "100000000";
                        tb_buy_minPrice1.Attributes.Add("onkeypress", "return isNumberKey(event)");

                    

                        ph.Controls.Add(tb_buy_minPrice1);
                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">حداکثر قیمت به ریال</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                        tb_buy_maxPrice1.Font.Name = "tahoma";
                        tb_buy_maxPrice1.Text = "10000000000";
                        tb_buy_maxPrice1.Attributes.Add("onkeypress", "return isNumberKey(event)");

                        ph.Controls.Add(tb_buy_maxPrice1);

             

                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));



                        ph.Controls.Add(new LiteralControl("	</div>"));


                        /***********************************/



                        ph.Controls.Add(new LiteralControl("<div class=\"search_rows\" style=\"margin-right:50px;margin-top:50px\">"));


                        //         this.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        //        this.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">کشور</div>"));
                        //        this.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));





                        ImageButton ibnt1 = new ImageButton();
                        ibnt1.ImageUrl = "theme/Flowhub/cssimage/btn/searchBtn.gif";
                        ibnt1.Click += new ImageClickEventHandler(btnSearch_Click);

                        ph.Controls.Add(ibnt1);





                        //    this.Controls.Add(new LiteralControl("ببببببب"));

                        //   this.Controls.Add(new LiteralControl("</div>"));
                        //    this.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("	</div>"));
                        ph.Controls.Add(new LiteralControl("	</div>"));


                        /**************************************/
                              int agreement_type;

                            if (this.Page.Request.QueryString["agreement_type"] != null)
                            {
                                agreement_type = int.Parse(this.Page.Request.QueryString["agreement_type"]);
                            }
                            else
                            {
                                agreement_type = 1;
                            }

                        if (agreement_type==1)
                        {
                        string qs_country = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["country"]);
                        if ((qs_country != null) && (qs_country != "all"))
                            geo1._geo.CountryId = int.Parse(qs_country);

                        string qs_state = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["state"]);
                        if ((qs_state != null) && (qs_state != "all"))
                            geo1._geo.EstateId = int.Parse(qs_state);

                        string qs_city = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["city"]);
                        if ((qs_city != null) && (qs_city != "all"))
                            geo1._geo.CityId = int.Parse(qs_city);

                        string qs_area = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["area"]);
                        if ((qs_area != null) && (qs_area != "all"))
                            geo1._geo.AreaId = int.Parse(qs_area);

                        string qs_type = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["type"]);
                        if ((qs_type != null) && (qs_type != "all"))
                            ddl_type1.SelectedValue = qs_type;

                        string qs_metrazhType = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["metrazhType"]);
                        if ((qs_metrazhType != null) && (qs_metrazhType != "all"))
                            ddl_metrazh1.SelectedValue = qs_metrazhType;

                        string qs_minTotalPrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["minTotalPrice"]);
                        if ((qs_minTotalPrice != null) && (qs_minTotalPrice != "all"))
                            tb_buy_minPrice1.Text = qs_minTotalPrice;

                        string qs_maxTotalPrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["maxTotalPrice"]);
                        if ((qs_maxTotalPrice != null) && (qs_maxTotalPrice != "all"))
                            tb_buy_maxPrice1.Text = qs_maxTotalPrice;
                   }
                        /**************************************/

                        return ph;
                    }

                    khatam.core.UI.baseControl.GeoSelector geo2 = new baseControl.GeoSelector();
                    DropDownList ddl_type2 = new DropDownList();
                    DropDownList ddl_metrazh2 = new DropDownList();
                    TextBox tb_maxVadiePrice = new TextBox();
                    TextBox tb_maxEjarePrice = new TextBox();


                    private Control tab2()
                    {
                        //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                        //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                        //  string id_core_serverControl1 = khatam.core.data.sql.getField("none", "id_core_serverControl", "id", tab1InstanceID, "Core_serverControlsInstance");
                        //   this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl1, tab1InstanceID, "1", editMode, true, theme));
                        

                        PlaceHolder ph = new PlaceHolder();
                       

                        ph.Controls.Add(new LiteralControl("	<div class=\"searchEstateArea\">"));

                        string fieldCssClass = "";

                        if (ordering == "1") fieldCssClass = "field_horizontal";
                        if (ordering == "2") fieldCssClass = "field_vertical";

                        geo2.ID = "geoTab2" + UniqueID;
                        geo2.ordering = ordering;

                        // geo._geo.CountryId = 104;
                        //  geo._geo.EstateId = 0;
                        //  geo._geo.CityId=  0;
                        ///  geo._geo.AreaId = 0;
                        geo2.searchAllMode = true;
                        geo2.searchEstateMode = true;
                        geo2.searchEstate_agreement_type = 2;
                        geo2.editMode = editMode  ;
                        ph.Controls.Add(geo2);


                        /************************************/

                        ph.Controls.Add(new LiteralControl("<div class=\"search_rows\" >"));


                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">نوع ملک</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                        ddl_type2.DataSource = khatam.estate.getTableEstate_type();
                        ddl_type2.DataValueField = "id";
                        ddl_type2.DataTextField = "title";
                        ddl_type2.Font.Name = "tahoma";
                        ddl_type2.DataBind();

                        ListItem li = new ListItem();
                        li.Text = "همه موارد";
                        li.Value = "all";
                        ddl_type2.Items.Insert(0, li);

                        ph.Controls.Add(ddl_type2);
                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">متراژ</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                        ddl_metrazh2.Font.Name = "tahoma";

                        ListItem li0 = new ListItem();
                        li0.Text = "همه موارد";
                        li0.Value = "all";
                        ddl_metrazh2.Items.Add(li0);

                        ListItem li1 = new ListItem();
                        li1.Text = "تا 100 متر";
                        li1.Value = "max100";
                        ddl_metrazh2.Items.Add(li1);

                        ListItem li2 = new ListItem();
                        li2.Text = "تا 150 متر";
                        li2.Value = "max150";
                        ddl_metrazh2.Items.Add(li2);

                        ListItem li3 = new ListItem();
                        li3.Text = "تا 200 متر";
                        li3.Value = "max200";
                        ddl_metrazh2.Items.Add(li3);

                        ListItem li4 = new ListItem();
                        li4.Text = "تا 1000 متر";
                        li4.Value = "max1000";
                        ddl_metrazh2.Items.Add(li4);

                        ListItem li5 = new ListItem();
                        li5.Text = "بیش از 1000 متر";
                        li5.Value = "min1000";
                        ddl_metrazh2.Items.Add(li5);

                        ph.Controls.Add(ddl_metrazh2);
                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">حداکثر ودیعه به ریال</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));


                        tb_maxVadiePrice.Font.Name = "tahoma";
                        tb_maxVadiePrice.Text = "100000000";
                        tb_maxVadiePrice.Attributes.Add("onkeypress", "return isNumberKey(event)");

                        ph.Controls.Add(tb_maxVadiePrice);
                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));

                        ph.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        ph.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">حداکثر اجاره به ریال</div>"));
                        ph.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));
                        tb_maxEjarePrice.Font.Name = "tahoma";
                        tb_maxEjarePrice.Text = "10000000";
                        tb_maxEjarePrice.Attributes.Add("onkeypress", "return isNumberKey(event)");

                        ph.Controls.Add(tb_maxEjarePrice);

                        ph.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("</div>"));



                        ph.Controls.Add(new LiteralControl("	</div>"));


                        /***********************************/



                        ph.Controls.Add(new LiteralControl("<div class=\"search_rows\" style=\"margin-right:50px;margin-top:50px\">"));


                        //         this.Controls.Add(new LiteralControl("<div class=\"row\">"));
                        //        this.Controls.Add(new LiteralControl("<div class=\"" + fieldCssClass  + "\">کشور</div>"));
                        //        this.Controls.Add(new LiteralControl("<div class=\"fieldInputArea\">"));





                        ImageButton ibnt1 = new ImageButton();
                        ibnt1.ImageUrl = "theme/Flowhub/cssimage/btn/searchBtn.gif";
                        ibnt1.Click += new ImageClickEventHandler(btnSearch2_Click);

                        ph.Controls.Add(ibnt1);





                        //    this.Controls.Add(new LiteralControl("ببببببب"));

                        //   this.Controls.Add(new LiteralControl("</div>"));
                        //    this.Controls.Add(new LiteralControl("</div>"));
                        ph.Controls.Add(new LiteralControl("	</div>"));
                        ph.Controls.Add(new LiteralControl("	</div>"));

                        /**************************************/
                              int agreement_type;

                            if (this.Page.Request.QueryString["agreement_type"] != null)
                            {
                                agreement_type = int.Parse(this.Page.Request.QueryString["agreement_type"]);
                            }
                            else
                            {
                                agreement_type = 1;
                            }
                        if (agreement_type == 2)
                        {
                            string qs_country = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["country"]);
                            if ((qs_country != null) && (qs_country != "all"))
                                geo2._geo.CountryId = int.Parse(qs_country);

                            string qs_state = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["state"]);
                            if ((qs_state != null) && (qs_state != "all"))
                                geo2._geo.EstateId = int.Parse(qs_state);

                            string qs_city = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["city"]);
                            if ((qs_city != null) && (qs_city != "all"))
                                geo2._geo.CityId = int.Parse(qs_city);

                            string qs_area = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["area"]);
                            if ((qs_area != null) && (qs_area != "all"))
                                geo2._geo.AreaId = int.Parse(qs_area);

                            string qs_type = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["type"]);
                            if ((qs_type != null) && (qs_type != "all"))
                                ddl_type2.SelectedValue = qs_type;

                            string qs_metrazhType = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["metrazhType"]);
                            if ((qs_metrazhType != null) && (qs_metrazhType != "all"))
                                ddl_metrazh2.SelectedValue = qs_metrazhType;

                            string qs_maxEjarePrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["maxEjarePrice"]);
                            if ((qs_maxEjarePrice != null) && (qs_maxEjarePrice != "all"))
                                tb_maxEjarePrice.Text = qs_maxEjarePrice;

                            string qs_maxVadiePrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["maxVadiePrice"]);
                            if ((qs_maxVadiePrice != null) && (qs_maxVadiePrice != "all"))
                                tb_maxVadiePrice.Text = qs_maxVadiePrice;
                        }
                        /**************************************/

                        return ph;
                    }


                    protected void btnSearch_Click(object sender, EventArgs e)
                    {

                        // TextBox _tb = new TextBox();
                        // _tb = (TextBox)FindControl("txtSearch");
                        Page.Response.Redirect(khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath +
                            "web/estate/?agreement_type=1&country="  + geo1.selectedCountry +
                            "&state=" + geo1.selectedstate  +
                            "&city=" + geo1.selectedcity  +
                            "&area=" + geo1.selectedarea  +
                            "&type=" + ddl_type1.SelectedValue   +
                            "&metrazhType=" + ddl_metrazh1.SelectedValue   +                           
                            "&minTotalPrice=" + tb_buy_minPrice1.Text   +
                            "&maxTotalPrice=" + tb_buy_maxPrice1.Text  );
                        //refresh grid
                        //upGrid.Update();

                    }

                    protected void btnSearch2_Click(object sender, EventArgs e)
                    {

                        // TextBox _tb = new TextBox();
                        // _tb = (TextBox)FindControl("txtSearch");
                        Page.Response.Redirect(khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath +
                                      "web/estate/?agreement_type=2&country=" + geo2.selectedCountry +
                                      "&state=" + geo2.selectedstate +
                                      "&city=" + geo2.selectedcity +
                                      "&area=" + geo2.selectedarea +
                                      "&type=" + ddl_type2.SelectedValue +
                                      "&metrazhType=" + ddl_metrazh2.SelectedValue +
                                      "&maxEjarePrice=" + tb_maxEjarePrice.Text +
                                      "&maxVadiePrice=" + tb_maxVadiePrice.Text);
                        //refresh grid
                        //upGrid.Update();

                    }



                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);

                        khatam.core.data.sql.addPropertyRow(Instance, "tab1InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab2InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab3InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab4InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab5InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab6InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab7InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab8InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab9InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab10InstanceID", "0", "Core_serverControlsInstanceVal", null);

                        khatam.core.data.sql.addPropertyRow(Instance, "ordering", "1", "Core_serverControlsInstanceVal", null);



                        return "added";
                    }










                }
            }

        }
    }
}
