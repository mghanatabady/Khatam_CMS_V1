using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using khatam.core.globalization;

public partial class Manage_C_shop_trasactions_offline_my : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "تراکنش های آفلاین من";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/Commercial_catalog.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " تراکنش های آفلاین من";
        l.Text = l.Text + "</span> ";


  



        if (this.Page.IsPostBack == false)
        {
           
        }

        SqlDataSource1.SelectCommand = "SELECT core_serverControls.id, Dictionary_Lang.title FROM core_serverControls INNER JOIN Dictionary_Lang ON core_serverControls.IdDictionary = Dictionary_Lang.id_dictionary WHERE (Dictionary_Lang.id_language = 1) " + khatam.core.UI.ObjectManager.getValidObjectSqlWhere();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.SelectCommand = "SELECT     core_transaction.id, core_transaction.idPayMode, core_transaction.idInvoice, core_transaction.idCoreBankAccounts, core_transaction.accontsDesc,  " +
                      " core_transaction.fishNo, core_transaction.FishDateTime, core_transaction.amount, core_transaction.regDate, core_transaction.valid, core_transaction.state " +
" FROM         core_transaction INNER JOIN " +
 "                     core_invoice ON core_transaction.idInvoice = core_invoice.id " +
" WHERE     (core_invoice.users_id = " + khatam.core.Security.Users.login().ToString() + ") order by core_transaction.id desc";


    }





 

    void sendInfoNotValid()
    {

        //khatam.core.email.sendAllPurposeEmail()
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
                GridView2.Rows[i].Cells[7].Text = khatam.shop.invoiceManager.getStateTransaction_Fish(int.Parse(GridView2.Rows[i].Cells[7].Text));
            }

        }

    }




 
}