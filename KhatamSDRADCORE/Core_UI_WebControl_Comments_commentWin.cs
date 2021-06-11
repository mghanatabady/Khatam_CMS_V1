using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:commentWin runat=server></{0}:commentWin>")]
                public class commentWin : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;


                    public event EventHandler SubmitHandler;

                    public event EventHandler SaveHandler2;

                    //public event EventHandler Send_Click;

                    public PlaceHolder PmsgOk = new PlaceHolder();

                    Panel Pform = new Panel();


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

                    public string tbName
                    {
                        get
                        {
                            TextBox tbName = (TextBox)this.FindControl("tbName" + instanceID);

                            return tbName.Text;
                        }
                        set
                        {
                            TextBox tbName = (TextBox)this.FindControl("tbName" + instanceID);

                            tbName.Text = value;
                        }
                    }


                    public string tbEmail
                    {
                        get
                        {
                            TextBox tbEmail = (TextBox)this.FindControl("tbEmail" + instanceID);

                            return tbEmail.Text;
                        }
                        set
                        {
                            TextBox tbEmail = (TextBox)this.FindControl("tbEmail" + instanceID);

                            tbEmail.Text = value;
                        }
                    }


                    public string tbWebSite
                    {
                        get
                        {
                            TextBox tbWebSite = (TextBox)this.FindControl("tbWebSite" + instanceID);

                            return tbWebSite.Text;
                        }
                        set
                        {
                            TextBox tbWebSite = (TextBox)this.FindControl("tbWebSite" + instanceID);

                            tbWebSite.Text = value;
                        }
                    }


                    public string tbMemo
                    {
                        get
                        {
                            TextBox tbMemo = (TextBox)this.FindControl("tbMemo" + instanceID);

                            return tbMemo.Text;
                        }
                        set
                        {
                            TextBox tbMemo = (TextBox)this.FindControl("tbMemo" + instanceID);

                            tbMemo.Text = value;
                        }
                    }




                    public string windowsMode;

                    public string instanceID;


                    public Boolean winVisible;







                    void Submit_Click2(object sender, EventArgs e)
                    {
                        if (SubmitHandler != null)
                            SubmitHandler(this, e);
                        //Lbl1.Text = "two" + DateTime.UtcNow.ToString();

                        // khatam.core.data.sql.updateField("propertyValue", "valtest", "propertyTitle", "title", "Core_serverControlsInstanceVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                      //  khatam.core.data.sql.InstanceValSet("6", "title", "sssssss");
                        //Page.Response.Redirect("http://www.google.com/");
                    }


                    void respond_Click(object sender, EventArgs e)
                    {
                        if (SubmitHandler != null)
                            SubmitHandler(this, e);
                        //Lbl1.Text = "two" + DateTime.UtcNow.ToString();

                        // khatam.core.data.sql.updateField("propertyValue", "valtest", "propertyTitle", "title", "Core_serverControlsInstanceVal", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        Button btn = (Button)sender;



                        //khatam.core.data.sql.InstanceValSet("6", "title", "sssssss");
                        Page.Response.Redirect("http://www.google.com/?q=" + btn.ID);
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

                        string section_str = "", contentId = "";
                        PmsgOk.Visible = false;
                        Pform.Visible = true;

                        if (editMode) this.Controls.Add(new LiteralControl(khatam.core.Drawing.EditorWin.EditBorderOpen(instanceID, windowsMode)));

                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));


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




                        System.Data.DataTable dt;
                        dt = load_comments(section_str, contentId, true);

                        this.Controls.Add(new LiteralControl("<h4>نظرات کاربران (" + dt.Rows.Count + ")<br /></h4><br />"));


                        PlaceHolder ph = new PlaceHolder();


                        PlaceHolder phRow = new PlaceHolder();

                        //1
                        //ph.Controls.Add(new LiteralControl("<div class=\"pagingGrid\">"));

                        ph.Controls.Add(new LiteralControl("<div>"));


                        string[] strShopCartId;
                        strShopCartId = khatam.shop.shopCart.GetShopCartArrayID(this.Page);

                        //for (int i = 0; i < dt.Rows.Count; i++)
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            string comment_id = dt.Rows[i].ItemArray[0].ToString();

                            ph.Controls.Add(new LiteralControl(" <div style=\"border: 1px solid #cccccc;  margin-bottom: 20px;	overflow: auto; 	width: 100%  \">"));
                            ph.Controls.Add(new LiteralControl(" <div style=\" width: 100%;   float:right\">"));
                            ph.Controls.Add(new LiteralControl(" <div style=\"min-width:58px; width: auto !important;float: right; margin: 8px 10px 8px 10px;  \">"));
                            ph.Controls.Add(new LiteralControl("<img  src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/aspnet/CssImage/Element/user_pic.png\" />"));
                            ph.Controls.Add(new LiteralControl(" </div>"));
                            ph.Controls.Add(new LiteralControl(" <div style=\" width:auto !important; float: right; margin: 8px 0px 8px 0px;\">"));
                            
                            ph.Controls.Add(new LiteralControl("    <div style=\"border: 1px solid #e0e0e0; width:50px;\">"));
                            Button btn = new Button();
                            btn.ID = "dddddddd" + i;
                            btn.ForeColor = System.Drawing.Color.White;
                            btn.BackColor = System.Drawing.Color.Blue;
                            btn.BorderStyle = System.Web.UI.WebControls.BorderStyle.None;
                            btn.Width = 25;
                            btn.Text = "+";
                            btn.Click += new EventHandler(respond_Click);
                            ph.Controls.Add(btn);
                            ph.Controls.Add(new LiteralControl("    </div>"));


                            string html2 = "<script>$(function () {"
+ " $(\"#dialog" + comment_id + "\").dialog({"
+ " draggable: false,"
+ " autoOpen: false,"
+ " width: 525,"
+ " height: 280,"
+ " maxHeight: 0,"
+ " position: {"
+ " my: \"right top\","
+ " at: \"right bottom\","
//+ " open: function(type, data) { "
//+ " $(this).appendTo(\"form\");}, "


+ " of: '#opener" + comment_id + "'"
+ " },"
+ " resizable: false"
+ " });"
+ " $(\"#opener" + comment_id + "\").click(function () {"
+  "$(\".ui-dialog-content\").dialog(\"close\"); "
+ " $(\"#dialog" + comment_id + "\").dialog(\"open\");"
//+ " alert($(this).attr(\"comment_id\"));"
+ " });"
//کد کلوز می تواند تکرار نشود به صورت کلی همه را ببندد
+ " $(\"#closer" + comment_id + "\").click(function () {"
+ "$(\".ui-dialog-content\").dialog(\"close\"); "
//+ " $(\"#dialog" + comment_id + "\").dialog(\"open\");"
                                //+ " alert($(this).attr(\"comment_id\"));"
+ " });"

+ " });</script>";

                            ph.Controls.Add(new LiteralControl(html2));






                            string html = "<a id=\"opener" + comment_id + "\" comment_id=\"" + comment_id + "\" ><div class=\"btn_replay\" ></div></a>"


//" <img class=\"img_replay\" />"

+ " <div id=\"dialog" + comment_id + "\" title=\"Basic dialog\" style=\"position:relative ;display: none;\">";
//+ " <p>" + comment_id + "This is an animated dialog which is useful for displaying information. The dialog window can be moved, resized and closed with the 'x' icon.</p>";
                            ph.Controls.Add(new LiteralControl(html));


 ph.Controls.Add(new LiteralControl("<div class=\"WinCt\"><div class=\"WinCb\"><div class=\"WinCl\"><div class=\"WinCr\"><div class=\"WinCbl\"><div class=\"WinCbr\"><div class=\"WinCtl\"><div class=\"WinCtr\">"));











 
ph.Controls.Add(new LiteralControl( " <div>"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:485px;float:right ; text-align:right \">"));
ph.Controls.Add(new LiteralControl("<h2> پاسخ به نظر</h2>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:20px\">"));
ph.Controls.Add(new LiteralControl("<a id=\"closer" + comment_id + "\"  ><div class=\"comment_close\" ></div></a>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:525px; direction:rtl \" >"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:180px; padding:10px; float:right;\">"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:160px;\">"));
ph.Controls.Add(new LiteralControl( " نام<br />"));
ph.Controls.Add(new LiteralControl( " <asp:TextBox ID=\"TextBox1\" CssClass=\"txtComment\" runat=\"server\"></asp:TextBox>"));
ph.Controls.Add(new LiteralControl(" </div>"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:180px;\">"));
ph.Controls.Add(new LiteralControl( " ایمیل<br />"));
ph.Controls.Add(new LiteralControl( " <asp:TextBox ID=\"TextBox2\" CssClass=\"txtComment\" runat=\"server\"></asp:TextBox>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:180px;\">"));
ph.Controls.Add(new LiteralControl( " وب سایت<br />"));
ph.Controls.Add(new LiteralControl( " <asp:TextBox ID=\"TextBox3\" CssClass=\"txtComment\" runat=\"server\"></asp:TextBox>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( " <div style=\"width:100px; padding:10px; float:right;\">"));
ph.Controls.Add(new LiteralControl( " پیام<br />"));
ph.Controls.Add(new LiteralControl( "<asp:TextBox ID=\"TextBox4\" CssClass=\"txtComment\" TextMode=\"MultiLine\" Width=\"250px\" Height=\"150px\" runat=\"server\"></asp:TextBox>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( " </div>"));
ph.Controls.Add(new LiteralControl( "<div style=\"width:525px; direction:rtl \" >"));

Button btn_dialog = new Button();
btn_dialog.ID = "btn" + comment_id;
btn_dialog.Click += new EventHandler(btnReplay_Click);
btn_dialog.Text = "ارسال";
btn_dialog.UseSubmitBehavior = false;

ph.Controls.Add(btn_dialog);


ph.Controls.Add(new LiteralControl( "<asp:CheckBox ID=\"CheckBox1\" runat=\"server\" />"));
ph.Controls.Add(new LiteralControl( "</div> "));



 

                            



                            ph.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));




                       
                            ph.Controls.Add(new LiteralControl(" </div>"));


                            //ph.Controls.Add(new LiteralControl("    <div style=\"border: 1px solid #e0e0e0; width:50px;\">"));
                            //ph.Controls.Add(new LiteralControl("   ssssssssss"));
                            //Button btnRespond = new Button();
                            //btnRespond.OnClientClick = "alert('fffffffffff');";
                            //ph.Controls.Add(btnRespond);
                            //ph.Controls.Add(new LiteralControl("    </div>"));


                            ph.Controls.Add(new LiteralControl(" </div>"));

                            ph.Controls.Add(new LiteralControl(" <div style=\" width:auto !important; float: right; margin: 8px 0px 8px 0px;\">"));
                            ph.Controls.Add(new LiteralControl(dt.Rows[i].ItemArray[1].ToString()));
                            ph.Controls.Add(new LiteralControl(" </div>"));

                            ph.Controls.Add(new LiteralControl(" </div>"));
                            ph.Controls.Add(new LiteralControl(" <div style=\" width: auto; margin: 8px 10px 8px 10px; color:#c5c5c5; font-size: 8pt; \">"));
                            ph.Controls.Add(new LiteralControl(dt.Rows[i].ItemArray[2].ToString()));
                            ph.Controls.Add(new LiteralControl(" </div>"));




                           // ph.Controls.Add(new LiteralControl("<div>ddddddddddddddddddddddddddd </div>"));



                            ph.Controls.Add(new LiteralControl(" </div>"));




                            ph.Controls.Add(phRow);

                            ph.Controls.Add(phRow);

                        }




                        //form

                        PmsgOk.ID = "PmsgOk" + instanceID;
                        string form =
                            " <div id=\"MSG2\" runat=\"server\" dir=\"rtl\" style=\"border-right: teal 2px solid; border-top: teal 2px solid;"
                            + " margin-left: 96px; border-left: teal 2px solid; width: 576px; margin-right: 10px;"
                            + " border-bottom: teal 2px solid; height: 45px; text-align: right\" "
                            + " visible=\"False\">"





                          + " <div style=\"margin-top: 5px; float: right; width: 38px; margin-right: 10px; height: 26px\">"
                             + "   <img  src=\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "theme/aspnet/CssImage/Element/msg2_icon1.gif\" />"
                         + "</div>"
                         + " <div style=\"padding-right: 5px; margin-top: 5px; float: right; width: 493px; color: red;"
                         + " padding-top: 5px; height: 26px\">"
                         + " <span style=\"color: black\">عملیات موفقیت آمیز<br />"
                         + " <span style=\"font-size: 9pt\">کاربر گرامی با تشکر از اطلاعات ارسالی، در اسرع وقت "
                         + " نظر شما بر روی سایت قرار می گیرد.</span></span></div>"
                         + " <br />"
                         + " </div>";
                        PmsgOk.Controls.Add(new LiteralControl(form));




                        PmsgOk.ID = "Pform" + instanceID;
                        string form2 = " <br />"
                         + " <div id=\"div_form_comment\" style=\"margin-right:10px\" runat=\"server\">"
                         + " <h4>"
                         + " ما را از نظرات خود آگاه سازید:</h4>";


                        Pform.Controls.Add(new LiteralControl(form2));

                        Pform.Controls.Add(new LiteralControl("<br />"));

                        TextBox tbName = new TextBox();
                        tbName.ID = "tbName" + instanceID;
                        Pform.Controls.Add(tbName);
                        Pform.Controls.Add(new LiteralControl("&nbsp;نام"));



                        Pform.Controls.Add(new LiteralControl("<br /><br />"));


                        TextBox tbEmail = new TextBox();
                        tbEmail.ID = "tbEmail" + instanceID;
                        Pform.Controls.Add(tbEmail);
                        Pform.Controls.Add(new LiteralControl(" &nbsp;ایمیل"));



                        Pform.Controls.Add(new LiteralControl("<br /><br />"));


                        TextBox tbWebSite = new TextBox();
                        tbWebSite.ID = "tbWebSite" + instanceID;
                        Pform.Controls.Add(tbWebSite);
                        Pform.Controls.Add(new LiteralControl(" &nbsp;وب سایت"));



                        Pform.Controls.Add(new LiteralControl("<br /><br />"));




                        TextBox tbMemo = new TextBox();
                        tbMemo.ID = "tbMemo" + instanceID;
                        tbMemo.TextMode = System.Web.UI.WebControls.TextBoxMode.MultiLine;
                        tbMemo.Width = Unit.Pixel(550);
                        tbMemo.Height = Unit.Pixel(127);

                        Pform.Controls.Add(tbMemo);

                        Pform.Controls.Add(new LiteralControl("<br /><br />"));


                        Button btn1 = new Button();
                        btn1.ID = "btnSend1";
                        btn1.Font.Name = "tahoma";
                        btn1.Width = Unit.Pixel(100);
                        btn1.Click += new EventHandler(Send_Click);

                        btn1.Text = "ارسال";
                        Pform.Controls.Add(btn1);

                        Pform.Controls.Add(new LiteralControl("<br /> </div>"));






                        ph.Controls.Add(PmsgOk);
                        ph.Controls.Add(Pform);



                        ph.Controls.Add(new LiteralControl("</div>"));
                        this.Controls.Add(ph);


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));
                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));





                    }


                    protected System.Data.DataTable load_comments(string type_content, string id_content, bool valid)
                    {


                        string str_sql;

                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                        parameters.Add("type_content", type_content);
                        parameters.Add("id_content", id_content);
                        parameters.Add("valid", valid);




                        str_sql = "SELECT     id,memo,name   FROM  comment  WHERE     ((id_content = @id_content) and (type_content = @type_content) and (valid = @valid))";


                        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        //'strmsg = "خطايي در ثبت خريد بوجود آمد. لطفا با پشتيباني تماس گيريد"

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

                            DropDownList ODDLwin = new DropDownList();

                            ODDLwin = (DropDownList)FindControl("DDLwin" + instanceID);

                            khatam.core.data.sql.InstanceValSet(instanceID, "windowsMode", ODDLwin.SelectedValue);





                            //fck.ID = "fck" + instanceID;

                            System.Web.UI.HtmlControls.HtmlInputText tbb = new System.Web.UI.HtmlControls.HtmlInputText();

                            //tbb = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("Text1" + instanceID );

                            khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);

                            Page.Response.Redirect(Page.Request.Url.PathAndQuery);
                            //refresh grid
                            //upGrid.Update();
                        }
                    }


                    protected void btnReplay_Click(object sender, EventArgs e)
                    {
                         Button myButton = (Button)sender;

                        this.Page.Response.Redirect("http://www.google.com/q=" + myButton.ID );
                    }


                    protected void Send_Click(object sender, EventArgs e)
                    {

                        ArrayList item_name = new ArrayList();
                        ArrayList item_value = new ArrayList();

                        item_name.Add("name");
                        item_value.Add(tbName);

                        item_name.Add("email");
                        item_value.Add(tbEmail);

                        item_name.Add("website");
                        item_value.Add(tbWebSite);

                        item_name.Add("memo");
                        item_value.Add(tbMemo.Replace("\r\n", "<BR>"));


                        item_name.Add("type_content");
                        item_value.Add(HttpContext.Current.Items["contentType"].ToString());

                        item_name.Add("id_content");
                        item_value.Add(HttpContext.Current.Items["id"].ToString());

                        item_name.Add("pub_date");
                        item_value.Add(DateTime.UtcNow.ToString());

                        item_name.Add("valid");
                        item_value.Add(false);

                        PmsgOk.Visible = true;
                        Pform.Visible = false;

                        khatam.core.data.sql.Add(item_name, item_value, "comment");


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






                }
            }

        }
    }
}
