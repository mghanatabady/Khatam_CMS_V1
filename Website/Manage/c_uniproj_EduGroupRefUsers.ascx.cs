using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Manage_c_uniproj_EduGroupRefUsers : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دانشگاه: انقیاد اساتید و گروه های آموزشی";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/Category.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=uniproj_eduGrroup_list_all\">دانشگاه: مدیریت گروه های آموزشی</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " دانشگاه: انقیاد اساتید و گروه های آموزشی";
        l.Text = l.Text + "</span> ";


        this.SqlDataSourceAll.SelectCommand =
            " SELECT     id, fname + ' ' + lname as title " +
" FROM         users " +
" WHERE     (id NOT IN " +
          "                (SELECT     users_1.id " +
         "                   FROM          uniproj_EduGroupRefUsers AS uniproj_EduGroupRefUsers_1 INNER JOIN " +
                           "                        users AS users_1 ON uniproj_EduGroupRefUsers_1.idUser = users_1.id " +
                          "  WHERE      (uniproj_EduGroupRefUsers_1.idEduGroup = " + this.Request.QueryString["id"] + ")))";

//" WHERE     (corePermissionRefUser.idUser = " + this.Request.QueryString["id"] + ") AND (Dictionary_Lang.id_language = 1) " +

  //khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("corePermission.title") +
        
      

// AND (corePermission.title LIKE N'%article%')" +
 //"        ORDER BY corePermission.title ";

        
        this.SqlDataSourceSelected.SelectCommand =
        "    SELECT     Users.id, users.fname + ' ' + users.lname AS title " +
" FROM         uniproj_EduGroupRefUsers INNER JOIN  " +
  "                    users ON uniproj_EduGroupRefUsers.idUser = users.id " +
" WHERE     (uniproj_EduGroupRefUsers.idEduGroup = " + this.Request.QueryString["id"] + " ) ";

            
            /*"SELECT     corePermission.id, Dictionary_Lang.title, Dictionary_Lang.id_language " +
" FROM         corePermission INNER JOIN " +
  "                    Dictionary_Lang ON corePermission.IdDictionary = Dictionary_Lang.id_dictionary " +
" WHERE     (corePermission.title NOT IN " +
  "                        (SELECT     corePermission_1.title " +
   "                         FROM          corePermission AS corePermission_1 INNER JOIN " +
    "                                               corePermissionRefUser ON corePermission_1.id = corePermissionRefUser.idPermission " +
     "                       WHERE      (corePermissionRefUser.idUser = " + this.Request.QueryString["id"] + " ))) AND (Dictionary_Lang.id_language = 1)  " + khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("corePermission.title") +

      "  ORDER BY corePermission.title";*/


        if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "uniproj_EduGroupRefUsers") == false)
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

        this.SqlDataSourceAll.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        this.SqlDataSourceSelected.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        
        if (this.Page.IsPostBack == false)
        {
            Literal1.Text = "کد گروه آموزشی: " + this.Request.QueryString["id"] + "<br />" + "عنوان: " +
                khatam.core.data.sql.getField( "title", "id", this.Request.QueryString["id"], "uniproj_eduGroup");
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
                a.Add("idUser");
                b.Add(ListBoxAdd.Items[j].Value );

                a.Add("idEduGroup");
                b.Add(this.Request.QueryString["id"].ToString());

                khatam.core.data.sql.Add(a, b, "uniproj_EduGroupRefUsers");

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

                a.Add("idUser");
                b.Add(this.ListBoxRemove.Items[j].Value);
               // b.Add("1");

                a.Add("idEduGroup");
                b.Add(this.Request.QueryString["id"].ToString());
                //b.Add("4");

                khatam.core.data.sql.Del(a, b, "uniproj_EduGroupRefUsers", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

            }




        }

        gb();
    }
}