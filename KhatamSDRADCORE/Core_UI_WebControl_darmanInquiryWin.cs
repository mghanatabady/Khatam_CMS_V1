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
                [ToolboxData("<{0}:darmanInquiryWin runat=server></{0}:darmanInquiryWin>")]
                public class darmanInquiryWin : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string windowsMode;
                    public string instanceID;
                    public Boolean winVisible;
                    public Boolean showPriceTable;

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
                              +  "editor.aspx?instanceID=" + instanceID + "&mode=23\",\"_blank\",\" scrollbars=yes, resizable=no, , width=825, height=600\",'child');return false;";
                          this.Controls.Add(btnEdit);
                      }
                         
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        //this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl("استعلام وضعیت کارت"));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        //this.Controls.Add(new LiteralControl(memo));
                        this.Controls.Add(new LiteralControl("<br/>"));


                        UpdatePanel up = new UpdatePanel();                      
                        UpdateProgress alp = new UpdateProgress();
                        alp.Controls.Add(new LiteralControl("<img alt=\"loading...\" src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "RadControls/Ajax/Skins/Default/Loading1.gif\" />"));

                        //if (this.Page.IsPostBack == false)
                        // {

                        alp.AssociatedUpdatePanelID = up.ClientID;
                        // }

                        this.Controls.Add(alp);

                        this.Controls.Add(new LiteralControl("<div style=\" text-align:center\" margin=\"auto\" >"));
                        up.ContentTemplateContainer.Controls.Add(InquiryForm());

                       
                        up.ContentTemplateContainer.Controls.Add(new LiteralControl("</div>"));



                        this.Controls.Add(up);

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));
                        
                    }

               
                   

                    Panel pSearchBox = new Panel();

                    Panel pNotFound = new Panel();
                    Panel pResult = new Panel();
                    Panel pCaptchaError = new Panel();
                    Panel pRows = new Panel();



                    TextBox tbDarmaCardId = new TextBox();
                    TextBox tbNationalCode = new TextBox();
                    TextBox tbCaptcha = new TextBox();

                    Obout.Ajax.UI.Captcha.CaptchaImage captcha = new Obout.Ajax.UI.Captcha.CaptchaImage();



                    public Control InquiryForm()
                    {
                        
                        PlaceHolder ph = new PlaceHolder();


                        /*************row******/
                        pSearchBox.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                        pSearchBox.Controls.Add(new LiteralControl(" شماره کارت "));
                        pSearchBox.Controls.Add(new LiteralControl("<br />"));
                        //ph.Controls.Add(new LiteralControl(getColVal(dt_result, fb_form_elements.element_id)));
                        RequiredFieldValidator rfvtbDarmaCardId = new RequiredFieldValidator();
                        rfvtbDarmaCardId.ControlToValidate = "tbDarmaCardId";
                        rfvtbDarmaCardId.Text = "*";
                        rfvtbDarmaCardId.ErrorMessage = "لطفا شماره کارت را وارد نمایید";
                        rfvtbDarmaCardId.ValidationGroup = "SearchBox";
                        pSearchBox.Controls.Add(rfvtbDarmaCardId);
                        tbDarmaCardId.Font.Name = "tahoma";
                        tbDarmaCardId.ID = "tbDarmaCardId";
                        tbDarmaCardId.Width = 120;
                        pSearchBox.Controls.Add(tbDarmaCardId);
                        pSearchBox.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

  

                        /*************row******/
                        pSearchBox.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                        pSearchBox.Controls.Add(new LiteralControl(" کد ملی    "));
                        pSearchBox.Controls.Add(new LiteralControl("<br />"));
                        
                        RequiredFieldValidator rfvtbDomainName = new RequiredFieldValidator();
                        rfvtbDomainName.ControlToValidate = "tbNationalCode";
                        rfvtbDomainName.Text = "*";
                        rfvtbDomainName.ErrorMessage  = "لطفا کد ملی دارنده کارت را وارد نمایید";
                        rfvtbDomainName.ValidationGroup = "SearchBox";
                        pSearchBox.Controls.Add(rfvtbDomainName);


                        tbNationalCode.Font.Name = "tahoma";
                        tbNationalCode.ID = "tbNationalCode";
                        tbNationalCode.Width = 120;
                        pSearchBox.Controls.Add(tbNationalCode);
                        pSearchBox.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/

                        pSearchBox.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                        pSearchBox.Controls.Add(captcha);
                        pSearchBox.Controls.Add(new LiteralControl("<br />"));
                        pSearchBox.Controls.Add(new LiteralControl(" متن تصویر    "));
                        pSearchBox.Controls.Add(new LiteralControl("<br />"));

                        RequiredFieldValidator rfvtbtbCaptcha = new RequiredFieldValidator();
                        rfvtbtbCaptcha.ControlToValidate = "tbCaptcha";
                        rfvtbtbCaptcha.Text = "*";
                        rfvtbtbCaptcha.ErrorMessage = "لطفا متن تصویر را درج نمایید";
                        rfvtbtbCaptcha.ValidationGroup = "SearchBox";
                        pSearchBox.Controls.Add(rfvtbtbCaptcha);


                        tbCaptcha.Font.Name = "tahoma";
                        tbCaptcha.ID = "tbCaptcha";
                        tbCaptcha.Width = 120;
                        pSearchBox.Controls.Add(tbCaptcha);
                        pSearchBox.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/


                        /***footer***/
                        pSearchBox.Controls.Add(new LiteralControl(" <div id=\"footer\"  style=\" direction:rtl; text-align:right;  padding:10px 20px 20px 20px;\">"));


                        pSearchBox.Controls.Add(new LiteralControl("<br/>"));

                        ValidationSummary ValidationSummary = new System.Web.UI.WebControls.ValidationSummary();
                        ValidationSummary.ValidationGroup = "SearchBox" ;
                        ValidationSummary.HeaderText = "لطفا به موارد زیر توجه کنید:";
                        pSearchBox.Controls.Add(ValidationSummary);

                        pSearchBox.Controls.Add(new LiteralControl("<br/>"));

                        pCaptchaError.Controls.Add(new LiteralControl(
                            khatam.core.Drawing.windows.getErrorMessage("متن تصویر اشتباه است", "لطفا متن تصویر را با دقت وارد نمایید"
                            , true)));
                        pCaptchaError.Visible = false;
                        ph.Controls.Add(pCaptchaError);

                        pNotFound.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getErrorMessage(
                         "کارتی با این مشخصات یافت نگردید", "در درج شماره ملی و کارت دقت نمایید.", true)));
                        pNotFound.Visible = false;
                        ph.Controls.Add(pNotFound);


                        Button btn1 = new Button();
                        btn1.ID = "btn1";
                        btn1.Text = "جستجو";
                        btn1.Font.Name = "tahoma";
                        btn1.ValidationGroup = "SearchBox";
                        btn1.Click += new EventHandler(btn_search_Click);
                        pSearchBox.Controls.Add(btn1);
                        pSearchBox.Controls.Add(new LiteralControl("<br/>"));
                        pSearchBox.Controls.Add(new LiteralControl("</div>"));
                        /***end footer***/
                        ph.Controls.Add(pSearchBox);


                       /*****************************************************************result*********************/



                        pResult.Controls.Add(new LiteralControl(" <div id=\"footer\"  style=\" direction:rtl; text-align:right;  padding:10px 20px 20px 20px;\">"));

                        pResult.Controls.Add(pRows);

                        pResult.Controls.Add(new LiteralControl("<br/>"));

                   

                        Button btn2 = new Button();
                        btn2.ID = "btn2";
                        btn2.Text = "جستجوی مجدد";
                        btn2.Font.Name = "tahoma";                        
                        btn2.Click += new EventHandler(btn_repeat_Click);
                        pResult.Controls.Add(btn2);
                        pResult.Controls.Add(new LiteralControl("<br/>"));
                        pResult.Controls.Add(new LiteralControl("</div>"));
                        pResult.Visible = false;

                        ph.Controls.Add(pResult);
                     // PaneldomainAvailable.Visible = false;

                    
                        /*****************************************************************not found*********************/
                  
                     


                    //    pAddedShopCart.Controls.Add(new LiteralControl(" <img src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                     //    "theme/Flowhub/CssImage/Element/CheckMarkGreanC.gif\" /> <span style=\" font-size:8pt\">به <a href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/shopCart/" + "\">سبد خرید</a> شما اضافه شد</span>"));

                                            

                       // pAddedShopCart.Visible = false;
                       // ph.Controls.Add(pAddedShopCart);


                        //  lw.ShowClicked 








                        return ph;

                    }


        


                    void btn_search_Click(object sender, EventArgs e)
                    {
                        pCaptchaError.Visible = false;
                        pResult.Visible = false;
                        pNotFound.Visible = false;
                    

                        if (!captcha.TestText(tbCaptcha.Text))
                        {
                            
                            pCaptchaError.Visible = true;         
                            

                        }

                       else
                       {
                 


                            GridView gv = new GridView();
                            DataTable dt = new DataTable();
                            gv.AutoGenerateColumns = true;
                            dt = getDarmanCard(tbDarmaCardId.Text ,tbNationalCode.Text );
                            gv.DataSource = dt;
                            gv.DataBind();

                            if (gv.Rows.Count < 1)
                            {
                                pNotFound.Visible = true;
                            }
                            else
                            {
                                pSearchBox.Visible=false;
                                pResult.Visible = true;
                          

                            
                            

                            
                        
               
                            /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[1].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/
                         /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("<img   height=\"150\" width=\"100\" src=\"" +
                         khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "Manage/upload/Content/darmancard/0/" + dt.Rows[0].ItemArray[14].ToString() + "\" />"));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                         /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("نام:"));                
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[2].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                         /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("نام خانوادگی:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[3].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("کد ملی:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[4].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("نام پدر:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[5].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("تاریخ تولد:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[6].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("شماره شناسنامه:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[7].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("محل صدور:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[8].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("تلفن:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[9].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("موبایل:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[10].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("آدرس:"));                  
                         pRows.Controls.Add(new LiteralControl(dt.Rows[0].ItemArray[11].ToString()));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("تاریخ صدور:"));                  
                         pRows.Controls.Add(new LiteralControl(khatam.core.globalization.dateTime.GetPersianDate(DateTime.Parse( dt.Rows[0].ItemArray[12].ToString()))));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                        /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("تاریخ انقضا:"));                  
                         pRows.Controls.Add(new LiteralControl(khatam.core.globalization.dateTime.GetPersianDate(DateTime.Parse( dt.Rows[0].ItemArray[13].ToString()))));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                         /*************row******/
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("وضعیت پرداخت :"));
                         pRows.Controls.Add(new LiteralControl( khatam.shop.invoiceManager.getStatePay(int.Parse(dt.Rows[0].ItemArray[15].ToString()))));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                         /*************row******/

                         string usedNo = countUsedCoupon(dt.Rows[0].ItemArray[0].ToString()).ToString();
                         pRows.Controls.Add(new LiteralControl("<div class=\"fb_row\">"));
                         pRows.Controls.Add(new LiteralControl("تعداد درخواست ها:"));
                         pRows.Controls.Add(new LiteralControl( usedNo));
                         pRows.Controls.Add(new LiteralControl("</div>"));
                        /********** end row ******/

                       



                        }
                        

                        //pResult.Visible = true;
                           //PaneldomainAvailable.Visible = true;
                      //
                        }

                

                    }

                 public  static  int countUsedCoupon(string  darman_cards_id)
                   {

                    Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
                    parameters.Add("darman_cards_id", darman_cards_id );
                    string sql_str= "SELECT COUNT ([id]) FROM [darman_card_use] where (darman_card_use.darman_cards_id =@darman_cards_id)" ;
                    return int.Parse( DBFunctions.ExecuteScaler(sql_str, parameters, System.Data.CommandType.Text,
                    khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString()); 

                   }
                    void btn_repeat_Click(object sender, EventArgs e)
                    {
                        pResult.Visible = false;
                        pSearchBox.Visible = true;
                    }
                    public static DataTable getDarmanCard(string id, string iranNationalCode)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        parameters.Add("id", id);
                        parameters.Add("iranNationalCode", iranNationalCode);


                        str_sql = " SELECT     darman_cards.id, core_invoice_line.title, darman_cards.fname, darman_cards.lname, darman_cards.iranNationalCode, darman_cards.fatherName,  " +
    "                   darman_cards.birthday, darman_cards.shsh, darman_cards.shMahalSodor, darman_cards.tel, darman_cards.mobile, darman_cards.address, darman_cards.regDate,   " +
  "                     darman_cards.expDate, darman_cards.pic, core_invoice.payStatus  " +
" FROM         darman_cards INNER JOIN  " +
                      " core_invoice ON darman_cards.invoice_id = core_invoice.id INNER JOIN  " +
                      " core_invoice_line ON core_invoice.id = core_invoice_line.invoice_id " +
                      "  WHERE     (darman_cards.id = @id) AND (darman_cards.iranNationalCode = @iranNationalCode) ";
                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    }

                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "پیگیری وضعیت کارت", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);
                      

                        return "added";
                    }




                }
            }

        }
    }
}
