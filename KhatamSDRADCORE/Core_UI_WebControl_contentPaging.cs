using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
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
                [ToolboxData("<{0}:contentPaging runat=server></{0}:contentPaging>")]
                public class contentPaging : CompositeControl
                {

                    #region variable



                    public event EventHandler SaveHandler2;
                    static Button btnok = new Button();

                    Panel PanelWin = new Panel();
                    Label Lbl1 = new Label();

                    PlaceHolder ph_place = new PlaceHolder();

                    public bool editMode;
                    public bool Demo;

                    public string sortType;

                    public string catid,contentId = "";

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


                    public string PasswordValue
                    {
                        get
                        {
                            TextBox pass = (TextBox)this.FindControl("PasswordControl");

                            return pass.Text;
                        }
                        set
                        {
                            TextBox pass = (TextBox)this.FindControl("PasswordControl");

                            pass.Text = value;
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



                    public string fckvalue3
                    {
                        get
                        {
                            TextBox fck1 = (TextBox)this.FindControl("fck" + instanceID);

                            return fck1.Text;
                        }
                        set
                        {
                            TextBox fck1 = (TextBox)this.FindControl("fck" + instanceID);

                            fck1.Text = value;
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
                    public string contentTable;// ="article";



                    public string instanceID;


                    public Boolean winVisible;

                    public DateTime pub_date;


                    #endregion

                    #region Events

                    void save_Click2(object sender, EventArgs e)
                    {

                        if (SaveHandler2 != null)
                            SaveHandler2(this, e);

                        //   PanelWin.Controls.Clear();

                        //Page.Response.Redirect(urlEngine() );
                        //PanelWin.Controls.Add(new LiteralControl("sssssssssss"));

                    }

                    protected void btnGoto_Click(object sender, EventArgs e)
                    {

                        TextBox tbt = new TextBox();
                        tbt = (TextBox)FindControl("tbgoto");

                        this.Page.Response.Redirect(urlEngine(tbt.Text, null, null,null ));
                    }

                    TextBox txtSearchTag = new TextBox();


                    protected void btnSearchTag_Click(object sender, EventArgs e)
                    {
                                              

                        this.Page.Response.Redirect(urlEngine("1", null, null, txtSearchTag.Text ));
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

                            DropDownList  oDDLsortType = new DropDownList();
                            oDDLsortType = (DropDownList)FindControl("DDLsortType" + instanceID);
                            khatam.core.data.sql.InstanceValSet(instanceID, "sortType", oDDLsortType.SelectedValue );

                          

                //            FredCK.FCKeditorV2.FCKeditor ff2 = new FredCK.FCKeditorV2.FCKeditor();
                  //          ff2 = (FredCK.FCKeditorV2.FCKeditor)FindControl("fck" + instanceID);


                            //fck.ID = "fck" + instanceID;

                            System.Web.UI.HtmlControls.HtmlInputText tbb = new System.Web.UI.HtmlControls.HtmlInputText();

                            //tbb = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("Text1" + instanceID );

                            khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);

                            Page.Response.Redirect(Page.Request.Url.PathAndQuery);
                            //refresh grid
                            //upGrid.Update();
                        }
                    }

                    protected void btnSearch_Click(object sender, EventArgs e)
                    {
                        ImageButton s = new ImageButton();
                        s = (ImageButton)sender;


                        //TextBox _tb = new TextBox();
                        // _tb = (TextBox)FindControl("txtSearch");
                        //Page.Response.Redirect("search.aspx?q=" + s.ID  );
                        //refresh grid
                        //upGrid.Update();

                        khatam.shop.shopCart.AddToShopCart("2069", 1, 0, null, "");

                        Page.Response.Redirect(this.Page.Request.Url.PathAndQuery  );
                    }

                    #endregion

                    #region CreateChildControls


                    protected override void CreateChildControls()
                    {
                        try
                        {
                            contentTable = HttpContext.Current.Items["contentType"].ToString();
                        }
                        catch
                        {

                        }

                        try
                        {
                            contentId = HttpContext.Current.Items["id"].ToString();// +".aspx";
                        }
                        catch
                        {
                            contentId = "";
                        }

                        try
                        {

                        }
                        catch
                        {

                        }

                        if ((this.Parent.Page.Request.QueryString["cat"] == null))
                        {
                            //catid  = Sql_get_sortid(contentTable, "فارسی");
                        }
                        else
                        {

                            catid = this.Parent.Page.Request.QueryString["cat"];
                        }

                                     

                        this.Controls.Add(new LiteralControl("<div style=\"margin:10px\">"));

                        int pos = Array.IndexOf(khatam.core.explorer.content_type_Arr , contentTable);
                        if ((pos > -1) || (contentTable == "search"))
                        {
                            this.Controls.Add(paging_content());
                        }
                        else if (contentTable == "tag") 
                        {
                            if (contentId =="")
                                this.Controls.Add(paging_tagMain());
                            else
                                this.Controls.Add(paging_tag_list());
                        }

                        this.Controls.Add(ph_place);

                        this.Controls.Add(new LiteralControl("</div>"));



                     //   this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));


                    }



                    #endregion


                    #region Controls

                    public  Control pagingHeader(string Results)
                    {
                        PlaceHolder ph1 = new PlaceHolder();

                        

                        ph1.Controls.Add(new LiteralControl("<div style=\"direction:rtl \">"));

                        //result
                        //ph1.Controls.Add(new LiteralControl(" نتایج: " + setPersianNumber(Results) + " مورد یافت گردید. "));


                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingHeaderResults\">"));
                        ph1.Controls.Add(new LiteralControl(" نتایج: " + setPersianNumber(Results) + " مورد یافت گردید. "));
                        ph1.Controls.Add(new LiteralControl("</div>"));

                        /*************************************************************************/
                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingHeaderTreeDiv\">"));

                        
                        if (contentTable != "search")
                        {
                            if (this.Page.Request.QueryString["cat"] != null)
                            {
                                string weArehere;
                                weArehere = khatam.core.explorer.generateUrl_link_website(catid,contentTable );
                                ph1.Controls.Add(new LiteralControl(weArehere));
                            }
                            else
                            {
                                string rootcatid = khatam.core.data.sql.getField( "id", "type_content", contentTable,"height","3", "cat");
                                string rootcatpid = khatam.core.data.sql.getField( "pid", "id", rootcatid , "cat");
                                string rootcatPcname = khatam.core.data.sql.getField( "cname", "id", rootcatpid, "cat");
                                ph1.Controls.Add(new LiteralControl( 
                                    "<a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath +
                            "web/"+"\"    >صفحه اصلی</a>  > " + rootcatPcname  ));
                            }
                            
                        }

                        if (contentTable == "estate")
                        {
                            string str_searchStatment=" [";
                            int agreement_type=0;

                            if (this.Page.Request.QueryString["agreement_type"] != null)
                            {
                                agreement_type = int.Parse(this.Page.Request.QueryString["agreement_type"]);
                            }
                            switch (agreement_type)
                            {
                                case 1:
                                    str_searchStatment = str_searchStatment + "خرید";
                                    break;
                                case 2:
                                    str_searchStatment = str_searchStatment + "رهن و اجاره";
                                    break;
                                default:
                                    break;

                            }

                            string qs_country = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["country"]);
                             if ((qs_country != null) && (qs_country != "all"))
                             {
                                 str_searchStatment = str_searchStatment + " | " + " کشور: " + khatam.core.data.sql.getDicTitle("country_id", qs_country, "core_country", "1", "dictionary_id");                              
                             }

                             string qs_state = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["state"]);
                             if ((qs_state != null) && (qs_state != "all") && (qs_state != "0"))
                             {
                                 str_searchStatment = str_searchStatment + " | " + " استان / ایالت: " + khatam.core.data.sql.getDicTitle("country_state_id", qs_state, "core_country_state", "1", "dictionary_id");
                             }

                             string qs_city = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["city"]);
                             if ((qs_city != null) && (qs_city != "all") && (qs_city != "0"))
                             {
                                 str_searchStatment = str_searchStatment + " | " + " شهر / شهرستان: " + khatam.core.data.sql.getDicTitle("country_state_city_id", qs_city, "core_country_state_city", "1", "dictionary_id");
                             }

                             string qs_area = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["area"]);
                             if ((qs_area != null) && (qs_area != "all") && (qs_area != "0"))
                             {
                                 str_searchStatment = str_searchStatment + " | " + " محدوده: " + khatam.core.data.sql.getDicTitle("country_state_city_area_id", qs_area, "core_country_state_city_area", "1", "dictionary_id");
                             }

                             string qs_type = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["type"]);
                             if ((qs_type != null) && (qs_type != "all") )
                             {
                                 str_searchStatment = str_searchStatment + " | " + khatam.core.data.sql.getDicTitle("id", qs_type, "estate_type", "1", "dictionary_id");
                             }

                             string qs_metrazhType = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["metrazhType"]);
                             if ((qs_metrazhType != null) && (qs_metrazhType != "all"))
                             {
                                 str_searchStatment = str_searchStatment + " | " + khatam.core.data.sql.getDicTitle(qs_metrazhType,"1");
                             }

                             string qs_minTotalPrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["minTotalPrice"]);
                             if (qs_minTotalPrice != null) 
                             {
                                 str_searchStatment = str_searchStatment + " | " + khatam.core.data.sql.getDicTitle("minTotalPrice", "1") +": " + qs_minTotalPrice +" " +"ریال";
                             }

                             string qs_maxTotalPrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["maxTotalPrice"]);
                             if (qs_maxTotalPrice != null) 
                             {
                                 str_searchStatment = str_searchStatment + " | " + khatam.core.data.sql.getDicTitle("maxTotalPrice", "1") + ": " + qs_maxTotalPrice + " " + "ریال";
                             }

                             string qs_maxEjarePrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["maxEjarePrice"]);
                             if ((qs_maxEjarePrice != null) && (qs_maxEjarePrice != ""))
                             {
                                 str_searchStatment = str_searchStatment + " | " + khatam.core.data.sql.getDicTitle("maxEjarePrice", "1") + ": " + qs_maxEjarePrice + " " + "ریال";
                             }

                             string qs_maxVadiePrice = khatam.core.Security.input.removeInjectionChars(Page.Request.QueryString["maxVadiePrice"]);
                             if ((qs_maxVadiePrice != null) && (qs_maxVadiePrice != ""))
                             {
                                 str_searchStatment = str_searchStatment + " | " + khatam.core.data.sql.getDicTitle("maxVadiePrice", "1") + ": " + qs_maxVadiePrice + " " + "ریال";
                             }
                             
                        
                            ph1.Controls.Add(new LiteralControl(str_searchStatment + "]" ));
                         
                           

                        }

                        ph1.Controls.Add(new LiteralControl("</div>"));
                        /*************************************************************************/

                        /*************************************************************************/
                        if (contentTable != "search")
                        {
                            

                            string sortid = "";

                            DataTable dt2 = new DataTable();


                            if (this.Page.Request.QueryString["cat"] != null)
                            {

                                sortid = khatam.core.data.sql.getField( "sortid", "id", catid, "cat");
                            }
                            else
                            {
                                sortid = khatam.core.data.sql.getField( "sortid", "type_content", contentTable, "height", "3", "cat");
                                
                            }

                            dt2 = khatam.core.explorer.getFolder("bindFolder", sortid);



                            string str_cat="";

                            if (dt2.Rows.Count > 0)
                            {
                                ph1.Controls.Add(new LiteralControl("<div class=\"pagingHeaderMainDiv\">"));
                                ph1.Controls.Add(new LiteralControl("<ul class=\"clearfix\">"));
                                for (int i = 0; i < dt2.Rows.Count; i++)
                                {
                                    ph1.Controls.Add(new LiteralControl("<li class=\"catLi\">"));                                     
                                    //ph1.Controls.Add(new LiteralControl( dt2.Rows[i].ItemArray[2].ToString()));
                                    
                                    //

                                    //ph1.Controls.Add(new LiteralControl("<a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath +
                                    //"web/" + contentTable + "/" + "?cat=" + dt2.Rows[i].ItemArray[0].ToString() +
                                    //"&title=" + dt2.Rows[i].ItemArray[0].ToString() + "    >" + dt2.Rows[i].ItemArray[2].ToString() + "</a> "));
                                    

                                    ph1.Controls.Add(new LiteralControl("<a href=\""
                                    + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable + "/?cat=" + dt2.Rows[i].ItemArray[0].ToString() +
                                    "&title=" + dt2.Rows[i].ItemArray[2].ToString() +
                                    "\">" + dt2.Rows[i].ItemArray[2].ToString() +   "</a>"));

                                    ph1.Controls.Add(new LiteralControl(" <span class=\"smallText\">(" + khatam.core.globalization.numbers.GetPersianNumbers( khatam.core.explorer.countFolderALLFiles(dt2.Rows[i].ItemArray[5].ToString(), contentTable)) + ")</span>"));

                                    ph1.Controls.Add(new LiteralControl("</li class=\"catLi\">"));

                                }


                                ph1.Controls.Add(new LiteralControl("</ul>"));
                                ph1.Controls.Add(new LiteralControl(" <div class=\"spacer\" style=\"clear: both;\"></div>"));

                                
                                ph1.Controls.Add(new LiteralControl("</div>"));
                            }

                        }
                        /*************************************************************************/



                        /*ph1.Controls.Add(new LiteralControl("<div class=\"pagingHeaderMainDiv\">"));
                        //row1
                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingHeaderMainDivRows\">"));
                        ph1.Controls.Add(new LiteralControl("<div style=\"float:right\">"));
                        ph1.Controls.Add(new LiteralControl("نوع نمایش"));
                        ph1.Controls.Add(new LiteralControl("</div>"));

                        ph1.Controls.Add(new LiteralControl("<div style=\"float:left\">"));
                        ph1.Controls.Add(new LiteralControl(setPersianNumber("صفحه 1 از 20 | بعدی قبلی")));
                        ph1.Controls.Add(new LiteralControl("</div>"));
                        ph1.Controls.Add(new LiteralControl("</div>"));


                        //row2

                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingHeaderMainDivRows\">"));
                        ph1.Controls.Add(new LiteralControl("<div style=\"float:right\">"));
                        ph1.Controls.Add(new LiteralControl("مرتب سازی بر اساس"));
                        ph1.Controls.Add(new LiteralControl("</div>"));

                        ph1.Controls.Add(new LiteralControl("<div style=\"float:left\">"));
                        ph1.Controls.Add(new LiteralControl("ssss"));
                        ph1.Controls.Add(new LiteralControl("</div>"));
                        ph1.Controls.Add(new LiteralControl("</div>"));


                        ph1.Controls.Add(new LiteralControl("</div>"));*/



                        ph1.Controls.Add(new LiteralControl("</div>"));

                        return ph1;
                    }

                    public Control paging_tagMain()
                    {
                        int pageQ;
                        int pageSize;
                        if (this.Page.Request.QueryString["pageSize"] == null)
                        {
                            pageSize = 40;
                        }
                        else
                        {
                            pageSize = int.Parse(this.Page.Request.QueryString["pageSize"]);

                        }

                        string q;

                        if (this.Page.Request.QueryString["q"] != null)
                        {
                            q =khatam.core.Security.input.removeInjectionChars( this.Page.Request.QueryString["q"].ToString());
                        }
                        else
                        {
                            q = "";
                        }

                        int Results = Sql_load_count_tags(q);

                        int pageLinkSize;
                        /*************error if 10***/
                        pageLinkSize = 40;
                        pageQ = Results / pageSize;

                        //query strings
                        int page;
                        if (this.Page.Request.QueryString["page"] != null)
                        {
                            page = int.Parse(this.Page.Request.QueryString["page"].ToString());
                        }
                        else
                        {
                            page = 1;
                        }

                        if (page < 1) page = 1;
                        if (page > pageQ) page = pageQ;
                        if (pageLinkSize > pageQ) pageLinkSize = pageQ;

                        DataTable dt = new DataTable();

                        //dt = khatam.core.data.sql.getTableIdTitleRecent(contentTable, 10 , khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        int fRow;
                        int lRow;
                        fRow = page * pageSize;

                        if (this.Page.Request.QueryString["page"] != null)
                        {

                            page = int.Parse(this.Page.Request.QueryString["page"].ToString());
                            lRow = page * pageSize;
                            fRow = (lRow - pageSize) + 1;
                        }
                        else
                        {
                            page = 1;
                            fRow = 0;
                            lRow = pageSize;
                        }

                        int lPage;
                        if ((Results % pageSize) == 0)
                        {
                            lPage = Results / pageSize;
                        }
                        else
                        {
                            lPage = Results / pageSize + 1;
                        }



                        
                        
                        DataTable dt1 = new DataTable();

                        dt1 = getTagsMainPage(q,fRow,lRow);// khatam.core.data.sql.getTable("core_tags");

                       // HttpContext.Current.Response.Write(first_row + "" + last_row);

                        PlaceHolder ph1 = new PlaceHolder();
                        //ph1.Controls.Add(new LiteralControl("tag_test"));

                        //GridView gv = new GridView();
                        //gv.DataSource = dt;
                        //gv.DataBind();
                        //ph1.Controls.Add(gv);


                        ph1.Controls.Add(new LiteralControl(" <div  style=\"width: 100%; display:  inline-block; \" >"));

                        ph1.Controls.Add(new LiteralControl("<h1>تگ ها</h1>"));
                        ph1.Controls.Add(new LiteralControl("<p>اصطلاح تگ به کلمات کلیدی، برچسب یا دسته بندی هایی اطلاق می شود که نویسنده گان مطالب برای جستجوی ساده تر تعیین نموده اند.</p>"));
                        ph1.Controls.Add(new LiteralControl(" <div  style=\"width: 100%; display:  inline-block; \" >"));
                        
                        ph1.Controls.Add(new LiteralControl("جستجوی تگ:"));
                        ph1.Controls.Add(txtSearchTag );

                        if (q != "")
                            txtSearchTag.Text = q;

                        ph1.Controls.Add(new LiteralControl(" "));

                        Button btnSearchTag = new Button();
                        btnSearchTag.Text = "جستجو";
                        btnSearchTag.Font.Name = "tahoma";
                        btnSearchTag.Click += new EventHandler(btnSearchTag_Click);


                        ph1.Controls.Add(btnSearchTag);
                        ph1.Controls.Add(new LiteralControl(" </br>"));

                        ph1.Controls.Add(new LiteralControl(" </br>"));



                        ph1.Controls.Add(new LiteralControl(" </div>"));


                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            
                            

                            string id = dt1.Rows[i].ItemArray[0].ToString();
                            string title = dt1.Rows[i].ItemArray[1].ToString();
                            string counter = dt1.Rows[i].ItemArray[2].ToString();

                      

                                //ph1.Controls.Add(new LiteralControl("test" + i.ToString()));

                            ph1.Controls.Add(new LiteralControl("<div class=\"tagRowBorder\" style=\" width: " + (230) + "px ;   text-align:right ; float:right ; margin-top:10px;padding-bottom:10px \" >"));


                           // ph1.Controls.Add(new LiteralControl("<div dir=\"rtl\" style=\" padding-right: 5px; padding-left: 5px;\" >"));

                            ph1.Controls.Add(new LiteralControl("<div  dir=\"rtl\" style=\"  margin-left: 5px;\" >"));


                            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                                "web/tag/" + title;
                            //<a class="" href="http://www.yourDomain.com">ffff</a>


                            ph1.Controls.Add(new LiteralControl("<a class=\"tag\" href=\"" + url + "\">"));
                            ph1.Controls.Add(new LiteralControl(title));
                            ph1.Controls.Add(new LiteralControl(" </a> "));

                            ph1.Controls.Add(new LiteralControl("<span class=\"tag_count\">" + "×"  + khatam.core.globalization.numbers.GetPersianNumbers(counter) + "</span>"));


                            //ph1.Controls.Add(new LiteralControl("<span class=\"tag_desc\">" + "سید مصطفی قنات آبادی" + "</span>"));


                            ph1.Controls.Add(new LiteralControl(" </div>"));


                            ph1.Controls.Add(new LiteralControl(" </div>"));

                               



                        }

                        ph1.Controls.Add(new LiteralControl("<div style=\"clear:both;\"> </div>"));

                       




                        ph1.Controls.Add(pagingFooterTag(Results, page, pageSize, pageLinkSize, lPage));



                        return ph1;



                    }

                    public Control paging_tag_list()
                    {
                        PlaceHolder ph1 = new PlaceHolder();


                        //this.Controls.Add(new LiteralControl("<br />"));
                        string pageName;
                        pageName = this.Parent.Page.ToString().Replace("ASP.", "").Replace("_aspx", "").Replace("_item", "");

                                               
                        int Results;

                        if (pageName != "layout")
                        {
                                                                   

                            Results =int.Parse( countTag(contentId));

                            contentTable = HttpContext.Current.Items["contentType"].ToString();


                            int pageQ;
                            int pageSize;
                            if (this.Page.Request.QueryString["pageSize"] == null)
                            {
                                pageSize = 10;
                            }
                            else
                            {
                                pageSize = int.Parse(this.Page.Request.QueryString["pageSize"]);

                            }

                            int pageLinkSize;
                            pageLinkSize = 10;
                            pageQ = Results / pageSize;

                            //query strings
                            int page;
                            if (this.Page.Request.QueryString["page"] != null)
                            {
                                page = int.Parse(this.Page.Request.QueryString["page"].ToString());
                            }
                            else
                            {
                                page = 1;
                            }

                            if (page < 1) page = 1;
                            if (page > pageQ) page = pageQ;
                            if (pageLinkSize > pageQ) pageLinkSize = pageQ;




                            ph1.Controls.Add(pagingHeader(Results.ToString()));


                            DataTable dt = new DataTable();

                          
                            int fRow;
                            int lRow;
                            fRow = page * pageSize;

                            if (this.Page.Request.QueryString["page"] != null)
                            {

                                page = int.Parse(this.Page.Request.QueryString["page"].ToString());
                                lRow = page * pageSize;
                                fRow = (lRow - pageSize) + 1;
                            }
                            else
                            {
                                page = 1;
                                fRow = 0;
                                lRow = pageSize;
                            }

                            int lPage;
                            if ((Results % pageSize) == 0)
                            {
                                lPage = Results / pageSize;
                            }
                            else
                            {
                                lPage = Results / pageSize + 1;
                            }


                           dt = getTableTags(contentId, fRow, lRow);

                            PlaceHolder ph = new PlaceHolder();


                            //1
                            ph.Controls.Add(new LiteralControl("<div class=\"pagingGrid\">"));


                            string[] strShopCartId;
                            strShopCartId = khatam.shop.shopCart.GetShopCartArrayID(this.Page);

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                string id = dt.Rows[i].ItemArray[0].ToString();
                                string titlef = dt.Rows[i].ItemArray[1].ToString();
                                string navurl = dt.Rows[i].ItemArray[2].ToString();

                                string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + navurl + khatam.core.strings.Url.replaceTitleNonChar(titlef);  //dt.Rows[i].ItemArray[2].ToString();


                             

                                string imageUrl = dt.Rows[i].ItemArray[3].ToString();
                                string TableRetunsql = dt.Rows[i].ItemArray[4].ToString();

                                string hostname;
                                hostname = this.Page.Request.Url.Host;


                                if ((imageUrl == "") || (imageUrl == "1") || (imageUrl == "manage/content/article/resize/1"))
                                {
                                    imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo.jpg";
                                }
                                else
                                {
                                    imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + TableRetunsql + "/4/" + dt.Rows[i].ItemArray[3].ToString();
                                }
                                string author = dt.Rows[i].ItemArray[5].ToString();
                                string description = dt.Rows[i].ItemArray[6].ToString();
                                string keywords = dt.Rows[i].ItemArray[7].ToString();




                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridRow\">"));



                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridImgContentDiv\" >"));

                            
                                ph.Controls.Add(new LiteralControl("<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>"));
                     

                                ph.Controls.Add(new LiteralControl(" </div>"));





                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentDiv\" >"));

                                ph.Controls.Add(new LiteralControl("<a class=\"public_Link\" href=\"" + url + "\">" + titlef + "</a>"));

                                // ph.Controls.Add(new LiteralControl("<br />"));
                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentDesc\">"));

                                ph.Controls.Add(new LiteralControl(description));
                                ph.Controls.Add(new LiteralControl("</div>"));


                                if (author != "")
                                {
                                    ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentAuthor\">"));
                                    ph.Controls.Add(new LiteralControl("[" + "نویسنده: " + author + "]"));
                                    ph.Controls.Add(new LiteralControl("</div>"));
                                }

                                if (keywords != "")
                                {
                                    ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentKeywords\">"));
                                    ph.Controls.Add(new LiteralControl("کلمات کلیدی: " + keywords));
                                    ph.Controls.Add(new LiteralControl("</div>"));
                                }

                                ph.Controls.Add(new LiteralControl("</div>"));




                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridBtnContentDiv\" >"));

                                bool ShopCartAdded = false;

                                foreach (string s in strShopCartId)
                                {
                                    if (s == id)
                                    {
                                        ShopCartAdded = true;
                                    }
                            

                                }


                                if (contentTable == "##shop")
                                {
                                    if (ShopCartAdded == false)
                                    {
                                        ImageButton ibnt1 = new ImageButton();
                                        ibnt1.ImageUrl = "theme/Flowhub/cssimage/btn/AddToShopCartbtn.gif";
                                        ibnt1.ID = id;
                                        ibnt1.Click += new ImageClickEventHandler(btnSearch_Click);
                                        ph.Controls.Add(ibnt1);
                                    }
                                    else
                                    {

                                        ph.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                            + "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));
                                    }
                                }

                                ph.Controls.Add(new LiteralControl(" </div>"));


                                //****** end row
                                ph.Controls.Add(new LiteralControl("</div>"));

                            }

                            ph.Controls.Add(new LiteralControl("</div>"));

                            ph.Controls.Add(new LiteralControl("ttttttttttt"));


                            ph1.Controls.Add(ph);

                            ph1.Controls.Add(pagingFooter(Results, page, pageSize, pageLinkSize, lPage));

                        }


                        //pagging  
                        return ph1;

                    }

                 

                
                    public Control paging_content()
                    {
                        PlaceHolder ph1 = new PlaceHolder();


                        //this.Controls.Add(new LiteralControl("<br />"));
                        string pageName;
                        pageName = this.Parent.Page.ToString().Replace("ASP.", "").Replace("_aspx", "").Replace("_item", "");

                


                        string sortid = "";
                        int Results;

                        if (pageName != "layout")
                        {

                            if (contentTable != "search")
                            {
                                if ((this.Parent.Page.Request.QueryString["cat"] == null)) {
                                    sortid = Sql_get_sortid(contentTable, "فارسی");
                                }
                                else 
                                { 
                                    
                                    sortid = Sql_get_sortid_by_id(this.Page.Request.QueryString["cat"]); 
                                }
                            }
                            else
                            {
                                sortid = "#.1";
                            }


                            switch (contentTable)
                            {
                                case "estate":
                                    Results =  Sql_load_count_estate(contentTable, sortid, this.Page.Request.QueryString["q"]);
                                    break;
                                default:
                                    Results = Sql_load_count(contentTable, sortid, this.Page.Request.QueryString["q"]);

                                    break;
                            }



                            int pageQ;
                            int pageSize;
                            if (this.Page.Request.QueryString["pageSize"] == null)
                            {
                                pageSize = 10;
                            }
                            else
                            {
                                pageSize = int.Parse(this.Page.Request.QueryString["pageSize"]);

                            }

                            int pageLinkSize;
                            pageLinkSize = 10;
                            pageQ = Results / pageSize;

                            //query strings
                            int page;
                            if (this.Page.Request.QueryString["page"] != null)
                            {
                                page = int.Parse(this.Page.Request.QueryString["page"].ToString());
                            }
                            else
                            {
                                page = 1;
                            }

                            if (page < 1) page = 1;
                            if (page > pageQ) page = pageQ;
                            if (pageLinkSize > pageQ) pageLinkSize = pageQ;




                            ph1.Controls.Add(pagingHeader(Results.ToString()));


                            DataTable dt = new DataTable();

                            //dt = khatam.core.data.sql.getTableIdTitleRecent(contentTable, 10 , khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                            int fRow;
                            int lRow;
                            fRow = page * pageSize;

                            if (this.Page.Request.QueryString["page"] != null)
                            {

                                page = int.Parse(this.Page.Request.QueryString["page"].ToString());
                                lRow = page * pageSize;
                                fRow = (lRow - pageSize) + 1;
                            }
                            else
                            {
                                page = 1;
                                fRow = 0;
                                lRow = pageSize;
                            }

                            int lPage;
                            if ((Results % pageSize) == 0)
                            {
                                lPage = Results / pageSize;
                            }
                            else
                            {
                                lPage = Results / pageSize + 1;
                            }


                            switch (contentTable)
                            {
                                case "estate":
                                    dt = getTableEstate(contentTable, this.Page.Request.QueryString["q"], fRow, lRow, sortid, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                                    break;
                                default:
                                    dt = getTable(contentTable, this.Page.Request.QueryString["q"], fRow, lRow, sortid, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                                    break;
                            }

                            

                            PlaceHolder ph = new PlaceHolder();



                            //1
                            ph.Controls.Add(new LiteralControl("<div class=\"pagingGrid\">"));


                            string[] strShopCartId;
                            strShopCartId = khatam.shop.shopCart.GetShopCartArrayID(this.Page);

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                string id = dt.Rows[i].ItemArray[0].ToString();
                                string titlef = dt.Rows[i].ItemArray[1].ToString();
                                string navurl = dt.Rows[i].ItemArray[2].ToString();

                                string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + navurl + khatam.core.strings.Url.replaceTitleNonChar(titlef);  //dt.Rows[i].ItemArray[2].ToString();


                         

                                string imageUrl = dt.Rows[i].ItemArray[3].ToString();
                                string TableRetunsql = dt.Rows[i].ItemArray[4].ToString();

                                string hostname;
                                hostname = this.Page.Request.Url.Host;


                                if ((imageUrl == "") || (imageUrl == "1") || (imageUrl == "manage/content/article/resize/1"))
                                {
                                    imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/Flowhub/CssImage/Element/no_photo.jpg";
                                }
                                else
                                {
                                    imageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Upload/content/" + TableRetunsql + "/4/" + dt.Rows[i].ItemArray[3].ToString();
                                }
                                string author = dt.Rows[i].ItemArray[5].ToString();
                                string description = dt.Rows[i].ItemArray[6].ToString();
                                string keywords = dt.Rows[i].ItemArray[7].ToString();


                                try
                                {
                                    pub_date = DateTime.Parse(dt.Rows[0].ItemArray[9].ToString());
                                }
                                catch
                                {

                                }



                                string timeStr = "";
                                // if (ci.pub_date != null) { timeStr = khatam.core.globalization.dateTime.GetPersianDateTime(ci.pub_date  ); };
                                try
                                {
                                    if (pub_date > DateTime.MinValue)
                                    {
                                        timeStr =
                                            numbers.GetPersianNumbers(dateTime.GetPersianDate(pub_date));
                                    };
                                }
                                catch
                                {
                                }

                              //  hhhhhhhhh


                                //author,description,keywords

                                //string 


                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridRow\">"));



                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridImgContentDiv\" >"));

                                //ph.Controls.Add(new LiteralControl("<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>"));
                                ph.Controls.Add(new LiteralControl("<a href=\"" + url + "\">" + " <img alt=\"" + titlef + "\" src=\"" + imageUrl + "\" />" + "</a>"));
                                //ph.Controls.Add(new LiteralControl(" <img alt=\"\" src=\"\" />"));

                                ph.Controls.Add(new LiteralControl(" </div>"));





                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentDiv\" >"));

                                ph.Controls.Add(new LiteralControl("<a class=\"public_Link\" href=\"" + url + "\">" + titlef + " - " + timeStr + "</a>"));

                                // ph.Controls.Add(new LiteralControl("<br />"));
                                ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentDesc\">"));

                                ph.Controls.Add(new LiteralControl(description));
                                ph.Controls.Add(new LiteralControl("</div>"));


                                if (author != "")
                                {
                                    ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentAuthor\">"));
                                    ph.Controls.Add(new LiteralControl("[" + "نویسنده: " + author + "]"));
                                    ph.Controls.Add(new LiteralControl("</div>"));
                                }

                              /********************* tag
                                    ph.Controls.Add(new LiteralControl("<div class=\"pagingGridDetailContentKeywords\">"));
                                    //ph.Controls.Add(new LiteralControl("کلمات کلیدی: " + keywords));

                                    DataTable dtTag = new DataTable();
                                    dtTag = khatam.core.explorer.getTags(dt.Rows[i].ItemArray[8].ToString());

                                    string html = "";

                                    for (int jj = 0; jj < dtTag.Rows.Count ; jj++)
			                        {
                                        html =html + " <a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath
                                            + "/web/tag/" + dtTag.Rows[jj].ItemArray[0] + "\" class=\"tag\">" + dtTag.Rows[jj].ItemArray[0] + "</a>";
		                        	}
                             
                                    ph.Controls.Add(new LiteralControl(html ));


                                    ph.Controls.Add(new LiteralControl("</div>"));
                               * ***************/
                              
                                

                                ph.Controls.Add(new LiteralControl("</div>"));




                                //1
                                //          ph.Controls.Add(new LiteralControl("</div>"));

                                // ph.Controls.Add(new LiteralControl("<div class=\"pagingGridBtnContentDiv\" >"));

                                  if (contentTable == "shop")
                                  {

                                      UpdatePanel up = new UpdatePanel();
                                      UpdateProgress alp = new UpdateProgress();

                                      alp.Controls.Add(new LiteralControl("<div style=\"text-align:right;\"> <img alt=\"loading...\"  src=\"" +
                                      khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                                      "RadControls/Ajax/Skins/Default/Loading2.gif\" /> </div>"));

                                      up.ID = this.UniqueID  + "up" + dt.Rows[i].ItemArray[8].ToString();

                                      alp.AssociatedUpdatePanelID = this.UniqueID  + "up" + dt.Rows[i].ItemArray[8].ToString();

                                      // }

                                      ph.Controls.Add(alp);

                                  // ph.Controls.Add(ContentChildShop(id, dt.Rows[i].ItemArray[8].ToString()));

                                   up.ContentTemplateContainer.Controls.Add(ContentChildShop(id, dt.Rows[i].ItemArray[8].ToString()));

                                 //  pAddedShopCart.Visible = false;
                                 //  up.ContentTemplateContainer.Controls.Add(pAddedShopCart);


                                   //ph.Controls.Add(ShopCartButton());

                                   ph.Controls.Add(up);
                                /*  bool ShopCartAdded = false;

                                  foreach (string s in strShopCartId)
                                  {
                                      if (s == id)
                                      {
                                          ShopCartAdded = true;
                                      }
                                      //       else
                                      //  {
                                      //        ShopCartAdded=false ;
                                      //  }

                                  }


                                 
                                     /* if (ShopCartAdded == false)
                                      {
                                          ImageButton ibnt1 = new ImageButton();
                                          ibnt1.ImageUrl = "theme/Flowhub/cssimage/btn/AddToShopCartbtn.gif";
                                          ibnt1.ID ="imgBtn_" + catid;
                                          ibnt1.Click += new ImageClickEventHandler(btnSearch_Click);
                                          ph.Controls.Add(ibnt1);
                                      }
                                      else
                                      {

                                          ph.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                              + "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));
                                      }*/
                                 

                                //  ph.Controls.Add(new LiteralControl(" </div>"));


                                  //****** end row*/
                                  }

                                  ph.Controls.Add(new LiteralControl("</div>"));



                            }

                            ph.Controls.Add(new LiteralControl("</div>"));
                            ph1.Controls.Add(ph);

                            ph1.Controls.Add(pagingFooter(Results, page, pageSize, pageLinkSize, lPage));

                        }


                        //pagging  
                        return ph1;

                    }

                



                    public Control ContentChildShop(string contentId, string catid)
                    {

                        string unit;
                        unit = khatam.shop.shopCart.getUnits(contentId);

                        PlaceHolder ph = new PlaceHolder();

                        Panel pAddToShopCart = new Panel();
                        pAddToShopCart.ID = this.UniqueID + "pAddToShopCart" + catid;
                        Panel pAddedShopCart = new Panel();
                        pAddedShopCart.ID = this.UniqueID + "pAddedShopCart" + catid;

                        // ph.Controls.Add(new LiteralControl("test"));

                        ph.Controls.Add(new LiteralControl("<div style=\"text-align: justify ;overflow:hidden;;margin-left:10px\">"));



                        // string price_in_rls = "";
                        string min = "";

             

                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        //  khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        //  khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        if (!khatam.core.data.sql.Sql_Check_identity("catId", catid, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
                        //if (false)
                        {
                            DataTable dt = new DataTable();
                            string sql_str = "SELECT     TOP (1) min   FROM         core_sale_terms  WHERE     (catId = " + catid + ") ORDER BY min";

                            dt = DBFunctions.ExecuteReader(sql_str, parameters, CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                            //   price_in_rls = dt.Rows[0].ItemArray[1].ToString();
                            min = dt.Rows[0].ItemArray[0].ToString();

                            //side right
                            DataTable dt2 = new DataTable();
                            dt2 =khatam.shop.shopCart.getPrices(catid);
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

                         

                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));
                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));

                            TextBox txtQ = new TextBox();

                            txtQ.ID =this.UniqueID + "_txtQ_" + catid;
                            txtQ.ClientIDMode = System.Web.UI.ClientIDMode.Static;
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
                            RangeValidator1.ControlToValidate = this.UniqueID + "_txtQ_" + catid;
                            RangeValidator1.MinimumValue = min;
                            RangeValidator1.MaximumValue = "10000000";
                            RangeValidator1.Type = ValidationDataType.Integer;
                            RangeValidator1.Text = "حداقل سفارش این محصول " + min + " عدد است";
                            RangeValidator1.Font.Size = FontUnit.Point(8);
                            RangeValidator1.ErrorMessage = "msg";
                            RangeValidator1.ValidationGroup = this.UniqueID + "_txtQ_vg_" + catid;                          
                            pAddToShopCart.Controls.Add(RangeValidator1);


                            RequiredFieldValidator RequiredFieldValidator1 = new RequiredFieldValidator();
                            RequiredFieldValidator1.ControlToValidate = this.UniqueID + "_txtQ_" + catid;
                            RequiredFieldValidator1.Text = " درج مقدار عددی مساوی یا بزرگتر از " + min +  " برای جعبه متن " + unit  + " الزامی است " ;
                            RequiredFieldValidator1.ErrorMessage = "msg";
                            RequiredFieldValidator1.Font.Size = FontUnit.Point(8);
                            RequiredFieldValidator1.ValidationGroup = this.UniqueID + "_txtQ_vg_" + catid;
                            pAddToShopCart.Controls.Add(RequiredFieldValidator1);






                            pAddToShopCart.Controls.Add(new LiteralControl("</br>"));



                            pAddToShopCart.Controls.Add(ShopCartButton(catid));

                            //pAddedShopCart.Controls.Add(new LiteralControl("محصو"));

                            pAddedShopCart.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                             "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));


                   


                            //ph.Controls.Add(ShopCartButton());

                            ph.Controls.Add(pAddToShopCart);
                            pAddedShopCart.Visible = false;

                            ph.Controls.Add(pAddedShopCart);


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

                    public Control ShopCartButton(string catId)
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
                        Btn1.ClientIDMode = System.Web.UI.ClientIDMode.Static;
                        Btn1.ID =this.UniqueID + "_imgBtn_" + catId;
                        Btn1.ValidationGroup = this.UniqueID + "_txtQ_vg_" + catId;
                        Btn1.Click += new ImageClickEventHandler(btnShopCart_Click);
                        Btn1.CssClass = "imgAlpha";
                        Btn1.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                            //    "theme/Flowhub/CssImage/btn/btnShopCart.gif";
                        "theme/Flowhub/cssimage/btn/AddToShopCartbtn.gif";
                        ph1.Controls.Add(Btn1);

                        return ph1;
                    }

                    public void btnShopCart_Click(object sender, EventArgs e)
                    {
                        ImageButton s = new ImageButton();
                        s = (ImageButton)sender;
                        string catid = s.ID.Replace(this.UniqueID + "_imgBtn_", ""); 

                        //Btn1.ID =this.UniqueID + "_imgBtn_" + catId;
                        TextBox txt =(TextBox ) FindControl(this.UniqueID + "_txtQ_" + catid);

                        //khatam.shop.shopCart.AddToShopCart(contentId, int.Parse(txtQ.Text), this.Page, catid,0,null);
                        khatam.shop.shopCart.AddToShopCart(catid, int.Parse(txt.Text), 0, null, "");

                        //Panel pAddToShopCart = new Panel();
                        //pAddToShopCart.ID = this.UniqueID + "pAddToShopCart" + catid;
                        //Panel pAddedShopCart = new Panel();
                        //pAddedShopCart.ID = this.UniqueID + "pAddedShopCart" + catid;

                        Panel pAddToShopCart = (Panel)FindControl(this.UniqueID + "pAddToShopCart" + catid);
                        Panel pAddedShopCart = (Panel)FindControl(this.UniqueID + "pAddedShopCart" + catid);
                        pAddedShopCart.Visible = true;
                       pAddToShopCart.Visible = false;
                    }


                    public Control pagingFooter(int Results, int page, int pageSize, int pageLinkSize, int lPage)
                    {

                        int pageQ;


                        pageQ = Results / pageSize;
                        PlaceHolder ph1 = new PlaceHolder();
                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingFooterMainDiv\">"));

                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingFooterQuantity\">"));

                        ph1.Controls.Add(new LiteralControl("<div style=\"float:right; margin-left:5px;\">"));
                        ph1.Controls.Add(new LiteralControl(setPersianNumber(" نمایش: ")));
                        ph1.Controls.Add(new LiteralControl("</div> "));



                        if ((this.Page.Request.QueryString["pageSize"] == null) || (this.Page.Request.QueryString["pageSize"] == "10"))
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtnActive\"><span  class=\"pageBtnLinkActive\" >" + setPersianNumber("10") + "</span> " + " </div>"));
                        }
                        else
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtn\"><a  class=\"pageBtnLink\"   href=\"" + urlEngine(null, "10", null,null ) + "\">" + setPersianNumber("10") + "</a> " + " </div>"));

                        }
                        if (this.Page.Request.QueryString["pageSize"] == "20")
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtnActive\"><span  class=\"pageBtnLinkActive\" >" + setPersianNumber("20") + "</span> " + " </div>"));

                        }
                        else
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtn\"><a  class=\"pageBtnLink\"  href=\"" + urlEngine(null, "20", null,null) + "\">" + setPersianNumber("20") + "</a> " + " </div>"));

                        }
                        if (this.Page.Request.QueryString["pageSize"] == "50")
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtnActive\"><span  class=\"pageBtnLinkActive\" >" + setPersianNumber("50") + "</span> " + " </div>"));

                        }
                        else
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtn\"><a  class=\"pageBtnLink\"   href=\"" + urlEngine(null, "50", null,null) + "\">" + setPersianNumber("50") + "</a> " + " </div>"));

                        }




                        //ph1.Controls.Add(new LiteralControl(setPersianNumber(" نمایش 10 20 50 100 ")));
                        ph1.Controls.Add(new LiteralControl("</div>"));


                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingFooterMainDivRows\">"));
                        // ph1.Controls.Add(new LiteralControl("<div style=\"float:right\">"));
                        ph1.Controls.Add(new LiteralControl("<div>"));

                        string pageLink = "";

                        int i = 1;

                        string pagelinkbtn = "";


                        pageLinkSize = 10;

                        int fLinkPage = 1;
                        int lLinkPage;

                        //fLinkPage = page;

                        if (page > 6) fLinkPage = page - 5;
                        //if (fLinkPage > 5) fLinkPage = fLinkPage - 5;
                        //if (page < 5) fLinkPage = 1;

                        lLinkPage = fLinkPage + 10;

                        if (lLinkPage > lPage) lLinkPage = lPage;
                        if (page > 6)
                        {

                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtn\"><a class=\"pageBtnLink\"  href=\"" + urlEngine("1", null, null,null) + "\">" + setPersianNumber("1") + "</a> " + " </div>";
                            pagelinkbtn = pagelinkbtn + "<div style=\"float:right\"> ... </div>";

                        }

                        for (i = fLinkPage; i < lLinkPage; i++)
                        {
                            pageLink = pageLink + i.ToString() + " ";
                            if (i == page)
                            {
                                pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnActive\"><span class=\"pageBtnLinkActive\"  >" + setPersianNumber(i.ToString()) + "</span> " + " </div>";
                            }
                            else
                            {
                                pagelinkbtn = pagelinkbtn + "<div class=\"pageBtn\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(i.ToString(), null, null,null) + "\">" + setPersianNumber(i.ToString()) + "</a> " + " </div>";
                            }
                        }



                        pagelinkbtn = pagelinkbtn + "<div style=\"float:right\"> ... </div>";



                        if (page == lPage)
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnActive\"><span class=\"pageBtnLinkActive\"  >" + setPersianNumber(lPage.ToString()) + "</span> " + " </div>";


                        }
                        else
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtn\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(lPage.ToString(), null, null, null) + "\">" + setPersianNumber(lPage.ToString()) + "</a> " + " </div>";

                        }




                        int prePage, nextPage;
                        prePage = page - 1;
                        nextPage = page + 1;



                        if (page > 1)
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnNBf\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(prePage.ToString(), null, null, null) + "\">قبلی</a> " + " </div>";

                        }

                        if (page < lPage)
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnNB\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(nextPage.ToString(), null, null, null) + "\">بعدی</a> " + " </div>";
                        }





                        ph1.Controls.Add(new LiteralControl(pagelinkbtn));

                        ph1.Controls.Add(new LiteralControl("</div>"));

                        ph1.Controls.Add(new LiteralControl("<div style=\"float:left\">"));

                        ph1.Controls.Add(new LiteralControl(" به صفحه "));

                        TextBox tb1 = new TextBox();
                        tb1.Width = 50;
                        tb1.ID = "tbgoto";
                        ph1.Controls.Add(tb1);
                        ph1.Controls.Add(new LiteralControl(" "));
                        Button Btn1 = new Button();
                        Btn1.Text = "برو";
                        Btn1.Width = 30;
                        //Btn1.Click += new EventHandler(btnGoto_Click);
                        Btn1.ID = "btnGoto";

                        Btn1.Click += new EventHandler(btnGoto_Click);

                        Btn1.Font.Name = "tahoma";
                        ph1.Controls.Add(Btn1);

                        ph1.Controls.Add(new LiteralControl("</div>"));



                        ph1.Controls.Add(new LiteralControl("</div>"));



                        ph1.Controls.Add(new LiteralControl("</div>"));

                        ph1.Controls.Add(new LiteralControl("<br />"));

                        return ph1;
                    }

                    public Control pagingFooterTag(int Results, int page, int pageSize, int pageLinkSize, int lPage)
                    {

                        int pageQ;


                        pageQ = Results / pageSize;
                        PlaceHolder ph1 = new PlaceHolder();
                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingFooterMainDiv\">"));

                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingFooterQuantity\">"));

                        ph1.Controls.Add(new LiteralControl("<div style=\"float:right; margin-left:5px;\">"));
                        ph1.Controls.Add(new LiteralControl(setPersianNumber(" نمایش: ")));
                        ph1.Controls.Add(new LiteralControl("</div> "));



                        if ((this.Page.Request.QueryString["pageSize"] == null) || (this.Page.Request.QueryString["pageSize"] == "40"))
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtnActive\"><span  class=\"pageBtnLinkActive\" >" + setPersianNumber("40") + "</span> " + " </div>"));
                        }
                        else
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtn\"><a  class=\"pageBtnLink\"   href=\"" + urlEngine(null, "40", null, null) + "\">" + setPersianNumber("40") + "</a> " + " </div>"));

                        }
                        if (this.Page.Request.QueryString["pageSize"] == "100")
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtnActive\"><span  class=\"pageBtnLinkActive\" >" + setPersianNumber("100") + "</span> " + " </div>"));

                        }
                        else
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtn\"><a  class=\"pageBtnLink\"  href=\"" + urlEngine(null, "100", null, null) + "\">" + setPersianNumber("100") + "</a> " + " </div>"));

                        }
                        if (this.Page.Request.QueryString["pageSize"] == "200")
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtnActive\"><span  class=\"pageBtnLinkActive\" >" + setPersianNumber("200") + "</span> " + " </div>"));

                        }
                        else
                        {
                            ph1.Controls.Add(new LiteralControl("<div class=\"pageSizeBtn\"><a  class=\"pageBtnLink\"   href=\"" + urlEngine(null, "200", null, null) + "\">" + setPersianNumber("200") + "</a> " + " </div>"));

                        }




                        //ph1.Controls.Add(new LiteralControl(setPersianNumber(" نمایش 10 20 50 100 ")));
                        ph1.Controls.Add(new LiteralControl("</div>"));


                        ph1.Controls.Add(new LiteralControl("<div class=\"pagingFooterMainDivRows\">"));
                        // ph1.Controls.Add(new LiteralControl("<div style=\"float:right\">"));
                        ph1.Controls.Add(new LiteralControl("<div>"));

                        string pageLink = "";

                        int i = 1;

                        string pagelinkbtn = "";


                        pageLinkSize = 10;

                        int fLinkPage = 1;
                        int lLinkPage;

                        //fLinkPage = page;

                        if (page > 6) fLinkPage = page - 5;
                        //if (fLinkPage > 5) fLinkPage = fLinkPage - 5;
                        //if (page < 5) fLinkPage = 1;

                        lLinkPage = fLinkPage + 10;

                        if (lLinkPage > lPage) lLinkPage = lPage;
                        if (page > 6)
                        {

                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtn\"><a class=\"pageBtnLink\"  href=\"" + urlEngine("1", null, null, null) + "\">" + setPersianNumber("1") + "</a> " + " </div>";
                            pagelinkbtn = pagelinkbtn + "<div style=\"float:right\"> ... </div>";

                        }

                        for (i = fLinkPage; i < lLinkPage; i++)
                        {
                            pageLink = pageLink + i.ToString() + " ";
                            if (i == page)
                            {
                                pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnActive\"><span class=\"pageBtnLinkActive\"  >" + setPersianNumber(i.ToString()) + "</span> " + " </div>";
                            }
                            else
                            {
                                pagelinkbtn = pagelinkbtn + "<div class=\"pageBtn\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(i.ToString(), null, null, null) + "\">" + setPersianNumber(i.ToString()) + "</a> " + " </div>";
                            }
                        }



                        pagelinkbtn = pagelinkbtn + "<div style=\"float:right\"> ... </div>";



                        if (page == lPage)
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnActive\"><span class=\"pageBtnLinkActive\"  >" + setPersianNumber(lPage.ToString()) + "</span> " + " </div>";


                        }
                        else
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtn\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(lPage.ToString(), null, null, null) + "\">" + setPersianNumber(lPage.ToString()) + "</a> " + " </div>";

                        }




                        int prePage, nextPage;
                        prePage = page - 1;
                        nextPage = page + 1;



                        if (page > 1)
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnNBf\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(prePage.ToString(), null, null, null) + "\">قبلی</a> " + " </div>";

                        }

                        if (page < lPage)
                        {
                            pagelinkbtn = pagelinkbtn + "<div class=\"pageBtnNB\"><a class=\"pageBtnLink\"  href=\"" + urlEngine(nextPage.ToString(), null, null, null) + "\">بعدی</a> " + " </div>";
                        }





                        ph1.Controls.Add(new LiteralControl(pagelinkbtn));

                        ph1.Controls.Add(new LiteralControl("</div>"));

                        ph1.Controls.Add(new LiteralControl("<div style=\"float:left\">"));

                        ph1.Controls.Add(new LiteralControl(" به صفحه "));

                        TextBox tb1 = new TextBox();
                        tb1.Width = 50;
                        tb1.ID = "tbgoto";
                        ph1.Controls.Add(tb1);
                        ph1.Controls.Add(new LiteralControl(" "));
                        Button Btn1 = new Button();
                        Btn1.Text = "برو";
                        Btn1.Width = 30;
                        //Btn1.Click += new EventHandler(btnGoto_Click);
                        Btn1.ID = "btnGoto";

                        Btn1.Click += new EventHandler(btnGoto_Click);

                        Btn1.Font.Name = "tahoma";
                        ph1.Controls.Add(Btn1);

                        ph1.Controls.Add(new LiteralControl("</div>"));



                        ph1.Controls.Add(new LiteralControl("</div>"));



                        ph1.Controls.Add(new LiteralControl("</div>"));

                        ph1.Controls.Add(new LiteralControl("<br />"));

                        return ph1;
                    }

                    #endregion

                    #region Function
                    public string urlEngine(string page, string pageSize,string cat, string q)
                    {


                        string url_str = this.Page.Request.Path;
                        string _pageT, _pageSizeT, _q,_cat;

                        if (page != null)
                        {

                            _pageT = page;

                            url_str = url_str + "?page=" + _pageT;

                        }
                        else
                        {
                            if (this.Page.Request.QueryString["page"] != null)
                            {
                                url_str = url_str + "?page=" + this.Page.Request.QueryString["page"];
                            }
                            else
                            {
                                url_str = url_str + "?page=1";
                            }
                        }


                        if (pageSize != null)
                        {

                            _pageSizeT = pageSize;

                            url_str = url_str + "&pageSize=" + _pageSizeT;

                        }
                        else
                        {
                            if (this.Page.Request.QueryString["pageSize"] != null)
                            {
                                url_str = url_str + "&pageSize=" + this.Page.Request.QueryString["pageSize"];
                            }
                            else
                            {
                                url_str = url_str + "&pageSize=10";
                            }
                        }


                        if (q != null)
                        {

                            _q = q;

                            url_str = url_str + "&q=" + _q;

                        }
                        else
                        {
                            if (this.Page.Request.QueryString["q"] != null)
                            {
                                url_str = url_str + "&q=" + this.Page.Request.QueryString["q"];
                            }
                            else
                            {

                            }
                        }


                        if (cat != null)
                        {

                            _cat = cat;

                            url_str = url_str + "&cat=" + _cat;

                        }
                        else
                        {
                            if (this.Page.Request.QueryString["cat"] != null)
                            {
                                url_str = url_str + "&cat=" + this.Page.Request.QueryString["cat"];
                            }
                            else
                            {

                            }
                        }


                        if (this.Page.Request.QueryString["agreement_type"] != null) url_str = url_str + "&agreement_type=" + this.Page.Request.QueryString["agreement_type"];
                        if (this.Page.Request.QueryString["country"] != null) url_str = url_str + "&country=" + this.Page.Request.QueryString["country"];
                        if (this.Page.Request.QueryString["state"] != null) url_str = url_str + "&state=" + this.Page.Request.QueryString["state"];
                        if (this.Page.Request.QueryString["city"] != null) url_str = url_str + "&city=" + this.Page.Request.QueryString["city"];
                        if (this.Page.Request.QueryString["area"] != null) url_str = url_str + "&area=" + this.Page.Request.QueryString["area"];
                        if (this.Page.Request.QueryString["type"] != null) url_str = url_str + "&type=" + this.Page.Request.QueryString["type"];
                        if (this.Page.Request.QueryString["metrazhType"] != null) url_str = url_str + "&metrazhType=" + this.Page.Request.QueryString["metrazhType"];
                        if (this.Page.Request.QueryString["minTotalPrice"] != null) url_str = url_str + "&minTotalPrice=" + this.Page.Request.QueryString["minTotalPrice"];
                        if (this.Page.Request.QueryString["maxTotalPrice"] != null) url_str = url_str + "&maxTotalPrice=" + this.Page.Request.QueryString["maxTotalPrice"];
                        if (this.Page.Request.QueryString["maxEjarePrice"] != null) url_str = url_str + "&maxEjarePrice=" + this.Page.Request.QueryString["maxEjarePrice"];
                        if (this.Page.Request.QueryString["maxVadiePrice"] != null) url_str = url_str + "&maxVadiePrice=" + this.Page.Request.QueryString["maxVadiePrice"];
                        
                       
                    


                        return url_str;
                    }

                    private void CloseDialog(string dialogId)
                    {
                        string script = string.Format(@"closeDialog('{0}')", dialogId);
                        ///ScriptManager.RegisterClientScriptBlock(this, typeof(Page), UniqueID, script, true);
                    }

                    public    DataTable getTable(string table, string q, int first_row, int last_row, string sortid, string ConnectionString)
                    {
                        string str_sql = "";
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        //parameters.Add("field_where_value", field_where_value);

                        string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                            + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; 

                        string str_sql_sortType ="";

                        if (sortType == "Descending") str_sql_sortType = "DESC";

                        if (table != "search")
                        {

                            str_sql = "SELECT     id,title,'" + table + "/' + CAST(id as nvarchar) + '/'  as navi_url " + ", image as image_navi , N'" + table + "' as TableSql , author,description,keywords, cat_id,pub_date  " +
               

                   " FROM         (SELECT     *, row_number() OVER (ORDER BY id " +  str_sql_sortType  + " ) AS Row_Number " +
               
              " FROM         (SELECT DISTINCT " + table + ".*, cat.id as cat_id " +
              " FROM         " + table + " INNER JOIN " +
              " Cat ON " + table + ".id = Cat.id_content " +
              //^^" WHERE     (Cat.sortid LIKE N'%" + sortid + "%') AND (" + table + ".Enable_Show = 1)) AS resultData1) AS resultData2 " +
              " WHERE    (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND   (Cat.sortid LIKE N'%" + sortid + "%') AND (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (" + table + ".enable = 1 ) ) AS resultData1) AS resultData2 " +
              " WHERE     (Row_Number BETWEEN " + first_row + " AND " + last_row + ") ";

                            

                        }
                        else
                        {
                            
                        

                            str_sql = " select * from (select *,row_number() OVER (ORDER BY id desc) AS Row_Number1 from  (  ";

                            for (int i = 0; i < khatam.core.explorer.content_type_Arr.Length    ; i++)
                            {

                                table = khatam.core.explorer.content_type_Arr[i];
                                //if (i > 0) str_sql = str_sql + " Union ";
                                //str_sql = str_sql + " SELECT     id,title,'" + table + "_item.aspx?id=' + CAST(id as nvarchar) + '&title=' + replace(replace(title,' ','-'),':','')  as navi_url " + ", image as image_navi , author,description,keywords " +

                                if (khatam.core.explorer.isValidContent_Type(table))
                                {
                                    if (i > 0) str_sql = str_sql + " union  ";

                                    str_sql = str_sql + " SELECT     Cat.id_content,title,'" + table + "/' + CAST(cat.id_content as nvarchar) + '?title=' + replace(replace(title,' ','-'),':','')  as navi_url , image as image_navi  , N'" + table + "' as TableSql  , author,description,keywords,cat.id,pub_date " +
                                                       " FROM         Cat INNER JOIN " +
                                     table + " ON Cat.id_content = " + table + ".id " + 
                                    //" WHERE     (Cat.type_content = N'article') ";
                                    " WHERE    (Cat.type_content = N'" + table  + "')  AND  (Cat.sortid LIKE N'%" + sortid + "%')   AND (" + table + ".title LIKE N'%" + q + "%') AND (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (" + table + ".enable = 1 ) ";
                                }
                                //" ;   

                            }

                            str_sql = str_sql + ")  as data1   ) as data2 where (Row_Number1 between " + first_row + " and " + last_row + ")"; 

                           

                        }

                       // this.Controls.Add(new LiteralControl (str_sql ));

                        // str_sql = "SELECT  top(10)    id, title,title as navi_url,'manage/content/" + table + "/resize/' + image as image_navi  FROM         article";
                        //str_sql = "select * from article";     


                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, ConnectionString);
                    }


                    public DataTable getTableEstate(string table, string q, int first_row, int last_row, string sortid, string ConnectionString)
                    {
                        string str_sql = "";
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        //parameters.Add("field_where_value", field_where_value);

                        string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                            + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second;

                        string str_sql_sortType = "";

                        if (sortType == "Descending") str_sql_sortType = "DESC";

                    

                            str_sql = "SELECT     id,title,'" + table + "/' + CAST(id as nvarchar) + '/'  as navi_url " + ", image as image_navi , N'" + table + "' as TableSql , author,description,keywords, cat_id,pub_date  " +


                   " FROM         (SELECT     *, row_number() OVER (ORDER BY id " + str_sql_sortType + " ) AS Row_Number " +

              " FROM         (SELECT DISTINCT " + table + ".*, cat.id as cat_id " +
              " FROM         " + table + " INNER JOIN " +
              " Cat ON " + table + ".id = Cat.id_content " +
                                //^^" WHERE     (Cat.sortid LIKE N'%" + sortid + "%') AND (" + table + ".Enable_Show = 1)) AS resultData1) AS resultData2 " +
              " WHERE    (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND   (Cat.sortid LIKE N'%" + sortid + "%') AND (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (" + table + ".enable = 1 ) " + sql_generate_estate_where()  +  " ) AS resultData1) AS resultData2 " +
              " WHERE     (Row_Number BETWEEN " + first_row + " AND " + last_row + ") ";



                        
                      

                        // this.Controls.Add(new LiteralControl (str_sql ));

                        // str_sql = "SELECT  top(10)    id, title,title as navi_url,'manage/content/" + table + "/resize/' + image as image_navi  FROM         article";
                        //str_sql = "select * from article";     


                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, ConnectionString);
                    }

               

                    public DataTable getTableTags(string title, int first_row, int last_row )
                    {
                        string str_sql = "";
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        //parameters.Add("field_where_value", field_where_value);

                        string str_sql_sortType = "";
                        string sql_temp="";
                        string sql_base = " SELECT DISTINCT "
                        + " #.id, #.title, #.[image],#.author,#.description,#.keywords, Cat.id as catId, Cat.type_content as catType_content"
                        + " FROM core_tag_ref_cat INNER JOIN"
                        + " # INNER JOIN"
                        + " Cat ON #.id = Cat.id_content ON core_tag_ref_cat.cat_id = Cat.id INNER JOIN"
                        + " core_tags ON core_tag_ref_cat.tag_id = core_tags.tag_id"
                        + " WHERE (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (#.enable = 1) AND (core_tags.tag_title=N'" + title + "') ";

                   //sql_base=    sql_base.Replace("#", "news");
                        string[] content_type_Arr = khatam.core.explorer.content_type_Arr;

                        for (int i = 0; i < content_type_Arr.Length; i++)
                        {
                           
                            if (khatam.core.License.ValidModule(content_type_Arr[i]))
                            {

                                if (sql_temp == "")
                                {
                                    sql_temp = sql_base.Replace("#", content_type_Arr[i]);
                                }
                                else
                                {
                                    sql_temp = sql_temp + " union " + sql_base.Replace("#", content_type_Arr[i]);
                                }
                            }
                            //   sql = sql.Replace("#", content_type_Arr[i]);
                            //   type_content = content_type_Arr[i];
                        }

                        
                        //catType_content +


                        if (sortType == "Descending") str_sql_sortType = "DESC";

                        str_sql = " SELECT     id,title, catType_content + '/' + CAST(id as nvarchar) + '/'  as navi_url , [image] as image_navi , '" + contentTable + "' as TableSql , author,description,keywords,catId  FROM         " +
" (SELECT     *, row_number() OVER (ORDER BY catId desc ) AS Row_Number  FROM         " +
 " ( " +

 sql_temp +


" ) AS resultData1) " +
 "  AS resultData2 " +
"  WHERE     (Row_Number BETWEEN  " + first_row + " AND " + last_row + ") ";

                           /* str_sql = "SELECT     id,title,'" + table + "/' + CAST(id as nvarchar) + '/'  as navi_url " + ", image as image_navi , N'" + table + "' as TableSql , author,description,keywords " +


                   " FROM         (SELECT     *, row_number() OVER (ORDER BY id " + str_sql_sortType + " ) AS Row_Number " +

              " FROM         (SELECT DISTINCT " + table + ".* " +
              " FROM         " + table + " INNER JOIN " +
              " Cat ON " + table + ".id = Cat.id_content " +                              
              " WHERE     (Cat.sortid LIKE N'%" + sortid + "%') AND (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (" + table + ".enable = 1 ) ) AS resultData1) AS resultData2 " +
              " WHERE     (Row_Number BETWEEN " + first_row + " AND " + last_row + ") ";*/
                       /*  str_sql22 = " SELECT DISTINCT "
+ " news.id, news.title, news.[image],news.author,news.description,news.keywords, Cat.id as catId"
+ " FROM core_tag_ref_cat INNER JOIN"
+ " news INNER JOIN"
+ " Cat ON news.id = Cat.id_content ON core_tag_ref_cat.cat_id = Cat.id INNER JOIN"
+ " core_tags ON core_tag_ref_cat.tag_id = core_tags.tag_id"
+ " WHERE (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (news.enable = 1) ";*/

                        HttpContext.Current.Response.Write(str_sql );


                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }


                    public static string Sql_get_sortid(string table, string language)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        parameters.Add("cname", language);
                        parameters.Add("type_content", table);
                        //parameters.Add("field_where_value", field_where_value);
                        str_sql = "SELECT     sortid   FROM         Cat   WHERE     (cname = @cname) AND (type_content = @type_content)";


                        return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }

         

                    public static DataTable getTagsMainPage(string q, int first_row, int last_row)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        //parameters.Add("cname", language);
                        //parameters.Add("type_content", table);
                        //parameters.Add("field_where_value", field_where_value); 
                        /*str_sql = "SELECT  distinct  core_tags.tag_id, core_tags.tag_title, core_tags.counter " +
                        " FROM         core_tags INNER JOIN " +
                        " core_tag_ref_cat ON core_tags.tag_id = core_tag_ref_cat.tag_id INNER JOIN " +
                        " Cat ON core_tag_ref_cat.cat_id = Cat.id";*/

                        string qLike = "";
                        if (q != "")
                            qLike = " WHERE     (core_tags.tag_title  LIKE N'%" + q + "%')";
                        
                        str_sql = "select * From (SELECT *, row_number() OVER (ORDER BY tag_title  ) AS Row_Number FROM ( select * from core_tags " + qLike  + " ) as data1) as data2 " +
                        " WHERE     (Row_Number BETWEEN  "  +  first_row  +" AND "  + last_row  + ") ";

                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }

                    #endregion


                    public static string countTag(string title)
                    {





                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        parameters.Add("title", title);
                        str_sql = " SELECT     COUNT(core_tags.tag_title) AS Expr1 " +
                        " FROM         core_tags INNER JOIN " +
                        " core_tag_ref_cat ON core_tags.tag_id = core_tag_ref_cat.tag_id INNER JOIN " +
                        " Cat ON core_tag_ref_cat.cat_id = Cat.id " +
                        " WHERE     (core_tags.tag_title = @title) ";

                        return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }



                    public static string Sql_get_sortid_by_id(string cat_id)
                    {





                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        parameters.Add("id", cat_id);
                        str_sql = "SELECT     sortid   FROM         Cat   WHERE     (id = @id) ";

                        return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
                    }

                    public  int Sql_load_count(string table, string sortid, string q)
                    {
                        string str_sql = "";
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                            + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second; 

                        int count = 0;

                        if (table != "search")
                        {
                            str_sql = "SELECT     COUNT(*) AS Expr1 " +
                                " FROM         (SELECT     *, row_number() OVER (ORDER BY id DESC) AS Row_Number " +
                                " FROM         (SELECT DISTINCT " + table + ".* " +
                                " FROM         " + table + " INNER JOIN " +
                                " Cat ON " + table + ".id = Cat.id_content " +
                                " WHERE     (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND  (Cat.sortid LIKE N'%" + sortid + "%') AND (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (" + table + ".enable = 1 ) ) AS resultData1) AS resultData2 ";
                            count = int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString());
                        }
                        else
                        {

                            str_sql = str_sql + "SELECT     COUNT(*) AS Expr1 " +
                                 " FROM         (SELECT     *, row_number() OVER (ORDER BY id DESC) AS Row_Number " +
                                 " FROM         ( ";

                            for (int i = 0; i < khatam.core.explorer.content_type_Arr.Length; i++)
                            {

                                table = khatam.core.explorer.content_type_Arr[i];


                                if (khatam.core.explorer.isValidContent_Type(table))
                                {
                                    if (i > 0) str_sql = str_sql + " union ";
                                    // table = "news";
                                    str_sql = str_sql +
                                     " SELECT DISTINCT " + table + ".id " +
                                     " FROM         " + table + " INNER JOIN " +
                                     " Cat ON " + table + ".id = Cat.id_content " +
                                     " WHERE     (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND  (Cat.sortid LIKE N'%" + sortid +
                                     "%') AND (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (" + table + ".enable = 1 ) AND (" + table + ".title LIKE N'%" + q + "%') ";

                                }                                 

                               // }

                              

                            }

                            str_sql = str_sql + " ) AS resultData1) AS resultData2 ";

                            count = count + int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString());

                        }
                        //ph_place.Controls.Add(new LiteralControl(str_sql + count.ToString() ));

                        return count;

                    }

                    public int Sql_load_count_estate(string table, string sortid, string q)
                    {
                      
                      
                                 

                        string str_sql = "";


                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                            + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second;

                        int count = 0;

                       str_sql = "SELECT     COUNT(*) AS result  FROM         ( " +
                           " SELECT  DISTINCT   cat.id FROM         estate INNER JOIN                       Cat ON estate.id = Cat.id_content  WHERE     (Cat.type_content = N'estate') " +
                                //" FROM         (SELECT     *, row_number() OVER (ORDER BY id DESC) AS Row_Number " +
                                //" FROM         (SELECT DISTINCT " + table + ".* " +
                                //" FROM         " + table + " INNER JOIN " +
                                //" Cat ON " + table + ".id = Cat.id_content " +
                                " and     (showTime < CONVERT(DATETIME, '" + strDate + "', 102)) AND (Cat.Valid = 1) AND (Cat.deleted <> 1) AND (" + table + ".enable = 1 ) " + sql_generate_estate_where() +
                                 " ) AS resultData1 ";
                            count = int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString());

                          

                           // str_sql = str_sql + " ) AS resultData1) AS resultData2 ";
                           // HttpContext.Current.Response.Write(str_sql);

                      
                        //ph_place.Controls.Add(new LiteralControl(str_sql + count.ToString() ));

                        return count;

                    }

                    public int Sql_load_count_tags(string q)
                    {

                        string str_sql = "";


                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        string strDate;
                        strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                            + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + ":" + DateTime.UtcNow.Second;

                        int count = 0;

                        string qLike = "";
                        if (q != "")
                            qLike = " WHERE     (core_tags.tag_title  LIKE N'%" + q + "%')";


                        str_sql = "SELECT     COUNT(*) AS result  FROM         ( " +
                            " SELECT * from core_tags   " + qLike +
                            //" FROM         (SELECT     *, row_number() OVER (ORDER BY id DESC) AS Row_Number " +
                            //" FROM         (SELECT DISTINCT " + table + ".* " +
                            //" FROM         " + table + " INNER JOIN " +
                            //" Cat ON " + table + ".id = Cat.id_content " +
                                  
                                  " ) AS resultData1 ";
                        count = int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString());



                        // str_sql = str_sql + " ) AS resultData1) AS resultData2 ";
                        // HttpContext.Current.Response.Write(str_sql);


                        //ph_place.Controls.Add(new LiteralControl(str_sql + count.ToString() ));

                        return count;

                    }


                    public string sql_generate_estate_where()
                    {
                        string str_sql_extra = "";

                        string str_agreement_type = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["agreement_type"]);
                        if (str_agreement_type != null)
                            str_sql_extra = " and (agreement_type = " + this.Page.Request.QueryString["agreement_type"] + ") ";

                        string strCountry = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["country"]);
                        if (!((strCountry == null) || (strCountry == "all")))
                            str_sql_extra = str_sql_extra + " and (country_id = " + strCountry + ") ";

                        string strState = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["state"]);
                        if (!((strState == null) || (strState == "all" || (strState == "0"))))
                            str_sql_extra = str_sql_extra + " and (country_state_id = " + strState + ") ";

                        string strCity = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["city"]);
                        if (!((strCity == null) || (strCity == "all") || (strCity == "0")))
                            str_sql_extra = str_sql_extra + " and (country_state_city_id = " + strCity + ") ";

                        string strArea = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["area"]);
                        if (!((strArea == null) || (strArea == "all") || (strArea == "0")))
                            str_sql_extra = str_sql_extra + " and (core_country_state_city_area_id = " + strArea + ") ";

                        string strType = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["type"]);
                        if (!((strType == null) || (strType == "all")))
                            str_sql_extra = str_sql_extra + " and (estate.type = " + strType + ") ";

                        string metrazhType = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["metrazhType"]);

                        switch (metrazhType)
                        {
                            case "max100":
                                str_sql_extra = str_sql_extra + " and (metrazh < 100) ";
                                break;
                            case "max150":
                                str_sql_extra = str_sql_extra + " and (metrazh < 150) ";
                                break;
                            case "max200":
                                str_sql_extra = str_sql_extra + " and (metrazh < 200) ";
                                break;
                            case "max1000":
                                str_sql_extra = str_sql_extra + " and (metrazh < 1000) ";
                                break;
                            case "min1000":
                                str_sql_extra = str_sql_extra + " and (metrazh >= 1000) ";
                                break;
                            case null:
                            case "all":
                            default:
                                break;
                        }

                        switch (str_agreement_type)
                        {
                            case "1":
                                string minTotalPrice = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["minTotalPrice"]);
                                string maxTotalPrice = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["maxTotalPrice"]);

                                if (minTotalPrice == null) minTotalPrice = "0";
                                if (maxTotalPrice == null) maxTotalPrice = "9999999999999999999";

                                str_sql_extra = str_sql_extra + "and (totalPrice BETWEEN " + minTotalPrice + " AND " + maxTotalPrice + " ) ";
                                break;

                            case "2":
                                string maxEjarePrice = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["maxEjarePrice"]);
                                string maxVadiePrice = khatam.core.Security.input.removeInjectionChars(this.Page.Request.QueryString["maxVadiePrice"]);

                                if (maxVadiePrice == null) maxVadiePrice = "9999999999999999999";
                                if (maxEjarePrice == null) maxEjarePrice = "9999999999999999999";

                                str_sql_extra = str_sql_extra + "and (VadiePrice < " + maxVadiePrice + " ) ";
                                str_sql_extra = str_sql_extra + "and (EjarePrice < " + maxEjarePrice + " ) ";

                                break;
                            default:
                                break;
                        }

                        return str_sql_extra;

                    }

                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal",null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "contentTable", "news", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "sortType", "Descending", "Core_serverControlsInstanceVal", null);

                        return "added";
                    }

         

                    public static string setPersianNumber(string source_str)
                    {
                        source_str = source_str.Replace("0", "٠");
                        source_str = source_str.Replace("1", "١");
                        source_str = source_str.Replace("2", "٢");
                        source_str = source_str.Replace("3", "٣");
                        source_str = source_str.Replace("4", "٤");
                        source_str = source_str.Replace("5", "٥");
                        source_str = source_str.Replace("6", "٦");
                        source_str = source_str.Replace("7", "٧");
                        source_str = source_str.Replace("8", "٨");
                        source_str = source_str.Replace("9", "٩");
                        return source_str;
                    }

                }
            }
        }
    }
}
