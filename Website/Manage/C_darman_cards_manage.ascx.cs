using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class Manage_C_darman_cards_manage : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label c = (Label)this.Parent.FindControl("lblMainTitle");
        c.Text = "دارمان : مدیریت کارت ها";

        Image d = (Image)this.Parent.FindControl("imgMainTitle");
        d.ImageUrl = "~/core/themeCP/Bitrix/CssImage/icon/profile.gif";

        Literal l = (Literal)this.Parent.FindControl("Literal1");
        l.Text = " > <span style=\" color: #808080\">";
        l.Text = l.Text + " دارمان : مدیریت کارت ها";
        l.Text = l.Text + "</span> ";

        ltrMsg.Text = khatam.core.Drawing.windows.getSuccessMessage("عنوان خطا!", "متن خطا", true);


        if (khatam.core.ConfigurationManager.License.demo == true)
        {
            this.Button1.Enabled = false;
            this.Button1.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button2.Enabled = false;
            this.Button2.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";
            this.Button4.Enabled = false;
            this.Button4.ToolTip = "این امکان در نسخه نمایشی وجود ندارد";

        }




        if (this.Page.IsPostBack == false)
        {
            hideWins();
        }

        SqlDataSource1.SelectCommand = "SELECT core_serverControls.id, Dictionary_Lang.title FROM core_serverControls INNER JOIN Dictionary_Lang ON core_serverControls.IdDictionary = Dictionary_Lang.id_dictionary WHERE (Dictionary_Lang.id_language = 1) " + khatam.core.UI.ObjectManager.getValidObjectSqlWhere();
        SqlDataSource1.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();
        SqlDataSource2.ConnectionString = khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString();



    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        hideWins();

        try
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("title");
            b.Add(add_txt_title.Text);

            a.Add("price_rls");
            b.Add(add_txt_price_rls.Text);

            khatam.core.data.sql.Add(a, b, "darman_cards_type");

            gridsbind();
            ltrMsg.Text = khatam.core.Drawing.windows.getSuccessMessage("عملیات موفقیت آمیز", "مشخصات مورد نظر شما ثبت گردید", true);



        }
        catch (Exception ex)
        {
            ltrMsg.Text = khatam.core.Drawing.windows.getErrorMessage("خطای سیستمی!", "متاسفانه به دلیل خطای فنی ثبت کارت جدید امکان پذیر نیست، این خطا برای گروه پشتیبانی ارسال گردید", true);

            khatam.core.support.sendEmailToSupport(ex);
            


        }





    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        hideWins();

        try
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();

            a.Add("title");
            b.Add(edit_txt_title.Text);

            a.Add("price_rls");
            b.Add(edit_txt_price_rls.Text);

            if (khatam.core.data.sql.update(a, b, "darman_cards_type", "id", LblEditCode.Text))
            {
                gridsbind();
                ltrMsg.Text = khatam.core.Drawing.windows.getSuccessMessage("عملیات موفقیت آمیز", "مشخصات مورد نظر شما ویرایش گردید", true);

            }
            else
            {
                ltrMsg.Text = khatam.core.Drawing.windows.getErrorMessage("خطای سیستمی!", "متاسفانه به دلیل خطای فنی ثبت کارت جدید امکان پذیر نیست، این خطا برای گروه پشتیبانی ارسال گردید", true);

            }                 


        }
        catch (Exception ex)
        {
            ltrMsg.Text = khatam.core.Drawing.windows.getErrorMessage("خطای سیستمی!", "متاسفانه به دلیل خطای فنی ثبت کارت جدید امکان پذیر نیست، این خطا برای گروه پشتیبانی ارسال گردید", true);

            khatam.core.support.sendEmailToSupport(ex);

        }



    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        this.hideWins();
        this.add_txt_title.Text = "";
        this.add_txt_price_rls.Text = "";
        this.msgAdd.Visible = true;
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        this.hideWins();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
  

        hideWins();

        try
        {
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();
            a.Add("id");
            b.Add(Label1.Text);

            if (bool.Parse(khatam.core.data.sql.Del(a, b, "darman_cards_type", khatam.core.ConfigurationManager.ConnectionStrings.ConnectionString())))
            {
                gridsbind();
                ltrMsg.Text = khatam.core.Drawing.windows.getSuccessMessage("عملیات موفقیت آمیز", "کارت مورد نظر شما حذف گردید", true);

            }
            else
            {
                gridsbind();
                ltrMsg.Text = khatam.core.Drawing.windows.getErrorMessage("عملیات موفقیت آمیز", "کارت مورد نظر شما یافت نگردید", true);
            }

         


        }
        catch (Exception ex)
        {
            ltrMsg.Text = khatam.core.Drawing.windows.getErrorMessage("خطای سیستمی!", "متاسفانه به دلیل خطای فنی امکان حذف مقدور نیست، این خطا برای گروه پشتیبانی ارسال گردید", true);

            khatam.core.support.sendEmailToSupport(ex);

        }


    }


    void hideWins()
    {
        ltrMsg.Text = "";

        MSG2.Visible = false;
        MSG3.Visible = false;
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
        this.GridView2.SelectedIndex = int.Parse(e.CommandArgument.ToString());


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
            this.edit_txt_title.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[1].Text;
            this.edit_txt_price_rls.Text = this.GridView2.Rows[this.GridView2.SelectedIndex].Cells[2].Text;

            this.msgEdit.Visible = true;

        }
    }

}