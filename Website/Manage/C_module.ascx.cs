using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_C_module : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "ماژول ها";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/site_explorer.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " ماژول ها";
        l.Text = l.Text + "</span> ";

        this.div_article.Visible = khatam.core.License.ValidModule("article");
        this.div_news.Visible = khatam.core.License.ValidModule("news");
        this.div_domain.Visible = khatam.core.License.ValidModule("domain");
        this.div_host.Visible = khatam.core.License.ValidModule("host");
        this.div_portal.Visible = khatam.core.License.ValidModule("portal");
        this.div_Sample_Exam.Visible = khatam.core.License.ValidModule("sample_exam");        
        this.div_car.Visible = khatam.core.License.ValidModule("car");
        this.div_help.Visible = khatam.core.License.ValidModule("help");
        this.div_shop.Visible = khatam.core.License.ValidModule("shop");
        this.div_school.Visible = khatam.core.License.ValidModule("school");
        this.div_service.Visible = khatam.core.License.ValidModule("service");
        this.div_support.Visible = khatam.core.License.ValidModule("support");
        this.div_link.Visible = khatam.core.License.ValidModule("link");
        this.div_library.Visible = khatam.core.License.ValidModule("library");
        this.div_software.Visible = khatam.core.License.ValidModule("software");
        this.div_picture.Visible = khatam.core.License.ValidModule("picture");
        this.div_clip.Visible = khatam.core.License.ValidModule("clip");
        
    }

 
}