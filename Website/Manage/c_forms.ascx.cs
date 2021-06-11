using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.IO;

public partial class Manage_c_forms : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "فرم ها";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/forms.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " فرم ها";
        l.Text = l.Text + "</span> ";

        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            this.Button1.Enabled = false;
            this.Button1.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.btnFromAdd.Enabled = false;
            this.btnFromAdd.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button4.Enabled = false;
            this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }
        
        
        
        
        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }

        SqlDataSource1.SelectCommand = "SELECT core_serverControls.id, Dictionary_Lang.title FROM core_serverControls INNER JOIN Dictionary_Lang ON core_serverControls.IdDictionary = Dictionary_Lang.id_dictionary WHERE (Dictionary_Lang.id_language = 1) " +khatam.core.UI.ObjectManager.getValidObjectSqlWhere();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();


        
    }



    protected void Button2_Click(object sender, EventArgs e)
    {


        //khatam.core.UI.ObjectManager.objectAdd(this.DropDownList1.SelectedValue.ToString(), this.TextBox1.Text);
        hideWins();
        gridsbind();
        this.MSG2.Visible = true;
       

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("form_name");
        b.Add(txt_edit_title.Text );

        a.Add("form_description");
        b.Add(txt_edit_Description.Text );
        

        khatam.core.data.sql.update(a,b, "fb_forms", "form_id",LblEditCode.Text );
        hideWins();
        gridsbind();
        this.MSG2.Visible = true;



    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.hideWins();
        //this.TextBox1.Text = "";
        this.msgAdd.Visible = true;
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        this.hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        khatam.core.data.sql.delTable("fb_form_" + Label1.Text );

        khatam.core.data.sql.Sql_Del_Row("form_id", Label1.Text, "fb_element_options",
    khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        khatam.core.data.sql.Sql_Del_Row("form_id", Label1.Text, "fb_form_elements",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());




        khatam.core.data.sql.Sql_Del_Row("form_id", Label1.Text, "fb_forms",
            khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        string objectID = khatam.core.data.sql.getField(" id_Core_ServerControlsInstance", "propertyValue", "17", "propertyTitle", "formID", "Core_serverControlsInstanceVal"); //, "propertyValue", Label1.Text, "Core_serverControlsInstanceVal");
        //Label2.Text = objectID;
        khatam.core.UI.ObjectManager.objectDelete(objectID );
        hideWins();
        gridsbind();
    }


  void  hideWins()
    {
        MSG2.Visible=false;
        MSG3.Visible=false;
        msgAdd.Visible = false;
        msgEdit.Visible = false;
             
    }

  void gridsbind()
  {
      GridView2.DataBind();
  }


  protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
  {

  }

    

        protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
  {
    this.GridView2.SelectedIndex =int.Parse( e.CommandArgument.ToString());
      
            
            if (e.CommandName == "del")
      {
          hideWins();
          Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
          this.MSG3.Visible = true;

      }

            if (e.CommandName == "editcom")
            {
                hideWins();
               this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
               khatam.fb_forms.fb_form fb_from = new khatam.fb_forms.fb_form();
                fb_from = khatam.fb_forms.getForm( this.LblEditCode.Text);
                this.txt_edit_title.Text = fb_from.form_name;
                this.txt_edit_Description.Text = fb_from.form_description;
              // this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

                this.msgEdit.Visible = true;

            }

            if (e.CommandName == "editField")
            {
               
               RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                   "manage/default.aspx?mode=formsFieldEdit&id=" +
                this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text);
               

            }

            if (e.CommandName == "entries")
            {
               
               RedirectTo(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath +
                   "manage/?mode=forms_list&id=" +
                this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text);
               

            }

            if (e.CommandName == "sms")
            {

             

            }
            
  }

        private void RedirectTo(string url)
        {
            //url is in pattern "~myblog/mypage.aspx"
            string redirectURL = Page.ResolveClientUrl(url);
            string script = "window.location = '" + redirectURL + "';";
            ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
        }


        protected void btnFromAdd_Click(object sender, EventArgs e)
        {
            //khatam.core.UI.ObjectManager.objectAdd(this.DropDownList1.SelectedValue.ToString(), this.TextBox1.Text);
            ArrayList item = new ArrayList();
            ArrayList value = new ArrayList();

            item.Add("form_name");
            value.Add(txtTitle.Text);

            item.Add("form_description");
            value.Add(txtDescription.Text );

         string form_id =  khatam.core.data.sql.Add(item,value,"fb_forms");
            hideWins();
            gridsbind();
            this.MSG2.Visible = true;


            string str_sql;
            Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();


            //parameters.Add("field_where_value", field_where_value);
            str_sql = " CREATE TABLE [dbo].[fb_form_" + form_id +  "]( " +
	        " [id] [int] IDENTITY(1,1) NOT NULL, " +
	        " [create_date] [datetime] NULL, " +
	        " [update_date] [datetime] NULL, " +
	        " [ip] [nvarchar](16) NULL, " +
            " CONSTRAINT [PK_fb_form_" + form_id + "] PRIMARY KEY CLUSTERED  " +
            " ( " +
	        " [id] ASC " +
            " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] " +
            " ) ON [PRIMARY] ";



            string iid;
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("id_Core_ServerControl");
            b.Add("24");

            a.Add("title");
            b.Add(txtTitle.Text );
            iid = khatam.core.data.sql.AddScope(a, b, "Core_serverControlsInstance");


            DBFunctions.ExecuteNonQuery(str_sql, parameters, System.Data.CommandType.Text, khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()).ToString();

            khatam.core.UI.WebControls.formPlaceHolder fph = new khatam.core.UI.WebControls.formPlaceHolder();
            fph.formID = form_id;
            fph.addInstanceProperty(iid);

        }
}