using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_shop_my_invoice : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "فاکتور های من";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/invoice.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " فاکتور های من";
        l.Text = l.Text + "</span> ";


        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            this.Button1.Enabled = false;
            this.Button1.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button2.Enabled = false;
            this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button4.Enabled = false;
            this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }




        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }

        SqlDataSource1.SelectCommand = "SELECT core_serverControls.id, Dictionary_Lang.title FROM core_serverControls INNER JOIN Dictionary_Lang ON core_serverControls.IdDictionary = Dictionary_Lang.id_dictionary WHERE (Dictionary_Lang.id_language = 1) " + khatam.core.UI.ObjectManager.getValidObjectSqlWhere();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        
        SqlDataSource2.SelectCommand = "SELECT     core_invoice.id, core_invoice.payStatus, core_invoice.sendStatus, core_invoice.orderDate, core_invoice.total_order_price, core_invoice.users_id, users.fname, users.lname FROM         core_invoice INNER JOIN       users ON core_invoice.users_id = users.id  WHERE     (core_invoice.users_id = " + khatam.core.Security.Users.login().ToString() + ")  ORDER BY core_invoice.id DESC";
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();



    }



    protected void Button2_Click(object sender, EventArgs e)
    {


        khatam.core.UI.ObjectManager.objectAdd(this.DropDownList1.SelectedValue.ToString(), this.TextBox1.Text);
        hideWins();
        gridsbind();
        this.MSG2.Visible = true;



    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        khatam.core.data.sql.updateField("title", txtEditTitle.Text, "id", LblEditCode.Text, "Core_serverControlsInstance", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        hideWins();
        gridsbind();
        this.MSG2.Visible = true;



    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.hideWins();
        this.TextBox1.Text = "";
        this.msgAdd.Visible = true;
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        this.hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        khatam.core.UI.ObjectManager.objectDelete(Label1.Text);
        hideWins();
        gridsbind();
    }


    void hideWins()
    {
        MSG2.Visible = false;
        MSG3.Visible = false;
        msgAdd.Visible = false;
        msgEdit.Visible = false;

    }

    void gridsbind()
    {
        GridView2.DataBind();
    }


    protected void gv_dataBound(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView2.Rows.Count; i++)
        {
            GridView2.Rows[i].Cells[1].Text = khatam.core.globalization.numbers.GetPersianNumbers(khatam.core.globalization.dateTime.GetPersianDateTime(DateTime.Parse(GridView2.Rows[i].Cells[1].Text)));

            //    GridView2.Rows[i].Cells[6].Text = khatam.shop.invoiceManager. (int.Parse(gv_fish.Rows[i].Cells[6].Text));
        }
    }




    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "del")
        {
            hideWins();
            Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            this.MSG3.Visible = true;

        }

        if (e.CommandName == "pay")
        {

            string pass = khatam.core.data.sql.getField( "idRandom", "id",
               this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text, "core_invoice");

            string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay.aspx?id=" +
                this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text + "&pass=" + pass;
            RedirectTo(url);

        }
    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}