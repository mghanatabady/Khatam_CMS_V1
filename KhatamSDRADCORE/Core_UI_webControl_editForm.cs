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
using System.Threading;



namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:editForm runat=server></{0}:editForm>")]
                public class editForm : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;                    

                    Panel pEdit = new Panel();
                    Panel pEditDialog = new Panel();

                    static Button btnok = new Button();

                    Panel PanelWin = new Panel();
                    Label Lbl1 = new Label();

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
                    

                    public string windowsMode;

                    public string instanceID;

                    public Boolean winVisible;

                    public HtmlTextArea hta = new HtmlTextArea();                   

                    public HtmlInputHidden ih = new HtmlInputHidden();

                    private  AjaxControlToolkit.ModalPopupExtender mPop = new AjaxControlToolkit.ModalPopupExtender();

                    PlaceHolder phFormEdit = new PlaceHolder();


                    protected override void CreateChildControls()
                    {
                                 

                        
                    
                        string scID;
                        scID = khatam.core.data.sql.getField( "id_core_serverControl", "id", instanceID, "Core_serverControlsInstance");

                        string scTitle;
                        scTitle = khatam.core.data.sql.getField( "title", "id", instanceID, "Core_serverControlsInstance");

                        string scDicId;
                        scDicId = khatam.core.data.sql.getField( "IdDictionary", "id", scID, "Core_serverControls");

                        string scDicTitle;
                        scDicTitle = khatam.core.data.sql.getField( "title", "id_dictionary", scDicId, "id_language", "1", "Dictionary_Lang");
                        

                        ImageButton btnEdit = new ImageButton();
                          btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                          btnEdit.CssClass = "editBtn";
                         // btnEdit.Attributes.Add("onmouseover", "return tooltip(' نوع این شی " + scDicTitle + " می باشد و می توانید متن و تصویر و ... را به صورت دلخواه در آن درج نمایید','" + "ویرایش شی " + instanceID + " - " + scTitle + "','direction:rtl,width:170');");
                         // btnEdit.Attributes.Add("click", "return hideTip();");
                         // btnEdit.Attributes.Add("onclick", "return hideTip();");


                        btnEdit.Attributes.Add("onmouseout", "return hideTip();");
                      


                        string str = "<div id=\"msgDel\"   style=\" width:875px ;background-color:White ; \"  > " +
                                     "  <div  style=\" background-color:#e2ebee; color:#282a2c;  font-weight:bold; cursor:default; height:30px; padding :10px;  font-size:12pt; text-align:right; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #ecf1f3;\">" +
                                     "فرم ویرایش شی شماره " + instanceID + " - " + scTitle  + " [نوع شی:" + scDicTitle + "]" +
                                     "  </div> " +
                                     "  <div style=\" background-color:White ;  width:875px ; display:inline-block  ; border-top-color: #e5e5e5;\"> ";

                        this.Page.Title = "فرم ویرایش شی شماره " + instanceID + " - " + scTitle + " - " + " نوع شی:" + scDicTitle;

                        this.Controls.Add(new LiteralControl(str));

                        if (scID == "8")
                        {

                            editorContentWin();
                        }

                        if (scID == "3")
                        {

                            editMenu();
                        }

                        if (scID == "12")
                        {

                            editorcontentList();

                        }

                        if (scID == "15")
                        {
                            
                           // editorSearchWin();
                        }

                        if (scID == "16")
                        {
                            editorSlider();
                        }

                        if (scID == "19")
                        {

                            editorSearchWin();
                        }

                        if (scID == "23")
                        {

                            editordomainSearchWin();
                        }

                     

                        if (scID == "26")
                        {

                            editortabList();
                        }

                        if (scID == "28")
                        {

                            editorEstateSearchWin();
                        }





                       // phFormEdit.Controls.Add(editorContentWin())ss;
                       // phFormEdit.Visible = false;
                       // this.Controls.Add(phFormEdit);                                                 
                      
                        string str2 = "  </div> " +
                                      "  <div style=\" text-align:right ;margin-top:10px; padding-right:10px ; padding-bottom:10px ; \">";
                        this.Controls.Add(new LiteralControl(str2));

                        Button btnSave = new Button
                        {
                            BackColor = System.Drawing.ColorTranslator.FromHtml("#9DC023"),
                            BorderStyle = BorderStyle.Solid,
                            Text = "تایید",
                            ForeColor= System.Drawing.Color.White ,
                            BorderWidth = Unit.Pixel(1),
                            BorderColor = System.Drawing.ColorTranslator.FromHtml("#74991A")

                        };
                        btnSave.OnClientClick = "  this.value = 'بروز رسانی...'; this.style.background = 'silver';";
                        btnSave.Font.Name = "tahoma";
                        btnSave.Font.Bold = true;
                        btnSave.Width = Unit.Pixel(58);                        
                        btnSave.Height = Unit.Pixel(31);
                        btnSave.Click += new EventHandler(btnAddSave_Click);
                        this.Controls.Add(btnSave);

                        this.Controls.Add(new LiteralControl(" "));


                        //new EventHandler(btnAddSave_Click)
                        Button btnCancel = new Button
                        {
                            BackColor = System.Drawing.ColorTranslator.FromHtml("#dfe9ec"),
                            BorderStyle = BorderStyle.Solid,
                            Text = "انصراف",
                            BorderWidth = Unit.Pixel(1),
                            BorderColor = System.Drawing.ColorTranslator.FromHtml("#959C9D")
                        };
                        btnCancel.Font.Name = "tahoma";
                        btnCancel.Font.Bold = true;
                        btnCancel.Width = Unit.Pixel(58);
                        btnCancel.Height = Unit.Pixel(31);
                        btnCancel.Click += new EventHandler(btnCancel_Click);
                        this.Controls.Add(btnCancel);

                        this.Controls.Add(new LiteralControl("</div> "));
                        this.Controls.Add(new LiteralControl("</div> "));



                    }

                    protected void editMenu()
                    {


                        this.Parent.Page.Title = "فرم ویرایش شی شماره " + instanceID;

                        this.Controls.Add(new LiteralControl("<div  dir=\"rtl\">"));


                        this.Controls.Add(new LiteralControl("</br>"));

                        this.Controls.Add(new LiteralControl("فرم ویرایش"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("</br>"));

                        this.Controls.Add(new LiteralControl("<strong>پهنا</strong>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(TxtWidth(instanceID));

                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("</br>"));

                        this.Controls.Add(new LiteralControl("<strong>قالب</strong>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(DDLskin(instanceID));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(btnSave());
                        this.Controls.Add(btnCanel());




                        this.Controls.Add(new LiteralControl("</div>"));


                    }

                    protected void editorcontentList()
                    {
                        this.Controls.Add(new LiteralControl("<div style=\" width :850px ;  display:inline-block   ; margin-right:10px ; margin-top:10px ;\">"));
                        this.Controls.Add(new LiteralControl("<ul class='tabs'>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab1'>تنظیمات</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab2'>محتوا</a></li>"));
                        /*this.Controls.Add(new LiteralControl(" 			<li><a href='#tab3'>Tab 3</a></li>"));*/
                        this.Controls.Add(new LiteralControl(" 		</ul>"));
                        this.Controls.Add(new LiteralControl("</div>"));

                        this.Controls.Add(new LiteralControl("<div style=\" border: 1px solid #dce7ed;width :850px ;  display:inline-block   ;background-color:#f5f9f9; margin-right:10px ;  padding-bottom:20px\">"));
                        this.Controls.Add(new LiteralControl("    <div dir=\"rtl\" style=\"text-align: right\">"));

                        this.Controls.Add(new LiteralControl("        <div id='tab1'>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("عنوان پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(TxtTitle(instanceID));
                        this.Controls.Add(new LiteralControl("               </div>"));
                        this.Controls.Add(new LiteralControl("           </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row2\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLwin(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("تعداد سطر"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(txtTop(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row4\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع محتوا"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DDLtype(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row5\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع نمایش لیست"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DDLlistMainType(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row5\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع نمایش لیست"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DDLsortMode(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row5\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش شرح برای لیست"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(ChkBoxdescVisible(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row6\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش تصویر برای لیست"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(ChkBoxlistMainImageVisible(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row7\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("اندازه تصویر لیست"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLMainImageSize(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row8\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش هدر"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(ChkBoxheaderVisible(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row9\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("کد محتوا هدر"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(txtBoxheaderContent(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row10\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش تصویر هدر"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(ChkBoxheaderImageVisible(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row11\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("اندازه تصویر هدر"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLHeaderImageSize(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));



                        this.Controls.Add(new LiteralControl("            <div id=\"row8\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش آیکون RSS"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(ChkBoxRssIconVisible(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

      


                    
                        this.Controls.Add(new LiteralControl(" 		</div>"));

                        this.Controls.Add(new LiteralControl(" 		<div id='tab2'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditor(instanceID));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("        </div>"));

                        this.Controls.Add(new LiteralControl("</div>"));
                        this.Controls.Add(new LiteralControl("</div>"));

                        /************************************************/                     

  

                       



                    }

                    protected void editorContentWin()
                    {
                       
                        this.Controls.Add(new LiteralControl("<div style=\" width :850px ;  display:inline-block   ; margin-right:10px ; margin-top:10px ;\">"));
                       this.Controls.Add(new LiteralControl("<ul class='tabs'>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab1'>تنظیمات</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab2'>محتوا</a></li>"));
                        /*this.Controls.Add(new LiteralControl(" 			<li><a href='#tab3'>Tab 3</a></li>"));*/
                        this.Controls.Add(new LiteralControl(" 		</ul>"));
                        this.Controls.Add(new LiteralControl("</div>"));

                        this.Controls.Add(new LiteralControl("<div style=\" border: 1px solid #dce7ed;width :850px ;  display:inline-block   ;background-color:#f5f9f9; margin-right:10px ;  padding-bottom:20px\">"));
                        this.Controls.Add(new LiteralControl("    <div dir=\"rtl\" style=\"text-align: right\">"));

                        this.Controls.Add(new LiteralControl("        <div id='tab1'>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("عنوان پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(TxtTitle(instanceID));
                        this.Controls.Add(new LiteralControl( "               </div>"));
                        this.Controls.Add(new LiteralControl( "           </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row2\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLwin(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl(" 		</div>"));

                        this.Controls.Add(new LiteralControl(" 		<div id='tab2'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditor(instanceID));          
                        
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("        </div>"));

                        this.Controls.Add(new LiteralControl("</div>"));
                        this.Controls.Add(new LiteralControl("</div>"));


                        
                        
                     
                    }

                    protected void editorEstateSearchWin()
                    {

                        this.Controls.Add(new LiteralControl("<div style=\" width :850px ;  display:inline-block   ; margin-right:10px ; margin-top:10px ;\">"));
                        this.Controls.Add(new LiteralControl("<ul class='tabs'>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab1'>تنظیمات</a></li>"));
                       // this.Controls.Add(new LiteralControl(" 			<li><a href='#tab2'>محتوا</a></li>"));
                        /*this.Controls.Add(new LiteralControl(" 			<li><a href='#tab3'>Tab 3</a></li>"));*/
                        this.Controls.Add(new LiteralControl(" 		</ul>"));
                        this.Controls.Add(new LiteralControl("</div>"));

                        this.Controls.Add(new LiteralControl("<div style=\" border: 1px solid #dce7ed;width :850px ;  display:inline-block   ;background-color:#f5f9f9; margin-right:10px ;  padding-bottom:20px\">"));
                        this.Controls.Add(new LiteralControl("    <div dir=\"rtl\" style=\"text-align: right\">"));

                        this.Controls.Add(new LiteralControl("        <div id='tab1'>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("چینش"));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DDLOrdering(instanceID));
                        this.Controls.Add(new LiteralControl("               </div>"));
                        this.Controls.Add(new LiteralControl("           </div>"));



                        this.Controls.Add(new LiteralControl(" 		</div>"));

                      /*  this.Controls.Add(new LiteralControl(" 		<div id='tab2'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditor(instanceID));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("        </div>"));*/

                        this.Controls.Add(new LiteralControl("</div>"));
                        this.Controls.Add(new LiteralControl("</div>"));





                    }




                    protected void editorSearchWin()
                    {
                       
                        this.Controls.Add(new LiteralControl("<div style=\" width :850px ;  display:inline-block   ; margin-right:10px ; margin-top:10px ;\">"));
                       this.Controls.Add(new LiteralControl("<ul class='tabs'>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab1'>تنظیمات</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab2'>محتوا</a></li>"));
                        /*this.Controls.Add(new LiteralControl(" 			<li><a href='#tab3'>Tab 3</a></li>"));*/
                        this.Controls.Add(new LiteralControl(" 		</ul>"));
                        this.Controls.Add(new LiteralControl("</div>"));

                        this.Controls.Add(new LiteralControl("<div style=\" border: 1px solid #dce7ed;width :850px ;  display:inline-block   ;background-color:#f5f9f9; margin-right:10px ;  padding-bottom:20px\">"));
                        this.Controls.Add(new LiteralControl("    <div dir=\"rtl\" style=\"text-align: right\">"));

                        this.Controls.Add(new LiteralControl("        <div id='tab1'>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("عنوان پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(TxtTitle(instanceID));
                        this.Controls.Add(new LiteralControl( "               </div>"));
                        this.Controls.Add(new LiteralControl( "           </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row2\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLwin(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row2\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع کادر جستجو"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLsearchBoxMode(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));



                        this.Controls.Add(new LiteralControl(" 		</div>"));

                        this.Controls.Add(new LiteralControl(" 		<div id='tab2'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditor(instanceID));          
                        
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("        </div>"));

                        this.Controls.Add(new LiteralControl("</div>"));
                        this.Controls.Add(new LiteralControl("</div>"));


                        
                        
                     
                    }

                    protected void editorSlider()
                    {

                        this.Controls.Add(new LiteralControl("<div style=\" width :850px ;  display:inline-block   ; margin-right:10px ; margin-top:10px ;\">"));
                        this.Controls.Add(new LiteralControl("<ul class='tabs'>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab1'>تنظیمات</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab2'>محتوا</a></li>"));                        
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab3'>اسلاید 1</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab4'>اسلاید 2</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab5'>اسلاید 3</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab6'>اسلاید 4</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab7'>اسلاید 5</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab8'>اسلاید 6</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab9'>اسلاید 7</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab10'>اسلاید 8</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab11'>اسلاید 9</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab12'>اسلاید 10</a></li>"));
                        


                        /*this.Controls.Add(new LiteralControl(" 			<li><a href='#tab3'>Tab 3</a></li>"));*/
                        this.Controls.Add(new LiteralControl(" 		</ul>"));
                        this.Controls.Add(new LiteralControl("</div>"));

                        this.Controls.Add(new LiteralControl("<div style=\" border: 1px solid #dce7ed;width :850px ;  display:inline-block   ;background-color:#f5f9f9; margin-right:10px ;  padding-bottom:20px\">"));
                        this.Controls.Add(new LiteralControl("    <div dir=\"rtl\" style=\"text-align: right\">"));

                        this.Controls.Add(new LiteralControl("        <div id='tab1'>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("عنوان پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(TxtTitle(instanceID));
                        this.Controls.Add(new LiteralControl("               </div>"));
                        this.Controls.Add(new LiteralControl("           </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row2\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLwin(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                     

                        this.Controls.Add(new LiteralControl(" 		</div>"));
                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab2'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditor(instanceID));

                        this.Controls.Add(new LiteralControl("           </div>"));
                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab3'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo1(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 1"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo1show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));
                 
                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab4'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo2(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 2"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo2show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab5'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo3(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 3"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo3show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab6'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo4(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 4"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo4show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab7'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo5(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 5"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo5show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab8'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo6(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 6"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo6show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab9'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo7(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 7"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo7show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab10'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo8(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 8"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo8show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab11'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo9(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 9"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo9show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                        this.Controls.Add(new LiteralControl(" 		<div id='tab12'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditorMemo10(instanceID));
                        this.Controls.Add(new LiteralControl("<br/>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نمایش اسلاید 10"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_chkBoxMemo10show(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("       </div>"));

                        /************************************/
                    


                        this.Controls.Add(new LiteralControl("</div>"));
                        this.Controls.Add(new LiteralControl("</div>"));







                    }


                 



                    protected void editortabList()
                    {

                        this.Controls.Add(new LiteralControl("<div style=\" width :850px ;  display:inline-block   ; margin-right:10px ; margin-top:10px ;\">"));
                        this.Controls.Add(new LiteralControl("<ul class='tabs'>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab1'>تنظیمات</a></li>"));
                        this.Controls.Add(new LiteralControl(" 			<li><a href='#tab2'>محتوا</a></li>"));
                        /*this.Controls.Add(new LiteralControl(" 			<li><a href='#tab3'>Tab 3</a></li>"));*/
                        this.Controls.Add(new LiteralControl(" 		</ul>"));
                        this.Controls.Add(new LiteralControl("</div>"));

                        this.Controls.Add(new LiteralControl("<div style=\" border: 1px solid #dce7ed;width :850px ;  display:inline-block   ;background-color:#f5f9f9; margin-right:10px ;  padding-bottom:20px\">"));
                        this.Controls.Add(new LiteralControl("    <div dir=\"rtl\" style=\"text-align: right\">"));

                        this.Controls.Add(new LiteralControl("        <div id='tab1'>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("عنوان پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));

                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(TxtTitle(instanceID));
                        this.Controls.Add(new LiteralControl("               </div>"));
                        this.Controls.Add(new LiteralControl("           </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row2\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("نوع پنجره"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(DLLwin(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));


                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 1"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector1(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 2"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector2(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 3"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector3(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 4"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector4(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 5"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector5(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 6"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector6(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 7"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector7(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 8"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector8(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 9"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector9(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("            <div id=\"row3\" style=\"margin-top: 10px; width: 100%; display: inline-block\">"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 120px; text-align: left; padding-left: 5px\">"));
                        this.Controls.Add(new LiteralControl("شی زبانه 10"));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("                <div style=\"float: right; width: 200px; text-align: right;\">"));
                        this.Controls.Add(_DLLObjectSelector10(instanceID));
                        this.Controls.Add(new LiteralControl("                </div>"));
                        this.Controls.Add(new LiteralControl("            </div>"));

                        

                        

                        this.Controls.Add(new LiteralControl(" 		</div>"));

                        this.Controls.Add(new LiteralControl(" 		<div id='tab2'>"));

                        this.Controls.Add(new LiteralControl("            <div  dir=\"rtl\">"));

                        this.Controls.Add(_CKEditor(instanceID));

                        this.Controls.Add(new LiteralControl("            </div>"));

                        this.Controls.Add(new LiteralControl("        </div>"));

                        this.Controls.Add(new LiteralControl("</div>"));
                        this.Controls.Add(new LiteralControl("</div>"));



                       

      

                    }

                    public Control tabList_tab_contentWin_Template()
                    {
                        PlaceHolder ph = new PlaceHolder();

                        string htm1 = "";

                        htm1 = " <div id=\"aaa\">" + khatam.core.data.sql.InstanceValGet(instanceID, "memo") + "</div>";


                        hta.ID = "aaa";
                        hta.InnerHtml = khatam.core.data.sql.InstanceValGet(instanceID, "memo");

                        ph.Controls.Add(hta);

                        // this.Controls.Add(new LiteralControl(htm1));


                        string html2 =

                        "<script type=\"text/javascript\">" +
                        " CKEDITOR.replace( '" + hta.ClientID + "',"
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



                        ph.Controls.Add(new LiteralControl(html2));


                        ph.Controls.Add(new LiteralControl("</br>"));

                        ph.Controls.Add(new LiteralControl("فرم ویرایش"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));

                        ph.Controls.Add(new LiteralControl("<strong>عنوان پنجره</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(TxtTitle(instanceID));

                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("<strong>نوع پنجره</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(DLLwin(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));

                        return ph;
                    }

                    public Control tabList_tab_contenList_Template()
                    {
                        PlaceHolder ph = new PlaceHolder();

                        ph.Controls.Add(new LiteralControl("<strong>تعداد سطر</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(txtTop(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));


                        ph.Controls.Add(new LiteralControl("<strong>نوع محتوا</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(DDLtype(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));


                        ph.Controls.Add(new LiteralControl("<strong>نوع نمایش لیست</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(DDLlistMainType(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));

                        ph.Controls.Add(new LiteralControl("<strong>نمایش تصویر برای لیست</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(ChkBoxlistMainImageVisible(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));

                        ph.Controls.Add(new LiteralControl("<strong>اندازه تصویر لیست</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(DLLMainImageSize(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));


                        ph.Controls.Add(new LiteralControl("<strong>نمایش هدر</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(ChkBoxheaderVisible(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));


                        ph.Controls.Add(new LiteralControl("<strong>کد محتوا هدر</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(txtBoxheaderContent(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));

                        ph.Controls.Add(new LiteralControl("<strong>نمایش تصویر هدر</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(ChkBoxheaderImageVisible(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));

                        ph.Controls.Add(new LiteralControl("<strong>اندازه تصویر هدر</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(DLLHeaderImageSize(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));


                        ListItem DDLlistMainTypeli2 = new ListItem();
                        DDLlistMainTypeli2.Text = "کادرهای کنار هم";
                        DDLlistMainTypeli2.Value = "2";



                        ph.Controls.Add(new LiteralControl("<strong>نمایش آیکون RSS</strong>"));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(ChkBoxRssIconVisible(instanceID));
                        ph.Controls.Add(new LiteralControl("</br>"));
                        ph.Controls.Add(new LiteralControl("</br>"));


                        Button btnnew = new Button();
                        btnnew.ID = "Button1";
                        btnnew.Text = "بروز رسانی";
                        btnnew.Font.Name = "tahoma";
                        //btnnew.OnClientClick = "test" + instanceID + "()";

                        // btnnew.OnClientClick = "testAAA();refreshParent();";
                        //btnnew.OnClientClick = "testAAA();opener.location.reload();window . close ();";
                        btnnew.OnClientClick = "testAAA();";
                        btnnew.Click += new EventHandler(btnAddSave_Click);




                        ph.Controls.Add(btnnew);







                        ph.Controls.Add(ih);

                        ph.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function testAAA(){  document.getElementById('" + ih.ClientID + "').value = CKEDITOR.instances." + hta.ClientID + ".getData()  ;  }</script>"));
                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() { window.opener.location.href = window.opener.location.href; if (window.opener.progressWindow) {     window.opener.progressWindow.close()   }         window.close();          }  //--> </script>"));
                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() {window.document.form1.ButtonRedirect.click();  window.opener.document.form1.ButtonRedirect.click();            }  //--> </script>"));
                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() { window.document.form1.ButtonRedirect.click();window.opener.location.href = window.opener.location.href;          }  //--> </script>"));
                        // this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() { window.opener.location.href = window.opener.location.href;          }  //--> </script>"));

                        // window.close();

                        //   ph.Controls.Add(new LiteralControl("</div>"));



                        return ph;

                    }

                    protected void editordomainSearchWin()
                    {


                        this.Parent.Page.Title = "فرم ویرایش شی شماره " + instanceID;

                        //border begin

                        this.Controls.Add(new LiteralControl("<div  dir=\"rtl\">"));


                        string htm1 = "";

                        htm1 = " <div id=\"aaa\">" + khatam.core.data.sql.InstanceValGet(instanceID, "memo") + "</div>";


                        hta.ID = "aaa";
                        hta.InnerHtml = khatam.core.data.sql.InstanceValGet(instanceID, "memo");

                        this.Controls.Add(hta);

                        // this.Controls.Add(new LiteralControl(htm1));


                        string html2 =

                        "<script type=\"text/javascript\">" +
                        " CKEDITOR.replace( '" + hta.ClientID + "',"
                            // " CKEDITOR.replace( '" + tb.ClientID + "',"
                        + " {	filebrowserBrowseUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html'"
                            //+ " 	filebrowserImageBrowseUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/ckfinder.html?type=Images',"
                            //+ " 	filebrowserFlashBrowseUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/ckfinder.html?type=Flash',"
                            //+ " 	filebrowserUploadUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files',"
                            //+ " 	filebrowserImageUploadUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images',"
                            //+ " 	filebrowserFlashUploadUrl : '" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash'"
                        + " }); " + "</script> ";
                        //+ " }); CKFinder.setupCKEditor( '" + tb.ClientID + "', '~/manage/' ); " + "</script>"; 
                        //+ " });   CKFinder.SetupCKEditor( var editor , '/manage/upload/', rememberLastFolder : false  ); " + "</script>"; 



                        this.Controls.Add(new LiteralControl(html2));


                        this.Controls.Add(new LiteralControl("</br>"));

                        this.Controls.Add(new LiteralControl("فرم ویرایش"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("</br>"));

                        this.Controls.Add(new LiteralControl("<strong>عنوان پنجره</strong>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(TxtTitle(instanceID));

                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("<strong>نوع پنجره</strong>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(DLLwin(instanceID));

                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("<strong>نمایش جدول قیمت</strong>"));
                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(chkDomainPriceTable(instanceID));

                        this.Controls.Add(new LiteralControl("</br>"));
                        this.Controls.Add(new LiteralControl("</br>"));


                        Button btnnew = new Button();
                        btnnew.ID = "Button1";
                        btnnew.Text = "بروز رسانی";
                        btnnew.Font.Name = "tahoma";
                        //btnnew.OnClientClick = "test" + instanceID + "()";

                        // btnnew.OnClientClick = "testAAA();refreshParent();";
                        //btnnew.OnClientClick = "testAAA();opener.location.reload();window . close ();";
                        btnnew.OnClientClick = "testAAA();";
                        btnnew.Click += new EventHandler(btnAddSave_Click);




                        this.Controls.Add(btnnew);







                        this.Controls.Add(ih);

                        this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function testAAA(){  document.getElementById('" + ih.ClientID + "').value = CKEDITOR.instances." + hta.ClientID + ".getData()  ;  }</script>"));
                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() { window.opener.location.href = window.opener.location.href; if (window.opener.progressWindow) {     window.opener.progressWindow.close()   }         window.close();          }  //--> </script>"));
                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() {window.document.form1.ButtonRedirect.click();  window.opener.document.form1.ButtonRedirect.click();            }  //--> </script>"));
                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() { window.document.form1.ButtonRedirect.click();window.opener.location.href = window.opener.location.href;          }  //--> </script>"));
                        // this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function refreshParent() { window.opener.location.href = window.opener.location.href;          }  //--> </script>"));

                        // window.close();

                        this.Controls.Add(new LiteralControl("</div>"));


                        //if (Page.IsPostBack == true)
                        //{
                        // this.Controls.AddAt(this.Controls.Count -1 ,new LiteralControl("<script type=\"text/javascript\"> window.close();</script>"));

                        //this.Page.
                        //}


                    }


                    protected void btnAddSave_Click(object sender, EventArgs e)
                    {
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo", CKEditor.Text );
                        khatam.core.data.sql.InstanceValSet(instanceID, "windowsMode", DDLwin.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "title", tb_Title.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "skin", DDLskinO.SelectedValue);
                        //khatam.core.data.sql.InstanceValSet(instanceID, "skin", "sss");
                        khatam.core.data.sql.InstanceValSet(instanceID, "width", tb_width.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "contentTable", DDLtypeO.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "top", tb_top.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "listMainType", DDLlistMainTypeO.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "listMainImageVisible", ChkBoxlistMainImageVisibleO.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "listMainImageSize", DLLMainImageSizeO.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "headerVisible", ChkBoxheaderVisibleO.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "headerContent", txtBoxheaderContentO.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "headerContent", txtBoxheaderContentO.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "headerImageVisible", ChkBoxheaderImageVisibleO.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "headerImageSize", DLLHeaderImageSizeO.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "showPriceTable", chkBoxShowPriceTable.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "rssIconVisible", ChkBoxRssIconVisibleO.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "descVisible", ChkBoxdescVisibleO.Checked.ToString());

                        khatam.core.data.sql.InstanceValSet(instanceID, "memo1", CKEditorMemo1.Text );
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo2", CKEditorMemo2.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo3", CKEditorMemo3.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo4", CKEditorMemo4.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo5", CKEditorMemo5.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo6", CKEditorMemo6.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo7", CKEditorMemo7.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo8", CKEditorMemo8.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo9", CKEditorMemo9.Text);
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo10", CKEditorMemo10.Text);


                        khatam.core.data.sql.InstanceValSet(instanceID, "memo1show", chkBoxMemo1show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo2show", chkBoxMemo2show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo3show", chkBoxMemo3show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo4show", chkBoxMemo4show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo5show", chkBoxMemo5show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo6show", chkBoxMemo6show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo7show", chkBoxMemo7show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo8show", chkBoxMemo8show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo9show", chkBoxMemo9show.Checked.ToString());
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo10show", chkBoxMemo10show.Checked.ToString());


                        khatam.core.data.sql.InstanceValSet(instanceID, "tab1InstanceID", DLLObjectSelector1.SelectedValue );
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab2InstanceID", DLLObjectSelector2.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab3InstanceID", DLLObjectSelector3.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab4InstanceID", DLLObjectSelector4.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab5InstanceID", DLLObjectSelector5.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab6InstanceID", DLLObjectSelector6.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab7InstanceID", DLLObjectSelector7.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab8InstanceID", DLLObjectSelector8.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab9InstanceID", DLLObjectSelector9.SelectedValue);
                        khatam.core.data.sql.InstanceValSet(instanceID, "tab10InstanceID", DLLObjectSelector10.SelectedValue);

                        khatam.core.data.sql.InstanceValSet(instanceID, "searchBoxMode", DDLsearchBoxMode.SelectedValue);

                        khatam.core.data.sql.InstanceValSet(instanceID, "sortMode",_DDLsortMode.SelectedValue );

                        khatam.core.data.sql.InstanceValSet(instanceID, "ordering", DDLOrderingO.SelectedValue);


            

                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">  alert(\"sss\");btnnew.OnClientClick = "testAAA();opener.location.reload();window . close ();";</script>"));
                       this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">  opener.location.reload();window . close ();</script>"));

                        //this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">function testAAA(){  document.getElementById('" + ih.ClientID + "').value = CKEDITOR.instances.aaa.getData()  ;  }</script>"));
                     //   this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">  opener.location.reload();</script>"));

                     //   this.Controls.Add(new LiteralControl("<script type=\"text/javascript\">  opener.location.reload();</script>"));
                        //RedirectTo(this.Page.Request.Url.OriginalString);

                    }


                    private void RedirectTo(string url)
                    {
                        //url is in pattern "~myblog/mypage.aspx"
                        string redirectURL = Page.ResolveClientUrl(url);
                        string script = "window.location = '" + redirectURL + "';";
                        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
                    }


                    protected void btnSave_Click(object sender, EventArgs e)
                    {


                        //  btnSave.Text = ih.Value   ;
                        khatam.core.data.sql.InstanceValSet(instanceID, "memo", ih.Value);


                    }



                    private void CloseDialog(string dialogId)
                    {
                        string script = string.Format(@"closeDialog('{0}')", dialogId);
                        ///ScriptManager.RegisterClientScriptBlock(this, typeof(Page), UniqueID, script, true);
                    }


                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }


                    public CKEditor.NET.CKEditorControl CKEditor = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditor(string instanceID)
                    {
                        CKEditor.Height = Unit.Pixel(200);
                        CKEditor.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditor.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditor.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditor.Text =  khatam.core.data.sql.InstanceValGet(instanceID, "memo");

                        return CKEditor;
                    }

                    public CheckBox chkBoxMemo1show = new  CheckBox();

                    public CheckBox _chkBoxMemo1show(string instanceID)
                    {
                        chkBoxMemo1show.Checked  =bool.Parse( khatam.core.data.sql.InstanceValGet(instanceID, "memo1show"));
                        return chkBoxMemo1show;
                    }

                    public CheckBox chkBoxMemo2show = new CheckBox();

                    public CheckBox _chkBoxMemo2show(string instanceID)
                    {
                        chkBoxMemo2show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo2show"));
                        return chkBoxMemo2show;
                    }

                    public CheckBox chkBoxMemo3show = new CheckBox();

                    public CheckBox _chkBoxMemo3show(string instanceID)
                    {
                        chkBoxMemo3show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo3show"));
                        return chkBoxMemo3show;
                    }

                    public CheckBox chkBoxMemo4show = new CheckBox();

                    public CheckBox _chkBoxMemo4show(string instanceID)
                    {
                        chkBoxMemo4show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo4show"));
                        return chkBoxMemo4show;
                    }

                    public CheckBox chkBoxMemo5show = new CheckBox();

                    public CheckBox _chkBoxMemo5show(string instanceID)
                    {
                        chkBoxMemo5show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo5show"));
                        return chkBoxMemo5show;
                    }

                    public CheckBox chkBoxMemo6show = new CheckBox();

                    public CheckBox _chkBoxMemo6show(string instanceID)
                    {
                        chkBoxMemo6show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo6show"));
                        return chkBoxMemo6show;
                    }

                    public CheckBox chkBoxMemo7show = new CheckBox();

                    public CheckBox _chkBoxMemo7show(string instanceID)
                    {
                        chkBoxMemo7show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo7show"));
                        return chkBoxMemo7show;
                    }

                    public CheckBox chkBoxMemo8show = new CheckBox();

                    public CheckBox _chkBoxMemo8show(string instanceID)
                    {
                        chkBoxMemo8show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo8show"));
                        return chkBoxMemo8show;
                    }

                    public CheckBox chkBoxMemo9show = new CheckBox();

                    public CheckBox _chkBoxMemo9show(string instanceID)
                    {
                        chkBoxMemo9show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo9show"));
                        return chkBoxMemo9show;
                    }

                    public CheckBox chkBoxMemo10show = new CheckBox();

                    public CheckBox _chkBoxMemo10show(string instanceID)
                    {
                        chkBoxMemo10show.Checked = bool.Parse(khatam.core.data.sql.InstanceValGet(instanceID, "memo10show"));
                        return chkBoxMemo10show;
                    }

                   

                    public CKEditor.NET.CKEditorControl CKEditorMemo1 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo1(string instanceID)
                    {
                        CKEditorMemo1.Height = Unit.Pixel(200);
                        CKEditorMemo1.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo1.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo1.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo1.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo1");

                        return CKEditorMemo1;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo2 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo2(string instanceID)
                    {
                        CKEditorMemo2.Height = Unit.Pixel(200);
                        CKEditorMemo2.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo2.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo2.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo2.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo2");

                        return CKEditorMemo2;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo3 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo3(string instanceID)
                    {
                        CKEditorMemo3.Height = Unit.Pixel(200);
                        CKEditorMemo3.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo3.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo3.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo3.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo3");

                        return CKEditorMemo3;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo4 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo4(string instanceID)
                    {
                        CKEditorMemo4.Height = Unit.Pixel(200);
                        CKEditorMemo4.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo4.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo4.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo4.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo4");
                    
                        return CKEditorMemo4;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo5 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo5(string instanceID)
                    {
                        CKEditorMemo5.Height = Unit.Pixel(200);
                        CKEditorMemo5.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo5.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo5.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo5.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo5");

                        return CKEditorMemo5;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo6 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo6(string instanceID)
                    {
                        CKEditorMemo6.Height = Unit.Pixel(200);
                        CKEditorMemo6.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo6.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo6.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo6.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo6");

                        return CKEditorMemo6;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo7 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo7(string instanceID)
                    {
                        CKEditorMemo7.Height = Unit.Pixel(200);
                        CKEditorMemo7.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo7.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo7.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo7.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo7");

                        return CKEditorMemo7;
                    }


                    public CKEditor.NET.CKEditorControl CKEditorMemo8 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo8(string instanceID)
                    {
                        CKEditorMemo8.Height = Unit.Pixel(200);
                        CKEditorMemo8.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo8.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo8.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo8.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo8");

                        return CKEditorMemo8;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo9 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo9(string instanceID)
                    {
                        CKEditorMemo9.Height = Unit.Pixel(200);
                        CKEditorMemo9.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo9.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo9.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo9.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo9");

                        return CKEditorMemo9;
                    }

                    public CKEditor.NET.CKEditorControl CKEditorMemo10 = new CKEditor.NET.CKEditorControl();

                    public CKEditor.NET.CKEditorControl _CKEditorMemo10(string instanceID)
                    {
                        CKEditorMemo10.Height = Unit.Pixel(200);
                        CKEditorMemo10.BasePath = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor";
                        CKEditorMemo10.FilebrowserBrowseUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckfinder/ckfinder.html";
                        CKEditorMemo10.TemplatesFiles = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "core/ckeditor/plugins/templates/templates/default.js";
                        CKEditorMemo10.Text = khatam.core.data.sql.InstanceValGet(instanceID, "memo10");

                        return CKEditorMemo10;
                    }

                 

                    public DropDownList DDLwin = new DropDownList();

                    public Control DLLwin(string instanceID)
                    {



                        DDLwin.ID = "DDLwin" + instanceID;
                        DDLwin.Text = title;
                        ListItem li0 = new ListItem();
                        li0.Text = "بدون پنجره";
                        li0.Value = "none";

                        ListItem li1 = new ListItem();
                        li1.Text = "مدل 1";
                        li1.Value = "win1";

                        ListItem li2 = new ListItem();
                        li2.Text = "مدل 2";
                        li2.Value = "win2";

                        ListItem li3 = new ListItem();
                        li3.Text = "مدل 3";
                        li3.Value = "win3";

                        ListItem li4 = new ListItem();
                        li4.Text = "مدل 4";
                        li4.Value = "win4";

                        ListItem li5 = new ListItem();
                        li5.Text = "مدل 5";
                        li5.Value = "win5";


                        DDLwin.Items.Add(li0);
                        DDLwin.Items.Add(li1);
                        DDLwin.Items.Add(li2);
                        DDLwin.Items.Add(li3);
                        DDLwin.Items.Add(li4);
                        DDLwin.Items.Add(li5);

                        DDLwin.Font.Name = "tahoma";

                        DDLwin.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "windowsMode");



                        return DDLwin;
                    }

                    public DropDownList DDLsearchBoxMode = new DropDownList();

                    public Control DLLsearchBoxMode(string instanceID)
                    {



                        DDLsearchBoxMode.ID = "DDLsearchBoxMode" + instanceID;
                        DDLsearchBoxMode.Text = title;
                        ListItem li0 = new ListItem();
                        li0.Text = "بعد از محتوا";
                        li0.Value = "1";

                        ListItem li1 = new ListItem();
                        li1.Text = "سمت چپ محتوا";
                        li1.Value = "2";

                        ListItem li2 = new ListItem();
                        li2.Text = "سمت راست محتوا";
                        li2.Value = "3";

                     /*   ListItem li3 = new ListItem();
                        li3.Text = "مدل 3";
                        li3.Value = "4";

                        ListItem li4 = new ListItem();
                        li4.Text = "مدل 4";
                        li4.Value = "5";

                        ListItem li5 = new ListItem();
                        li5.Text = "مدل 5";
                        li5.Value = "6";*/


                        DDLsearchBoxMode.Items.Add(li0);
                        DDLsearchBoxMode.Items.Add(li1);
                        DDLsearchBoxMode.Items.Add(li2);
                      //  DDLsearchBoxMode.Items.Add(li3);
                      //  DDLsearchBoxMode.Items.Add(li4);
                      //  DDLsearchBoxMode.Items.Add(li5);

                        DDLsearchBoxMode.Font.Name = "tahoma";

                        DDLsearchBoxMode.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "searchBoxMode");



                        return DDLsearchBoxMode;
                    }

                    public DropDownList DLLObjectSelector1 = new DropDownList();


                    public Control _DLLObjectSelector1(string instanceID)
                    {

                        DLLObjectSelector1.ID = "DLLObjectSelector_1_" + instanceID;
                        
                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector1.DataSource = dt;
                        DLLObjectSelector1.DataTextField = "title";
                        DLLObjectSelector1.DataValueField = "id";
                        DLLObjectSelector1.Font.Name = "tahoma";
                        DLLObjectSelector1.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector1.Items.Insert(0, li0);
                        
                        DLLObjectSelector1.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab1InstanceID");



                        return DLLObjectSelector1;
                    }

                    public DropDownList DLLObjectSelector2 = new DropDownList();


                    public Control _DLLObjectSelector2(string instanceID)
                    {

                        DLLObjectSelector2.ID = "DLLObjectSelector_2_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector2.DataSource = dt;
                        DLLObjectSelector2.DataTextField = "title";
                        DLLObjectSelector2.DataValueField = "id";
                        DLLObjectSelector2.Font.Name = "tahoma";
                        DLLObjectSelector2.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector2.Items.Insert(0, li0);

                        DLLObjectSelector2.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab2InstanceID");



                        return DLLObjectSelector2;
                    }

                    public DropDownList DLLObjectSelector3 = new DropDownList();


                    public Control _DLLObjectSelector3(string instanceID)
                    {

                        DLLObjectSelector3.ID = "DLLObjectSelector_3_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector3.DataSource = dt;
                        DLLObjectSelector3.DataTextField = "title";
                        DLLObjectSelector3.DataValueField = "id";
                        DLLObjectSelector3.Font.Name = "tahoma";
                        DLLObjectSelector3.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector3.Items.Insert(0, li0);

                        DLLObjectSelector3.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab3InstanceID");



                        return DLLObjectSelector3;
                    }

                    public DropDownList DLLObjectSelector4 = new DropDownList();


                    public Control _DLLObjectSelector4(string instanceID)
                    {

                        DLLObjectSelector4.ID = "DLLObjectSelector_4_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector4.DataSource = dt;
                        DLLObjectSelector4.DataTextField = "title";
                        DLLObjectSelector4.DataValueField = "id";
                        DLLObjectSelector4.Font.Name = "tahoma";
                        DLLObjectSelector4.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector4.Items.Insert(0, li0);

                        DLLObjectSelector4.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab4InstanceID");



                        return DLLObjectSelector4;
                    }

                    public DropDownList DLLObjectSelector5 = new DropDownList();


                    public Control _DLLObjectSelector5(string instanceID)
                    {

                        DLLObjectSelector5.ID = "DLLObjectSelector_5_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector5.DataSource = dt;
                        DLLObjectSelector5.DataTextField = "title";
                        DLLObjectSelector5.DataValueField = "id";
                        DLLObjectSelector5.Font.Name = "tahoma";
                        DLLObjectSelector5.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector5.Items.Insert(0, li0);

                        DLLObjectSelector5.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab5InstanceID");



                        return DLLObjectSelector5;
                    }

                    public DropDownList DLLObjectSelector6 = new DropDownList();


                    public Control _DLLObjectSelector6(string instanceID)
                    {

                        DLLObjectSelector6.ID = "DLLObjectSelector_6_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector6.DataSource = dt;
                        DLLObjectSelector6.DataTextField = "title";
                        DLLObjectSelector6.DataValueField = "id";
                        DLLObjectSelector6.Font.Name = "tahoma";
                        DLLObjectSelector6.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector6.Items.Insert(0, li0);

                        DLLObjectSelector6.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab6InstanceID");



                        return DLLObjectSelector6;
                    }

                    public DropDownList DLLObjectSelector7 = new DropDownList();


                    public Control _DLLObjectSelector7(string instanceID)
                    {

                        DLLObjectSelector7.ID = "DLLObjectSelector_7_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector7.DataSource = dt;
                        DLLObjectSelector7.DataTextField = "title";
                        DLLObjectSelector7.DataValueField = "id";
                        DLLObjectSelector7.Font.Name = "tahoma";
                        DLLObjectSelector7.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector7.Items.Insert(0, li0);

                        DLLObjectSelector7.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab7InstanceID");



                        return DLLObjectSelector7;
                    }

                    public DropDownList DLLObjectSelector8 = new DropDownList();


                    public Control _DLLObjectSelector8(string instanceID)
                    {

                        DLLObjectSelector8.ID = "DLLObjectSelector_8_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector8.DataSource = dt;
                        DLLObjectSelector8.DataTextField = "title";
                        DLLObjectSelector8.DataValueField = "id";
                        DLLObjectSelector8.Font.Name = "tahoma";
                        DLLObjectSelector8.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector8.Items.Insert(0, li0);

                        DLLObjectSelector8.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab8InstanceID");



                        return DLLObjectSelector8;
                    }

                    public DropDownList DLLObjectSelector9 = new DropDownList();


                    public Control _DLLObjectSelector9(string instanceID)
                    {

                        DLLObjectSelector9.ID = "DLLObjectSelector_9_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector9.DataSource = dt;
                        DLLObjectSelector9.DataTextField = "title";
                        DLLObjectSelector9.DataValueField = "id";
                        DLLObjectSelector9.Font.Name = "tahoma";
                        DLLObjectSelector9.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector9.Items.Insert(0, li0);

                        DLLObjectSelector9.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab9InstanceID");



                        return DLLObjectSelector9;
                    }

                    public DropDownList DLLObjectSelector10 = new DropDownList();


                    public Control _DLLObjectSelector10(string instanceID)
                    {

                        DLLObjectSelector10.ID = "DLLObjectSelector_10_" + instanceID;

                        DataTable dt = new DataTable();
                        dt = getObjectForTab();

                        DLLObjectSelector10.DataSource = dt;
                        DLLObjectSelector10.DataTextField = "title";
                        DLLObjectSelector10.DataValueField = "id";
                        DLLObjectSelector10.Font.Name = "tahoma";
                        DLLObjectSelector10.DataBind();

                        ListItem li0 = new ListItem();
                        li0.Text = "بدون شی";
                        li0.Value = "0";
                        DLLObjectSelector10.Items.Insert(0, li0);

                        DLLObjectSelector10.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "tab10InstanceID");



                        return DLLObjectSelector10;
                    }

                 
                    public static DataTable getObjectForTab()
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        //parameters.Add("field_where_value", field_where_value);
                        str_sql = "SELECT    id, id_core_serverControl, title FROM         Core_serverControlsInstance WHERE     (id_core_serverControl <> 26)"; 
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                    }

                    public CheckBox chkBoxShowPriceTable = new CheckBox();


                    public CheckBox chkDomainPriceTable(string instanceID)
                    {


                        chkBoxShowPriceTable.ID = "chkBoxShowPriceTable" + instanceID;



                        chkBoxShowPriceTable.Font.Name = "tahoma";

                        chkBoxShowPriceTable.Checked = Convert.ToBoolean(khatam.core.data.sql.InstanceValGet(instanceID, "showPriceTable"));


                        return chkBoxShowPriceTable;
                    }




                    public DropDownList _DDLsortMode = new DropDownList();

                    public Control DDLsortMode(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        _DDLsortMode.ID = "DDLsortMode" + instanceID;

                        ListItem DDLsortModeTypeli1 = new ListItem();
                        DDLsortModeTypeli1.Text = "آخرین ها بر اساس زمان درج";
                        DDLsortModeTypeli1.Value = "1";

                        ListItem DDLsortModeTypeli2 = new ListItem();
                        DDLsortModeTypeli2.Text = "آخرین ها بر اساس زمان بروز رسانی";
                        DDLsortModeTypeli2.Value = "2";

                        ListItem DDLsortModeTypeli3 = new ListItem();
                        DDLsortModeTypeli3.Text = "مهمترین ها بر اساس زمان درج";
                        DDLsortModeTypeli3.Value = "3";

                        ListItem DDLsortModeTypeli4 = new ListItem();
                        DDLsortModeTypeli4.Text = "مهمترین ها بر اساس زمان بروز رسانی";
                        DDLsortModeTypeli4.Value = "4";

                        ListItem DDLsortModeTypeli5 = new ListItem();
                        DDLsortModeTypeli5.Text = "بر اساس تعداد نظر کاربران";
                        DDLsortModeTypeli5.Value = "5";

                        ListItem DDLsortModeTypeli6 = new ListItem();
                        DDLsortModeTypeli6.Text = "بر اساس بیشترین بازدید";
                        DDLsortModeTypeli6.Value = "6";

                        _DDLsortMode.Items.Add(DDLsortModeTypeli1);
                        _DDLsortMode.Items.Add(DDLsortModeTypeli2);
                        _DDLsortMode.Items.Add(DDLsortModeTypeli3);
                        _DDLsortMode.Items.Add(DDLsortModeTypeli4);
                        _DDLsortMode.Items.Add(DDLsortModeTypeli5);
                        _DDLsortMode.Items.Add(DDLsortModeTypeli6);


                        _DDLsortMode.Font.Name = "tahoma";

                        _DDLsortMode.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "sortMode");

                        return _DDLsortMode;
                    }

                    public DropDownList DDLlistMainTypeO = new DropDownList();

                    public Control DDLlistMainType(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        DDLlistMainTypeO.ID = "DDLlistMainType" + instanceID;

                        ListItem DDLlistMainTypeli1 = new ListItem();
                        DDLlistMainTypeli1.Text = "فهرست عمودی";
                        DDLlistMainTypeli1.Value = "1";

                        ListItem DDLlistMainTypeli2 = new ListItem();
                        DDLlistMainTypeli2.Text = "کادرهای کنار هم";
                        DDLlistMainTypeli2.Value = "2";

                        ListItem DDLlistMainTypeli3 = new ListItem();
                        DDLlistMainTypeli3.Text = "کادر های افقی متحرک";
                        DDLlistMainTypeli3.Value = "3";

                        ListItem DDLlistMainTypeli4 = new ListItem();
                        DDLlistMainTypeli4.Text = "کادر های افقی متحرک + دکمه های بعدی - قبلی";
                        DDLlistMainTypeli4.Value = "4";

                        ListItem DDLlistMainTypeli5 = new ListItem();
                        DDLlistMainTypeli5.Text = "اسلاید";
                        DDLlistMainTypeli5.Value = "5";

                        ListItem DDLlistMainTypeli6 = new ListItem();
                        DDLlistMainTypeli6.Text = "متن متحرک";
                        DDLlistMainTypeli6.Value = "6";

                        DDLlistMainTypeO.Items.Add(DDLlistMainTypeli1);
                        DDLlistMainTypeO.Items.Add(DDLlistMainTypeli2);
                        DDLlistMainTypeO.Items.Add(DDLlistMainTypeli3);
                        DDLlistMainTypeO.Items.Add(DDLlistMainTypeli4);
                        //DDLlistMainTypeO.Items.Add(DDLlistMainTypeli5);
                        //DDLlistMainTypeO.Items.Add(DDLlistMainTypeli6);


                        DDLlistMainTypeO.Font.Name = "tahoma";

                        DDLlistMainTypeO.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "listMainType");

                        return DDLlistMainTypeO;
                    }


                    public DropDownList DDLOrderingO = new DropDownList();

                    public Control DDLOrdering(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        DDLOrderingO.ID = "DDLOrdering" + instanceID;

                        ListItem DDLOrderingOli1 = new ListItem();
                        DDLOrderingOli1.Text = "افقی";
                        DDLOrderingOli1.Value = "1";

                        ListItem DDLOrderingOli2 = new ListItem();
                        DDLOrderingOli2.Text = "عمودی";
                        DDLOrderingOli2.Value = "2";



                        DDLOrderingO.Items.Add(DDLOrderingOli1);
                        DDLOrderingO.Items.Add(DDLOrderingOli2);


                        DDLOrderingO.Font.Name = "tahoma";

                        DDLOrderingO.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "ordering");

                        return DDLOrderingO;
                    }




                    public CheckBox ChkBoxlistMainImageVisibleO = new CheckBox();

                    public Control ChkBoxlistMainImageVisible(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        ChkBoxlistMainImageVisibleO.ID = "ChkBoxlistMainImageVisible" + instanceID;



                        ChkBoxlistMainImageVisibleO.Font.Name = "tahoma";

                        ChkBoxlistMainImageVisibleO.Checked = Convert.ToBoolean(khatam.core.data.sql.InstanceValGet(instanceID, "listMainImageVisible"));

                        return ChkBoxlistMainImageVisibleO;
                    }

                    public CheckBox ChkBoxdescVisibleO = new CheckBox();

                    public Control ChkBoxdescVisible(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        ChkBoxdescVisibleO.ID = "ChkBoxdescVisible" + instanceID;



                        ChkBoxdescVisibleO.Font.Name = "tahoma";

                        ChkBoxdescVisibleO.Checked = Convert.ToBoolean(khatam.core.data.sql.InstanceValGet(instanceID, "descVisible"));

                        return ChkBoxdescVisibleO;
                    }


                    public DropDownList DLLMainImageSizeO = new DropDownList();

                    public Control DLLMainImageSize(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        DLLMainImageSizeO.ID = "DLLMainImageSize" + instanceID;

                        ListItem DLLMainImageSizeOli1 = new ListItem();
                        DLLMainImageSizeOli1.Text = "1";
                        DLLMainImageSizeOli1.Value = "1";

                        ListItem DLLMainImageSizeOli2 = new ListItem();
                        DLLMainImageSizeOli2.Text = "2";
                        DLLMainImageSizeOli2.Value = "2";

                        ListItem DLLMainImageSizeOli3 = new ListItem();
                        DLLMainImageSizeOli3.Text = "3";
                        DLLMainImageSizeOli3.Value = "3";

                        ListItem DLLMainImageSizeOli4 = new ListItem();
                        DLLMainImageSizeOli4.Text = "4";
                        DLLMainImageSizeOli4.Value = "4";

                        ListItem DLLMainImageSizeOli5 = new ListItem();
                        DLLMainImageSizeOli5.Text = "5";
                        DLLMainImageSizeOli5.Value = "5";

                        ListItem DLLMainImageSizeOli6 = new ListItem();
                        DLLMainImageSizeOli6.Text = "6";
                        DLLMainImageSizeOli6.Value = "6";

                        ListItem DLLMainImageSizeOli7 = new ListItem();
                        DLLMainImageSizeOli7.Text = "7";
                        DLLMainImageSizeOli7.Value = "7";

                        ListItem DLLMainImageSizeOli8 = new ListItem();
                        DLLMainImageSizeOli8.Text = "8";
                        DLLMainImageSizeOli8.Value = "8";


                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli1);
                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli2);
                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli3);
                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli4);
                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli5);
                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli6);
                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli7);
                        DLLMainImageSizeO.Items.Add(DLLMainImageSizeOli8);

                        DLLMainImageSizeO.Font.Name = "tahoma";

                        DLLMainImageSizeO.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "listMainImageSize");

                        return DLLMainImageSizeO;
                    }

                    public CheckBox ChkBoxheaderVisibleO = new CheckBox();

                    public Control ChkBoxheaderVisible(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        ChkBoxheaderVisibleO.ID = "ChkBoxheaderVisible" + instanceID;



                        ChkBoxheaderVisibleO.Font.Name = "tahoma";

                        ChkBoxheaderVisibleO.Checked = Convert.ToBoolean(khatam.core.data.sql.InstanceValGet(instanceID, "headerVisible"));

                        return ChkBoxheaderVisibleO;
                    }

                    public CheckBox ChkBoxheaderImageVisibleO = new CheckBox();

                    public Control ChkBoxheaderImageVisible(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        ChkBoxheaderImageVisibleO.ID = "ChkBoxheaderImageVisible" + instanceID;



                        ChkBoxheaderImageVisibleO.Font.Name = "tahoma";

                        ChkBoxheaderImageVisibleO.Checked = Convert.ToBoolean(khatam.core.data.sql.InstanceValGet(instanceID, "headerImageVisible"));

                        return ChkBoxheaderImageVisibleO;
                    }

                    public CheckBox ChkBoxRssIconVisibleO = new CheckBox();

                    public Control ChkBoxRssIconVisible(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        ChkBoxRssIconVisibleO.ID = "ChkBoxRssIconVisible" + instanceID;



                        ChkBoxRssIconVisibleO.Font.Name = "tahoma";

                        ChkBoxRssIconVisibleO.Checked = Convert.ToBoolean(khatam.core.data.sql.InstanceValGet(instanceID, "rssIconVisible"));

                        return ChkBoxRssIconVisibleO;
                    }



                    public DropDownList DDLtypeO = new DropDownList();

                    public Control DDLtype(string instanceID)
                    {



                        DDLtypeO.ID = "DDLtype" + instanceID;
                        DDLtypeO.Text = title;


                        ListItem tli1 = new ListItem();
                        tli1.Text = "مقاله";
                        tli1.Value = "article";
                        if (khatam.core.License.ValidModule("article") == true) DDLtypeO.Items.Add(tli1);


                        ListItem tli2 = new ListItem();
                        tli2.Text = "صفحه سفارشی";
                        tli2.Value = "special_pages";
                        DDLtypeO.Items.Add(tli2);

                        ListItem tli3 = new ListItem();
                        tli3.Text = "خدمات";
                        tli3.Value = "service";
                        if (khatam.core.License.ValidModule("service") == true) DDLtypeO.Items.Add(tli3);


                        ListItem tli4 = new ListItem();
                        tli4.Text = "پروژه های تحقیقاتی";
                        tli4.Value = "research_project";
                        if (khatam.core.License.ValidModule("research_project") == true) DDLtypeO.Items.Add(tli4);


                        ListItem tli5 = new ListItem();
                        tli5.Text = "متون راهنما";
                        tli5.Value = "help";
                        if (khatam.core.License.ValidModule("help") == true) DDLtypeO.Items.Add(tli5);


                        ListItem tli6 = new ListItem();
                        tli6.Text = "نمونه سوال";
                        tli6.Value = "sample_exam";
                        if (khatam.core.License.ValidModule("sample_exam") == true) DDLtypeO.Items.Add(tli6);

                        ListItem tli7 = new ListItem();
                        tli7.Text = "پرتال";
                        tli7.Value = "portal";
                        if (khatam.core.License.ValidModule("portal") == true) DDLtypeO.Items.Add(tli7);



                        ListItem tli8 = new ListItem();
                        tli8.Text = "خودرو";
                        tli8.Value = "car";
                        if (khatam.core.License.ValidModule("car") == true) DDLtypeO.Items.Add(tli8);


                        ListItem tli9 = new ListItem();
                        tli9.Text = "تصاویر";
                        tli9.Value = "picture";
                        if (khatam.core.License.ValidModule("picture") == true) DDLtypeO.Items.Add(tli9);

                        ListItem tli10 = new ListItem();
                        tli10.Text = "هاست";
                        tli10.Value = "host";
                        if (khatam.core.License.ValidModule("host") == true) DDLtypeO.Items.Add(tli10);


                        ListItem tli11 = new ListItem();
                        tli11.Text = "اخبار";
                        tli11.Value = "news";
                        if (khatam.core.License.ValidModule("news") == true) DDLtypeO.Items.Add(tli11);


                        ListItem tli12 = new ListItem();
                        tli12.Text = "کتابخانه";
                        tli12.Value = "library";
                        if (khatam.core.License.ValidModule("library") == true) DDLtypeO.Items.Add(tli12);

                        ListItem tli13 = new ListItem();
                        tli13.Text = "نرم افزار";
                        tli13.Value = "software";
                        if (khatam.core.License.ValidModule("software") == true) DDLtypeO.Items.Add(tli13);


                        ListItem tli14 = new ListItem();
                        tli14.Text = "موبایل";
                        tli14.Value = "mobile";
                        if (khatam.core.License.ValidModule("mobile") == true) DDLtypeO.Items.Add(tli14);


                        ListItem tli15 = new ListItem();
                        tli15.Text = "کلیپ";
                        tli15.Value = "clip";
                        if (khatam.core.License.ValidModule("clip") == true) DDLtypeO.Items.Add(tli15);


                        ListItem tli16 = new ListItem();
                        tli16.Text = "محصولات";
                        tli16.Value = "shop";
                        if (khatam.core.License.ValidModule("shop") == true) DDLtypeO.Items.Add(tli16);



                        ListItem tli17 = new ListItem();
                        tli17.Text = "لینک";
                        tli17.Value = "link";
                        if (khatam.core.License.ValidModule("link") == true) DDLtypeO.Items.Add(tli17);


                        ListItem tli18 = new ListItem();
                        tli18.Text = "املاک خرید و فروش";
                        tli18.Value = "estate_1";
                        if (khatam.core.License.ValidModule("estate") == true) DDLtypeO.Items.Add(tli18);

                        ListItem tli19 = new ListItem();
                        tli19.Text = "املاک رهن و اجاره";
                        tli19.Value = "estate_2";
                        if (khatam.core.License.ValidModule("estate") == true) DDLtypeO.Items.Add(tli19);


                        string contentTable;
                        contentTable = khatam.core.data.sql.InstanceValGet(instanceID, "contentTable");

                        try
                        {
                            DDLtypeO.SelectedValue = contentTable;

                        }
                        catch
                        {
                            

                        }



                        //DDLtype.SelectedValue = contentTable;

                        DDLtypeO.Font.Name = "tahoma";

                        return DDLtypeO;
                    }

                    public DropDownList DLLHeaderImageSizeO = new DropDownList();

                    public Control DLLHeaderImageSize(string instanceID)
                    {


                        // panel1.Controls.Add(new LiteralControl("	<label class=\"description\" for=\"element_5\">نوع نمایش لیست </label> "));



                        DLLHeaderImageSizeO.ID = "DLLHeaderImageSize" + instanceID;

                        ListItem DLLHeaderImageSizeOli1 = new ListItem();
                        DLLHeaderImageSizeOli1.Text = "1";
                        DLLHeaderImageSizeOli1.Value = "1";

                        ListItem DLLHeaderImageSizeOli2 = new ListItem();
                        DLLHeaderImageSizeOli2.Text = "2";
                        DLLHeaderImageSizeOli2.Value = "2";

                        ListItem DLLHeaderImageSizeOli3 = new ListItem();
                        DLLHeaderImageSizeOli3.Text = "3";
                        DLLHeaderImageSizeOli3.Value = "3";

                        ListItem DLLHeaderImageSizeOli4 = new ListItem();
                        DLLHeaderImageSizeOli4.Text = "4";
                        DLLHeaderImageSizeOli4.Value = "4";

                        ListItem DLLHeaderImageSizeOli5 = new ListItem();
                        DLLHeaderImageSizeOli5.Text = "5";
                        DLLHeaderImageSizeOli5.Value = "5";

                        ListItem DLLHeaderImageSizeOli6 = new ListItem();
                        DLLHeaderImageSizeOli6.Text = "6";
                        DLLHeaderImageSizeOli6.Value = "6";

                        ListItem DLLHeaderImageSizeOli7 = new ListItem();
                        DLLHeaderImageSizeOli7.Text = "7";
                        DLLHeaderImageSizeOli7.Value = "7";

                        ListItem DLLHeaderImageSizeOli8 = new ListItem();
                        DLLHeaderImageSizeOli8.Text = "8";
                        DLLHeaderImageSizeOli8.Value = "8";


                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli1);
                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli2);
                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli3);
                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli4);
                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli5);
                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli6);
                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli7);
                        DLLHeaderImageSizeO.Items.Add(DLLHeaderImageSizeOli8);

                        DLLHeaderImageSizeO.Font.Name = "tahoma";

                        DLLHeaderImageSizeO.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "headerImageSize");

                        return DLLHeaderImageSizeO;
                    }





                    public DropDownList DDLskinO = new DropDownList();

                    public Control DDLskin(string instanceID)
                    {


                        DirectoryInfo StoreFile = new DirectoryInfo(Page.Server.MapPath("~/radcontrols/menu/skins/"));
                        DirectoryInfo[] fi;

                        fi = StoreFile.GetDirectories();

                        DDLskinO.ID = "DDLskinO" + instanceID;

                        foreach (var item in fi)
                        {
                            ListItem li = new ListItem();
                            li.Text = item.ToString();
                            li.Value = item.ToString();
                            DDLskinO.Items.Add(li);
                        }

                        DDLskinO.Font.Name = "tahoma";

                        DDLskinO.SelectedValue = khatam.core.data.sql.InstanceValGet(instanceID, "skin");



                        return DDLskinO;
                    }

                    TextBox tb_Title = new TextBox();

                    public Control TxtTitle(string instanceID)
                    {
                        tb_Title.Font.Name = "tahoma";

                        tb_Title.Text = khatam.core.data.sql.InstanceValGet(instanceID, "title");


                        return tb_Title;
                    }

                    TextBox tb_width = new TextBox();

                    public Control TxtWidth(string instanceID)
                    {
                        tb_width.Font.Name = "tahoma";

                        tb_width.Text = khatam.core.data.sql.InstanceValGet(instanceID, "Width");


                        return tb_width;
                    }


                    TextBox tb_top = new TextBox();

                    public Control txtTop(string instanceID)
                    {
                        tb_top.Font.Name = "tahoma";

                        tb_top.Text = khatam.core.data.sql.InstanceValGet(instanceID, "top");


                        return tb_top;
                    }

                    TextBox txtBoxheaderContentO = new TextBox();

                    public Control txtBoxheaderContent(string instanceID)
                    {
                        txtBoxheaderContentO.Font.Name = "tahoma";

                        txtBoxheaderContentO.Text = khatam.core.data.sql.InstanceValGet(instanceID, "headerContent");


                        return txtBoxheaderContentO;
                    }




                    public Button btnCanelo = new Button();

                    public Button btnCanel()
                    {

                        btnCanelo.ID = "Button2";
                        btnCanelo.Text = "انصراف";
                        btnCanelo.Font.Name = "tahoma";
                        btnCanelo.OnClientClick = "opener.location.reload();window . close (); return false;";
                        return btnCanelo;
                    }

                    public Button btnSaveo = new Button();


                    public Button btnSave()
                    {

                        btnSaveo.ID = "Button1";
                        btnSaveo.Text = "بروز رسانی";
                        btnSaveo.Font.Name = "tahoma";
                        //btnSaveo.OnClientClick = "testAAA();";
                        btnSaveo.Click += new EventHandler(btnAddSave_Click);

                        return btnSaveo;

                    }

                    CheckBox chkboxTabList_ShowContentList = new CheckBox();

                    public CheckBox chkboxTabList()
                    {

                        chkboxTabList_ShowContentList.ID = "Button1chk";
                        chkboxTabList_ShowContentList.Text = "بروز رسانی";
                        chkboxTabList_ShowContentList.Font.Name = "tahoma";
                        chkboxTabList_ShowContentList.AutoPostBack = true;
                        //btnSaveo.OnClientClick = "testAAA();";
                        chkboxTabList_ShowContentList.CheckedChanged += new EventHandler(chkboxTabList_Click);

                        return chkboxTabList_ShowContentList;

                    }

                    protected void chkboxTabList_Click(object sender, EventArgs e)
                    {
                        HttpContext.Current.Response.Redirect("http://www.google.com");
                    }


                    protected void btnEdit_Click(object sender, EventArgs e)
                    {

                        //khatam.core.data.sql.InstanceValSet(instanceID, "memo", ih.Value);
                        //this.Page.Response.Redirect("http://www.google.com/");
                        phFormEdit.Visible = true;
                        mPop.Show();


          


                    }

                    protected void btnCancel_Click(object sender, EventArgs e)
                    {

                        //khatam.core.data.sql.InstanceValSet(instanceID, "memo", ih.Value);
                        //this.Page.Response.Redirect("http://www.google.com/");
                        //RedirectTo("https://www.google.com/");
                       // mPop.Hide();
                       // phFormEdit.Visible = false ;

                        this.Controls.Add(new LiteralControl("<script type=\"text/javascript\"> window.close();</script>"));
                                 


                    }
                    

                }
            }

        }
    }
}


