using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;



public partial class Manage_C_sections : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "صفحات";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/section.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " صفحات";
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

        
        this.txt_sectionTitle.Attributes.Add("onkeypress", "return isAlphabeticKey(event)");

        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }

        SqlDataSource1.SelectCommand = "SELECT  [id]      ,REPLACE( [title],'.aspx','') as title     ,[yuig]      ,[yui_id]      ,[yui_class]      ,[background_color]      ,[background_image]      ,[background_repeat]      ,[background_attachment]      ,[keywords]      ,[Description]      ,[Author]      ,[IdDictionary]  FROM [local].[dbo].[Core_section] " + khatam.core.UI.ObjectManager.getValidObjectSqlWhere();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        SqlDataSource4.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.hideWins();
        this.txt_sectionTitle.Text = "";
        this.msgAdd.Visible = true;


    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (khatam.core.data.sql.Sql_Check_identity("title","_"+ txt_sectionTitle.Text, "core_section_option", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();
            a.Add("title");
            b.Add("_" + txt_sectionTitle.Text);

            string section_option_id = khatam.core.data.sql.Add(a, b, "Core_section_option");

           /// khatam.core.UI.SectionManager. addSection_Option_Property(section_option_id);

            khatam.core.UI.SectionManager.addSectionProperty(section_option_id);


            gridsbind();
            hideWins();
            this.MSG2.Visible = true;
        }
        else
        {
            lbl_section_add_uniq_error.Text = "نام صفحه انتخابی شما تکراری است";
        }

   
        
        
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
        khatam.core.data.sql.Sql_Del_Row("id_Core_section_option", Label1.Text, "Core_sectionVal_option",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        khatam.core.data.sql.Sql_Del_Row("id_setting_section", Label1.Text, "Core_serverControlsInstancePlacing",
    khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        khatam.core.data.sql.Sql_Del_Row("id", Label1.Text, "Core_section_option",
           khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        gridsbind();
        hideWins();
        MSG_delOk.Visible = true;


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

    void hideWins()
    {
        MSG2.Visible = false;
        MSG3.Visible = false;
        msgAdd.Visible = false;
        msgEdit.Visible = false;
        MSG_delOk.Visible = false;
        lbl_section_add_uniq_error.Text = "";
    }

    void gridsbind()
    {
        GridView2.DataBind();
    }

    protected void btn_Save_Click(object sender, EventArgs e)
    {

    }
    protected void btn_restore_Click(object sender, EventArgs e)
    {

    }
}