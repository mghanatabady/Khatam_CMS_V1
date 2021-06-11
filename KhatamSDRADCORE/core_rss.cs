using System;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Web.Configuration;


public class rss : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {


        string type_content = "", type_content_fa;
        try
        {
            type_content = context.Request.QueryString["type"].ToString();

        }
        catch
        {
            type_content = "";
        }

        string domain_str, Title_fa_str;

        domain_str = khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir();
            
        
        Title_fa_str = khatam.core.data.sql.getBaseSetting("Title", "1");

        if (type_content == "")
            type_content_fa = "";
        else
            type_content_fa = " || " + khatam.core.data.sql.getTranslate(type_content, "1");



        context.Response.Clear();
        context.Response.ContentType = "text/xml";
        //Dim objX As New XmlTextWriter(context.Response.OutputStream, Encoding.UTF8)
        XmlTextWriter objX = new XmlTextWriter(context.Response.OutputStream, Encoding.UTF8);
        objX.WriteStartDocument();
        objX.WriteStartElement("rss");
        objX.WriteAttributeString("version", "2.0");
        objX.WriteStartElement("channel");
        objX.WriteElementString("title", Title_fa_str + type_content_fa);
        objX.WriteElementString("link", "http://www." + domain_str + "/web/" + type_content);
        objX.WriteElementString("description", type_content_fa);
        objX.WriteElementString("copyright", domain_str);
        objX.WriteElementString("ttl", "5");
        SqlConnection objConnection = new SqlConnection(khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        objConnection.Open();

        string sql, sql_base = "";
        sql_base = " SELECT DISTINCT top(20) #.title, #.description, #.id, #.pub_date, #.update_date, Cat.id_content, Cat.type_content , Cat.id as catid  " +
" FROM         # INNER JOIN " +
                 " Cat ON #.id = Cat.id_content " +
" WHERE     (Cat.type_content = N'#') AND (#.Enable = 1) AND (cat.valid=1 ) AND (cat.deleted<>1 )";

        if (type_content != "")
        {
            //sql = "SELECT     TOP (20) title, description, id, pub_date,update_date   FROM  " + type_content + "   WHERE     (Enable = 1) ORDER BY id DESC";


            sql = sql_base.Replace("#", type_content);
        }
        else
        {

            string[] content_type_Arr = khatam.core.explorer.content_type_Arr;
            sql = "";
            //    string type_content


            for (int i = 0; i < content_type_Arr.Length; i++)
            {

                if (khatam.core.License.ValidModule(content_type_Arr[i]))
                {
                    if (i == 0)
                    {
                        sql = "(" + sql_base.Replace("#", content_type_Arr[i]);
                    }
                    else
                    {
                        sql = sql + " union " + sql_base.Replace("#", content_type_Arr[i]);
                    }
                }
                //   sql = sql.Replace("#", content_type_Arr[i]);
                //   type_content = content_type_Arr[i];

            }

            sql = sql + " ) order by catid desc ";

            /*eee valid and enable*/


        }

        // khatam.core.ConfigurationManager.License()
        SqlCommand objCommand = new SqlCommand(sql, objConnection);



        SqlDataReader objReader = objCommand.ExecuteReader();

        while (objReader.Read())
        {
            objX.WriteStartElement("item");
            objX.WriteElementString("title", objReader.GetString(0));

            try
            {
                objX.WriteElementString("description", objReader.GetString(1));
            }
            catch (Exception)
            {
                objX.WriteElementString("description", " ");

            }

            if (type_content != "")
                objX.WriteElementString("link", "http://www." + domain_str + "/web/" + type_content + "/" + objReader.GetInt32(2).ToString() + "/" + khatam.core.strings.Url.replaceTitleNonChar(objReader.GetString(0)));
            else
                objX.WriteElementString("link", "http://www." + domain_str + "/web/" + objReader.GetString(6).ToString() + "/" + objReader.GetInt32(2).ToString() + "/" + khatam.core.strings.Url.replaceTitleNonChar(objReader.GetString(0)));

            try
            {
                objX.WriteElementString("pubDate", objReader.GetDateTime(3).ToString("R"));
            }
            catch (Exception)
            {

                try
                {
                    objX.WriteElementString("pubDate", objReader.GetDateTime(4).ToString("R"));
                }
                catch (Exception)
                {
                    objX.WriteElementString("pubDate", DateTime.Now.ToString());

                }



            }






            objX.WriteEndElement();
        }





        objReader.Close();
        objConnection.Close();

        objX.WriteEndElement();
        objX.WriteEndElement();
        objX.WriteEndDocument();
        objX.Flush();
        objX.Close();
        context.Response.End();










    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}