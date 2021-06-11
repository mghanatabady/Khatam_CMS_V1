using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;

namespace khatam
{
    namespace core
    {
        namespace UI
        {
            namespace WebControls
            {
                [DefaultProperty("Text")]
                [ToolboxData("<{0}:Menu runat=server></{0}:Menu>")]
                public class Menu : CompositeControl
                {


                    //********* edit mode
                    public bool editMode;
                    public bool Demo;

                

                    public string WidthMenu;
                    public string skin;
                    public string instanceID;


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


                    protected override void CreateChildControls()
                    {
                        
                        if (editMode) this.Controls.Add(new LiteralControl("<div class=\"ve_div\">"));
                        

                        if (editMode)
                        {
                            ImageButton btnEdit = new ImageButton();
                            btnEdit.ImageUrl = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + @"core/themeCP/Bitrix/CssImage/btn/edit.gif";
                            btnEdit.OnClientClick = "child=window.open(\"editor.aspx?instanceID=" + instanceID + "\",\"_blank\",\" scrollbars=yes, resizable=no, , width=825, height=600\",'child');return false;";
                            this.Controls.Add(btnEdit);
                        }


                        //if (editMode) this.Controls.Add(new LiteralControl(khatam.core.Drawing.EditorWin.EditBorderOpen(instanceID, "none")));
                        this.Controls.Add(new LiteralControl("<div class=\"RadMenu_" + skin + "_widebackground\" style=\"\">"));
                        this.Controls.Add(new LiteralControl("<div class=\"RadMenu_" + skin + "_widebackground2\" style=\"width:" + WidthMenu + "px;\">"));
                        Telerik.WebControls.RadMenu Oradmenu = new Telerik.WebControls.RadMenu();
                        Oradmenu.ID = "RadMenuO";
                        Oradmenu.Attributes.Add("dir", "rtl");
                        Oradmenu.Skin = skin;
                  
                        
                       // Oradmenu.SkinsPath = this.Page.Server.MapPath(@"~\radcontrols\menu\skins222");
                        Oradmenu.Width = System.Web.UI.WebControls.Unit.Pixel(Int32.Parse(WidthMenu));
                            //System.Web.UI.WebControls.Unit.Percentage(100);
                            //System.Web.UI.WebControls.Unit.Pixel(Int32.Parse(WidthMenu));// Percentage(100);
                        Oradmenu.LoadXmlString(getxml_str());
                        this.Controls.Add(Oradmenu);
                        this.Controls.Add(new LiteralControl("</div>"));
                        /*eeee*/
                        this.Controls.Add(new LiteralControl("</div>"));
                        //if (editMode) this.Controls.Add(new LiteralControl("</div>"));
                        //if (editMode) this.Controls.Add(new LiteralControl("</div>"));

                        //if (editMode) this.Controls.Add(new LiteralControl(khatam.core.Drawing.EditorWin.EditPopupScript(instanceID)));
                        //if (editMode) this.Controls.Add(editwinpop());


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

                            //khatam.core.data.sql.InstanceValSet(instanceID, "Width", txtBoxValue2);
                            khatam.core.data.sql.InstanceValSet(instanceID, "Width",   txtBoxValue2 );

                            DropDownList ODDLwin = new DropDownList();

                            ODDLwin = (DropDownList)FindControl("DDLwin" + instanceID);

                            khatam.core.data.sql.InstanceValSet(instanceID, "skin", ODDLwin.SelectedValue);



                            //fck.ID = "fck" + instanceID;

                            System.Web.UI.HtmlControls.HtmlInputText tbb = new System.Web.UI.HtmlControls.HtmlInputText();

                            //tbb = (System.Web.UI.HtmlControls.HtmlInputText)FindControl("Text1" + instanceID );

                            //khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);
                            ///khatam.core.data.sql.InstanceValSet(instanceID, "memo", texthf);

                            Page.Response.Redirect(Page.Request.Url.PathAndQuery);
                           
                            //refresh grid
                            //upGrid.Update();
                        }
                    }


                  private    string getxml_str()
                    {
                        int order_id;
                        ArrayList a = new ArrayList();
                        DataTable dt = new DataTable();
                        // context.Response.Clear()
                        // context.Response.ContentType = "text/xml"
                        // StringWriter stringWriter = new StringWriter();
                        // XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
                        // xmlWriter.WriteStartElement("gods");
                        // xmlWriter.WriteElementString("god", "Kibo");
                        // xmlWriter.WriteEndElement();
                        // xmlWriter.Close();
                        // Console.WriteLine(stringWriter.ToString());
                        StringWriter stringWriter22 = new StringWriter();
                        XmlTextWriter objX = new XmlTextWriter(stringWriter22);
                        // Dim objX As New XmlTextWriter(Server.MapPath("manage/xmlfile3.xml"), Encoding.UTF8)
                        objX.WriteStartDocument();
                        // objX.WriteStartElement("siteMap")
                        // objX.WriteAttributeString("xmlns", "http://schemas.microsoft.com/AspNet/SiteMap-File-1.0")
                        // ------------------
                        string str_sql;
                        
                        Dictionary<string,object> parameters = new System.Collections.Generic.Dictionary<string,object>();
                        
                        string type_content;
                        
                        string language;
                        string sortid;
                        type_content = "Menu";
                        
                        language = "منوی اصلی";
                        sortid = Sql_get_sortid(type_content, language, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        // str_sql = "SELECT     id, cname, height, orderid, type_content    FROM         Cat     WHERE     (Cat.sortid LIKE N'%" & sortid & "%') and (Cat.sortid <> N'" & sortid & "')  and (type=1)   ORDER BY sortid"
                        str_sql = ("SELECT     id, cname, height, orderid, type_content , id_content,type   FROM         Cat     WHERE   " +
                        "  (Cat.sortid LIKE N\'%"
                                    + (sortid + "%\')     ORDER BY sortid"));
                        dt = DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        int i;
                        int j;
                        for (i = 0; (i
                                    <= (dt.Rows.Count - 1)); i++)
                        {
                            if ((i == 0))
                            {
                                objX.WriteStartElement("Menu");
                            }
                            else
                            {
                                objX.WriteStartElement("Item");
                                try
                                {
                                    if ((dt.Rows[i].ItemArray[6].ToString() == "2"))
                                    {
                                        objX.WriteAttributeString("Href",  khatam.core.data.sql.getField("link", "id", dt.Rows[i].ItemArray[5].ToString(), "menu"));
                                    }
                                }
                                //catch (Exception ex)
                                catch 
                                {
                                }
                                objX.WriteAttributeString("Text", dt.Rows[i].ItemArray[1].ToString());
                                // objX.WriteAttributeString("description", "a")
                            }
                            // objX.WriteElementString("title", objReader.GetString(0))
                            // a.Add(objReader.GetValue(2))
                            // Dim height_prev As Integer
                            // url="" title=""  description=""
                            // objX.WriteElementString("description", objReader.GetString(1))
                            // objX.WriteElementString("link", "http://www.uberasp.net/GetArticle.aspx?id=" + objReader.GetInt32(2).ToString())
                            // objX.WriteElementString("pubDate", objReader.GetDateTime(3).ToString("R"))
                            if ((i
                                        != (dt.Rows.Count - 1)))
                            {
                                if (((int)dt.Rows[i].ItemArray[2] < (int)dt.Rows[(i + 1)].ItemArray[2]))
                                {
                                    // ����
                                }
                                else
                                {
                                    // ����
                                    if (((int)dt.Rows[i].ItemArray[2] > (int)dt.Rows[(i + 1)].ItemArray[2]))
                                    {
                                        for (j = (int)dt.Rows[(i + 1)].ItemArray[2]; (j
                                                    <= ((int)dt.Rows[i].ItemArray[2] - 1)); j++)
                                        {
                                            objX.WriteEndElement();
                                        }
                                    }
                                    objX.WriteEndElement();
                                }
                            }
                            order_id = (int)dt.Rows[i].ItemArray[2];
                        }
                        // objReader.Close()
                        // objConnection.Close()
                        // objX.WriteEndElement()
                        objX.WriteEndDocument();
                        objX.Flush();
                        objX.Close();
                        // context.Response.End()
                        return stringWriter22.ToString();
                    }

                  private static string Sql_get_sortid(string table, string language, string ConnectionString)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        parameters.Add("cname", language);
                        parameters.Add("type_content", table);
                        str_sql = "SELECT     sortid   FROM         Cat   WHERE     (cname = @cname) AND (type_content = @type_content)";

                        return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text , ConnectionString).ToString();
                    }


                  public  string addInstanceProperty(string Instance)
                  {


                      khatam.core.data.sql.addPropertyRow(Instance, "skin", "Mac", "Core_serverControlsInstanceVal",null);
                      khatam.core.data.sql.addPropertyRow(Instance, "Width", "974", "Core_serverControlsInstanceVal", null);
                      

                      return "added";
                  }


                  public Panel editwinpop()
                  {
                      //div edit
                      // if (state)  this.Controls.Add(new LiteralControl("</div>"));

                      Panel panel1 = new Panel();


                      panel1.Controls.Add(new LiteralControl("<div id=\"newPerson" + instanceID + "\">"));

       




                      //************** row title
                      panel1.Controls.Add(new LiteralControl("<div style=\"float:right ; text-align:left ; margin-left:10px ; \">"));

                      panel1.Controls.Add(new LiteralControl("<div style=\"float:right ; width:200px ;text-align:left ; margin-left:10px \">"));
                      panel1.Controls.Add(new LiteralControl("پهنا"));
                      panel1.Controls.Add(new LiteralControl("</div>"));

                      panel1.Controls.Add(new LiteralControl("<div style=\" float:right ; direction:rtl;  \">"));

                      TextBox txtNewName = new TextBox();
                      txtNewName.ID = "txtbox" + instanceID;
                      txtNewName.Text = WidthMenu;
                      txtNewName.Width = 250;
                      panel1.Controls.Add(txtNewName);
                      panel1.Controls.Add(new LiteralControl("</div>"));

                      panel1.Controls.Add(new LiteralControl("</div>"));


                      //************** row winmode
                      panel1.Controls.Add(new LiteralControl("<div style=\"float:right ; text-align:left ; margin-left:10px ; \">"));

                      panel1.Controls.Add(new LiteralControl("<div style=\"float:right ; width:200px ;text-align:left ; margin-left:10px \">"));
                      panel1.Controls.Add(new LiteralControl("theme"));
                      panel1.Controls.Add(new LiteralControl("</div>"));

                      panel1.Controls.Add(new LiteralControl("<div style=\" float:right ; direction:rtl;  \">"));



                     // if (Page.IsPostBack == false)
                     // {
                      DirectoryInfo StoreFile = new DirectoryInfo(Page.Server.MapPath("~/radcontrols/menu/skins/"));
                          DirectoryInfo[] fi;//= new FileInfo("sssssssss");



                          //Dim StoreFile As System.IO.Directory


                          //Dim Files As String()
                          //Dim File As String


                          fi = StoreFile.GetDirectories();

                          DropDownList DDLwin = new DropDownList();
                          DDLwin.ID = "DDLwin" + instanceID;

                          foreach (var item in fi)
                          {
                              ListItem li = new ListItem();
                              li.Text = item.ToString();
                              DDLwin.Items.Add(li);
                          }

                      //}



                          DDLwin.SelectedValue = skin;

 

                    ///  DDLwin.SelectedValue = windowsMode;

                      panel1.Controls.Add(DDLwin);
                      panel1.Controls.Add(new LiteralControl("</div>"));

                      panel1.Controls.Add(new LiteralControl("</div>"));


                      //**************** button Row
                      panel1.Controls.Add(new LiteralControl("<div style=\" ; text-align:right ; margin-left:10px ;\">"));

                      //Button btnc = new Button();
                      //btnc.ID = "Buttonc1";
                      //btnc.Text = "انصراف";
                      //btnc.BorderStyle = System.Web.UI.WebControls.BorderStyle.None;
                      //btnc.OnClientClick = "test" + instanceID + "()";
                      //btnc.Click += new EventHandler(btnAddSave_Click);
                      //this.Controls.Add(btnc);


                      Button btnnew = new Button();
                      btnnew.ID = "Button1";
                      btnnew.Text = "تایید";
                      btnnew.BorderStyle = System.Web.UI.WebControls.BorderStyle.None;
                      if (Demo != true)
                      {

                          btnnew.OnClientClick = "test" + instanceID + "()";
                          btnnew.Click += new EventHandler(btnAddSave_Click);
                      }
                      else
                      {
                          btnnew.Enabled = false;
                          btnnew.ToolTip = "در نسخه دمو امکان تغییر وجود ندارد";
                      }
                      panel1.Controls.Add(btnnew);

                      panel1.Controls.Add(new LiteralControl("</div>"));



                      //<asp:Button ID="Button1" runat="server" onclick="Button1_Click" OnClientClick="test()" Text="Button" />




                      //this.Controls.Add(btn);


                      panel1.Controls.Add(new LiteralControl("</div>"));

                      return panel1;
                  }

                  private void CloseDialog(string dialogId)
                  {
                      string script = string.Format(@"closeDialog('{0}')", dialogId);
                      ///ScriptManager.RegisterClientScriptBlock(this, typeof(Page), UniqueID, script, true);
                  }



                }
            }
        }
    }
}
