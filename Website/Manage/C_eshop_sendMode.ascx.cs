using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_shop_sendMode : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "شیوه های ارسال سفارش";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/trasport.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " شیوه های ارسال سفارش ";
        l.Text = l.Text + "</span> ";


        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        GridView2.DataBind();

        GridView2.Rows[0].Cells[2].Text = ""; 
        GridView2.Rows[1].Cells[2].Text = "";


        GridView2.Rows[0].Cells[3].Text = "";
        //GridView2.Rows[2].Cells[3].Text = "";
        GridView2.Rows[3].Cells[3].Text = "";
        



    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.hideWins();
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        this.hideWins();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


      

        if (e.CommandName == "setting")
        {
          this.Response.Redirect(
              khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=shop_sendMode_setting&id=" + GridView2.Rows[GridView2.SelectedIndex].Cells[0].Text);

        }

        if (e.CommandName == "setAddress")
        {
            this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=eshop_sendMode_instance&id=" + GridView2.Rows[GridView2.SelectedIndex].Cells[0].Text);

        }


    }



    void hideWins()
    {
       

    }


    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}