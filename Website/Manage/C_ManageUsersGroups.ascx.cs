using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Manage_C_ManageUsersGroups : System.Web.UI.UserControl
{



    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "مدیریت گروه های کاربری";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_lesson_group.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " مدیریت گروه های کاربری";
        l.Text = l.Text + "</span> ";


        //this.Label2.Text = khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "article333333").ToString();
        if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "ManageUsersGroups") == false)
        {
            this.Response.Redirect("~/manage/?mode=msgPermisson");
        }

        if (khatam.core.ConfigurationManager.License.demo == true)
        {
          //  this.Button1.Enabled = false;
          //  this.Button1.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
          //  this.Button2.Enabled = false;
          //  this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
          //  this.Button4.Enabled = false;
          //  this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }

        //khatam.core.data.sql.


        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }

        //SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        if (!Page.IsPostBack)
        {
            Label2.Text = "همه موارد";
            ViewState["strOrderBy"] = " ORDER BY id DESC ";
        }



        gridsbind();
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("title");
        //b.Add(this.TextBox1.Text );

        khatam.core.data.sql.Add(a, b, "coreRole");
 
        hideWins();
        gridsbind();
        //this.MSG2.Visible = true;
    }

    void gridsbind()
    {

        //SqlDataSource2.SelectCommand = "SELECT *  FROM [coreRole] " + ViewState["strWhere"] + ViewState["strOrderBy"]; ;

        SqlDataSource2.SelectCommand = "SELECT *  FROM [coreRoleSys] " + ViewState["strWhere"] + ViewState["strOrderBy"];

        SqlDataSource2.SelectCommand = " SELECT  coreRoleSys.id, Dictionary_Lang.title "
+ " FROM         coreRoleSys INNER JOIN "
  + " Dictionary_Lang ON coreRoleSys.IdDictionary = Dictionary_Lang.id_dictionary "
+ " WHERE     (Dictionary_Lang.id_language = 1) " + khatam.core.UI.ObjectManager.getValidPermissonSqlWhere("coreRoleSys.Module")
+ ViewState["strWhere"] 
+ " UNION   SELECT     id, title   FROM         coreRole   " + ViewState["strWhere2"] + ViewState["strOrderBy"];

        

        GridView1.DataBind();
       //    GridView2.Rows[0].Cells[2].Text = "";
         //   GridView2.Rows[0].Cells[3].Text = "";
       

       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //khatam.core.data.sql.updateField("title", txtEditTitle.Text, "id", LblEditCode.Text, "coreRole", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        hideWins();
        gridsbind();
       // this.MSG2.Visible = true;

    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        this.hideWins();

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ///khatam.core.data.sql.Sql_Del_Row("idRole",Label1.Text ,"coreRoleRefUser",khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        ///khatam.core.data.sql.Sql_Del_Row("id", Label1.Text, "coreRole", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        hideWins();
        gridsbind();

    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //this.Response.Redirect("~/manage/?mode=corePermissionRefRole_list&id=" + this.GridView2.SelectedRow.Cells[0].Text);
    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
       // this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "del")
        {
            hideWins();
            //Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            //this.MSG3.Visible = true;

        }

        if (e.CommandName == "editcom")
        {
            hideWins();
            ///this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            ///this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            //this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

           // this.msgEdit.Visible = true;

        }

        if (e.CommandName == "editMember")
        {
         ///   Response.Redirect("~/manage/?mode=coreRoleRefUserList&id=" + this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text);

        }

    }

    void hideWins()
    {
       // MSG2.Visible = false;
      //  MSG3.Visible = false;
       // msgAdd.Visible = false;
      //  msgEdit.Visible = false;

    }





    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.hideWins();
       // this.TextBox1.Text = "";
       // this.msgAdd.Visible = true;
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {

    }
    protected void ImageButton_fillter_Click(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_Modal_gridFilter.Show();

    }
    protected void ImageButton_fillter_del_Click(object sender, ImageClickEventArgs e)
    {

        ViewState["strWhere"] = "";



        Label2.Text = "همه موارد";

        gridBind();
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        this.add_txt_title.Text = "";
        UpdatePanel1_Modal_msgAdd.Show();
    }
    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {

    }
    protected void btn_small_per_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
       // del_lbl_code.Text = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text);


        RedirectTo("~/manage/?mode=corePermissionRefRole_list&id=" + khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text));
    }
    protected void btn_small_del_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
       del_lbl_code.Text = this.GridView1.Rows[rowIndex].Cells[0].Text;
      
        UpdatePanel1_Modal_msgDel.Show();
    }
    protected void btn_small_Announcement_Click(object sender, ImageClickEventArgs e)
    {

        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);

        string userId = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text);

        msgAnnouncement_lbl_id.Text = userId;
        msgAnnouncement_lbl_titleRealname.Text =  this.GridView1.Rows[rowIndex].Cells[1].Text;
        if (int.Parse(userId) > 1000)
        {
            CKEditor1.Text = khatam.core.data.sql.getField( "Announcement", "id", userId, "coreRoleSyS");
        }
        else
        {
            CKEditor1.Text = khatam.core.data.sql.getField( "Announcement", "id", userId, "coreRole");

        }

        // msgAnnouncement_lbl_titleRealname.Text = "سید مصطفی قنات ابادی";
        UpdatePanel1_msgAnnouncement.Show();


    }


    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            //GridView1.Rows[0].Cells[2].Text = GridView1.Rows[i].FindControl("btn_small_del").ID;
            if (int.Parse(khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[i].Cells[0].Text)) > 10000)
            {
            ImageButton myHyperLink = GridView1.Rows[i].FindControl("btn_small_del") as ImageButton;
            myHyperLink.Visible = false;

            ImageButton myHyperLink1 = GridView1.Rows[i].FindControl("btn_small_Rename") as ImageButton;
            myHyperLink1.Visible = false;


            }

            GridView1.Rows[i].Cells[0].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView1.Rows[i].Cells[0].Text);

         //   for (int j = 0; j <=1; j++)
          //  {
            //    GridView1.Rows[i].Cells[j].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView1.Rows[i].Cells[j].Text);

           // }
        }

        //if (e.Row.RowType == DataControlRowType.DataRow)
       // {
            //ImageButton myHyperLink = e.Row.FindControl("btn_small_del") as ImageButton;
            //myHyperLink.Visible = false;
       // }



        //  if (e.Row.RowType == DataControlRowType.DataRow)
        // {
        //ExpanseExample.Expanse expanse = e.Row.DataItem as ExpanseExample.Expanse;
        //(e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        // (e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        //(e.Row.FindControl("lnkDelete") as LinkButton).CommandArgument = e.Row.Cells[0].Text;
        //  }
    }
    protected void add_dialog_save_Click(object sender, EventArgs e)
    {
        if (khatam.core.data.sql.Sql_Check_identity("title", this.add_txt_title.Text, "coreRole",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("title");
            b.Add(this.add_txt_title.Text);

            khatam.core.data.sql.Add(a, b, "coreRole");

            gridsbind();
            UpdatePanel1_Modal_msgOk.Show();

        }
        else
        {
            UpdatePanel1_Modal_msgIdentityError.Show();
        }
    }
    protected void add2_dialog_save_Click(object sender, EventArgs e)
    {
        UpdatePanel1_Modal_msgAdd.Show();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {

    }
    protected void Button12_Click(object sender, EventArgs e)
    {

    }
    protected void Button77_Click(object sender, EventArgs e)
    {

    }
    protected void Button_filter_ok_Click(object sender, EventArgs e)
    {
        // ViewState("Counter"), 
        string strWhereTemp = "";

        strWhereTemp = whereGenerator(filter_txt_id, "id", "");
        //strWhereTemp = strWhereTemp + whereGenerator(filter_txt_email, "email", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_title, "title", strWhereTemp);




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
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("عنوان", filter_txt_title.Text, strSyntaxFaTemp);

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
    protected void Button10_Click(object sender, EventArgs e)
    {

    }
    protected void del_dialog_yes_Click(object sender, EventArgs e)
    {
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("id");
        b.Add(khatam.core.globalization.numbers.GetGeorgianNumbers(del_lbl_code.Text));
        khatam.core.data.sql.Del(a, b, "coreRole", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        gridBind();
    }
    protected void Button21_Click(object sender, EventArgs e)
    {

    }
    protected void msgAnnouncement_ok_Click(object sender, EventArgs e)
    {
        if (int.Parse(msgAnnouncement_lbl_id.Text)<1000)
        khatam.core.data.sql.updateField("Announcement", CKEditor1.Text, "id", msgAnnouncement_lbl_id.Text, "coreRole",
         khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        else
            khatam.core.data.sql.updateField("Announcement", CKEditor1.Text, "id", msgAnnouncement_lbl_id.Text, "coreRoleSys",
         khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

    }
    protected void msgAnnouncement_cancel_Click(object sender, EventArgs e)
    {

    }

    void gridBind()
    {
        string sqlstr = "SELECT *    FROM [coreRole]     " + ViewState["strWhere"] + ViewState["strOrderBy"];
        SqlDataSource2.SelectCommand = sqlstr;
        GridView1.DataBind();
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
    protected void btn_small_Rename_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        rename_lbl_code.Text = this.GridView1.Rows[rowIndex].Cells[0].Text;
        rename_txt_title.Text = this.GridView1.Rows[rowIndex].Cells[1].Text;


        UpdatePanel1_Modal_msgRename.Show();
    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }

    protected void add_dialog_rename_Click(object sender, EventArgs e)
    {
         //rename_lbl_code.Text
        khatam.core.data.sql.updateField("title", rename_txt_title.Text, "id",
            khatam.core.globalization.numbers.GetGeorgianNumbers( rename_lbl_code.Text), "coreRole",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        gridBind();
    }
    protected void btn_small_group_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        // del_lbl_code.Text = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text);


        RedirectTo("~/manage/?mode=coreRoleRefUserList&id=" + khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text));
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}