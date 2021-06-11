using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class Manage_c_theme : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "قالب";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/theme.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " قالب";
        l.Text = l.Text + "</span> ";
        
        
        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            Button1.Enabled = false;
            Button1.ToolTip = "در نسخه دمو این امکان وجود ندارد";
         
        }

        if (Page.IsPostBack == false)
        {



            DirectoryInfo StoreFile = new DirectoryInfo(Server.MapPath("../theme/"));
            DirectoryInfo[] fi;//= new FileInfo("sssssssss");



            //Dim StoreFile As System.IO.Directory


            //Dim Files As String()
            //Dim File As String

            string[] files;
            string file;

            fi = StoreFile.GetDirectories();


            foreach (var item in fi)
            {
                ListItem li = new ListItem();
                li.Text = item.ToString();
                ListBox1.Items.Add(li);
            }

            this.ListBox1.SelectedValue = Khatam_Functions.KUI.setting.setting_base.Get_Setting_base("theme", 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());


        }

//Files = StoreFile.GetFiles("drive:\directory\path\", "*")
//For Each File In Files
//Response.Write(File & "<br>")
//Next
//End Sub

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Khatam_Functions.KUI.setting.setting_base.set_Setting_base("theme", ListBox1.SelectedItem.Text, 0, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "manage/");

    }
}