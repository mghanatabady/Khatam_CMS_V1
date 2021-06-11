using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_c_page_edit_pictureGalley : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        pictureGallery_win1.ClientIDMode = System.Web.UI.ClientIDMode.Static;
        Button2.ClientIDMode = System.Web.UI.ClientIDMode.Static;

        if (this.IsPostBack)
            pictureGallery_win1.Visible = false;

        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        pictureGallery_win1.Visible = true;

    }
    public void  hideWins()
{
        pictureGallery_win1.Visible = false;
    
}
    protected void btn_small_edit_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btn_small_del_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {

    }

    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    //    for (int i = 0; i < GridView1.Rows.Count; i++)
      //  {
         //   for (int j = 0; j <= 7; j++)
       //     {
        //        GridView1.Rows[i].Cells[j].Text = khatam.core.globalization.numbers.GetPersianNumbers(GridView1.Rows[i].Cells[j].Text);
     //       }
        //}



        //  if (e.Row.RowType == DataControlRowType.DataRow)
        // {
        //ExpanseExample.Expanse expanse = e.Row.DataItem as ExpanseExample.Expanse;
        //(e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        // (e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        //(e.Row.FindControl("lnkDelete") as LinkButton).CommandArgument = e.Row.Cells[0].Text;
        //  }
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
}