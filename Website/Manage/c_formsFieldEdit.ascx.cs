using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Xml;

public partial class Manage_c_formsFieldEdit : System.Web.UI.UserControl
{

    khatam.fb_forms.fb_form form = new khatam.fb_forms.fb_form();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (khatam.core.ConfigurationManager.License.demo == true)
        {

          this.btnSaveStatus.Enabled = false;
           btnSaveStatus.ToolTip = "در نسخه دمو این امکان وجود ندارد";
        }

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "فرم ها";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/forms.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=forms\">فرم ها</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " ویرایش فیلد ها";
        l.Text = l.Text + "</span> ";

        TextHidden.ClientIDMode = System.Web.UI.ClientIDMode.Static;
        btnSaveStatus.ClientIDMode = System.Web.UI.ClientIDMode.Static;

        form = khatam.fb_forms.getForm(this.Request.QueryString["id"]);
        lbl_Form_Name.Text = form.form_name;
        lbl_Form_descraption.Text = form.form_description;

        sortable.ClientIDMode = System.Web.UI.ClientIDMode.Static;

        if (Page.IsPostBack == false)
        {
            sortableBind();

        }

  
     

        //System.Web.UI

    }

    public void sortableBind()
    {

        sortable.InnerHtml = "";
        DataTable dt = new DataTable();
        dt = khatam.fb_forms.getElementTable(this.Request.QueryString["id"]);

        for (int i = 10000; i < dt.Rows.Count + 10000; i++)
        {
            int j = i - 10000;

            // string multiOptionXML;
            //  multiOptionXML = "<multi_option></multi_option><multi_option></multi_option><multi_option></multi_option><multi_option></multi_option>";


            string html = "";




            string privateStr, element_id,
            size, req, unique, DefValue, guidelines, title, element_type;

            privateStr = dt.Rows[j].ItemArray[7].ToString();
            element_id = dt.Rows[j].ItemArray[0].ToString();
            size = dt.Rows[j].ItemArray[4].ToString();
            req = dt.Rows[j].ItemArray[5].ToString();
            unique = dt.Rows[j].ItemArray[6].ToString();
            DefValue = dt.Rows[j].ItemArray[10].ToString();
            guidelines = dt.Rows[j].ItemArray[3].ToString();
            title = dt.Rows[j].ItemArray[2].ToString();
            element_type = dt.Rows[j].ItemArray[8].ToString();

            switch (element_type)
            {
                case "text":
                case "phone":
                case "cellphone":
                case "url":
                case "email":
                case "currency":
                    html = getHtmlControl_text(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title, element_type);
                    break;
                case "section":
                    html = getHtmlControl_section(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;
                case "date":
                    html = getHtmlControl_date(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;
                case "file":
                    html = getHtmlControl_file(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;
                case "number":
                    html = getHtmlControl_number(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;
                case "textarea":
                    html = getHtmlControl_textarea(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;
                case "checkbox":
                    html = getHtmlControl_checkbox(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;

                case "radio":
                    html = getHtmlControl_radio(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;

                case "select":
                    html = getHtmlControl_select(i, privateStr, element_id, size, req, unique, DefValue, guidelines, title);
                    break;

                default:
                    break;
            }




            sortable.InnerHtml = sortable.InnerHtml + html;
        }
    }

    public static string getHtmlControl_text(int i, string privateStr, string element_id,
        string size, string req, string unique, string DefValue, string guidelines, string title, string element_type)
    {


        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\"  element_type=\"" + element_type + "\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" + unique +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br><input id=\"f" + i + "_text\" class=\"Element_TextBox_" + size + "\" type=\"text\" />" +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }

    public static string getHtmlControl_section(int i, string privateStr, string element_id,
     string size, string req, string unique, string DefValue, string guidelines, string title)
    {


        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\"  element_type=\"section\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" + unique +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><hr/><span id=\"f" + i + "title\">" + title + "</span>" +
             " " +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }


    public static string getHtmlControl_file(int i, string privateStr, string element_id,
    string size, string req, string unique, string DefValue, string guidelines, string title)
    {


        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\"  element_type=\"file\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" + unique +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br><input id=\"f" + i + "_text\" class=\"Element_TextBox_" + size + "\" type=\"text\" /><input id=\"Button1\" type=\"button\"  value=\"upload\" />" +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }

    public static string getHtmlControl_date(int i, string privateStr, string element_id,
string size, string req, string unique, string DefValue, string guidelines, string title)
    {


        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\"  element_type=\"date\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" + unique +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br><input id=\"f" + i + "_text\" class=\"Element_TextBox_" + size + "\" type=\"text\" value=\"1390/12/30\"  />" +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }

    public static string getHtmlControl_number(int i, string privateStr, string element_id,
    string size, string req, string unique, string DefValue, string guidelines, string title)
    {


        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\"  element_type=\"number\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" + unique +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br><input id=\"f" + i + "_text\" class=\"Element_TextBox_" + size + "\" type=\"text\" value=\"0123456789\"  />" +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }

    public static string getHtmlControl_textarea(int i, string privateStr, string element_id,
    string size, string req, string unique, string DefValue, string guidelines, string title)
    {


        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\"  element_type=\"textarea\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" + unique +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br> <textarea id=\"f" + i + "_text\" class=\"Element_TextBox_" + size + "\" type=\"textarea\" ></textarea> " +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }


    public static string getHtmlControl_checkbox(int i, string privateStr, string element_id,
    string size, string req, string unique, string DefValue, string guidelines, string title)
    {



        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\" element_type=\"checkbox\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br>    " + generate_checkbox_Options(element_id, "f" + i.ToString()) +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }

    public static string getHtmlControl_radio(int i, string privateStr, string element_id,
string size, string req, string unique, string DefValue, string guidelines, string title)
    {


      

        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\" element_type=\"radio\"  isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br>    " + generate_radio_Options(element_id, "f" + i.ToString()) +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";

        return html;
    }

    public static string getHtmlControl_select(int i, string privateStr, string element_id,
 string size, string req, string unique, string DefValue, string guidelines, string title)
    {



        string html = "<div id=\"f" + i + "\" class=\"fieldBorder\" element_type=\"select\" isnew=\"false\" deleted=\"false\" private=\"" + privateStr + "\"   element_id=\"" + element_id +
             "\"  size=\"" + size + "\" " +
             "\" req=\"" + req + "\" unique=\"" +
             "\" DefValue=\"" + DefValue + "\" guidelines=\"" + guidelines + "\"  ><span id=\"f" + i + "title\">" + title + "</span>" +
             " <span id=\"f" + i + "regStar\" class=\"regStar\">*</span></br>    " + generate_select_Options(element_id, "f" + i.ToString()) +
            // " <input id=\"f" + i + "_txtOptionHidden\" type=\"text\" value=\"" + multiOptionXML + "\" /> " +
         " <div id=\"f" + i + "b\"  class=\"fieldBorderBtns\"><img id=\"f" + i + "deleteBtn\" showerid=\"f" + i + "\" class=\"deleteBtn\" " +
         " src=\"../core/themeCP/Bitrix/cssimage/btn/delete.gif\" /> </div> </div>";




        return html;
    }


    public static string generate_checkbox_Options(string element_id, string id)
    {
        string chkBox = "<div id=\"" + id + "checkboxGroup\" >";


        //   chkBox =
        //   "<input id=\"Checkbox1\" type=\"checkbox\" /> حق انتخاب یک </br>" +
        //    "<input id=\"Checkbox1\" type=\"checkbox\" /> حق انتخاب یک </br>" +
        //    "<input id=\"Checkbox1\" type=\"checkbox\" /> حق انتخاب یک </br>";

        DataTable dt = new DataTable();
        dt = getFb_element_live_options(element_id);

        for (int i = 10000; i < dt.Rows.Count + 10000; i++)
        {
            int j = i - 10000;

            string oid = id + "_o" + i;

            string strChecked = "";
            if (bool.Parse(dt.Rows[j].ItemArray[6].ToString()))
            {
                strChecked = "checked=\"checked\"";
            }
            chkBox = chkBox + "<div id=\"" + oid + "\" element_id=\"" + dt.Rows[j].ItemArray[0].ToString() + "\"    deleted=\"false\"  isnew=\"false\" option_is_default=\"" + dt.Rows[j].ItemArray[6].ToString() + "\"   ><input id=\"" + oid + "chk\" type=\"checkbox\" " +
                strChecked + " readonly=\"readonly\" /> <span id=\"" + oid + "title\">" + dt.Rows[j].ItemArray[5].ToString() + "</span></br></div>";

        }

        chkBox = chkBox + "</div>";

        return chkBox;
    }

    public static string generate_radio_Options(string element_id, string id)
    {
        string chkBox = "<div id=\"" + id + "checkboxGroup\" >";


        //   chkBox =
        //   "<input id=\"Checkbox1\" type=\"checkbox\" /> حق انتخاب یک </br>" +
        //    "<input id=\"Checkbox1\" type=\"checkbox\" /> حق انتخاب یک </br>" +
        //    "<input id=\"Checkbox1\" type=\"checkbox\" /> حق انتخاب یک </br>";

        DataTable dt = new DataTable();
        dt = getFb_element_live_options(element_id);

        for (int i = 10000; i < dt.Rows.Count + 10000; i++)
        {
            int j = i - 10000;

            string oid = id + "_o" + i;

            string strChecked = "";
            if (bool.Parse(dt.Rows[j].ItemArray[6].ToString()))
            {
                strChecked = "checked=\"checked\"";
            }
            chkBox = chkBox + "<div id=\"" + oid + "\" element_id=\"" + dt.Rows[j].ItemArray[0].ToString() + "\"    deleted=\"false\"  isnew=\"false\" option_is_default=\"" + dt.Rows[j].ItemArray[6].ToString() +
                "\"   ><input id=\"" + oid + "chk\" type=\"radio\" " +
                strChecked + " readonly=\"readonly\"    name=\"groupF" + element_id + "\"   /> <span id=\"" + oid + "title\">" + dt.Rows[j].ItemArray[5].ToString() + "</span></br></div>";

        }

        chkBox = chkBox + "</div>";

        return chkBox;
    }

    public static string generate_select_Options(string element_id, string id)
    {
        string chkBox = "<select id=\"" + id + "checkboxGroup\" style=\"font-family: tahoma\" >";

        DataTable dt = new DataTable();
        dt = getFb_element_live_options(element_id);

        for (int i = 10000; i < dt.Rows.Count + 10000; i++)
        {
            int j = i - 10000;

            string oid = id + "_o" + i;

            string strChecked = "";
            if (bool.Parse(dt.Rows[j].ItemArray[6].ToString()))
            {
                strChecked = "  selected=\"selected\" ";
            }

            //chkBox = chkBox + "<div id=\"" + oid + "\" element_id=\"" + dt.Rows[j].ItemArray[0].ToString() + "\"    deleted=\"false\"  isnew=\"false\" option_is_default=\"" + dt.Rows[j].ItemArray[6].ToString() + "\"   ><input id=\"" + oid + "chk\" type=\"checkbox\" " +
              //  strChecked + " readonly=\"readonly\" /> <span id=\"" + oid + "title\">" + dt.Rows[j].ItemArray[5].ToString() + "</span></br></div>";

            chkBox = chkBox + "<option id=\"" + oid + "\"   isnew=\"false\" element_id=\"" + dt.Rows[j].ItemArray[0].ToString() + 
                "\"  deleted=\"false\" option_is_default=\"" + dt.Rows[j].ItemArray[6].ToString() + "\"" +  strChecked   +  " >" + dt.Rows[j].ItemArray[5].ToString() + "</option>";

        }

        chkBox = chkBox + "</select>";

        return chkBox;
    }

    public static DataTable getFb_element_live_options(string element_id)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        parameters.Add("element_id", element_id);
        str_sql = "SELECT     aeo_id, form_id, element_id, option_id, position, option_title, option_is_default, live FROM         fb_element_options WHERE     ((element_id = @element_id) and (live=1)) order by position";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }

    public static DataTable getFb_element_all_options(string element_id)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
        parameters.Add("element_id", element_id);
        str_sql = "SELECT     aeo_id, form_id, element_id, option_id, position, option_title, option_is_default, live FROM         fb_element_options WHERE     (element_id = @element_id)  order by position";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }




    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/Default.aspx?mode=forms");
    }
    protected void btnSaveStatus_Click(object sender, EventArgs e)
    {

        saveFields();

        sortableBind();

        //khatam.core.data.sql.ErrorLogAdd(TextHidden.Value);
    }




    public void saveFields()
    {
        /*decelaration*/
        String rawXml = TextHidden.Value;
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(rawXml);
        XmlNode root = xmlDoc.FirstChild;
        string str = "";

        if (root.HasChildNodes)
        {
            for (int i = 0; i < root.ChildNodes.Count; i++)
            {

                //check is new element
                if (root.ChildNodes[i].Attributes["id"].Value.ToString().Length < 6)
                {
                    //check is not deleted element
                    if (root.ChildNodes[i].Attributes["deleted"].Value.ToString() != "true")
                    {


                        string element_id = element_Add(root.ChildNodes[i].Attributes["element_type"].Value.ToString(), root.ChildNodes[i].Attributes["title"].Value.ToString()
                               , i.ToString()
                               , root.ChildNodes[i].Attributes["guidelines"].Value.ToString()
                               , root.ChildNodes[i].Attributes["size"].Value.ToString()
                               , root.ChildNodes[i].Attributes["req"].Value.ToString()
                               , root.ChildNodes[i].Attributes["unique"].Value.ToString()
                               , root.ChildNodes[i].Attributes["private"].Value.ToString()
                               , root.ChildNodes[i].Attributes["DefValue"].Value.ToString());



                        switch (root.ChildNodes[i].Attributes["element_type"].Value.ToString())
                        {
                            case "text":
                            case "phone":
                            case "cellphone":
                            case "url":
                            case "email":
                            case "currency":
                            case "number":
                            case "textarea":
                            case "date":
                            case "section":
                            case "file":
                                khatam.core.data.sql.addColumn("element_" + element_id, "nvarchar(max)", "fb_form_" + form.form_id);
                                break;
                            case "checkbox":
                            case "radio":
                            case "select":
                                saveOptionsAdd(element_id, i, root.ChildNodes[i].Attributes["element_type"].Value.ToString());
                                break;
                            default:
                                break;
                        }


          


                    }
                }
                //is old element
                else
                {

                    //check old element is deleted 
                    if (root.ChildNodes[i].Attributes["deleted"].Value.ToString() == "true")
                    {


                        switch (root.ChildNodes[i].Attributes["element_type"].Value.ToString())
                        {
                            case "text":
                            case "number":
                            case "textarea":
                                khatam.core.data.sql.delColumn("element_" + root.ChildNodes[i].Attributes["element_id"].Value.ToString(), "fb_form_" + form.form_id);
                                //khatam.core.data.sql.addColumn("element_" + element_id, "nvarchar(max)", "fb_form_" + form.form_id);
                                break;
                            case "checkbox":
                            case "radio":
                            case "select":

                                DataTable dtRows = new DataTable();
                                dtRows = getFb_element_all_options(root.ChildNodes[i].Attributes["element_id"].Value.ToString());
                                for (int z = 0; z < dtRows.Rows.Count; z++)
                                {
                                    khatam.core.data.sql.delColumn(
                                        "element_" + root.ChildNodes[i].Attributes["element_id"].Value.ToString() + "_" + dtRows.Rows[z].ItemArray[0].ToString()
                                        , "fb_form_" + form.form_id);
                                }

                                khatam.core.data.sql.Sql_Del_Row("element_id", root.ChildNodes[i].Attributes["element_id"].Value.ToString(),
                                    "fb_element_options", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                                //saveOptions(element_id, i, root.ChildNodes[i].Attributes["element_type"].Value.ToString(), elementSaveType.add);
                                break;
                            default:
                                break;
                        }

                        khatam.core.data.sql.Sql_Del_Row("element_id", root.ChildNodes[i].Attributes["element_id"].Value.ToString(),
                            "fb_form_elements", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    }
                    //old element is not deleted and need update
                    else
                    {
                        //### next step if changed
                        element_Update(root.ChildNodes[i].Attributes["element_id"].Value.ToString(),
                                  "true",
                                  root.ChildNodes[i].Attributes["element_type"].Value.ToString(),
                            // root.ChildNodes[i].Attributes["element_type"].Value.ToString(),
                                   root.ChildNodes[i].Attributes["title"].Value.ToString(),
                                   i.ToString(),
                                   root.ChildNodes[i].Attributes["guidelines"].Value.ToString(),
                                   root.ChildNodes[i].Attributes["size"].Value.ToString(),
                                    root.ChildNodes[i].Attributes["req"].Value.ToString(),
                                   root.ChildNodes[i].Attributes["unique"].Value.ToString(),
                                   root.ChildNodes[i].Attributes["private"].Value.ToString(),
                                   root.ChildNodes[i].Attributes["DefValue"].Value.ToString()

                                   );

                        switch (root.ChildNodes[i].Attributes["element_type"].Value.ToString())
                        {
                            case "checkbox":
                            case "radio":
                            case "select":
                                saveOptionsUpdate(root.ChildNodes[i].Attributes["element_id"].Value.ToString(), i, root.ChildNodes[i].Attributes["element_type"].Value.ToString());


                                break;
                            default:
                                break;
                        }



                    }

                }

            }



        }
    }




    public void saveOptionsAdd(string element_id, int i, string elementType)
    {
        String rawXml = TextHidden.Value;
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(rawXml);
        XmlNode root = xmlDoc.FirstChild;
        string str = "";
        // this.Response.Redirect("http://www.google.com");
        if (root.ChildNodes[i].HasChildNodes)
        {

            for (int k = 0; k < root.ChildNodes[i].ChildNodes.Count; k++)
            {
                if (!bool.Parse(root.ChildNodes[i].ChildNodes[k].Attributes["deleted"].Value.ToString()))
                {

                    string element_option_id = element_option_Add(form.form_id, element_id, k.ToString(),
                        root.ChildNodes[i].ChildNodes[k].Attributes["title"].Value.ToString(),
                        root.ChildNodes[i].ChildNodes[k].Attributes["option_is_default"].Value.ToString(), "1");

                    khatam.core.data.sql.addColumn("element_" + element_id + "_" + element_option_id, "bit", "fb_form_" + form.form_id);
                }

            }
        }



    }

    public void saveOptionsUpdate(string element_id, int i, string elementType)
    {
        String rawXml = TextHidden.Value;
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(rawXml);
        XmlNode root = xmlDoc.FirstChild;
        string str = "";
        // this.Response.Redirect("http://www.google.com");

        if (root.ChildNodes[i].HasChildNodes)
        {

            for (int k = 0; k < root.ChildNodes[i].ChildNodes.Count; k++)
            {
                //new
                if (bool.Parse(root.ChildNodes[i].ChildNodes[k].Attributes["isnew"].Value.ToString()))
                {

                    ///new not deleted
                    if (!bool.Parse(root.ChildNodes[i].ChildNodes[k].Attributes["deleted"].Value.ToString()))
                    {

                        string element_option_id = element_option_Add(form.form_id, element_id, k.ToString(),
                            root.ChildNodes[i].ChildNodes[k].Attributes["title"].Value.ToString(),
                            root.ChildNodes[i].ChildNodes[k].Attributes["option_is_default"].Value.ToString(), "1");

                        khatam.core.data.sql.addColumn("element_" + element_id + "_" + element_option_id, "bit", "fb_form_" + form.form_id);
                    }

                }
                else
                {
                    //old
                    //not deleted
                    if (!bool.Parse(root.ChildNodes[i].ChildNodes[k].Attributes["deleted"].Value.ToString()))
                    {
                        element_option_update(root.ChildNodes[i].ChildNodes[k].Attributes["element_id"].Value.ToString(),
                            k.ToString(), root.ChildNodes[i].ChildNodes[k].Attributes["title"].Value.ToString(),
                           root.ChildNodes[i].ChildNodes[k].Attributes["option_is_default"].Value.ToString(), "1");

                        //khatam.core.data.sql.addColumn("element_" + element_id + "_" + element_option_id, "bit", "fb_form_" + form.form_id);
                    }
                    //deleted
                    else
                    {
                        khatam.core.data.sql.updateField("live", "0", "aeo_id", root.ChildNodes[i].ChildNodes[k].Attributes["element_id"].Value.ToString(), "fb_element_options"
                            , khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }


                    // TextBox1.Text = TextBox1.Text + root.ChildNodes[i].ChildNodes[k].Attributes["title"].Value.ToString();
                }


            }



        }

    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }


    public string element_Add(string type, string title, string position, string guidelines,
        string size, string required, string unique, string str_private, string default_value)
    {
        ArrayList item = new ArrayList(), value = new ArrayList();
        item.Add("element_title");
        value.Add(title);

        item.Add("element_size");
        value.Add(size);


        item.Add("element_type");
        value.Add(type);

        item.Add("form_id");
        value.Add(form.form_id);

        item.Add("element_position");
        value.Add(position);

        item.Add("element_guidelines");
        value.Add(guidelines);
        //################     	
        item.Add("element_is_required");
        value.Add(required);

        item.Add("element_is_unique");
        value.Add(unique);

        item.Add("element_is_private");
        value.Add(str_private);

        item.Add("element_default_value");
        value.Add(default_value);

        return khatam.core.data.sql.Add(item, value, "fb_form_elements");
    }

    public void element_Update(string element_id, string changed, string type, string title, string position, string guidelines,
        string size, string required, string unique, string str_private, string default_value)
    {
        ArrayList item2 = new ArrayList(), value2 = new ArrayList();
        if (changed == "true")
        {

            item2.Add("element_title");
            value2.Add(title);


            item2.Add("element_size");
            value2.Add(size);

            item2.Add("element_guidelines");
            value2.Add(guidelines);


            item2.Add("element_is_private");
            value2.Add(str_private);


            item2.Add("element_type");
            value2.Add(type);

            item2.Add("element_is_required");
            value2.Add(required);

            item2.Add("element_is_unique");
            value2.Add(unique);

            item2.Add("element_default_value");
            value2.Add(default_value);


        }
        item2.Add("element_position");
        value2.Add(position);

        khatam.core.data.sql.update(item2, value2, "fb_form_elements", "element_id", element_id);
    }


    public string element_option_Add(string form_id, string element_id, string position,
        string option_title, string option_is_default, string live)
    {

        ArrayList item = new ArrayList(), value = new ArrayList();
        item.Add("form_id");
        value.Add(form_id);

        item.Add("element_id");
        value.Add(element_id);

        item.Add("option_id");
        value.Add("1");

        item.Add("position");
        value.Add(position);

        item.Add("option_title");
        value.Add(option_title);

        item.Add("option_is_default");
        value.Add(option_is_default);

        item.Add("live");
        value.Add("1");


        return khatam.core.data.sql.Add(item, value, "fb_element_options");
    }

    public bool element_option_update(string aeo_id, string position,
       string option_title, string option_is_default, string live)
    {

        ArrayList item = new ArrayList(), value = new ArrayList();
        // item.Add("form_id");
        // value.Add(form_id);

        // item.Add("element_id");
        // value.Add(element_id);

        item.Add("option_id");
        value.Add("1");

        item.Add("position");
        value.Add(position);

        item.Add("option_title");
        value.Add(option_title);

        item.Add("option_is_default");
        value.Add(option_is_default);

        item.Add("live");
        value.Add(live);


        return khatam.core.data.sql.update(item, value, "fb_element_options", "aeo_id", aeo_id);
    }

}