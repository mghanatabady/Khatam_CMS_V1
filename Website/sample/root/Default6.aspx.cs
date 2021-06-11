using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        khatam.uniproj.cluster _cluster = new khatam.uniproj.cluster();

        _cluster.cluster_id = 1;
        _cluster.GetCluster();

        TextBox1.Text = _cluster.EduGroupId.ToString() ;

    }
}