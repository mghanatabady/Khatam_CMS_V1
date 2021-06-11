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
                [ToolboxData("<{0}:upload runat=server></{0}:upload>")]
                public class upload : CompositeControl
                {

                    public string text;
                    public bool required;
                    public string ValidationGroup;
                    public  FileUpload _FileUpload = new FileUpload();


                    enum fileValidotrMode
                    {
                        picture,document,software,all
                    }


                    protected override void CreateChildControls()
                    {
                     
                       PlaceHolder ph = new PlaceHolder();

                        _FileUpload.ID = "OFileUpload_" + this.UniqueID.Replace("$","_")  ;
                        _FileUpload.ClientIDMode = System.Web.UI.ClientIDMode.Static;
                        _FileUpload.Font.Name = "tahoma";


                        ph.Controls.Add(new LiteralControl(text ));

                      //  if (fb_form_element.element_guidelines != "")
                        //    ph.Controls.Add(new LiteralControl(" <a href=\"#\" class=\"tooltipA\" onMouseOver = \"return tooltip('" + fb_form_element.element_guidelines +
                          //      "', '" + fb_form_element.element_title + "', 'width:150, titletextcolor:#FFFFFF,direction:rtl, bordercolor:#333333, backcolor:#EEEEEE');\"onmouseout=\"return hideTip();\" onClick=\"return false;\">[?]</a>"));
                        

                        if (required)
                        {
                            RequiredFieldValidator rfv = new RequiredFieldValidator();
                            rfv.ControlToValidate = _FileUpload.ID ;
                            rfv.Text = "*";
                            rfv.ErrorMessage = "آپلود فیلد " + text  + " الزامی است";
                            rfv.ValidationGroup = ValidationGroup ;
                            ph.Controls.Add(rfv);
                        }

                            CustomValidator _CustomValidator = new CustomValidator();
                            _CustomValidator.ValidationGroup= ValidationGroup;
                            _CustomValidator.ClientValidationFunction="ValidateFile";
                            //_CustomValidator.ErrorMessage ="<span dir=\"rtl\">" + "نوع فایل انتخابی شما برای آپلود مجاز نیست. پسوند های معتبر  jpg,pdf,gif,png,doc,docx,jpeg,xls,xlsx" + "</span>";
                            _CustomValidator.ErrorMessage =  "نوع فایل انتخابی شما برای آپلود مجاز نیست. پسوند های معتبر  jpg,pdf,gif,png,doc,docx,jpeg,xls,xlsx" ;
                            _CustomValidator.Text  = "*";
                            _CustomValidator.ControlToValidate = _FileUpload.ID;

                            ph.Controls.Add(_CustomValidator );

        

             

                       // lbl_file_type.ClientIDMode = System.Web.UI.ClientIDMode.Predictable  ;
                       // lbl_file_type.ClientID = "ddd";
                       // lbl_file_type.ClientID  = "1111";

                      //  OFileUpload.ClientIDMode = System.Web.UI.ClientIDMode.AutoID;

                        ph.Controls.Add(new LiteralControl("<script type =\"text/javascript\">"));
                        ph.Controls.Add(new LiteralControl(" var validFilesTypes = [\"bmp\", \"gif\", \"png\", \"jpg\", \"jpeg\", \"doc\", \"xls\"];"));
                        ph.Controls.Add(new LiteralControl(" function ValidateFile(oSrc, args) {"));
                        ph.Controls.Add(new LiteralControl(" var file = document.getElementById(\"" +  _FileUpload.ID + "\");"));
                        //ph.Controls.Add(new LiteralControl(" var label = document.getElementById(\"" + _FileUpload.ID + "\");"));
                        ph.Controls.Add(new LiteralControl(" var path = file.value;"));
                        ph.Controls.Add(new LiteralControl(" var ext = path.substring(path.lastIndexOf(\".\") + 1, path.length).toLowerCase();"));
                        ph.Controls.Add(new LiteralControl(" var isValidFile = false;"));
                        ph.Controls.Add(new LiteralControl(" for (var i = 0; i < validFilesTypes.length; i++) {"));
                        ph.Controls.Add(new LiteralControl(" if (ext == validFilesTypes[i]) {"));
                        ph.Controls.Add(new LiteralControl(" isValidFile = true;"));
                        ph.Controls.Add(new LiteralControl(" break;"));
                        ph.Controls.Add(new LiteralControl(" }"));
                        ph.Controls.Add(new LiteralControl(" }"));
                     ///   + " if (!isValidFile) {"
                     ///   + " label.style.color = \"red\";"
                        // + " label.innerHTML = \"Invalid File. Please upload a File with  extension:bmp,gif,png,jpg,jpeg,doc,xls\""
                      ///  + " label.innerHTML = \"نوع فایل انتخابی شما برای آپلود مجاز نیست. پسوند های معتبر  jpg,pdf,gif,png,doc,docx,jpeg,xls,xlsx \""
                        // + " label.innerHTML = \"Invalid File. Please upload a File with\" ;"
                        //+ " label.innerHTML = \"Invalid File. Please upload a File with\" +"
                        // + "\" extension:\n\n\" + validFilesTypes.join(\", \");"
                       // + " }"
                       ph.Controls.Add(new LiteralControl( "args.IsValid =isValidFile; "));
                        //+" return false;"
                        ph.Controls.Add(new LiteralControl( " }"));
                        ph.Controls.Add(new LiteralControl( " </script>"));

                        string html2 = "<script type=\"text/javascript\">"
+ " function ValidateFile(oSrc, args){"
+ "args.IsValid =false;"// (args.Value.length >= 8);"
+ " }"
+ " </script>";

                        



                        //Type="Date" ControlToValidate="PersianDateTextBox"  ></asp:RangeValidator>

                        ph.Controls.Add(new LiteralControl("<br />"));
                        ph.Controls.Add(_FileUpload);
                        ph.Controls.Add(new LiteralControl("<br />"));

                      

                        ph.Controls.Add(new LiteralControl("<br />"));
                        

                        this.Controls.Add(ph);

                        
                        
                    }

                  
                   
                

                


                 


                 


                }
            }

        }
    }
}






                        