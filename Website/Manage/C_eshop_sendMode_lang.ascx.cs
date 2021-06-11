using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Manage_C_shop_sendMode_lang : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = " تنظیمات قوانین ارسال سفارش زبان فارسی";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/site_explorer.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = ">  <a  style=\"color:Black;text-decoration:none;\" href=\"Default.aspx?mode=shop_send_terms\"> قوانین ارسال سفارش - انتخاب زبان </a>";
        l.Text =l.Text  + " > <span style=\" color: #808080\">";
        l.Text = l.Text + " تنظیمات قوانین ارسال سفارش زبان فارسی";
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

   
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();



    }



    protected void Button2_Click(object sender, EventArgs e)
    {


       //## khatam.core.UI.ObjectManager.objectAdd(this.DropDownList1.SelectedValue.ToString(), this.TextBox1.Text);
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
        add_ddl_sendMode.DataSource = getSendMode();
        add_ddl_sendMode.DataTextField = "title";
        add_ddl_sendMode.DataValueField  = "id";
        add_ddl_sendMode.DataBind();


        add_ddl_country.DataSource = khatam.core.globalization.country.getCountryList();
        add_ddl_country.DataTextField = "country_title";
        add_ddl_country.DataValueField = "country_id";
        add_ddl_country.DataBind();

     

      


        this.hideWins();
        
        this.msgAdd.Visible = true;
    }

    public static DataTable getSendMode()
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


        //parameters.Add("field_where_value", field_where_value);
        str_sql = "SELECT  * FROM core_sendMode";
        return DBFunctions.ExecuteReader(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
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


    protected void add_ddl_country_SelectedIndexChanged(object sender, EventArgs e)
    {
        add_ddl_state.DataSource = khatam.core.globalization.state.getStateListByCountry(this.add_ddl_country.SelectedValue );
        add_ddl_state.DataTextField = "state_title";
        add_ddl_state.DataValueField = "state_id";
        add_ddl_state.DataBind();
       
    }
    protected void add_ddl_state_SelectedIndexChanged(object sender, EventArgs e)
    {
        add_ddl_city.DataSource = khatam.core.globalization.city.getCityListByState(this.add_ddl_state.SelectedValue );
        add_ddl_city.DataTextField = "city_title";
        add_ddl_city.DataValueField = "city_id";
        add_ddl_city.DataBind(); 
    }
 
    protected void add_ddl_city_SelectedIndexChanged(object sender, EventArgs e)
    {

        add_ddl_area.DataSource = khatam.core.globalization.area.getAreaListByCity(this.add_ddl_city.SelectedValue);
        add_ddl_area.DataTextField = "area_title";
        add_ddl_area.DataValueField = "area_id";
        add_ddl_area.DataBind();
    }

    protected void add_ddl_area_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}