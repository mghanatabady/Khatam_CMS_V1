using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;


public partial class Manage_c_coreRoleRefUserList : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "مدیریت گروه های کاربری";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_lesson_group.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=ManageUsersGroups\">مدیریت گروه های کاربری</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " مدیریت اعضا";
        l.Text = l.Text + "</span> ";

        if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "ManageUsersGroups") == false)
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
            if (int.Parse(this.Request.QueryString["id"]) < 10000)
                Literal1.Text = "کد: " + this.Request.QueryString["id"] + "<br />" + "عنوان گروه: " +
               khatam.core.data.sql.getField( "title", "id", this.Request.QueryString["id"], "coreRole");


            else
                Literal1.Text = "کد: " + this.Request.QueryString["id"] + "<br />" + "عنوان گروه: " +
           khatam.core.data.sql.getField( "title", "id_dictionary",
           khatam.core.data.sql.getField("IdDictionary", "id", this.Request.QueryString["id"], "coreRoleSys"),
           "Dictionary_Lang");
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
                a.Add("idUser");
                b.Add(ListBoxAdd.Items[j].Value);

                a.Add("idRole");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Add(a, b, "coreRoleRefUser");
            }




        }

        gb();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        for (int j = 0; j < this.ListBoxRemove.Items.Count; j++)
        {

           if (this.ListBoxRemove.Items[j].Selected)
           {

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();

                a.Add("idUser");
                //b.Add(1);
                b.Add(ListBoxRemove.Items[j].Value);

           
                a.Add("idRole");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Del(a, b, "coreRoleRefUser", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

           }




        }

        gb();
    }

}