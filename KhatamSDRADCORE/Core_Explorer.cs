using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;



namespace khatam
{
    namespace core
    {


        public static class explorer
        {

            public static string[] content_type_Arr = { "special_pages", "news", "link", "car", "host", "domain", "shop", "article", "clip", "library", "software", "picture", "host", "service", "domain", "help", "portal" ,"estate"};
         /*link not content*/

            public static bool isValidContent_Type(string content_type)
            {
                if (khatam.core.ConfigurationManager.License.moduleArr.Contains(content_type) || content_type == "special_pages")
                {
                    return true;
                }
                else
                {
                    return false ; 
                }
            }

            public static string getSortId(string table, string languageCname)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("cname", languageCname);
                parameters.Add("type_content", table);

                str_sql = "SELECT     sortid   FROM         Cat   WHERE     (cname = @cname) AND (type_content = @type_content)";
                return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
            }

            public static string getSortId(string ContentFarsiCname)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("cname", ContentFarsiCname);
                parameters.Add("height", 2);

                str_sql = "SELECT     sortid   FROM         Cat   WHERE     (cname = @cname) AND (height = @height)";
                return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
            }

            public static string getSortId(int height, int id_cat, string sortid)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("id", id_cat);
                parameters.Add("height", height);
                str_sql = "SELECT     sortid   FROM         cat  WHERE   (height = @height) and  (id = @id) and   (sortid LIKE N'%" + sortid + "%')";

                return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
            }

   
            public static string getOrderid(string pid)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("pid", pid);
           

                str_sql = "SELECT    top(1) orderid   FROM         Cat   WHERE    (pid = @pid)  ORDER BY orderid DESC ";

                object _obj = DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                if (_obj == null)
                {
                    return "-1";
                }
                else
                {
                    return _obj.ToString();
                }

               
            }


            public static DataTable getFilePage(string sortid, string table, int first_row, int last_row, bool accessAll, bool showDeleted, string userID)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                //##   parameters.Add("type", type);
                string sqluserwhere = "";
                if (accessAll == false)
                {
                    sqluserwhere = "AND (Cat.insertUserId=N'" + userID + "')";// "AND (Cat.deleted='1')";

                }


                string sqlShowDeleted = "";
                if (showDeleted == false)
                {
                    sqlShowDeleted = " AND (Cat.deleted <>'1')";
                }


                str_sql = "SELECT     id,cname, Enable,valid,deleted, '" + table + "' AS table_name " +
          "FROM         (SELECT     *, row_number() OVER (ORDER BY id DESC) AS Row_Number  " +
           "FROM         (SELECT cat.* , " + table + ".Enable  " +
          "FROM        " + table + "  INNER JOIN " +
          "Cat ON " + table + ".id = Cat.id_content " +
          "WHERE     (Cat.sortid LIKE N'%" + sortid + "%') " + sqluserwhere + sqlShowDeleted + " ) AS resultData1) AS resultData2 " +
          "WHERE     (Row_Number BETWEEN " + first_row + " AND  " + last_row + ") ";
                return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }

            public static string getContentXmlTree(string type_content, string languageCname)
            {
                int c = 0;
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
                languageCname = "فارسی";
                switch (type_content)
                {
                    case "article":
                        type_content_fa = "مقالات";
                        break;
                    case "news":
                        type_content_fa = "اخبار";
                        break;
                    case "service":
                        type_content_fa = "خدمات";
                        break;
                    case "software":
                        type_content_fa = "نرم افزار";
                        break;
                    case "shop":
                        type_content_fa = "محصولات";
                        break;
                    case "Link":
                        type_content_fa = "پیوند ها";
                        break;
                    case "portal":
                        type_content_fa = "پرتال";
                        break;
                    case "help":
                        type_content_fa = "راهنما";
                        break;
                    case "picture":
                        type_content_fa = "تصاویر";
                        break;
                    case "menu":
                        type_content_fa = "منو ها";
                        break;
                    case "library":
                        type_content_fa = "کتابخانه";
                        break;
                    case "clip":
                        type_content_fa = "کلیپ";
                        break;
                    case "sample_exam":
                        type_content_fa = "نمونه سوالات";
                        break;
                    case "car":
                        type_content_fa = "خودروها";
                        break;
                    case "host":
                        type_content_fa = "هاست";
                        break;
                    case "special_pages":
                        type_content_fa = "صفحات سفارشی";
                        break;

                    case "estate":
                        type_content_fa = "املاک";
                        break;
                    case "domain":
                        type_content_fa = "نام دامنه";
                        break;
                }
                sortid = getSortId(type_content_fa);
                //Sql_get_sortid(type_content, language, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                //sortid = "#.1.2";
                str_sql = ("SELECT     id, cname, height, orderid, type_content,sortid    FROM         Cat     WHERE     (Cat.sortid LIKE" +
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
                        objX.WriteAttributeString("id", dt.Rows[i].ItemArray[0].ToString());
                    }
                    else
                    {
                        objX.WriteAttributeString("title", dt.Rows[i].ItemArray[1].ToString());
                        objX.WriteAttributeString("id", dt.Rows[i].ItemArray[0].ToString());
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

            public static DataTable getTable(string table, string q, int first_row, int last_row, string sortid, string ConnectionString)
            {
                string str_sql = "";
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                //parameters.Add("field_where_value", field_where_value);

                if (table != "search")
                {

                    // str_sql = "SELECT     id,title,'" + table + "/' + CAST(id as nvarchar) + '/' + replace(replace(title,' ','-'),':','')  as navi_url " + ", image as image_navi , N'" + table + "' as TableSql , author,description,keywords " +
                    str_sql = "SELECT     id,title,'" + table + "/' + CAST(id as nvarchar) + '/' + replace(replace(title,' ','-'),':','')  as navi_url " + ", image as image_navi , N'" + table + "' as TableSql , author,description,keywords " +
         " FROM         (SELECT     *, row_number() OVER (ORDER BY id DESC) AS Row_Number " +
         " FROM         (SELECT DISTINCT " + table + ".* " +
         " FROM         " + table + " INNER JOIN " +
         " Cat ON " + table + ".id = Cat.id_content " +
         " WHERE     (Cat.sortid LIKE N'%" + sortid + "%')) AS resultData1) AS resultData2 " +
         " WHERE     (Row_Number BETWEEN " + first_row + " AND " + last_row + ") ";
                }


                return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, ConnectionString);
            }

            public static DataTable getFolder(string caller, string sortid)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("type", "1");
                parameters.Add("height", int.Parse(khatam.core.data.sql.getField( "height", "sortid", sortid, "cat")) + 1);

                str_sql = "SELECT    *   FROM         Cat  WHERE    (sortid LIKE N'%" + sortid + ".%')  AND (type = @type)  AND (height = @height) ";

                try
                {
                    return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
                }
                catch /*(Exception ex)*/
                {
                    //khatam.core.data.sql.ErrorLogAdd("caller:" + caller + " sortid: " + sortid + " ex: " + ex.InnerException + " " + ex.Message);
                    //return null;
                    //throw;
                    return null;
                }

            }

            public static DataTable getTags(string cat_id)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


                parameters.Add("cat_id", cat_id);

                str_sql = "SELECT     core_tags.tag_title " +
                          " FROM         core_tags INNER JOIN " +
                          "    core_tag_ref_cat ON core_tags.tag_id = core_tag_ref_cat.tag_id " +
                          " WHERE     (core_tag_ref_cat.cat_id = @cat_id)";
                return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }

            public static string  countFolderALLFiles( string sortid, string contentType)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("type", "2");
                //.Add("height", int.Parse(khatam.core.data.sql.getField("getFolder", "height", "sortid", sortid, "cat")) + 1);

                str_sql = "SELECT     COUNT(cat.id) AS Expr1 FROM         Cat INNER JOIN " +
                      " " + contentType + " ON Cat.id_content = " + contentType + ".id " +
                      " WHERE   (Cat.type_content = N'" + contentType + "') AND (cat.sortid LIKE N'%" + sortid + ".%') AND (cat.type = @type) AND (cat.deleted=0) AND (cat.valid=1) AND " +
                      "(" + contentType + ".enable = 1) AND (Cat.showTime < CONVERT(DATETIME, '" + DateTime.UtcNow.ToString() + "', 102)) ";
                
                return DBFunctions.ExecuteScaler (str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();
            
            }

            public static int TableItemCount(string table, string sortid, bool accessAll, bool showDeleted, string userID)
            {
                string str_sql = "";
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                string sqluserwhere = "";
                if (accessAll == false)
                {
                    sqluserwhere = " AND (Cat.insertUserId=N'" + userID + "')";// "AND (Cat.deleted='1')";
                }

                string sqlShowDeleted = "";
                if (showDeleted == false)
                {
                    sqlShowDeleted = " AND (Cat.deleted <>'1')";
                }



                int count = 0;

                str_sql = "SELECT     COUNT(*) AS Expr1 " +
                   "FROM         (SELECT     *, row_number() OVER (ORDER BY id DESC) AS Row_Number " +
                   "FROM         (SELECT DISTINCT " + table + ".* " +
                   "FROM        " + table + " INNER JOIN " +
                   "Cat ON " + table + ".id = Cat.id_content " +
                   "WHERE     (Cat.sortid LIKE N'%" + sortid + "%')  " + sqluserwhere + sqlShowDeleted + " ) AS resultData1) AS resultData2 ";
                count = int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString().ToString()).ToString());



                return count;

            }

            public static int getOrderId(int height, string sortid)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("height", height);
                parameters.Add("sortid", sortid);

                str_sql = "SELECT  top(1)    orderid  FROM         cat  WHERE   (height = @height) and   (sortid LIKE N'%" + sortid + "%') ORDER BY  orderid DESC";
                //  SELECT  top(1)   orderid  FROM         cat  WHERE  (height = 4) and   (sortid LIKE N'%#.1.2.1%') ORDER BY  id DESC
                return int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString());
            }

            public static string generateUrl(string id)
            {

                string url_str = "";
                int currentFolderHeight;
                string cname;

                currentFolderHeight = int.Parse(khatam.core.data.sql.getField( "height", "id", id, "cat"));

                for (int i = 2; i < currentFolderHeight + 1; i++)
                {
                    cname = khatam.core.data.sql.getField( "cname", "id", id, "cat");
                    id = khatam.core.data.sql.getField( "pid", "id", id, "cat");



                    if (i > 2)
                    {
                        url_str = cname + " ‏>‏ " + url_str;

                    }
                    else
                    {
                        url_str = cname + url_str;
                    }


                }

                //If i > 2 Then
                //    url_str = " <div style=""height: 16px; float:left""  > " & "<a href=""default.aspx?mode=folder&cat=" & dt.Rows(0).Item(0) & """  style=""color: black; text-decoration: none""  >" & dt.Rows(0).Item(2) & "</a>  < &nbsp; </div>" & url_str
                //Else
                //   
                //End If
                //  Next i


                //return  url_str;
                return url_str;

            }

            public static string generateUrl_link(string id)
            {

                string url_str = "";
                int currentFolderHeight;
                string cname;
                string currentId;

                currentFolderHeight = int.Parse(khatam.core.data.sql.getField( "height", "id", id, "cat"));

                for (int i = 2; i < currentFolderHeight + 1; i++)
                {
                    cname = khatam.core.data.sql.getField( "cname", "id", id, "cat");
                    currentId = id;
                    id = khatam.core.data.sql.getField( "pid", "id", id, "cat");



                    if (i > 2)
                    {
                //        url_str = cname + " ‏>‏ " + url_str;
                        url_str = "<a href=\"default.aspx?mode=folder&cat=" + currentId + "\"  style=\"color: black; text-decoration: none\"  >" + cname + "</a>  > " + url_str;

                    }
                    else
                    {
                        url_str = cname + url_str;
                    }


                }

                //If i > 2 Then
                //    url_str = " <div style=""height: 16px; float:left""  > " & "<a href=""default.aspx?mode=folder&cat=" & dt.Rows(0).Item(0) & """  style=""color: black; text-decoration: none""  >" & dt.Rows(0).Item(2) & "</a>  < &nbsp; </div>" & url_str
                //Else
                //   
                //End If
                //  Next i


                //return  url_str;
                return url_str;

            }

            public static string generateUrl_link_website(string cat_id,string  contentTable)
            {

                string url_str = "";
                int currentFolderHeight;
                string cname;
                string currentId;


                currentFolderHeight = int.Parse(khatam.core.data.sql.getField( "height", "id", cat_id, "cat"));

                for (int i = 2; i < currentFolderHeight - 1; i++)
                {
                    cname = khatam.core.data.sql.getField( "cname", "id", cat_id, "cat");
                    currentId = cat_id;
                    cat_id = khatam.core.data.sql.getField( "pid", "id", cat_id, "cat");

                    if (i > 2)
                    {
                        url_str = "<a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath +
                            "web/" + contentTable  + "/?cat=" + currentId + "&title=" + cname  +"\"    >" + cname + "</a>  > " + url_str;

                    }
                    else
                    {
                        url_str = cname + url_str;
                    }
                }


                string pid = khatam.core.data.sql.getField( "pid", "id", cat_id, "cat");
                cname = khatam.core.data.sql.getField( "cname", "id", pid, "cat");

                
                    if (currentFolderHeight >3)
                    {
                        url_str = "<a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath +
                            "\"    >صفحه اصلی</a>  > " +
                    "<a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath + "web/" + contentTable  + "/?cat=" + cat_id + "&title=" + cname +
                    "\"   >" + cname + "</a>  > " + url_str;
                    }
                    else
                    {
                        url_str = "<a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath +
                            "\"    >صفحه اصلی</a>  > " 
                     + cname ;
                    }
                 


                return url_str  ;

            }
     


            public static DataTable getFolderType(string contentType)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                //parameters.Add("type", type);
                //parameters.Add("height", int.Parse(khatam.core.data.sql.getField("height", "sortid", sortid, "cat", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())) + 1);

                str_sql = "SELECT     id  FROM         Cat  WHERE     (type_content = N'" + contentType + "') AND (type = 1) AND (height > 2) ORDER BY sortid";
                return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
            }

            public static int contentInsert(string title, string contentType)
            {
                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                parameters.Add("title", title);
                parameters.Add("pub_date", DateTime.UtcNow);

                str_sql = "INSERT INTO " + contentType + "  (title,Enable,pub_date)  VALUES     (@title,0,@pub_date)  ; SELECT SCOPE_IDENTITY();";


                return int.Parse(DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString());
            }

            public static string fileAdd(int orderid, string cname, int pid, string sortid, int height, int type, string type_content, string id_content, string insertUserId)
            {

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("orderid");
                b.Add(orderid);

                a.Add("cname");
                b.Add(cname);

                a.Add("pid");
                b.Add(pid);

                a.Add("sortid");
                b.Add(sortid);

                a.Add("height");
                b.Add(height);

                a.Add("type");
                b.Add(type);

                a.Add("type_content");
                b.Add(type_content);

                a.Add("id_content");
                b.Add(id_content);

                a.Add("insertUserId");
                b.Add(insertUserId);

                a.Add("Valid");
                b.Add(false);

                a.Add("Deleted");
                b.Add(false);

                a.Add("showTime");
                b.Add(DateTime.UtcNow.AddDays(-1).Date);

                return khatam.core.data.sql.Add(a, b, "cat");

            }

            public static string fileAdd(string cname, string pid, string insertUserId)
            {



                string type_content;
                type_content = khatam.core.data.sql.getField( "type_content", "id", pid, "cat");

                int height;
                height = int.Parse(khatam.core.data.sql.getField( "height", "id", pid, "cat"));

                string sortidCurrent;
                sortidCurrent = khatam.core.data.sql.getField( "sortid", "id", pid, "cat");

                int orderid = 1;

                try
                {
                    orderid = khatam.core.explorer.getOrderId(height + 1, sortidCurrent) + 1;
                }
                catch
                {

                }

                string sortchar;
                if ((orderid.ToString().Length > 1))
                {
                    sortchar = ((char)((63 + orderid.ToString().Length))).ToString();
                }
                else
                {
                    sortchar = "";
                }



                string sortid;
                sortid = khatam.core.explorer.getSortId(height, int.Parse(pid), sortidCurrent);


                int pidCurrent;
                pidCurrent = int.Parse(khatam.core.data.sql.getField( "pid", "id", pid, "cat"));

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("orderid");
                b.Add(orderid);

                a.Add("cname");
                b.Add(cname);

                a.Add("pid");
                b.Add(pid);

                a.Add("sortid");
                b.Add(sortid + "." + sortchar + orderid);

                a.Add("height");
                b.Add(height + 1);

                a.Add("type");
                b.Add("2");

                a.Add("type_content");
                b.Add(type_content);

                a.Add("id_content");
                b.Add(khatam.core.explorer.contentInsert(cname, type_content).ToString());

                a.Add("insertUserId");
                b.Add(insertUserId);

                a.Add("Valid");
                b.Add(false);

                a.Add("Deleted");
                b.Add(false);

                return khatam.core.data.sql.Add(a, b, "cat");

            }

            public static string folderAdd(string cname, string  pid,string insertUserId)
            {

                

                string type_content;
                type_content = khatam.core.data.sql.getField( "type_content", "id", pid, "cat");

                int height;
                height = int.Parse( khatam.core.data.sql.getField( "height", "id", pid, "cat"));

                string sortidCurrent;
                sortidCurrent = khatam.core.data.sql.getField( "sortid", "id", pid, "cat");

                int orderid = 1;

                try
                {
                    orderid = khatam.core.explorer.getOrderId(height + 1, sortidCurrent) + 1;
                }
                catch
                {

                }

                string sortchar;
                if ((orderid.ToString().Length > 1))
                {
                    sortchar = ((char)((63 + orderid.ToString().Length))).ToString();
                }
                else
                {
                    sortchar = "";
                }



                string sortid;
                sortid = khatam.core.explorer.getSortId(height, int.Parse(pid), sortidCurrent);


                int pidCurrent;
                pidCurrent = int.Parse(khatam.core.data.sql.getField( "pid", "id", pid, "cat"));
         
                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("orderid");
                b.Add(orderid);

                a.Add("cname");
                b.Add(cname);

                a.Add("pid");
                b.Add(pid);

                a.Add("sortid");
                b.Add( sortid + "." + sortchar + orderid);

                a.Add("height");
                b.Add(height + 1);

                a.Add("type");
                b.Add("1");

                a.Add("type_content");
                b.Add(type_content);

                a.Add("id_content");
                b.Add("0");

                a.Add("insertUserId");
                b.Add(insertUserId);

                a.Add("Valid");
                b.Add(false);

                a.Add("Deleted");
                b.Add(false);

                return khatam.core.data.sql.Add(a, b, "cat");

            }

    
            
            public static bool fileMove(string idFile, int orderid, int pid, string sortid, int height)
            {


                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("orderid");
                b.Add(orderid);



                a.Add("pid");
                b.Add(pid);

                a.Add("sortid");
                b.Add(sortid);

                a.Add("height");
                b.Add(height);



                return khatam.core.data.sql.update(a, b, "cat", "id", idFile);

            }

            public static bool folderMove(string idFolder, int orderid, int pid, string sortid, int height)
            {

                string folderSortid;
                folderSortid = khatam.core.data.sql.getField( "sortid", "id", idFolder, "cat");

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("orderid");
                b.Add(orderid);



                a.Add("pid");
                b.Add(pid);

                a.Add("sortid");
                b.Add(sortid);

                a.Add("height");
                b.Add(height);




                khatam.core.data.sql.update(a, b, "cat", "id", idFolder);



                string str_sql;
                Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

                // parameters.Add("title", title);

                str_sql = "UPDATE    Cat  SET              sortid = REPLACE(sortid, N'" + folderSortid + "', N'" + sortid + "') WHERE     (sortid LIKE N'" + folderSortid + "%');UPDATE    Cat     SET              height = dbo.ufn_CountChar(sortid, '.') WHERE     (sortid LIKE N'" + sortid + "%'); ";
                DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                return true;

            }


        }


    }
}
