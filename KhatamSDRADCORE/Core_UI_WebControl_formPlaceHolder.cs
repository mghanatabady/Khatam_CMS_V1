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
using System.IO;

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
                [ToolboxData("<{0}:formPlaceHolder runat=server></{0}:formPlaceHolder>")]
                public class formPlaceHolder : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string windowsMode;
                    public string instanceID;
                    public string formID;
                    public Boolean winVisible;
                    public bool readOnly  ;
                    public string formResultID;
                   

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



                    khatam.fb_forms.fb_form fb_form = new khatam.fb_forms.fb_form();
                    DataTable dt = new DataTable();







                    protected override void CreateChildControls()
                    {
                        editMode = false;
                        if (editMode) this.Controls.Add(new LiteralControl("<div class=\"ve_div\">"));

                       // formID = "12";

                        if (editMode)
                        {
                            ImageButton btnEdit = new ImageButton();
                            btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                            btnEdit.OnClientClick = "child=window.open(\"" +
                                khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                                + "editor.aspx?instanceID=" + instanceID + "&mode=8\",\"_blank\",\" scrollbars=yes, resizable=no, , width=825, height=600\",'child');return false;";
                            this.Controls.Add(btnEdit);
                        }

                        fb_form = khatam.fb_forms.getForm(formID);

                       if (!readOnly) this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                       if (!readOnly) this.Controls.Add(new LiteralControl(fb_form.form_name));
                       if (!readOnly) this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                       if (!readOnly) this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                       if (!readOnly) this.Controls.Add(new LiteralControl(fb_form.form_description));
                       if (!readOnly) this.Controls.Add(new LiteralControl("<br/><br/>"));
                       
                        if (readOnly)
                        {
                            this.Controls.Add(formBody_readOnly());
                        }
                        else
                        {
                            ph_message.Visible = false;

                            ph_message_fileTypeError.Visible = false;
                            this.Controls.Add(message_fileTypeError());



                            this.Controls.Add(message_ok());

                            this.Controls.Add(formBody());

                        }

                        if (!readOnly) this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));

                    }

                    public PlaceHolder ph_message = new PlaceHolder();
                    public PlaceHolder ph_message_fileTypeError = new PlaceHolder();


                    public Control message_ok()
                    {


                        string html =  "<div id=\"MSG2\" runat=\"server\" dir=\"rtl\" style=\"border-right: teal 2px solid; border-top: teal 2px solid;"
                                + " margin-left: 96px; border-left: teal 2px solid; width: 576px; margin-right: 10px;"
                                + " border-bottom: teal 2px solid; height: 45px; text-align: right\" "
                                + " visible=\"False\">"





                              + " <div style=\"margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px\">"
                                 + "   <img  src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg2_icon1.gif\" />"
                             + "</div>"
                             + " <div style=\"padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;"
                             + " padding-top: 5px; height: 26px\">"
                             + " <span style=\"color: black\">عملیات موفقیت آمیز<br />"
                             + " <span style=\"font-size: 9pt\">کاربر گرامی با تشکر از تکمیل فرم، در اسرع وقت "
                             + " به اطلاعات ارسالی شما رسیدگی خواهد شد.</span></span></div>"
                             + " <br />"
                             + " </div>";

                        ph_message.Controls.Add(new LiteralControl(html));

                        return ph_message;
                    }



                    public Control message_fileTypeError()
                    {


                        string html = "<div id=\"MSG2\" runat=\"server\" dir=\"rtl\" style=\"border-right: red 2px solid; border-top: red 2px solid;"
                                + " margin-left: 96px; border-left: red 2px solid; width: 576px; margin-right: 10px;"
                                + " border-bottom: red 2px solid; height: 45px; text-align: right\" "
                                + " visible=\"False\">"





                              + " <div style=\"margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px\">"
                                 + "   <img  src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/themeCP/Bitrix/CssImage/icon/msg1_icon1.gif\" />"
                             + "</div>"
                             + " <div style=\"padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;"
                             + " padding-top: 5px; height: 26px\">"
                             + " <span>خطا<br />"
                             + " <span style=\"font-size: 9pt\">نوع فایلی که قصد آپلود آنرا دارید معتبر نیست "
                             + ".</span></span></div>"
                             + " <br />"
                             + " </div>";
                         
                        ph_message_fileTypeError.Controls.Add(new LiteralControl(html));

                        return ph_message_fileTypeError;
                    }


                    PlaceHolder ph_formBody = new PlaceHolder();

                    public Control formBody()
                    {
                       

                      
                       
                        /***main***/
                        ph_formBody.Controls.Add(new LiteralControl("<div style=\"margin:20px auto 0 auto;text-align: center; width:650px; 	 \">"));

                        /***header***/
                     //   ph_formBody.Controls.Add(new LiteralControl("<div id=\"header\"  style=\" direction:rtl; text-align:right; padding:10px 20px 20px 20px;\">"));

                      //  ph_formBody.Controls.Add(new LiteralControl("<h2>" + fb_form.form_name + "</h2>"));
                      //  ph_formBody.Controls.Add(new LiteralControl("<p>" + fb_form.form_description + "</p>"));
                      //  ph_formBody.Controls.Add(new LiteralControl("</div>"));
                        /***end header***/


                        /***row***/
                        //this.Request.QueryString["id"]




                        dt = khatam.fb_forms.getElementTable(fb_form.form_id);


                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            khatam.fb_forms.fb_form_elements fb_form_elements = new khatam.fb_forms.fb_form_elements();
                            fb_form_elements = khatam.fb_forms.getFormElement(dt.Rows[i].ItemArray[0].ToString());

                            switch (fb_form_elements.element_type)
                            {
                                case "text":
                                case "number":
                                case "textarea":
                                case "phone":
                                case "url":
                                case "email":
                                case "currency":
                                case "date":
                                    ph_formBody.Controls.Add(text(fb_form_elements));
                                    break;
                                case "checkbox":
                                    ph_formBody.Controls.Add(checkbox(fb_form_elements));
                                    break;
                                case "radio":
                                    ph_formBody.Controls.Add(radio(fb_form_elements));
                                    break;
                                case "select":
                                    ph_formBody.Controls.Add(select(fb_form_elements));
                                    break;
                                case "section":
                                    ph_formBody.Controls.Add(section(fb_form_elements));

                                    break;
                                case "file":
                                    ph_formBody.Controls.Add(file(fb_form_elements));

                                    break;
                                default:
                                    break;
                            }



                        }



                        /***end row***/

                        /***footer***/
                        ph_formBody.Controls.Add(new LiteralControl(" <div id=\"footer\"  style=\" direction:rtl; text-align:right;  padding:10px 20px 20px 20px;\">"));


                        ph_formBody.Controls.Add(new LiteralControl("<br/>"));

                        ValidationSummary ValidationSummary = new System.Web.UI.WebControls.ValidationSummary();
                        ValidationSummary.ValidationGroup = "fb_validation_" + instanceID;
                        ValidationSummary.HeaderText = "لطفا به موارد زیر توجه کنید:";
                        ph_formBody.Controls.Add(ValidationSummary);

                        ph_formBody.Controls.Add(new LiteralControl("<br/>"));


                        Button btn1 = new Button();
                        btn1.ID = "btn1";
                        btn1.Text = "تایید";
                        btn1.Font.Name = "tahoma";
                        // btn1.ValidationGroup = "domainSearchWin";
                        btn1.ValidationGroup = "fb_validation_" + instanceID;
                        ///btn1.OnClientClick = "return ValidateFile()";
                        btn1.Click += new EventHandler(btn_ChekDomain_Click);

                        ph_formBody.Controls.Add(btn1);
                        ph_formBody.Controls.Add(new LiteralControl("<br/>"));






                        ph_formBody.Controls.Add(new LiteralControl("</div>"));
                        /***end footer***/




                        ph_formBody.Controls.Add(new LiteralControl("</div>"));
                        /***end main***/

                        return ph_formBody;

                    }

                    public string  getColVal(DataTable dt_result,string element_colname)
                    {
                        for (int i = 0; i < dt_result.Columns.Count  ; i++)
                        {
                            if ((dt_result.Columns[i].ColumnName) == ("element_" + element_colname))
                            {
                                return  dt_result.Rows[0].ItemArray[i].ToString();
                                //dt_result.Columns[i].ColumnName + " element_" + element_colname;// dt_result.Rows[0].ItemArray[3].ToString();
                            }
                        }
                        
                        return "";
                    }

                    public Control formBody_readOnly() 
                    {

                        DataTable dt_result = new DataTable();
                        dt_result = getFormResultTable(fb_form.form_id, formResultID);

                       
                        //GridView gv_result = new GridView();
                        //gv_result.DataSource = dt_result;
                      // dt_result.Rows[0].
                  
                        /***main***/
                        ph_formBody.Controls.Add(new LiteralControl("<div style=\"margin:20px auto 0 auto;text-align: center; width:650px; 	 \">"));

                        /***header***/
                          ph_formBody.Controls.Add(new LiteralControl("<div id=\"header\"  style=\" direction:rtl; text-align:right; padding:10px 20px 20px 20px;\">"));

                          ph_formBody.Controls.Add(new LiteralControl("<h2>" + fb_form.form_name + "</h2>"));
                          ph_formBody.Controls.Add(new LiteralControl("<p>" + fb_form.form_description + "</p>"));
                          ph_formBody.Controls.Add(new LiteralControl("</div>"));
                        /***end header***/


                        /***row***/
                        //this.Request.QueryString["id"]




                        dt = khatam.fb_forms.getElementTable(fb_form.form_id);


                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            khatam.fb_forms.fb_form_elements fb_form_elements = new khatam.fb_forms.fb_form_elements();
                            fb_form_elements = khatam.fb_forms.getFormElement(dt.Rows[i].ItemArray[0].ToString());

                            switch (fb_form_elements.element_type)
                            {
                                case "text":
                                case "number":
                                case "textarea":
                                case "phone":
                                case "url":
                                case "email":
                                case "currency":
                                case "date":

                                     ph_formBody.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                                     ph_formBody.Controls.Add(new LiteralControl(fb_form_elements.element_title)); 
                                     ph_formBody.Controls.Add(new LiteralControl("<br />"));
                                     ph_formBody.Controls.Add(new LiteralControl(getColVal(dt_result, fb_form_elements.element_id)));
                                     ph_formBody.Controls.Add(new LiteralControl("</div>"));

                                   
                                   // ph_formBody.Controls.Add(text(fb_form_elements));
                                    break;
                                case "checkbox":
                                    ph_formBody.Controls.Add(checkbox_readOnly(fb_form_elements));
                                    break;
                                case "radio":
                                    ph_formBody.Controls.Add(radio_readOnly(fb_form_elements));
                                    break;
                                case "select":
                                    ph_formBody.Controls.Add(select_readOnly(fb_form_elements));
                                    break;
                                case "section":
                                    ph_formBody.Controls.Add(section(fb_form_elements));

                                    break;
                                case "file":
                                    ph_formBody.Controls.Add(file_readOnly(fb_form_elements));

                                    break;
                                default:
                                    break;
                            }



                        }



                        /***end row***/

                        




                        this.Controls.Add(new LiteralControl("</div>"));
                        /***end main***/

                        return ph_formBody;

                    }

                    public static DataTable getFormResultTable(string form_id,string result_id)
                    {
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        parameters.Add("result_id", result_id);
                        string str_sql = "SELECT *  FROM [fb_form_" + form_id  + "] where (id=@result_id)";
                        return DBFunctions.ExecuteReader(str_sql , parameters, System.Data.CommandType.Text , khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }

                    void btn_ChekDomain_Click(object sender, EventArgs e)
                    {

                        bool filetypeError = false;
                        string fileName="";
                        //   if (SaveHandler2 != null)
                        //     SaveHandler2(this, e);

                        //   PanelWin.Controls.Clear(); 
                        // (TextBox)FindControl("text1");
                        ArrayList a = new ArrayList();
                        ArrayList b = new ArrayList();

                        a.Add("create_date");
                        b.Add(DateTime.UtcNow.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));

                       

                        a.Add("ip");
                       

                        try
                        {
                            b.Add( HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] );
                        }
                        catch
                        {
                            b.Add("none");
                        }
                     

                        int i;
                        for (i = 0; i < dt.Rows.Count; i++)
                        {

                            switch (dt.Rows[i].ItemArray[8].ToString())
                            {
                                case "text":
                                case "number":
                                case "textarea":
                                case "phone":
                                case "url":
                                case "email":
                                case "currency":
                                case "date":

                                    TextBox Otextbox = (TextBox)FindControl(dt.Rows[i].ItemArray[0].ToString());
                                    a.Add("element_" + dt.Rows[i].ItemArray[0].ToString());
                                    b.Add(Otextbox.Text);
                                    break;
                                case "checkbox":

                                    
                                    string element_id = dt.Rows[i].ItemArray[0].ToString();                                                                    

                                    DataTable dt_options = new DataTable();
                                    dt_options = khatam.fb_forms.getElementOption_Table(element_id);                                    

                                    for (int j = 0; j < dt_options.Rows.Count; j++)
			                        {
                                        CheckBox Ocheckbox = (CheckBox)FindControl(element_id + "_" + dt_options.Rows[j].ItemArray[0]);

			                            a.Add("element_" + element_id + "_" + dt_options.Rows[j].ItemArray[0]);                               
                                        b.Add(Ocheckbox.Checked);
			                        }
                                    break;
                                case "radio":
                                                                       

                                    DataTable dt_radio = new DataTable();
                                    dt_radio = khatam.fb_forms.getElementOption_Table(dt.Rows[i].ItemArray[0].ToString());

                                    for (int j = 0; j < dt_radio.Rows.Count; j++)
                                    {
                                        CheckBox Ocheckbox = (CheckBox)FindControl(dt.Rows[i].ItemArray[0].ToString() + "_" + dt_radio.Rows[j].ItemArray[0]);

                                        a.Add("element_" + dt.Rows[i].ItemArray[0].ToString() + "_" + dt_radio.Rows[j].ItemArray[0]);
                                        b.Add(Ocheckbox.Checked);
                                    }
                                  

                                    break;
                                case "select":


                                    //DataTable dt_select = new DataTable();
                                    ///dt_select = khatam.fb_forms.getElementOption_Table(dt.Rows[i].ItemArray[0].ToString());

                                    DropDownList Oddl = (DropDownList)FindControl(dt.Rows[i].ItemArray[0].ToString());

                                    for (int j = 0; j < Oddl.Items.Count; j++)
                                    {
                                       
                                        //CheckBox Ocheckbox = (CheckBox)FindControl(dt.Rows[i].ItemArray[0].ToString() + "_" + dt_select.Rows[j].ItemArray[0]);

                                         a.Add("element_" + Oddl.Items[j].Value);
                                        b.Add(Oddl.Items[j].Selected);

                                        //a.Add("element_" + dt.Rows[i].ItemArray[0].ToString() + "_" + dt_select.Rows[j].ItemArray[0]);
                                        //b.Add(Oddl.);
                                    }


                                    break;
                                case "file":


                                    FileUpload OfileUpload = (FileUpload)FindControl(dt.Rows[i].ItemArray[0].ToString());
                                    a.Add("element_" + dt.Rows[i].ItemArray[0].ToString());
                                    
                                   


                                    string path;
                                    path = HttpContext.Current.Request.PhysicalApplicationPath + @"manage\upload\content\forms\form_" +formID+  @"\element_" + dt.Rows[i].ItemArray[0].ToString()  + @"\";
                                           

                                        DirectoryInfo di = new DirectoryInfo(path);
                                        if (di.Exists == false)
                                        {
                                            di.Create();
                                        }
                                    //چک کردن نوع فایل

                                        if (OfileUpload.HasFile)
                                        {

                                            if (!khatam.core.Security.file.typeValidator_docPic(OfileUpload.FileName))
                                            {
                                                ph_message_fileTypeError.Visible = true;
                                                filetypeError = true;
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    string guid = Guid.NewGuid().ToString();
                                                    guid = guid.ToString().Replace("-", "");

                                                    fileName = dt.Rows[i].ItemArray[0].ToString() + "_" + guid + "_" + OfileUpload.FileName;

                                                    OfileUpload.SaveAs(path + fileName);
                                                    // LiteralDirectLink.Text = "ارسال موفقیت آمیز<br> " +
                                                    // "File name: " +
                                                    // Request.QueryString["id"] + "_" + FileUploadDirectLink.FileName + "<br>" +
                                                    // "File Size: " +
                                                    // FileUploadDirectLink.PostedFile.ContentLength + " kb<br>" +
                                                    // "Content type: " +
                                                    // FileUploadDirectLink.PostedFile.ContentType;

                                                    // this.FileDLName.Text = Request.QueryString["id"] + "_" + FileUploadDirectLink.FileName;

                                                    //  this.FileDLSize.Text     = FileUploadDirectLink.PostedFile.ContentLength.ToString();


                                                    //'split file name
                                                    string[] stringBuffer;
                                                    stringBuffer = OfileUpload.PostedFile.FileName.Split('\\');
                                                    //LiteralDirectLink.Text = Path.GetFileName(this.FileUploadDirectLink.PostedFile.FileName); //stringBuffer(UBound(stringBuffer)); 

                                                    b.Add(fileName);

                                                }
                                                catch (Exception ex)
                                                {
                                                    b.Add("ERROR: " + ex.Message.ToString());
                                                    // LiteralDirectLink.Text = "ERROR: " + ex.Message.ToString();

                                                }

                                            }
                                   }
                                    else
                                    {

                                        b.Add("فایل انتخاب نشده است");
                                        //'پیام در صورت عدم انتخاب فایل
                                        //LiteralDirectLink.Text = "none";
                                       
                                   }



                                    break;
                             //   default:
                               //     break;
                            }



                        }





                        if (!filetypeError)
                        {
                            khatam.core.data.sql.Add(a, b, "fb_form_" + fb_form.form_id);

                            ph_message_fileTypeError.Visible = false;
                            ph_formBody.Visible = false;
                            ph_message.Visible = true;
                        }
                        //HttpContext.Current.Response.Redirect("http://www.google.com?q=" +i );
                        //PanelWin.Controls.Add(new LiteralControl("sssssssssss"));

                    }


                    public string addInstanceProperty(string Instance)
                    {

                    //    khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal", null);
                     //   khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "formID", formID, "Core_serverControlsInstanceVal", null);

                        return "added";
                    }

                    public Control text(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();



                        TextBox text = new TextBox();
                        text.ID = fb_form_element.element_id;
                        text.Text = fb_form_element.element_default_value;
                        text.Font.Name = "tahoma";

                        if (fb_form_element.element_type == "textarea")
                        {
                            text.TextMode = TextBoxMode.MultiLine;
                            text.Rows = 3;
                        }


                        if (fb_form_element.element_type == "number")
                        {
                            text.Attributes.Add("onkeypress", "return isNumberKey(event)");
                        }

                        if (fb_form_element.element_size == "")
                            text.CssClass = "Element_TextBox_small";
                        else
                            text.CssClass = "Element_TextBox_" + fb_form_element.element_size;





                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        if (fb_form_element.element_guidelines != "")
                            ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                                "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));


                        if (bool.Parse(fb_form_element.element_is_required))
                        {
                            RequiredFieldValidator rfv = new RequiredFieldValidator();
                            rfv.ControlToValidate = text.ID;
                            rfv.Text = "*";
                            rfv.ErrorMessage = "درج فیلد " + fb_form_element.element_title + " الزامی است";
                            rfv.ValidationGroup = "fb_validation_" + instanceID;
                            ph.Controls.Add(rfv);
                        }

                        if (fb_form_element.element_type == "email")
                        {
                            RegularExpressionValidator rfv_email = new RegularExpressionValidator();
                            rfv_email.ControlToValidate = text.ID;
                            rfv_email.Text = "*";
                            rfv_email.ValidationExpression = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                            rfv_email.ErrorMessage = " فیلد " + fb_form_element.element_title + " را با فرمت صحیح ایمیل درج نمایید مانند: example@domain.com";
                            rfv_email.ValidationGroup = "fb_validation_" + instanceID;
                            ph.Controls.Add(rfv_email);
                        }

                        if (fb_form_element.element_type == "date")
                        {
                            RangeValidator rv_date = new RangeValidator();
                            rv_date.ControlToValidate = text.ID;
                            rv_date.Text = "*";
                            rv_date.Type = ValidationDataType.Date;
                            rv_date.MaximumValue = "2012/11/11";
                            rv_date.MinimumValue = "1012/11/11";

                            text.Style.Add("direction", "ltr");


                            rv_date.ErrorMessage = " فیلد " + fb_form_element.element_title + " را با فرمت صحیح تاریخ درج نمایید مانند:format: 1390/12/30  2012/12/30";
                            rv_date.ValidationGroup = "fb_validation_" + instanceID;
                            ph.Controls.Add(rv_date);
                        }

                        //Type="Date" ControlToValidate="PersianDateTextBox"  ></asp:RangeValidator>

                        ph.Controls.Add(new LiteralControl("<br />"));
                        ph.Controls.Add(text);
                        ph.Controls.Add(new LiteralControl("</div>"));




                        return ph;

                    }




                    public Control section(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));
                        ph.Controls.Add(new LiteralControl("<hr />"));
                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));
                        ph.Controls.Add(new LiteralControl("<br />"));
                        ph.Controls.Add(new LiteralControl("<br />"));
                        ph.Controls.Add(new LiteralControl("</div>"));
                        return ph;

                    }


       



                    public Control checkbox(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        TextBox text = new TextBox();
                        text.ID =  fb_form_element.element_id;
                        text.Text = fb_form_element.element_default_value;
                        text.Font.Name = "tahoma";


                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        if (fb_form_element.element_guidelines != "")
                            ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                                "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));


                        ph.Controls.Add(new LiteralControl("<br />"));

                        DataTable dt = new DataTable();
                        dt = fb_forms.getElementOption_Table(fb_form_element.element_id);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            fb_forms.fb_elements_option elements_option = new fb_forms.fb_elements_option();
                            elements_option = fb_forms.getElementOption(dt.Rows[i].ItemArray[0].ToString());

                            CheckBox chbox = new CheckBox();
                            chbox.ID = elements_option.element_id + "_" +elements_option.aeo_id;
                            chbox.Text =  elements_option.option_title;
                            chbox.Checked = bool.Parse(elements_option.option_is_default);
                            ph.Controls.Add(chbox);
                            ph.Controls.Add(new LiteralControl("<br/>"));


                            //ph.Controls.Add(new LiteralControl("results" + elements_option.option_title));
                            // ph.Controls.Add(new LiteralControl("results" + dt.Rows[i].ItemArray[0].ToString()));
                        }

                        ph.Controls.Add(new LiteralControl("</div>"));




                        return ph;

                    }

                    public Control radio(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        TextBox text = new TextBox();
                        text.ID = fb_form_element.element_id;
                        text.Text = fb_form_element.element_default_value;
                        text.Font.Name = "tahoma";


                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        if (fb_form_element.element_guidelines != "")
                            ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                                "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));


                        ph.Controls.Add(new LiteralControl("<br />"));

                        DataTable dt = new DataTable();
                        dt = fb_forms.getElementOption_Table(fb_form_element.element_id);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            fb_forms.fb_elements_option elements_option = new fb_forms.fb_elements_option();
                            elements_option = fb_forms.getElementOption(dt.Rows[i].ItemArray[0].ToString());

                            RadioButton chbox = new RadioButton();
                            chbox.ID = elements_option.element_id + "_" + elements_option.aeo_id;
                            chbox.Text = elements_option.option_title;
                            chbox.GroupName ="group_" + elements_option.element_id;
                            chbox.Checked = bool.Parse(elements_option.option_is_default);
                            ph.Controls.Add(chbox);
                            ph.Controls.Add(new LiteralControl("<br/>"));


                            //ph.Controls.Add(new LiteralControl("results" + elements_option.option_title));
                            // ph.Controls.Add(new LiteralControl("results" + dt.Rows[i].ItemArray[0].ToString()));
                        }

                        ph.Controls.Add(new LiteralControl("</div>"));




                        return ph;

                    }

                    public Control select(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                                                                      

                        DropDownList ddl = new DropDownList();
                        ddl.ID = fb_form_element.element_id;                        
                        ddl.Font.Name = "tahoma";

                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        if (fb_form_element.element_guidelines != "")
                            ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                                "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));


                        ph.Controls.Add(new LiteralControl("<br />"));

                        DataTable dt = new DataTable();
                        dt = fb_forms.getElementOption_Table(fb_form_element.element_id);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            fb_forms.fb_elements_option elements_option = new fb_forms.fb_elements_option();
                            elements_option = fb_forms.getElementOption(dt.Rows[i].ItemArray[0].ToString());
                            
                            ListItem li = new ListItem();
                            li.Value = elements_option.element_id + "_" + elements_option.aeo_id;
                            li.Text = elements_option.option_title;
                            li.Selected =bool.Parse( elements_option.option_is_default);
                            ddl.Items.Add(li);

                            //ph.Controls.Add(new LiteralControl("results" + elements_option.option_title));
                            // ph.Controls.Add(new LiteralControl("results" + dt.Rows[i].ItemArray[0].ToString()));
                        }

                        ph.Controls.Add(ddl);

                        ph.Controls.Add(new LiteralControl("</div>"));




                        return ph;

                    }

                    public Control file(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        FileUpload OFileUpload = new FileUpload();
                        OFileUpload.ID = fb_form_element.element_id;
                        //text.Text = fb_form_element.element_default_value;
                        OFileUpload.Font.Name = "tahoma";                       

                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        if (fb_form_element.element_guidelines != "")
                            ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                                "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));


                        if (bool.Parse(fb_form_element.element_is_required))
                        {
                            RequiredFieldValidator rfv = new RequiredFieldValidator();
                            rfv.ControlToValidate = OFileUpload.ID;
                            rfv.Text = "*";
                            rfv.ErrorMessage = "درج فیلد " + fb_form_element.element_title + " الزامی است";
                            rfv.ValidationGroup = "fb_validation_" + instanceID;
                            ph.Controls.Add(rfv);
                        }

                        Label lbl_file_type = new Label();

                        lbl_file_type.ID ="lbl_"+ fb_form_element.element_id;

                       // lbl_file_type.ClientIDMode = System.Web.UI.ClientIDMode.Predictable  ;
                       // lbl_file_type.ClientID = "ddd";
                       // lbl_file_type.ClientID  = "1111";

                      //  OFileUpload.ClientIDMode = System.Web.UI.ClientIDMode.AutoID;

                        string html = "<script type =\"text/javascript\">"

                        + "var validFilesTypes = [\"bmp\", \"gif\", \"png\", \"jpg\", \"jpeg\", \"doc\", \"xls\"];"
  + " function ValidateFile() {"
+ " var file = document.getElementById(\"" + this.ClientID + "_" + OFileUpload.ClientID + "\");"
 + " var label = document.getElementById(\"" + this.ClientID + "_" + lbl_file_type.ClientID + "\");"
 + " var path = file.value;"
 + " var ext = path.substring(path.lastIndexOf(\".\") + 1, path.length).toLowerCase();"
 + " var isValidFile = false;"
 + " for (var i = 0; i < validFilesTypes.length; i++) {"
 + " if (ext == validFilesTypes[i]) {"
+ " isValidFile = true;"
+ " break;"
 + " }"
 + " }"
 + " if (!isValidFile) {"
 + " label.style.color = \"red\";"
// + " label.innerHTML = \"Invalid File. Please upload a File with  extension:bmp,gif,png,jpg,jpeg,doc,xls\""

 + " label.innerHTML = \"نوع فایل انتخابی شما برای آپلود مجاز نیست. پسوند های معتبر  jpg,pdf,gif,png,doc,docx,jpeg,xls,xlsx \""

// + " label.innerHTML = \"Invalid File. Please upload a File with\" ;"
 //+ " label.innerHTML = \"Invalid File. Please upload a File with\" +"
// + "\" extension:\n\n\" + validFilesTypes.join(\", \");"
 + " }"
  +" return isValidFile;"
 + " }"
                        + " </script>";

                        ph.Controls.Add(new LiteralControl(html));



                        //Type="Date" ControlToValidate="PersianDateTextBox"  ></asp:RangeValidator>

                        ph.Controls.Add(new LiteralControl("<br />"));
                        ph.Controls.Add(OFileUpload);
                        ph.Controls.Add(new LiteralControl("<br />"));

                        ph.Controls.Add(lbl_file_type);

                        ph.Controls.Add(new LiteralControl("<br />"));
                        ph.Controls.Add(new LiteralControl("</div>"));




                        return ph;

                    }






                    /********************************************************************/

                    public Control checkbox_readOnly(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        bool elementIsNewerThanResult = true;

                     
                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

              

                        ph.Controls.Add(new LiteralControl("<br />"));

                        DataTable dt = new DataTable();
                        dt = fb_forms.getElementOption_Table(fb_form_element.element_id);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            fb_forms.fb_elements_option elements_option = new fb_forms.fb_elements_option();
                            elements_option = fb_forms.getElementOption(dt.Rows[i].ItemArray[0].ToString());

                            string str_val = khatam.core.data.sql.getField( "element_" + elements_option.element_id + "_" 
                                + elements_option.aeo_id, "id", formResultID, "fb_form_" + formID);
                            if (str_val != "")
                            {
  

                            CheckBox chbox = new CheckBox();
                            chbox.ID = elements_option.element_id + "_" + elements_option.aeo_id;
                            chbox.Text =elements_option.option_title;

                           // chbox.Checked =bool.Parse( khatam.core.data.sql.getField("formplaceholder", "element_" +
                             //   elements_option.element_id + "_" + elements_option.aeo_id, "id", formResultID, "fb_from_" + formID).ToString());
                            chbox.Checked = bool.Parse(str_val );
                            chbox.Enabled = false;


                                //getColVal(dt_result, fb_form_elements.element_id))
                                //bool.Parse(elements_option.option_is_default);
                            ph.Controls.Add(chbox);
                            ph.Controls.Add(new LiteralControl("<br/>"));


                            //ph.Controls.Add(new LiteralControl("results" + elements_option.option_title));
                            // ph.Controls.Add(new LiteralControl("results" + dt.Rows[i].ItemArray[0].ToString()));
                            elementIsNewerThanResult = false;

                        }

                        }

                        ph.Controls.Add(new LiteralControl("</div>"));



                        if (elementIsNewerThanResult) ph.Controls.Clear();

                        return ph;

                    }

                    public Control radio_readOnly(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        bool elementIsNewerThanResult = true;

                   
                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        if (fb_form_element.element_guidelines != "")
                            ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                                "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));


                        ph.Controls.Add(new LiteralControl("<br />"));

                        DataTable dt = new DataTable();
                        dt = fb_forms.getElementOption_Table(fb_form_element.element_id);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            fb_forms.fb_elements_option elements_option = new fb_forms.fb_elements_option();
                            elements_option = fb_forms.getElementOption(dt.Rows[i].ItemArray[0].ToString());

                            string str_val = khatam.core.data.sql.getField( "element_" + elements_option.element_id + "_" 
                                + elements_option.aeo_id, "id", formResultID, "fb_form_" + formID);
                            if (str_val != "")
                            {
                                RadioButton chbox = new RadioButton();
                                chbox.ID = elements_option.element_id + "_" + elements_option.aeo_id;
                                chbox.Enabled = false;
                                chbox.Text = elements_option.option_title;
                                chbox.GroupName = "group_" + elements_option.element_id;


                               // chbox.Text = str_val;
                                chbox.Checked = bool.Parse(str_val );                            
                                //bool.Parse(elements_option.option_is_default);
                                ph.Controls.Add(chbox);
                                ph.Controls.Add(new LiteralControl("<br/>"));

                                elementIsNewerThanResult = false;
                            }

                            //ph.Controls.Add(new LiteralControl("results" + elements_option.option_title));
                            // ph.Controls.Add(new LiteralControl("results" + dt.Rows[i].ItemArray[0].ToString()));
                        }

                        ph.Controls.Add(new LiteralControl("</div>"));


                        if (elementIsNewerThanResult) ph.Controls.Clear();

                        return ph;

                    }

                    public Control select_readOnly(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        bool elementIsNewerThanResult = true;


                        DropDownList ddl = new DropDownList();
                        ddl.ID = fb_form_element.element_id;
                        ddl.Font.Name = "tahoma";
                        ddl.Enabled = false;
                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        if (fb_form_element.element_guidelines != "")
                            ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                                "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));


                        ph.Controls.Add(new LiteralControl("<br />"));

                        DataTable dt = new DataTable();
                        dt = fb_forms.getElementOption_Table(fb_form_element.element_id);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            fb_forms.fb_elements_option elements_option = new fb_forms.fb_elements_option();
                            elements_option = fb_forms.getElementOption(dt.Rows[i].ItemArray[0].ToString());

                                      string str_val = khatam.core.data.sql.getField( "element_" + elements_option.element_id + "_" 
                                + elements_option.aeo_id, "id", formResultID, "fb_form_" + formID);
                            if (str_val != "")
                            {
                                

                            ListItem li = new ListItem();
                            li.Value = elements_option.element_id + "_" + elements_option.aeo_id;
                            li.Text = elements_option.option_title;
                            li.Selected = bool.Parse(elements_option.option_is_default);
                            ddl.Items.Add(li);
                            elementIsNewerThanResult = false;
                            }

                            //ph.Controls.Add(new LiteralControl("results" + elements_option.option_title));
                            // ph.Controls.Add(new LiteralControl("results" + dt.Rows[i].ItemArray[0].ToString()));
                        }

                        ph.Controls.Add(ddl);

                        ph.Controls.Add(new LiteralControl("</div>"));


                        if (elementIsNewerThanResult) ph.Controls.Clear();


                        return ph;

                    }

                    public Control file_readOnly(khatam.fb_forms.fb_form_elements fb_form_element)
                    {
                        PlaceHolder ph = new PlaceHolder();

                        bool elementIsNewerThanResult = true;

                     //   FileUpload OFileUpload = new FileUpload();
                     //   OFileUpload.ID = fb_form_element.element_id;
                        //text.Text = fb_form_element.element_default_value;
                      //  OFileUpload.Font.Name = "tahoma";

                        


                        ph.Controls.Add(new LiteralControl("<div  class=\"fb_row\">"));

                        ph.Controls.Add(new LiteralControl(fb_form_element.element_title));

                        string str_val = khatam.core.data.sql.getField( "element_" + fb_form_element.element_id , "id", formResultID, "fb_form_" + formID);

                        //Type="Date" ControlToValidate="PersianDateTextBox"  ></asp:RangeValidator>
                        if (str_val !="")
                        {
                            ph.Controls.Add(new LiteralControl("<a href=\"" + 
                            khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "Manage/upload/Content/forms/form_" + formID + "/element_"
                            + fb_form_element.element_id + "/"  + str_val  + "\">" + str_val +
                            "</a>"));
                        }

                        ph.Controls.Add(new LiteralControl("<br />"));
                       
                        ph.Controls.Add(new LiteralControl("</div>"));




                        return ph;

                    }



                }
            }

        }
    }
}
