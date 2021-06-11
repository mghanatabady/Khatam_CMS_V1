using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default29 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        khatam.core.UI.WebControls.contentPaging cp = new khatam.core.UI.WebControls.contentPaging();
        Label1.Text = cp.Sql_load_count_estate("estate", "#.1.A21", "").ToString();
    }
}