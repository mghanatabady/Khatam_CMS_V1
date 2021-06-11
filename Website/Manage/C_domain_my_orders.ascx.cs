using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using khatam.shop;


public partial class Manage_C_domain_my_orders : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دامین های من";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/domain_name.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " دامین های من";
        l.Text = l.Text + "</span> ";

        string sqlstr = "";

        SqlDataSource3.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();


        gridBind();

        if (!Page.IsPostBack)
        {
            Label2.Text = "همه موارد";
            ViewState["strOrderBy"] = " ORDER BY id DESC ";
            // updateGridAndStats();
        }


        gridBind();



        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            //   this.Button2.Enabled = false;
            //   this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            //   this.Button4.Enabled = false;
            //   this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
        }


    }

    protected void GridView2_OnDataBound(object sender, EventArgs e)
    {
        updateGridAndStats();


    }


    void updateGridAndStats()
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {

            ImageButton imgbtn = new ImageButton();
            imgbtn = (ImageButton)GridView1.Rows[i].Cells[8].FindControl("btn_small_Renew");
            if ((int.Parse(GridView1.Rows[i].Cells[5].Text) != 2) || !(
                 (int.Parse(GridView1.Rows[i].Cells[6].Text) == 4)
                 || (int.Parse(GridView1.Rows[i].Cells[6].Text) == 6)))
            {
                imgbtn.Visible = false;
            }

            ImageButton imgbtn2 = new ImageButton();
            imgbtn2 = (ImageButton)GridView1.Rows[i].Cells[8].FindControl("btn_small_status");
            if ((int.Parse(GridView1.Rows[i].Cells[6].Text) == 6) || (int.Parse(GridView1.Rows[i].Cells[6].Text) == 7))
            {
                imgbtn2.Visible = false;
            }



            if (HavePaidChild(GridView1.Rows[i].Cells[0].Text))
            {

                khatam.core.data.sql.updateField("virtualServiceStatus", "7", "id", GridView1.Rows[i].Cells[0].Text, "core_invoice_line");
            }
            else if (HaveNotPaidChild(GridView1.Rows[i].Cells[0].Text))
            {

                khatam.core.data.sql.updateField("virtualServiceStatus", "4", "id", GridView1.Rows[i].Cells[0].Text, "core_invoice_line");
            }
            else if ((checkRenewRequestIdenentity(GridView1.Rows[i].Cells[0].Text, "") == null) && (int.Parse(GridView1.Rows[i].Cells[6].Text) == 7))
            {
                khatam.core.data.sql.updateField("virtualServiceStatus", "4", "id", GridView1.Rows[i].Cells[0].Text, "core_invoice_line");

            }



            if (DateTime.Parse(GridView1.Rows[i].Cells[4].Text) < DateTime.UtcNow)
            {
                khatam.core.data.sql.updateField("virtualServiceStatus", "6", "id", GridView1.Rows[i].Cells[0].Text, "core_invoice_line");
            }


            GridView1.Rows[i].Cells[3].Text = khatam.core.globalization.dateTime.GetPersianDate(DateTime.Parse(GridView1.Rows[i].Cells[3].Text));
            GridView1.Rows[i].Cells[4].Text = khatam.core.globalization.dateTime.GetPersianDate(DateTime.Parse(GridView1.Rows[i].Cells[4].Text));

            GridView1.Rows[i].Cells[5].Text = khatam.shop.invoiceManager.getStatePay(int.Parse(GridView1.Rows[i].Cells[5].Text));
            GridView1.Rows[i].Cells[6].Text = khatam.shop.invoiceManager.getVirtualServiceStatus(int.Parse(GridView1.Rows[i].Cells[6].Text));



            for (int j = 0; j <= 6; j++)
            {
                GridView1.Rows[i].Cells[j].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView1.Rows[i].Cells[j].Text);

            }



        }

    }


    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }


    protected void ImageButton_fillter_Click(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_Modal_gridFilter.Show();
    }
    protected void Button_filter_ok_Click(object sender, EventArgs e)
    {
        string strWhereTemp = " ";
        strWhereTemp = whereGenerator(filter_txt_id, "core_invoice_line.id", " ");
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_domain, "core_invoice_line.domain", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_title, "core_invoice_line.title", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_users_id, "core_invoice.users_id", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_fname, "fname", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_lname, "lname", strWhereTemp);
        strWhereTemp = strWhereTemp + whereGeneratorDate(filter_txt_start_from.PersianDateString, filter_txt_start_to.PersianDateString, "core_invoice_line.start", strWhereTemp, true);
        strWhereTemp = strWhereTemp + whereGeneratorDate(filter_txt_exp_from.PersianDateString, filter_txt_exp_to.PersianDateString, "core_invoice_line.exp", strWhereTemp, true);
        strWhereTemp = strWhereTemp + whereGenerator(filter_txt_invoice_id, "core_invoice.id", strWhereTemp);

        if (strWhereTemp != "")
        {
            ViewState["strWhere"] = /*" WHERE  " +*/ strWhereTemp;
        }
        else
        {
            ViewState["strWhere"] = "";
        }

        string strSyntaxFaTemp = "";

        strSyntaxFaTemp = searchSyntaxGeneratorFa("کد", filter_txt_id.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام دامنه", filter_txt_domain.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("شرح", filter_txt_title.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("کد کاربر", filter_txt_users_id.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام", filter_txt_fname.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("نام خانوادگی", filter_txt_lname.Text, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorDateFa("زمان شروع", filter_txt_start_from.PersianDateString, filter_txt_start_to.PersianDateString, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorDateFa("زمان پایان", filter_txt_exp_from.PersianDateString, filter_txt_exp_to.PersianDateString, strSyntaxFaTemp);
        strSyntaxFaTemp = strSyntaxFaTemp + searchSyntaxGeneratorFa("شماره فاکتور", filter_txt_invoice_id.Text, strSyntaxFaTemp);


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
        string sqlstr = "SELECT     core_invoice_line.id, core_invoice_line.invoice_id, core_invoice_line.price, core_invoice_line.title, core_invoice_line.quantity, core_invoice_line.sum,  " +
                      " core_invoice_line.catid, core_invoice_line.productcode, core_invoice_line.type_content, core_invoice_line.virtual, core_invoice_line.domain, core_invoice_line.exp,  " +
                      " core_invoice.users_id, core_invoice.orderDate, core_invoice.payStatus, core_invoice_line.start, core_invoice_line.virtualServiceStatus " +
" FROM         core_invoice_line INNER JOIN " +
  "                    core_invoice ON core_invoice_line.invoice_id = core_invoice.id " +
" WHERE     (core_invoice_line.type_content = N'domain') AND (core_invoice.users_id = " + khatam.core.Security.Users.login().ToString() + ") " + ViewState["strWhere"] + ViewState["strOrderBy"];



        //string    sqlstr = "SELECT     core_invoice.id, core_invoice.payStatus, core_invoice.sendStatus, core_invoice.orderDate, core_invoice.total_order_price, core_invoice.users_id, users.fname,  users.lname FROM         core_invoice INNER JOIN           users ON core_invoice.users_id = users.id " +
        //             ViewState["strWhere"] + ViewState["strOrderBy"];
        SqlDataSource2.SelectCommand = sqlstr;
        GridView1.DataBind();

    }

    public string whereGenerator(TextBox TxtCtrl, string colName, string parentStr)
    {
        string strWhereTemp = " ";
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
    protected void btn_small_renew_Click(object sender, ImageClickEventArgs e)
    {

        //pAddToShopCart.Controls.Add(ddl_payCycle);
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);
        string str_id = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[0].Text);


        hiddenField.Value = str_id;

        object obj = new object();
        obj = checkRenewRequestIdenentity(str_id, "dddd");

        if (obj == null)
        {


            string catid = khatam.core.data.sql.getField( "catid", "id", str_id, "core_invoice_line");
            ddl_payCycle.DataSource = khatam.core.UI.WebControls.domainSearchWin.getPaycycle_VProducts(catid);
            ddl_payCycle.DataValueField = "id";
            ddl_payCycle.DataTextField = "title";
            ddl_payCycle.Font.Name = "tahoma";
            ddl_payCycle.DataBind();

            UpdatePanel1_Modal_msgRenew.Show();
        }
        else
        {
            Label1.Text = obj.ToString();
            UpdatePanel1_Modal_msgRenewIsDuplicate.Show();
        }


    }
    protected void Button_renew_ok_Click(object sender, EventArgs e)
    {

        int price = int.Parse(khatam.core.data.sql.getField("addToShopCartDomain", "price", "id", ddl_payCycle.SelectedValue, "core_paycycle",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));
        int month = int.Parse(khatam.core.data.sql.getField("addToShopCartDomain", "month", "id", ddl_payCycle.SelectedValue, "core_paycycle",
          khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()));

        khatam.core.Security.Users.user user = new khatam.core.Security.Users.user();
        user = khatam.core.Security.Users.getUser(khatam.core.Security.Users.login().ToString());


        string idRandom = khatam.core.Security.Users.MakePassword(4);

        string invoiceId = invoiceManager.invoiceAdd(0, 0, price.ToString(), idRandom, false,int.Parse( user.id ), ""
        , "", "", "", "", "", user.tel, user.cellphone, "", 0, 0, "0", "0", false, price.ToString());

        DateTime start = DateTime.Parse(khatam.core.data.sql.getField( "exp", "id", hiddenField.Value, "core_invoice_line"));
        string domain = khatam.core.data.sql.getField( "domain", "id", hiddenField.Value, "core_invoice_line");

        string catid = khatam.core.data.sql.getField( "catid", "id", hiddenField.Value, "core_invoice_line");


        invoiceManager.invoiceLineAdd(invoiceId, " تمدید نام دامنه" + domain + " " + ddl_payCycle.SelectedItem.Text, price.ToString(), "1", catid, price.ToString(),
            "domain", "true", domain, month.ToString(), hiddenField.Value, start);
        invoiceManager.sendInfoNeedPay(user.id.ToString(), invoiceId.ToString(), idRandom);

        gridBind();

    }


    /// <summary>
    /// چک می کند که آیا فاکتور منقضی نشده ای هست که والد آن باشد
    /// </summary>
    /// <param name="renewParentId">شماره خط فاکتور والد</param>    
    /// <returns>My result</returns>
    public static object checkRenewRequestIdenentity(string InstanceId, string propertyTitle)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        int invoice_exp = int.Parse(khatam.core.data.sql.getBaseSetting("invoice_exp", "0"));


        parameters.Add("InstanceId", InstanceId);

        parameters.Add("title", propertyTitle);

        str_sql = " SELECT     core_invoice.id " +
        " FROM         core_invoice_line INNER JOIN  " +
        " core_invoice ON core_invoice_line.invoice_id = core_invoice.id  " +
        " WHERE     (core_invoice_line.renewParentId = " + InstanceId + ") AND (core_invoice.orderDate > CONVERT(DATETIME, '" +
        DateTime.UtcNow.AddHours(-invoice_exp).ToString("yyyy/MM/dd HHHH:mmmm:ssss") + "', 102))";




        return DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

    }

    /// <summary>
    /// آیا بچه ای دارد که پرداخت شده باشد
    /// </summary>
    /// <param name="renewParentId">شماره خط فاکتور والد</param>    
    /// <returns>My result</returns>
    public static bool HavePaidChild(string renewParentId)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        parameters.Add("renewParentId", renewParentId);
        parameters.Add("payStatus", 2);

        str_sql = " SELECT      core_invoice_line.id " +
        " FROM         core_invoice_line INNER JOIN " +
        " core_invoice ON core_invoice_line.invoice_id = core_invoice.id " +
        " WHERE     (core_invoice_line.renewParentId = @renewParentId) AND (core_invoice.payStatus = @payStatus) ";

        if ((DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) == null))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    /// <summary>
    /// آیا بچه ای دارد که پرداخت نشده باشد
    /// </summary>
    /// <param name="renewParentId">شماره خط فاکتور والد</param>    
    /// <returns>My result</returns>
    public static bool HaveNotPaidChild(string renewParentId)
    {
        string str_sql;
        Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();

        parameters.Add("renewParentId", renewParentId);
        parameters.Add("payStatus", 2);

        str_sql = " SELECT      core_invoice_line.id " +
        " FROM         core_invoice_line INNER JOIN " +
        " core_invoice ON core_invoice_line.invoice_id = core_invoice.id " +
        " WHERE     (core_invoice_line.renewParentId = @renewParentId) AND (core_invoice.payStatus <> @payStatus) ";

        if ((DBFunctions.ExecuteScaler(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()) == null))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    protected void btn_small_status_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton ibtn1 = sender as ImageButton;
        int rowIndex = Convert.ToInt32(ibtn1.Attributes["RowIndex"]);
        string str_id = khatam.core.globalization.numbers.GetGeorgianNumbers(GridView1.Rows[rowIndex].Cells[0].Text);


        hiddenField.Value = str_id;

        string status = "";

        status = khatam.core.data.sql.getField( "virtualServiceStatus", "id", str_id, "core_invoice_line");
        ddl_status.SelectedValue = status;

        UpdatePanel1_Modal_msgStatus.Show();
    }
    protected void Button_status_ok_Click(object sender, EventArgs e)
    {
        khatam.core.data.sql.updateField("virtualServiceStatus", ddl_status.SelectedValue, "id", hiddenField.Value, "core_invoice_line");
        gridBind();
    }
}