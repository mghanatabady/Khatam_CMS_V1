using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Default35 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      DirectoryInfo directoryInfo = new DirectoryInfo(Server.MapPath( @"manage\upload\test\_flash\"));
    //  Response.Write("Directory Name :" + directoryInfo.FullName.ToString());

foreach (FileInfo fileInfo in directoryInfo.GetFiles())
{
    if (fileInfo.Name.ToString().StartsWith("TourWeaver_"))
    {
             Response.Write(fileInfo.Name.ToString());
    }
}


    }
}