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
                [ToolboxData("<{0}:seacrhWin runat=server></{0}:seacrhWin>")]
                public class seacrhWin : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string  theme;

                    public event EventHandler SubmitHandler;

                    public event EventHandler SaveHandler2;
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

                    //    FredCK.FCKeditorV2.FCKeditor f = new FredCK.FCKeditorV2.FCKeditor();
                //        f.BasePath = "~/fckeditor/";
                  //      f.Height = 400;
                    //    f.Value = memo;
                      //  f.AutoDetectLanguage = false;
                 //       f.ContentLangDirection = FredCK.FCKeditorV2.LanguageDirection.RightToLeft;
                   //     f.DefaultLanguage = "fa";

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
                        btn1.Click += new EventHandler(Submit_Click2);

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

                        if (editMode) this.Controls.Add(new LiteralControl("<div class=\"ve_div\">"));


                        if (editMode)
                        {
                            ImageButton btnEdit = new ImageButton();
                            btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                            btnEdit.OnClientClick = "child=window.open(\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "editor.aspx?instanceID=" + instanceID + "&mode=8\",\"_blank\",\" scrollbars=yes, resizable=no, , width=890, height=600\",'child');return false;";
                            this.Controls.Add(btnEdit);
                        }


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));

                        ///if lang

                        this.Controls.Add(new LiteralControl("<div style=\"width:100%; display:block;overflow: auto \">"));

                        /**************** mode 2 *************************
                        this.Controls.Add(new LiteralControl("<div dir=\"rtl\" style=\"float:right\">"));
                        this.Controls.Add(new LiteralControl(memo));
                        this.Controls.Add(new LiteralControl("</div>"));


                        /*************************
                        //this.Controls.Add(new LiteralControl("<div style=\"margin:0 auto; width:100%; text-align: center; \" >"));
                        this.Controls.Add(new LiteralControl("<div dir=\"rtl\" style=\"margin:25px 0px 0px 0px;float:left  \" >"));
                        TextBox tb = new TextBox();
                        tb.ID = "txtSearch";
                        tb.Font.Name = "tahoma";
                        tb.Font.Size = FontUnit.Point(12);
                        tb.Width = 175;
                        this.Controls.Add(tb);
                        this.Controls.Add(new LiteralControl("  "));
                        ImageButton ibnt1 = new ImageButton();
                        ibnt1.ImageUrl = "theme/" + theme  + "/cssimage/btn/searchBtn.gif";
                        ibnt1.Click += new ImageClickEventHandler(btnSearch_Click);
                        this.Controls.Add(ibnt1);
                        this.Controls.Add(new LiteralControl("</div>"));
                        /**************************

                        this.Controls.Add(new LiteralControl("</div>"));
                        ************end mode 1**/
                        /*****************mode def ************/

                        this.Controls.Add(new LiteralControl(memo));

                        this.Controls.Add(new LiteralControl("<div style=\"margin:0 auto; width:100%; text-align: center; \" >"));


                        //this.Controls.Add(new LiteralControl("<div style=\" \">"));

                        TextBox tb = new TextBox();
                        tb.ID = "txtSearch";
                        tb.Font.Name = "tahoma";
                        tb.Font.Size = FontUnit.Point(23);
                        tb.Width = 400;

                        this.Controls.Add(tb);
                        this.Controls.Add(new LiteralControl("  "));
                        //this.Controls.Add(new LiteralControl("</div>"));


                        // this.Controls.Add(new LiteralControl("<div style=\" \">"));

                        ImageButton ibnt1 = new ImageButton();
                        ibnt1.ImageUrl = "theme/Flowhub/cssimage/btn/searchBtn.gif";
                        ibnt1.Click += new ImageClickEventHandler(btnSearch_Click);

                        this.Controls.Add(ibnt1);
          


                        this.Controls.Add(new LiteralControl("</div>"));


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));





                     



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



                            //FredCK.FCKeditorV2.FCKeditor ff2 = new FredCK.FCKeditorV2.FCKeditor();
                            //ff2 = (FredCK.FCKeditorV2.FCKeditor)FindControl("fck" + instanceID);


                            //fck.ID = "fck" + instanceID;

                            System.Web.UI.HtmlControls.HtmlInputText tbb = new System.Web.UI.HtmlControls.HtmlInputText();

                            //tbb = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("Text1" + instanceID );

                            khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);

                            Page.Response.Redirect(Page.Request.Url.PathAndQuery);
                            //refresh grid
                            //upGrid.Update();
                        }
                    }



                    protected void btnSearch_Click(object sender, EventArgs e)
                    {

                        TextBox _tb = new TextBox();
                        _tb = (TextBox)FindControl("txtSearch");
                            Page.Response.Redirect("/web/search/?q=" + _tb.Text );
                            //refresh grid
                            //upGrid.Update();
                        
                    }


                    private void CloseDialog(string dialogId)
                    {
                        string script = string.Format(@"closeDialog('{0}')", dialogId);
                        ///ScriptManager.RegisterClientScriptBlock(this, typeof(Page), UniqueID, script, true);
                    }


                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal",null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "searchBoxMode", "1", "Core_serverControlsInstanceVal", null);

                        return "added";
                    }




         

                }
            }

        }
    }
}
