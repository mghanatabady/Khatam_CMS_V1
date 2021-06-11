using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_c_darman_cards_my : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {



        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دارمان : کارت های من";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/profile.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " دارمان : کارت های من";
        l.Text = l.Text + "</span> ";


        filter_txt_price_from.Attributes.Add("onkeypress", "return isNumberKey(event)");
        filter_txt_price_to.Attributes.Add("onkeypress", "return isNumberKey(event)");



        string sqlstr = "";


        if (!Page.IsPostBack)
        {
            Label2.Text = "همه موارد";
            ViewState["strOrderBy"] = " ORDER BY darman_cards.id DESC ";
        }



     

                if (khatam.core.Security.Users.validUserPermission(khatam.core.Security.Users.login().ToString(), "darman_cards_my") == false)
                {
                    this.Response.Redirect("~/manage/?mode=msgPermisson");
                }
                else
                {
                    string strWhereTemp = "";
                    strWhereTemp = "     (users.id = " + khatam.core.Security.Users.login().ToString() + ") ";                   
                    ViewState["strWhere"] = " WHERE " + strWhereTemp;
                  


                    gridBind();
                  //  sqlstr = "SELECT     darman_cards.id, darman_cards.darman_cards_type_id, darman_cards.fname, darman_cards.lname, darman_cards.iranNationalCode, darman_cards.fatherName,  " +
                 //   "  darman_cards.birthday, darman_cards.shsh, darman_cards.shMahalSodor, darman_cards.tel, darman_cards.mobile, darman_cards.address, darman_cards.regDate, " +
                 //   "  darman_cards.expDate, darman_cards.pic, darman_cards.invoice_line_id, users.fname AS reseller_fname, users.lname AS reseller_lname, core_invoice_line.title, " +
                 //    " core_invoice_line.price, core_invoice.id AS invoice_id, users.id AS reseller_id " +
//" FROM         darman_cards INNER JOIN " +
  //           "         core_invoice_line ON darman_cards.invoice_line_id = core_invoice_line.id INNER JOIN "  +
    //          "        core_invoice ON core_invoice_line.invoice_id = core_invoice.id INNER JOIN " +
      //         "       users ON core_invoice.users_id = users.id " +
//" WHERE     (users.id = " + khatam.core.Security.Users.login() + ") " + ViewState["strWhere"] + ViewState["strOrderBy"];
                   
                }
     
        
              


        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            //    this.Button2.Enabled = false;
            //   this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button4.Enabled = false;
            this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }

        //khatam.core.data.sql.


        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }


        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
  



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
        b.Add(this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text);
        khatam.core.data.sql.Del(a, b, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        hideWins();
        GridView2.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=corePermissionRefUser_list&id=" + this.GridView2.SelectedRow.Cells[0].Text);
    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "cmdEdit")
        {
            //hideWins();
            //  this.TextBox1.Text =this.GridView2.SelectedIndex.ToString() ;
            // this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            //this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;
            //int rowIndex = Convert.ToInt32(e.CommandArgument);
            // int id = Convert.ToInt32(GridView2.DataKeys[rowIndex].Value);
            // UpdatePanel1_ModalPopupExtender.Show();

            //GridView2.Visible = false;
            //this.msgEdit.Visible = true;

        }

        /*   this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "del")
        {
            hideWins();
            Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            this.MSG3.Visible = true;

        }*/

        if (e.CommandName == "cmdPrint")
        {
            //this.Response.Redirect("~/manage/?mode=corePermissionRefUser_list&id=" + this.GridView2.SelectedRow.Cells[0].Text);

            // this.UpdatePanel1_ModalPopupExtender2.Show();
            RedirectTo("~/print.aspx?mode=darman&id=" + this.GridView2.SelectedRow.Cells[0].Text);

        }

        if (e.CommandName == "editcom")
        {
            hideWins();
            this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            // this.TextBox1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

            //  UpdatePanel1_ModalPopupExtender.Show();

        }
    }




    protected void GridView2_OnDataBound(object sender, EventArgs e)
    {


        for (int i = 0; i < GridView2.Rows.Count; i++)
        {
            GridView2.Rows[i].Cells[6].Text = khatam.core.globalization.dateTime.GetPersianDate(DateTime.Parse(GridView2.Rows[i].Cells[6].Text));
            GridView2.Rows[i].Cells[11].Text = khatam.shop.invoiceManager.getStatePay(int.Parse(GridView2.Rows[i].Cells[11].Text));

            for (int j = 0; j <= 11; j++)
            {
                GridView2.Rows[i].Cells[j].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView2.Rows[i].Cells[j].Text);

            }

        }


 


    }



    void hideWins()
    {
        MSG2.Visible = false;
        MSG3.Visible = false;
        //msgAdd.Visible = false;
        msgEdit.Visible = false;

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

        
        RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/?mode=darman_cards_add&from=darman_cards_my");

    }
    protected void msg_ok_Click(object sender, EventArgs e)
    {
        GridView2.Visible = false;
    }
    protected void msgerroIdentity_back_Click(object sender, EventArgs e)
    {
        //  UpdatePanel1_MsgIdentytyError.Hide(); 
        //UpdatePanel1_ModalPopupExtender2.Show();
        //UpdatePanel1_ModalPopupExtender.Show();
        GridView2.Visible = false;
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

    }

    protected void gv_darman_card_use1_DataBound(object sender, EventArgs e)
    {
        for (int i = 0; i < gv_darman_card_use1.Rows.Count; i++)
        {
            // ImageButton deleteButtonField = GridView2.Rows[0].Cells[11].Controls[0] as ImageButton;


            //   deleteButtonField.Visible  = false;//dateTime.GetPersianDate(DateTime.Parse(GridView2.Rows[i].Cells[4].Text));
            gv_darman_card_use1.Rows[i].Cells[1].Text = khatam.core.globalization.dateTime.GetPersianDate(
                DateTime.Parse(gv_darman_card_use1.Rows[i].Cells[1].Text));
        }

        //  if (e.Row.RowType == DataControlRowType.DataRow)
        // {
        //ExpanseExample.Expanse expanse = e.Row.DataItem as ExpanseExample.Expanse;
        //(e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        // (e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        //(e.Row.FindControl("lnkDelete") as LinkButton).CommandArgument = e.Row.Cells[0].Text;
        //  }
    }

    protected void gv_darman_card_useFull_DataBound(object sender, EventArgs e)
    {
        for (int i = 0; i < gv_darman_card_useFull.Rows.Count; i++)
        {
            // ImageButton deleteButtonField = GridView2.Rows[0].Cells[11].Controls[0] as ImageButton;


            //   deleteButtonField.Visible  = false;//dateTime.GetPersianDate(DateTime.Parse(GridView2.Rows[i].Cells[4].Text));
            gv_darman_card_useFull.Rows[i].Cells[1].Text = khatam.core.globalization.dateTime.GetPersianDate(
                DateTime.Parse(gv_darman_card_useFull.Rows[i].Cells[1].Text));
        }

        //  if (e.Row.RowType == DataControlRowType.DataRow)
        // {
        //ExpanseExample.Expanse expanse = e.Row.DataItem as ExpanseExample.Expanse;
        //(e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        // (e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        //(e.Row.FindControl("lnkDelete") as LinkButton).CommandArgument = e.Row.Cells[0].Text;
        //  }
    }

    protected void btn_small_use_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]); ;
        string code = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView2.Rows[rowIndex].Cells[0].Text);
        this.use_lbl_code.Text = code ;
        this.useFull_lbl_code.Text = code;
        this.use_lbl_date.Text = khatam.core.globalization.dateTime.GetPersianDate(DateTime.UtcNow);

        string invoiceId= khatam.core.globalization.numbers.GetGeorgianNumbers(GridView2.Rows[rowIndex].Cells[7].Text);
        int invoicePayStatus =int.Parse ( khatam.core.data.sql.getField("payStatus","id",invoiceId ,"core_invoice"));
       
        if (invoicePayStatus !=2)
        {
            UpdatePanel1_Modal_msgNotPaid.Show();
        }

        else
        {
        //  Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
        //  parameters.Add("darman_cards_id", khatam.core.globalization.numbers.GetGeorgianNumbers(GridView2.Rows[rowIndex].Cells[0].Text) );
        //  string sql_str= "SELECT COUNT ([id]) FROM [darman_card_use] where (darman_card_use.darman_cards_id =@darman_cards_id)" ;
        
        //  string usedNo=  DBFunctions.ExecuteScaler(sql_str, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString(); 
        int countCoupon = khatam.core.UI.WebControls.darmanInquiryWin.countUsedCoupon(code);

        SqlDataSource1.SelectCommand = " SELECT id, darman_cards_id, reg_user_id, datetime, N'return tooltip(''' + memo + N''',''شرح'' ,''direction:rtl,width:200'');' AS memoTip, drname FROM darman_card_use where (darman_cards_id=" + code + ")";

       if (countCoupon >= 5)
        {
            gv_darman_card_useFull.DataBind();

            UpdatePanel1_Modal_msgUseFull.Show();

        }
        else
        {

            gv_darman_card_use1.DataBind();

           UpdatePanel1_Modal_msgUse.Show();

       }
        }

       // trace_lbl.Text = countCoupon.ToString();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {

    }

    protected void use_dialog_save_Click(object sender, EventArgs e)
    {

        int countCoupon = khatam.core.UI.WebControls.darmanInquiryWin.countUsedCoupon(use_lbl_code.Text );

        if (countCoupon >= 5)
        {
            UpdatePanel1_Modal_msgUseFull.Show();
        }
        else
        {
            //check how many use

            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("darman_cards_id");
            b.Add(khatam.core.globalization.numbers.GetGeorgianNumbers(use_lbl_code.Text));

            a.Add("reg_user_id");
            b.Add(khatam.core.Security.Users.login().ToString());

            a.Add("datetime");
            b.Add(use_lbl_date.Text);
                //khatam.core.globalization.dateTime.GetGregorianDateFromPersianDate(use_lbl_date.Text));

            a.Add("memo");
            b.Add(use_txt_memo.Text);

            a.Add("drname");
            b.Add(use_txt_drName.Text);



            khatam.core.data.sql.Add(a, b, "darman_card_use");



            UpdatePanel1_ModalPopupExtender3.Show();

        }







    }
    protected void Button9_Click(object sender, EventArgs e)
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

    void gridBind()
    {
       string  sqlstr = "SELECT     darman_cards.id, darman_cards.darman_cards_type_id, darman_cards.fname, darman_cards.lname, darman_cards.iranNationalCode, darman_cards.fatherName,  " +
                    "  darman_cards.birthday, darman_cards.shsh, darman_cards.shMahalSodor, darman_cards.tel, darman_cards.mobile, darman_cards.address, darman_cards.regDate, " +
                    "  darman_cards.expDate, darman_cards.pic, darman_cards.invoice_line_id,core_invoice.payStatus, users.fname AS reseller_fname, users.lname AS reseller_lname, core_invoice_line.title, " +
                     " core_invoice_line.price, core_invoice.id AS invoice_id, users.id AS reseller_id " +
" FROM         darman_cards INNER JOIN " +
             "         core_invoice_line ON darman_cards.invoice_line_id = core_invoice_line.id INNER JOIN " +
              "        core_invoice ON core_invoice_line.invoice_id = core_invoice.id INNER JOIN " +
               "       users ON core_invoice.users_id = users.id " +
" " + ViewState["strWhere"] + ViewState["strOrderBy"];
        SqlDataSource2.SelectCommand = sqlstr;
        //GridView1.DataBind();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {

    }
    protected void Button_filter_ok_Click(object sender, EventArgs e)
    {
        // ViewState("Counter"), 
        string strWhereTemp = "";

        strWhereTemp = "     (users.id = " + khatam.core.Security.Users.login() + ") ";

        strWhereTemp = whereGenerator(filter_txt_id, "darman_cards.id", "");
       // strWhereTemp = strWhereTemp + whereGenerator(filter_txt_email, "email", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_fname, "darman_cards.fname", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_lname, "darman_cards.lname", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_iranNationalCode, "darman_cards.iranNationalCode", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_tel, "darman_cards.tel", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_mobile, "darman_cards.mobile", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGeneratorDate(filter_txt_regDate_from.PersianDateString, filter_txt_regDate_to.PersianDateString, "regDate", strWhereTemp, true);
     
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_invoice_id, "core_invoice.id", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_reseller_id, "users.id", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_title, "core_invoice_line.title", strWhereTemp);


        strWhereTemp = strWhereTemp + whereGeneratorPrice(filter_txt_price_from, filter_txt_price_to, "core_invoice.price", strWhereTemp, true);


        //strWhereTemp = strWhereTemp + whereGenerator(filter_txt_tel, "tel", strWhereTemp);
        //strWhereTemp = strWhereTemp + whereGenerator(filter_txt_cellphone, "cellphone", strWhereTemp);



        if (strWhereTemp != "")
        {
            ViewState["strWhere"] = " WHERE " + strWhereTemp;
        }
        else
        {
            ViewState["strWhere"] = "";
        }


        string strSyntaxFaTemp = "";

        strSyntaxFaTemp = searchSyntaxGeneratorFa("کد", filter_txt_id.Text, strSyntaxFaTemp);
      //  strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام کاربری", filter_txt_email.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام", filter_txt_fname.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام خانوادگی", filter_txt_lname.Text, strSyntaxFaTemp);

        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("کد  ملی", filter_txt_iranNationalCode.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("تلفن", filter_txt_tel.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("موبایل", filter_txt_mobile.Text, strSyntaxFaTemp);

       //strWhereTemp = strWhereTemp + whereGeneratorDate(filter_txt_regDate_from, filter_txt_regDate_to, "regDate", strWhereTemp, true);


        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorDateFa("زمان ثبت", filter_txt_regDate_from.PersianDateString, filter_txt_regDate_to.PersianDateString, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorPriceFa("قیمت", filter_txt_price_from.Text, filter_txt_price_to.Text, strSyntaxFaTemp);



      //  strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("شرکت", filter_txt_company.Text, strSyntaxFaTemp);
        //strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("تلفن", filter_txt_tel.Text, strSyntaxFaTemp);
      //  strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("موبایل", filter_txt_cellphone.Text, strSyntaxFaTemp);

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

    public string whereGeneratorDate(string  dateFrom,string  dateTo, string colName, string parentStr,bool persianCalender)
    {
       // WHERE     (regDate BETWEEN '10/1/2011' AND '10/5/2015 11:59:59 PM')
        string strFrom = "1390/1/1";
        string strTo = "1399/1/1";

        if (dateFrom != "") strFrom = dateFrom;
        if (dateTo != "") strTo = dateTo;


        string strWhereTemp = "";

        string str_and="";
        if (parentStr != "") str_and=" and ";

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

}