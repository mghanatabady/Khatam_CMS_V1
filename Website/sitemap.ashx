<%@ WebHandler Language="VB" Class="sitemap" %>


Imports System
Imports System.Web
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Xml
Imports System.Web.Configuration
Imports System.Web.HttpRequest
Imports Khatam_Functions

Public Class sitemap : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        
        Dim domainname As String
        domainname = khatam.core.strings.Url.ApplicationPaths.domainAndVirtualDir()
       
        
        context.Response.Clear()
        context.Response.ContentType = "text/xml"
        Dim objX As New XmlTextWriter(context.Response.OutputStream, Encoding.UTF8)
        objX.WriteStartDocument()
        'objX.WriteStartElement("rss")
        'objX.WriteAttributeString("version", "2.0")
        objX.WriteStartElement("urlset")
        objX.WriteAttributeString("xmlns", "http://www.sitemaps.org/schemas/sitemap/0.9")
        'objX.WriteElementString("link", "http://www.pardazeshsazan.com/webrss.aspx")
        'objX.WriteElementString("description", "آخرین محصولات شبکه")
        'objX.WriteElementString("copyright", "(c) 2010, Pardazeshsazan.com, LLC. All rights reserved.")
        'objX.WriteElementString("ttl", "5")
        Dim objConnection As New SqlConnection(khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
        objConnection.Open()
        Dim sql As String = "SELECT    id,cname,id_content,type_content   FROM         cat WHERE     (type = 2) AND (type_content <> N'menu') AND (type_content <> N'link') AND (type_content <> N'picture') AND (type_content <> N'template') ORDER BY id DESC"
        Dim objCommand As New SqlCommand(sql, objConnection)
        Dim objReader As SqlDataReader = objCommand.ExecuteReader()
        While objReader.Read()
            objX.WriteStartElement("url")
            
            Dim title As String
            title = objReader.GetValue(1).ToString.Replace(" ", "-").Replace(":", "-").Replace(".", "-").Replace("?", "-").Replace("/", "-").Replace("\", "-")
            
            
            objX.WriteElementString("loc", "http://www." & domainname & "/web/" & objReader.GetValue(3) & "/" & objReader.GetValue(2) & "/" & title)
            'objX.WriteElementString("changefreq", "daily") 'objReader.GetString(0))
            'objX.WriteElementString("priority", "1.0") 'objReader.GetString(0))
      
            ''objX.WriteElementString("description", objReader.GetString(1))
            'objX.WriteElementString("link", "http://slam.ir/article_item.aspx?id=" + objReader.GetInt32(2).ToString())
            'objX.WriteElementString("pubDate", objReader.GetDateTime(3).ToString("R"))
            objX.WriteEndElement()
        End While
        objReader.Close()
        objConnection.Close()
        
        
        ''read 2
        Dim objConnection2 As New SqlConnection(khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())
        objConnection2.Open()
        Dim sql2 As String = "SELECT    id,cname,id_content,type_content   FROM         cat WHERE     (type = 1) AND (type_content <> N'menu') AND (type_content <> N'link') AND (type_content <> N'picture') AND (type_content <> N'template') AND (type_content <> N'special_pages') ORDER BY id DESC"
        Dim objCommand2 As New SqlCommand(sql2, objConnection2)
        Dim objReader2 As SqlDataReader = objCommand2.ExecuteReader()
        While objReader2.Read()
            objX.WriteStartElement("url")
            
            
            
            objX.WriteElementString("loc", "http://www." & domainname & "/web/" & objReader2.GetValue(3) & "/?cat=" & objReader2.GetValue(0) & "&title=" & objReader2.GetValue(1).ToString.Replace(" ", "-"))
            'objX.WriteElementString("changefreq", "daily") 'objReader.GetString(0))
            'objX.WriteElementString("priority", "1.0") 'objReader.GetString(0))
      
            ''objX.WriteElementString("description", objReader.GetString(1))
            'objX.WriteElementString("link", "http://slam.ir/article_item.aspx?id=" + objReader.GetInt32(2).ToString())
            'objX.WriteElementString("pubDate", objReader.GetDateTime(3).ToString("R"))
            objX.WriteEndElement()
        End While
        objReader2.Close()
        objConnection2.Close()

        'objX.WriteEndElement()
        objX.WriteEndElement()
        objX.WriteEndDocument()
        objX.Flush()
        objX.Close()
        context.Response.End()
    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class