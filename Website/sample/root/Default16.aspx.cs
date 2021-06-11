using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default16 : System.Web.UI.Page
{
    khatam.core.UI.baseControl.GeoSelector gs = new khatam.core.UI.baseControl.GeoSelector();


    protected void Page_Load(object sender, EventArgs e)
    {
       // gs.defaultCityId = 47;
        if (!Page.IsPostBack)
        {
            gs._geo.CountryId = 104;
            gs._geo.EstateId = 8;
            gs._geo.CityId = 120;
            gs._geo.AreaId = 0;
        }
        PlaceHolder1.Controls.Add(gs);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = gs.selectedCountry + " : " + gs.selectedstate + " : " + gs.selectedcity + " : " + gs.selectedarea;
    }
}