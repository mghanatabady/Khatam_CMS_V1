using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Install_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    Khatam_Functions.KUI.Explorer.cat hostcat = new Khatam_Functions.KUI.Explorer.cat();
                  
                   
        hostcat.insert_type_content("هاست", "host");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Khatam_Functions.KUI.Explorer.cat hostcat = new Khatam_Functions.KUI.Explorer.cat();

        hostcat.insert_type_content("املاک", "estate");
      //  hostcat.insert_type_content("درخواست  املاک", "estateReg");

    }
}