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
                [ToolboxData("<{0}:linkToUs runat=server></{0}:linkToUs>")]
                public class linkToUs : CompositeControl
                {

                    //decleare 

                    //********* edit mode
                    public bool editMode;
                    public bool Demo;
                    public string windowsMode;
                    public string instanceID;
                    public Boolean winVisible;

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
                          btnEdit.OnClientClick = "child=window.open(\"" + khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "editor.aspx?instanceID=" + instanceID + "&mode=8\",\"_blank\",\" scrollbars=yes, resizable=no, , width=890, height=600\",'child');return false;";
                          this.Controls.Add(btnEdit);
                      }                    
                        
                         
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagTitleOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(title));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagTitleClose(windowsMode)));
                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getWinTagcontentOpen(windowsMode)));
                        this.Controls.Add(new LiteralControl(memo));

                        string siteUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath;

                        string Logo = khatam.core.data.sql.getBaseSetting("logo", "0");
                        string titleSite = khatam.core.data.sql.getBaseSetting("Title", "1");
                        string domainName = khatam.core.ConfigurationManager.License.domainsArr[0];

                        string LogoPathAndFile;

                        if (Logo == "")
                        {
                            LogoPathAndFile = siteUrl + "theme/Flowhub/CssImage/Element/no_photo2.jpg";
                        }
                        else
                        {
                            LogoPathAndFile = Logo;
                        }

                        string html = "<div align=\"center\">"
+ " <img src=\"" + LogoPathAndFile + "\" /><br />"
+ " <input id=\"Text1\" dir=\"ltr\" readonly=\"readonly\" style=\"width: 120px\" type=\"text\""
+ " value='<a href=\"http://www." + domainName + "\"><img src=\"" + LogoPathAndFile + "\"  alt=\"" + titleSite + " " + domainName +
"\" border=\"0\"></a>' /><br />"
+ " و یا به صورت متن<br />"
+ " <input id=\"Text2\" dir=\"ltr\" readonly=\"readonly\" style=\"width: 120px; font-size: 9pt; font-family: tahoma;\" type=\"text\""
+ " value='<a title=\"" + titleSite + " " + domainName + "\" href=\"http://www." + domainName + "/\">" + titleSite + "</a>' /><br />"
+ " <br />"
+ " </div>";
                        this.Controls.Add(new LiteralControl(html));


                        this.Controls.Add(new LiteralControl(khatam.core.Drawing.windows.getwinTagContentClose(windowsMode)));

                        if (editMode) this.Controls.Add(new LiteralControl("</div>"));
                        
                    }

                  
                   
                

                    public string addInstanceProperty(string Instance)
                    {

                        khatam.core.data.sql.addPropertyRow(Instance, "title", "لینک به ما", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "memo", "", "Core_serverControlsInstanceVal", null);
                        khatam.core.data.sql.addPropertyRow(Instance, "windowsMode", "win1", "Core_serverControlsInstanceVal", null);


                        return "added";
                    }




                 


                 


                }
            }

        }
    }
}
