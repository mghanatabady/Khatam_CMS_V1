using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Routing;
using System.Web.Compilation;

public class HomeRouteHandler : IRouteHandler
{
    public IHttpHandler GetHttpHandler(RequestContext requestContext)

         
    {
       

        string contentType = requestContext.RouteData.Values["contentType"] as string;

        if (contentType == "مقاله")
        {
            HttpContext.Current.Items["contentType"] = "article";
        }
        else
        {
            HttpContext.Current.Items["contentType"] = contentType;
        }

      


        string contentId = requestContext.RouteData.Values["id"] as string;
        HttpContext.Current.Items["id"] = contentId;

        string lang = requestContext.RouteData.Values["lang"] as string;
        HttpContext.Current.Items["lang"] = lang;

        return BuildManager.CreateInstanceFromVirtualPath("~/Default.aspx" , typeof(Page)) as Page;



      
    }
}

