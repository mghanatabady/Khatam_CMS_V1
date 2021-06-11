using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default13 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ImageButton1.ImageUrl = FullyQualifiedApplicationPath + "file.gif";
    }

    public static string FullyQualifiedApplicationPath
    {
        get
        {
            //Return variable declaration
            string appPath = null;

            //Getting the current context of HTTP request
            HttpContext context = HttpContext.Current;

            //Checking the current context content
            if (context != null)
            {
                //Formatting the fully qualified website url/name
                appPath = string.Format("{0}://{1}{2}{3}",
                context.Request.Url.Scheme,
                context.Request.Url.Host,
                    //":" + context.Request.Url.Port,
                context.Request.Url.Port == 80 ? string.Empty : ":" + context.Request.Url.Port,
                context.Request.ApplicationPath);
                // context.Request.ApplicationPath + "/");
            }
            if (!appPath.EndsWith("/"))
                appPath += "/";

            return appPath;
        }
    }
}