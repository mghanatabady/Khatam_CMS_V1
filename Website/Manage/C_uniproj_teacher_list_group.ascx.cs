using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Linq;


public partial class Manage_C_uniproj_teacher_list_group : System.Web.UI.UserControl
{
    khatam.uniproj.cluster _cluster = new khatam.uniproj.cluster();



    protected void Page_Load(object sender, EventArgs e)
    {


  
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دانشگاه: لیست اساتید - مدیر گروه";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/icon_lesson_group.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=uniproj_cluster_list_group\">دانشگاه: لیست ظرفیت های اختصاص پروژه - مدیر گروه</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " دانشگاه: لیست اساتید - مدیر گروه";
        l.Text = l.Text + "</span> ";


        string sqlstr = "";


        if (!Page.IsPostBack)
        {
            Label2.Text = "همه موارد";
            ViewState["strOrderBy"] = " ORDER BY id DESC ";
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

        _cluster.cluster_id =int.Parse( this.Request.QueryString["cluster_id"]);        
        _cluster.GetCluster();

        if (_cluster.uniGroupUserId != khatam.core.Security.Users.login())
        {
            this.RedirectTo("~/manage/?mode=MSG_Access_denied");
        }

      
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        gridBind();
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

            
            string result    = khatam.core.data.sql.getField("capacity", "uniTeacherId",khatam.core.globalization.numbers.GetGeorgianNumbers( GridView1.Rows[i].Cells[0].Text),
               "cluster_id", _cluster.cluster_id.ToString(), "uniproj_ClusterRefTeacher");

            if (result != "-1")
            {
                GridView1.Rows[i].Cells[4].Text = result;
            }
            for (int j = 0; j <= 4; j++)
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

        int totalUsedCapacityWithoutTeacher =        khatam.uniproj.cluster.GetUsedCapacityWithoutTeacher(hiddenField.Value, this.Request.QueryString["cluster_id"]);
        int totalTermLimit =int.Parse( khatam.core.data.sql.getField( "capacity", "id", this.Request.QueryString["cluster_id"], "uniproj_cluster"));


       // trace.Text = "totalUsedCapacityWithoutTeacher: " + totalUsedCapacityWithoutTeacher + " edit_txt_capacity: " + edit_txt_capacity.Text + " totalTermLimit: " + totalTermLimit;
        if (totalUsedCapacityWithoutTeacher + int.Parse(edit_txt_capacity.Text) > totalTermLimit)
        {
            lbl_LimmitFull.Text = (totalTermLimit - totalUsedCapacityWithoutTeacher).ToString();
            UpdatePanel1_msgLimmitFull.Show();
        }
        else
        {
            khatam.uniproj.project _project = new khatam.uniproj.project();
            int usedProj = _project.CountTeacherUsedProject(hiddenField.Value, this.Request.QueryString["cluster_id"]);

            if (int.Parse(edit_txt_capacity.Text) < usedProj)
            {
                lbl_LimitLower.Text = usedProj.ToString();
                UpdatePanel1_msgLimitLowerThanTeacherUsed.Show();
            }
            else
            {

                bool checkIdentity = true;

                checkIdentity = khatam.core.data.sql.Sql_Check_identity("uniTeacherId", hiddenField.Value, "cluster_id", this.Request.QueryString["cluster_id"], "uniproj_ClusterRefTeacher", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                if (checkIdentity)
                {

                    ArrayList a = new ArrayList();
                    ArrayList b = new ArrayList();



                    a.Add("uniTeacherId");
                    b.Add(hiddenField.Value);

                    a.Add("cluster_id");
                    b.Add(this.Request.QueryString["cluster_id"]);

                    a.Add("capacity");
                    b.Add(edit_txt_capacity.Text);


                    khatam.core.data.sql.Add(a, b, "uniproj_ClusterRefTeacher");

                    UpdatePanel1_ModalPopupExtender3.Show();

                    GridView1.DataBind();

                    //##this.Page.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/login");
                }
                else
                {
                    ArrayList a = new ArrayList();
                    ArrayList b = new ArrayList();



                    a.Add("uniTeacherId");
                    b.Add(hiddenField.Value);

                    a.Add("cluster_id");
                    b.Add(this.Request.QueryString["cluster_id"]);

                    a.Add("capacity");
                    b.Add(edit_txt_capacity.Text);


                    khatam.core.data.sql.updateField("capacity", edit_txt_capacity.Text, "cluster_id", this.Request.QueryString["cluster_id"],
                        "uniTeacherId", hiddenField.Value, "uniproj_ClusterRefTeacher", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

                    UpdatePanel1_ModalPopupExtender3.Show();

                    GridView1.DataBind();
                }
            }
        }
           
      //  }*/

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

        string IdEduGroup;


        string sqlstr =
            /*" SELECT     users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone, uniproj_ClusterRefTeacher.capacity,  "
           + "  uniproj_ClusterRefTeacher.cluster_id, uniproj_ClusterRefTeacher.uniTeacherId, coreRoleRefUser.idRole "
+ " FROM         users INNER JOIN "
+ "                   coreRoleRefUser ON users.id = coreRoleRefUser.idUser LEFT OUTER JOIN "
+ "               uniproj_ClusterRefTeacher ON users.id = uniproj_ClusterRefTeacher.uniTeacherId "
+ " WHERE     (uniproj_ClusterRefTeacher.cluster_id = " + this.Request.QueryString["cluster_id"] + " OR     uniproj_ClusterRefTeacher.cluster_id IS NULL)"
+ "       AND (coreRoleRefUser.idRole = 10003)          "*/

     ///       "SELECT     users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone, uniproj_ClusterRefTeacher.capacity,   " +
            ///     " uniproj_ClusterRefTeacher.cluster_id, uniproj_ClusterRefTeacher.uniTeacherId  " +
            ///" FROM         users INNER JOIN  " +
            ///"                    uniproj_EduGroupRefUsers ON users.id = uniproj_EduGroupRefUsers.idUser LEFT OUTER JOIN  " +
            ///"                   uniproj_ClusterRefTeacher ON users.id = uniproj_ClusterRefTeacher.uniTeacherId  " +
            ///" WHERE     (uniproj_ClusterRefTeacher.cluster_id = " + _cluster.cluster_id + " OR  uniproj_ClusterRefTeacher.cluster_id IS NULL) AND (uniproj_EduGroupRefUsers.idEduGroup = " + _cluster.EduGroupId + ") ";
            ///

 // " SELECT     users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone, uniproj_ClusterRefTeacher.capacity,  " +
            // "                  uniproj_ClusterRefTeacher.cluster_id, uniproj_ClusterRefTeacher.uniTeacherId " +
            //" FROM         users INNER JOIN " +
            //"                    uniproj_EduGroupRefUsers ON users.id = uniproj_EduGroupRefUsers.idUser INNER JOIN " +
            //"                   uniproj_cluster ON uniproj_EduGroupRefUsers.idEduGroup = uniproj_cluster.EduGroupId LEFT OUTER JOIN " +
            //"                  uniproj_ClusterRefTeacher ON users.id = uniproj_ClusterRefTeacher.uniTeacherId " +
            //" WHERE     (uniproj_EduGroupRefUsers.idEduGroup =  " + _cluster.EduGroupId + ") AND (uniproj_cluster.id =  " + _cluster.cluster_id + " ) ";

" SELECT     users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone, uniproj_EduGroupRefUsers.idEduGroup " +
" FROM         users INNER JOIN " +
  "                    uniproj_EduGroupRefUsers ON users.id = uniproj_EduGroupRefUsers.idUser " +
" WHERE     (uniproj_EduGroupRefUsers.idEduGroup = " + _cluster.EduGroupId + ")";

      //  " WHERE     (uniproj_ClusterRefTeacher.cluster_id = " + _cluster.cluster_id + ") OR  (uniproj_ClusterRefTeacher.cluster_id IS NULL) AND (uniproj_EduGroupRefUsers.idEduGroup = " + _cluster.EduGroupId + ") ";
  //                  
                    
                    
                    
                    
                   /* "SELECT     users.id, users.email, users.fname, users.lname, users.company, users.tel, users.fax, users.cellphone, uniproj_ClusterRefTeacher.capacity, " +
  "                    uniproj_ClusterRefTeacher.cluster_id, uniproj_ClusterRefTeacher.uniTeacherId " +
" FROM         users LEFT OUTER JOIN " +
  "                    uniproj_ClusterRefTeacher ON users.id = uniproj_ClusterRefTeacher.uniTeacherId " +
" WHERE     (uniproj_ClusterRefTeacher.cluster_id = " +  this.Request.QueryString["cluster_id"] + ") OR " +
                      " (uniproj_ClusterRefTeacher.cluster_id IS NULL) "       */
       
     //   + ViewState["strWhere"] + ViewState["strOrderBy"];
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
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);
        hiddenField.Value = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text);
        hiddenField2.Value = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[4].Text);
        

        edit_txt_capacity.Text = khatam.core.data.sql.getField("capacity", "uniTeacherId", hiddenField.Value, "cluster_id", this.Request.QueryString["cluster_id"], "uniproj_ClusterRefTeacher");
        if (edit_txt_capacity.Text=="-1")
        {
            edit_txt_capacity.Text = "";
        }

        UpdatePanel1_ModalPopupExtender.Show();
    }
    protected void btn_small_del_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btn_small_Announcement_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void msgAnnouncement_ok_Click(object sender, EventArgs e)
    {



    }
    protected void msgAnnouncement_cancel_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        UpdatePanel1_ModalPopupExtender.Show();
    }

}



