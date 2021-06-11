using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Manage_c_corePermissionRefRole_list : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "مدیریت گروه های کاربری";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_lesson_group.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=ManageUsersGroups\">مدیریت گروه های کاربری</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " مدیریت دسترسی ها";
        l.Text = l.Text + "</span> ";



        this.SqlDataSource1.SelectCommand = " SELECT     corePermission.id, Dictionary_Lang.title " +
        " FROM         corePermissionRefRole INNER JOIN " +
                               " corePermission ON corePermissionRefRole.idPermission = corePermission.id INNER JOIN " +
                              " Dictionary_Lang ON corePermission.IdDictionary = Dictionary_Lang.id_dictionary " +
        " WHERE     (corePermissionRefRole.idRole = " + this.Request.QueryString["id"] + ") AND (Dictionary_Lang.id_language = 1) " +

        " ORDER BY corePermission.title";

        this.SqlDataSource3.SelectCommand = " SELECT     corePermission.id, Dictionary_Lang.title " +
        " FROM         corePermission INNER JOIN " +
                              " Dictionary_Lang ON corePermission.IdDictionary = Dictionary_Lang.id_dictionary "  +
        " WHERE     (corePermission.title NOT IN " +
                  " (SELECT     corePermission_1.title " +
                  " FROM          corePermission AS corePermission_1 INNER JOIN " +
                  " corePermissionRefRole ON corePermission_1.id = corePermissionRefRole.idPermission " +
                  " WHERE      (corePermissionRefRole.idRole = " + this.Request.QueryString["id"] + "))) AND (Dictionary_Lang.id_language = 1) " + khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("corePermission.title") +
                  " ORDER BY corePermission.title";

        
        
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
      


            if (int.Parse(this.Request.QueryString["id"])<10000) 
                Literal1.Text = "کد: " + this.Request.QueryString["id"] + "<br />" + "عنوان گروه: " +
               khatam.core.data.sql.getField("title","id",this.Request.QueryString["id"],"coreRole" );

               
            else
                Literal1.Text = "کد: " + this.Request.QueryString["id"] + "<br />" + "عنوان گروه: " +
           khatam.core.data.sql.getField( "title", "id_dictionary", 
           khatam.core.data.sql.getField( "IdDictionary", "id", this.Request.QueryString["id"], "coreRoleSys"),
           "Dictionary_Lang");
              /**/
              
            


            
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
        this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/");

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
                a.Add("idPermission");
                b.Add(ListBoxAdd.Items[j].Value);

                a.Add("idRole");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Add(a, b, "corePermissionRefRole");
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

                a.Add("idPermission");
                b.Add(this.ListBoxRemove.Items[j].Value);

                a.Add("idRole");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Del(a, b, "corePermissionRefRole", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            }




        }

        gb();
    }


}