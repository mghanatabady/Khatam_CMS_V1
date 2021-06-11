using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Manage_c_shop_sendMode_instance : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "شیوه های ارسال سفارش > شهرها / مناطق";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/trasport.gif";

        string naviUrl = "<a href=\"?mode=shop_sendMode\"  style=\"color: black; text-decoration: none\"  >شیوه های ارسال سفارش</a>";

        

        Literal l = (Literal)this.Parent.FindControl("Literal1");

        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text +  naviUrl ;
        l.Text = l.Text;
        l.Text = l.Text + "</span> ";

        l.Text = l.Text +" > <span style=\" color: #808080\">";
        l.Text = l.Text + " شهر ها / مناطق ";
        l.Text = l.Text;
        l.Text = l.Text + "</span> ";


       
        //string weArehere;
       // weArehere = khatam.core.explorer.generateUrl_link(idpage_content);


        //Label c = (Label)this.Parent.FindControl("lblMainTitle");
       // c.Text = weArehere;

        //Image d = (Image)this.Parent.FindControl("imgMainTitle");
        //d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/title_iblock.gif";

        //Literal l = (Literal)this.Parent.FindControl("Literal1");
        //l.Text = " > <span style=\" color: #808080\">";
        //l.Text = l.Text + weArehere;
        //l.Text = l.Text + "</span> ";



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
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource33.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource22.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource11.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();


    }



    protected void Button2_Click(object sender, EventArgs e)
    {

        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("country_id");
        b.Add(DropDownList1.SelectedValue);

        a.Add("state_id");
        b.Add(DropDownList2.SelectedValue);

        a.Add("city_id");
        b.Add(DropDownList3.SelectedValue);

        a.Add("sendMode_id");
        b.Add(this.Request.QueryString["id"]);

        if (khatam.core.data.sql.Sql_Check_identityArray(a, b, "core_sendMode_Instance", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
        {

            khatam.core.data.sql.Add(a, b, "core_sendMode_Instance");
            hideWins();
            gridsbind();
            this.MSG2.Visible = true;
        }
        else
        {
            add_msg_error_identity.Visible = true;
        }

   



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
        //this.TextBox1.Text = "";
        this.msgAdd.Visible = true;
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        this.hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //khatam.core.UI.ObjectManager.objectDelete(Label1.Text);
        khatam.core.data.sql.Sql_Del_Row("id", Label1.Text, "core_sendMode_Instance", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        hideWins();
        gridsbind();
    }


    void hideWins()
    {
        MSG2.Visible = false;
        MSG3.Visible = false;
        msgAdd.Visible = false;
        msgEdit.Visible = false;
        add_msg_error_identity.Visible =false ;

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