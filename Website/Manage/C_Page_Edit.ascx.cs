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
using Telerik.WebControls.RadAjaxUtils;
using System.Diagnostics;
using Ionic.Zip;

public partial class Manage_C_Page_Edit : System.Web.UI.UserControl
{

    public string idpage;
    public string idpage_content;
    public string visitCounter;

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
        khatam.core.UI.baseControl.GeoSelector GeoSelector1 = new khatam.core.UI.baseControl.GeoSelector();
     
    protected void Page_PreInit(object sender, EventArgs e)
    {
   
   
    }


    protected void Page_Load(object sender, EventArgs e)
    {

         UserControl  uc11 = (UserControl )c_page_edit_pictureGalley ;

  


        ViewFieldOptional.Visible = false;

        if (this.IsPostBack == false)
        {
            setTags();
            setOptionalField();
        }

        if (khatam.core.ConfigurationManager.License.demo == true)
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
        type_content = khatam.core.data.sql.getField( "type_content", "id", this.Request.QueryString["id"], "cat");
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


        if (UserId.ToString() == khatam.core.data.sql.getField( "insertUserId", "id", this.Request.QueryString["id"], "cat"))
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
           // this.Response.Redirect("http://www.google.com");

               this.Response.Redirect("~/manage/?mode=msgPermisson");
        }


        if (RealDelete == false)
        {
            if (Convert.ToBoolean(khatam.core.data.sql.getField( "deleted", "id", this.Request.QueryString["id"], "cat")))
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
        idpage = khatam.core.data.sql.getField( "id_content", "id", this.Request.QueryString["id"], "cat");

        visitCounter = khatam.core.data.sql.getField("visitCounter", "id", this.Request.QueryString["id"], "cat");

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

        if (type_content == "estate")
        {
            try
            {
                GeoSelector1._geo.CountryId = int.Parse(khatam.core.data.sql.getField("country_id", "id", idpage, "estate"));
                GeoSelector1._geo.EstateId = int.Parse(khatam.core.data.sql.getField("country_state_id", "id", idpage, "estate"));
                GeoSelector1._geo.CityId = int.Parse(khatam.core.data.sql.getField("country_state_city_id", "id", idpage, "estate"));
                GeoSelector1._geo.AreaId = int.Parse(khatam.core.data.sql.getField("core_country_state_city_area_id", "id", idpage, "estate"));
            }
            catch
            {
                GeoSelector1._geo.CountryId = 0;

            }

            PlaceHolder2.Controls.Add(GeoSelector1);
        }

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
                case "link":

                    Fill_Field_Content(type_content);

                    Fill_Field_link();
                    break;

                case "estate":
                    Fill_Field_Content(type_content);                        

                    Fill_Field_estate();
                    


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
        estate_txt_meterPrice.Attributes.Add("onkeypress", "return isNumberKey(event)");
        estate_txt_totalPrice.Attributes.Add("onkeypress", "return isNumberKey(event)");
        estate_txt_EjarePrice.Attributes.Add("onkeypress", "return isNumberKey(event)");
        estate_txt_VadiePrice.Attributes.Add("onkeypress", "return isNumberKey(event)");
        estate_txt_metrazh.Attributes.Add("onkeypress", "return isNumberKey(event)");
        estate_txt_seneBana.Attributes.Add("onkeypress", "return isNumberKey(event)");




        Agent_Smith();

        loadFields();


    }



    public void setTags()
    {
        string html = " <ul id=\"singleFieldTags\" style=\" width:200px\">";
        
        PlaceHolder1.Controls.Add(new LiteralControl(html));

        DataTable dt = new DataTable();
        dt =khatam.core.explorer.getTags(this.Request.QueryString["id"]);

        string str_li="";

        for (int i = 0; i < dt.Rows.Count  ; i++)
			{
                str_li = str_li + " <li>" + dt.Rows[i].ItemArray[0].ToString() + "</li>";	 
			}

        PlaceHolder1.Controls.Add(new LiteralControl(str_li));
    
        PlaceHolder1.Controls.Add(new LiteralControl(" </ul>"));
    }



    void setNavi()
    {


        string weArehere;
        weArehere = khatam.core.explorer.generateUrl_link(idpage_content);


        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = weArehere;

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/title_iblock.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + weArehere;
        l.Text = l.Text + "</span> ";

        
    }

    
    void loadFields()
    {



  //DataTable dt = new DataTable();
  //getTableRecentContent().Rows.Count 

        DataTable dt = getProp();

       

  for (int i = 0; i < dt.Rows.Count ; i++)
  {
      string html = "<div class=\"row\">"
+ " <div class=\"field\">"
+ " "
+  dt.Rows[i].ItemArray[2].ToString() +  " :</div>"
+ " <div class=\"fieldInputArea\">";

      PlaceHolder_fieldTab.Controls.Add(new LiteralControl(html));

      DataTable dtDef = new DataTable();
      dtDef = getDefVal(dt.Rows[i].ItemArray[0].ToString());

      

      DropDownList ddl = new DropDownList();
      ddl.ID ="ddlDefVal_" + dt.Rows[i].ItemArray[0].ToString();
      ddl.ClientIDMode = System.Web.UI.ClientIDMode.Static;

      ListItem li_s = new ListItem();
      li_s.Value = "0";
      li_s.Text = "---";

      ddl.Items.Add(li_s);

      ddl.Width = System.Web.UI.WebControls.Unit.Pixel(200);
      
      for (int j = 0; j < dtDef.Rows.Count ; j++)
      {
        
        // li.Text=;
        // li.Text = j.ToString();
          ListItem li = new ListItem();

          li.Text = dtDef.Rows[j].ItemArray[2].ToString();
          li.Value = dtDef.Rows[j].ItemArray[1].ToString();

          //   ddl.Items.Add(dtDef.Rows[j].ItemArray[2].ToString());
          ddl.Items.Add(li);
              //Add(dtDef.Rows[j].ItemArray[2].ToString());
          
      }

      PlaceHolder_fieldTab.Controls.Add(ddl);


      PlaceHolder_fieldTab.Controls.Add(new LiteralControl(" "));

      TextBox tb = new TextBox();
      tb.Width = System.Web.UI.WebControls.Unit.Pixel(100);
      tb.ID = "txtDefVal_" + dt.Rows[i].ItemArray[0].ToString();
      tb.ClientIDMode = System.Web.UI.ClientIDMode.Static;

      PlaceHolder_fieldTab.Controls.Add(tb);

      string html2 = " </div>"
 + " </div>";
      PlaceHolder_fieldTab.Controls.Add(new LiteralControl(html2));
  }

        
      
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

    void Agent_Smith()
    {




        if (ValidationALL)
        {
           divValidationArea.Visible = true;
        }

        if ((ValidationOwn) && (isInsertUser))
        {
           divValidationArea.Visible = true;
        }


        divDirectLink.Visible = UploadDirectFile;

    }

    private void saleTerms_hideWins()
    {
        saleTerm_div_error_min.Visible = false;
        saleTerm_edit_div_error_min.Visible = false;
        divAddSaleTerm.Visible = false;
        divDelSaleTerm.Visible = false;
        divOkSaleTerm.Visible = false;
        divEditSaleTerm.Visible = false;
    }


    private void hide_wins()
    {
        
       
        MSG_OK.Visible = false;
        View_saleTerm.Visible = false;
        Div_Part_Software.Visible = false;
        Div_Part_Shop.Visible = false;
        Div_link.Visible = false;
        Div_part_library.Visible = false;
        Div_Part_speciallink.Visible = false;
        Div_menu.Visible = false;
        Div_news.Visible = false;
        Div_Part_Clip.Visible = false;
        Div_Part_Mobile.Visible = false;
        Div_host.Visible = false;
        divDirectLink.Visible = false;
        divPropAdd.Visible = false;
        divPropDel.Visible = false;
        divPropEdit.Visible = false;
        divPropMsgOk.Visible = false;
        divPropEditDefVal.Visible = false;
        div_estate.Visible = false;

        View.Visible = false;
        this.paycycle_div_MSG2.Visible = false;
        this.paycycle_div_MSG3.Visible = false;
        this.paycycle_div_msgAdd.Visible = false;
        this.paycycle_div_msgEdit.Visible = false;
        this.paycycle_div_msgEdit.Visible = false;
        this.div_portal.Visible = false;
        div_estate.Visible = false;
        View_tour.Visible = false;


       

       // MSG2.Visible = false;
      //  MSG3.Visible = false;
      //  msgAdd.Visible = false;
      //  msgEdit.Visible = false;

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


        try
        {

            if ((Convert.ToBoolean(str_contentEnable) == true))
            {
               // this.Rb_Content_Enable.Checked = true; this.Rb_Content_Disable.Checked = false;
                this.chk_Content_Enable.Checked = true;
            }
            else
            {
              //  this.Rb_Content_Disable.Checked = true; this.Rb_Content_Enable.Checked = false;
                this.chk_Content_Enable.Checked = false;
            }


        }
        catch
        {
            this.chk_Content_Enable.Checked = true;
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

        string str_contentImportant;

        try
        {
            str_contentImportant = khatam.core.data.sql.getField( "important", "id", idpage_content, "cat");
            if (str_contentImportant=="")
            {
                str_contentImportant = "false";
            }
        }
        catch
        {
            str_contentImportant = "false";
        }

        chk_important_Enable.Checked  = bool.Parse(str_contentImportant);
     

            if ((Convert.ToBoolean(str_contentValid) == true))
            {
                chk__Valid_Enable.Checked = true;
            
            }
            else
            {
                chk__Valid_Enable.Checked = false;
            
            }


    



        try
        {

            this.txt_tag_Author.Text = khatam.core.data.sql.getField( "author", "id", idpage, type_content);
        }
        catch
        {
            this.txt_tag_Author.Text = "";
        }



        try
        {

            this.txt_tag_keywords.Text = khatam.core.data.sql.getField( "keywords", "id", idpage, type_content);
        }
        catch
        {
            this.txt_tag_keywords.Text = "";
        }



        try
        {

            this.txt_tag_Description.Text = khatam.core.data.sql.getField( "description", "id", idpage, type_content);
        }
        catch
        {
            this.txt_tag_Description.Text = "";
        }


            DateTime showTime = DateTime.Parse( khatam.core.data.sql.getField( "showtime", "id", idpage_content, "cat")); 
            txt_birthday.Text =khatam.core.globalization.dateTime.GetPersianDate( showTime);

            DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(showTime , TimeZoneInfo.Utc.Id, "Iran Standard Time");            

            ddl_time.SelectedValue  = ((dtLocal.Hour * 60) + dtLocal.Minute).ToString()  ;
      


 



    }


    private void Fill_Field_news()
    {
        this.Div_news.Visible = true;

        DateTime k;

        try
        {
            k = DateTime.Parse(khatam.core.data.sql.getField("newsdate", "id", idpage, "news"));
        }
        catch
        {
            k = DateTime.UtcNow;
        }



        if (k.Month < 7)
        {
            k = k.AddHours(4.5);
        }
        else
        {
            k = k.AddHours(3.5);
        }

        //System.Globalization.PersianCalendar ps = new System.Globalization.PersianCalendar();


        this.PersianDateTextBox.Text = Persia.Number.ConvertToLatin(Persia.Calendar.ConvertToPersian(k).Simple);

        //trace.Text= Persia.Number.ConvertToLatin( Persia.Calendar.ConvertToPersian().Simple);
        //Dim ps As New PersianCalendar

      //  this.DDL_News_Day.SelectedValue = ps.GetDayOfMonth(k).ToString();
      //  this.DDL_New_Month.SelectedValue = ps.GetMonth(k).ToString();
      //  this.txt_news_year.Text = ps.GetYear(k).ToString();



        loader(Txt_news_source, "source", type_content);


    }


    private void Fill_Field_estate()
    {
        div_estate.Visible = true;
        View_tour.Visible = true;

        estate_ddl_type.DataSource = khatam.estate.getTableEstate_type();
        estate_ddl_type.DataValueField = "id";
        estate_ddl_type.DataTextField = "title";
        estate_ddl_type.DataBind();


        loader(estate_txt_address, "address", type_content);
        loader(estate_txt_number, "number", type_content);
        loader(estate_txt_zipCode, "zipCode", type_content);

        loader(estate_ddl_agreement_type, "agreement_type", type_content);
        this.estate_div_foroshPrices.Visible = false;
        this.estate_div_rahnEjare.Visible = false;

          //  estate_div_rahnEjare
        if (estate_ddl_agreement_type.SelectedValue == "1") this.estate_div_foroshPrices.Visible = true;
        else if (estate_ddl_agreement_type.SelectedValue == "2") this.estate_div_rahnEjare.Visible = true;


        loader(estate_txt_meterPrice, "meterPrice", type_content);
        loader(estate_txt_totalPrice, "totalPrice", type_content);
      
        loader(estate_txt_VadiePrice, "VadiePrice", type_content);
        loader(estate_txt_EjarePrice, "EjarePrice", type_content);

        loader(estate_ddl_docType , "docType", type_content);
        loader(estate_ddl_type, "Type", type_content);

        loader(estate_txt_landlord_fname, "landlord_fname", type_content);
        loader(estate_txt_landlord_lname, "landlord_lname", type_content);
        loader(estate_txt_landlord_email, "landlord_email", type_content);
        loader(estate_txt_landlord_tel, "landlord_tel", type_content);
        loader(estate_txt_landlord_cellPhone, "landlord_cellPhone", type_content);
        loader(estate_txt_tedadeOtagh, "tedadeOtagh", type_content);
        loader(estate_txt_tabaghe, "tabaghe", type_content);
        loader(estate_txt_tedadeTabaghat, "tedadeTabaghat", type_content);
        loader(estate_txt_JameVahedHa, "JameVahedHa", type_content);
        loader(estate_txt_nama, "nama", type_content);

        loader(estate_ddl_sokonatStatus, "sokonatStatus", type_content);

        loader(estate_txt_seneBana, "seneBana", type_content);
        loader(estate_chk_bazsaziShode, "bazsaziShode", type_content);
        loader(estate_txt_kabinet, "kabinet", type_content);
        loader(estate_txt_wc, "wc", type_content);
        loader(estate_txt_kafpoosh, "kafpoosh", type_content);
        loader(estate_txt_tedadeParking, "tedadeParking", type_content);
        loader(estate_txt_tedadeTel, "tedadeTel", type_content);
        loader(estate_chk_anbari, "anbari", type_content);
        loader(estate_chk_balkon, "balkon", type_content);
        loader(estate_chk_OpenKitchen, "OpenKitchen", type_content);
        loader(estate_chk_shoomine, "shoomine", type_content);
        loader(estate_chk_shofazh, "shofazh", type_content);
        loader(estate_chk_chiler, "chiler", type_content);
        loader(estate_chk_FanCoil, "FanCoil", type_content);
        loader(estate_chk_packge, "package", type_content);
        loader(estate_chk_cooler, "cooler", type_content);
        loader(estate_chk_pool, "pool", type_content);
        loader(estate_chk_Sauna, "Sauna", type_content);
        loader(estate_chk_Jacuzzi, "Jacuzzi", type_content);
        loader(estate_chk_Elevator, "Elevator", type_content);
        loader(estate_chk_Barbecue, "Barbecue", type_content);
        loader(estate_chk_VideoIPhone, "VideoIPhone", type_content);
        loader(estate_chk_CCTV, "CCTV", type_content);
        loader(estate_chk_RemoteDoor, "RemoteDoor", type_content);
        loader(estate_chk_CentralAntenna, "CentralAntenna", type_content);
        loader(estate_chk_CentralInternet, "CentralInternet", type_content);
        loader(estate_chk_Backyard, "Backyard", type_content);
        loader(estate_chk_Landscape, "Landscape", type_content);
        loader(estate_chk_Lobby, "Lobby", type_content);
        loader(estate_chk_communitiesHall, "communitiesHall", type_content);
        loader(estate_chk_watchMan, "watchMan", type_content);
        loader(estate_chk_Patio, "Patio", type_content);
        loader(estate_chk_FireFighting, "FireFighting", type_content);
        loader(estate_chk_wasteShoting, "wasteShoting", type_content);



     



      


    }




    private void Fill_Field_menu()
    {

        View.Visible = true;
                    this.Div_Main.Visible=false;
                    this.ViewEdit.Visible = false;
                    this.ViewFieldOptional.Visible = false;
                    this.View_picture.Visible = false;

                 this.Div_menu.Visible= true;

            loader(Txt_menu_title, "title", type_content);
        loader(Txt_menu_link, "Link", type_content);



    }
    
    private void Fill_Field_shop()
    {

        this.Div_Part_Shop.Visible = true;
        if (khatam.core.License.ValidModule("eshop"))
        {
            this.View_saleTerm.Visible = true;
        }
        else
        {
            ddl_shop_DdlSellMode.Enabled = false;
            ddl_shop_DdlSellMode.SelectedValue = "2";
        }
        this.View.Visible = true;

     // loader(Txt_price_in_rls, "price_in_rls", type_content);        
        loader(Txt_manufacturer, "manufacturer", type_content);
        loader(Txt_pdf, "pdf", type_content);
        loader(Txt_driver, "driver", type_content);
     // loader(Txt_id_iranmc, "id_iranmc", type_content);
        loader(this.Txt_Shop_YahooID , "YahooID", type_content);
        loader(this.Txt_Shop_shopAssistantTel , "shopAssistantTel", type_content);
        loader(this.Txt_Shop_shopAssistantMobile , "shopAssistantMobile", type_content);
        loader(this.Txt_Shop_shopAssistantEmail , "shopAssistantEmail", type_content);

        loader(this.txt_shop_weight , "weight",type_content);
        loader(this.txt_shop_Width , "Width",type_content);
        loader(this.txt_shop_Length , "Length",type_content);
        loader(this.txt_shop_Height , "Height",type_content);

        ddl_shop_units.DataSource = getUnits();
        ddl_shop_units.DataTextField = "title";
        ddl_shop_units.DataValueField = "id";
        ddl_shop_units.DataBind();

              
        try
        {
            this.chk_shop_Breakable.Checked = bool.Parse( khatam.core.data.sql.getField( "Breakable", "id", idpage, type_content));
        }
        catch
        {
            this.chk_shop_Breakable.Checked = false;
        }
        

            try
        {
            this.chk_shop_Liquid.Checked = bool.Parse(khatam.core.data.sql.getField( "Liquid", "id", idpage, type_content));
        }
        catch
        {
            this.chk_shop_Liquid.Checked = false;
        }


            try
            {
                this.ddl_shop_units.SelectedValue = khatam.core.data.sql.getField( "sale_unit", "id", idpage, type_content);
            }
            catch
            {
                
            }


            try
            {
                this.ddl_shop_DdlSellMode.SelectedValue = khatam.core.data.sql.getField("sale_mode", "id", idpage, type_content);
            }
            catch
            {

            }
        
        


    }

    public static DataTable getUnits()
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        //parameters.Add("field_where_value", field_where_value);
        str_sql = "SELECT     core_units.id, Dictionary_Lang.title   FROM         core_units INNER JOIN                        Dictionary_Lang ON core_units.id_dictonary = Dictionary_Lang.id_dictionary  WHERE     (Dictionary_Lang.id_language = 1)   ";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }

    private void Fill_Field_domain()
    {

        

        View_paycycle.Visible = true;



    }
    
    private void Fill_Field_Library()
    {

        this.Div_part_library.Visible = true;

        loader(Txt_author, "author_book", type_content);
        loader(Txt_translator, "translator", type_content);

          loader(Txt_isbn, "isbn", type_content);
  loader(Txt_Link1_Book, "Link1", type_content);
  loader(Txt_Link2_Book, "Link2", type_content);
  loader(Txt_translator, "translator", type_content);


  try
  {
      this.Txt_Library_password.Text = khatam.core.data.sql.getField( "password", "id", idpage, type_content);


  }
  catch
  {
      this.Txt_Library_password.Text = khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir();
  }

  if (this.Txt_Library_password.Text == "")
  {
      this.Txt_Library_password.Text = khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir();
  }


  

    }

    private void Fill_Field_software()
    {

        this.Div_Part_Software.Visible = true;

        loader(Txt_Password, "password", type_content);
        loader(Txt_Link1, "Link1", type_content);
        loader(Txt_Link2, "Link2", type_content);
        loader(Txt_Link3, "Link3", type_content);
        loader(Txt_Crack1, "crack1", type_content);
        loader(Txt_Crack2, "crack1", type_content);
        loader(Txt_BuilderSite, "sitebuilder", type_content);


    }

    private void Fill_Field_clip()
    {

        this.Div_Part_Clip.Visible = true;

        loader(Txt_Clip_Password, "password", type_content);
        loader(Txt_Clip_Link1, "Link1", type_content);
        loader(Txt_Clip_Link2, "Link2", type_content);
        loader(Txt_Clip_Link3, "Link3", type_content);


    }     

    private void Fill_Field_host()
    {

        this.View.Visible = true;
        this.Div_host.Visible = true;
        this.div_portal.Visible = false;

        View_paycycle.Visible = true;


        //loader(txtHostPrice, "priceRLS", type_content);

       
    }

    private void Fill_Field_portal()
    {
        div_portal.Visible = true;
        this.View.Visible = true;
        //this.Div_portal.Visible = true;
        View_paycycle.Visible = true;

        loader(txt_portal_memo_invoice , "memo_invoice", type_content);
        loader(txt_portal_setupPrice , "setupPrice", type_content);


        //loader(txtHostPrice, "priceRLS", type_content);


    }

    private void Fill_Field_link()
    {
        View.Visible = true;
        //this.Div_Main.Visible = false;
        
        this.ViewFieldOptional.Visible = false;
        this.View_picture.Visible = true;
        
        
        this.Div_link.Visible = true;

        loader(Txt_Link_Link, "link1", type_content);
       

    }

    private void Fill_FileDL()
    {
        string fileDL,Size;

  try
  {
     fileDL = khatam.core.data.sql.getField( "fileDL", "id", idpage, type_content);


  }
  catch
  {
    fileDL = "";

 }

 if (fileDL != "")
 {
      this.LiteralDirectLinkCurent.Text  = "نام فایل فعلی: " + fileDL;
          //+ "حجم:" 
 }


 try
 {
     Size = khatam.core.data.sql.getField( "Size", "id", idpage, type_content);


 }
 catch
 {
     Size = "";

 }

 this.LiteralDirectLinkCurent.Text = this.LiteralDirectLinkCurent.Text + " حجم: " + Size ;
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

    private void loader(CheckBox  chkBox, string field, string type_content)
    {
        try
        {
            chkBox.Checked  =bool.Parse( khatam.core.data.sql.getField(field, "id", idpage, type_content));
        }
        catch
        {
            chkBox.Checked  = false;
        }


    }

    private void loader(DropDownList  ddl , string field, string type_content)
    {
        try
        {
            ddl.SelectedValue  = khatam.core.data.sql.getField(field, "id", idpage, type_content);
        }
        catch
        {
            
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

    protected string update_portal(string id)
    {

        ArrayList item_name = new ArrayList();
        ArrayList item_value = new ArrayList();
        

        item_name.Add("memo_invoice");
        item_value.Add(txt_portal_memo_invoice.Text );

        item_name.Add("setupPrice");
        item_value.Add(txt_portal_setupPrice.Text );

        khatam.core.data.sql.update(item_name, item_value, "portal", "id", id);

        return "0";
    }

    protected string update_news(string id)
    {

        ArrayList item_name = new ArrayList();
        ArrayList item_value = new ArrayList();

        DateTime date_source;
        date_source =DateTime.Parse( PersianDateTextBox.Text);

        DateTime date_event;
        date_event = Persia.Calendar.ConvertToGregorian(date_source.Year,date_source.Month, date_source.Day,Persia.DateType.Persian  );
            // (DateTime.Parse(this.PersianDateTextBox.Text)).Year,
         //   ((DateTime.Parse(this.PersianDateTextBox.Text)).Month,
         //   ((DateTime.Parse(this.PersianDateTextBox.Text)).Day, Persia.DateType.Persian);
        item_name.Add("newsdate");
        item_value.Add(   date_event.Date.ToString().Replace(" ق.ظ", ""));
        //trace.Text = this.PersianDateTextBox.DateValue.ToString();

        item_name.Add("source");
       item_value.Add(this.Txt_news_source.Text);




        khatam.core.data.sql.update(item_name, item_value, "news", "id", id);



        return "0";
    }

    protected string update_menu(string id)
    {



        ArrayList item_name = new ArrayList();
        ArrayList item_value = new ArrayList();

        item_name.Add("title");
         item_value.Add(this.Txt_menu_title.Text);

        item_name.Add("link");
        item_value.Add(this.Txt_menu_link.Text);




        khatam.core.data.sql.update(item_name, item_value, "menu", "id", id);

      

      khatam.core.data.sql.updateField( "cname", this.Txt_menu_title.Text, "id", idpage_content  , "cat",khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString() );

        return "0";
    }

    protected string update_link(string id)
    {



        ArrayList item_name = new ArrayList();
        ArrayList item_value = new ArrayList();



        item_name.Add("link1");
        item_value.Add(this.Txt_Link_Link.Text);

 


        khatam.core.data.sql.update(item_name, item_value, "link", "id", id);



        

        return "0";
    }

    protected string update_estate(string id)
    {

        ArrayList item_name = new ArrayList();
        ArrayList item_value = new ArrayList();

      item_name.Add("country_id");
      item_value.Add(GeoSelector1.selectedCountry  );

      item_name.Add("country_state_id");
      item_value.Add(GeoSelector1.selectedstate );

      item_name.Add("country_state_city_id");
      item_value.Add(GeoSelector1.selectedcity );

      item_name.Add("core_country_state_city_area_id");
      item_value.Add(GeoSelector1.selectedarea  );

      item_name.Add("address");
      item_value.Add(this.estate_txt_address.Text);

      item_name.Add("number");
      item_value.Add(this.estate_txt_number.Text );

      item_name.Add("zipCode");
      item_value.Add(this.estate_txt_zipCode.Text  );

      item_name.Add("type");
      item_value.Add(this.estate_ddl_type.SelectedValue);

      item_name.Add("doctype");
      item_value.Add(this.estate_ddl_docType.SelectedValue);

      item_name.Add("agreement_type");
      item_value.Add(this.estate_ddl_agreement_type.SelectedValue  );

      if (estate_ddl_agreement_type.SelectedValue == "1")
      {
          if (estate_txt_meterPrice.Text == "")    estate_txt_meterPrice.Text = "0";
          
          item_name.Add("meterPrice");
          item_value.Add(int.Parse(this.estate_txt_meterPrice.Text));

          if (estate_txt_totalPrice.Text == "") estate_txt_totalPrice.Text = "0";
          item_name.Add("totalPrice");
          item_value.Add(this.estate_txt_totalPrice.Text);
      }

      else  if (estate_ddl_agreement_type.SelectedValue == "2")
      {
          if (estate_txt_VadiePrice.Text == "") estate_txt_VadiePrice.Text = "0";

          item_name.Add("VadiePrice");
          item_value.Add(int.Parse(this.estate_txt_VadiePrice.Text));

          if (estate_txt_EjarePrice.Text == "") estate_txt_EjarePrice.Text = "0";
          item_name.Add("EjarePrice");
          item_value.Add(this.estate_txt_EjarePrice.Text);
      }


      item_name.Add("landlord_fname");
      item_value.Add(this.estate_txt_landlord_fname.Text );

      item_name.Add("landlord_lname");
      item_value.Add(this.estate_txt_landlord_lname.Text );

      item_name.Add("landlord_email");
      item_value.Add(this.estate_txt_landlord_email.Text );

      item_name.Add("landlord_tel");
      item_value.Add(this.estate_txt_landlord_tel.Text );

      item_name.Add("landlord_cellPhone");
      item_value.Add(this.estate_txt_landlord_cellPhone.Text );

      item_name.Add("metrazh");
      item_value.Add(this.estate_txt_metrazh.Text );

      item_name.Add("tedadeOtagh");
      item_value.Add(this.estate_txt_tedadeOtagh.Text );

      item_name.Add("tabaghe");
      item_value.Add(this.estate_txt_tabaghe.Text  );

      item_name.Add("tedadeTabaghat");
      item_value.Add(this.estate_txt_tedadeTabaghat.Text );

      item_name.Add("JameVahedHa");
      item_value.Add(this.estate_txt_JameVahedHa.Text );

      item_name.Add("nama");
      item_value.Add(this.estate_txt_nama.Text );

      item_name.Add("sokonatStatus");
      item_value.Add(this.estate_ddl_sokonatStatus.SelectedValue );

      item_name.Add("seneBana");
      item_value.Add(this.estate_txt_seneBana.Text );

      item_name.Add("bazsaziShode");
      item_value.Add(this.estate_chk_bazsaziShode.Checked );

      item_name.Add("kabinet");
      item_value.Add(this.estate_txt_kabinet.Text );

      item_name.Add("wc");
      item_value.Add(this.estate_txt_wc.Text );

      item_name.Add("kafpoosh");
      item_value.Add(this.estate_txt_kafpoosh.Text );

     
        
         item_name.Add("tedadeParking");
          item_value.Add(this.estate_txt_tedadeParking.Text );

          item_name.Add("tedadeTel");
          item_value.Add(this.estate_txt_tedadeTel.Text );

          item_name.Add("anbari");
          item_value.Add(this.estate_chk_anbari.Checked );

          item_name.Add("balkon");
          item_value.Add(this.estate_chk_balkon.Checked );

          item_name.Add("OpenKitchen");
          item_value.Add(this.estate_chk_OpenKitchen.Checked );

          item_name.Add("shoomine");
          item_value.Add(this.estate_chk_shoomine.Checked );

          item_name.Add("shofazh");
          item_value.Add(this.estate_chk_shofazh.Checked );

          item_name.Add("chiler");
          item_value.Add(this.estate_chk_chiler.Checked );

          item_name.Add("FanCoil");
          item_value.Add(this.estate_chk_FanCoil.Checked );

          item_name.Add("package");
          item_value.Add(this.estate_chk_packge.Checked );

          item_name.Add("cooler");
          item_value.Add(this.estate_chk_cooler.Checked );

          item_name.Add("pool");
          item_value.Add(this.estate_chk_pool.Checked );

          item_name.Add("Sauna");
          item_value.Add(this.estate_chk_Sauna.Checked );

          item_name.Add("Jacuzzi");
          item_value.Add(this.estate_chk_Jacuzzi.Checked );

          item_name.Add("Elevator");
          item_value.Add(this.estate_chk_Elevator.Checked );

          item_name.Add("Barbecue");
          item_value.Add(this.estate_chk_Barbecue.Checked );

          item_name.Add("VideoIPhone");
          item_value.Add(this.estate_chk_VideoIPhone.Checked );

          item_name.Add("CCTV");
          item_value.Add(this.estate_chk_CCTV.Checked );

          item_name.Add("RemoteDoor");
          item_value.Add(this.estate_chk_RemoteDoor.Checked );

          item_name.Add("CentralAntenna");
          item_value.Add(this.estate_chk_CentralAntenna.Checked );

          item_name.Add("CentralInternet");
          item_value.Add(this.estate_chk_CentralInternet.Checked );

          item_name.Add("Backyard");
          item_value.Add(this.estate_chk_Backyard.Checked );

          item_name.Add("Landscape");
          item_value.Add(this.estate_chk_Landscape.Checked );

          item_name.Add("Lobby");
          item_value.Add(this.estate_chk_Lobby.Checked );

          item_name.Add("communitiesHall");
          item_value.Add(this.estate_chk_communitiesHall.Checked );

          item_name.Add("watchMan");
          item_value.Add(this.estate_chk_watchMan.Checked  );

          item_name.Add("Patio");
          item_value.Add(this.estate_chk_Patio.Checked );

          item_name.Add("FireFighting");
          item_value.Add(this.estate_chk_FireFighting.Checked );

          item_name.Add("wasteShoting");
          item_value.Add(this.estate_chk_wasteShoting.Checked );

    
    
      if (lt_tourFileName.Text != "")
      {
          khatam.core.data.sql.updateField("tourFileName",  lt_tourFileName.Text, "id", idpage, type_content, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
      }

      khatam.core.data.sql.update(item_name, item_value, "estate", "id", id);


      return "0";
  }
    
  protected string update_shop(string id)
  {

      ArrayList item_name = new ArrayList();
      ArrayList item_value = new ArrayList();

        
      item_name.Add("manufacturer");
      item_value.Add(this.Txt_manufacturer.Text);

      item_name.Add("pdf");
      item_value.Add(this.Txt_pdf.Text);

      item_name.Add("driver");
      item_value.Add(this.Txt_driver.Text);

      item_name.Add("YahooID");
      item_value.Add(this.Txt_Shop_YahooID.Text);

      item_name.Add("shopAssistantTel");
      item_value.Add(this.Txt_Shop_shopAssistantTel.Text);

      item_name.Add("shopAssistantMobile");
      item_value.Add(this.Txt_Shop_shopAssistantMobile.Text);

      item_name.Add("shopAssistantEmail");
      item_value.Add(this.Txt_Shop_shopAssistantEmail.Text);

      item_name.Add("weight");
      item_value.Add(this.txt_shop_weight.Text);

      item_name.Add("Width");
      item_value.Add(this.txt_shop_Width.Text);

      item_name.Add("Length");
      item_value.Add(this.txt_shop_Length.Text );

      item_name.Add("Height");
      item_value.Add(this.txt_shop_Height.Text );

      item_name.Add("Breakable");
      item_value.Add(this.chk_shop_Breakable.Checked );

      item_name.Add("Liquid");
      item_value.Add(this.chk_shop_Liquid.Checked);

      item_name.Add("sale_unit");
      item_value.Add(this.ddl_shop_units.SelectedValue);

      item_name.Add("sale_mode");
      item_value.Add(this.ddl_shop_DdlSellMode.SelectedValue);

      khatam.core.data.sql.update(item_name, item_value, "shop", "id", id);

       
      return "0";
  }
    
  protected string update_library(string id)
  {



      ArrayList item_name = new ArrayList();
      ArrayList item_value = new ArrayList();

      item_name.Add("author_book");
      item_value.Add(this.Txt_author.Text);

      item_name.Add("translator");
      item_value.Add(this.Txt_translator.Text);

      item_name.Add("isbn");
      item_value.Add(this.Txt_isbn.Text);

      item_name.Add("Link1");
      item_value.Add(this.Txt_Link1_Book.Text);

      item_name.Add("Link2");
      item_value.Add(this.Txt_Link2_Book.Text);

  
      khatam.core.data.sql.update(item_name, item_value, "library", "id", id);



       

      return "0";
  }

  protected string update_software(string id)
  {
           ArrayList item_name = new ArrayList();
      ArrayList item_value = new ArrayList();

        
      item_name.Add("password");
      item_value.Add(this.Txt_Password.Text);

      item_name.Add("link1");
      item_value.Add(this.Txt_Link1.Text);

      item_name.Add("link2");
      item_value.Add(this.Txt_Link2.Text);

      item_name.Add("link3");
      item_value.Add(this.Txt_Link3.Text);

      item_name.Add("crack1");
      item_value.Add(this.Txt_Crack1.Text);

      item_name.Add("crack2");
      item_value.Add(this.Txt_Crack2.Text);

      item_name.Add("sitebuilder");
      item_value.Add(Txt_BuilderSite.Text);



      khatam.core.data.sql.update(item_name, item_value, "software", "id", id);
        

      return "0";
  }

  protected string update_clip(string id)
  {
      ArrayList item_name = new ArrayList();
      ArrayList item_value = new ArrayList();


      item_name.Add("password");
      item_value.Add(this.Txt_Clip_Password.Text);

      item_name.Add("link1");
      item_value.Add(this.Txt_Clip_Link1.Text);

      item_name.Add("link2");
      item_value.Add(this.Txt_Clip_Link2.Text);

      item_name.Add("link3");
      item_value.Add(this.Txt_Clip_Link3.Text);



      khatam.core.data.sql.update(item_name, item_value, "clip", "id", id);


      return "0";
  }

  void SaveTags()
  {
      string tag1 = "9999999999999999999", tag2 = "9999999999999999999", tag3 = "9999999999999999999",
         tag4 = "9999999999999999999", tag5 = "9999999999999999999", tag6 = "9999999999999999999",
         tag7 = "9999999999999999999", tag8 = "9999999999999999999", tag9 = "9999999999999999999",
         tag10 = "9999999999999999999";

      String rawXml = Hidden1.Value;
      XmlDocument xmlDoc = new XmlDocument();
      xmlDoc.LoadXml(rawXml);
      XmlNode root = xmlDoc.FirstChild;

      Label2.Text = Hidden1.Value;

      if (root.HasChildNodes)
      {
          for (int i = 0; i < root.ChildNodes.Count; i++)
          {
              switch (i)
              {
                  case 0:
                      tag1 = root.ChildNodes[i].InnerText; break;
                  case 1:
                      tag2 = root.ChildNodes[i].InnerText; break;
                  case 2:
                      tag3 = root.ChildNodes[i].InnerText; break;
                  case 3:
                      tag4 = root.ChildNodes[i].InnerText; break;
                  case 4:
                      tag5 = root.ChildNodes[i].InnerText; break;
                  case 5:
                      tag6 = root.ChildNodes[i].InnerText; break;
                  case 6:
                      tag7 = root.ChildNodes[i].InnerText; break;
                  case 7:
                      tag8 = root.ChildNodes[i].InnerText; break;
                  case 8:
                      tag9 = root.ChildNodes[i].InnerText; break;
                  case 9:
                      tag10 = root.ChildNodes[i].InnerText; break;
                  default:
                      break;
              }


          }

      }


      Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


      parameters.Add("catid", idpage_content);
      parameters.Add("tag1", tag1);
      parameters.Add("tag2", tag2);
      parameters.Add("tag3", tag3);
      parameters.Add("tag4", tag4);
      parameters.Add("tag5", tag5);
      parameters.Add("tag6", tag6);
      parameters.Add("tag7", tag7);
      parameters.Add("tag8", tag8);
      parameters.Add("tag9", tag9);
      parameters.Add("tag10", tag10);

      DBFunctions.ExecuteNonQuery("core_tags_update", parameters, System.Data.CommandType.StoredProcedure, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        

  }

  protected string update_content(string id, string type_content)
  {

      ArrayList item_name = new ArrayList();
      ArrayList item_value = new ArrayList();

    
          item_name.Add("page");
        //  item_value.Add(ih.Value );
         // item_value.Add( hta.InnerText  );
          item_value.Add(CKEditor1.Text);
    


      item_name.Add("Enable");
      item_value.Add(this.chk_Content_Enable.Checked);

      item_name.Add("title");
      item_value.Add(this.Txt_Title.Text);

      item_name.Add("keywords");
      item_value.Add(this.txt_tag_keywords.Text);

      item_name.Add("Description");
      item_value.Add(this.txt_tag_Description.Text);

      item_name.Add("Author");
      item_value.Add(this.txt_tag_Author.Text);

      item_name.Add("update_date");
      item_value.Add(DateTime.UtcNow);

item_name.Add("update_user");
      item_value.Add(UserId);

      bool validdate = false;



      if (ValidationALL)
      {
          validdate = this.chk__Valid_Enable.Checked;
            
      }

      if (ValidationALL == false)
          if ((isInsertUser) && (ValidationOwn))
          {
              validdate = chk__Valid_Enable.Checked;
          }





     khatam.core.data.sql.updateField("valid", validdate.ToString(), "id", idpage_content, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

     khatam.core.data.sql.updateField("important", chk_important_Enable.Checked.ToString() , "id", idpage_content, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

       

      khatam.core.data.sql.update(item_name, item_value, type_content, "id", id);

      khatam.core.data.sql.updateField("cname", Txt_Title.Text, "id", idpage_content, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


      /********************/
        DateTime irDateTime = new DateTime();

        int minute, hours;
        hours = (int.Parse(ddl_time.SelectedValue) / 60) ;
        minute = int.Parse(ddl_time.SelectedValue) - (hours * 60);

        irDateTime = khatam.core.globalization.dateTime.GetGregorianDateTimeFromPersianTime(
           txt_birthday.Text  + " " + hours + ":" + minute + ":00");
        //DateTime showTime = DateTime.Parse(khatam.core.data.sql.getField("Fill_Field_ContentValid", "showtime", "id", idpage_content, "cat"));
        //txt_birthday.SelectedDateTime = showTime;
        //DateTime dtLocal = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(showTime, TimeZoneInfo.Utc.Id, "Iran Standard Time");
        //ddl_time.SelectedValue = ((dtLocal.Hour * 60) + dtLocal.Minute).ToString();

        khatam.core.data.sql.updateField("showtime", irDateTime.ToString() , "id", idpage_content, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
     
        /********************/

        SaveTags();

        return "0";
    }


    protected string update_fileDL(string id, string type_content)
    {

        ArrayList item_name = new ArrayList();
        ArrayList item_value = new ArrayList();


        if (this.FileDLName.Text != ""  )
       {

        //khatam.core.data.sql.ErrorLogAdd("22222" + fileDLnewUploaded.ToString());

      
            item_name.Add("size");
            item_value.Add(this.FileDLSize.Text   );

            item_name.Add("fileDL");
            item_value.Add(this.FileDLName.Text  );

            khatam.core.data.sql.update(item_name, item_value, type_content, "id", id);

       }

        return "0";
    }




    protected void back_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=folder&cat=" + khatam.core.data.sql.getField( "pid", "id", this.Request.QueryString["id"], "cat"));
    }


    
    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        string path;
        path = Server.MapPath(@"upload\content\" + type_content + @"\0\");
        for (int i = 0; i < 10; i++)
        {
            DirectoryInfo di = new DirectoryInfo(Server.MapPath(@"upload\content\" + type_content + @"\" + i.ToString() + @"\"));
            if (di.Exists == false)
            {
                di.Create();
            }
        }
        lblError.Text  = "";
           if (FileUpload1.HasFile)
           {

            string extention= System.IO.Path.GetExtension(FileUpload1.FileName).ToUpper();
            if ((".JPG" == extention) || (".GIF" == extention) || (".PNG" == extention))
            {
                int fileSize = FileUpload1.PostedFile.ContentLength;
                if (fileSize < 400000)
                {
                   try
                   {

                       FileUpload1.SaveAs(path + Request.QueryString["id"] + "_" + FileUpload1.FileName);
                       Literal2.Text = "ارسال موفقیت آمیز تصویر <br> " +
                       "File name: " +
                       FileUpload1.PostedFile.FileName + "<br>" +
                       "File Size: " +
                       FileUpload1.PostedFile.ContentLength + " kb<br>" +
                       "Content type: " +
                       FileUpload1.PostedFile.ContentType;



                       string[] stringBuffer;
                       stringBuffer = this.FileUpload1.PostedFile.FileName.Split('\\');
                       Literal2.Text = Path.GetFileName(this.FileUpload1.PostedFile.FileName); //stringBuffer(UBound(stringBuffer)); 

                       string filePath;
                       filePath = Request.QueryString["id"] + "_" + Path.GetFileName(this.FileUpload1.PostedFile.FileName);

                       image_resize(filePath, type_content, "1", 50, 50);
                       image_resize(filePath, type_content, "2", 75, 75);
                       image_resize(filePath, type_content, "3", 100, 100);
                       image_resize(filePath, type_content, "4", 120, 120);
                       image_resize(filePath, type_content, "5", 150, 150);
                       image_resize(filePath, type_content, "6", 200, 200);
                       image_resize(filePath, type_content, "7", 300, 300);
                       image_resize(filePath, type_content, "8", 400, 400);


                       string image_path;

                       this.Literal3.Text = "";

                       for (int i = 1; i < 9; i++)
                       {

                           image_path = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"manage/upload/content/" + type_content + @"/" + i.ToString() + @"/" +

                                filePath;

                           this.Literal3.Text = this.Literal3.Text + " <img  src=" + image_path + " />";
                       }



                   }
                   catch (Exception ex)
                   {
                       lblError.Text = "ERROR: " + ex.Message.ToString();

                   }

                }
                else
                {
                    lblError.Text = fileSize + "حجم فایل انتخابی شما از 400 کیلو بایت بیشتر است";

                }
            }
            else
            {
                lblError.Text = "نوع فایل انتخابی شما برای آپلود مجاز نیست. پسوند های معتبر  jpg,gif,png,jpeg";
            }
              // }
         
           }
           else
           {
               //'پیام در صورت عدم انتخاب فایل
               Literal2.Text = "فایلی انتخاب نشده است";
           }
        
         
         

    }
    


    public void image_resize(string filename, string cat_type, string idcoreRulesImageSize, int Width, int Height)
    {
        FileStream fs = new FileStream(Server.MapPath(@"upload\content\" + type_content + @"\0\") + filename, FileMode.Open, FileAccess.Read, FileShare.Read);
        System.Drawing.Image image = System.Drawing.Image.FromStream(fs);



        fs.Close();
        fs = null;

        int w, h;
        w = image.Width;
        h = image.Height;

        if (w > h)
        {
            Height = (h * Width) / w;
        }
        else
        {
            Width = (Height * w) / h;
        }

        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image, Width, Height);

        //Dim bitmap As New System.Drawing.Bitmap(image, Me.txt_width.Text, Me.Txt_height.Text)



        //'bitmap.Save(MapPath("uploaded_images/t__" + fileName), image.RawFormat);
        bitmap.Save(Server.MapPath(@"upload\content\" + cat_type + @"\" + idcoreRulesImageSize + @"\") + filename, image.RawFormat);

    }


    protected void Btn_Mobile_Upload_Click(object sender, EventArgs e)
    {

    }
    protected void btnUploadDirectLinkImage_Click(object sender, EventArgs e)
    {

      

        string path;

        path = Server.MapPath(@"upload\content\" + type_content + @"\DL\");

        

            DirectoryInfo di = new DirectoryInfo(Server.MapPath(@"upload\content\" + type_content + @"\DL\"));
            if (di.Exists == false)
            {
                di.Create();
            }


            if (FileUploadDirectLink.HasFile)
        {
            
            try
            {

                //'back to root folder
                //'path = path.Replace("\cp", "")
                FileUploadDirectLink.SaveAs(path + Request.QueryString["id"] + "_" + FileUploadDirectLink.FileName);
                LiteralDirectLink.Text = "ارسال موفقیت آمیز<br> " +
                "File name: " +
                Request.QueryString["id"] + "_" + FileUploadDirectLink.FileName + "<br>" +
                "File Size: " +
                FileUploadDirectLink.PostedFile.ContentLength + " kb<br>" +
                "Content type: " +
                FileUploadDirectLink.PostedFile.ContentType;

                this.FileDLName.Text = Request.QueryString["id"] + "_" + FileUploadDirectLink.FileName;

                this.FileDLSize.Text     = FileUploadDirectLink.PostedFile.ContentLength.ToString();
                

                //'split file name
                string[] stringBuffer;
                stringBuffer = this.FileUploadDirectLink.PostedFile.FileName.Split('\\');
                //LiteralDirectLink.Text = Path.GetFileName(this.FileUploadDirectLink.PostedFile.FileName); //stringBuffer(UBound(stringBuffer)); 


                 }
            catch (Exception ex)
            {
                LiteralDirectLink.Text = "ERROR: " + ex.Message.ToString();
               // fileDLnewUploaded = false;
            }
        }
        else
        {
            //'پیام در صورت عدم انتخاب فایل
            LiteralDirectLink.Text = "none";
            //fileDLnewUploaded = false;
        }



 
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
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        //hide_wins();
       // setOptionalField();
        saleTerms_hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        khatam.core.data.sql.Sql_Del_Row("core_sale_terms_id", sale_term_del_lbl_id.Text, "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        this.saleTerm_gv.DataBind();

        saleTerms_hideWins();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
     //   this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "del")
        {
            saleTerms_hideWins();
            //##SaleTerm_del_label.Text = this.GridView22.Rows[this.GridView22.SelectedIndex].Cells[0].Text;
            this.divDelSaleTerm.Visible = true;

        }

        if (e.CommandName == "editcom")
        {
           // hideWins();
        //   this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
         //   this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
          //  this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

          //  this.msgEdit.Visible = true;

        }
    }

    protected void imgBtnPayCycleNew_Click(object sender, ImageClickEventArgs e)
    {
        this.hide_wins();
      //  this.TextBox1.Text = "";
        this.paycycle_div_msgAdd.Visible = true;
            
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
       // object tag1 = DBNull.Value, tag2 = DBNull.Value, tag3 = DBNull.Value, tag4 = DBNull.Value, tag5 = DBNull.Value,
       //     tag6 = DBNull.Value, tag7 = DBNull.Value, tag8 = DBNull.Value, tag9 = DBNull.Value, tag10 = DBNull.Value;
       

    


            //khatam.core.data.sql.updateField("valid",false 

           

           // update_content(idpage,type_content );



            switch (type_content)
            {



                case "article":
                case "special_pages":
                case "service":
                case "research_project":
                case "help":
                case "sample_exam":
                case "car":
                    update_content(idpage, type_content);
                    break;

                case "portal":
                    update_content(idpage, type_content);
                    update_portal(idpage);
                    break;
                case "picture":
                    update_content(idpage, type_content);
                    update_fileDL(idpage, type_content);
                    break;
                case "host":
                    update_content(idpage, type_content);
                    //  update_host(idpage, type_content)
                    break;
                case "news":
                    update_content(idpage, type_content);
                    update_news(idpage);
                    break;
                case "library":
                    update_content(idpage, type_content);
                    update_library(idpage);
                    update_fileDL(idpage, type_content);
                    break;
                case "software":
                    update_content(idpage, type_content);
                    update_software(idpage);
                    update_fileDL(idpage, type_content);
                    break;
                case "mobile":
                    update_content(idpage, type_content);
                    //update_mobile(idpage, type_content)
                    update_fileDL(idpage, type_content);
                    break;
                case "clip":
                    update_content(idpage, type_content);
                    update_clip(idpage);
                    update_fileDL(idpage, type_content);
                    break;
                case "shop":
                    update_content(idpage, type_content);
                    update_shop(idpage);
                    break;
                case "menu":
                    update_menu(idpage);
                    break;
                case "domain":
                    update_content(idpage, type_content);
                    //update_menu(idpage);
                    break;
                case "Link":
                case "link":

                    update_content(idpage, type_content);
                    update_link(idpage);
                    break;
                case "estate":

                    update_content(idpage, type_content);
                    update_estate(idpage);
                    break;


                default:
                    break;
            }




            if (Literal2.Text != "")
            {
                khatam.core.data.sql.updateField("image", this.Request.QueryString["id"] + "_" + Literal2.Text, "id", idpage, type_content, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }


        



            // lblTrace.Text = PlaceHolder_fieldTab.
            //   Count.ToString();/

            //##  this.Response.Redirect("~/manage/?mode=folder&cat=" + khatam.core.data.sql.getField("backurl", "pid", "id", this.Request.QueryString["id"], "cat"));



            //ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "tmp", "<script type='text/javascript'>for ( var i = 0; i < parent.frames.length; ++i ) if ( parent.frames[i].FCK ) parent.frames[i].FCK.UpdateLinkedField();</script>", false);


            //   RedirectTo("~/manage/?mode=folder&cat=" + khatam.core.data.sql.getField("backurl", "pid", "id", this.Request.QueryString["id"], "cat"));
       

        setTags();
        setNavi();

        MSG_OK.Visible = true;
    }


    void setOptionalField()
    {
        foreach (var c in PlaceHolder_fieldTab.Controls)
        {
            if (c is DropDownList)
            {
                DropDownList dl = new DropDownList();
                dl = (DropDownList)c;


                string strPropDefValId;
                strPropDefValId = dl.ID.Replace("ddlDefVal_", "");

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                TextBox txtVal = new TextBox();
                txtVal = (TextBox)this.PlaceHolder_fieldTab.FindControl("txtDefVal_" + strPropDefValId);

                if (dl.SelectedItem.Text == "---")
                {
                    a.Add("value");
                    b.Add(txtVal.Text);
                }
                else
                {
                    a.Add("value");
                    b.Add(dl.SelectedItem.Text);


                }

                //  a.Add(txtVal.Text);

                khatam.core.data.sql.Add(a, b, "core_prop_val");

            }
        }
    }


    protected void btn_cancel_Click(object sender, EventArgs e)
    {
      string  pid = khatam.core.data.sql.getField( "pid", "id", idpage_content, "cat");
      this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=folder&cat="
          + pid);
    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }



    protected void imgBtnCore_PropAdd_Click(object sender, ImageClickEventArgs e)
    {
        hide_wins();
        divPropAdd.Visible = true;
    }
    protected void btnPropAdd_Save_Click(object sender, EventArgs e)
    {

        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();
        a.Add("title");
        b.Add(txtPropTitle.Text);

        khatam.core.data.sql.Add(a,b,"core_prop");

        gv_prop.DataBind();

        hide_wins();
        setOptionalField();
        divPropMsgOk.Visible = true;
    }


    protected void gv_prop_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.gv_prop.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "defVals")
        {    
             hide_wins();
             hide_wins_defVal();
            
             SqlDataSource4.SelectCommand = "SELECT     core_prop_defVal_id, core_prop_id, title FROM         core_prop_defVal " +
             " WHERE     (core_prop_id = " + this.gv_prop.SelectedRow.Cells[0].Text + ")";

             divPropEditDefVal.Visible = true;
            //     Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            //   this.MSG3.Visible = true;

        }

        if (e.CommandName == "editcom")
        {
            // hideWins();
            //   this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            //   this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            //  this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

            //  this.msgEdit.Visible = true;

        }
    }
    protected void imgBtn_prop_defVal_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void imgBtnprop_defValADD_Click(object sender, ImageClickEventArgs e)
    {
        divProp_defVal_ADD.Visible = true;

    }

    void   hide_wins_defVal()
    {
        divProp_defVal_ADD.Visible = false;
    }

  

    protected void btnPropAddDefVal_Save_Click(object sender, EventArgs e)
    {
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();
        a.Add("title");
        b.Add(txt_Prop_defVal_ADD_title.Text );

        a.Add("core_prop_id");
        b.Add("3");
        //b.Add(txt_Prop_defVal_ADD_title.Text );

        

        khatam.core.data.sql.Add(a, b, "core_prop_defval");

        gv_propDefVal.DataBind();

        hide_wins_defVal();
        setOptionalField();
        //divPropMsgOk.Visible = true;
    }
    protected void btnPropAddDefVal_Cancel_Click(object sender, EventArgs e)
    {
        
        hide_wins_defVal();
    }

    protected void imgBtnCore_SaleTermShowAdd_Click(object sender, ImageClickEventArgs e)
    {
        //hide_wins();
        saleTerms_hideWins();
     //   DDL_SaleTerm_ADD_Country.DataSource = getCountry();


     //   DDL_SaleTerm_ADD_Country.DataTextField = "country_title";
//        DDL_SaleTerm_ADD_Country.DataValueField = "country_id";

 //       DDL_SaleTerm_ADD_Country.Items.Add("همه کشور ها");

      //  DDL_SaleTerm_ADD_Country.DataBind();

        sale_term_lbl_min_unit_field.Text = "(" + ddl_shop_units.SelectedItem.Text + ")";
   
        
        divAddSaleTerm.Visible = true;
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

  
             protected void saleTerm_add_btnSave_Click(object sender, EventArgs e)
             {

                 if (khatam.core.data.sql.Sql_Check_identity("min", this.Saleterm_Add_txt_min.Text, "catid",
                       this.Request.QueryString["id"], "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
                 {

                     ArrayList a = new ArrayList();
                     ArrayList b = new ArrayList();
                     a.Add("catId");
                     b.Add(this.Request.QueryString["id"]);


                     a.Add("min");
                     b.Add(this.Saleterm_Add_txt_min.Text);


                     a.Add("price");
                     b.Add(this.Saleterm_Add_txt_Price.Text);

                     a.Add("price_unit");
                     b.Add("68");                                      

                     a.Add("sale_mode");
                     b.Add("1");


                     khatam.core.data.sql.Add(a, b, "core_sale_terms");

                     this.saleTerm_gv.DataBind();

                     // hide_wins();
                     saleTerms_hideWins();


                     divOkSaleTerm.Visible = true;
                 }
                 else
                 {

                     sale_term_lbl_min_unit_field2.Text = "(" + ddl_shop_units.SelectedItem.Text + ")";
                     sale_term_lbl_min_quantity_field.Text = Saleterm_Add_txt_min.Text;
        
                     saleTerm_div_error_min.Visible = true;

                 }


             }
             protected void saleTerm_gv_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
             {
                 this.saleTerm_gv.SelectedIndex = int.Parse(e.CommandArgument.ToString());


                 if (e.CommandName == "del")
                 {
                     

                     saleTerms_hideWins();
                     sale_term_del_lbl_id.Text = saleTerm_gv.Rows[this.saleTerm_gv.SelectedIndex].Cells[0].Text;
                     divDelSaleTerm.Visible = true;

                    
                    // hide_wins();
                    // hide_wins_defVal();

                    // SqlDataSource4.SelectCommand = "SELECT     core_prop_defVal_id, core_prop_id, title FROM         core_prop_defVal " +
                   //  " WHERE     (core_prop_id = " + this.gv_prop.SelectedRow.Cells[0].Text + ")";

                   ///  divPropEditDefVal.Visible = true;
                     //     Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
                     //   this.MSG3.Visible = true;

                 }

                 if (e.CommandName == "editcom")
                 {
                    saleTerms_hideWins();
                    sale_term_edit_lbl_min_unit_field.Text = "(" + ddl_shop_units.SelectedItem.Text + ")";
                    saleTerm_Edit_lbl_code.Text = this.saleTerm_gv.Rows[this.saleTerm_gv.SelectedIndex].Cells[0].Text;
                    Saleterm_Edit_txt_min.Text = this.saleTerm_gv.Rows[this.saleTerm_gv.SelectedIndex].Cells[1].Text;
                    Saleterm_Edit_txt_Price.Text = this.saleTerm_gv.Rows[this.saleTerm_gv.SelectedIndex].Cells[2].Text;
                     //   this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
                     //   this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
                     //  this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

                     this.divEditSaleTerm.Visible = true;

                 }
             }

             protected void saleTerm_gv_RowCommand(object sender, EventArgs e)
             {

             }
             protected void paycycle_btn_add_save_Click(object sender, EventArgs e)
             {
                 ArrayList a = new ArrayList();
                 ArrayList b = new ArrayList();
                 
                 a.Add("month");
                 b.Add(DropDownList1.SelectedValue);
                 
                 a.Add("catId");
                 b.Add(this.Request.QueryString["id"]);

                 a.Add("price");
                 b.Add(paycycle_txt_price.Text);

                 a.Add("enable");
                 b.Add(true);
                 
                 //##واحد پول 



                 khatam.core.data.sql.Add(a, b, "core_paycycle");

                 this.paycycle_gv.DataBind();

                 hide_wins();
                
                 divPropMsgOk.Visible = true;
             }
             protected void paycycle_btn_add_Cancel_Click(object sender, EventArgs e)
             {
                 hide_wins();
             }
             protected void Saleterm_Add_ddl__SelectedIndexChanged(object sender, EventArgs e)
             {
                 
             }
      
             protected void ddl_shop_units_SelectedIndexChanged1(object sender, EventArgs e)
             {
              //   divAddSaleTerm.Visible = false;
                 sale_term_lbl_min_unit_field.Text = "(" + ddl_shop_units.SelectedItem.Text + ")";
                 sale_term_lbl_min_unit_field2.Text = "(" + ddl_shop_units.SelectedItem.Text + ")";

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

             protected void saleTerm_Edit_btnSave_Click(object sender, EventArgs e)
             {
              //   bool changed;
                // if (this.Saleterm_Edit_txt_min.Text != this.saleTerm_gv.Rows[this.saleTerm_gv.SelectedIndex].Cells[1].Text)
                  //   changed = true;

               //  if (khatam.core.data.sql.Sql_Check_identity("min", this.Saleterm_Edit_txt_min.Text, "catid",
                 //      this.Request.QueryString["id"], "core_sale_terms", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
                 if (Sql_Check_Edit(this.Saleterm_Edit_txt_min.Text,this.saleTerm_gv.Rows[this.saleTerm_gv.SelectedIndex].Cells[0].Text,
                     this.Request.QueryString["id"]))
                 {

                     ArrayList a = new ArrayList();
                     ArrayList b = new ArrayList();
                     a.Add("catId");
                     b.Add(this.Request.QueryString["id"]);


                     a.Add("min");
                     b.Add(this.Saleterm_Edit_txt_min.Text);


                     a.Add("price");
                     b.Add(this.Saleterm_Edit_txt_Price.Text);

                     a.Add("price_unit");
                     b.Add("68");


                     khatam.core.data.sql.update(a, b, "core_sale_terms", "core_sale_terms_id",saleTerm_Edit_lbl_code.Text);

                     this.saleTerm_gv.DataBind();

                     // hide_wins();
                     saleTerms_hideWins();


                     divOkSaleTerm.Visible = true;
                 }
                 else
                 {

              
                     sale_term_edit_lbl_min_unit_field2.Text = "(" + ddl_shop_units.SelectedItem.Text + ")";
                     sale_term_edit_lbl_min_quantity_field.Text = Saleterm_Edit_txt_min.Text;

                     saleTerm_edit_div_error_min.Visible = true;

                 }
             }

             protected void estate_ddl_agreement_type_SelectedIndexChanged(object sender, EventArgs e)
             {
                 estate_div_foroshPrices.Visible = false ;
                 estate_div_rahnEjare.Visible = false ;


                 if (estate_ddl_agreement_type.SelectedValue == "1")
                 {
                     estate_div_foroshPrices.Visible = true;
                 }
                 else
                 {
                     estate_div_rahnEjare.Visible = true;
                 }
             }
             protected void btnUploadTour_Click(object sender, EventArgs e)
             {
                 hide_wins();
                 // Make sure file has been uploaded and has a ZIP extension...
                 if (!fu_tour.HasFile || string.Compare(".zip", Path.GetExtension(fu_tour.FileName), true) != 0  )
                 {
                     DisplayAlert("فایل معتبر نیست، لطفا فایل تور مجازی با پسوند زیپ را انتخاب نمایید");
                     return;
                 }

               
                 var extractToFolder = Server.MapPath("~/manage/upload/Content/estate/tour/" + idpage );

                 DirectoryInfo di = new DirectoryInfo(extractToFolder);
                 if (di.Exists == false)
                 {
                     di.Create();
                 }

                 FileCleanup(extractToFolder );  

                 using (var zip = ZipFile.Read(fu_tour.FileBytes))
                 {


                     zip.ExtractAll(extractToFolder, ExtractExistingFileAction.DoNotOverwrite);

                           DirectoryInfo directoryInfo = new DirectoryInfo( extractToFolder + @"/_flash/");
    //  Response.Write("Directory Name :" + directoryInfo.FullName.ToString());

foreach (FileInfo fileInfo in directoryInfo.GetFiles())
{
    if (fileInfo.Name.ToString().StartsWith("TourWeaver_"))
    {
           lt_tourFileName.Text =fileInfo.Name.ToString();
    }
}


                     
                     //   gvZIPContents.DataSource = zip.Entries;
                     // gvZIPContents.DataBind();
                 }

               //  load_xml_content((Server.MapPath("upload\\") + "xml_settings.xml"));
             }

             private static void FileCleanup(string directoryName)
             {
                 try
                 {
                     string[] filenames = Directory.GetFiles(directoryName);

                     foreach (string filename in filenames)
                     {
                         File.Delete(filename);
                     }

                     string[] dirnames = Directory.GetDirectories(directoryName);

                     foreach (string dirname in dirnames)
                     {
                         Directory.Delete(dirname, true);
                     }
                     //if (Directory.Exists(directoryName))
                     // {
                     //   Directory.Delete(directoryName);
                     // }
                 }
                 catch (Exception ex)
                 {
                     // you might want to log it, or swallow any exceptions here 
                 }
             } 

             protected virtual void DisplayAlert(string message)
             {
                 this.Page.ClientScript.RegisterStartupScript(
                                   this.GetType(),
                                   Guid.NewGuid().ToString(),
                                   string.Format("alert('{0}');", message.Replace("'", @"\'")),
                                   true
                               );
             }

       
             protected void Button3_Click(object sender, EventArgs e)
             {
             }
}