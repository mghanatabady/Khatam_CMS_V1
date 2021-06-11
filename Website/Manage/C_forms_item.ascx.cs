using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_forms_item : System.Web.UI.UserControl


{
    khatam.fb_forms.fb_form fb_form = new khatam.fb_forms.fb_form();


    protected void Page_Load(object sender, EventArgs e)
    {
      //  SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();


        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "فرم ها";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/forms.gif";

        string id_form;
        id_form = this.Request.QueryString["id_form"].ToString();

        string id_result;
        id_result = this.Request.QueryString["id_result"].ToString();

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=forms\">فرم ها</a>  ";
        l.Text = l.Text + " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=forms_list&id=" + id_form  +"\">" + "نتایج فرم شماره " + id_form + "</a>";       
        l.Text = l.Text +" > <span style=\" color: #808080\">";
        l.Text = l.Text + " نتیجه دریافتی شماره " + id_result;
        l.Text = l.Text + "</span> ";


        khatam.core.UI.WebControls.formPlaceHolder fPh = new khatam.core.UI.WebControls.formPlaceHolder();
        fPh.windowsMode = "none";

        fPh.formID = id_form;//this.Request.QueryString["id"];
        fPh.formResultID = id_result;
        fPh.readOnly = true  ;

        PlaceHolder1.Controls.Add(fPh);

    }
}