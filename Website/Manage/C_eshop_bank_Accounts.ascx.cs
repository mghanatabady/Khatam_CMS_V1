using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Manage_C_shop_bank_Accounts : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {


        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "شماره حساب های بانکی";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/account.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " شماره حساب های بانکی";
        l.Text = l.Text + "</span> ";



        string sqlstr = "";


        //GridView2.Columns[10].Visible = false;


        sqlstr = "SELECT   id, cardNo, shabaNo, bankName, accountNo, enable, name FROM         core_Bank_accounts ORDER BY id DESC ";



        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            //    this.Button2.Enabled = false;
            //   this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button4.Enabled = false;
            this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }


        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }


        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.SelectCommand = sqlstr;


    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList();

        a.Add("id");
        b.Add(this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text);
        khatam.core.data.sql.Del(a, b, "users", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString());

        hideWins();
        GridView2.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.Response.Redirect("~/manage/?mode=corePermissionRefUser_list&id=" + this.GridView2.SelectedRow.Cells[0].Text);
    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
    {
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


        if (e.CommandName == "cmdEdit")
        {
            //hideWins();
            //  this.TextBox1.Text =this.GridView2.SelectedIndex.ToString() ;
            // this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            //this.LblEditType.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;
            //int rowIndex = Convert.ToInt32(e.CommandArgument);
            // int id = Convert.ToInt32(GridView2.DataKeys[rowIndex].Value);
            // UpdatePanel1_ModalPopupExtender.Show();

            //GridView2.Visible = false;
            //this.msgEdit.Visible = true;

        }

        /*   this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());

        */
        if (e.CommandName == "cmdDel")
        {

            this.del_lbl_code.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            UpdatePanel1_ModalPopupExtender2.Show(); 
            //hideWins();
            //Label1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            //this.MSG3.Visible = true;

        }

        if (e.CommandName == "cmdPer")
        {
            //this.Response.Redirect("~/manage/?mode=corePermissionRefUser_list&id=" + this.GridView2.SelectedRow.Cells[0].Text);
            RedirectTo("~/manage/?mode=corePermissionRefUser_list&id=" + this.GridView2.SelectedRow.Cells[0].Text);

        }

        if (e.CommandName == "editcom")
        {
            hideWins();
            this.LblEditCode.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[0].Text;
            this.txtEditTitle.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            // this.TextBox1.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

            //  UpdatePanel1_ModalPopupExtender.Show();

        }
    }




    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //  if (e.Row.RowType == DataControlRowType.DataRow)
        // {
        //ExpanseExample.Expanse expanse = e.Row.DataItem as ExpanseExample.Expanse;
        //(e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        // (e.Row.FindControl("lnkEdit") as LinkButton).Attributes.Add("onClick", "ShowEditModal('" + e.Row.Cells[0].Text    + "');");
        //(e.Row.FindControl("lnkDelete") as LinkButton).CommandArgument = e.Row.Cells[0].Text;
        //  }
    }

    void hideWins()
    {
        MSG2.Visible = false;
        MSG3.Visible = false;
        //msgAdd.Visible = false;
        msgEdit.Visible = false;

    }
    khatam.core.UI.WebControls.membrshipWin mw = new khatam.core.UI.WebControls.membrshipWin();



    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {







    }

    private void RedirectTo(string url)
    {
        //url is in pattern "~myblog/mypage.aspx"
        string redirectURL = Page.ResolveClientUrl(url);
        string script = "window.location = '" + redirectURL + "';";
        ScriptManager.RegisterStartupScript(Page, typeof(Page), "RedirectTo", script, true);
    }



    protected void BtnAddOk_Click(object sender, EventArgs e)
    {
        DNA.UI.JQuery.Dialog dialog = new DNA.UI.JQuery.Dialog();

        // membership_form.Controls.Add(dialog); 
    }


    protected void imgbtn_Click(object sender, ImageClickEventArgs e)
    {

        //ImageButton btndetails = sender asImageButton;

        //GridViewRow gvrow = (GridViewRow)btndetails.NamingContainer;

        //lblID.Text = gvdetails.DataKeys[gvrow.RowIndex].Value.ToString();

        //lblusername.Text = gvrow.Cells[1].Text;

        //txtfname.Text = gvrow.Cells[2].Text;

        //txtlname.Text = gvrow.Cells[3].Text;

        //txtCity.Text = gvrow.Cells[4].Text;

        //txtDesg.Text = gvrow.Cells[5].Text;

        //this.ModalPopupExtender1.Show();

    }




    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        UpdatePanel1_ModalPopupExtender.Show();


    }
    protected void msg_ok_Click(object sender, EventArgs e)
    {
        GridView2.Visible = false;
    }
    protected void msgerroIdentity_back_Click(object sender, EventArgs e)
    {
        //  UpdatePanel1_MsgIdentytyError.Hide(); 
        //UpdatePanel1_ModalPopupExtender2.Show();
        //UpdatePanel1_ModalPopupExtender.Show();
        GridView2.Visible = false;
    }
    protected void add_dialog_save_Click(object sender, EventArgs e)
    {

            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("cardNo");
            b.Add(add_txt_cardNo.Text );

            a.Add("shabaNo");
            b.Add(add_txt_shabaNo.Text );

            a.Add("bankName");
            b.Add(add_txt_bankName.Text );

            a.Add("accountNo");
            b.Add(add_txt_accountNo.Text );

            a.Add("name");
            b.Add(add_txt_name.Text );

            khatam.core.data.sql.Add(a, b, "core_Bank_accounts");

            //  khatam.core.email.sendMembershipActive(add_txt_email.Text, EmailSalt);

            UpdatePanel1_ModalPopupExtender3.Show();

            GridView2.DataBind();

            //##this.Page.Response.Redirect(khatam.core.strings.Url.ApplicationPaths.FullyQualifiedApplicationPath + "web/login");
        }
     


      

    
    protected void add2_dialog_save_Click(object sender, EventArgs e)
    {

        ArrayList a = new ArrayList();
        ArrayList b = new ArrayList(); 

        a.Add("id");
        b.Add(del_lbl_code.Text );
        khatam.core.data.sql.Del(a,b,"core_Bank_accounts",khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString()  );  //del_lbl_code
       // UpdatePanel1_ModalPopupExtender.Show();
        GridView2.DataBind();

    }
    protected void Button1112_Click(object sender, EventArgs e)
    {

    }
    protected void Button1112_Click1(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(2000);
    }
}