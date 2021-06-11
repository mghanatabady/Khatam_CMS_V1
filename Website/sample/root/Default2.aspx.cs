using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
                khatam.uniproj.cluster _cluster = new khatam.uniproj.cluster();
        _cluster.uniSection =1;
        _cluster.year_id = 1;

        Label1.Text= _cluster.CheckIdentity().ToString();
        
    }
}