using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.IO;

public partial class Manage_C_shop_send_terms : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "قوانین ارسال سفارش - انتخاب زبان";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/language.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " قوانین ارسال سفارش - انتخاب زبان ";
        l.Text = l.Text + "</span> ";


        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "selectItem")
        {
            
            //Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=shop_sendMode_lang&id=" + this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text);


        }

  
    }


    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}