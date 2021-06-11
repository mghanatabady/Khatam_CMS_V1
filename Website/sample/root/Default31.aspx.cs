using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default31 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
          try
        {


            var fileInBytes = Encoding.UTF8.GetBytes("a.txt");
            using (var stream = new MemoryStream(fileInBytes))
            {
                long dataLengthToRead = stream.Length;
                Response.Clear();
                Response.ClearContent();
                Response.ClearHeaders();
                Response.BufferOutput = true;
                Response.ContentType = "text/xml"; /// if it is text or xml
                Response.AddHeader("Content-Disposition", "attachment; filename=" + "yourfilename");
                Response.AddHeader("Content-Length", dataLengthToRead.ToString());
                stream.WriteTo(Response.OutputStream);
                Response.Flush();
                Response.Close();
            }
            Response.End();
            
        }
        catch (Exception)
        {

        }

    }
}