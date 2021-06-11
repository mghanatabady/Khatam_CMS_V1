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
                [ToolboxData("<{0}:slider runat=server></{0}:slider>")]
                public class slider : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string windowsMode;
                    public string instanceID;
                    public Boolean winVisible;

                    public bool memo1show;
                    public bool memo2show;
                    public bool memo3show;
                    public bool memo4show;
                    public bool memo5show;
                    public bool memo6show;
                    public bool memo7show;
                    public bool memo8show;
                    public bool memo9show;
                    public bool memo10show;



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

                    public string memo1;
                    public string memo2;
                    public string memo3;
                    public string memo4;
                    public string memo5;
                    public string memo6;
                    public string memo7;
                    public string memo8;
                    public string memo9;
                    public string memo10;
         
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
                              +  "editor.aspx?instanceID=" + instanceID + "&mode=16\",\"_blank\",\" scrollbars=yes, resizable=no, , width=890, height=600\",'child');return false;";
                          this.Controls.Add(btnEdit);
                      }
                         
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));
                        html1();
                        script1();
                        //  html59();
                        //  script59();
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));
                        
                    }

              


            

                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "عنوان", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "محتوا", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo1", "محتوای اسلاید 1", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo1show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo2", "محتوای اسلاید 2", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo2show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo3", "محتوای اسلاید 3", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo3show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo4", "محتوای اسلاید 4", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo4show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo5", "محتوای اسلاید 5", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo5show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo6", "محتوای اسلاید 6", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo6show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo7", "محتوای اسلاید 7", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo7show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo8", "محتوای اسلاید 8", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo8show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo9", "محتوای اسلاید 9", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo9show", "true", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo10", "محتوای اسلاید 10", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo10show", "true", "Core_serverControlsInstanceVal", null);
                        
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }

                    void html1()
                    {

                        //<div style=\"height:230px\" >
                        string html = "  <div class=\"list_carousel\"  > " +
                        "<ul id=\"foo2" + this.UniqueID  +  "\" style=\"direction:ltr\">  ";
                     /*   if (memo1show) html = html + "<li><div style=\"height:230px\" >" + memo1 + "</div></li> ";
                        if (memo2show) html = html + "<li><div style=\"height:230px\" >" + memo2 + "</div></li> ";
                        if (memo3show) html = html + "<li><div style=\"height:230px\" >" + memo3 + "</div></li> ";
                        if (memo4show) html = html + "<li><div style=\"height:230px\" >" + memo4 + "</div></li> ";
                        if (memo5show) html = html + "<li><div style=\"height:230px\" >" + memo5 + "</div></li> ";
                        if (memo6show) html = html + "<li><div style=\"height:230px\" >" + memo6 + "</div></li> ";
                        if (memo7show) html = html + "<li><div style=\"height:230px\" >" + memo7 + "</div></li> ";
                        if (memo8show) html = html + "<li><div style=\"height:230px\" >" + memo8 + "</div></li> ";
                        if (memo9show) html = html + "<li><div style=\"height:230px\" >" + memo9 + "</div></li> ";
                        if (memo10show) html = html + "<li><div style=\"height:230px\" >" + memo10 + "</div></li> ";*/

                        if (memo2show) html = html + "<li>" + memo1 + "</li> ";
                        if (memo2show) html = html + "<li>" + memo2 + "</li> ";
                        if (memo3show) html = html + "<li>" + memo3 + "</li> ";
                        if (memo4show) html = html + "<li>" + memo4 + "</li> ";
                        if (memo5show) html = html + "<li>" + memo5 + "</li> ";
                        if (memo6show) html = html + "<li>" + memo6 + "</li> ";
                        if (memo7show) html = html + "<li>" + memo7 + "</li> ";
                        if (memo8show) html = html + "<li>" + memo8 + "</li> ";
                        if (memo9show) html = html + "<li>" + memo9 + "</li> ";
                        if (memo10show) html = html + "<li>" + memo10 + "</li> ";

                        html = html + "				</ul> " +
"			<div class=\"clearfix\"></div> " +
"<a id=\"prev2" + this.UniqueID + "\" class=\"prev\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_back.gif\" /></a>" +
"<a id=\"play" + this.UniqueID + "\" class=\"play\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_play.gif\" /></a>" +
"<a id=\"pause" + this.UniqueID + "\" class=\"pause\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_pause.gif\" /></a>" +
"<a id=\"next2" + this.UniqueID + "\" class=\"next\" href=\"#\"><img src=\"theme/Flowhub/CssImage/btn/slider_btn_next.gif\" /></a>" +

        //	"<div id=\"pager2\" class=\"pager\"></div> " +
            "</div> ";
                        this.Controls.Add(new LiteralControl(html));

                    }
                    
    

                  void  script1()
                    {
                        string html=" <script type=\"text/javascript\" language=\"javascript\"> " 
                       +"$(document).ready(function () {"
                        + "$(\"#play" + this.UniqueID + "\").hide(); "
                        //+"//	Scrolled by user interaction"
                        + "$('#foo2" + this.UniqueID + "').carouFredSel({ "
                        + "auto: {		timeoutDuration: 4000,delay: 4000 	}, scroll: {  pauseOnHover: true   }, "
                        + "prev: '#prev2" + this.UniqueID + "', "
                        + "next: '#next2" + this.UniqueID + "', "
                        + "pagination: \"#pager2" + this.UniqueID + "\", "
                        +"mousewheel: true, "
                        +"swipe: { "
                        +"onMouse: true,	"
                        + "onTouch: true "
                        +"} "
                        +"}); "
                        + "$(\"#pause" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"pause\"); "
                        + "$(\"#pause" + this.UniqueID + "\").hide(); "
                        + "$(\"#play" + this.UniqueID + "\").show(); "
                        +"});"
                        + "$(\"#play" + this.UniqueID + "\").click(function () { "
                        + "$(\"#foo2" + this.UniqueID + "\").trigger(\"play\"); "
                        + "$(\"#play" + this.UniqueID + "\").hide() ;"
                        + "$(\"#pause" + this.UniqueID + "\").show(); "
                        +"});"
                        +" }); </script>";

   
   
		
	

                  
                        
                        this.Controls.Add(new  LiteralControl(html));

                    }

    
                 


                }
            }

        }
    }
}
