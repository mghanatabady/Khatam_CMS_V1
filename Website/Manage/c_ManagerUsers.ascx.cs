using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Linq;


public partial class Manage_c_ManagerUsers : System.Web.UI.UserControl
{



    protected void Page_Load(object sender, EventArgs e)
    {


        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "مدیریت کاربران";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_user.jpg";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " مدیریت کاربران";
        l.Text = l.Text + "</span> ";



        string sqlstr = "";


        if (!Page.IsPostBack)
        {
            Label2.Text = "همه موارد";
            ViewState["strOrderBy"] = " ORDER BY id DESC ";
        }




        switch (Request.QueryString["p"])
        {
            case null:

                if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "ManagerUsers") == false)
                {
                   // this.Response.Redirect("~/manage/?mode=msgPermisson");
                }
                else
                {
                    sqlstr = "SELECT [id], [email], [fname], [lname], [company], [tel], [fax], [cellphone] FROM [users] " + ViewState["strWhere"] + ViewState["strOrderBy"];

                }
                break;

            case "student":

                if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "school_student") == false)
                {
                    this.Response.Redirect("~/manage/?mode=msgPermisson");

                }
                else
                {
                    sqlstr = "SELECT DISTINCT users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone"
+ " FROM users INNER JOIN"
+ " corePermissionRefUser ON users.id = corePermissionRefUser.idUser INNER JOIN"
+ " corePermission ON corePermissionRefUser.idPermission = corePermission.id"
+ " WHERE (corePermission.title = N'school_View_reportCard_linked_student') OR"
+ " (corePermission.title = N'school_View_ClassGrade_linked_student')"
+ " UNION"
+ " SELECT DISTINCT users_1.id, users_1.email, users_1.fname, users_1.lname, users_1.company, users_1.tel, users_1.fax, users_1.cellphone"
+ " FROM corePermission AS corePermission_1 INNER JOIN"
+ " corePermissionRefRole ON corePermission_1.id = corePermissionRefRole.idPermission INNER JOIN"
+ " coreRoleRefUser ON corePermissionRefRole.idRole = coreRoleRefUser.idRole INNER JOIN"
+ " users AS users_1 ON coreRoleRefUser.idUser = users_1.id"
+ " WHERE (corePermission_1.title = N'school_View_reportCard_linked_student') OR"
+ " (corePermission_1.title = N'school_View_ClassGrade_linked_student')";
                }
                break;

            case "parent":

                if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "school_student") == false)
                {
                    this.Response.Redirect("~/manage/?mode=msgPermisson");

                }
                else
                {
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
                }
                break;

            case "teacher":

                if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "school_teacher") == false)
                {
                    this.Response.Redirect("~/manage/?mode=msgPermisson");

                }
                else
                {


                    sqlstr = "SELECT DISTINCT users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone"
+ " FROM users INNER JOIN"
+ " corePermissionRefUser ON users.id = corePermissionRefUser.idUser INNER JOIN"
+ " corePermission ON corePermissionRefUser.idPermission = corePermission.id"
+ " WHERE (corePermission.title = N'school_declaration_reportCard_teacher') OR"
+ " (corePermission.title = N'school_declaration_ClassGrade_teacher')"
+ " UNION"
+ " SELECT DISTINCT users_1.id, users_1.email, users_1.fname, users_1.lname, users_1.company, users_1.tel, users_1.fax, users_1.cellphone"
+ " FROM users AS users_1 INNER JOIN"
+ " coreRoleRefUser ON users_1.id = coreRoleRefUser.idUser INNER JOIN"
+ " corePermissionRefRole ON coreRoleRefUser.idRole = corePermissionRefRole.idRole INNER JOIN"
+ " corePermission AS corePermission_1 ON corePermissionRefRole.idPermission = corePermission_1.id"
+ " WHERE (corePermission_1.title = N'school_declaration_reportCard_teacher') OR"
+ " (corePermission_1.title = N'school_declaration_ClassGrade_teacher')";
                }
                break;
            default:


                this.Response.Redirect("~/manage/?mode=msgPermisson");


                break;
        }


        //Label2.Text = Request.QueryString["p"];



        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            //    this.Button2.Enabled = false;
            //   this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            //  this.Button4.Enabled = false;
            //    this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }

        //khatam.core.data.sql.


        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }


        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        //if (!Page.IsPostBack)
        // {
        SqlDataSource2.SelectCommand = sqlstr;
        // }


        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();


    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("id");
        b.Add(this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text);
        khatam.core.data.sql.Del(a, b, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        hideWins();
        GridView1.DataBind();
    }


 


    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            for (int j = 0; j <= 7; j++)
            {
                GridView1.Rows[i].Cells[j].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView1.Rows[i].Cells[j].Text);
            }
        }



        //  if (e.Row.RowType == DataControlRowType.DataRow)
        // {
        //ExpanseExample.Expanse expanse = e.Row.DataItem as ExpanseExample.Expanse;
        //(e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        // (e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        //(e.Row.FindControl("lnkDelete") as LinkButton).CommandArgument = e.Row.Cells[0].Text;
        //  }
    }

    void hideWins()
    {
        // MSG2.Visible = false;
        //   MSG3.Visible = false;
        //msgAdd.Visible = false;
        //   msgEdit.Visible = false;

    }
    khatam.core.UI.WebControls.membrshipWin mw = new khatam.core.UI.WebControls.membrshipWin();



    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {







    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }



    protected void BtnAddOk_Click(object sender, EventArgs e)
    {
        DNA.UI.JQuery.Dialog dialog = new DNA.UI.JQuery.Dialog();

        // membership_form.Controls.Add(dialog); 
    }


    protected void imgbtn_Click(object sender, ImageClickEventArgs e)
    {

        //ImageButton btndetails = sender asImageButton;

        //GridViewRow gvrow = (GridViewRow)btndetails.NamingContainer;

        //lblID.Text = gvdetails.DataKeys[gvrow.RowIndex].Value.ToString();

        //lblusername.Text = gvrow.Cells[1].Text;

        //txtfname.Text = gvrow.Cells[2].Text;

        //txtlname.Text = gvrow.Cells[3].Text;

        //txtCity.Text = gvrow.Cells[4].Text;

        //txtDesg.Text = gvrow.Cells[5].Text;

        //this.ModalPopupExtender1.Show();

    }




    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        SqlDataSource1.SelectCommand= 
             
  "                                  SELECT     coreRoleSys.id, Dictionary_Lang.title    " +
" FROM         coreRoleSys INNER JOIN " +
                      " Dictionary_Lang ON coreRoleSys.IdDictionary = Dictionary_Lang.id_dictionary " +
                      "                                   union " +
                      "            SELECT id,title FROM [coreRole] " 
                      
                      ;

        DropDownList1.DataBind();
        
        if (khatam.core.License.ValidModule("uniproj"))
        {
            this.add_div_teacher_code.Visible = true;
        }
        else
        {
            this.add_div_teacher_code.Visible = false ;
        }

        add_txt_fname.Text = "";
        add_txt_lname.Text = "";
        add_txt_lname.Text = "";

        add_txt_teacher_code.Text = "";
        add_txt_company.Text  = "";
        add_txt_tel.Text = "";
        add_txt_fax.Text  = "";
        add_txt_cellphone.Text = "";
        add_txt_country.Text = "";
        add_txt_stats.Text = "";
        add_txt_city.Text = "";
        add_txt_address.Text = "";
        add_txt_zipcode.Text = "";
        add_txt_email.Text = "";
        add_txt_password.Text = "";


        UpdatePanel1_ModalPopupExtender.Show();


    }
    protected void msg_ok_Click(object sender, EventArgs e)
    {
        GridView1.Visible = false;
    }
    protected void msgerroIdentity_back_Click(object sender, EventArgs e)
    {
        //  UpdatePanel1_MsgIdentytyError.Hide(); 
        //UpdatePanel1_ModalPopupExtender2.Show();
        //UpdatePanel1_ModalPopupExtender.Show();
        GridView1.Visible = false;
    }
    protected void add_dialog_save_Click(object sender, EventArgs e)
    {




        bool checkIdentity = false;

        checkIdentity = khatam.core.data.sql.Sql_Check_identity("email", add_txt_email.Text, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        if (checkIdentity)
        {

            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("username");
            b.Add("a");


            a.Add("fname");
            b.Add(add_txt_fname.Text);

            a.Add("lname");
            b.Add(add_txt_lname.Text);

            a.Add("company");
            b.Add(add_txt_company.Text);

            a.Add("tel");
            b.Add(add_txt_tel.Text);

            a.Add("fax");
            b.Add(add_txt_fax.Text);

            a.Add("CellPhone");
            b.Add(add_txt_cellphone.Text);

            a.Add("country");
            b.Add(add_txt_country.Text);

            a.Add("Stats");
            b.Add(add_txt_stats.Text);

            a.Add("City");
            b.Add(add_txt_city.Text);

            a.Add("Address");
            b.Add(add_txt_address.Text);


            a.Add("ZipCode");
            b.Add(this.add_txt_zipcode.Text);

            string passwordSalt = khatam.core.Security.Users.CreateSalt(10);
            a.Add("passwordSalt");
            b.Add(passwordSalt);

            a.Add("password");
            b.Add(khatam.core.Security.Users.CreatePasswordHash(add_txt_password.Text, passwordSalt));


            a.Add("email");
            b.Add(add_txt_email.Text);

            string EmailSalt = khatam.core.Security.Users.CreateSalt(20);
            a.Add("activeEmailSalt");
            b.Add(EmailSalt);

            a.Add("active");
            b.Add(false);

            string idUsers;


            idUsers = khatam.core.data.sql.AddScope(a, b, "users");

            ArrayList aa = new ArrayList();
            ArrayList bb = new ArrayList();

            aa.Add("idRole");
            bb.Add(this.DropDownList1.SelectedValue);

            aa.Add("idUser");
            bb.Add(idUsers);

            khatam.core.data.sql.Add(aa, bb, "coreRoleRefUser");

            khatam.core.email.sendMembershipActive(add_txt_email.Text, EmailSalt, add_txt_password.Text);

            UpdatePanel1_ModalPopupExtender3.Show();

           // System.Threading.Thread.Sleep(2000);

            // membership_form.Visible = false;
            //  panelmsgok.Visible = true;

            GridView1.DataBind();

            //##this.Page.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/login");
        }
        else
        {
            //  GridView1.Rows[0].Cells[0].Text = "eeee";
            UpdatePanel1_ModalPopupExtender2.Show();
            //  }
           
        }

        // UpdatePanel1_ModalPopupExtender.Hide();

    }
    protected void add2_dialog_save_Click(object sender, EventArgs e)
    {
        
        UpdatePanel1_ModalPopupExtender.Show();


    }
    protected void Button1112_Click(object sender, EventArgs e)
    {

    }
    protected void Button1112_Click1(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(2000);
    }
    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_Modal_gridSetting.Show();
    }
    protected void ImageButton_fillter_del_Click(object sender, ImageClickEventArgs e)
    {




            ViewState["strWhere"] = "";
   


            Label2.Text = "همه موارد";
     
        gridBind();


    }

    protected void Button_filter_ok_Click(object sender, EventArgs e)
    {
        // ViewState("Counter"), 
        string strWhereTemp = "";

        strWhereTemp = whereGenerator(filter_txt_id, "id", "");
        //strWhereTemp = strWhereTemp + whereGenerator(filter_txt_email, "email", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_fname, "fname", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_lname, "lname", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_company, "company", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_tel, "tel", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_cellphone, "cellphone", strWhereTemp);



        if (strWhereTemp != "")
        {
            ViewState["strWhere"] = " WHERE  " + strWhereTemp;
        }
        else
        {
            ViewState["strWhere"] = "";
        }


        string strSyntaxFaTemp = "";

        strSyntaxFaTemp = searchSyntaxGeneratorFa("کد", filter_txt_id.Text, strSyntaxFaTemp);
        //strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام کاربری", filter_txt_email.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام", filter_txt_fname.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام خانوادگی", filter_txt_lname.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("شرکت", filter_txt_company.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("تلفن", filter_txt_tel.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("موبایل", filter_txt_cellphone.Text, strSyntaxFaTemp);

        if (strSyntaxFaTemp != "")
        {
            Label2.Text = strSyntaxFaTemp;
        }
        else
        {
            Label2.Text = "همه موارد";
        }

        gridBind();


    }



   void  gridBind()
    {
                string sqlstr = "SELECT [id], [email], [fname], [lname], [company], [tel], [fax], [cellphone] FROM [users]     " + ViewState["strWhere"] + ViewState["strOrderBy"];
        SqlDataSource2.SelectCommand = sqlstr;
        GridView1.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    public string whereGenerator(TextBox TxtCtrl, string colName, string parentStr)
    {
        string strWhereTemp = "";
        if (TxtCtrl.Text != "")
        {
            if (parentStr != "")
            {
                strWhereTemp = strWhereTemp + " and (" + colName + " like N'%" + TxtCtrl.Text + "%')";
            }
            else
            {
                strWhereTemp = strWhereTemp + " ( " + colName + " like N'%" + TxtCtrl.Text + "%')";

            }

        }

        return strWhereTemp;

    }

    public string searchSyntaxGeneratorFa(string colNameFa, string Value, string parentStr)
    {
        string strWhereTemp = "";

        if (Value != "")
        {
            if (parentStr != "")
            {
                strWhereTemp = strWhereTemp + " و (" + colNameFa + " شبیه به '" + Value + "' باشد)";
            }
            else
            {
                strWhereTemp = strWhereTemp + " ( " + colNameFa + " شبیه به '" + Value + "' باشد)";

            }

        }

        return strWhereTemp;

    }
    protected void del_dialog_yes_Click(object sender, EventArgs e)
    {
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList(); 

        a.Add("id");
        b.Add(khatam.core.globalization.numbers.GetGeorgianNumbers( del_lbl_code.Text ) );
        khatam.core.data.sql.Del(a, b, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        gridBind();

    }
    protected void btn_small_invoice_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        RedirectTo("~/manage/?mode=eshop_invoices_list&user_id=" + khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text));

    }

    protected void ImageButton_fillter_Click(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_Modal_gridFilter.Show();

    }
    protected void btn_small_per_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        RedirectTo("~/manage/?mode=corePermissionRefUser_list&id=" + khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text));

    }
    protected void btn_small_del_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        del_lbl_code.Text = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text);
        this.UpdatePanel1_Modal_msgDel.Show();
    }
    protected void btn_small_Announcement_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);

        string userId = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text); 

        msgAnnouncement_lbl_id.Text = userId;
        msgAnnouncement_lbl_titleRealname.Text = this.GridView1.Rows[rowIndex].Cells[2].Text + ' ' + this.GridView1.Rows[rowIndex].Cells[3].Text + ' '
             + this.GridView1.Rows[rowIndex].Cells[1].Text;

        

           
        CKEditor1.Text =khatam.core.data.sql.getField("Announcement","id",userId,"users");

       // msgAnnouncement_lbl_titleRealname.Text = "سید مصطفی قنات ابادی";
        UpdatePanel1_msgAnnouncement.Show();
    }
    protected void msgAnnouncement_ok_Click(object sender, EventArgs e)
    {
            //msgAnnouncement_lbl_id.Text 
        khatam.core.data.sql.updateField("Announcement", CKEditor1.Text, "id", msgAnnouncement_lbl_id.Text, "users",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


    }
    protected void msgAnnouncement_cancel_Click(object sender, EventArgs e)
    {

    }
}



