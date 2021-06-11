using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default37 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        khatam.estate.estateItem _estateItem = new khatam.estate.estateItem();
        _estateItem = khatam.estate.getEstate("6");

        Label1.Text = _estateItem.anbari.ToString() ;
    //    Label1.Text = Label1.Text + _estateItem.bazsaziShode.ToString() +"dddd" ;
        Label1.Text = _estateItem.bazsaziShode.ToString();
    }
}