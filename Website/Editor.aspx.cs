using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Editor : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        int userId = khatam.core.Security.Users.login();
        if (userId  > 0)
        {
            if (khatam.core.Security.Users.validUserPermission(userId.ToString(),"accessVisualContentManager"))
            {
                //TempControl = LoadControl("C_" + this.Request.QueryString["mode"] + ".ascx");
                khatam.core.UI.WebControls.editForm ef = new khatam.core.UI.WebControls.editForm();
                ef.instanceID = this.Page.Request.QueryString["instanceID"];
                PlaceHolder1.Controls.Add(ef);
            }
            else
            {
                PlaceHolder1.Controls.Add(new LiteralControl("عدم دسترسی"));

            }
        }
        else
        {
            PlaceHolder1.Controls.Add(new LiteralControl("عدم دسترسی"));

        }

    }
}