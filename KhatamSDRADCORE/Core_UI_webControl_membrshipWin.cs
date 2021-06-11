using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:membrshipWin runat=server></{0}:membrshipWin>")]
                public class membrshipWin : CompositeControl
                {
                    public event EventHandler SubmitHandler;

                    public event EventHandler SaveHandler2;

                    public event EventHandler oncreateduser;

                    static Button btnok = new Button();

                    Panel PanelWin = new Panel();
                    Label Lbl1 = new Label();
                   



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

                    public string instanceID;


                    public Boolean winVisible;




                    //protected override void





                    void Submit_Click2(object sender, EventArgs e)
                    {
                        if (SubmitHandler != null)
                            SubmitHandler(this, e);
                        //Lbl1.Text = "two" + DateTime.UtcNow.ToString();

                        // khatam.core.data.sql.updateField("propertyValue", "valtest", "propertyTitle", "title", "Core_serverControlsInstanceVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        khatam.core.data.sql.InstanceValSet("6", "title", "sssssss");
                        //Page.Response.Redirect("http://www.google.com/");
                    }


                    void Submit_Click(object sender, EventArgs e)
                    {
                        if (SubmitHandler != null)
                            SubmitHandler(this, e);
                        //Lbl1.Text = "two" + DateTime.UtcNow.ToString();


                        //PanelWin.Controls.Add(new LiteralControl("<script  type=\"text/javascript\" > $(function () {$(\"#dialog:ui-dialog\").dialog(\"destroy\");$(\"#dialog-modal\").dialog({height: 600,width:900,modal: true });});</script>"));

                        //PanelWin.Controls.Add(new LiteralControl("<div id=\"dialog-modal\" title=\"" + title + "\"><p>"));

                        //  FredCK.FCKeditorV2.FCKeditor f = new FredCK.FCKeditorV2.FCKeditor();
                        //  f.BasePath = "~/fckeditor/";
                        //  f.Height = 400;
                        //  f.Value = memo;
                        //  f.AutoDetectLanguage = false;
                        //  f.ContentLangDirection = FredCK.FCKeditorV2.LanguageDirection.RightToLeft;
                        //  f.DefaultLanguage = "fa";

                        PanelWin.Controls.Add(new LiteralControl("<div>"));


                        PanelWin.Controls.Add(new LiteralControl("</div>"));

                        PanelWin.Controls.Add(new LiteralControl("<div class=\"tb\">"));


                        PanelWin.Controls.Add(new LiteralControl("<div style=\"float:right; \">"));

                        Label Lbl = new Label();
                        Lbl.Text = "عنوان";
                        PanelWin.Controls.Add(Lbl);
                        PanelWin.Controls.Add(new LiteralControl("</div>"));



                        PanelWin.Controls.Add(new LiteralControl("<div style=\" direction:rtl\">"));
                        TextBox tb = new TextBox();
                        tb.Text = title;
                        tb.Font.Name = "tahoma";
                        PanelWin.Controls.Add(tb);
                        PanelWin.Controls.Add(new LiteralControl("</div>"));

                        PanelWin.Controls.Add(new LiteralControl("</div>"));


                        PanelWin.Controls.Add(new LiteralControl("<div class=\"tb\">"));



                        Button btn1 = new Button();
                        btn1.ID = "btn1";
                        btn1.Text = "تایید";
                        btn1.Font.Name = "tahoma";

                        if (khatam.core.ConfigurationManager.License.demo)
                        {
                            btn1.Enabled = false;
                            btn1.ToolTip = "در نسخه دمو این امکان وجود ندارد";
                        }
                        {
                            btn1.Click += new EventHandler(Submit_Click2);
                        }
                        //System.Web.UI.WebControls.butt
                        //Lbl1.Text = "first";


                        PanelWin.Controls.Add(btn1);

                        PanelWin.Controls.Add(new LiteralControl("</div>"));

                        //PanelWin.Controls.Add(new LiteralControl("</p></div>"));


                    }



                    void save_Click2(object sender, EventArgs e)
                    {

                        if (SaveHandler2 != null)
                            SaveHandler2(this, e);

                        //   PanelWin.Controls.Clear();

                        Page.Response.Redirect("http://www.google.com/");
                        //PanelWin.Controls.Add(new LiteralControl("sssssssssss"));

                    }




                    protected override void CreateChildControls()
                    {

                        string str_content = "", section_str = "", contentId = "";

                        try
                        {
                            str_content = this.Parent.Page.ToString().Replace("ASP.", "").Replace("_aspx", "").Replace("_item", "");
                        }
                        catch
                        {
                        }


                        try
                        {
                            section_str = HttpContext.Current.Items["contentType"].ToString();// +".aspx";
                        }
                        catch
                        {
                            section_str = "article";//+ ".aspx";
                        }


                        try
                        {
                            contentId = HttpContext.Current.Items["id"].ToString();// +".aspx";
                        }
                        catch
                        {
                            contentId = "1";
                        }





                        //if (str_content == "layout") layout = true;

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));

                        //if (str_content != "layout") this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField("title", "id", contentId, section_str, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())));

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));

                        //this.Controls.Add(new LiteralControl(memo));

                        //if (str_content != "layout") this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField("page", "id", contentId, section_str, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())));

                        //if (str_content == "shop")
                        //    if (str_content != "layout") this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField("price_in_rls", "id", contentId, section_str, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())));

                        //if (str_content == "shop")

                        panelmsgok.Controls.Add(new LiteralControl("ثبت نام موفقیت آمیز، ایمیل فعال سازی برای شما ارسال شد"));
                        panelmsgok.Visible = false;

                        this.Controls.Add(panelmsgok);

                        ShopCartButton();

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));


                    }

                    public Panel panelmsgok = new Panel();

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





                  

                            //fck.ID = "fck" + instanceID;

                            System.Web.UI.HtmlControls.HtmlInputText tbb = new System.Web.UI.HtmlControls.HtmlInputText();

                            //tbb = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("Text1" + instanceID );

                            khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);

                            Page.Response.Redirect(Page.Request.Url.PathAndQuery);
                            //refresh grid
                            //upGrid.Update();
                        }
                    }

                    private void CloseDialog(string dialogId)
                    {
                        string script = string.Format(@"closeDialog('{0}')", dialogId);
                        ///ScriptManager.RegisterClientScriptBlock(this, typeof(Page), UniqueID, script, true);
                    }


                    public string addInstanceProperty(string Instance)
                    {

                        // khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان");
                        // khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا");
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "idCorePermissionRole", "none", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }


                    #region Events



                    public void btnShopCart_Click(object sender, EventArgs e)
                    {
                        TextBox tbEmail = new TextBox();
                        tbEmail = (TextBox)this.FindControl("tbEmail");

                        bool checkIdentity = false;

                        checkIdentity = khatam.core.data.sql.Sql_Check_identity("email", tbEmail.Text, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                        if (checkIdentity)
                        {

                            ArrayList a = new ArrayList();
                            ArrayList b = new ArrayList();

                            a.Add("username");
                            b.Add("a");

                            TextBox tbFname = new TextBox(); tbFname = (TextBox)this.FindControl("tbFname");
                            a.Add("fname");
                            b.Add(tbFname.Text);

                            TextBox tbLname = new TextBox(); tbLname = (TextBox)this.FindControl("tbLname");
                            a.Add("lname");
                            b.Add(tbLname.Text);

                            TextBox tbCompany = new TextBox(); tbCompany = (TextBox)this.FindControl("tbCompany");
                            a.Add("company");
                            b.Add(tbCompany.Text);

                            TextBox tbTel = new TextBox(); tbTel = (TextBox)this.FindControl("tbTel");
                            a.Add("tel");
                            b.Add(tbTel.Text);

                            TextBox tbFax = new TextBox(); tbFax = (TextBox)this.FindControl("tbFax");
                            a.Add("fax");
                            b.Add(tbFax.Text);

                            TextBox tbCellPhone = new TextBox(); tbCellPhone = (TextBox)this.FindControl("tbCellPhone");
                            a.Add("CellPhone");
                            b.Add(tbCellPhone.Text);

                            TextBox tbCountry = new TextBox(); tbCountry = (TextBox)this.FindControl("tbCountry");
                            a.Add("country");
                            b.Add(tbCountry.Text);

                            TextBox tbStats = new TextBox(); tbStats = (TextBox)this.FindControl("tbStats");
                            a.Add("Stats");
                            b.Add(tbStats.Text);


                            TextBox tbCity = new TextBox(); tbCity = (TextBox)this.FindControl("tbCity");
                            a.Add("City");
                            b.Add(tbCity.Text);


                            TextBox tbAddress = new TextBox(); tbAddress = (TextBox)this.FindControl("tbAddress");
                            a.Add("Address");
                            b.Add(tbAddress.Text);


                            TextBox tbZipCode = new TextBox(); tbZipCode = (TextBox)this.FindControl("tbZipCode");
                            a.Add("ZipCode");
                            b.Add(tbZipCode.Text);


                            string passwordSalt = khatam.core.Security.Users.CreateSalt(10);
                            a.Add("passwordSalt");
                            b.Add(passwordSalt);

                            TextBox tbPassword = new TextBox(); tbPassword = (TextBox)this.FindControl("tbPassword");
                            a.Add("password");
                            b.Add(khatam.core.Security.Users.CreatePasswordHash(tbPassword.Text, passwordSalt));


                            a.Add("email");
                            b.Add(tbEmail.Text);


                            string EmailSalt = khatam.core.Security.Users.CreateSalt(20);
                            a.Add("activeEmailSalt");
                            b.Add(EmailSalt);

                            a.Add("active");
                            b.Add(false);

                            string idUsers;
                       
                            
                            idUsers = khatam.core.data.sql.AddScope(a, b, "users");

                            Page.Session["id_user"] = idUsers;
                            ArrayList aa = new ArrayList();
                            ArrayList bb = new ArrayList();

                            aa.Add("idRole");
                            bb.Add("10001");

                            aa.Add("idUser");
                            bb.Add(idUsers );

                            khatam.core.data.sql.Add(aa, bb, "coreRoleRefUser");

                            khatam.core.email.sendMembershipActive(tbEmail.Text, EmailSalt,"" );

                            if (oncreateduser != null)
                                oncreateduser(this, e);


                            membership_form.Visible = false;
                            panelmsgok.Visible = true;



                            //##this.Page.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/login");
                        }
                        else
                        {
                            Label lbl1msg = new Label(); lbl1msg = (Label)this.FindControl("lbl1msg");
                            lbl1msg.Visible = true;
                        }
                        //khatam.core.data.sql.Add(a, b, "users", ConfigurationManager.ConnectionStrings.ConnectionString());

                        //this.Page.Response.Redirect("http://www.google.com/?q=" + tbFname.Text );
                    }






                    #endregion


                    #region Controls

                    public Panel membership_form = new Panel();

                    


                    public Control ShopCartButton()
                    {


                        

                        Button Btn1 = new Button();
                        Btn1.Text = "ثبت نام";
                        Btn1.Width = 30;
                        //Btn1.Click += new EventHandler(btnGoto_Click);
                        Btn1.ID = "btnGoto";

                        Btn1.Click += new EventHandler(btnShopCart_Click);

                        Btn1.Font.Name = "tahoma";



                        string html = "<div id=\"stylized\" class=\"myform\">"
                            //+ " <form id=\"form\" name=\"form\" method=\"post\" action=\"index.html\">"
                        + " <h1>کاربر جدید هستید؟</h1>"
                        + " <p>لطفا فرم ثبت نام را تکمیل کنید</p>";
                        membership_form.Controls.Add(new LiteralControl(html));


                        TextBox tbFname = new TextBox();
                        tbFname.ID = "tbFname";
                        membership_form.Controls.Add(tbFname);
                        membership_form.Controls.Add(new LiteralControl("<label>نام<span class=\"small\">نام خود را درج نمایید</span></label>"));

                        TextBox tbLname = new TextBox();
                        tbLname.ID = "tbLname";
                        membership_form.Controls.Add(tbLname);
                        membership_form.Controls.Add(new LiteralControl("<label>نام خانوادگی"));

                        RequiredFieldValidator rfv1 = new RequiredFieldValidator();
                        rfv1.ControlToValidate = tbLname.ID;
                        rfv1.ValidationGroup = "membership";
                        rfv1.Text = "*";
                        membership_form.Controls.Add(rfv1);
                        membership_form.Controls.Add(new LiteralControl("<span class=\"small\">نام خانوادگی خود را درج نمایید</span></label>"));


                        TextBox tbCompany = new TextBox();
                        tbCompany.ID = "tbCompany";
                        membership_form.Controls.Add(tbCompany);
                        membership_form.Controls.Add(new LiteralControl("<label>شرکت<span class=\"small\">شرکت موسسه سازمان</span></label>"));

                        TextBox tbTel = new TextBox();
                        tbTel.ID = "tbTel";
                        membership_form.Controls.Add(tbTel);
                        membership_form.Controls.Add(new LiteralControl("<label>تلفن<span class=\"small\">همراه با کد شهر - کشور</span></label>"));

                        TextBox tbFax = new TextBox();
                        tbFax.ID = "tbFax";
                        membership_form.Controls.Add(tbFax);
                        membership_form.Controls.Add(new LiteralControl("<label>نمابر<span class=\"small\">همراه با کد شهر - کشور</span></label>"));

                        TextBox tbCellPhone = new TextBox();
                        tbCellPhone.ID = "tbCellPhone";
                        membership_form.Controls.Add(tbCellPhone);
                        membership_form.Controls.Add(new LiteralControl("<label>تلفن همراه<span class=\"small\">همراه با کد کشور</span></label>"));

                        TextBox tbCountry = new TextBox();
                        tbCountry.ID = "tbCountry";
                        membership_form.Controls.Add(tbCountry);
                        membership_form.Controls.Add(new LiteralControl("<label>کشور<span class=\"small\">نام کشور</span></label>"));

                        TextBox tbStats = new TextBox();
                        tbStats.ID = "tbStats";
                        membership_form.Controls.Add(tbStats);
                        membership_form.Controls.Add(new LiteralControl("<label>استان<span class=\"small\">استان / ایالت</span></label>"));

                        TextBox tbCity = new TextBox();
                        tbCity.ID = "tbCity";
                        membership_form.Controls.Add(tbCity);
                        membership_form.Controls.Add(new LiteralControl("<label>شهر<span class=\"small\">شهر محل سکونت</span></label>"));


                        TextBox tbAddress = new TextBox();
                        tbAddress.ID = "tbAddress";
                        membership_form.Controls.Add(tbAddress);
                        membership_form.Controls.Add(new LiteralControl("<label>آدرس<span class=\"small\">نشانی دقیق محل سکونت</span></label>"));


                        TextBox tbZipCode = new TextBox();
                        tbZipCode.ID = "tbZipCode";
                        membership_form.Controls.Add(tbZipCode);
                        membership_form.Controls.Add(new LiteralControl("<label>کدپستی<span class=\"small\">کد پستی ده رقمی</span></label>"));


                        TextBox tbEmail = new TextBox();
                        tbEmail.ID = "tbEmail";
                        membership_form.Controls.Add(tbEmail);
                        membership_form.Controls.Add(new LiteralControl("<label>ایمیل (نام کاربری)"));

                        RequiredFieldValidator rfv3 = new RequiredFieldValidator();
                        rfv3.ControlToValidate = tbEmail.ID;
                        rfv3.ValidationGroup = "membership";
                        rfv3.Text = "*";
                        membership_form.Controls.Add(rfv3);


                        RegularExpressionValidator rfvEmail = new RegularExpressionValidator();
                        rfvEmail.Text = "*";
                        rfvEmail.ValidationExpression = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                        //ErrorMessage="RegularExpressionValidator" 
                        rfvEmail.ControlToValidate = tbEmail.ID;
                        rfvEmail.ValidationGroup = "membership";
                        membership_form.Controls.Add(rfvEmail);



                        membership_form.Controls.Add(new LiteralControl("<span class=\"small\">پست الکترونیک معتبر</span></label>"));




                        TextBox tbPassword = new TextBox();
                        tbPassword.ID = "tbPassword";
                        tbPassword.TextMode=TextBoxMode.Password ;
                        membership_form.Controls.Add(tbPassword);
                        membership_form.Controls.Add(new LiteralControl("<label>کلمه عبور"));

                        RequiredFieldValidator rfv2 = new RequiredFieldValidator();
                        rfv2.ControlToValidate = tbPassword.ID;
                        rfv2.ValidationGroup = "membership";
                        rfv2.Text = "*";
                        membership_form.Controls.Add(rfv2);


                        membership_form.Controls.Add(new LiteralControl("<span class=\"small\">گذر واژه انتخابی</span></label>"));
                        //this.Controls.Add(new LiteralControl("<label>کلمه عبور<span class=\"small\">گذر واژه انتخابی</span></label>"));





                        Btn1.CssClass = "btnSS";
                        Btn1.Width = 125;
                        Btn1.Height = 31;
                        Btn1.ValidationGroup = "membership";
                        membership_form.Controls.Add(Btn1);
                        //+ " <button type=\"submit\">Sign-up</button>"
                        membership_form.Controls.Add(new LiteralControl(" <div class=\"spacer\"></div>"));
                            //+ " </form>"

                            Label lbl1 = new Label();
                            lbl1.ID = "lbl1msg";
                            lbl1.ForeColor=System.Drawing.Color.Red  ;
                            lbl1.Visible = false;
                            lbl1.Text = "نام کاربری قبلا در سیستم ثبت گردیده است";
                            membership_form.Controls.Add(lbl1);






                            membership_form.Controls.Add(new LiteralControl(" </div>"));


                            


                            this.Controls.Add(membership_form);



                        return null;
                    }

                    #endregion

                }
            }
        }
    }
}
