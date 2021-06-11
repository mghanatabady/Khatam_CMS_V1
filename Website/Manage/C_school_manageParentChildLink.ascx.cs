using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;


public partial class Manage_C_school_manageParentChildLink : System.Web.UI.UserControl
{


    protected void Page_Load(object sender, EventArgs e)
    {
        string sqlstr = "";


       // GridView2.Columns[10].Visible = false;




     
                    sqlstr = "SELECT DISTINCT users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone"
+ " FROM users INNER JOIN"
+ " corePermissionRefUser ON users.id = corePermissionRefUser.idUser INNER JOIN"
+ " corePermission ON corePermissionRefUser.idPermission = corePermission.id"
+ " WHERE (corePermission.title = N'school_View_reportCard_linked_parent') OR"
+ " (corePermission.title = N'school_View_ClassGrade_linked_parent')"
+ " UNION"
+ " SELECT DISTINCT users_1.id, users_1.email, users_1.fname, users_1.lname, users_1.company, users_1.tel, users_1.fax, users_1.cellphone"
+ " FROM corePermission AS corePermission_1 INNER JOIN"
+ " corePermissionRefRole ON corePermission_1.id = corePermissionRefRole.idPermission INNER JOIN"
+ " coreRoleRefUser ON corePermissionRefRole.idRole = coreRoleRefUser.idRole INNER JOIN"
+ " users AS users_1 ON coreRoleRefUser.idUser = users_1.id"
+ " WHERE (corePermission_1.title = N'school_View_reportCard_linked_parent') OR"
+ " (corePermission_1.title = N'school_View_ClassGrade_linked_parent')";
     

        //Label2.Text = Request.QueryString["p"];



        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            this.Button1.Enabled = false;
            this.Button1.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button2.Enabled = false;
            this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button4.Enabled = false;
            this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }

        //khatam.core.data.sql.


        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }


        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.SelectCommand = sqlstr;


    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=school_manageParentChildLink_select&id=" + this.GridView2.SelectedRow.Cells[0].Text);
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

    }
}
