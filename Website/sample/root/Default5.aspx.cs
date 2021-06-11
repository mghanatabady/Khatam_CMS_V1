using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
           string strDate;
                    strDate = DateTime.UtcNow.Year + "-" + DateTime.UtcNow.Month + "-" + DateTime.UtcNow.Day
                        + " " + DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute  + ":" + DateTime.UtcNow.Second  ;
                    TextBox1.Text = strDate;
    }
}