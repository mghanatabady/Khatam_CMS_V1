using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Manage_c_forms_list : System.Web.UI.UserControl
{

    string form_id;
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "فرم ها";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/forms.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " >  <a style=\"color: #000000; text-decoration: none;\" href=\"Default.aspx?mode=forms\">فرم ها</a>   > <span style=\" color: #808080\">";
        l.Text = l.Text + " نتایج";
        l.Text = l.Text + "</span> ";

        
        
        form_id = this.Request.QueryString["id"];



        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource1.SelectCommand = "SELECT * FROM [fb_form_" + form_id  + "] ORDER BY [id] DESC";

   //     DataTable dt = new DataTable();
     //   dt= khatam.core.data.sql.getTable("fb_form_" + form_id  );

     //   for (int i = 0; i < dt.Columns.Count; i++)
		//	{
          //      BoundField dcf = new BoundField();
           //     dcf.HeaderText = "test";
            //    dcf.DataField="ip";

//                GridView2.Columns.Add(dcf);
	//		}

    
             
    //    GridView2.DataSource = dt;
       // GridView2.AutoGenerateColumns = true;
     //   GridView2.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "cmd_show")
        {
            this.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath
                + "manage/?mode=forms_item&id_form=" + form_id + "&id_result=" + this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text);
            
            // hideWins();
           // Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
           // this.MSG3.Visible = true;

        }

        if (e.CommandName == "editcom")
        {
           // hideWins();
           // this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
          //  this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
          //  this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

            //this.msgEdit.Visible = true;

        }
    }

}