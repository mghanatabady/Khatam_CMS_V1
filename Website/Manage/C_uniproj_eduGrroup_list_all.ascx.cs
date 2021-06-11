using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_uniproj_eduGrroup_list_all : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دانشگاه: مدیریت گروه های آموزشی";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/category.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " دانشگاه: مدیریت گروه های آموزشی";
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

     

        gridBind();



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

            if (e.CommandName == "cmdEdit")
            {
                UpdatePanel1_Modal_msgEdit.Show();
                //this.LblEditCode.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                //this.txtEditTitle.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                // this.TextBox1.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[2].Text;

                //  UpdatePanel1_ModalPopupExtender.Show();

            }

            if (e.CommandName == "cmdInfo")
            {
                UpdatePanel1_Modal_msgInfo.Show();
                //this.LblEditCode.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[0].Text;
                //this.txtEditTitle.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[1].Text;
                // this.TextBox1.Text = this.GridView1.Rows[this.GridView1.SelectedIndex].Cells[2].Text;

                //  UpdatePanel1_ModalPopupExtender.Show();

            }

            if (e.CommandName == "cmdPass")
            {
                UpdatePanel1_Modal_msgPass.Show();
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


        bool identity = khatam.core.data.sql.Sql_Check_identity("title", add_txt_title.Text, "uniproj_eduGroup",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        if (identity)
        {

            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();            
     
            a.Add("title");
            b.Add(add_txt_title.Text  );

           khatam.core.data.sql.Add(a, b, "uniproj_eduGroup");                      

            UpdatePanel1_ModalPopupExtender3.Show();                       

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
    protected void ImageButton_fillter_Click(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_Modal_gridFilter.Show();
    }
    protected void Button_filter_ok_Click(object sender, EventArgs e)
    {
        // ViewState("Counter"), 
        string strWhereTemp = "";

        strWhereTemp = whereGenerator(filter_txt_id, "id", "");
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

    void gridBind()
    {
        string sqlstr = "SELECT     id,title from uniproj_eduGroup " +
                    ViewState["strWhere"] + ViewState["strOrderBy"];
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



        bool haveNotChild = khatam.core.data.sql.Sql_Check_identity("EduGroupId", khatam.core.globalization.numbers.GetGeorgianNumbers(del_lbl_code.Text), "uniproj_cluster",
    khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        if (haveNotChild)
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("id");
            b.Add(khatam.core.globalization.numbers.GetGeorgianNumbers(del_lbl_code.Text));
            khatam.core.data.sql.Del(a, b, "uniproj_eduGroup", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        }
        else
        {
            UpdatePanel1_Modal_msg_HaveChild.Show();
        }
        


        gridBind();

    }

    protected void btn_small_del_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        this.del_lbl_code.Text = GridView1.Rows[rowIndex].Cells[0].Text;

        bool haveNotChild = khatam.core.data.sql.Sql_Check_identity("EduGroupId", del_lbl_code.Text, "uniproj_cluster",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        if (haveNotChild)
        {
            UpdatePanel1_Modal_msgDel.Show();
        }
        else
        {
            UpdatePanel1_Modal_msg_HaveChild.Show();
        }
    }
    protected void btn_small_invoice_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        string invoiceId = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[0].Text);
        //  UpdatePanel1_Modal_msgDel.Show(); 


        string pass = khatam.core.data.sql.getField("idRandom", "id",
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
    protected void btn_small_status_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);
        string str_id = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[0].Text);


        hiddenField.Value = str_id;
      //  ddl_status.SelectedValue = khatam.core.data.sql.getField( "id", hiddenField.Value, "core_invoice");

        UpdatePanel1_Modal_msgStatus.Show();
    }
    protected void btn_small_invoice_user_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);
        string str_id = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[0].Text);


        hiddenField.Value = str_id;

        txt_msg_invoice_user_user_id.Text = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[1].Text);
        UpdatePanel1_Modal_msg_invoice_user.Show();
    }
    protected void btn_msg_invoice_ok_Click(object sender, EventArgs e)
    {
        khatam.core.data.sql.updateField("users_id", txt_msg_invoice_user_user_id.Text, "id", hiddenField.Value, "core_invoice");
        gridBind();
    }
    protected void Button_status_ok_Click(object sender, EventArgs e)
    {
        khatam.core.data.sql.updateField("sendStatus", ddl_status.SelectedValue, "id", hiddenField.Value, "core_invoice");
        gridBind();
    }
    protected void btn_small_edit_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btn_small_group_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        // del_lbl_code.Text = khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text);


        RedirectTo("~/manage/?mode=uniproj_EduGroupRefUsers&id=" + khatam.core.globalization.numbers.GetGeorgianNumbers(this.GridView1.Rows[rowIndex].Cells[0].Text));
    }
    protected void ImageButton_fillter_Click1(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_Modal_gridFilter.Show();
    }
}