
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;


public partial class Manage_c_uniproj_project_add_teacher : System.Web.UI.UserControl
{

    public string idpage;
    public string idpage_content;

    public string type_content, rows;

    public  string fileDLSize;
    public  string fileDLName;
    public   bool fileDLnewUploaded ;

    //permisson
    public bool PcatType;
    public bool AccessALL = false;

    public bool insert = false;
    public bool FolderInsert = false;
    public bool FolderEdit = false;
    public bool FolderMove = false;
    public bool FolderCopy = false;
    public bool FolderDelete = false;
    public bool PMove = false;
    public bool PCopy = false;
    public bool ValidationALL = false;
    public bool ValidationOwn = false;
    public int UserId = 0;
    public bool VirtualDelete = false;
    public bool RealDelete = false;

    public bool folderCheckBox = false;
    public bool fileCheckBox = false;
    public bool Edit = false;
    public bool UnDelete = false;
    public bool UploadDirectFile = false;
    
    public bool isInsertUser = false;

    public HtmlTextArea hta = new HtmlTextArea();

    //public HtmlInputHidden ih = new HtmlInputHidden();
    public HtmlInputText ih = new HtmlInputText();


    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (khatam.core.data.sql.Sql_Check_identity("cluster_id", this.Request.QueryString["cluster_id"], "uniTeacherId", khatam.core.Security.Users.login().ToString(),
      "uniproj_ClusterRefTeacher", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
        {
            this.Response.Redirect("~/manage/?mode=MSG_Access_denied");
        }


        

        string TeacherMaxProject = khatam.core.data.sql.getField("capacity", "uniTeacherId", khatam.core.Security.Users.login().ToString(),
           "cluster_id", this.Request.QueryString["cluster_id"], "uniproj_ClusterRefTeacher");

        string TeacherUsedProject = khatam.uniproj.cluster.CountTeacherUsedProject(
            khatam.core.Security.Users.login().ToString(), this.Request.QueryString["cluster_id"]);

        if (int.Parse(TeacherMaxProject) <= int.Parse(TeacherUsedProject))
        {
            PlaceHolder1.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getErrorMessage("ظرفیت اختصاص پروژه", "ظرفیت اختصاص پروژه اتمام یافته است", true)));
            mainWin.Visible = false;
        }
        else
        {
            mainWin.Visible = true ;
        }

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دانشگاه: ایجاد پروژه - استاد";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_lesson_group.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=uniproj_cluster_list_teacher\">لیست ظرفیت های اخصاص پروژه - استاد</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + "  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=uniproj_project_list_teacher&id=" + this.Request.QueryString["cluster_id"] + "\">دانشگاه: لیست پروژه ها - استاد</a>   > <span style=\" color: #808080\">";

        l.Text = l.Text + " دانشگاه: ایجاد پروژه - استاد";
        l.Text = l.Text + "</span> ";

        

        if (this.IsPostBack == false)
        {
      //      setTags();
        //    setOptionalField();
        }

/*        if (khatam.core.ConfigurationManager.License.demo == true)
        {
           this.btnOK.Enabled = false;
           btnOK.ToolTip = "در نسخه دمو این امکان وجود ندارد";

            btnUploadDirectLink.Enabled = false;
btnOK.Enabled = false;
btnUploadImage.Enabled = false;
imgBtnCore_SaleTermShowAdd.Enabled = false;
Button17.Enabled = false;
saleTerm_add_btnSave.Enabled = false;
saleTerm_Edit_btnSave.Enabled = false;
BtnCancel_edit.Enabled = false;
Button22.Enabled = false;
Button23.Enabled = false;
imgBtnPayCycleNew.Enabled = false;
paycycle_btn_add_save.Enabled = false;
paycycle_btn_add_Cancel.Enabled = false;
Button6.Enabled = false;
Button16.Enabled = false;
Button7.Enabled = false;
imgBtnPayCycleNew.Enabled = false;
paycycle_btn_add_save.Enabled = false;
paycycle_btn_add_Cancel.Enabled = false;
Button6.Enabled = false;
Button16.Enabled = false;
Button7.Enabled = false;


btnUploadDirectLink.ToolTip = "در نسخه دمو این امکان وجود ندارد";
btnOK.ToolTip = "در نسخه دمو این امکان وجود ندارد";
btnUploadImage.ToolTip = "در نسخه دمو این امکان وجود ندارد";
imgBtnCore_SaleTermShowAdd.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button17.ToolTip = "در نسخه دمو این امکان وجود ندارد";
saleTerm_add_btnSave.ToolTip = "در نسخه دمو این امکان وجود ندارد";
saleTerm_Edit_btnSave.ToolTip = "در نسخه دمو این امکان وجود ندارد";
BtnCancel_edit.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button22.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button23.ToolTip = "در نسخه دمو این امکان وجود ندارد";
imgBtnPayCycleNew.ToolTip = "در نسخه دمو این امکان وجود ندارد";
paycycle_btn_add_save.ToolTip = "در نسخه دمو این امکان وجود ندارد";
paycycle_btn_add_Cancel.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button6.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button16.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button7.ToolTip = "در نسخه دمو این امکان وجود ندارد";
imgBtnPayCycleNew.ToolTip = "در نسخه دمو این امکان وجود ندارد";
paycycle_btn_add_save.ToolTip = "در نسخه دمو این امکان وجود ندارد";
paycycle_btn_add_Cancel.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button6.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button16.ToolTip = "در نسخه دمو این امکان وجود ندارد";
Button7.ToolTip = "در نسخه دمو این امکان وجود ندارد";

        }

        //~~~~{ permission }~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~} 
        DataTable dt1 = new DataTable();
        UserId = int.Parse(khatam.core.Security.Users.login().ToString());
        type_content = khatam.core.data.sql.getField("defCpLog", "type_content", "id", this.Request.QueryString["id"], "cat");
        dt1 = khatam.core.Security.Users.getUserPermissionIdTitle(UserId.ToString());



        for (int jj = 0; jj < dt1.Rows.Count; jj++)
        {
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content) PcatType = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "AccessALL") AccessALL = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "Insert") insert = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderInsert") FolderInsert = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderEdit") FolderEdit = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderMove") FolderMove = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "FolderDelete") FolderDelete = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "Move") PMove = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "ValidationALL") ValidationALL = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "ValidationOwn") ValidationOwn = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "VirtualDelete") VirtualDelete = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "RealDelete") RealDelete = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "Edit") Edit = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "UnDelete") UnDelete = true;
            if (dt1.Rows[jj].ItemArray[1].ToString() == type_content + "UploadDirectFile") UploadDirectFile = true;
        }

         if (PcatType != true)
        {
              this.Response.Redirect("~/manage/?mode=msgPermisson");
        }


        if (UserId.ToString() == khatam.core.data.sql.getField("pageEditLoad", "insertUserId", "id", this.Request.QueryString["id"], "cat"))
        {
            isInsertUser = true;
        }

        if (AccessALL == false)
        {
            if (isInsertUser == false)
            {
                    this.Response.Redirect("~/manage/?mode=msgPermisson");
            }
        }


        if (Edit == false)
        {
               this.Response.Redirect("~/manage/?mode=msgPermisson");
        }


        if (RealDelete == false)
        {
            if (Convert.ToBoolean(khatam.core.data.sql.getField("pageEditLoad", "deleted", "id", this.Request.QueryString["id"], "cat")))
            {
                   this.Response.Redirect("~/manage/?mode=msgPermisson");
            }
            //divValidationArea.Visible = true;
        }




        //FCKeditor1.AutoDetectLanguage = false;
        //FCKeditor1.DefaultLanguage = "fa";
        //FCKeditor1.BasePath = "~/fckeditor/";
        //FCKeditor1.ContentLangDirection = FredCK.FCKeditorV2.LanguageDirection.RightToLeft;



        //If type = "content" Then
        //    idpage = Me.Request.QueryString("id")
        //  ElseIf type = "teacher" Then
        //    idpage = khatam.core.data.sql.getField("pageEditLoadidt", "id", "idt", Me.Session("user_id"), "content")
        //    idpage_content = idpage
        // Else
        idpage = khatam.core.data.sql.getField("pageeditgetidpage", "id_content", "id", this.Request.QueryString["id"], "cat");


        hta.ID = "hta";
        hta.ClientIDMode = System.Web.UI.ClientIDMode.Static;

        ih.ID = "ih";
        ih.ClientIDMode = System.Web.UI.ClientIDMode.Static;
        ih.Visible = true;
        //##Label2.Text = hta.ClientID+ "   " + ih.ClientID ;

        //this.PlaceHolder1.Controls.Add(hta);

        //this.PlaceHolder1.Controls.Add(ih);



        // this.Controls.Add(new LiteralControl(htm1));


        string html2 =

        "<script type=\"text/javascript\">" +
        " CKEDITOR.replace( 'hta',"
            // " CKEDITOR.replace( '" + tb.ClientID + "',"
        + " {	filebrowserBrowseUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/ckfinder.html'"


        //+ " 	filebrowserImageBrowseUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/ckfinder.html?type=Images',"
            //+ " 	filebrowserFlashBrowseUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/ckfinder.html?type=Flash',"
            //+ " 	filebrowserUploadUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files',"
            //+ " 	filebrowserImageUploadUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images',"
            //+ " 	filebrowserFlashUploadUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash'"
        + " }); " + "</script> ";



        //+ " }); CKFinder.setupCKEditor( '" + tb.ClientID + "', '~/manage/' ); " + "</script>"; 
        //+ " });   CKFinder.SetupCKEditor( var editor , '/manage/upload/', rememberLastFolder : false  ); " + "</script>"; 





        //## this.PlaceHolder1.Controls.Add(new LiteralControl(html2));


        //"SELECT     id_content    FROM         Cat    WHERE     (id = @id)" get_contentid(this.Request.QueryString["id"]);
        // End If


        idpage_content = this.Request.QueryString["id"];

        if (Page.IsPostBack == false)
        {
            hide_wins();
            saleTerms_hideWins();
            setNavi();


            switch (type_content)
            {
                case "article":
                case "special_pages":
                case "service":               
                case "research_project":
                case "help":
                case "sample_exam":
                case "car":
                case "picture":
                    Fill_Field_Content(type_content);

                    break;
                case "host":
                    Fill_Field_Content(type_content);
                    Fill_Field_host();
                    break;

                case "portal":
                    Fill_Field_Content(type_content);
                    Fill_Field_portal();
                    break;
                case "news":
                    Fill_Field_Content(type_content);
                    Fill_Field_news();
                    break;
                case "library":
                    Fill_Field_Content(type_content);

                    Fill_Field_Library();
                    Fill_FileDL();
                    break;
                case "software":
                    Fill_Field_Content(type_content);
                    Fill_Field_software();
                    Fill_FileDL();
                    break;
                case "mobile":
                    Fill_Field_Content(type_content);
                    this.Div_Part_Mobile.Visible = true;
                    //                 Fill_Field_mobile("mobile")
                    Fill_FileDL();
                    break;
                case "clip":
                    Fill_Field_Content(type_content);
                    this.Div_Part_Clip.Visible = true;
                    Fill_Field_clip();
                    //    CType(Me.Parent.FindControl("label1"), Label).Text = Generate_url_page_edit(Me.Request.QueryString("id"))
                    Fill_FileDL();
                    break;
                case "shop":
                    Fill_Field_Content(type_content);
                    Fill_Field_shop();
                    break;
                case "domain":
                    Fill_Field_Content(type_content);
                    Fill_Field_domain();
                    //    Fill_Field_shop();
                    break;
                case "menu":
                    Fill_Field_menu();
                    break;
                case "Link":
                    Fill_Field_Content(type_content);

                    Fill_Field_link();
                    break;

                default:
                    break;
            }


        }

        SqlDataSource6.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource4.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        Saleterm_Add_txt_min.Attributes.Add("onkeypress", "return isNumberKey(event)");
        Saleterm_Add_txt_Price.Attributes.Add("onkeypress", "return isNumberKey(event)");
        Saleterm_Edit_txt_min.Attributes.Add("onkeypress", "return isNumberKey(event)");
        Saleterm_Edit_txt_Price.Attributes.Add("onkeypress", "return isNumberKey(event)");



        Agent_Smith();

        loadFields();
        */

    }

    public static DataTable getTags(string cat_id)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        parameters.Add("cat_id", cat_id);

        str_sql = "SELECT     core_tags.tag_title " +
                  " FROM         core_tags INNER JOIN " +
                  "    core_tag_ref_cat ON core_tags.tag_id = core_tag_ref_cat.tag_id " +
                  " WHERE     (core_tag_ref_cat.cat_id = @cat_id)";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }





    
   
    public static DataTable getProp()
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        //parameters.Add("field_where_value", field_where_value);
        //str_sql = "SELECT  TOP (" + top + ") id,title,image FROM " + table + " ORDER BY id DESC ";

        str_sql = "SELECT  [core_prop_id]      ,[cat_id]      ,[title]  FROM [core_prop] ";

        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }

    public static DataTable getDefVal(string propId)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        //parameters.Add("field_where_value", field_where_value);
        //str_sql = "SELECT  TOP (" + top + ") id,title,image FROM " + table + " ORDER BY id DESC ";

        str_sql = "SELECT  [core_prop_defVal_id]        ,[core_prop_id]       ,[title]   FROM [core_prop_defVal] WHERE     (core_prop_id = " + propId + ")";

        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text,khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }

  


    
    private void Fill_Field_Content(string type_content)
    {
        //Txt_Title.Attributes.Add("onkeypress", "return checkTextAreaMaxLength(this,event,'10');");
        //150
        //onkeyDown="return checkTextAreaMaxLength(this,event,'10');"


        View.Visible = true;
        string image_path = "";
        string image_fileName;
        string currentImage = "";

        image_fileName = khatam.core.data.sql.getField( "image", "id", idpage, type_content);

    
        if (image_fileName != "")
        {
            image_path = @"upload\content\" + type_content + @"\4\" + image_fileName;

            currentImage = "<br />تصویر فعلی: " + "<br />" +
               "<br />" + " <img  src=" + image_path + " />";


        }
       
        try
        {

            this.Txt_Title.Text = khatam.core.data.sql.getField( "title", "id", idpage, type_content);
        }
        catch
        {
            this.Txt_Title.Text = "";
        }


        if (type_content  != "Link")
        {

            string htmlPage;
            try
            {
                htmlPage = khatam.core.data.sql.getField( "page", "id", idpage, type_content);
            }
            catch
            {
                htmlPage = "";
            }

            CKEditor1.Text = htmlPage;
            
        }

        //enable
        string str_contentEnable;

        try
        {
            str_contentEnable = khatam.core.data.sql.getField( "enable", "id", idpage, type_content);
        }
        catch
        {
            str_contentEnable = "0";
        }





        //valid
        string str_contentValid;

        try
        {
            str_contentValid = khatam.core.data.sql.getField( "Valid", "id", idpage_content, "cat");
        }
        catch
        {
            str_contentValid = "0";
        }


     


    






        try
        {

            this.txt_tag_Description.Text = khatam.core.data.sql.getField( "description", "id", idpage, type_content);
        }
        catch
        {
            this.txt_tag_Description.Text = "";
        }




    }



  
    

    private void loader(TextBox textbox, string field, string type_content)
    {
        try
        {
            textbox.Text = khatam.core.data.sql.getField(field, "id", idpage, type_content);
        }
        catch
        {
            textbox.Text = "";
        }


    }


    private void fill_html(string html_str)
    {
        int editor_mode;
        // editor_mode = int.Parse( Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("editor_mode", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));
        //this.FCKeditor1.Visible = false;
        //this.FCKeditor1.Visible = true;
        //this.FCKeditor1.Value = html_str;

    }


    private string get_html()
    {
           string html_str;


        //html_str = FCKeditor1.Value;



    return "return html";
    }




    protected string add_project()
    {

        ArrayList item_name = new ArrayList();
        ArrayList item_value = new ArrayList();


        item_name.Add("title");     
        item_value.Add(Txt_Title.Text );

        item_name.Add("memo");     
        item_value.Add(txt_tag_Description.Text );
        
        item_name.Add("htmlPage");     
        item_value.Add(CKEditor1.Text);

        item_name.Add("regDatetime");
        item_value.Add(DateTime.UtcNow);

        item_name.Add("updateDatetime");
        item_value.Add(DateTime.UtcNow);

        item_name.Add("clusterId");
        item_value.Add(this.Request.QueryString["cluster_id"]);

        string userId = khatam.core.Security.Users.login().ToString();
        khatam.core.Security.Users.user _user ;
        _user = khatam.core.Security.Users.getUser(userId);

        item_name.Add("uniTeacherUserId");
        item_value.Add(userId);

        item_name.Add("uniTeacherUserFname");
        item_value.Add(_user.fname );

        item_name.Add("uniTeacherUserLname");
        item_value.Add(_user.lname );

        item_name.Add("projectType");
        item_value.Add(DropDownList1.SelectedValue );



       HiddenField1.Value= khatam.core.data.sql.AddScope(item_name, item_value, "uniproj_project");

        return "0";
    }


    protected void back_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=folder&cat=" + khatam.core.data.sql.getField( "pid", "id", this.Request.QueryString["id"], "cat"));
    }


    
 
    


   


    protected void back_Click(object sender, ImageClickEventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=folder&cat=" + khatam.core.data.sql.getField( "pid", "id", this.Request.QueryString["id"], "cat"));
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   

   


  


    protected void btn_cancel_Click(object sender, EventArgs e)
    {

        RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=uniproj_project_list_teacher&id=" + this.Request.QueryString["cluster_id"] );
    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }




    public static DataTable getCountry()
                {
                    string str_sql;
                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                    //parameters.Add("field_where_value", field_where_value);
                    str_sql = "SELECT  country_id,country_title FROM core_country";
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }

    public static DataTable getSend_mode()
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        //parameters.Add("field_where_value", field_where_value);
        str_sql = "SELECT  [id] ,[title]  FROM [core_sendMode]";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }

  
      
    
             protected void saleTerm_gv_SelectedIndexChanged(object sender, EventArgs e)
             {

             }

             public static bool Sql_Check_Edit(string min, string core_sale_terms_id, string catId)
             {
                 string str_sql;
                 Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                 parameters.Add("min", min);
                 parameters.Add("core_sale_terms_id", core_sale_terms_id);
                 parameters.Add("catId", catId);
                                  

                 str_sql = "SELECT    core_sale_terms_id   FROM         core_sale_terms   WHERE     (min = @min) AND (core_sale_terms_id <> @core_sale_terms_id) AND (catId = @catId)";
                 if ((DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, 
                     khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) == null))
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }


             protected void btnOK_Click(object sender, EventArgs e)
             {
                 add_project();

                 UpdatePanel1_Modal_SendToGroupUser.Show();

                 
                 
             }


             protected void txt_tag_Description_TextChanged(object sender, EventArgs e)
             {

             }
             protected void del_dialog_yes_Click(object sender, EventArgs e)
             {
                 khatam.core.data.sql.updateField("sendToGroupId", "true", "id", HiddenField1.Value, "uniproj_project");

                 RedirectTo("~/manage/?mode=uniproj_project_list_teacher&msg=ok&id=" + this.Request.QueryString["cluster_id"]);                 
             }
             protected void Button21_Click(object sender, EventArgs e)
             {
                 khatam.core.data.sql.updateField("sendToGroupId", "false", "id", HiddenField1.Value, "uniproj_project");

                 RedirectTo("~/manage/?mode=uniproj_project_list_teacher&msg=ok&id=" + this.Request.QueryString["cluster_id"]);                 
             }
}