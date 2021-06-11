<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.IO.Compression" %>
<%@ Import Namespace="System.ServiceModel.Activation" %>
<script runat="server">

   
  
    
    
    
    
    void Application_PreRequestHandlerExecute(object sender, EventArgs e)
    {
    /*    HttpApplication app = sender as HttpApplication;
        string acceptEncoding = app.Request.Headers["Accept-Encoding"];
        Stream prevUncompressedStream = app.Response.Filter;

       // this.Response.Redirect("http://www.google.com?q=" + app.Response.GetType());
        if (!(app.Context.CurrentHandler is Page ||
            app.Context.CurrentHandler.GetType().Name == "SyncSessionlessHandler") ||
           app.Request["HTTP_X_MICROSOFTAJAX"] != null)
        return;

        if (acceptEncoding == null || acceptEncoding.Length == 0)
            return;

        acceptEncoding = acceptEncoding.ToLower();

        if (acceptEncoding.Contains("deflate") || acceptEncoding == "*")
        {
            // defalte
            app.Response.Filter = new DeflateStream(prevUncompressedStream,
                CompressionMode.Compress);
            app.Response.AppendHeader("Content-Encoding", "deflate");
        }
        else if (acceptEncoding.Contains("gzip"))
        {
            // gzip
            app.Response.Filter = new GZipStream(prevUncompressedStream,
                CompressionMode.Compress);
            app.Response.AppendHeader("Content-Encoding", "gzip");
        }*/
    }
    
  

   

 

    
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
       
        //RouteTable.Routes.Add(new ServiceRoute("KhatamSDRADCORE.irmc.ShoppingPortType", new WebServiceHostFactory(), typeof(KhatamSDRADCORE.irmc.ShoppingPortType)));
        RegisterRoutes(RouteTable.Routes);
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        
    }
        

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs
       // Response.Filter = null;
        /*
         
         Utilities.LastError = Server.GetLastError();
         Utilities.LastError_Page = Request.Url.PathAndQuery;
         Utilities.LastError_PageQuery = Request.ServerVariables["QUERY_string"];
           try
           {
               Utilities.LastError_Page_reffer = Request.UrlReferrer.PathAndQuery;

           }
           //catch (Exception ex)
           catch
           {
               Utilities.LastError_Page_reffer = "none_ref";
           }


           Exception ex = Server.GetLastError();
        
          string filename;

          filename = Path.GetFileName(this.Request.Url.OriginalString );

       
          if (check_old_Page(filename) == false)
          {
              sendErrorToSupport(ex);
          }
      //  if (ex is ThreadAbortException)
        //    return;
      //  Logger.Error(LoggerType.Global, ex, "Exception");
      //  Response.Redirect("unexpectederror.htm");
        
        */
        //khatam.core.email.sendAllPurposeEmail("mghanatabady@yahoo.com", "slam", ex.Message, "ccccccc", false);

    }

    public bool check_old_Page(string filename)
    {
        filename = filename.ToLower();
        //l1.Text = filename;

        if (filename.ToString().Contains("article_item.aspx"))
        {
            this.Response.Redirect("~/web/article/" + Utilities.LastError_PageQuery.Replace("id=", ""));

        }

        if (filename.ToString().Contains("library_item.aspx"))
        {
            this.Response.Redirect("~/web/library/" + Utilities.LastError_PageQuery.Replace("id=", ""));

        }
        
        //if (
            
         //   http://www.slam.ir:80/shop.aspx?cat=1108

        if (filename.ToString().Contains("shop.aspx") && Utilities.LastError_PageQuery.Contains("cat"))
        {
            this.Response.Redirect("~/web/shop/?" + Utilities.LastError_PageQuery);

        }


        if (filename.ToString().Contains("news_item.aspx"))
        {
            this.Response.Redirect("~/web/news/" + Utilities.LastError_PageQuery.Replace("id=", ""));

        }

        if (filename.ToString().Contains("picture_item.aspx"))
        {
            this.Response.Redirect("~/web/picture/" + Utilities.LastError_PageQuery.Replace("id=", ""));

        }

        
        
        switch (filename)
        {
                        
            case "article.aspx":
                this.Response.Redirect("~/web/article");
                return true;
                break;

            case "shop.aspx":
                this.Response.Redirect("~/web/shop");
                return true;
                
                break;
      
            case "news.aspx":
                this.Response.Redirect("~/web/news");
                return true;
                
                break;
      
                
                break;
            case "picture.aspx":
                this.Response.Redirect("~/web/picture");
                return true;
                
                break;

            case "help.aspx":
                this.Response.Redirect("~/web/help");
                return true;

 
 
                
                break;
            case "special_pages_item.aspx":
                this.Response.Redirect("~/web/special_pages/" + Utilities.LastError_PageQuery.Replace("id=", "") + "/");
                return true;
                
                break;
            case "contactus.aspx":
                this.Response.Redirect("~/web/contactus/");
                return true;
                
                break;
            default:
                break;
        }


        return false;

    }
    
    public void sendErrorToSupport(Exception ex)
    {

        string str_body = "";

        try
        {
            str_body = str_body + "آدرس : <br /> " + this.Request.Url.OriginalString + "<br />";
        }
        catch
        {
            str_body = str_body + "آدرس : none <br />";
        }
        
        try
        {
            str_body = str_body + "آدرس در خواست: <br /> " + this.Request.Url.PathAndQuery + "<br />";
        }
        catch
        {
            str_body = str_body + "آدرس در خواست: none <br />";
        }

        try
        {
            str_body = str_body + "آدرس صفحه ارجاع داده شده: " + Request.UrlReferrer.PathAndQuery + "<br />";

        }
        catch
        {
            str_body = str_body + "آدرس صفحه ارجاع داده شده:  <br />" + "none";

        }

   

        try
        {
            str_body = str_body + "IP: " + Request.ServerVariables["REMOTE_ADDR"] + "<br />";

        }
        catch
        {
            str_body = str_body + "IP: none <br />";

        }

        try
        {
            str_body = str_body + "زمان درج درخواست: " + DateTime.UtcNow + " | " + khatam.core.globalization.dateTime.GetPersianDate(DateTime.UtcNow) + "<br />";

        }
        catch
        {
            str_body = str_body + "زمان درج درخواست: none <br />";

        }

        try
        {
            str_body = str_body + "Message: " +ex.Message  + "<br />";

        }
        catch
        {
            str_body = str_body + "Message: none";
        }

        try
        {
            str_body = str_body + "StackTrace: " + ex.InnerException.StackTrace.Replace("\r", " ") + "<br />";

        }
        catch
        {
            str_body = str_body + "StackTrace: none";

        }

        try
        {
            str_body = str_body + "Source: " + ex.InnerException.Source + "<br />";

        }
        catch
        {
            str_body = str_body + "Source: none";

        }

        try
        {
            str_body = str_body + "Message: " + ex.InnerException.Message;
        }
        catch
        {
            str_body = str_body + "Message: none";
        }







        /*     message_str = .Message

             stacktrace_str = .StackTrace.Replace(vbCr, "<br>")

             source_str = .Source
           
             Dim page_reffer_str, user_ip_str As String
             Try
                 page_reffer_str = Me.Request.UrlReferrer.PathAndQuery
             Catch ex As Exception
                 page_reffer_str = "none"
             End Try

             Try
                 user_ip_str = Request.ServerVariables("REMOTE_ADDR")
             Catch ex As Exception
                 user_ip_str = "none"
             End Try




             EmailSender_Error("support@yourDomain.com", "khatam: Error " & Me.Request.Url.Host & Me.Request.QueryString("aspxerrorpath") DateTime.UtcNow(), Me.Request.Url.PathAndQuery, Utilities.LastError_Page, message_str, stacktrace_str, source_str, Utilities.LastError_Page_reffer, user_ip_str)
         End With
       
     End Sub

  */
        khatam.core.email.sendAllPurposeEmail("mghanatabady@yahoo.com", "KhatamSDRAD : " + khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_") +
        " support request", str_body, khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir().Replace(".", "_"), false);

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
 

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

    //routering scott

    void RegisterRoutes(System.Web.Routing.RouteCollection routes)
    {
         
        
        // Register a route for Categories/All 
        //routes.Add(
        // "All Categories",
         //     new System.Web.Routing.Route("Categories/All", new CategoryRouteHandler())
         //  );

        // Register a route for Categories/{CategoryName} 
        //routes.Add(
          // "View Category",
          // new System.Web.Routing.Route("Categories/{*CategoryName}", new CategoryRouteHandler())
       // );

        // Register a route for Products/{ProductName} 
        // routes.Add(
        //"filename",
        //new System.Web.Routing.Route("radcontrols", new HomeRouteHandler())
        //); 
        
        
         //Register a route for Products/{ProductName} 
    //            routes.Add(
    // "filename",
   //  new System.Web.Routing.Route("{filename}.aspx", new HomeRouteHandler())
 // );


      

        routes.Add(
        "web",
        new System.Web.Routing.Route("web" , new HomeRouteHandler())
        );

        routes.Add(
        "lang",
        new System.Web.Routing.Route("{lang}/web/", new HomeRouteHandler())
        );

        routes.Add(
        "contentType",
        new System.Web.Routing.Route("web/{contentType}", new HomeRouteHandler())
        );

        routes.Add(
        "LangContentType",
        new System.Web.Routing.Route("{lang}/web/{contentType}", new HomeRouteHandler())
        );

        routes.Add(
        "contentId",
        new System.Web.Routing.Route("web/{contentType}/{id}", new HomeRouteHandler())
        );

        routes.Add(
        "contentIdTitle",
        new System.Web.Routing.Route("web/{contentType}/{id}/{title}", new HomeRouteHandler())
        );
        
        routes.Add(
        "LangcontentId",
        new System.Web.Routing.Route("{lang}/web/{contentType}/{id}", new HomeRouteHandler())
        );

        routes.Add(
        "LangcontentIdTitle",
        new System.Web.Routing.Route("{lang}/web/{contentType}/{id}/{title}", new HomeRouteHandler())
        );
        
        
        //routes.Add(
        //"ccontentId",
        //new System.Web.Routing.Route("{contentType}/{id}", new HomeRouteHandler())
        //);

        //routes.Add(
        //"catId",
        //new System.Web.Routing.Route("{contentType}/cat/{id}", new HomeRouteHandler())
        //);
                
        //routes.Add(
        //"newsitem",
        //new System.Web.Routing.Route("news/{item}", new HomeRouteHandler())
        //);
  

        
        //routes.Add(
        //   "View Product2",
        //   new System.Web.Routing.Route("Products/{ProductName}", new ProductRouteHandler())
        //);
    } 
    
</script>
