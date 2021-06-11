using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;


public partial class Manage_C_school_manageParentChildLink_select : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //this.SqlDataSource1.SelectCommand = "SELECT     school_StudentRefParent.idStudent, users.fname + ' ' + users.lname AS realname
//FROM         school_StudentRefParent INNER JOIN
                      //users ON school_StudentRefParent.idStudent = users.id
//WHERE     (school_StudentRefParent.IdParent = 35) ";
        //+ this.Request.QueryString["id"] + ") AND (Dictionary_Lang.id_language = 1) " +// AND (corePermission.title LIKE N'%article%')" +
        //"        ORDER BY corePermission.title ";

        //this.SqlDataSource3.SelectCommand = "SELECT     id, email, realname FROM         View_Student WHERE     (id NOT IN    (SELECT     users.id      FROM          school_StudentRefParent INNER JOIN        users ON school_StudentRefParent.userId = users.id))";


        if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "school_manageParentChildLink") == false)
        {
            this.Response.Redirect("~/manage/?mode=msgPermisson");
        }

        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            this.BtnAdd.Enabled = false;
            this.BtnAdd.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.BtnRemove.Enabled = false;
            this.BtnRemove.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
        }

        this.SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        this.SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        if (this.Page.IsPostBack == false)
        {
            Literal1.Text = "کد کاربر: " + this.Request.QueryString["id"] + "<br />" + "نام و نام خانوادگی: " +
                khatam.core.Security.Users.getRealName(this.Request.QueryString["id"]);
            gb();
        }


    }


    void gb()
    {

        this.ListBoxAdd.DataBind();
        this.ListBoxRemove.DataBind();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("~/manage/");
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        for (int j = 0; j < this.ListBoxAdd.Items.Count; j++)
        {

            //CheckBox chbox = new CheckBox();
            //chbox = ListBoxAdd.se ;


            //  Label1.Text = chbox.Checked.ToString();


            if (ListBoxAdd.Items[j].Selected)
            {
                //GridView1.Rows[j].BackColor = System.Drawing.Color.LightGreen;

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();
                a.Add("idStudent");
                b.Add(ListBoxAdd.Items[j].Value);

                a.Add("IdParent");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Add(a, b, "school_StudentRefParent");

            }




        }

        gb();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        for (int j = 0; j < this.ListBoxRemove.Items.Count; j++)
        {

            //  khatam.core.data.sql.ErrorLogAdd(j.ToString());



            if (this.ListBoxRemove.Items[j].Selected)
            {

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("idStudent");
                b.Add(this.ListBoxRemove.Items[j].Value);

                a.Add("IdParent");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Del(a, b, "school_StudentRefParent", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            }




        }

        gb();
    }
}