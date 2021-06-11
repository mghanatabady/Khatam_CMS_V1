using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using khatam.core.globalization;

public partial class Manage_C_shop_trasactions_offline_all : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "تراکنش های آفلاین";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/Commercial_catalog.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " تراکنش های آفلاین";
        l.Text = l.Text + "</span> ";


        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            this.Button1.Enabled = false;
            this.Button1.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button2.Enabled = false;
            this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button4.Enabled = false;
            this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }




        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }

        SqlDataSource1.SelectCommand = "SELECT core_serverControls.id, Dictionary_Lang.title FROM core_serverControls INNER JOIN Dictionary_Lang ON core_serverControls.IdDictionary = Dictionary_Lang.id_dictionary WHERE (Dictionary_Lang.id_language = 1) " + khatam.core.UI.ObjectManager.getValidObjectSqlWhere();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();



    }



    protected void Button2_Click(object sender, EventArgs e)
    {


        //khatam.core.UI.ObjectManager.objectAdd(this.DropDownList1.SelectedValue.ToString(), this.TextBox1.Text);


        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("idPayMode");
        b.Add("3");

        a.Add("idInvoice");
        b.Add(add_txt_invoiceId.Text);

        
        a.Add("accontsDesc");
        b.Add(add_txt_title.Text);

        int amount =int.Parse( this.txt_edit_amount.Text);
        amount = amount * int.Parse(DropDownList1.SelectedValue);

        a.Add("amount");
        b.Add(amount);


        a.Add("regDate");
        b.Add(DateTime.UtcNow.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));

        a.Add("state");
        b.Add(2);

   

        DateTime date_event;
        date_event = Persia.Calendar.ConvertToGregorian(int.Parse(txt_year.Text), int.Parse(txt_month.Text),
        int.Parse(txt_day.Text), Persia.DateType.Persian);
        //Label1.Text = "fff" + date_event.ToString();

        a.Add("FishDateTime");
        b.Add(date_event.ToString("yyyy/MM/dd HHHH:mmmm:ssss"));
        //date_event.ToString("yyyy/MM/dd HHHH:mmmm:ssss")

      /*  a.Add();
        b.Add();
        
        a.Add();
        b.Add();
        
        a.Add();
        b.Add();*/


        khatam.core.data.sql.Add(a,b,"core_transaction");

      khatam.shop.invoiceManager.updateStatus(add_txt_invoiceId.Text);

      //  khatam.shop.invoiceManager.updateStatus("112");

        /*SELECT TOP 1000 [id]
      ,[idPayMode]
      ,[idInvoice]
      ,[idCoreBankAccounts]
      ,[accontsDesc]
      ,[fishNo]
      ,[FishDateTime]
      ,[amount]
      ,[regDate]
      ,[valid]
      ,[state]
  FROM [abzarforoshi].[dbo].[core_transaction]
        */
        hideWins();
        gridsbind();
        this.MSG2.Visible = true;



    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        khatam.core.data.sql.updateField("state", ddl_edit_state.SelectedValue, "id", LblEditCode.Text, "core_transaction", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        if (ddl_edit_state.SelectedValue == "1")
        {
            sendInfoNotValid();
        }


        khatam.shop.invoiceManager.updateStatus(GridView2.Rows[GridView2.SelectedRow.RowIndex].Cells[1].Text);


        hideWins();
        gridsbind();
        this.MSG2.Visible = true;



    }

    void sendInfoNotValid()
    {

       //khatam.core.email.sendAllPurposeEmail()
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.hideWins();
        this.add_txt_title.Text = "";
        this.msgAdd.Visible = true;
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        this.hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //khatam.core.UI.ObjectManager.objectDelete(Label1.Text);
        khatam.core.data.sql.Sql_Del_Row("id", Label1.Text, "core_transaction",
           khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
        khatam.shop.invoiceManager.updateStatus( GridView2.Rows[GridView2.SelectedRow.RowIndex].Cells[1].Text);

        hideWins();
        gridsbind();
    }


    void hideWins()
    {
        MSG2.Visible = false;
        MSG3.Visible = false;
        msgAdd.Visible = false;
        msgEdit.Visible = false;

    }

    void gridsbind()
    {
        GridView2.DataBind();
    }


    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

       protected void gv_sbt_bound(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView2.Rows.Count; i++)
        {
            GridView2.Rows[i].Cells[4].Text = dateTime.GetPersianDate(DateTime.Parse(GridView2.Rows[i].Cells[4].Text));


            if (GridView2.Rows[i].Cells[6].Text != "")
            {
                try
                {
                    GridView2.Rows[i].Cells[6].Text = dateTime.GetPersianDateTime(DateTime.Parse(GridView2.Rows[i].Cells[6].Text));
                }
                catch (Exception)
                {


                }


            }
            if (GridView2.Rows[i].Cells[7].Text != "")
            {
                GridView2.Rows[i].Cells[7].Text =khatam.shop.invoiceManager.getStateTransaction_Fish(int.Parse(GridView2.Rows[i].Cells[7].Text));
            }
            
        }

    }

  


    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "del")
        {
            hideWins();
            Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            this.MSG3.Visible = true;

        }

        if (e.CommandName == "editcom")
        {
            hideWins();
            this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
         //   this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
          //  this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

            this.msgEdit.Visible = true;

        }
    }

    
}