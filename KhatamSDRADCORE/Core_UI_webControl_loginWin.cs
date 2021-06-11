using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using khatam.core.Security;


namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:loginWin runat=server></{0}:loginWin>")]
                public class loginWin : CompositeControl
                {

                    //decleare 



                    //********* edit mode
                    public bool showStyled;
                    public bool editMode;
                    public bool Demo;

                    public bool LoginValidUserOnly;


                    Label lblMsg = new Label();

                    Panel pLogin = new Panel();
                    //pLogin.ID = "pLogin";
                    Panel pLogout = new Panel();
                    //pLogout.ID = "pLogout";

                    public event EventHandler SubmitHandler;

                    public event EventHandler LoggedIn;



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



                    public string fckvalue3
                    {
                        get
                        {
                            TextBox fck1 = (TextBox)this.FindControl("fck" + instanceID);

                            return fck1.Text;
                        }
                        set
                        {
                            TextBox fck1 = (TextBox)this.FindControl("fck" + instanceID);

                            fck1.Text = value;
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

                    public delegate void IndexChangeEventHandler(object sender, EventArgs e);
                    public event IndexChangeEventHandler SelectedIndexChanged = delegate { };
                    //this is in your composite control, handling ddl's index change event 
                    protected void DDL_SelectedIndexchanged(object sender, EventArgs e)
                    {
                        SelectedIndexChanged(this, e);
                    }


                    // protected override void CreateChildControls()

                    protected override void CreateChildControls()
                    {
                        if (showStyled == true)
                        {
                            this.Controls.Add(form_login_style1());
                        }
                        else
                        {
                            this.Controls.Add(form_login_simple());
                        }


                    }

                    public Button btnlogin = new Button();


                    private PlaceHolder form_login_style1()
                    {
                        PlaceHolder ph = new PlaceHolder();

                        
                        bool logged = false;


                        int userId = khatam.core.Security.Users.login();
                        if (userId > 0) logged = true;





                        if (editMode) this.Controls.Add(new LiteralControl("<div class=\"ve_div\">"));


                        if (editMode)
                        {
                            ImageButton btnEdit = new ImageButton();
                            btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                            btnEdit.OnClientClick = "child=window.open(\"editor.aspx?instanceID=" + instanceID + "&mode=15\",\"_blank\",\" scrollbars=yes, resizable=no, , width=825, height=600\",'child');return false;";
                            this.Controls.Add(btnEdit);
                        }



                        //if (editMode) this.Controls.Add(new LiteralControl("</div>"));





                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));

                        this.Controls.Add(new LiteralControl("<br />"));

                        //  Telerik.WebControls.RadAjaxPanel AjaxPanel = new Telerik.WebControls.RadAjaxPanel();
                        //  Telerik.WebControls.AjaxLoadingPanel alp = new Telerik.WebControls.AjaxLoadingPanel();

                        UpdatePanel AjaxPanel = new UpdatePanel();
                        UpdateProgress alp = new UpdateProgress();
                        alp.Controls.Add(new LiteralControl("<img alt=\"loading...\" src=\"RadControls/Ajax/Skins/Default/Loading1.gif\" />"));

                        //if (this.Page.IsPostBack == false)
                        // {

                        alp.AssociatedUpdatePanelID = AjaxPanel.ClientID;
                        // }

                        this.Controls.Add(alp);



                        if (logged)
                        {
                            pLogin.Visible = false;
                            pLogout.Visible = true;
                        }
                        else
                        {
                            pLogin.Visible = true;
                            pLogout.Visible = false;
                        }

                        TextBox tbuser = new TextBox();
                        tbuser.ID = "tbUser";

                        //pLogin.Controls.Add(new LiteralControl(logged.ToString()));



                        string html = "<div id=\"stylized\" class=\"myform\">"

                            //+ " <form id=\"form\" name=\"form\" method=\"post\" action=\"index.html\">"
                    + " <h1>از کاربران سایت ما هستید؟</h1>"
                    + " <p>لطفا نام کاربری و کلمه عبور خود را وارد کنید</p>";
                        pLogin.Controls.Add(new LiteralControl(html));

                        //##pLogin.Controls.Add(new LiteralControl("<div >نام کاربری (ایمیل)</div>"));
                        pLogin.Controls.Add(tbuser);
                        pLogin.Controls.Add(new LiteralControl("<label>نام کاربری<span class=\"small\">ایمیل</span></label>"));

                        //  pLogin.Controls.Add(new LiteralControl("<div dir=\"ltr\">"));
                        //pLogin.Controls.Add(tbuser);
                        //  pLogin.Controls.Add(new LiteralControl("</div>"));


                        TextBox tbpass = new TextBox();
                        tbpass.ID = "tbPass";
                        tbpass.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
                        pLogin.Controls.Add(tbpass);

                        pLogin.Controls.Add(new LiteralControl("<label>کلمه عبور<span class=\"small\">گذر واژه</span></label>"));

                        // pLogin.Controls.Add(new LiteralControl("<div>کلمه عبور</div>"));

                        //  pLogin.Controls.Add(new LiteralControl("<div dir=\"ltr\">"));
                        //  pLogin.Controls.Add(tbpass);
                        // pLogin.Controls.Add(new LiteralControl("</div>"));








                        pLogin.Controls.Add(new LiteralControl("<br />"));


                        btnlogin.Text = "ورود";
                        btnlogin.Font.Name = "tahoma";
                        btnlogin.CssClass = "btnSS";
                        btnlogin.Width = 125;
                        btnlogin.Height = 31;

                        btnlogin.Click += new EventHandler(btnlogin_Click);
                        pLogin.Controls.Add(btnlogin);
                        //pLogin.Controls.Add(new LiteralControl("<br />"));

                        pLogin.Controls.Add(new LiteralControl(" <div class=\"spacer\"></div>"));

                        Label lbl = new Label();
                        //lbl.Text = msg;
                        lbl.ID = "Lbl1msg";
                        //pLogin.Controls.Add(new LiteralControl("<label><span class=\"small\">گذر واژه</span></label>"));
                        pLogin.Controls.Add(lbl);
                        //pLogin.Controls.Add(new LiteralControl("</div>"));
                        pLogin.Controls.Add(new LiteralControl("<br />"));
                        pLogin.Controls.Add(new LiteralControl("<br />"));



                        //##    pLogin.Controls.Add(new LiteralControl("کاربر جدید هستید؟ "));
                        //## pLogin.Controls.Add(new LiteralControl("<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/membership/" + "\">"));
                        //##  pLogin.Controls.Add(new LiteralControl("فرم عضویت"));
                        //##    pLogin.Controls.Add(new LiteralControl("</a>"));

                        //##   pLogin.Controls.Add(new LiteralControl("<br />"));
                        //<a href="google.com">
                        pLogin.Controls.Add(new LiteralControl("<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/forgot_password.aspx" + "\">"));
                        pLogin.Controls.Add(new LiteralControl("رمز عبور را به خاطر ندارید؟"));
                        pLogin.Controls.Add(new LiteralControl("</a>"));



                        // PlaceHolder  t = (PlaceHolder)Parent;//.FindControl("TextBoxName");
                        //  Parent.
                        // t.btn1.Text = "محشر";



                        pLogin.Controls.Add(new LiteralControl("</div>"));

                        pLogin.Controls.Add(new LiteralControl("<br />"));

                        AjaxPanel.ContentTemplateContainer.Controls.Add(pLogin);

                        try
                        {
                            lblMsg.Text = "کاربر گرامی، " + khatam.core.Security.Users.getRealNameByEmail(this.Page.Request.Cookies["UID"].Value) + " خوش آمدید " + "<br />" +
                             "<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/" + "\">" + "کنترل پنل اختصاصی" + "</a>" + "<br />";
                        }
                        catch
                        {
                        }

                        pLogout.Controls.Add(lblMsg);




                        Button btnlogout = new Button();
                        btnlogout.Text = "خروج";
                        btnlogout.Font.Name = "tahoma";
                        btnlogout.Click += new EventHandler(btnlogout_Click);
                        pLogout.Controls.Add(btnlogout);
                        pLogout.Controls.Add(new LiteralControl("<br />"));

                        AjaxPanel.ContentTemplateContainer.Controls.Add(pLogout);


                        this.Controls.Add(AjaxPanel);

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));
                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));






                        return ph;
                    }

                    private PlaceHolder form_login_simple()
                    {
                        PlaceHolder ph = new PlaceHolder();

                        bool logged = false;


                        int userId = khatam.core.Security.Users.login();
                        if (userId > 0) logged = true;



                        if (editMode) this.Controls.Add(new LiteralControl("<div class=\"ve_div\">"));


                        if (editMode)
                        {
                            ImageButton btnEdit = new ImageButton();
                            btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                            btnEdit.OnClientClick = "child=window.open(\"editor.aspx?instanceID=" + instanceID + "&mode=15\",\"_blank\",\" scrollbars=yes, resizable=no, , width=825, height=600\",'child');return false;";
                            this.Controls.Add(btnEdit);
                        }


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));

                        this.Controls.Add(new LiteralControl("<br />"));


                        UpdatePanel AjaxPanel = new UpdatePanel();
                        UpdateProgress alp = new UpdateProgress();
                        alp.Controls.Add(new LiteralControl("<img alt=\"loading...\" src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "RadControls/Ajax/Skins/Default/Loading1.gif\" />"));

                        alp.AssociatedUpdatePanelID = AjaxPanel.ClientID;

                        this.Controls.Add(alp);



                        if (logged)
                        {
                            pLogin.Visible = false;
                            pLogout.Visible = true;
                        }
                        else
                        {
                            pLogin.Visible = true;
                            pLogout.Visible = false;
                        }

                        TextBox tbuser = new TextBox();
                        tbuser.ID = "tbUser";

                        pLogin.Controls.Add(new LiteralControl("<div >نام کاربری (ایمیل)</div>"));
                        pLogin.Controls.Add(tbuser);
                        pLogin.Controls.Add(new LiteralControl("<div dir=\"ltr\">"));
                        pLogin.Controls.Add(tbuser);
                        pLogin.Controls.Add(new LiteralControl("</div>"));


                        TextBox tbpass = new TextBox();
                        tbpass.ID = "tbPass";
                        tbpass.TextMode = System.Web.UI.WebControls.TextBoxMode.Password;
                        pLogin.Controls.Add(new LiteralControl("<div>کلمه عبور</div>"));
                        pLogin.Controls.Add(new LiteralControl("<div dir=\"ltr\">"));
                        pLogin.Controls.Add(tbpass);
                        pLogin.Controls.Add(new LiteralControl("</div>"));

                        Label lbl = new Label();
                        lbl.ID = "Lbl1msg";
                        pLogin.Controls.Add(lbl);
                        pLogin.Controls.Add(new LiteralControl("<br />"));

                        btnlogin.Text = "ورود";
                        btnlogin.Font.Name = "tahoma";
                        btnlogin.CssClass = "btn";
                        btnlogin.Click += new EventHandler(btnlogin_Click);
                        pLogin.Controls.Add(btnlogin);
                        pLogin.Controls.Add(new LiteralControl("<br />"));

                        pLogin.Controls.Add(new LiteralControl("کاربر جدید هستید؟ "));
                        pLogin.Controls.Add(new LiteralControl("<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "fa/web/membership/" + "\">"));
                        pLogin.Controls.Add(new LiteralControl("فرم عضویت"));
                        pLogin.Controls.Add(new LiteralControl("</a>"));

                        pLogin.Controls.Add(new LiteralControl("<br />"));
                        pLogin.Controls.Add(new LiteralControl("<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/forgot_password.aspx" + "\">"));
                        pLogin.Controls.Add(new LiteralControl("رمز عبور را به خاطر ندارید؟"));
                        pLogin.Controls.Add(new LiteralControl("</a>"));

                        pLogin.Controls.Add(new LiteralControl("<br />"));

                        AjaxPanel.ContentTemplateContainer.Controls.Add(pLogin);

                        try
                        {
                            lblMsg.Text = "کاربر گرامی، " + khatam.core.Security.Users.getRealNameByEmail(this.Page.Request.Cookies["UID"].Value) + " خوش آمدید " + "<br />" +
                             "<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/" + "\">" + "کنترل پنل اختصاصی" + "</a>" + "<br />";
                        }
                        catch
                        {
                        }

                        pLogout.Controls.Add(lblMsg);

                        Button btnlogout = new Button();
                        btnlogout.Text = "خروج";
                        btnlogout.Font.Name = "tahoma";
                        btnlogout.Click += new EventHandler(btnlogout_Click);
                        pLogout.Controls.Add(btnlogout);
                        pLogout.Controls.Add(new LiteralControl("<br />"));

                        AjaxPanel.ContentTemplateContainer.Controls.Add(pLogout);


                        this.Controls.Add(AjaxPanel);

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));
                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));






                        return ph;
                    }


                    public void btnlogin_Click(object sender, EventArgs e)
                    {

                        Label lblt = new Label();
                        lblt = (Label)this.FindControl("Lbl1msg");
                        //Lbl1msg

                        TextBox tbuser = new TextBox();
                        tbuser = (TextBox)this.FindControl("tbUser");

                        TextBox tbpass = new TextBox();
                        tbpass = (TextBox)this.FindControl("tbPass");



                        int LoginResult = Users.login(tbuser.Text, tbpass.Text);


                        if (LoginResult > 0)
                        {

                            lblMsg.Text = "کاربر گرامی، " + khatam.core.Security.Users.getRealNameByEmail(this.Page.Request.Cookies["UID"].Value) + " خوش آمدید " + "<br />" +
                            "<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/" + "\">" + "کنترل پنل اختصاصی" + "</a>" + "<br />";

                            lblt.Text = "";

                            pLogout.Visible = true;
                            pLogin.Visible = false;

                            if (LoggedIn != null)
                                LoggedIn(this, e);
                        }

                  
                        switch (LoginResult)
                        {
                            //faild user pass
                            case -2:
                                lblt.Text = "نام کاربری یا کلمه عبور اشتباه است";
                                lblMsg.Text = "";
                                pLogout.Visible = false;
                                pLogin.Visible = true;
                                break;
                            //faild email is not active
                            case -3:
                                lblMsg.Text = "کاربر گرامی، " + khatam.core.Security.Users.getRealNameByEmail(tbuser.Text) + " نام کاربری شما فعال نیست." + "<br />" +
                                               "لطفا به ایمیلی که در زمان ثبت نام برای شما ارسال شده مراجعه کنید و یا به آدرس زیر برای ارسال مجدد ایمیل فعال سازی مراجعه کنید: " + "<br />" +
                                               "<a  class=\"public_Link\"  href=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/ActivationReSend.aspx" + "\">" + "ارسال مجدد ایمیل فعال سازی" + "</a>" + "<br />";

                                lblt.Text = "";
                                break;

                        }





                    }





                    protected void btnlogout_Click(object sender, EventArgs e)
                    {
                        logout();
                        pLogout.Visible = false;
                        pLogin.Visible = true;



                    }

                    string removeInjectionChars(string str)
                    {


                        str = str.Replace("'", "").Replace("<", "").Replace(">", "");


                        return str;
                    }



                    bool logout()
                    {
                        HttpCookie objuid, objpid, objtopbar;
                        objuid = this.Page.Request.Cookies["UID"];
                        objpid = this.Page.Request.Cookies["PID"];
                        objtopbar = this.Page.Request.Cookies["topbar"];



                        if (objuid == null)
                        {
                            //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                        }
                        else
                        {
                            objuid.Expires = DateTime.UtcNow.AddDays(-60);
                            this.Page.Response.Cookies.Add(objuid);
                            //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                        }


                        if (objpid == null)
                        {
                            //this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                        }
                        else
                        {
                            objpid.Expires = DateTime.UtcNow.AddDays(-60);
                            this.Page.Response.Cookies.Add(objpid);
                            //  this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                        }

                        if (objtopbar == null)
                        {
                            // this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);

                        }
                        else
                        {
                            objtopbar.Expires = DateTime.UtcNow.AddDays(-60);
                            this.Page.Response.Cookies.Add(objtopbar);
                            // this.Response.Redirect(Request.ServerVariables["HTTP_REFERER"]);
                        }



                        HttpCookie aCookie = new HttpCookie("lastVisit");

                        aCookie.Value = DateTime.UtcNow.ToString();
                        aCookie.Expires = DateTime.UtcNow.AddDays(-60);
                        Context.Response.Cookies.Add(aCookie);
                        this.Page.Session["State"] = false;
                        this.Page.Session.Abandon();

                        return true;

                    }

                    bool set_cookie(string userName, string password)
                    {
                        this.Page.Response.Cookies["UID"].Value = userName;
                        this.Page.Response.Cookies["PID"].Value = password;


                        return true;
                    }

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
                        ///

                    }







                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }












                }
            }
        }
    }
}
