<%@ WebService Language="C#" Class="GetAllSitesService" %>

using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Collections.Generic;
using System.Data.SqlClient;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]

// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class GetAllSitesService  : System.Web.Services.WebService {
    [WebMethod]
    public IList<string> GetAllSites(string keywords)
    {
        //TODO: implement real search here!
        IList<string> result = new List<string>();
        string constr = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString() ;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandText = "select tag_title as title from core_tags where tag_title like N'%" + keywords + "%'";
       // result.Add("ddd");
       // return result;
        try
        {
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                result.Add(dr["title"].ToString());
            }
            con.Close();
            return result;
        }
        catch
        {
            return null;
        }
    }

}