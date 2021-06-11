using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Net;
using System.IO;
using System.Web;

namespace khatam
{
    namespace core
    {
        namespace XML
        {
            public static class IO
            {

                public  static  void Export_DataSet_To_File(DataSet ds, string filename)
                {
                    HttpContext.Current.Response.ClearContent();
                    HttpContext.Current.Response.AddHeader("content-disposition", "attachment; filename=" + filename + ".xml");
                    HttpContext.Current.Response.ContentType = "application/vnd.xml";
                    HttpContext.Current.Response.Write(ds.GetXml());
                    HttpContext.Current.Response.End();
                }

   
            }


        }
    }
}



