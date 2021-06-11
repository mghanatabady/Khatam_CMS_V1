using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default14 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = generateUrl_link_website("505");
    }

    public static string generateUrl_link_website(string id)
    {

        string url_str = "";
        int currentFolderHeight;
        string cname;
        string currentId;

        currentFolderHeight = int.Parse(khatam.core.data.sql.getField( "height", "id", id, "cat"));

        for (int i = 2; i < currentFolderHeight -1   ; i++)
        {
            cname = khatam.core.data.sql.getField( "cname", "id", id, "cat")   ;
            currentId = id;
            id = khatam.core.data.sql.getField( "pid", "id", id, "cat");

                if (i > 2)
                {
                   url_str = "<a href=\"" + khatam.core.ConfigurationManager.ApplicationPaths.FullyQualifiedApplicationPath + 
                       "web" + currentId + "\"  style=\"color: black; text-decoration: none\"  >" + cname + "</a>  > " + url_str;

                }
                else
                {
                   url_str = cname + url_str;
                }
            }

       
        string  pid = khatam.core.data.sql.getField( "pid", "id", id, "cat");
        cname = khatam.core.data.sql.getField( "cname", "id", pid, "cat");        

        url_str = "<a href=\"default.aspx?mode=folder&cat=" + id  + "\"  style=\"color: black; text-decoration: none\"  >" + cname + "</a>  > " + url_str;


        return url_str;

    }

}