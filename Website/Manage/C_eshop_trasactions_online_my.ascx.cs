using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using khatam.core.globalization;

public partial class Manage_C_shop_trasactions_online_my : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "تراکنش های آنلاین من";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/Commercial_catalog.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " تراکنش های آنلاین من";
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

        SqlDataSource2.SelectCommand = "SELECT sbt.resnum, sbt.id_core_invoice, sbt.RefNum, sbt.state, sbt.regDate, sbt.backDate, core_invoice.users_id FROM sbt INNER JOIN core_invoice ON sbt.id_core_invoice = core_invoice.id WHERE (core_invoice.users_id = " + khatam.core.Security.Users.login() + ") ORDER BY sbt.resnum DESC";
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();



    }

    protected void gv_sbt_bound(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView2.Rows.Count; i++)
        {
            GridView2.Rows[i].Cells[4].Text = dateTime.GetPersianDateTime(DateTime.Parse(GridView2.Rows[i].Cells[4].Text));


            if (GridView2.Rows[i].Cells[5].Text != "")
            {
                try
                {
                    GridView2.Rows[i].Cells[5].Text = dateTime.GetPersianDateTime(DateTime.Parse(GridView2.Rows[i].Cells[5].Text));
                }
                catch (Exception)
                {


                }


            }
            if (GridView2.Rows[i].Cells[3].Text != "")
            {
                if (GridView2.Rows[i].Cells[3].Text == "1")
                    GridView2.Rows[i].Cells[3].Text = "موفق";

                if (GridView2.Rows[i].Cells[3].Text == "2")
                    GridView2.Rows[i].Cells[3].Text = "ناموفق";

            }
            // gv_fish.Rows[i].Cells[5].Text = getStateTransaction_Fish(int.Parse(gv_fish.Rows[i].Cells[5].Text));
        }

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


    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

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

        if (e.CommandName == "editcom")
        {
            hideWins();
            this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

            this.msgEdit.Visible = true;

        }
    }

}