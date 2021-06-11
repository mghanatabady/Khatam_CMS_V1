using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using khatam;
using System.Data;
using System.Data.SqlClient;
using System.Web.Routing;
using System.Diagnostics;
using System.IO.Compression;

public partial class _Default : System.Web.UI.Page
{
    public bool EditMode = false;

    private void Page_Error(object sender, EventArgs e)
    {
       
    }

    protected override void OnLoad(EventArgs e)
    {
        //
        // Apply GZIP compression (or DEFLATE)
        //
    /*    if (EditMode == false)
        {
          if (IsGZipSupported())
            {
                Response.Filter = new GZipStream(Response.Filter,
                    CompressionMode.Compress);
                Response.AddHeader("Content-Encoding", "gzip");
            }
        }*/
    }

    public static bool IsGZipSupported()
    {
        string AcceptEncoding = HttpContext.Current.Request.Headers["Accept-Encoding"];
        if (!string.IsNullOrEmpty(AcceptEncoding) &&
                (AcceptEncoding.Contains("gzip") || AcceptEncoding.Contains("deflate")))
            return true;
        return false;
    }



    protected void Page_Load(object sender, EventArgs e)
    {



       


    }


    protected void Page_PreInit(object sender, EventArgs e)
    {

        if ( khatam.core.ConfigurationManager.License.demo)
          ltr_demo.Text= khatam.core.UI.SectionManager.demoBarHtml();

        

     //   string html = "<!-- Begin WebGozar.com Counter code --><script type=\"text/javascript\" language=\"javascript\" src=\"http://www.webgozar.ir/c.aspx?Code=1738494&amp;t=counter\" ></script><noscript><a href=\"http://www.webgozar.com/counter/stats.aspx?code=1738494\" target=\"_blank\">&#1570;&#1605;&#1575;&#1585;</a></noscript><!-- End WebGozar.com Counter code -->"
//+ " <script type=\"text/javascript\">var _gaq = _gaq || []; _gaq.push(['_setAccount', 'UA-17845103-1']); _gaq.push(['_trackPageview']); (function () { var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true; ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js'; var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s); })();</script>";




        if (khatam.core.ConfigurationManager.License.demo )
        ltl_status_script.Text = khatam.core.UI.SectionManager.demoFooterScript() ;

        string section_str = "", content_id = "";

        string UserId = "0";
      

            if (khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString() != "-1")
            {

                this.faviicon.Href = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/upload/favicon/favicon.ico";

               


                try
                {
                    section_str = HttpContext.Current.Items["contentType"].ToString();
                }
                catch
                {
                    section_str = "default";
                }

                try
                {
                    content_id = HttpContext.Current.Items["id"].ToString();
                    
                }
                catch
                {

                }

               

                if (content_id != "")
                {
                    section_str = section_str + "_item";
                }

              

          
           

                string section_id="11111";
                string core_section_val_table;
         
                
                if (section_str.StartsWith("_"))
                {
                section_id = khatam.core.data.sql.getField( "id", "title", section_str, "Core_section_option");
                core_section_val_table = "Core_sectionVal_option";

                }
                else
                {
                section_str = section_str + ".aspx";
                section_id = khatam.core.data.sql.getField( "id", "title", section_str, "core_section");
                core_section_val_table = "Core_sectionVal";
                    
               }
               // section_id = khatam.core.data.sql.getField("DefaultAspxPage_PreInit", "id", "title", "test", "core_section");

              

                try
                {


                    EditMode = bool.Parse(Request.Cookies["topbar"].Value);

                }
                catch
                {
                    EditMode = false;
                }

               

                if (EditMode)
                {
                    UserId = khatam.core.Security.Users.login().ToString();

                }

                bool EditModePermission = false;

                if (EditMode && (UserId != "0"))
                {


                    DataTable dt = new DataTable();
                    dt = Khatam_Functions.KUI.Database.sql.Sql_Get_Col("idPermission", "idUser", UserId, "corePermissionRefUser", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        switch (dt.Rows[i].ItemArray[0].ToString())
                        {
                            case "1":
                                this.AccessVisualContentManager_div.Visible = true;
                                EditModePermission = true;
                                break;
                            case "2":
                                AccessLayoutManager_div.Visible = true;
                                break;
                            default:
                                break;
                        }

                       
                    }

                    this.topbar_div.Visible = true;
                    this.toolbar2.Visible = true;

               





                 /*   this.HL_Lang1.NavigateUrl = "~/layout.aspx?id=" + idStr + "&lang=1";
                    this.HL_Lang2.NavigateUrl = "~/layout.aspx?id=" + idStr + "&lang=2";
                    this.HL_Lang3.NavigateUrl = "~/layout.aspx?id=" + idStr + "&lang=3";
                    this.HL_Lang4.NavigateUrl = "~/layout.aspx?id=" + idStr + "&lang=4";*/
                }
                else
                {
                    this.topbar_div.Visible = false;
                    this.toolbar2.Visible = false;
                }
                

              

               // doc_div.ID = khatam.core.data.sql.getField("default","yui_id","id_core"
                //    khatam.core.data.sql.getField("DefaultAspxPage_PreInit", "yui_id", "title", section_str, "core_section");
               // doc_div.Attributes["class"] = khatam.core.data.sql.getField("DefaultAspxPage_PreInit", "yui_class", "title", section_str, "core_section");
               // yui.Attributes["class"] = khatam.core.data.sql.getField("DefaultAspxPage_PreInit", "yuig", "title", section_str, "core_section");

                string lang = "";
                try
                {


                    lang = HttpContext.Current.Items["lang"].ToString();



                }
                catch
                {
                }

                string langId;

                switch (lang)
                {
                    case "fa":
                        langId = "1";
                        break;
                    case "en":
                        langId = "2";
                        break;
                    case "ar":
                        langId = "3";
                        break;
                    case "de":
                        langId = "4";
                        break;

                    default:
                        langId = "1";
                        break;
                }


                    string theme;
        theme = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("theme", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                
                //SELECT     id_Core_Section, propertyValue, language, propertyTitle  FROM        
                //Core_sectionVal  WHERE     (id_Core_Section = 3) AND (language = 1) AND (propertyTitle = N'yui_id')

                //Label2.Text = langId ;
                    //khatam.core.data.sql.getField("default", "propertyValue", "id_Core_Section","3", "propertyTitle", "yui_id", "language", "1", "Core_sectionVal");

                //Title = section_id;

                doc_div.ID = khatam.core.UI.SectionManager.getProperty(section_id, "yui_id", langId);

                //khatam.core.data.sql.getField("default", "propertyValue", "id_Core_Section", section_id, "propertyTitle", "yui_id", "language", langId, core_section_val_table);

               

                string yui_class;
                yui_class = khatam.core.UI.SectionManager.getProperty(section_id, "yui_class", langId);
                
               // khatam.core.data.sql.getField("default", "propertyValue", "id_Core_Section", section_id, "propertyTitle", "yui_class", "language", langId, core_section_val_table);
                doc_div.Attributes["class"] = yui_class ;

               string yuig;
               yuig = khatam.core.UI.SectionManager.getProperty(section_id, "yuig1", langId); 
                //khatam.core.data.sql.getField("default", "propertyValue", "id_Core_Section", section_id, "propertyTitle", "yuig1", "language", langId, core_section_val_table);
               yui.Attributes["class"] = yuig;

                

                setTitleAndSeoTags(section_id, langId);

                khatam.core.UI.SectionManager.load_section_placeholders(section_str, this, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString(), langId, EditModePermission, false,theme );
              // Khatam_Functions.KUI.modular.ui.load_section_placeholders(section_str, this, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString(), langId, EditModePermission, false);


                if ((this.PH_u.Controls.Count > 0) || (this.PH_ufrist.Controls.Count > 0))
                    this.yui.Visible = true;

               if (yui_class == "yui-t7")
                   this.PH_NAVIGATION.Visible = false  ;



               setJavaScript(EditMode);
                setCss(EditMode,theme );



            }
            else
            {
                Label lbl1 = new Label();
                lbl1.Text = "لایسنس پرتال اتمام یافته است";
                PH_exheader.Controls.Add(lbl1);

            }






         //  this.PlaceHolder1.Controls.Add(mPop );

        //     <cc1:ModalPopupExtender ID="UpdatePanel1_Modal_msgDel" runat="server" BackgroundCssClass="ModalPopupBG"
          //      DynamicServicePath="" Enabled="True" TargetControlID="Button1" PopupControlID="msgDel">
          //  </cc1:ModalPopupExtender>

            this.DataList1.DataSource = getSection_webSiteMenu("1");

            this.DataList1.DataBind();

            this.DataList_lang.DataSource = getLanguageSection("1");

            this.DataList_lang.DataBind();


            string userEmail = khatam.core.Security.Users.getEmail(UserId);
            string userRealName = khatam.core.Security.Users.getRealName(UserId);

            ph_userInfo.Controls.Add(new LiteralControl("کاربر گرامی: " + userRealName));
            ph_userInfo.Controls.Add(new LiteralControl("<br />"));
            ph_userInfo.Controls.Add(new LiteralControl(userEmail));


    }

    

        public static DataTable getLanguageSection(string LangId)
    {
        string content_type = "", contentId = "";
        try
        {
            content_type = HttpContext.Current.Items["contentType"].ToString() +"/";
        }
        catch
        {
            //"defualt"
            content_type = "";
        }

        string lang = "";
        try
        {


            lang = HttpContext.Current.Items["lang"].ToString();



        }
        catch
        {
        }

        try
        {
            contentId = HttpContext.Current.Items["id"].ToString();

        }
        catch
        {

        }

     


        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        // parameters.Add("field_where_value", field_where_value);
        //  str_sql = ("SELECT N'layout.aspx?id=' + cast (id as nvarchar) + N'&lang=' + '" +  LangId  + "'  AS N'id', title  from Core_section");
        if (contentId == "")
        {
            str_sql = "SELECT [title] ,N'" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                + "'+ [url] + N'/web/" + content_type + "' As 'url'   FROM [Language]";
        }
        else
        {
            str_sql = "SELECT [title] ,N'" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
             + "'+ [url] + N'/web/" + content_type +  contentId  + "/' As 'url'   FROM [Language]";
        }
      
      return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString());
    }
    
    public  void  setUrlLabels()
    {
        string content_type = "",content_type2="", contentId = "";
        try
        {
            content_type = HttpContext.Current.Items["contentType"].ToString() +"/";
            content_type2 =HttpContext.Current.Items["contentType"].ToString()  ;
        }
        catch
        {
            //"defualt"
            content_type = "";
            content_type2="default";
        }

        try
        {
            contentId = HttpContext.Current.Items["id"].ToString();

        }
        catch
        {

        }

        string lang = "", langUrl="",langTitle="";
        try
        {
            lang = HttpContext.Current.Items["lang"].ToString() ;
            langUrl = HttpContext.Current.Items["lang"].ToString();
            langTitle = khatam.core.data.sql.getField("title","url",langUrl ,"language");
           
        }
        catch
        {
        }

        ph_pageInfo.Controls.Clear();

    
            if (!content_type2.StartsWith("_"))
            {
                if (contentId == "")
                {


                    if (lang == "")
                    {
                        string content_type_IdDictionary = khatam.core.data.sql.getField("IdDictionary", "title", content_type2 + ".aspx", "Core_section");
                        string content_type_LangTitle =
                            khatam.core.data.sql.getField( "title", "id_dictionary", content_type_IdDictionary, "id_language", "1", "Dictionary_Lang");


                        ph_pageInfo.Controls.Add(new LiteralControl(content_type_LangTitle + " - Persian فارسی (Iran)"));
                        ph_pageInfo.Controls.Add(new LiteralControl("<br />"));
                        TextBox txt_url = new TextBox { ReadOnly = true, Width = Unit.Pixel(300) };
                        txt_url.Text = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  + "web/" + content_type;
                        ph_pageInfo.Controls.Add(txt_url);
                        ph_pageInfo.Controls.Add(new LiteralControl("<a href=\"#\" class=\"tooltipA\"  onmouseover=\"return tooltip('کاربر گرامی برای لینک به این صفحه از منو ها ، ویرایشگر محتوا ، اشیا و یا حتی سایت های دیگر لینک مقابل را کپی و در قسمت لینک درج نمایید','راهنما','direction:rtl,width:300');\" onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));
                        ph_pageInfo.Controls.Add(new LiteralControl("[لینک]"));
                    }
                    else
                    {
                        string content_type_IdDictionary = khatam.core.data.sql.getField("IdDictionary", "title", content_type2 + ".aspx", "Core_section");
                        string content_type_LangTitle =
                            khatam.core.data.sql.getField( "title", "id_dictionary", content_type_IdDictionary, "id_language", "1", "Dictionary_Lang");


                        ph_pageInfo.Controls.Add(new LiteralControl(content_type_LangTitle + " - " + langTitle));
                        ph_pageInfo.Controls.Add(new LiteralControl("<br />"));
                        TextBox txt_url = new TextBox { ReadOnly = true, Width = Unit.Pixel(300) };
                        txt_url.Text = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + lang + "/" + "web/" + content_type;
                        ph_pageInfo.Controls.Add(txt_url);
                        ph_pageInfo.Controls.Add(new LiteralControl("<a href=\"#\" class=\"tooltipA\"  onmouseover=\"return tooltip('کاربر گرامی برای لینک به این صفحه از منو ها ، ویرایشگر محتوا ، اشیا و یا حتی سایت های دیگر لینک مقابل را کپی و در قسمت لینک درج نمایید','راهنما','direction:rtl,width:300');\" onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));
                        ph_pageInfo.Controls.Add(new LiteralControl("[لینک]"));
                    }

      

                }
                else
                {
                    if (lang == "")
                    {
                        string content_type_IdDictionary = khatam.core.data.sql.getField( "IdDictionary", "title", content_type2 + "_item.aspx", "Core_section");
                        string content_type_LangTitle =
                            khatam.core.data.sql.getField( "title", "id_dictionary", content_type_IdDictionary, "id_language", "1", "Dictionary_Lang");


                        ph_pageInfo.Controls.Add(new LiteralControl(content_type_LangTitle + " - Persian فارسی (Iran)"));
                        ph_pageInfo.Controls.Add(new LiteralControl("<br />"));      
                        ph_pageInfo.Controls.Add(new LiteralControl("<a href=\"#\" class=\"tooltipA\"  onmouseover=\"return tooltip('لینک صفحه نمایش بر اساس کد محتوایی که در آن نمایش داده می شود تعیین می گردد و برای لینک به هریک از انواع محتوا لینک مورد نظرتان را در هنگام ویرایش محتوا و قسمت اطلاعات پایه خواهید یافت','راهنما','direction:rtl,width:300');\" onmouseout=\"return hideTip();\" onClick=\"return false;\">[راهنمای یافتن لینک این صفحه]</a>"));
                        //ph_pageInfo.Controls.Add(new LiteralControl("[لینک]"));
                    }
                    else
                    {
                        string content_type_IdDictionary = khatam.core.data.sql.getField( "IdDictionary", "title", content_type2 + "_item.aspx", "Core_section");
                        string content_type_LangTitle =
                            khatam.core.data.sql.getField( "title", "id_dictionary", content_type_IdDictionary, "id_language", "1", "Dictionary_Lang");


                        ph_pageInfo.Controls.Add(new LiteralControl(content_type2 + " - " + langTitle));
                        ph_pageInfo.Controls.Add(new LiteralControl("<br />"));
                        ph_pageInfo.Controls.Add(new LiteralControl("<a href=\"#\" class=\"tooltipA\"  onmouseover=\"return tooltip('لینک صفحه نمایش بر اساس کد محتوایی که در آن نمایش داده می شود تعیین می گردد و برای لینک به هریک از انواع محتوا لینک مورد نظرتان را در هنگام ویرایش محتوا و قسمت اطلاعات پایه خواهید یافت','راهنما','direction:rtl,width:300');\" onmouseout=\"return hideTip();\" onClick=\"return false;\">[راهنمای یافتن لینک این صفحه]</a>"));
                    }

               }
            }
            else
            {
               if (lang == "")
                {
                    ph_pageInfo.Controls.Add(new LiteralControl(content_type2 + " - Persian فارسی (Iran)"));
                   
                    TextBox txt_url = new TextBox { ReadOnly = true, Width = Unit.Pixel(300) };
                    ph_pageInfo.Controls.Add(new LiteralControl("<br />"));
                    txt_url.Text = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath  + "web/" + content_type;
                    ph_pageInfo.Controls.Add(txt_url);
                    ph_pageInfo.Controls.Add(new LiteralControl("<a href=\"#\" class=\"tooltipA\"  onmouseover=\"return tooltip('کاربر گرامی برای لینک به این صفحه از منو ها ، ویرایشگر محتوا ، اشیا و یا حتی سایت های دیگر لینک مقابل را کپی و در قسمت لینک درج نمایید','راهنما','direction:rtl,width:300');\" onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));
                    ph_pageInfo.Controls.Add(new LiteralControl("[لینک]"));

                }
                else
                {
                    ph_pageInfo.Controls.Add(new LiteralControl(content_type2 + " - " + langTitle));                  
                    TextBox txt_url = new TextBox { ReadOnly = true, Width = Unit.Pixel(300) };
                    ph_pageInfo.Controls.Add(new LiteralControl("<br />"));
                    txt_url.Text = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +  lang + "/" + "web/" + content_type;
                    ph_pageInfo.Controls.Add(txt_url);
                    ph_pageInfo.Controls.Add(new LiteralControl("<a href=\"#\" class=\"tooltipA\"  onmouseover=\"return tooltip('کاربر گرامی برای لینک به این صفحه از منو ها ، ویرایشگر محتوا ، اشیا و یا حتی سایت های دیگر لینک مقابل را کپی و در قسمت لینک درج نمایید','راهنما','direction:rtl,width:300');\" onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));
                    ph_pageInfo.Controls.Add(new LiteralControl("[لینک]"));

                }

            }
      
      
   
    }

   

    public static DataTable getSection_webSiteMenu(string LangId)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        string lang = "";
        try
        {
            lang = HttpContext.Current.Items["lang"].ToString();       

        }
        catch
        {
        }


        if (lang == "")
        {
            str_sql = "(SELECT     N'" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
            + "web/' + REPLACE( replace(core_section.title,N'_item.aspx','/1/'),N'.aspx','/')  AS N'id', Dictionary_Lang.title as title " +
 "FROM         Dictionary_Lang INNER JOIN " +
                       " Dictionary ON Dictionary_Lang.id_dictionary = Dictionary.id INNER JOIN " +
                       " Core_section ON Dictionary.id = Core_section.IdDictionary  where ( " + khatam.core.UI.ObjectManager.getPageSqlWhere() +
                //  "  ) order by Dictionary_Lang.title " +
                           "  )  " +
                          " union " +
 " SELECT  N'" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
     + "web/' + REPLACE( replace(Core_section_option.title,N'_item.aspx','/1/'),N'.aspx','/')  " +
   " AS N'id', Core_section_option.title as title " +
   " FROM [Core_section_option]  ) order by title "
        ;
        }
        else
        {
            str_sql = "(SELECT     N'" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
           + lang   + "/web/' + REPLACE( replace(core_section.title,N'_item.aspx','/1/'),N'.aspx','/')  AS N'id', Dictionary_Lang.title as title " +
 "FROM         Dictionary_Lang INNER JOIN " +
                       " Dictionary ON Dictionary_Lang.id_dictionary = Dictionary.id INNER JOIN " +
                       " Core_section ON Dictionary.id = Core_section.IdDictionary  where ( " + khatam.core.UI.ObjectManager.getPageSqlWhere() +
                //  "  ) order by Dictionary_Lang.title " +
                           "  )  " +
                          " union " +
 " SELECT  N'" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath 
    +lang + "/web/' + REPLACE( replace(Core_section_option.title,N'_item.aspx','/1/'),N'.aspx','/')  " +
   " AS N'id', Core_section_option.title as title " +
   " FROM [Core_section_option]  ) order by title "
        ;
        }



        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString());
    }
    

    void setTitleAndSeoTags(string section_id, string langId)
    {
     
        string section_str = "", content_id = "";
        
        try
        {
            section_str = HttpContext.Current.Items["contentType"].ToString();
        }
        catch
        {
            section_str = "default";
        }

        try
        {
            content_id = HttpContext.Current.Items["id"].ToString();

        }
        catch
        {
        }


        string strItemTitle = "", strItemKeywords = "", strItemDescription = "", strItemAuthor = "";

        if ((content_id != ""))
        {
            try
            {
                strItemKeywords = khatam.core.data.sql.getMetaTagByItem(content_id, section_str);
            }
            catch
            {
            }

            try
            {
                strItemTitle = " | " + khatam.core.data.sql.getField( "title", "id", content_id, section_str);

            }
            catch
            {

            }

            try
            {
                strItemDescription = khatam.core.data.sql.getField( "description", "id", content_id, section_str);

            }
            catch
            {

            }

            try
            {
                strItemAuthor = khatam.core.data.sql.getField( "Author", "id", content_id, section_str);

            }
            catch
            {

            }
        }

        string cat_id = "";

        try
        {
            cat_id = HttpContext.Current.Request.QueryString["cat"].ToString();

        }
        catch
        {

        }

        if ((cat_id != ""))
        {
            strItemKeywords = khatam.core.UI.SectionManager.getProperty(section_id, "keywords", langId) + " " + Request.QueryString["title"];
            strItemTitle = " | " + Request.QueryString["title"];
            strItemDescription = khatam.core.UI.SectionManager.getProperty(section_id, "Description", langId);
            strItemAuthor = khatam.core.UI.SectionManager.getProperty(section_id, "Author", langId);
        }

        link_logout.HRef=khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Default.aspx?mode=logout";

        if (section_str != "search")
        {

            this.Title = khatam.core.UI.SectionManager.getProperty(section_id, "Title", langId) + strItemTitle;
        }
        else
        {
            this.Title = khatam.core.UI.SectionManager.getProperty(section_id, "Title", langId) + " : " + this.Request.QueryString["q"];
        }


        try
        {
            System.Web.UI.HtmlControls.HtmlMeta meta1 = new System.Web.UI.HtmlControls.HtmlMeta();
            meta1.Name = "keywords";
            if (strItemKeywords != "")
            {
                meta1.Content = strItemKeywords;
            }
            else
            {
                meta1.Content = khatam.core.UI.SectionManager.getProperty(section_id, "keywords", langId);
            }
            MetaPlaceHolder.Controls.Add(meta1);
        }
        catch
        {
        }

        try
        {
            System.Web.UI.HtmlControls.HtmlMeta meta2 = new System.Web.UI.HtmlControls.HtmlMeta();
            meta2.Name = "Description";
            if (strItemDescription != "")
            {
                meta2.Content = strItemDescription;
            }
            else
            {
                meta2.Content = khatam.core.UI.SectionManager.getProperty(section_id, "Description", langId);
            }
            MetaPlaceHolder.Controls.Add(meta2);
        }
        catch
        {
        }

        try
        {
            System.Web.UI.HtmlControls.HtmlMeta meta3 = new System.Web.UI.HtmlControls.HtmlMeta();
            meta3.Name = "Author";
            if (strItemAuthor != "")
            {
                meta3.Content = strItemAuthor;
            }
            else
            {
                meta3.Content = khatam.core.UI.SectionManager.getProperty(section_id, "Author", langId);
            }
            MetaPlaceHolder.Controls.Add(meta3);
        }
        catch
        {
        }


        HtmlMeta meta4 = new HtmlMeta();
        meta4.Name = "robots";
        meta4.Content = "INDEX,FOLLOW";
        MetaPlaceHolder.Controls.Add(meta4);

    }
    
    void setJavaScript(bool editMode)
    {
         //  <script src="core/js/jquery-1.8.3.js" type="text/javascript"></script>
         //   <script src="core/js/jquery-ui.1.9.2.js" type="text/javascript"></script>
         //   <link href="core/css/smoothness/jquery-ui-1.9.2.custom.css" rel="stylesheet" type="text/css" />


       Shinkansen.Web.UI.WebControls.JavaScriptInclude js1 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
       js1.Path = "~/core/js/jquery-1.9.1.js";
       StaticResourceManager1.JavaScript.Add(js1);

       Shinkansen.Web.UI.WebControls.JavaScriptInclude js11 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
       js11.Path = "~/core/js/jquery-ui-1.10.3.custom.js";
       StaticResourceManager1.JavaScript.Add(js11);

       Shinkansen.Web.UI.WebControls.JavaScriptInclude js3 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
       js3.Path = "~/core/js/jquery.carouFredSel-6.2.0-packed.js";
       StaticResourceManager1.JavaScript.Add(js3);


       Shinkansen.Web.UI.WebControls.JavaScriptInclude js4 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
       js4.Path = "~/highslide/highslide-full.js";
       StaticResourceManager1.JavaScript.Add(js4);
    



    //<script src="core/js/skinnytip.js" type="text/javascript"></script>





       // Shinkansen.Web.UI.WebControls.JavaScriptInclude js2 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
       // js2.Path = "~/core/js/jquery.tools.min.js";
       // StaticResourceManager1.JavaScript.Add(js2);


      //  Shinkansen.Web.UI.WebControls.JavaScriptInclude js1 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
      //  js1.Path = "~/core/js/jquery-ui.1.9.2.js";
      //  StaticResourceManager1.JavaScript.Add(js1);

        // <script src="core/js/jquery-1.7.2.min.js" type="text/javascript"></script>
     //   Shinkansen.Web.UI.WebControls.JavaScriptInclude js2 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
     //   js2.Path = "~/core/js/slide_show/jquery.cycle.all.js";
     //   StaticResourceManager1.JavaScript.Add(js2);

      //  Shinkansen.Web.UI.WebControls.JavaScriptInclude js3 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
       // js3.Path = "~/core/js/slide_show/jquery.easing.1.3.js";
       // StaticResourceManager1.JavaScript.Add(js3);

       // Shinkansen.Web.UI.WebControls.JavaScriptInclude js4 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
       // js4.Path = "~/core/js/skinnytip.js";
       // StaticResourceManager1.JavaScript.Add(js4);

       /// Shinkansen.Web.UI.WebControls.JavaScriptInclude js5 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
      //  js5.Path = "~/core/js/acidTabs.js";
      //  StaticResourceManager1.JavaScript.Add(js5);

        if (EditMode)
        {
            setUrlLabels();
          //  Shinkansen.Web.UI.WebControls.JavaScriptInclude js1 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
          //  js1.Path = "~/core/js/jquery-1.7.2.min.js";
          //  StaticResourceManager1.JavaScript.Add(js1);

            Shinkansen.Web.UI.WebControls.JavaScriptInclude js2 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
            js2.Path = "~/core/js/skinnytip.js";
            StaticResourceManager1.JavaScript.Add(js2);

            //<script src="~/core/js/skinnytip.js" type="text/javascript"></script>

            //    Shinkansen.Web.UI.WebControls.JavaScriptInclude js3 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
            //  js3.Path = "~/Scripts/jquery-ui-1.8.16.custom.min.js";
            //  StaticResourceManager1.JavaScript.Add(js3);

        }

    }

    void setCss(bool editMode,string theme)
    {




        Shinkansen.Web.UI.WebControls.CssInclude css1 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css1.Path = "~/theme/" + theme  + "/StyleSheet.css";
        StaticResourceManager1.Css.Add(css1);

      //  Shinkansen.Web.UI.WebControls.CssInclude css4 = new Shinkansen.Web.UI.WebControls.CssInclude();
    //  css4.Path = "~/core/css/jquery-ui-1.10.3.custom.css";
       //StaticResourceManager1.Css.Add(css4);
      
        Shinkansen.Web.UI.WebControls.CssInclude css2 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css2.Path = "~/highslide/highslide.css";
        StaticResourceManager1.Css.Add(css2);
        
    

        if (EditMode)
        {
            Shinkansen.Web.UI.WebControls.CssInclude css3 = new Shinkansen.Web.UI.WebControls.CssInclude();
            css3.Path = "~/core/themeCP/Bitrix/StyleSheet.css";
            StaticResourceManager1.Css.Add(css3);
        }
    }


  
 
}