
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using khatam;
using System.Data;
using Telerik.WebControls;


public partial class Layout : System.Web.UI.Page
{
    public bool EditMode = false;

    protected void Page_Load(object sender, EventArgs e)
    {

       // this.Title = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) + " || کنترل پنل ";

              



        string idStr, lang;
        idStr = "3";
        lang = "1";

        if (this.Request.QueryString["id"] != null)
        {
            idStr = this.Request.QueryString["id"];
        }

        if (this.Request.QueryString["lang"] != null)
        {
            lang = this.Request.QueryString["lang"];
        }


        if (this.Page.IsPostBack == false)
        {
            
   
            txtSectionTitle.Text = khatam.core.UI.SectionManager.getProperty( idStr, "title", lang);
            this.txtSectionKeywords.Text = khatam.core.UI.SectionManager.getProperty(idStr, "keywords", lang);
            this.txtSectionDescription.Text = khatam.core.UI.SectionManager.getProperty(idStr, "Description", lang);
            this.txtSectionAuthor.Text = khatam.core.UI.SectionManager.getProperty(idStr, "Author", lang);
            this.DDLSectionChangefreq.SelectedValue = khatam.core.UI.SectionManager.getProperty(idStr, "changefreq", lang);
            this.DDLSectionPriority.SelectedValue = khatam.core.UI.SectionManager.getProperty(idStr, "priority", lang);

            this.DdlBodySize.SelectedValue = khatam.core.UI.SectionManager.getProperty(idStr, "yui_id", lang);

            this.DdlBodyCol.SelectedValue = khatam.core.UI.SectionManager.getProperty(idStr, "yui_class", lang);
            this.DdlContentCol.SelectedValue = khatam.core.UI.SectionManager.getProperty(idStr, "yuig1", lang); 
       

        
               
        }

        //doc_div.ID = khatam.core.data.sql.getField("default", "propertyValue", "id_Core_Section", idStr, "propertyTitle", "yui_id", "language", lang, "Core_sectionVal");
       






        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            btnSaveObjectStatus.Enabled = false;
            btnSaveObjectStatus.ToolTip = "در نسخه دمو امکان تغییر وجود ندارد";
        }
        
        if (System.Configuration.ConfigurationManager.AppSettings.Get(0) == "false")
        {
            //this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "/install/");
            Context.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "install/");
        }

        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();



        string UserId = "0";

      
        UserId = khatam.core.Security.Users.login().ToString();
              
        bool AccessLayoutManager = false;

        if (UserId != "0")
        {


            DataTable dt = new DataTable();
            dt = Khatam_Functions.KUI.Database.sql.Sql_Get_Col("idPermission", "idUser", UserId, "corePermissionRefUser", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                switch (dt.Rows[i].ItemArray[0].ToString())
                {
                    case "1":
                        this.AccessVisualContentManager_div.Visible = true;
                        break;
                    case "2":
                        AccessLayoutManager_div.Visible = true;
                        AccessLayoutManager = true;
                        break;
                    default:
                        break;
                }


            }
        }

            //this.toolbar2.Visible = true;
 
        if (AccessLayoutManager)
        {

        }
else 
        {
        this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/login.aspx");
        }
        
        
            this.topbar_div.Visible = true;
        
       
        
        
        
       // this.Title = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("Title", 1, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        DataSet  ds = new DataSet ();

        this.DataList1.DataSource = khatam.core.UI.SectionManager.getSection("1");
        this.DataList1.DataBind();

   


        

        this.HL_Lang1.NavigateUrl = "~/layout.aspx?id=" + idStr  + "&lang=1";
        this.HL_Lang2.NavigateUrl = "~/layout.aspx?id=" + idStr + "&lang=2";
        this.HL_Lang3.NavigateUrl = "~/layout.aspx?id=" + idStr + "&lang=3";
        this.HL_Lang4.NavigateUrl = "~/layout.aspx?id=" + idStr + "&lang=4";


 



    }

 
    protected void Page_PreInit(object sender, EventArgs e)
    {

        if (khatam.core.ConfigurationManager.License.demo)
        {
           ltr_demo.Text = khatam.core.UI.SectionManager.demoBarHtml();
           ltl_status_script.Text = khatam.core.UI.SectionManager.demoFooterScript();
            
           Button1.Enabled = false;
           Button1.ToolTip = "در نسخه دمو این امکان وجود ندارد";
            
           Button2.Enabled = false;
           Button2.ToolTip = "در نسخه دمو این امکان وجود ندارد";
            
           btnSaveObjectStatus.Enabled = false;
           btnSaveObjectStatus.ToolTip = "در نسخه دمو این امکان وجود ندارد";

           DdlContentCol.Enabled = false;
           DdlContentCol.ToolTip = "در نسخه دمو این امکان وجود ندارد";

           DdlBodyCol.Enabled = false;
           DdlBodyCol.ToolTip = "در نسخه دمو این امکان وجود ندارد";

           DdlBodySize.Enabled = false;
           DdlBodySize.ToolTip = "در نسخه دمو این امکان وجود ندارد";

            



        }


        string idStr, lang;
        idStr = "3";
        lang = "1";

        if (this.Request.QueryString["id"] != null)
        {
            idStr = this.Request.QueryString["id"];
        }

        if (this.Request.QueryString["lang"] != null)
        {
            lang = this.Request.QueryString["lang"];
        }


        string section_str;
      //  section_str = "default.aspx";// (this.Page.ToString().Replace("ASP.", "").Replace("_aspx", "") + ".aspx");




        string Core_sectionVal_table = "";
        string id_Core_Section = "";
        if (int.Parse(idStr) >999)
        {
            Core_sectionVal_table="Core_sectionVal_option";
            id_Core_Section = "id_Core_section_option";

                  section_str = khatam.core.data.sql.getField( "title", "id", this.Request.QueryString["id"], "core_section_option");
                
        }
        else
        {
            if (this.Request.QueryString["id"] != null)
            {
                section_str = khatam.core.data.sql.getField( "title", "id", this.Request.QueryString["id"], "core_section");
            }
            else
            {
                section_str = "default.aspx";
            }
        
            
            Core_sectionVal_table = "Core_sectionVal";
            id_Core_Section = "id_Core_Section";

        }

        //this.DdlBodySize.SelectedValue = khatam.core.UI.SectionManager.getProperty(idStr, "yui_id", lang);

        doc_div.ID = khatam.core.UI.SectionManager.getProperty(idStr, "yui_id", lang);
            // khatam.core.data.sql.getField("default", "propertyValue", id_Core_Section, idStr, "propertyTitle", "yui_id", "language", lang, Core_sectionVal_table);
        //Title = doc_div.ID;

        string yui_class = khatam.core.UI.SectionManager.getProperty(idStr, "yui_class", lang);
        doc_div.Attributes["class"] = yui_class;

        if (yui_class == "yui-t7")
        {
            this.RadDockingZone_NAVIGATION.Visible = false;
            this.dvNavigation.Visible = false;
        }

       // khatam.core.data.sql.updateField("propertyValue", DdlBodyCol.SelectedValue, "propertyTitle", "yui_class", "Core_sectionVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        string yuig;
        yuig =khatam.core.UI.SectionManager.getProperty(idStr, "yuig1", lang);
            //\khatam.core.data.sql.getField("default", "propertyValue", id_Core_Section, idStr, "propertyTitle", "yuig1", "language", lang, Core_sectionVal_table);
        yui.Attributes["class"] = yuig;

        

            this.yui.Visible = true;


        
        string theme_str;
        theme_str = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("theme", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


          
            CreateDockableObjects(section_str, lang,theme_str );



        setCss(true,theme_str );
        setJavaScript(true );

        setUrlLabels();
    }




    DateTime startTime = DateTime.Now;

    protected override void OnPreRender(EventArgs e)
    {

        base.OnPreRender(e);

        

    }

    public void setUrlLabels()
    {
        string id = "3", lang = "1";
        
        if ( this.Request.QueryString["id"] !=null )
        {
            id = this.Request.QueryString["id"] ;
        }
        
        if ( this.Request.QueryString["lang"] != null )
        {
            lang = this.Request.QueryString["lang"] ;
        }
        


        
                
        ph_pageInfo.Controls.Clear();

        string content_type_LangTitle;
        if (int.Parse(id) >= 1000)
        {
            content_type_LangTitle = khatam.core.data.sql.getField( "title", "id", id, "core_section_option");
        }
        else
        {
            string Core_section_IdDictionary = khatam.core.data.sql.getField( "IdDictionary", "id", id, "core_section");
            content_type_LangTitle = khatam.core.data.sql.getField( "title", "id_dictionary", Core_section_IdDictionary, "id_language", "1", "Dictionary_Lang");            
        }
         
        

                    string LangTitle = khatam.core.data.sql.getField( "title", "id", lang, "Language");
                    ph_pageInfo.Controls.Add(new LiteralControl(content_type_LangTitle + " - " + LangTitle));
                    ph_pageInfo.Controls.Add(new LiteralControl("<br />"));                  

    }

    void CreateDockableObjects(string section_title , string langId,string theme)
    {
        DataTable dt = new DataTable();
        //dt = get_section_from_db(section_title, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
      //  Title = "jjjj" + section_title;
        if (section_title.StartsWith("_"))
        {
            dt = getServerControlTitle_option(section_title, "ph_header", langId, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            // dt.Rows.Count.ToString();
                
        }
        else
        {
            dt = getServerControlTitle(section_title, "ph_header", langId, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        }   
                



            
        int i;
        for (i = 0; (i
                    <= (dt.Rows.Count - 1)); i++)
        //for (i = 0; (i
        //            <= 10); i++)
        {
            //Telerik.WebControls.RadDockableObject radDockableObject1 = CreateDockableObjectFromAscx(dt.Rows[i].ItemArray[0].ToString() , dt.Rows[i].ItemArray[2].ToString());

            //Telerik.WebControls.RadDockableObject radDockableObject1 = CreateDockableObjectFromAscx("","");

        Telerik.WebControls.RadDockableObject radDockableObject1 = new RadDockableObject();
       


        radDockableObject1.Text =  dt.Rows[i].ItemArray[1].ToString();
            Telerik.WebControls.RadDockableObjectCommand rad_cmd = new Telerik.WebControls.RadDockableObjectCommand();
            Telerik.WebControls.RadDockableObjectCommand rad_cmd2 = new Telerik.WebControls.RadDockableObjectCommand();
            // radDockableObject1.Behavior = RadDockableObjectBehaviorFlags.Collapse
            rad_cmd.Name = "Close";
            rad_cmd.ToolTip = "Close";
            rad_cmd.OnClientCommand = "alertCommand";
            rad_cmd2.Name = "Collapse";
            rad_cmd2.ToolTip = "Collapse";
            radDockableObject1.Commands.Add(rad_cmd2);
            radDockableObject1.Commands.Add(rad_cmd);
            radDockableObject1.ID = ("ddddd" + i);
            radDockableObject1.Width = System.Web.UI.WebControls.Unit.Percentage(100);// "";
            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_header"))
            {
            Label lbl1 = new Label();
            lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
            radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false,false ,theme  ));
            RadDockingZone_hd.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }


            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_content"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                this.RadDockingZone_content.Controls.Add(radDockableObject1);
                
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }

            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_content2"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                this.RadDockingZone_content2.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }

            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_NAVIGATION"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                this.RadDockingZone_NAVIGATION.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }

            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_ufrist"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                raddockingzone_ufrist.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }

            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_u"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                RadDockingZone_u.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }



            if ((dt.Rows[i].ItemArray[2].ToString() == "ph_beforeft"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                RadDockingZone_beforeft.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }


            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_Footer"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                RadDockingZone_Footer.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }



            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_exFooter"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                
                this.RadDockingZone_exFooter.Controls.Add(radDockableObject1);
                

                //this.RadDockingZone_exFooter.tit;
                
                //this. .Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }



            if ((dt.Rows[i].ItemArray[2].ToString() == "PH_exheader"))
            {
                Label lbl1 = new Label();
                lbl1.Text = dt.Rows[i].ItemArray[2].ToString();
                radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(dt.Rows[i].ItemArray[0].ToString(), dt.Rows[i].ItemArray[1].ToString(), "0", false, false, theme));
                this.RadDockingZone_exheader.Controls.Add(radDockableObject1);
                //PH_header.Controls.Add(lbl1);
                //RadDockingZone_hd.Controls.Add(radDockableObject1);
            }


  

           



        
            }
        }
    


    

    public static DataTable getServerControlTitle222(string setting_section_title, string placeholder_controlid, string connectionstring)
    {
          Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        parameters.Add("setting_section_title", setting_section_title);
        parameters.Add("setting_placeholder_title", placeholder_controlid);
        parameters.Add("idLanguage", 1);
        return DBFunctions.ExecuteReader("usp_core_getServerControlTitle", parameters, System.Data.CommandType.StoredProcedure, connectionstring);
    }


    public static DataTable getServerControlTitle(string setting_section_title, string placeholder_controlid,string  langId ,string connectionstring)
    {
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        string str_sql;

        parameters.Add("setting_section_title", setting_section_title);
        parameters.Add("setting_placeholder_title", placeholder_controlid);
        parameters.Add("langId", langId);
        

        str_sql = "SELECT      Core_ServerControls.title,Core_ServerControlsInstance.id,core_placeholder.title AS idInstance " +
" FROM         Core_ServerControls INNER JOIN " +
                      " Core_ServerControlsInstance ON Core_ServerControls.id = Core_ServerControlsInstance.id_core_serverControl INNER JOIN" +
                      " Core_ServerControlsInstancePlacing ON Core_ServerControlsInstance.id = Core_ServerControlsInstancePlacing.id_core_serverControlInstance INNER JOIN" +
                      " Core_section ON Core_ServerControlsInstancePlacing.id_setting_section = Core_section.id INNER JOIN" +
                      " core_placeholder ON Core_ServerControlsInstancePlacing.id_setting_placeholder = core_placeholder.id  " +
" WHERE      (Core_section.title = @setting_section_title) AND (Core_ServerControlsInstancePlacing.idLanguage = @langId)";

        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, connectionstring);
    }

    public static DataTable getServerControlTitle_option(string setting_section_title, string placeholder_controlid, string langId, string connectionstring)
    {
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        string str_sql;

        parameters.Add("setting_section_title", setting_section_title);
        parameters.Add("setting_placeholder_title", placeholder_controlid);
        parameters.Add("langId", langId);


        str_sql = "SELECT      Core_ServerControls.title,Core_ServerControlsInstance.id,core_placeholder.title AS idInstance " +
" FROM         Core_ServerControls INNER JOIN " +
                      " Core_ServerControlsInstance ON Core_ServerControls.id = Core_ServerControlsInstance.id_core_serverControl INNER JOIN" +
                      " Core_ServerControlsInstancePlacing ON Core_ServerControlsInstance.id = Core_ServerControlsInstancePlacing.id_core_serverControlInstance INNER JOIN" +
                      " Core_section_option ON Core_ServerControlsInstancePlacing.id_setting_section = Core_section_option.id INNER JOIN" +
                      " core_placeholder ON Core_ServerControlsInstancePlacing.id_setting_placeholder = core_placeholder.id  " +
" WHERE      (Core_section_option.title = @setting_section_title) AND (Core_ServerControlsInstancePlacing.idLanguage = @langId)";

        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, connectionstring);
    }





    public static string Del_section(string id_setting_section, string idLanguage, string ConnectionString)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        parameters.Add("id_setting_section", id_setting_section);
        parameters.Add("idLanguage", idLanguage);



        //DELETE FROM corePermissionRefUser  WHERE     (idUser = @idUser) AND (idPermission = @idPermission)

        str_sql = "DELETE FROM Core_serverControlsInstancePlacing  WHERE     (id_setting_section = @id_setting_section) AND (idLanguage = @idLanguage)";

                    

        if ((DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, ConnectionString) != 1))
        {
            return "false";
        }
        else
        {
            return "true";
        }
    }

    bool save_componet_by_string(string string_of_componet_status, string section_id, string idLanguage)
    {
        //Khatam_Functions.KUI.Database.sql.Sql_Del_Row("id_setting_section", section_id, "Core_serverControlsInstancePlacing", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        Del_section(section_id, idLanguage, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString());

        string[] str_array;
        string[] field;
        int j;
        str_array = string_of_componet_status.Split(new Char [] {';' });

        // Array.Sort(str_array)
        Array.Reverse(str_array);
        int i;
        for (i = 0; (i
                    <= (str_array.Length - 1)); i++)
        {
            try
            {
                field = str_array[i].Split(new Char [] { ',' });
                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();
                a.Add("id_setting_section");
                b.Add(section_id);
                a.Add("id_setting_placeholder");
                b.Add(getRadDockingZone_id(field[1]));
                a.Add("id_core_serverControlInstance");
                b.Add(field[0]);
                a.Add("idLanguage");
                b.Add(idLanguage);

               khatam.core.data.sql.Add(a, b, "Core_serverControlsInstancePlacing");
            }
            catch (Exception ex)
            {
            }
        }
        try
        {
          //  Khatam_Functions.KUI.setting.setting_base.set_Setting_base("test"  , string_of_componet_status, 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }
        catch (Exception ex)
        {
        }
        return false ;
    }


    string getRadDockingZone_id(string placeholder_str)
    {
        string r="";
        switch (placeholder_str)
        {
            case "RadDockingZone_hd":
                r = "1";
                break;
            case "RadDockingZone_content":
                r = "2";
                break;
            case "RadDockingZone_NAVIGATION":
                r = "3";
                break;
            case "raddockingzone_ufrist":
            
                r = "4";
                break;
            case "RadDockingZone_u":
                r = "5";
                   break;
            case "RadDockingZone_content2":
                r = "6";
                break;
            case "RadDockingZone_beforeft":
                r = "7";
                break;
            case "RadDockingZone_Footer":
                r = "8";
                break;
            case "RadDockingZone_exFooter":
                r = "9";
                break;
            case "RadDockingZone_exheader":
                r = "11";
                break;
        }
        return r;
    }


    protected void btnSaveObjectStatus_Click(object sender, EventArgs e)
    {

        string idStr, lang;
        idStr = "3";
        lang = "1";

        if (this.Request.QueryString["id"] != null)
        {
            idStr = this.Request.QueryString["id"];
        }

        if (this.Request.QueryString["lang"] != null)
        {
            lang = this.Request.QueryString["lang"];
        }

        string url = "~/layout.aspx?id=" + idStr + "&lang=" + lang;


        save_componet_by_string(this.Text1.Value, idStr, lang);
        this.Response.Redirect("~/layout.aspx?id=" + idStr + "&lang=" + lang)  ;

              


 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      
        // = ((Label)(GridView1.SelectedRow.Cells[1].FindControl("Lbl_id"))).Text;



        string theme_str;
        theme_str = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("theme", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());



        Telerik.WebControls.RadDockableObject radDockableObject1 = new RadDockableObject();

     

        radDockableObject1.Text = DropDownList1.SelectedValue;

        string sctitle;
        string scid;

        scid  = khatam.core.data.sql.getField("id_core_serverControl", "id", DropDownList1.SelectedValue, "core_serverControlsInstance");

        radDockableObject1.Text = DropDownList1.SelectedValue  ;

        sctitle = khatam.core.data.sql.getField( "title", "id", scid, "core_serverControls");


        radDockableObject1.Container.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(sctitle, DropDownList1.SelectedValue, "0", false, false, theme_str));

        Telerik.WebControls.RadDockableObjectCommand rad_cmd = new Telerik.WebControls.RadDockableObjectCommand();
        Telerik.WebControls.RadDockableObjectCommand rad_cmd2 = new Telerik.WebControls.RadDockableObjectCommand();
        // radDockableObject1.Behavior = RadDockableObjectBehaviorFlags.Collapse
        rad_cmd.Name = "Close";
        rad_cmd.ToolTip = "Close";
        rad_cmd.OnClientCommand = "alertCommand";
        rad_cmd2.Name = "Collapse";
        rad_cmd2.ToolTip = "Collapse";
        //radDockableObject1.Commands.Add(rad_cmd2);
        radDockableObject1.Commands.Add(rad_cmd);
        // radDockableObject1.ID = "ddddd" & i
       // if ((this.DropDownList1.SelectedValue == "PH_header"))
        //{
          //  RadDockingZone_hd.Controls.Add(radDckableObject1);
            Label lbl = new Label();
            lbl.Text = "sssssssssssss";
            RadDockingZone_hd.Controls.Add(radDockableObject1);
            string url;
        //}
        if ((this.DropDownList1.SelectedValue == "PH_content"))
        {
            RadDockingZone_content.Controls.Add(radDockableObject1);
        }
        if ((this.DropDownList1.SelectedValue == "PH_content2"))
        {
            RadDockingZone_content2.Controls.Add(radDockableObject1);
        }
        if ((this.DropDownList1.SelectedValue == "PH_NAVIGATION"))
        {
            RadDockingZone_NAVIGATION.Controls.Add(radDockableObject1);
        }
        if ((this.DropDownList1.SelectedValue == "PH_ufrist"))
        {
           this.raddockingzone_ufrist.Controls.Add(radDockableObject1);
        }
        if ((this.DropDownList1.SelectedValue == "PH_u"))
        {
            RadDockingZone_u.Controls.Add(radDockableObject1);
        }
        if (this.DropDownList1.SelectedValue == "ph_beforeft")
        {
            RadDockingZone_beforeft.Controls.Add(radDockableObject1);
        }
        if (this.DropDownList1.SelectedValue == "PH_Footer")
        {
            RadDockingZone_Footer.Controls.Add(radDockableObject1);
        }
        if (this.DropDownList1.SelectedValue == "PH_exFooter")
        {
            RadDockingZone_exFooter.Controls.Add(radDockableObject1);
        }
        if (this.DropDownList1.SelectedValue == "PH_exheader")
        {
            RadDockingZone_exheader.Controls.Add(radDockableObject1);
        }

    }



    void setJavaScript(bool editMode)
    {
       
            //Shinkansen.Web.UI.WebControls.JavaScriptInclude js1 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
            //js1.Path = "Scripts/jquery-1.5.2.min.js";
            //StaticResourceManager1.JavaScript.Add(js1);

          //  Shinkansen.Web.UI.WebControls.JavaScriptInclude js2 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
          //  js2.Path = "~/Module/Core/Scripts/jquery-ui-1.7.3.custom.min.js";
          //  StaticResourceManager1.JavaScript.Add(js2);


            //Shinkansen.Web.UI.WebControls.JavaScriptInclude js3 = new Shinkansen.Web.UI.WebControls.JavaScriptInclude();
            //js3.Path = "~/fckeditor/fckeditor.js";
           // StaticResourceManager1.JavaScript.Add(js3);



        
    }

    void setCss(bool editMode,string theme)
    {




        //Shinkansen.Web.UI.WebControls.CssInclude css4 = new Shinkansen.Web.UI.WebControls.CssInclude();
        //css4.Path = "~/Content/reset-fonts-grids.css";
        //StaticResourceManager1.Css.Add(css4);









        Shinkansen.Web.UI.WebControls.CssInclude css1 = new Shinkansen.Web.UI.WebControls.CssInclude();
        css1.Path = "~/theme/" + theme + "/StyleSheet.css";
        StaticResourceManager1.Css.Add(css1);



       // if (EditMode)
      //  {




            Shinkansen.Web.UI.WebControls.CssInclude css2 = new Shinkansen.Web.UI.WebControls.CssInclude();
            css2.Path = "~/core/themeCP/Bitrix/StyleSheet.css";
            StaticResourceManager1.Css.Add(css2);

         


       // }





    }



    protected void Button2_Click(object sender, EventArgs e)
    {

        string idStr, lang;
        idStr = "3";
        lang = "1";

        if (this.Request.QueryString["id"] != null)
        {
            idStr = this.Request.QueryString["id"];
        }

        if (this.Request.QueryString["lang"] != null)
        {
            lang = this.Request.QueryString["lang"];
        }



        khatam.core.UI.SectionManager.setProperty(txtSectionTitle.Text, idStr, "title", lang);
        khatam.core.UI.SectionManager.setProperty(txtSectionKeywords.Text, idStr, "keywords", lang);
        khatam.core.UI.SectionManager.setProperty(txtSectionDescription.Text, idStr, "Description", lang);
        khatam.core.UI.SectionManager.setProperty(this.txtSectionAuthor.Text, idStr, "Author", lang);
        khatam.core.UI.SectionManager.setProperty(this.DDLSectionChangefreq.SelectedValue, idStr, "changefreq", lang);
        khatam.core.UI.SectionManager.setProperty(this.DDLSectionPriority.SelectedValue, idStr, "priority", lang);
        khatam.core.UI.SectionManager.setProperty(DateTime.UtcNow.ToString(), idStr, "lastmod", lang);
        
 
    }

    protected void DdlBodySize_SelectedIndexChanged(object sender, EventArgs e)
    {
             string idStr, lang;
        idStr = "3";
        lang = "1";

        if (this.Request.QueryString["id"] != null)
        {
            idStr = this.Request.QueryString["id"];
        }

        if (this.Request.QueryString["lang"] != null)
        {
            lang = this.Request.QueryString["lang"];
        }

        //khatam.core.data.sql.ErrorLogAdd("istr=" + idStr);

        if (int.Parse(idStr) > 999)
        {
            khatam.core.data.sql.updateField("propertyValue", DdlBodySize.SelectedValue, "propertyTitle", "yui_id", "id_Core_Section_option", idStr, "language", "1", "Core_sectionVal_option", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }
        else
        {
            khatam.core.data.sql.updateField("propertyValue", DdlBodySize.SelectedValue, "propertyTitle", "yui_id", "id_Core_Section", idStr, "language", "1", "Core_sectionVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        }

        this.Response.Redirect(this.Request.Url.OriginalString, false);

    }
    protected void DdlBodyCol_SelectedIndexChanged(object sender, EventArgs e)
    {


        string idStr, lang;
        idStr = "3";
        lang = "1";

        if (this.Request.QueryString["id"] != null)
        {
            idStr = this.Request.QueryString["id"];
        }

        if (this.Request.QueryString["lang"] != null)
        {
            lang = this.Request.QueryString["lang"];
        }


        if (int.Parse(idStr) > 999)
        {
            khatam.core.data.sql.updateField("propertyValue", DdlBodyCol.SelectedValue,
                "propertyTitle",
                "yui_class",
                "id_Core_Section_option",
                idStr,
                "language",
                lang,
                "Core_sectionVal_option",
                khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }
        else
        {
            khatam.core.data.sql.updateField("propertyValue", DdlBodyCol.SelectedValue,
        "propertyTitle",
        "yui_class",
        "id_Core_Section",
        idStr,
        "language",
        lang,
        "Core_sectionVal",
        khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }
  
        this.Response.Redirect(this.Request.Url.OriginalString, false);

    }


    protected void DdlContentCol_SelectedIndexChanged(object sender, EventArgs e)
    {


        string idStr, lang;
        idStr = "3";
        lang = "1";

        if (this.Request.QueryString["id"] != null)
        {
            idStr = this.Request.QueryString["id"];
        }

        if (this.Request.QueryString["lang"] != null)
        {
            lang = this.Request.QueryString["lang"];
        }

        khatam.core.data.sql.ErrorLogAdd("istr=" + idStr);


        if (int.Parse(idStr) > 999)
        {
            khatam.core.data.sql.updateField("propertyValue", this.DdlContentCol.SelectedValue, "propertyTitle", "yuig1", "Core_sectionVal_option", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        }
        else
        {
            khatam.core.data.sql.updateField("propertyValue", this.DdlContentCol.SelectedValue, "propertyTitle", "yuig1", "Core_sectionVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        }
        
   
        this.Response.Redirect(this.Request.Url.OriginalString, false);
             

    }


    
}
