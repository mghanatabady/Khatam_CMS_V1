using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_c_comment : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "نظرات";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/web_forms.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " نظرات";
        l.Text = l.Text + "</span> ";


        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
    }
}