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
                [ToolboxData("<{0}:TreeCat runat=server></{0}:TreeCat>")]
                public class TreeCat : CompositeControl
                {
                    public event EventHandler SubmitHandler;

                    public bool CpMode;

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

                    protected override void CreateChildControls()
                    {
                        Panel RootPanel = new Panel();

                       
                        TreeView OtreeView = new TreeView();
                        TreeNodeBinding OtreeNodeBinding = new TreeNodeBinding();

                        OtreeNodeBinding.TextField = "title";
                        OtreeNodeBinding.NavigateUrlField = "url";
                        
                        OtreeView.CssClass = "TreeCat";


                       
                        //TreeNodeBinding;
                        //OtreeNode.Text = "ssssssss";
                        //OtreeView.Nodes.Add(OtreeNode);
                        XmlDataSource OXmlDataSource = new XmlDataSource();


                        string contentTable="news";
                        string str_content="news";

                        try
                        {
                            str_content = this.Parent.Page.ToString().Replace("ASP.", "").Replace("_aspx", "").Replace("_item", "");
                        }
                        catch
                        {
                        }


                
                        try
                        {
                            contentTable = HttpContext.Current.Items["contentType"].ToString();
                        }
                        catch
                        {

                        }


                        if (str_content != "layout")
                        {
                            OXmlDataSource.Data = getxml_str(contentTable, "فارسی");
                            OXmlDataSource.EnableCaching = false;

                            OtreeView.DataBindings.Add(OtreeNodeBinding);
                            OtreeView.NodeIndent = 5;
                            OtreeView.ExpandDepth = 1;
                            OtreeView.Font.Size  = FontUnit.Point(9) ;
                            OtreeView.DataSource = OXmlDataSource;
                            OtreeView.DataBind();
                            RootPanel.Controls.Add(new LiteralControl("<div dir=\"rtl\" >"));

                            RootPanel.Controls.Add(OtreeView);

                            RootPanel.Controls.Add(new LiteralControl("</div>"));
                        
                        }
                        else
                        {
                            RootPanel.Controls.Add(new LiteralControl("دسته بندی محتوا"));
                        }



                        string skin = "sina";
                     
                        string WidthMenu = "180";
                      //  this.Controls.Add(RootPanel);

                       // this.Controls.Add(new LiteralControl("<div class=\"RadMenu_" + skin + "_widebackground\" style=\"\">"));
                     //   this.Controls.Add(new LiteralControl("<div class=\"RadMenu_" + skin + "_widebackground2\" style=\"width:" + WidthMenu + "px;\">"));
                     ///   Telerik.WebControls.RadMenu Oradmenu = new Telerik.WebControls.RadMenu();
                     ///   Oradmenu.ID = "RadMenuO";
                     ///   Oradmenu.Attributes.Add("dir", "rtl");
                     ///   Oradmenu.Skin = skin;
                    ///    Oradmenu.Flow = Telerik.WebControls.ItemFlow.Vertical;
                      

                        // Oradmenu.SkinsPath = this.Page.Server.MapPath(@"~\radcontrols\menu\skins222");
                      ///  Oradmenu.Width = System.Web.UI.WebControls.Unit.Pixel(Int32.Parse(WidthMenu));
                        //System.Web.UI.WebControls.Unit.Percentage(100);
                        //System.Web.UI.WebControls.Unit.Pixel(Int32.Parse(WidthMenu));// Percentage(100);
                     ///   Oradmenu.LoadXmlString(getxml_str());
                     //###make option rad and tree   this.Controls.Add(Oradmenu);
                    
                        this.Controls.Add(RootPanel );


                    }



                    void Submit_Click(object sender, EventArgs e)
                    {
                        if (SubmitHandler != null)
                            SubmitHandler(this, e);

                    }


                    string getxml_str(string type_content, string language)
                    {
                        int c=0;
                        int order_id;
                        ArrayList a = new ArrayList();
                        DataTable dt = new DataTable();
                        // 'Context.Response.Clear()
                        // 'Context.Response.ContentType = "text/xml"
                        // 'Dim objX As New XmlTextWriter(Context.Response.OutputStream, Encoding.UTF8)
                        StringWriter stringWriter22 = new StringWriter();
                        XmlTextWriter objX = new XmlTextWriter(stringWriter22);
                        objX.WriteStartDocument();
                        // objX.WriteStartElement("siteMap")
                        // objX.WriteAttributeString("xmlns", "http://schemas.microsoft.com/AspNet/SiteMap-File-1.0")
                        // Dim objConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("Khatam_site").ConnectionString)
                        // objConnection.Open()
                        // Dim sql As String = "SELECT     id,cname,height     FROM         Cat   ORDER BY height, sortid"
                        // Dim objCommand As New SqlCommand(sql, objConnection)
                        // Dim objReader As SqlDataReader = objCommand.ExecuteReader()
                        // ------------------
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        // parameters.Add(field_where, field_where_value)
                        // parameters.Add("enable", enable)
                        string type_content_fa;
                        string sortid;
                        
                        // Context.Request.QueryString("type_content")
                        type_content_fa = type_content;
                        // Context.Request.QueryString("type_content")
                        language = "فارسی";
                        switch (type_content)
                        {
                            case "article":
                            case "Article":
                                type_content_fa = "مقالات";
                                break;
                            case "news":
                            case "News":
                                type_content_fa = "اخبار";
                                break;
                            case "service":
                                type_content_fa = "خدمات";
                                break;
                            case "software":
                                type_content_fa = "نرم افزار";
                                break;
                            case "shop":
                                type_content_fa = "فروشگاه";
                                break;
                            case "link":
                                type_content_fa = "پیوند ها";
                                break;
                            case "portal":
                                type_content_fa = "پرتال ها";
                                break;
                            case "help":
                            case "Help":
                                type_content_fa = "راهنما";
                                break;
                            case "clip":
                            case "Clip":
                                type_content_fa = "کلیپ";
                                break;
                            case "picture":
                            case "Picture":
                                type_content_fa = "تصاویر";
                                break;
                            case "menu":
                                language = "منوی اصلی";
                                break;
                            case "library":
                                type_content_fa = "کتابخانه";
                                break;
                            case "sample_exam":
                                type_content_fa = "نمونه سوالات";
                                break;
                            case "car":
                                type_content_fa = "خودروها";
                                break;
                        }
                        sortid = Sql_get_sortid(type_content, language, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        //##sortid = "#.1.2";
                        str_sql = ("SELECT     id, cname, height, orderid, type_content    FROM         Cat     WHERE     (Cat.sortid LIKE" +
                        " N\'%"
                                    + (sortid + "%\')  and (type=1)   ORDER BY sortid"));
                        dt = DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                        int i;
                        int j;
                        for (i = 0; (i
                                    <= (dt.Rows.Count - 1)); i++)
                        {
                            objX.WriteStartElement("item");
                            // objX.WriteElementString("title", objReader.GetString(0))
                            // a.Add(objReader.GetValue(2))
                            c = (c + 1);
                            // Dim height_prev As Integer
                            if ((i == 0))
                            {
                                objX.WriteAttributeString("title", type_content_fa);
                                objX.WriteAttributeString("url", khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" +
                                                 type_content + "/?cat="
                                                + dt.Rows[i].ItemArray[0] + ("&title=" + dt.Rows[i].ItemArray[1].ToString().Replace(" ", "-").Replace(":", "")));
                            }
                            else
                            {
                                objX.WriteAttributeString("title", dt.Rows[i].ItemArray[1].ToString());
                                objX.WriteAttributeString("url", khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/" +
                                                 type_content + "/?cat="
                                                + dt.Rows[i].ItemArray[0] + ("&title=" + dt.Rows[i].ItemArray[1].ToString().Replace(" ", "-").Replace(":", "")));
                            }
                            objX.WriteAttributeString("description", "a");
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
                        objX.WriteEndElement();
                        objX.WriteEndDocument();
                        objX.Flush();
                        objX.Close();
                        // Context.Response.End()
                        // Extra Class
                        return stringWriter22.ToString();
                    }

                    private string getxml_str()
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

                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        string type_content;

                        string language;
                        string sortid;
                        type_content = "news";

                        language = "فارسی";
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
                                        objX.WriteAttributeString("Href", khatam.core.data.sql.getField("link", "id", dt.Rows[i].ItemArray[5].ToString(), "menu"));
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

                    public static string Sql_get_sortid(string table, string language, string ConnectionString)
                    {
                        string str_sql;
                        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                        parameters.Add("cname", language);
                        parameters.Add("type_content",  table);
                      
                        str_sql = "SELECT     sortid   FROM         Cat   WHERE     (cname = @cname) AND (type_content = @type_content)";
                        return DBFunctions.ExecuteScaler(str_sql, parameters,  System.Data.CommandType.Text, ConnectionString).ToString();
                    }
                }
            }
        }
    }
}
