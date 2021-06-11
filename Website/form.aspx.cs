using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class form : System.Web.UI.Page
{
    khatam.fb_forms.fb_form fb_form = new khatam.fb_forms.fb_form();

    protected void Page_Load(object sender, EventArgs e)
    {

        khatam.core.UI.WebControls.formPlaceHolder fPh = new khatam.core.UI.WebControls.formPlaceHolder();
        fPh.windowsMode = "none";

        fPh.formID = this.Request.QueryString["id"];
        fPh.readOnly = true;

        PlaceHolder1.Controls.Add(fPh);

    }
}