

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_uniproj_project_list_student : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {



        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دانشگاه: پروژه - دانشجو";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/uniProj.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " دانشگاه: پروژه - دانشجو";
        l.Text = l.Text + "</span> ";




        string sqlstr = "";


        if (!Page.IsPostBack)
        {
            Label2.Text = "همه موارد";
            ViewState["strOrderBy"] = " ORDER BY id DESC ";
        }

        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.SelectCommand = sqlstr;
        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        string selectedProjectId;

        selectedProjectId = khatam.core.data.sql.getField("project_id", "status", "2", "uniStudentUserId",
            khatam.core.Security.Users.login().ToString(), "uniproj_ProjectRefStudent");


        if (selectedProjectId == "-1")
        {
            gridBind();
        }
        else
        {
            divMain.Visible = false;

            string project_title = khatam.core.data.sql.getField("title", "id", selectedProjectId, "uniproj_project");
            string project_memo = khatam.core.data.sql.getField("memo", "id", selectedProjectId, "uniproj_project");
            string project_htmlpage = khatam.core.data.sql.getField("htmlPage", "id", selectedProjectId, "uniproj_project");
            string project_uniTeacherUserFname = khatam.core.data.sql.getField("uniTeacherUserFname", "id", selectedProjectId, "uniproj_project");
            string project_uniTeacherUserLname = khatam.core.data.sql.getField("uniTeacherUserLname", "id", selectedProjectId, "uniproj_project");


                //project_memo=
                //project_html=
            khatam.core.Security.Users.user user_ostad = new  khatam.core.Security.Users.user();

            PlaceHolder1.Controls.Add(new LiteralControl("<div dir=\"rlt\" style=\" text-align:right \">"));
            PlaceHolder1.Controls.Add(new LiteralControl(":کد پروژه ی تایید شده"));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));

            PlaceHolder1.Controls.Add(new LiteralControl(selectedProjectId ));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));

            PlaceHolder1.Controls.Add(new LiteralControl("عنوان"));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));
            PlaceHolder1.Controls.Add(new LiteralControl(project_title ));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));

            PlaceHolder1.Controls.Add(new LiteralControl(":استاد"));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));
            PlaceHolder1.Controls.Add(new LiteralControl(project_uniTeacherUserFname + " " + project_uniTeacherUserLname));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));

            PlaceHolder1.Controls.Add(new LiteralControl("شرح"));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));
            PlaceHolder1.Controls.Add(new LiteralControl(project_memo));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));
            

        
            PlaceHolder1.Controls.Add(new LiteralControl(project_htmlpage));
            PlaceHolder1.Controls.Add(new LiteralControl("</br>"));

            PlaceHolder1.Controls.Add(new LiteralControl("</div>"));

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




        //if (!Page.IsPostBack)
        // {
        //  SqlDataSource2.SelectCommand = sqlstr;
        // }


        ///SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();


    }

    protected void GridView2_OnDataBound(object sender, EventArgs e)
    {

        updateGridAndStats();


    }

    void updateGridAndStats()
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {

            GridView1.Rows[i].Cells[6].Text = khatam.core.globalization.dateTime.GetPersianDateTime(DateTime.Parse(GridView1.Rows[i].Cells[6].Text));
            GridView1.Rows[i].Cells[7].Text = khatam.core.globalization.dateTime.GetPersianDateTime(DateTime.Parse(GridView1.Rows[i].Cells[7].Text));

            khatam.uniproj.project _project = new khatam.uniproj.project();
            try
            {
                GridView1.Rows[i].Cells[8].Text = _project.GetVerficationState(int.Parse(GridView1.Rows[i].Cells[8].Text));
            }
            catch
            {

            }

            for (int j = 0; j <= 7; j++)
            {
                GridView1.Rows[i].Cells[j].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView1.Rows[i].Cells[j].Text);
            }
        }

     /*   for (int i = 0; i < GridView1.Rows.Count; i++)
        {

            ImageButton imgbtn = new ImageButton();
            imgbtn = (ImageButton)GridView1.Rows[i].Cells[8].FindControl("btn_small_status");
            if (int.Parse(GridView1.Rows[i].Cells[7].Text) == 0)
            {
                imgbtn.Visible = false;
            }

            GridView1.Rows[i].Cells[4].Text = khatam.core.globalization.dateTime.GetPersianDate(DateTime.Parse(GridView1.Rows[i].Cells[4].Text));
            GridView1.Rows[i].Cells[6].Text = khatam.shop.invoiceManager.getStatePay(int.Parse(GridView1.Rows[i].Cells[6].Text));

            for (int j = 0; j <= 6; j++)
            {
                GridView1.Rows[i].Cells[j].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView1.Rows[i].Cells[j].Text);

            }

            GridView1.Rows[i].Cells[7].Text = khatam.shop.invoiceManager.getStateSend(int.Parse(GridView1.Rows[i].Cells[7].Text));


        }*/
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
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=corePermissionRefUser_list&id=" + this.GridView1.SelectedRow.Cells[0].Text);
    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {


        if (e.CommandName != "Sort")
        {

            this.GridView1.SelectedIndex = int.Parse(e.CommandArgument.ToString());



            /*   this.GridView1.SelectedIndex = int.Parse(e.CommandArgument.ToString());
                */

            if (e.CommandName == "cmdDel")
            {
                //hideWins();
                del_lbl_code.Text = this.GridView1.SelectedRow.Cells[0].Text;
                this.UpdatePanel1_Modal_msgDel.Show();
                //Label1.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                //this.MSG3.Visible = true;

            }

       

            if (e.CommandName == "cmdPer")
            {
                //this.Response.Redirect("~/manage/?mode=corePermissionRefUser_list&id=" + this.GridView1.SelectedRow.Cells[0].Text);
                RedirectTo("~/manage/?mode=corePermissionRefUser_list&id=" + khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.SelectedRow.Cells[0].Text));

            }

   

            if (e.CommandName == "cmdInfo")
            {
                UpdatePanel1_Modal_msgInfo.Show();
                //this.LblEditCode.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                //this.txtEditTitle.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                // this.TextBox1.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[2].Text;

                //  UpdatePanel1_ModalPopupExtender.Show();

            }

    

            if (e.CommandName == "cmdInvoice")
            {
                RedirectTo("~/manage/?mode=eshop_invoices_list&userId=" + this.GridView1.SelectedRow.Cells[0].Text);

            }


        }
    }




    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
  



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
        //UpdatePanel1_ModalPopupExtender.Show();


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



        // UpdatePanel1_ModalPopupExtender.Hide();

    }
    protected void add2_dialog_save_Click(object sender, EventArgs e)
    {

        //UpdatePanel1_ModalPopupExtender.Show();


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
    protected void ImageButton_fillter_Click(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_Modal_gridFilter.Show();
    }
    protected void Button_filter_ok_Click(object sender, EventArgs e)
    {
        // ViewState("Counter"), 
        string strWhereTemp = "";

        strWhereTemp = whereGenerator(filter_txt_id, "core_invoice.id", "");
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_userid, "users.id", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_fname, "fname", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_lname, "lname", strWhereTemp);

        strWhereTemp = strWhereTemp + whereGeneratorDate(filter_txt_regDate_from.PersianDateString, filter_txt_regDate_to.PersianDateString, "orderDate", strWhereTemp, true);


        strWhereTemp = strWhereTemp + whereGeneratorPrice(filter_txt_price_from, filter_txt_price_to, "core_invoice.total_order_price", strWhereTemp, true);

        //strWhereTemp = strWhereTemp + whereGenerator(filter_txt_company, "company", strWhereTemp);
        // strWhereTemp = strWhereTemp + whereGenerator(filter_txt_tel, "tel", strWhereTemp);
        //strWhereTemp = strWhereTemp + whereGenerator(filter_txt_cellphone, "cellphone", strWhereTemp);



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
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("کد کاربر", filter_txt_userid.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام", filter_txt_fname.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام خانوادگی", filter_txt_lname.Text, strSyntaxFaTemp);

        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorDateFa("زمان ثبت", filter_txt_regDate_from.PersianDateString, filter_txt_regDate_to.PersianDateString, strSyntaxFaTemp);

        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorPriceFa("قیمت", filter_txt_price_from.Text, filter_txt_price_to.Text, strSyntaxFaTemp);

        //strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("شرکت", filter_txt_company.Text, strSyntaxFaTemp);
        //strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("تلفن", filter_txt_tel.Text, strSyntaxFaTemp);
        //strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("موبایل", filter_txt_cellphone.Text, strSyntaxFaTemp);

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

    void gridBind()
    {
         /*"SELECT uniproj_project.id, uniproj_project.title, uniproj_project.uniTeacherUserId, uniproj_project.uniTeacherUserFname, uniproj_project.uniTeacherUserLname, "
+ " uniproj_project.uniProjTeacherCode, uniproj_project.regDatetime, uniproj_project.updateDatetime, uniproj_ProjectRefStudent.status"
+ " FROM uniproj_project LEFT OUTER JOIN"
+ " uniproj_ProjectRefStudent ON uniproj_project.id = uniproj_ProjectRefStudent.project_id"
+ " WHERE (uniproj_ProjectRefStudent.uniStudentUserId =" + khatam.core.Security.Users.login() + ") OR"
+ " (uniproj_ProjectRefStudent.uniStudentUserId IS NULL)"+ */

        
                    //" ORDER BY id DESC  " +
        string cluster_id = khatam.core.data.sql.getField("cluster_id", "uniStudentId", khatam.core.Security.Users.login().ToString(), "uniproj_ClusterRefStudent");
      //  PlaceHolder1.Controls.Add(new LiteralControl(cluster_id));

                    //ViewState["strWhere"] + ViewState["strOrderBy"];
        /*string sqlstr = " SELECT     uniproj_project.id, uniproj_project.title, uniproj_project.memo, uniproj_project.htmlPage, uniproj_project.clusterId, uniproj_project.uniTeacherUserId,  " +
                    "  uniproj_project.uniTeacherUserFname, uniproj_project.uniTeacherUserLname, uniproj_project.uniProjTeacherCode, uniproj_project.uniStudentUserId,  " +
                    " uniproj_project.uniStrudentFname, uniproj_project.uniStudentLname, uniproj_project.uniGroupUserIdVerification, uniproj_project.uniGroupUserFnameVerfication,  " +
                    " uniproj_project.uniGroupUserLnameVerfication, uniproj_project.uniGroupUserTeacherCodeVerfication, uniproj_project.researchDepartementUserIdVerfication,  " +
                    " uniproj_project.researchDepartementUserFnameVerfication, uniproj_project.researchDepartementUserLnameVerfication, uniproj_project.regDatetime,  " +
                    " uniproj_project.updateDatetime, uniproj_project.GroupUserIdVerificationState, uniproj_project.DepartementUserIdVerficationState, uniproj_project.projectType,  " +
                    " uniproj_project.sendToGroupId, uniproj_ProjectRefStudent.status " +
                    " FROM         uniproj_project LEFT OUTER JOIN " +
                    " uniproj_ProjectRefStudent ON uniproj_project.id = uniproj_ProjectRefStudent.project_id " +
                    " WHERE   (  (uniproj_ProjectRefStudent.status <> 2) or (uniproj_ProjectRefStudent.status IS NULL)) AND  (GroupUserIdVerificationState=2) AND (uniproj_project.clusterId = " + cluster_id + ")  " +
                    " ";*/

        string sqlstr =
           " SELECT     uniproj_project.id, uniproj_project.title, uniproj_project.memo, uniproj_project.htmlPage, uniproj_project.uniTeacherUserId, uniproj_project.uniTeacherUserFname, " +
            "          uniproj_project.uniTeacherUserLname, uniproj_project.uniProjTeacherCode, uniproj_project.uniStudentUserId, uniproj_project.uniStrudentFname, " +
             "         uniproj_project.uniStudentLname, uniproj_project.uniGroupUserIdVerification, uniproj_project.uniGroupUserFnameVerfication, " +
              "        uniproj_project.uniGroupUserLnameVerfication, uniproj_project.uniGroupUserTeacherCodeVerfication, uniproj_project.researchDepartementUserIdVerfication,  " +
               "       uniproj_project.researchDepartementUserFnameVerfication, uniproj_project.researchDepartementUserLnameVerfication, uniproj_project.regDatetime,  " +
                "      uniproj_project.updateDatetime, uniproj_project.GroupUserIdVerificationState, uniproj_project.DepartementUserIdVerficationState, uniproj_project.projectType,  " +
                      " uniproj_project.sendToGroupId, uniproj_ProjectRefStudent.status, uniproj_sections.title AS sections_title, uniproj_project.clusterId " +
" FROM         uniproj_ProjectRefStudent RIGHT OUTER JOIN " +
  "                    uniproj_project INNER JOIN " +
   "                   uniproj_sections INNER JOIN " +
    "                  uniproj_cluster ON uniproj_sections.id = uniproj_cluster.uniSection ON uniproj_project.clusterId = uniproj_cluster.id ON " +
     "                 uniproj_ProjectRefStudent.project_id = uniproj_project.id " +
      " WHERE   (  (uniproj_ProjectRefStudent.status <> 2) or (uniproj_ProjectRefStudent.status IS NULL)) AND  (GroupUserIdVerificationState=2) AND (uniproj_project.clusterId = " + cluster_id + ") ORDER BY uniproj_project.id DESC ";// +


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

    public string whereGeneratorDate(string dateFrom, string dateTo, string colName, string parentStr, bool persianCalender)
    {
        // WHERE     (regDate BETWEEN '10/1/2011' AND '10/5/2015 11:59:59 PM')
        string strFrom = "1390/1/1";
        string strTo = "1399/1/1";

        if (dateFrom != "") strFrom = dateFrom;
        if (dateTo != "") strTo = dateTo;


        string strWhereTemp = "";

        string str_and = "";
        if (parentStr != "") str_and = " and ";

        strWhereTemp = strWhereTemp + str_and + " ( " + colName + " >= '" + khatam.core.globalization.dateTime.GetGregorianDateFromPersianDate(strFrom)
                    + "' ) AND  ( " + colName + "  <= '" + khatam.core.globalization.dateTime.GetGregorianDateFromPersianDate(strTo) + "')";

        return strWhereTemp;

    }

    public string whereGeneratorPrice(TextBox TxtCtrlFrom, TextBox TxtCtrlTo, string colName, string parentStr, bool persianCalender)
    {
        // WHERE     (regDate BETWEEN '10/1/2011' AND '10/5/2015 11:59:59 PM')
        string strFrom = "0";
        string strTo = "9999999999999999";

        if (TxtCtrlFrom.Text != "") strFrom = TxtCtrlFrom.Text;
        if (TxtCtrlTo.Text != "") strTo = TxtCtrlTo.Text;

        string strWhereTemp = "";

        string str_and = "";
        if (parentStr != "") str_and = " and ";

        strWhereTemp = strWhereTemp + str_and + " ( " + colName + " >= " + strFrom
            + " ) AND  ( " + colName + "  <= " + strTo + ")";

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

    public string searchSyntaxGeneratorDateFa(string colNameFa, string Value, string Value2, string parentStr)
    {
        string strWhereTemp = "";

        if ((Value == "") && (Value2 == ""))
        {
        }
        else
        {
            if (parentStr != "")
            {


                strWhereTemp = strWhereTemp + " و (" + colNameFa + " از تاریخ: '" + Value + "' " + " تا تاریخ: '" + Value2 + "'  )";

            }
            else
            {


                strWhereTemp = strWhereTemp + " (" + colNameFa + " از تاریخ: '" + Value + "' " + " تا تاریخ: '" + Value2 + "'  )";


            }

        }
        return strWhereTemp;

    }

    public string searchSyntaxGeneratorPriceFa(string colNameFa, string Value, string Value2, string parentStr)
    {
        string strWhereTemp = "";

        if ((Value == "") && (Value2 == ""))
        {
        }
        else
        {
            if (parentStr != "")
            {


                strWhereTemp = strWhereTemp + " و (" + colNameFa + " از مبلغ: '" + Value + "' " + " تا مبلغ: '" + Value2 + "'  )";

            }
            else
            {


                strWhereTemp = strWhereTemp + " (" + colNameFa + " از مبلغ: '" + Value + "' " + " تا مبلغ: '" + Value2 + "'  )";


            }

        }
        return strWhereTemp;

    }


    protected void del_dialog_yes_Click(object sender, EventArgs e)
    {
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("project_id");
        b.Add(khatam.core.globalization.numbers.GetGeorgianNumbers(del_lbl_code.Text));

        a.Add("uniStudentUserId");
        b.Add(khatam.core.Security.Users.login().ToString());

        khatam.core.data.sql.Del(a, b, "uniproj_ProjectRefStudent", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        gridBind();

    }

    protected void btn_small_del_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        this.del_lbl_code.Text = GridView1.Rows[rowIndex].Cells[0].Text;
        UpdatePanel1_Modal_msgDel.Show();
    }
    protected void btn_small_invoice_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        string invoiceId = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[0].Text);
        //  UpdatePanel1_Modal_msgDel.Show(); 


        string pass = khatam.core.data.sql.getField( "idRandom", "id",
      invoiceId, "core_invoice");

        string url = khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "pay.aspx?id=" +
            invoiceId + "&pass=" + pass;
        RedirectTo(url);
    }
    protected void ImageButton_fillter_del_Click(object sender, ImageClickEventArgs e)
    {
        ViewState["strWhere"] = "";

        Label2.Text = "همه موارد";

        gridBind();
    }

 

    protected void btn_small_edit_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btn_small_avtice_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);
        string str_id = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[0].Text);



        khatam.core.Security.Users.user _user = new khatam.core.Security.Users.user();
        _user= khatam.core.Security.Users.getUser( khatam.core.Security.Users.login().ToString() );


        if (khatam.core.data.sql.Sql_Check_identity("uniStudentUserId", _user.id, "project_id", str_id, "uniproj_ProjectRefStudent",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()))
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();



            a.Add("uniStudentUserId");
            b.Add(_user.id);

            a.Add("uniStrudentFname");
            b.Add(_user.fname);

            a.Add("uniStrudentLname");
            b.Add(_user.lname);

            a.Add("project_id");
            b.Add(str_id);

            a.Add("status");
            b.Add("1");

            a.Add("regdateTime");
            b.Add(DateTime.UtcNow);

            khatam.core.data.sql.Add(a, b, "uniproj_ProjectRefStudent");

            UpdatePanel1_ModalPopupExtender3.Show();

            gridBind();
        }
        else
        {
            UpdatePanel1_ModalPopupExtender4.Show();

        }

    }
    protected void Button9_Click(object sender, EventArgs e)
    {

    }
}