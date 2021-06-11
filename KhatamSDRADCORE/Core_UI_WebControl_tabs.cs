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
                [ToolboxData("<{0}:tabs runat=server></{0}:tabs>")]
                public class tabs : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string windowsMode;
                    public string instanceID;
                    public Boolean winVisible;

                    public string tab1InstanceID;
                    public string tab2InstanceID;
                    public string tab3InstanceID;
                    public string tab4InstanceID;
                    public string tab5InstanceID;
                    public string tab6InstanceID;
                    public string tab7InstanceID;
                    public string tab8InstanceID;
                    public string tab9InstanceID;
                    public string tab10InstanceID;

                    public string theme;

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
                              +  "editor.aspx?instanceID=" + instanceID + "&mode=26\",\"_blank\",\" scrollbars=yes, resizable=no, , width=890, height=600\",'child');return false;";
                          this.Controls.Add(btnEdit);
                      }
                         
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));



                        this.Controls.Add(new LiteralControl(" <div class=\"Otabs" + this.UniqueID  +  "\" >"));
                        if (tab1InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab1" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField("propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab1InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab2InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab2" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab2InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab3InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab3" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab3InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }


                        if (tab4InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab4" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab4InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab5InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab5" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab5InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab6InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab6" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab6InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab7InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab7" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField("propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab7InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab8InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab8" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab8InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab9InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab9" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab9InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                        if (tab10InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl("      <a href='#tab10" + this.UniqueID + "' >"));
                            this.Controls.Add(new LiteralControl("          <div class=\"WinTab1t_tb\" style=\" width:auto; float:right ; \"><div class=\"WinTab1b_tb\"><div class=\"WinTab1l_tb\"><div class=\"WinTab1r_tb\"><div class=\"WinTab1bl_tb\"><div class=\"WinTab1br_tb\"><div class=\"WinTab1tl_tb\"><div class=\"WinTab1tr_tb\">"));
                            this.Controls.Add(new LiteralControl(khatam.core.data.sql.getField( "propertyValue", "propertyTitle", "title", "id_Core_ServerControlsInstance", tab10InstanceID, "Core_serverControlsInstanceVal")));
                            this.Controls.Add(new LiteralControl("          </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("     </a>"));
                        }

                      

                        this.Controls.Add(new LiteralControl( " <div style=\"clear:both\"></div>"));
                        this.Controls.Add(new LiteralControl( " </div>"));

                        if (tab1InstanceID != "0")
                       {
                           this.Controls.Add(new LiteralControl(" <div id='tab1" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab1InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab1InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab2InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab2" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));

                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab2InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab2InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab3InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab3" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab3InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab3InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab4InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab4" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab4InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab4InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab5InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab5" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab5InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab5InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab6InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab6" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab6InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab6InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab7InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab7" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab7InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab7InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab8InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab8" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab8InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab8InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab9InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab9" + this.UniqueID + "''>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField( "id_core_serverControl", "id", tab9InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab9InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        if (tab10InstanceID != "0")
                        {
                            this.Controls.Add(new LiteralControl(" <div id='tab10" + this.UniqueID + "'>"));
                            this.Controls.Add(new LiteralControl(" <div class=\"WinTab1t\"><div class=\"WinTab1b\"><div class=\"WinTab1l\"><div class=\"WinTab1r\"><div class=\"WinTab1bl\"><div class=\"WinTab1br\"><div class=\"WinTab1tl\"><div class=\"WinTab1tr\">"));
                            //this.Controls.Add(new LiteralControl( "	<h3>Section 1</h3>"));
                            //this.Controls.Add(new LiteralControl( "	<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec lobortis placerat dolor id aliquet. Sed a orci in justo blandit commodo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae.</p>"));
                            string id_core_serverControl = khatam.core.data.sql.getField("id_core_serverControl", "id", tab10InstanceID, "Core_serverControlsInstance");
                            this.Controls.Add(khatam.core.UI.ObjectManager.ControlsDic(id_core_serverControl, tab10InstanceID, "1", editMode, true, theme));
                            this.Controls.Add(new LiteralControl(" </div></div></div></div></div></div></div></div>"));
                            this.Controls.Add(new LiteralControl("	</div>"));
                        }

                        string html = " <script type=\"text/javascript\">"
                            + " $(document).ready(function () {"
                            + " $('.Otabs" + this.UniqueID + "').each(function () {"
                           // + " // For each set of tabs, we want to keep track of"
                         //   + " // which tab is active and it's associated content"
                            + " var $active, $content, $links = $(this).find('a');"
                        //    + " // If the location.hash matches one of the links, use that as the active tab."
                        //    + " // If no match is found, use the first link as the initial active tab."
                            + " $active = $($links.filter('[href=\"' + location.hash + '\"]')[0] || $links[0]);"
                            + " $active.addClass('active');"
                            + " $content = $($active.attr('href'));"
                      //      + " // Hide the remaining content"
                            + " $links.not($active).each(function () {"
                            + " $($(this).attr('href')).hide();"
                            + " });"
                        //    + " // Bind the click event handler"
                            + " $(this).on('click', 'a', function (e) {"
                          //  + " // Make the old tab inactive."
                //            + " //alert($(this).find('.winTabActive1t_tb').attr('class'));"
                  //          + " //$(this).find('.winTabActive1t_tb').removeClass();"
                            + " $active.removeClass('active');"
                            + " $content.hide();"
                    //        + " // Update the variables with the new link and content"
                            + " $active = $(this);"
                            + " $content = $($(this).attr('href'));"
                      //      + " // Make the tab active."
                            + " $active.addClass('active');"
                            + " $content.fadeIn();"
                        //    + " // Prevent the anchor's default click action"
                            + " e.preventDefault();"
                            + " });"
                            + " });"
                            + ""
                            + " });"
                            + " </script>";

                         this.Controls.Add(new LiteralControl(html ));


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));

                    }

                  
                   
                

                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);

                        khatam.core.data.sql.addPropertyRow(Instance, "tab1InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab2InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab3InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab4InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab5InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab6InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab7InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab8InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab9InstanceID", "0", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "tab10InstanceID", "0", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }




                 


                 


                }
            }

        }
    }
}
