using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Manage_c_corePermissionRefUser_list : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "مدیریت کاربران";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_user.jpg";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=ManagerUsers\">مدیریت کاربران</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " مدیریت دسترسی ها";
        l.Text = l.Text + "</span> ";


        this.SqlDataSource1.SelectCommand =   " SELECT     corePermission.id, corePermissionRefUser.idUser, Dictionary_Lang.title " +
" FROM         corePermissionRefUser INNER JOIN" +
 "                     corePermission ON corePermissionRefUser.idPermission = corePermission.id INNER JOIN " +
                      " Dictionary_Lang ON corePermission.IdDictionary = Dictionary_Lang.id_dictionary " +
" WHERE     (corePermissionRefUser.idUser = " + this.Request.QueryString["id"] + ") AND (Dictionary_Lang.id_language = 1) " +

  khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("corePermission.title") +
        
      

// AND (corePermission.title LIKE N'%article%')" +
 "        ORDER BY corePermission.title ";

        this.SqlDataSource3.SelectCommand = "SELECT     corePermission.id, Dictionary_Lang.title, Dictionary_Lang.id_language " +
" FROM         corePermission INNER JOIN " +
  "                    Dictionary_Lang ON corePermission.IdDictionary = Dictionary_Lang.id_dictionary " +
" WHERE     (corePermission.title NOT IN " +
  "                        (SELECT     corePermission_1.title " +
   "                         FROM          corePermission AS corePermission_1 INNER JOIN " +
    "                                               corePermissionRefUser ON corePermission_1.id = corePermissionRefUser.idPermission " +
     "                       WHERE      (corePermissionRefUser.idUser = " + this.Request.QueryString["id"] + " ))) AND (Dictionary_Lang.id_language = 1)  " + khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("corePermission.title") +

      "  ORDER BY corePermission.title";


       // if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "ManagerUsers") == false)
      //  {
        //    this.Response.Redirect("~/manage/?mode=msgPermisson");
      //  }

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
                khatam.core.Security.Users.getRealName(this.Request.QueryString["id"])  ;
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


            if (ListBoxAdd.Items[j].Selected )
            {
                //GridView1.Rows[j].BackColor = System.Drawing.Color.LightGreen;

                ArrayList a = new ArrayList();
                ArrayList b = new ArrayList();
                a.Add("idPermission");
                b.Add(ListBoxAdd.Items[j].Value );

                a.Add("idUser");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Add(a, b, "corePermissionRefUser");

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

                a.Add("idUser");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Del(  a, b, "corePermissionRefUser", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            }




        }

        gb();
    }
}